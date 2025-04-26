Imports System.IO

Public Class Form2
    Dim locationSettingsPath As String = "location_settings.txt"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(locationSettingsPath) Then
            Dim lines = File.ReadAllLines(locationSettingsPath)
            If lines.Length >= 2 Then
                txtLat.Text = lines(0)
                txtLon.Text = lines(1)
            End If
        End If
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        Try
            Dim lat As String = txtLat.Text.Trim()
            Dim lon As String = txtLon.Text.Trim()

            If lat = "" OrElse lon = "" Then
                MessageBox.Show("Please enter both latitude and longitude.")
                Return
            End If

            ' Save the settings to a text file
            File.WriteAllLines(locationSettingsPath, {lat, lon})
            MessageBox.Show("Location settings saved.")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error saving settings: " & ex.Message)
        End Try
    End Sub
End Class
