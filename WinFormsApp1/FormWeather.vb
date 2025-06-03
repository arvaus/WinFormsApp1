Imports System.IO
Imports System.Net.Http
Imports Microsoft.Data.SqlClient
Imports Newtonsoft.Json.Linq

Public Class FormWeather
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Austi\OneDrive\Documents\ProgramData.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"

    ' Define the image path
    Dim imagesPath As String = "C:\Users\Austi\OneDrive\Desktop\BeeHeaven\app\WinFormsApp1\WinFormsApp1\Images\"

    ' Check if the system is online when the form loads
    Private Sub FormWeather_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        If IsOnline() Then
            ' Fetch and update weather data for the first apiary or selected apiary
            If cmbApiarySelection.Items.Count > 0 Then
                cmbApiarySelection.SelectedIndex = 0 ' Default to first apiary
                FetchWeatherForSelectedApiary() ' Fetch weather for the first apiary
            End If
        Else
            MessageBox.Show("You are offline. Weather data cannot be updated.")
        End If

        ' Load the apiary names into the dropdown
        LoadApiaryNames()
    End Sub

    ' Function to check if the system is online
    Private Function IsOnline() As Boolean
        Try
            ' Try to access a known website (Google in this case)
            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromSeconds(5) ' Timeout after 5 seconds
                Dim response As HttpResponseMessage = client.GetAsync("https://www.google.com").Result
                Return response.IsSuccessStatusCode
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    ' Load the apiary names into the dropdown list
    Private Sub LoadApiaryNames()
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' Get all apiaries
            Dim query As String = "SELECT ApiaryName FROM Apiaries"
            Dim cmd As New SqlCommand(query, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                cmbApiarySelection.Items.Add(reader("ApiaryName").ToString())
            End While
        End Using
    End Sub

    ' Event handler for when the selected apiary changes in the dropdown
    Private Sub cmbApiarySelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbApiarySelection.SelectedIndexChanged
        ' Fetch weather for the selected apiary
        FetchWeatherForSelectedApiary()
    End Sub

    ' Fetch weather data for the selected apiary
    Private Sub FetchWeatherForSelectedApiary()
        ' Get the selected apiary name from the dropdown
        Dim selectedApiary As String = cmbApiarySelection.SelectedItem.ToString()

        ' Get the coordinates for the selected apiary from the database
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' Query to get coordinates for the selected apiary
            Dim query As String = "SELECT Coordinates FROM Apiaries WHERE ApiaryName = @ApiaryName"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ApiaryName", selectedApiary)

            Dim coordinates As String = Convert.ToString(cmd.ExecuteScalar())

            ' Assuming coordinates are stored as "latitude,longitude"
            Dim latLon As String() = coordinates.Split(","c)
            If latLon.Length = 2 Then
                Dim latitude As String = latLon(0).Trim()
                Dim longitude As String = latLon(1).Trim()

                ' Fetch and update weather for the selected apiary
                FetchWeatherDataAndSave(selectedApiary, latitude, longitude)
            End If
        End Using
    End Sub

    ' Fetch weather data for a specific apiary and save it
    Private Async Function FetchWeatherDataAndSave(apiaryName As String, latitude As String, longitude As String) As Task
        ' Set up the URL for NOAA API
        Dim url As String = $"https://api.weather.gov/points/{latitude},{longitude}"

        ' Create a new HttpClient instance
        Dim client As New HttpClient()
        client.DefaultRequestHeaders.Add("User-Agent", "BeeHeavenWeatherApp/1.0 (contact@myweatherapp.com)")

        Try
            ' Send the request and get the response
            Dim response As HttpResponseMessage = Await client.GetAsync(url)

            ' If the response is successful, parse the weather data
            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                ' Parse the JSON response
                Dim data As JObject = JObject.Parse(jsonResponse)

                ' Extract forecast URL from the NOAA response
                Dim forecastUrl As String = data("properties")("forecast").ToString()

                ' Fetch the detailed forecast using the forecast URL
                Dim forecastResponse As HttpResponseMessage = Await client.GetAsync(forecastUrl)
                If forecastResponse.IsSuccessStatusCode Then
                    Dim forecastJsonResponse As String = Await forecastResponse.Content.ReadAsStringAsync()
                    Dim forecastData As JObject = JObject.Parse(forecastJsonResponse)

                    ' Extract the temperature and weather description from the forecast data
                    Dim temperature As Double = forecastData("properties")("periods")(0)("temperature")
                    Dim weatherDescription As String = forecastData("properties")("periods")(0)("shortForecast").ToString()

                    ' Update the UI elements (e.g., labels, weather details, and weather image)
                    UpdateWeatherUI(weatherDescription, temperature)

                    ' Save the weather data to the database
                    SaveWeatherData(apiaryName, weatherDescription, temperature.ToString())
                Else
                    ' Handle forecast fetch error
                    MessageBox.Show($"Error fetching forecast for {apiaryName}. Status Code: {forecastResponse.StatusCode.ToString()}")
                End If
            Else
                ' Handle initial fetch error
                MessageBox.Show($"Error fetching data for {apiaryName}. Status Code: {response.StatusCode.ToString()}")
            End If
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show($"Error fetching weather data for {apiaryName}: {ex.Message}")
        End Try
    End Function

    ' Update the UI with weather description, temperature, and weather image
    Private Sub UpdateWeatherUI(weatherDescription As String, temperature As Double)
        ' Update the labels with the fetched weather data
        lblWeather.Text = "Weather: " & weatherDescription
        lblTemperature.Text = "Temperature: " & temperature.ToString() & "°F"

        ' Update the weather details textbox with more information
        txtWeatherDetails.Text = $"Description: {weatherDescription}" & Environment.NewLine &
                                 $"Temperature: {temperature}°F"

        ' Update the weather image based on the weather description
        UpdateWeatherImage(weatherDescription)
    End Sub

    ' Update the weather image based on the weather description
    Private Sub UpdateWeatherImage(weatherDescription As String)
        ' Clear the previous image
        picWeather.Image = Nothing

        ' Based on the weather description, choose an appropriate image
        Select Case weatherDescription.ToLower()
            Case "clear"
                picWeather.Image = Image.FromFile(Path.Combine(imagesPath, "clear_sky.jpg"))
            Case "cloudy"
                picWeather.Image = Image.FromFile(Path.Combine(imagesPath, "cloudy.jpg"))
            Case "rain"
                picWeather.Image = Image.FromFile(Path.Combine(imagesPath, "rain.jpg"))
            Case "snow"
                picWeather.Image = Image.FromFile(Path.Combine(imagesPath, "snow.jpg"))
            Case Else
                picWeather.Image = Image.FromFile(Path.Combine(imagesPath, "default_weather.jpg"))
        End Select
    End Sub

    ' Save the weather data to the database
    Private Sub SaveWeatherData(apiaryName As String, weatherDescription As String, temperature As String)
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' Check if weather data already exists for the selected apiary
            Dim query As String = "IF EXISTS (SELECT 1 FROM ApiaryWeather WHERE ApiaryName = @ApiaryName)
                                    UPDATE ApiaryWeather SET Weather = @Weather, Temperature = @Temperature, Date = @Date
                                    WHERE ApiaryName = @ApiaryName
                                    ELSE
                                    INSERT INTO ApiaryWeather (ApiaryName, Weather, Temperature, Date)
                                    VALUES (@ApiaryName, @Weather, @Temperature, @Date)"

            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ApiaryName", apiaryName)
            cmd.Parameters.AddWithValue("@Weather", weatherDescription)
            cmd.Parameters.AddWithValue("@Temperature", temperature)
            cmd.Parameters.AddWithValue("@Date", DateTime.Now)

            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class
