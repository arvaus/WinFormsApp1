Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms

Public Module WeatherManager

    ' Create a static HttpClient to reuse across requests
    Private ReadOnly client As New HttpClient()

    Public Async Function FetchWeather(latitude As String, longitude As String) As Task(Of String)
        Try
            ' Step 1: Get the forecast URL for the coordinates
            Dim pointUrl As String = $"https://api.weather.gov/points/{latitude},{longitude}"
            Dim pointData As String = Await client.GetStringAsync(pointUrl)

            Dim pointJson As JObject = JObject.Parse(pointData)
            Dim forecastUrl As String = pointJson("properties")("forecast").ToString()

            ' Step 2: Get the actual forecast data
            Dim forecastData As String = Await client.GetStringAsync(forecastUrl)
            Return forecastData

        Catch ex As Exception
            MessageBox.Show("Error fetching weather data: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Async Function FetchHourlyForecast(latitude As String, longitude As String) As Task(Of String)
        Try
            ' Step 1: Get the forecast hourly URL for the coordinates
            Dim pointUrl As String = $"https://api.weather.gov/points/{latitude},{longitude}"
            Dim pointData As String = Await client.GetStringAsync(pointUrl)

            Dim pointJson As JObject = JObject.Parse(pointData)
            Dim hourlyUrl As String = pointJson("properties")("forecastHourly").ToString()

            ' Step 2: Get the hourly forecast data
            Dim hourlyData As String = Await client.GetStringAsync(hourlyUrl)
            Return hourlyData

        Catch ex As Exception
            MessageBox.Show("Error fetching hourly data: " & ex.Message)
            Return Nothing
        End Try
    End Function

End Module
