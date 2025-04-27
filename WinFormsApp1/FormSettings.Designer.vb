<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
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
        lblApiaryName = New Label()
        txtApiaryName = New TextBox()
        lblAddress = New Label()
        txtApiaryAddress = New TextBox()
        lblHives = New Label()
        txtNumberOfHives = New NumericUpDown()
        btnSaveSettings = New Button()
        CType(txtNumberOfHives, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblApiaryName
        ' 
        lblApiaryName.AutoSize = True
        lblApiaryName.Location = New Point(38, 38)
        lblApiaryName.Name = "lblApiaryName"
        lblApiaryName.Size = New Size(99, 20)
        lblApiaryName.TabIndex = 0
        lblApiaryName.Text = "Apiary Name:"
        ' 
        ' txtApiaryName
        ' 
        txtApiaryName.Location = New Point(143, 38)
        txtApiaryName.Name = "txtApiaryName"
        txtApiaryName.Size = New Size(164, 27)
        txtApiaryName.TabIndex = 1
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(12, 109)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(130, 20)
        lblAddress.TabIndex = 2
        lblAddress.Text = "Address of Apiary:"
        ' 
        ' txtApiaryAddress
        ' 
        txtApiaryAddress.Location = New Point(148, 109)
        txtApiaryAddress.Name = "txtApiaryAddress"
        txtApiaryAddress.Size = New Size(159, 27)
        txtApiaryAddress.TabIndex = 3
        ' 
        ' lblHives
        ' 
        lblHives.AutoSize = True
        lblHives.Location = New Point(12, 183)
        lblHives.Name = "lblHives"
        lblHives.Size = New Size(212, 20)
        lblHives.TabIndex = 4
        lblHives.Text = "Number of Hives in the Apiary:"
        ' 
        ' txtNumberOfHives
        ' 
        txtNumberOfHives.Location = New Point(243, 181)
        txtNumberOfHives.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        txtNumberOfHives.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        txtNumberOfHives.Name = "txtNumberOfHives"
        txtNumberOfHives.Size = New Size(150, 27)
        txtNumberOfHives.TabIndex = 5
        txtNumberOfHives.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' btnSaveSettings
        ' 
        btnSaveSettings.Location = New Point(225, 361)
        btnSaveSettings.Name = "btnSaveSettings"
        btnSaveSettings.Size = New Size(150, 29)
        btnSaveSettings.TabIndex = 6
        btnSaveSettings.Text = "Save Settings"
        btnSaveSettings.UseVisualStyleBackColor = True
        ' 
        ' FormSettings
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 553)
        Controls.Add(btnSaveSettings)
        Controls.Add(txtNumberOfHives)
        Controls.Add(lblHives)
        Controls.Add(txtApiaryAddress)
        Controls.Add(lblAddress)
        Controls.Add(txtApiaryName)
        Controls.Add(lblApiaryName)
        Name = "FormSettings"
        Text = "FormSettings"
        CType(txtNumberOfHives, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblApiaryName As Label
    Friend WithEvents txtApiaryName As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtApiaryAddress As TextBox
    Friend WithEvents lblHives As Label
    Friend WithEvents txtNumberOfHives As NumericUpDown
    Friend WithEvents btnSaveSettings As Button
End Class
