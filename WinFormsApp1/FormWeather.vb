Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class FormWeather
    ' Controls Declaration
    ' Make sure you have these controls on the form:
    ' - txtLatitude (TextBox to enter latitude)
    ' - txtLongitude (TextBox to enter longitude)
    ' - txtWeatherDetails (TextBox or RichTextBox to show weather data)
    ' - progressBar (ProgressBar for showing loading state)
    ' - btnFetchWeather (Button to fetch the weather)
    ' - btnClose (Button to close the form)
    ' - lblLatitude (Label to display latitude)
    ' - lblLongitude (Label to display longitude)
    ' - lblTemperature (Label to display temperature)
    ' - lblWeather (Label to display weather status)
    ' - picWeather (PictureBox to display corresponding weather image)

    ' Handles the click of the Fetch Weather button
    Private Sub btnFetchWeather_Click(sender As Object, e As EventArgs) Handles btnFetchWeather.Click
        ' Show the progress bar and start fetching the data
        progressBar.Visible = True
        progressBar.Value = 0 ' Reset the progress bar
        progressBar.Style = ProgressBarStyle.Marquee ' Make it indeterminate (loading)

        ' Get latitude and longitude from the textboxes
        Dim latitude As String = txtLatitude.Text
        Dim longitude As String = txtLongitude.Text

        ' Fetch weather data from NOAA API
        FetchWeatherData(latitude, longitude)
    End Sub

    ' Fetch weather data and update the UI
    Private Async Sub FetchWeatherData(latitude As String, longitude As String)
        ' Set up the URL for NOAA API (use NWS endpoint for forecast data)
        Dim url As String = $"https://api.weather.gov/points/{latitude},{longitude}"

        ' Create a new HttpClient instance
        Dim client As New HttpClient()

        ' Add a properly formatted User-Agent header to the request
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

                    ' Update the labels with the fetched weather data
                    lblLatitude.Text = "Latitude: " & latitude
                    lblLongitude.Text = "Longitude: " & longitude
                    lblWeather.Text = "Weather: " & weatherDescription
                    lblTemperature.Text = "Temperature: " & temperature.ToString() & "°F"

                    ' Update the weather image based on the weather description
                    UpdateWeatherImage(weatherDescription)
                Else
                    ' Log the status code for debugging
                    txtWeatherDetails.Text = $"Error fetching forecast. Status Code: {forecastResponse.StatusCode.ToString()}"
                End If
            Else
                ' Log the status code for debugging
                txtWeatherDetails.Text = $"Error fetching data. Status Code: {response.StatusCode.ToString()}"
            End If
        Catch ex As Exception
            ' Handle any errors that occur during the request
            txtWeatherDetails.Text = "Error: " & ex.Message
        End Try

        ' Hide the progress bar when done
        progressBar.Visible = False
    End Sub

    ' Updates the PictureBox with a weather image based on the weather description
    Private Sub UpdateWeatherImage(weatherDescription As String)
        ' Clear the previous image
        picWeather.Image = Nothing

        ' Get the path for the images in the Images folder of the project
        Dim imagesPath As String = Path.Combine(Application.StartupPath, "Images")

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

    ' Handles the click of the Close button (closes the form)
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FormWeather_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
