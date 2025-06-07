<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TabControl1 = New TabControl()
        TabPageForm = New TabPage()
        btnWiki = New Button()
        btnAddFile = New Button()
        lvFiles = New ListView()
        FileType = New ColumnHeader()
        FilePath = New ColumnHeader()
        txtHiveNumber = New ComboBox()
        btnSettings = New Button()
        btnOpenWeather = New Button()
        txtPests = New TextBox()
        Label14 = New Label()
        txtTreatment = New TextBox()
        Label13 = New Label()
        btnSave = New Button()
        Label12 = New Label()
        txtNotes = New TextBox()
        btnUploadPhoto = New Button()
        picPreview = New PictureBox()
        txtTemperature = New TextBox()
        Label11 = New Label()
        txtWeather = New TextBox()
        Label10 = New Label()
        txtFeedAmount = New TextBox()
        Label9 = New Label()
        txtFeedType = New TextBox()
        Treatments = New Label()
        txtMiteCount = New TextBox()
        Label8 = New Label()
        txtDronePopulation = New TextBox()
        Label7 = New Label()
        txtBeePopulation = New TextBox()
        Label6 = New Label()
        txtQueenStatus = New TextBox()
        Label5 = New Label()
        chkSwarming = New CheckBox()
        txtBroodPattern = New TextBox()
        Label4 = New Label()
        txtHiveCondition = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        dtpDate = New DateTimePicker()
        Panel4 = New Panel()
        Panel5 = New Panel()
        cboFrame2 = New ComboBox()
        Panel6 = New Panel()
        cboFrame3 = New ComboBox()
        Panel7 = New Panel()
        cboFrame4 = New ComboBox()
        Panel8 = New Panel()
        cboFrame5 = New ComboBox()
        Panel9 = New Panel()
        cboFrame6 = New ComboBox()
        Panel10 = New Panel()
        cboFrame7 = New ComboBox()
        Panel11 = New Panel()
        cboFrame8 = New ComboBox()
        Panel12 = New Panel()
        cboFrame9 = New ComboBox()
        Panel13 = New Panel()
        cboFrame10 = New ComboBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        cboFrame1 = New ComboBox()
        TabPageRecords = New TabPage()
        btnFilter = New Button()
        cmbHiveFilter = New ComboBox()
        dgvRecords = New DataGridView()
        TabPageBeePlants = New TabPage()
        txtWikiContent = New RichTextBox()
        btnSearch = New Button()
        txtSearch = New TextBox()
        OpenFileDialog = New OpenFileDialog()
        Panel1 = New Panel()
        TabControl1.SuspendLayout()
        TabPageForm.SuspendLayout()
        CType(picPreview, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        Panel11.SuspendLayout()
        Panel12.SuspendLayout()
        Panel13.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        TabPageRecords.SuspendLayout()
        CType(dgvRecords, ComponentModel.ISupportInitialize).BeginInit()
        TabPageBeePlants.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPageForm)
        TabControl1.Controls.Add(TabPageRecords)
        TabControl1.Controls.Add(TabPageBeePlants)
        TabControl1.Location = New Point(86, 3)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1023, 1997)
        TabControl1.TabIndex = 0
        ' 
        ' TabPageForm
        ' 
        TabPageForm.AutoScroll = True
        TabPageForm.BackgroundImage = CType(resources.GetObject("TabPageForm.BackgroundImage"), Image)
        TabPageForm.BackgroundImageLayout = ImageLayout.Stretch
        TabPageForm.Controls.Add(btnWiki)
        TabPageForm.Controls.Add(btnAddFile)
        TabPageForm.Controls.Add(lvFiles)
        TabPageForm.Controls.Add(txtHiveNumber)
        TabPageForm.Controls.Add(btnSettings)
        TabPageForm.Controls.Add(btnOpenWeather)
        TabPageForm.Controls.Add(txtPests)
        TabPageForm.Controls.Add(Label14)
        TabPageForm.Controls.Add(txtTreatment)
        TabPageForm.Controls.Add(Label13)
        TabPageForm.Controls.Add(btnSave)
        TabPageForm.Controls.Add(Label12)
        TabPageForm.Controls.Add(txtNotes)
        TabPageForm.Controls.Add(btnUploadPhoto)
        TabPageForm.Controls.Add(picPreview)
        TabPageForm.Controls.Add(txtTemperature)
        TabPageForm.Controls.Add(Label11)
        TabPageForm.Controls.Add(txtWeather)
        TabPageForm.Controls.Add(Label10)
        TabPageForm.Controls.Add(txtFeedAmount)
        TabPageForm.Controls.Add(Label9)
        TabPageForm.Controls.Add(txtFeedType)
        TabPageForm.Controls.Add(Treatments)
        TabPageForm.Controls.Add(txtMiteCount)
        TabPageForm.Controls.Add(Label8)
        TabPageForm.Controls.Add(txtDronePopulation)
        TabPageForm.Controls.Add(Label7)
        TabPageForm.Controls.Add(txtBeePopulation)
        TabPageForm.Controls.Add(Label6)
        TabPageForm.Controls.Add(txtQueenStatus)
        TabPageForm.Controls.Add(Label5)
        TabPageForm.Controls.Add(chkSwarming)
        TabPageForm.Controls.Add(txtBroodPattern)
        TabPageForm.Controls.Add(Label4)
        TabPageForm.Controls.Add(txtHiveCondition)
        TabPageForm.Controls.Add(Label3)
        TabPageForm.Controls.Add(Label2)
        TabPageForm.Controls.Add(Label1)
        TabPageForm.Controls.Add(dtpDate)
        TabPageForm.Controls.Add(Panel4)
        TabPageForm.Location = New Point(4, 29)
        TabPageForm.Name = "TabPageForm"
        TabPageForm.Padding = New Padding(3)
        TabPageForm.Size = New Size(1015, 1964)
        TabPageForm.TabIndex = 0
        TabPageForm.Text = "New Inspection"
        TabPageForm.UseVisualStyleBackColor = True
        ' 
        ' btnWiki
        ' 
        btnWiki.Image = CType(resources.GetObject("btnWiki.Image"), Image)
        btnWiki.Location = New Point(834, 97)
        btnWiki.Name = "btnWiki"
        btnWiki.Size = New Size(103, 31)
        btnWiki.TabIndex = 40
        btnWiki.UseVisualStyleBackColor = True
        ' 
        ' btnAddFile
        ' 
        btnAddFile.Location = New Point(622, 1055)
        btnAddFile.Name = "btnAddFile"
        btnAddFile.Size = New Size(94, 29)
        btnAddFile.TabIndex = 39
        btnAddFile.Text = "Add File"
        btnAddFile.UseVisualStyleBackColor = True
        ' 
        ' lvFiles
        ' 
        lvFiles.Columns.AddRange(New ColumnHeader() {FileType, FilePath})
        lvFiles.Location = New Point(622, 928)
        lvFiles.Name = "lvFiles"
        lvFiles.Size = New Size(151, 121)
        lvFiles.TabIndex = 38
        lvFiles.UseCompatibleStateImageBehavior = False
        lvFiles.View = View.Details
        ' 
        ' FileType
        ' 
        FileType.Text = "File Type"
        ' 
        ' FilePath
        ' 
        FilePath.Text = "File Path"
        ' 
        ' txtHiveNumber
        ' 
        txtHiveNumber.FormattingEnabled = True
        txtHiveNumber.Location = New Point(144, 60)
        txtHiveNumber.Name = "txtHiveNumber"
        txtHiveNumber.Size = New Size(151, 28)
        txtHiveNumber.TabIndex = 37
        ' 
        ' btnSettings
        ' 
        btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), Image)
        btnSettings.Location = New Point(492, 104)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(53, 49)
        btnSettings.TabIndex = 36
        btnSettings.UseVisualStyleBackColor = True
        ' 
        ' btnOpenWeather
        ' 
        btnOpenWeather.Location = New Point(464, 464)
        btnOpenWeather.Name = "btnOpenWeather"
        btnOpenWeather.Size = New Size(176, 29)
        btnOpenWeather.TabIndex = 35
        btnOpenWeather.Text = "What is the weather?"
        btnOpenWeather.UseVisualStyleBackColor = True
        ' 
        ' txtPests
        ' 
        txtPests.Location = New Point(144, 529)
        txtPests.Name = "txtPests"
        txtPests.Size = New Size(314, 27)
        txtPests.TabIndex = 34
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(62, 529)
        Label14.Name = "Label14"
        Label14.Size = New Size(41, 20)
        Label14.TabIndex = 33
        Label14.Text = "Pests"
        ' 
        ' txtTreatment
        ' 
        txtTreatment.Location = New Point(144, 562)
        txtTreatment.Name = "txtTreatment"
        txtTreatment.Size = New Size(314, 27)
        txtTreatment.TabIndex = 32
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(62, 565)
        Label13.Name = "Label13"
        Label13.Size = New Size(76, 20)
        Label13.TabIndex = 31
        Label13.Text = "Treatment"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.AntiqueWhite
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.Location = New Point(264, 1306)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(60, 49)
        btnSave.TabIndex = 30
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(70, 1180)
        Label12.Name = "Label12"
        Label12.Size = New Size(48, 20)
        Label12.TabIndex = 29
        Label12.Text = "Notes"
        ' 
        ' txtNotes
        ' 
        txtNotes.Location = New Point(124, 1180)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(421, 120)
        txtNotes.TabIndex = 28
        ' 
        ' btnUploadPhoto
        ' 
        btnUploadPhoto.BackColor = Color.LightSkyBlue
        btnUploadPhoto.Location = New Point(247, 1146)
        btnUploadPhoto.Name = "btnUploadPhoto"
        btnUploadPhoto.Size = New Size(129, 29)
        btnUploadPhoto.TabIndex = 27
        btnUploadPhoto.Text = "Upload Photo"
        btnUploadPhoto.UseVisualStyleBackColor = False
        ' 
        ' picPreview
        ' 
        picPreview.Location = New Point(124, 937)
        picPreview.Name = "picPreview"
        picPreview.Size = New Size(373, 203)
        picPreview.SizeMode = PictureBoxSizeMode.Zoom
        picPreview.TabIndex = 26
        picPreview.TabStop = False
        ' 
        ' txtTemperature
        ' 
        txtTemperature.Location = New Point(144, 496)
        txtTemperature.Name = "txtTemperature"
        txtTemperature.Size = New Size(314, 27)
        txtTemperature.TabIndex = 25
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(37, 499)
        Label11.Name = "Label11"
        Label11.Size = New Size(93, 20)
        Label11.TabIndex = 24
        Label11.Text = "Temperature"
        ' 
        ' txtWeather
        ' 
        txtWeather.Location = New Point(144, 461)
        txtWeather.Name = "txtWeather"
        txtWeather.Size = New Size(314, 27)
        txtWeather.TabIndex = 23
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(62, 464)
        Label10.Name = "Label10"
        Label10.Size = New Size(64, 20)
        Label10.TabIndex = 22
        Label10.Text = "Weather"
        ' 
        ' txtFeedAmount
        ' 
        txtFeedAmount.Location = New Point(144, 425)
        txtFeedAmount.Name = "txtFeedAmount"
        txtFeedAmount.Size = New Size(314, 27)
        txtFeedAmount.TabIndex = 21
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(32, 432)
        Label9.Name = "Label9"
        Label9.Size = New Size(98, 20)
        Label9.TabIndex = 20
        Label9.Text = "Feed Amount"
        ' 
        ' txtFeedType
        ' 
        txtFeedType.Location = New Point(144, 392)
        txtFeedType.Name = "txtFeedType"
        txtFeedType.Size = New Size(314, 27)
        txtFeedType.TabIndex = 19
        ' 
        ' Treatments
        ' 
        Treatments.AutoSize = True
        Treatments.Location = New Point(50, 399)
        Treatments.Name = "Treatments"
        Treatments.Size = New Size(76, 20)
        Treatments.TabIndex = 18
        Treatments.Text = "Feed Type"
        ' 
        ' txtMiteCount
        ' 
        txtMiteCount.Location = New Point(144, 355)
        txtMiteCount.Name = "txtMiteCount"
        txtMiteCount.Size = New Size(314, 27)
        txtMiteCount.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(17, 362)
        Label8.Name = "Label8"
        Label8.Size = New Size(121, 20)
        Label8.TabIndex = 16
        Label8.Text = "Number of Mites"
        ' 
        ' txtDronePopulation
        ' 
        txtDronePopulation.Location = New Point(144, 322)
        txtDronePopulation.Name = "txtDronePopulation"
        txtDronePopulation.Size = New Size(314, 27)
        txtDronePopulation.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(17, 329)
        Label7.Name = "Label7"
        Label7.Size = New Size(125, 20)
        Label7.TabIndex = 14
        Label7.Text = "Drone Population"
        ' 
        ' txtBeePopulation
        ' 
        txtBeePopulation.Location = New Point(144, 276)
        txtBeePopulation.Name = "txtBeePopulation"
        txtBeePopulation.Size = New Size(314, 27)
        txtBeePopulation.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(17, 283)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 20)
        Label6.TabIndex = 12
        Label6.Text = "Bee Population"
        ' 
        ' txtQueenStatus
        ' 
        txtQueenStatus.Location = New Point(144, 233)
        txtQueenStatus.Name = "txtQueenStatus"
        txtQueenStatus.Size = New Size(314, 27)
        txtQueenStatus.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(30, 240)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 20)
        Label5.TabIndex = 10
        Label5.Text = "Queen Status"
        ' 
        ' chkSwarming
        ' 
        chkSwarming.AutoSize = True
        chkSwarming.Location = New Point(159, 203)
        chkSwarming.Name = "chkSwarming"
        chkSwarming.Size = New Size(235, 24)
        chkSwarming.TabIndex = 9
        chkSwarming.Text = "Did you see swarming activity?"
        chkSwarming.UseVisualStyleBackColor = True
        ' 
        ' txtBroodPattern
        ' 
        txtBroodPattern.Location = New Point(144, 161)
        txtBroodPattern.Name = "txtBroodPattern"
        txtBroodPattern.Size = New Size(314, 27)
        txtBroodPattern.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 20)
        Label4.TabIndex = 6
        Label4.Text = "Brood Pattern"
        ' 
        ' txtHiveCondition
        ' 
        txtHiveCondition.Location = New Point(144, 115)
        txtHiveCondition.Name = "txtHiveCondition"
        txtHiveCondition.Size = New Size(314, 27)
        txtHiveCondition.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 20)
        Label3.TabIndex = 4
        Label3.Text = "Hive Condition"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 20)
        Label2.TabIndex = 2
        Label2.Text = "Hive Number"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(7, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 20)
        Label1.TabIndex = 1
        Label1.Text = "Date of inspection"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(144, 17)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(250, 27)
        dtpDate.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.WhiteSmoke
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(Panel6)
        Panel4.Controls.Add(Panel7)
        Panel4.Controls.Add(Panel8)
        Panel4.Controls.Add(Panel9)
        Panel4.Controls.Add(Panel10)
        Panel4.Controls.Add(Panel11)
        Panel4.Controls.Add(Panel12)
        Panel4.Controls.Add(Panel13)
        Panel4.Controls.Add(Panel2)
        Panel4.Location = New Point(62, 628)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(672, 294)
        Panel4.TabIndex = 43
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Gainsboro
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(cboFrame2)
        Panel5.Location = New Point(76, 15)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(39, 262)
        Panel5.TabIndex = 43
        ' 
        ' cboFrame2
        ' 
        cboFrame2.FormattingEnabled = True
        cboFrame2.Items.AddRange(New Object() {"Empty", "Honey", "Brood", "Pollen", "Queen", "Drone", "Mixed"})
        cboFrame2.Location = New Point(7, 229)
        cboFrame2.Name = "cboFrame2"
        cboFrame2.Size = New Size(23, 28)
        cboFrame2.TabIndex = 45
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Gainsboro
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(cboFrame3)
        Panel6.Location = New Point(143, 15)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(39, 262)
        Panel6.TabIndex = 44
        ' 
        ' cboFrame3
        ' 
        cboFrame3.FormattingEnabled = True
        cboFrame3.Items.AddRange(New Object() {"Empty", "Honey", "Brood", "Pollen", "Queen", "Drone", "Mixed"})
        cboFrame3.Location = New Point(8, 229)
        cboFrame3.Name = "cboFrame3"
        cboFrame3.Size = New Size(23, 28)
        cboFrame3.TabIndex = 45
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Gainsboro
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(cboFrame4)
        Panel7.Location = New Point(207, 15)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(39, 262)
        Panel7.TabIndex = 44
        ' 
        ' cboFrame4
        ' 
        cboFrame4.FormattingEnabled = True
        cboFrame4.Items.AddRange(New Object() {"Empty", "Honey", "Brood", "Pollen", "Queen", "Drone", "Mixed"})
        cboFrame4.Location = New Point(7, 229)
        cboFrame4.Name = "cboFrame4"
        cboFrame4.Size = New Size(23, 28)
        cboFrame4.TabIndex = 46
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Gainsboro
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(cboFrame5)
        Panel8.Location = New Point(275, 15)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(39, 262)
        Panel8.TabIndex = 44
        ' 
        ' cboFrame5
        ' 
        cboFrame5.FormattingEnabled = True
        cboFrame5.Items.AddRange(New Object() {"Empty", "Honey", "Brood", "Pollen", "Queen", "Drone", "Mixed"})
        cboFrame5.Location = New Point(8, 226)
        cboFrame5.Name = "cboFrame5"
        cboFrame5.Size = New Size(23, 28)
        cboFrame5.TabIndex = 46
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Gainsboro
        Panel9.BorderStyle = BorderStyle.FixedSingle
        Panel9.Controls.Add(cboFrame6)
        Panel9.Location = New Point(339, 15)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(39, 262)
        Panel9.TabIndex = 44
        ' 
        ' cboFrame6
        ' 
        cboFrame6.FormattingEnabled = True
        cboFrame6.Items.AddRange(New Object() {"Empty", "Honey", "Brood", "Pollen", "Queen", "Drone", "Mixed"})
        cboFrame6.Location = New Point(7, 227)
        cboFrame6.Name = "cboFrame6"
        cboFrame6.Size = New Size(23, 28)
        cboFrame6.TabIndex = 47
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Gainsboro
        Panel10.BorderStyle = BorderStyle.FixedSingle
        Panel10.Controls.Add(cboFrame7)
        Panel10.Location = New Point(407, 15)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(39, 262)
        Panel10.TabIndex = 44
        ' 
        ' cboFrame7
        ' 
        cboFrame7.FormattingEnabled = True
        cboFrame7.Items.AddRange(New Object() {"Empty", "Honey", "Brood", "Pollen", "Queen", "Drone", "Mixed"})
        cboFrame7.Location = New Point(7, 226)
        cboFrame7.Name = "cboFrame7"
        cboFrame7.Size = New Size(23, 28)
        cboFrame7.TabIndex = 48
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.Gainsboro
        Panel11.BorderStyle = BorderStyle.FixedSingle
        Panel11.Controls.Add(cboFrame8)
        Panel11.Location = New Point(472, 15)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(39, 262)
        Panel11.TabIndex = 44
        ' 
        ' cboFrame8
        ' 
        cboFrame8.FormattingEnabled = True
        cboFrame8.Items.AddRange(New Object() {"Empty", "Honey", "Brood", "Pollen", "Queen", "Drone", "Mixed"})
        cboFrame8.Location = New Point(9, 226)
        cboFrame8.Name = "cboFrame8"
        cboFrame8.Size = New Size(23, 28)
        cboFrame8.TabIndex = 49
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.Gainsboro
        Panel12.BorderStyle = BorderStyle.FixedSingle
        Panel12.Controls.Add(cboFrame9)
        Panel12.Location = New Point(538, 15)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(39, 262)
        Panel12.TabIndex = 44
        ' 
        ' cboFrame9
        ' 
        cboFrame9.FormattingEnabled = True
        cboFrame9.Items.AddRange(New Object() {"Empty", "Honey", "Brood", "Pollen", "Queen", "Drone", "Mixed"})
        cboFrame9.Location = New Point(8, 227)
        cboFrame9.Name = "cboFrame9"
        cboFrame9.Size = New Size(23, 28)
        cboFrame9.TabIndex = 50
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.Gainsboro
        Panel13.BorderStyle = BorderStyle.FixedSingle
        Panel13.Controls.Add(cboFrame10)
        Panel13.Location = New Point(608, 15)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(39, 262)
        Panel13.TabIndex = 44
        ' 
        ' cboFrame10
        ' 
        cboFrame10.FormattingEnabled = True
        cboFrame10.Items.AddRange(New Object() {"Empty", "Honey", "Brood", "Pollen", "Queen", "Drone", "Mixed"})
        cboFrame10.Location = New Point(8, 228)
        cboFrame10.Name = "cboFrame10"
        cboFrame10.Size = New Size(23, 28)
        cboFrame10.TabIndex = 51
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gainsboro
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(14, 15)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(39, 262)
        Panel2.TabIndex = 41
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Gainsboro
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(cboFrame1)
        Panel3.Location = New Point(-1, -1)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(39, 262)
        Panel3.TabIndex = 42
        ' 
        ' cboFrame1
        ' 
        cboFrame1.FormattingEnabled = True
        cboFrame1.Items.AddRange(New Object() {"Empty", "Honey", "Brood", "Pollen", "Queen", "Drone", "Mixed"})
        cboFrame1.Location = New Point(6, 229)
        cboFrame1.Name = "cboFrame1"
        cboFrame1.Size = New Size(23, 28)
        cboFrame1.TabIndex = 44
        ' 
        ' TabPageRecords
        ' 
        TabPageRecords.BackgroundImage = CType(resources.GetObject("TabPageRecords.BackgroundImage"), Image)
        TabPageRecords.Controls.Add(btnFilter)
        TabPageRecords.Controls.Add(cmbHiveFilter)
        TabPageRecords.Controls.Add(dgvRecords)
        TabPageRecords.Location = New Point(4, 29)
        TabPageRecords.Name = "TabPageRecords"
        TabPageRecords.Padding = New Padding(3)
        TabPageRecords.Size = New Size(1015, 1964)
        TabPageRecords.TabIndex = 1
        TabPageRecords.Text = "Inspection Records"
        TabPageRecords.UseVisualStyleBackColor = True
        ' 
        ' btnFilter
        ' 
        btnFilter.Location = New Point(325, 10)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(147, 29)
        btnFilter.TabIndex = 2
        btnFilter.Text = "Filter by Hive"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' cmbHiveFilter
        ' 
        cmbHiveFilter.FormattingEnabled = True
        cmbHiveFilter.Location = New Point(107, 8)
        cmbHiveFilter.Name = "cmbHiveFilter"
        cmbHiveFilter.Size = New Size(151, 28)
        cmbHiveFilter.TabIndex = 1
        ' 
        ' dgvRecords
        ' 
        dgvRecords.AllowUserToAddRows = False
        dgvRecords.AllowUserToDeleteRows = False
        dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecords.Location = New Point(107, 42)
        dgvRecords.Name = "dgvRecords"
        dgvRecords.ReadOnly = True
        dgvRecords.RowHeadersWidth = 51
        dgvRecords.Size = New Size(800, 576)
        dgvRecords.TabIndex = 0
        ' 
        ' TabPageBeePlants
        ' 
        TabPageBeePlants.Controls.Add(txtWikiContent)
        TabPageBeePlants.Controls.Add(btnSearch)
        TabPageBeePlants.Controls.Add(txtSearch)
        TabPageBeePlants.Location = New Point(4, 29)
        TabPageBeePlants.Name = "TabPageBeePlants"
        TabPageBeePlants.Size = New Size(1015, 1964)
        TabPageBeePlants.TabIndex = 2
        TabPageBeePlants.Text = "Wiki"
        TabPageBeePlants.UseVisualStyleBackColor = True
        ' 
        ' txtWikiContent
        ' 
        txtWikiContent.Location = New Point(169, 183)
        txtWikiContent.Name = "txtWikiContent"
        txtWikiContent.ReadOnly = True
        txtWikiContent.Size = New Size(125, 120)
        txtWikiContent.TabIndex = 2
        txtWikiContent.Text = ""
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(149, 109)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(95, 42)
        txtSearch.Name = "txtSearch"
        txtSearch.RightToLeft = RightToLeft.No
        txtSearch.Size = New Size(125, 27)
        txtSearch.TabIndex = 0
        ' 
        ' OpenFileDialog
        ' 
        OpenFileDialog.FileName = "OpenFileDialog"
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(TabControl1)
        Panel1.Location = New Point(-64, 1053)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(3058, 1560)
        Panel1.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(1902, 1055)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        TabControl1.ResumeLayout(False)
        TabPageForm.ResumeLayout(False)
        TabPageForm.PerformLayout()
        CType(picPreview, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel12.ResumeLayout(False)
        Panel13.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        TabPageRecords.ResumeLayout(False)
        CType(dgvRecords, ComponentModel.ISupportInitialize).EndInit()
        TabPageBeePlants.ResumeLayout(False)
        TabPageBeePlants.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageForm As TabPage
    Friend WithEvents TabPageRecords As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHiveCondition As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBroodPattern As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkSwarming As CheckBox
    Friend WithEvents txtQueenStatus As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBeePopulation As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDronePopulation As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMiteCount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFeedType As TextBox
    Friend WithEvents Treatments As Label
    Friend WithEvents txtFeedAmount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtWeather As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents picPreview As PictureBox
    Friend WithEvents btnUploadPhoto As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvRecords As DataGridView
    Friend WithEvents txtPests As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTreatment As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents cmbHiveFilter As ComboBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnOpenWeather As Button
    Friend WithEvents TabPageBeePlants As TabPage
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtWikiContent As RichTextBox
    Friend WithEvents btnSettings As Button
    Friend WithEvents txtHiveNumber As ComboBox
    Friend WithEvents lvFiles As ListView
    Friend WithEvents FileType As ColumnHeader
    Friend WithEvents FilePath As ColumnHeader
    Friend WithEvents btnAddFile As Button
    Friend WithEvents btnWiki As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cboFrame2 As ComboBox
    Friend WithEvents cboFrame3 As ComboBox
    Friend WithEvents cboFrame4 As ComboBox
    Friend WithEvents cboFrame5 As ComboBox
    Friend WithEvents cboFrame6 As ComboBox
    Friend WithEvents cboFrame7 As ComboBox
    Friend WithEvents cboFrame8 As ComboBox
    Friend WithEvents cboFrame9 As ComboBox
    Friend WithEvents cboFrame10 As ComboBox
    Friend WithEvents cboFrame1 As ComboBox

End Class
