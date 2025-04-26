<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        txtLat = New TextBox()
        txtLon = New TextBox()
        lblLat = New Label()
        lblLon = New Label()
        btnSaveSettings = New Button()
        SuspendLayout()
        ' 
        ' txtLat
        ' 
        txtLat.Location = New Point(125, 63)
        txtLat.Name = "txtLat"
        txtLat.Size = New Size(125, 27)
        txtLat.TabIndex = 0
        ' 
        ' txtLon
        ' 
        txtLon.Location = New Point(384, 63)
        txtLon.Name = "txtLon"
        txtLon.Size = New Size(125, 27)
        txtLon.TabIndex = 1
        ' 
        ' lblLat
        ' 
        lblLat.AutoSize = True
        lblLat.Location = New Point(43, 70)
        lblLat.Name = "lblLat"
        lblLat.Size = New Size(63, 20)
        lblLat.TabIndex = 2
        lblLat.Text = "Latitude"
        ' 
        ' lblLon
        ' 
        lblLon.AutoSize = True
        lblLon.Location = New Point(302, 70)
        lblLon.Name = "lblLon"
        lblLon.Size = New Size(76, 20)
        lblLon.TabIndex = 3
        lblLon.Text = "Longitude"
        ' 
        ' btnSaveSettings
        ' 
        btnSaveSettings.Location = New Point(257, 164)
        btnSaveSettings.Name = "btnSaveSettings"
        btnSaveSettings.Size = New Size(94, 29)
        btnSaveSettings.TabIndex = 4
        btnSaveSettings.Text = "Save"
        btnSaveSettings.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSaveSettings)
        Controls.Add(lblLon)
        Controls.Add(lblLat)
        Controls.Add(txtLon)
        Controls.Add(txtLat)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtLat As TextBox
    Friend WithEvents txtLon As TextBox
    Friend WithEvents lblLat As Label
    Friend WithEvents lblLon As Label
    Friend WithEvents btnSaveSettings As Button
End Class
