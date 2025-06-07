Imports Microsoft.Data.SqlClient

Public Class Form1
    ' Connection string to the SQL Server instance on Austins-Laptop
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Austi\OneDrive\Documents\ProgramData.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"

    Dim imagePath As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
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
        If txtHiveNumber.SelectedIndex = -1 Then
            MessageBox.Show("Please select a hive number!")
            Exit Sub
        End If

        Using conn As New SqlConnection(connectionString)
            conn.Open()

            Dim query = "INSERT INTO Inspections 
                (InspectionDate, HiveNumber, HiveCondition, BroodPattern, Swarming, QueenStatus, BeePopulation, DronePopulation, 
                 Pests, MiteCount, Treatment, FeedType, FeedAmount, Weather, Temperature, Notes, PhotoPath,
                 Frame1Content, Frame2Content, Frame3Content, Frame4Content, Frame5Content, 
                 Frame6Content, Frame7Content, Frame8Content, Frame9Content, Frame10Content)
                VALUES 
                (@Date, @HiveNumber, @Condition, @Brood, @Swarming, @Queen, @Bees, @Drones, 
                 @Pests, @Mites, @Treatment, @FeedType, @FeedAmt, @Weather, @Temp, @Notes, @Photo,
                 @Frame1, @Frame2, @Frame3, @Frame4, @Frame5, 
                 @Frame6, @Frame7, @Frame8, @Frame9, @Frame10)"

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

            ' Frame dropdowns
            cmd.Parameters.AddWithValue("@Frame1", cboFrame1.Text)
            cmd.Parameters.AddWithValue("@Frame2", cboFrame2.Text)
            cmd.Parameters.AddWithValue("@Frame3", cboFrame3.Text)
            cmd.Parameters.AddWithValue("@Frame4", cboFrame4.Text)
            cmd.Parameters.AddWithValue("@Frame5", cboFrame5.Text)
            cmd.Parameters.AddWithValue("@Frame6", cboFrame6.Text)
            cmd.Parameters.AddWithValue("@Frame7", cboFrame7.Text)
            cmd.Parameters.AddWithValue("@Frame8", cboFrame8.Text)
            cmd.Parameters.AddWithValue("@Frame9", cboFrame9.Text)
            cmd.Parameters.AddWithValue("@Frame10", cboFrame10.Text)

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
        txtHiveNumber.SelectedIndex = -1
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

        ' Clear frame combo boxes
        cboFrame1.SelectedIndex = -1
        cboFrame2.SelectedIndex = -1
        cboFrame3.SelectedIndex = -1
        cboFrame4.SelectedIndex = -1
        cboFrame5.SelectedIndex = -1
        cboFrame6.SelectedIndex = -1
        cboFrame7.SelectedIndex = -1
        cboFrame8.SelectedIndex = -1
        cboFrame9.SelectedIndex = -1
        cboFrame10.SelectedIndex = -1
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
        cmbHiveFilter.Items.Clear()
        txtHiveNumber.Items.Clear()

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT ApiaryName, NumberOfHives FROM Apiaries", conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim apiaryName As String = reader("ApiaryName").ToString()
                Dim hives As Integer = Convert.ToInt32(reader("NumberOfHives"))

                For i As Integer = 1 To hives
                    Dim hiveName As String = $"{apiaryName} - Hive {i}"
                    cmbHiveFilter.Items.Add(hiveName)
                    txtHiveNumber.Items.Add(hiveName)
                Next
            End While
        End Using
    End Sub

    Private Sub btnOpenWeather_Click(sender As Object, e As EventArgs) Handles btnOpenWeather.Click
        Dim weatherForm As New FormWeather()
        weatherForm.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTerm As String = txtSearch.Text.Trim()

        If String.IsNullOrEmpty(searchTerm) Then
            MessageBox.Show("Please enter a search term.")
            Return
        End If

        Dim query As String = "SELECT Title, Content FROM WikiEntries WHERE Content LIKE @searchTerm"
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
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

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Dim settingsForm As New FormSettings()
        settingsForm.ShowDialog()
    End Sub

    Private Sub cmbHiveFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHiveFilter.SelectedIndexChanged
        ' Nothing needed here (for now)
    End Sub

    Private Sub btnWiki_Click(sender As Object, e As EventArgs) Handles btnWiki.Click
        Dim wikiForm As New WikiForm()
        wikiForm.Show()
    End Sub

    Private Sub TabPageForm_Click(sender As Object, e As EventArgs) Handles TabPageForm.Click
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
    End Sub

    Private Sub cboFrame4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFrame4.SelectedIndexChanged
    End Sub

    Private Sub TabPageRecords_Click(sender As Object, e As EventArgs) Handles TabPageRecords.Click

    End Sub
End Class
