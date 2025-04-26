Imports Microsoft.Data.SqlClient
Imports System.IO
Imports System.Data
Public Class Form1
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Austi\OneDrive\Desktop\BeeHeaven\app\WinFormsApp1\WinFormsApp1\HiveInspections.mdf;Integrated Security=True"
    Dim imagePath As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInspections()
        LoadHiveNumbers()
    End Sub



    Private Sub btnUploadPhoto_Click(sender As Object, e As EventArgs) Handles btnUploadPhoto.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg;*.bmp"
        If ofd.ShowDialog = DialogResult.OK Then
            imagePath = ofd.FileName
            picPreview.Image = Image.FromFile(imagePath)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            Dim query = "INSERT INTO Inspections 
            (InspectionDate, HiveNumber, HiveCondition, BroodPattern, Swarming, QueenStatus, BeePopulation, DronePopulation, 
             Pests, MiteCount, Treatment, FeedType, FeedAmount, Weather, Temperature, Notes, PhotoPath) 
            VALUES 
            (@Date, @HiveNumber, @Condition, @Brood, @Swarming, @Queen, @Bees, @Drones, 
             @Pests, @Mites, @Treatment, @FeedType, @FeedAmt, @Weather, @Temp, @Notes, @Photo)"

            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Date", dtpDate.Value)
            cmd.Parameters.AddWithValue("@HiveNumber", txtHiveNumber.Text)
            cmd.Parameters.AddWithValue("@Condition", txtHiveCondition.Text)
            cmd.Parameters.AddWithValue("@Brood", txtBroodPattern.Text)
            cmd.Parameters.AddWithValue("@Swarming", chkSwarming.Checked)
            cmd.Parameters.AddWithValue("@Queen", txtQueenStatus.Text)
            cmd.Parameters.AddWithValue("@Bees", txtBeePopulation.Text)
            cmd.Parameters.AddWithValue("@Drones", txtDronePopulation.Text)
            cmd.Parameters.AddWithValue("@Pests", txtPests.Text)
            cmd.Parameters.AddWithValue("@Mites", txtMiteCount.Text)
            cmd.Parameters.AddWithValue("@Treatment", txtTreatment.Text)
            cmd.Parameters.AddWithValue("@FeedType", txtFeedType.Text)
            cmd.Parameters.AddWithValue("@FeedAmt", txtFeedAmount.Text)
            cmd.Parameters.AddWithValue("@Weather", txtWeather.Text)
            cmd.Parameters.AddWithValue("@Temp", txtTemperature.Text)
            cmd.Parameters.AddWithValue("@Notes", txtNotes.Text)
            cmd.Parameters.AddWithValue("@Photo", imagePath)

            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Inspection saved!")
        LoadInspections()
        ClearForm()
    End Sub

    Private Sub LoadInspections()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM Inspections ORDER BY InspectionDate DESC"
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvRecords.DataSource = table
        End Using
    End Sub

    Private Sub ClearForm()
        txtHiveNumber.Clear()
        txtHiveCondition.Clear()
        txtBroodPattern.Clear()
        chkSwarming.Checked = False
        txtQueenStatus.Clear()
        txtBeePopulation.Clear()
        txtDronePopulation.Clear()
        txtPests.Clear()
        txtMiteCount.Clear()
        txtTreatment.Clear()
        txtFeedType.Clear()
        txtFeedAmount.Clear()
        txtWeather.Clear()
        txtTemperature.Clear()
        txtNotes.Clear()
        picPreview.Image = Nothing
        imagePath = ""
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim hiveNumber As String = cmbHiveFilter.Text.Trim()

        Using conn As New SqlConnection(connectionString)
            conn.Open()

            Dim query As String = "SELECT * FROM Inspections WHERE HiveNumber = @HiveNumber"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@HiveNumber", hiveNumber)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvRecords.DataSource = table
        End Using
    End Sub

    Private Sub LoadHiveNumbers()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT DISTINCT HiveNumber FROM Inspections", conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cmbHiveFilter.Items.Add(reader("HiveNumber").ToString())
            End While
        End Using
    End Sub

    Private Sub btnOpenWeather_Click(sender As Object, e As EventArgs) Handles btnOpenWeather.Click
        ' Create an instance of FormWeather and show it
        Dim weatherForm As New FormWeather()
        weatherForm.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTerm As String = txtSearch.Text.Trim()

        If String.IsNullOrEmpty(searchTerm) Then
            MessageBox.Show("Please enter a search term.")
            Return
        End If

        ' Query the database to search for content that matches the search term
        Dim query As String = "SELECT Title, Content FROM WikiEntries WHERE Content LIKE @searchTerm"
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%") ' % adds wildcards for partial matches
            conn.Open()

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                txtWikiContent.Text = "Title: " & reader("Title").ToString() & vbCrLf & vbCrLf & reader("Content").ToString()
            Else
                txtWikiContent.Text = "No results found."
            End If
        End Using
    End Sub
End Class


