<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWeather
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblLatitude = New Label()
        lblAdditionalWeather = New Label()
        lblTemperature = New Label()
        lblWeatherInfo = New Label()
        lblLongitude = New Label()
        btnClose = New Button()
        txtWeatherDetails = New RichTextBox()
        progressBar = New ProgressBar()
        picWeather = New PictureBox()
        lblWeather = New Label()
        Label1 = New Label()
        cmbApiarySelection = New ComboBox()
        CType(picWeather, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblLatitude
        ' 
        lblLatitude.AutoSize = True
        lblLatitude.Location = New Point(12, 32)
        lblLatitude.Name = "lblLatitude"
        lblLatitude.Size = New Size(63, 20)
        lblLatitude.TabIndex = 1
        lblLatitude.Text = "Latitude"
        ' 
        ' lblAdditionalWeather
        ' 
        lblAdditionalWeather.AutoSize = True
        lblAdditionalWeather.Location = New Point(267, 402)
        lblAdditionalWeather.Name = "lblAdditionalWeather"
        lblAdditionalWeather.Size = New Size(168, 20)
        lblAdditionalWeather.TabIndex = 4
        lblAdditionalWeather.Text = "Additional Weather Info"
        ' 
        ' lblTemperature
        ' 
        lblTemperature.AutoSize = True
        lblTemperature.Location = New Point(123, 368)
        lblTemperature.Name = "lblTemperature"
        lblTemperature.Size = New Size(93, 20)
        lblTemperature.TabIndex = 5
        lblTemperature.Text = "Temperature"
        ' 
        ' lblWeatherInfo
        ' 
        lblWeatherInfo.AutoSize = True
        lblWeatherInfo.Location = New Point(267, 368)
        lblWeatherInfo.Name = "lblWeatherInfo"
        lblWeatherInfo.Size = New Size(146, 20)
        lblWeatherInfo.TabIndex = 6
        lblWeatherInfo.Text = "Weather Information"
        ' 
        ' lblLongitude
        ' 
        lblLongitude.AutoSize = True
        lblLongitude.Location = New Point(187, 32)
        lblLongitude.Name = "lblLongitude"
        lblLongitude.Size = New Size(76, 20)
        lblLongitude.TabIndex = 7
        lblLongitude.Text = "Longitude"
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(12, 651)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 11
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' txtWeatherDetails
        ' 
        txtWeatherDetails.Location = New Point(91, 433)
        txtWeatherDetails.Name = "txtWeatherDetails"
        txtWeatherDetails.Size = New Size(566, 170)
        txtWeatherDetails.TabIndex = 12
        txtWeatherDetails.Text = ""
        ' 
        ' progressBar
        ' 
        progressBar.Location = New Point(194, 609)
        progressBar.Name = "progressBar"
        progressBar.Size = New Size(405, 29)
        progressBar.TabIndex = 13
        progressBar.Visible = False
        ' 
        ' picWeather
        ' 
        picWeather.Location = New Point(30, 88)
        picWeather.Name = "picWeather"
        picWeather.Size = New Size(627, 277)
        picWeather.TabIndex = 14
        picWeather.TabStop = False
        ' 
        ' lblWeather
        ' 
        lblWeather.AutoSize = True
        lblWeather.Location = New Point(533, 368)
        lblWeather.Name = "lblWeather"
        lblWeather.Size = New Size(53, 20)
        lblWeather.TabIndex = 15
        lblWeather.Text = "Label1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 20)
        Label1.TabIndex = 16
        Label1.Text = "Weather for:"
        ' 
        ' cmbApiarySelection
        ' 
        cmbApiarySelection.FormattingEnabled = True
        cmbApiarySelection.Location = New Point(416, 32)
        cmbApiarySelection.Name = "cmbApiarySelection"
        cmbApiarySelection.Size = New Size(151, 28)
        cmbApiarySelection.TabIndex = 17
        ' 
        ' FormWeather
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 692)
        Controls.Add(cmbApiarySelection)
        Controls.Add(Label1)
        Controls.Add(lblWeather)
        Controls.Add(picWeather)
        Controls.Add(progressBar)
        Controls.Add(txtWeatherDetails)
        Controls.Add(btnClose)
        Controls.Add(lblLongitude)
        Controls.Add(lblWeatherInfo)
        Controls.Add(lblTemperature)
        Controls.Add(lblAdditionalWeather)
        Controls.Add(lblLatitude)
        Name = "FormWeather"
        Text = "FormWeather"
        CType(picWeather, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents lblLatitude As Label
    Friend WithEvents lblAdditionalWeather As Label
    Friend WithEvents lblTemperature As Label
    Friend WithEvents lblWeatherInfo As Label
    Friend WithEvents lblLongitude As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents txtWeatherDetails As RichTextBox
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents picWeather As PictureBox
    Friend WithEvents lblWeather As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbApiarySelection As ComboBox
End Class
