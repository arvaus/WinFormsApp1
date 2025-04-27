Imports System.Data.SqlClient
Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Microsoft.Data.SqlClient

Public Class FormSettings
    ' Connection string to your SQL database
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Austi\OneDrive\Documents\ProgramData.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"


    ' Constructor for FormSettings (if any initialization is needed)
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Example: Method to save settings, such as Apiary address and number of hives
    Private Async Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        ' Get values from user inputs like textboxes
        Dim apiaryName As String = txtApiaryName.Text.Trim()
        Dim apiaryAddress As String = txtApiaryAddress.Text.Trim()
        Dim numOfHives As Integer

        ' Validate number of hives input
        If Not Integer.TryParse(txtNumberOfHives.Text.Trim(), numOfHives) Then
            MessageBox.Show("Please enter a valid number of hives.")
            Return
        End If

        ' Convert the address to lat/long using OpenCage Geocoding API
        Dim coordinates As String = Await GetCoordinates(apiaryAddress)

        ' Save data into the database
        If String.IsNullOrEmpty(coordinates) Then
            MessageBox.Show("Unable to retrieve coordinates. Please check the address.")
            Return
        End If

        ' Insert the data into the database
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "INSERT INTO Apiaries (ApiaryName, NumberOfHives, Address, Coordinates) VALUES (@ApiaryName, @NumOfHives, @Address, @Coordinates)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ApiaryName", apiaryName)
            cmd.Parameters.AddWithValue("@NumOfHives", numOfHives)
            cmd.Parameters.AddWithValue("@Address", apiaryAddress)
            cmd.Parameters.AddWithValue("@Coordinates", coordinates)
            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Settings saved successfully!")
        Me.Close()
    End Sub

    ' Method to get coordinates using OpenCage Geocoding API (Async version)
    Private Async Function GetCoordinates(apiaryAddress As String) As Task(Of String)
        Try
            ' Replace with your actual OpenCage API key
            Dim apiKey As String = "2a5b84d3bc4845779fadb5f99853101e"
            Dim encodedAddress As String = Uri.EscapeDataString(apiaryAddress)
            Dim url As String = $"https://api.opencagedata.com/geocode/v1/json?q={encodedAddress}&key={apiKey}"

            ' Use HttpClient to make the HTTP request
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync(url)
                If response.IsSuccessStatusCode Then
                    ' Read and parse the response as JSON
                    Dim responseJson As String = Await response.Content.ReadAsStringAsync()
                    Dim geocodeResult = JsonConvert.DeserializeObject(Of OpenCageResponse)(responseJson)

                    ' Check if the API returned results
                    If geocodeResult.status.code = 200 AndAlso geocodeResult.results.Count > 0 Then
                        ' Get the latitude and longitude from the first result
                        Dim latitude As String = geocodeResult.results(0).geometry.lat.ToString()
                        Dim longitude As String = geocodeResult.results(0).geometry.lng.ToString()

                        ' Return the coordinates as a string
                        Return $"{latitude},{longitude}"
                    End If
                End If
            End Using
        Catch ex As Exception
            ' Handle any errors (e.g., network issues)
            MessageBox.Show("Error while fetching coordinates: " & ex.Message)
            Return String.Empty
        End Try

        ' Return empty string if no results
        Return String.Empty
    End Function

    Private Sub txtNumberOfHives_ValueChanged(sender As Object, e As EventArgs) Handles txtNumberOfHives.ValueChanged

    End Sub
End Class

' OpenCage API response classes
Public Class OpenCageResponse
    Public Property status As OpenCageStatus
    Public Property results As List(Of OpenCageResult)
End Class

Public Class OpenCageStatus
    Public Property code As Integer
    Public Property message As String
End Class

Public Class OpenCageResult
    Public Property geometry As OpenCageGeometry
End Class

Public Class OpenCageGeometry
    Public Property lat As Double
    Public Property lng As Double
End Class
