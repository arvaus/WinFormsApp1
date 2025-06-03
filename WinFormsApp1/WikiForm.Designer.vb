<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WikiForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WikiForm))
        lstPages = New ListBox()
        rtbContent = New RichTextBox()
        txtPageTitle = New TextBox()
        btnLoad = New Button()
        btnSave = New Button()
        btnNewPage = New Button()
        btnBold = New Button()
        btnItalic = New Button()
        btnUnderline = New Button()
        btnInsertImage = New Button()
        SuspendLayout()
        ' 
        ' lstPages
        ' 
        lstPages.FormattingEnabled = True
        lstPages.Location = New Point(12, 26)
        lstPages.Name = "lstPages"
        lstPages.Size = New Size(150, 644)
        lstPages.TabIndex = 0
        ' 
        ' rtbContent
        ' 
        rtbContent.Location = New Point(182, 125)
        rtbContent.Name = "rtbContent"
        rtbContent.Size = New Size(1263, 511)
        rtbContent.TabIndex = 1
        rtbContent.Text = ""
        ' 
        ' txtPageTitle
        ' 
        txtPageTitle.Location = New Point(427, 50)
        txtPageTitle.Name = "txtPageTitle"
        txtPageTitle.Size = New Size(397, 27)
        txtPageTitle.TabIndex = 2
        ' 
        ' btnLoad
        ' 
        btnLoad.Location = New Point(1026, 49)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(94, 29)
        btnLoad.TabIndex = 3
        btnLoad.Text = "Load Page"
        btnLoad.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(1116, 642)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 4
        btnSave.Text = "Save Page"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnNewPage
        ' 
        btnNewPage.Location = New Point(399, 642)
        btnNewPage.Name = "btnNewPage"
        btnNewPage.Size = New Size(94, 29)
        btnNewPage.TabIndex = 5
        btnNewPage.Text = "New Page"
        btnNewPage.UseVisualStyleBackColor = True
        ' 
        ' btnBold
        ' 
        btnBold.Image = CType(resources.GetObject("btnBold.Image"), Image)
        btnBold.Location = New Point(339, 90)
        btnBold.Name = "btnBold"
        btnBold.Size = New Size(36, 29)
        btnBold.TabIndex = 6
        btnBold.UseVisualStyleBackColor = True
        ' 
        ' btnItalic
        ' 
        btnItalic.Image = CType(resources.GetObject("btnItalic.Image"), Image)
        btnItalic.Location = New Point(605, 90)
        btnItalic.Name = "btnItalic"
        btnItalic.Size = New Size(36, 29)
        btnItalic.TabIndex = 7
        btnItalic.UseVisualStyleBackColor = True
        ' 
        ' btnUnderline
        ' 
        btnUnderline.Image = CType(resources.GetObject("btnUnderline.Image"), Image)
        btnUnderline.Location = New Point(864, 90)
        btnUnderline.Name = "btnUnderline"
        btnUnderline.Size = New Size(36, 29)
        btnUnderline.TabIndex = 8
        btnUnderline.UseVisualStyleBackColor = True
        ' 
        ' btnInsertImage
        ' 
        btnInsertImage.Image = CType(resources.GetObject("btnInsertImage.Image"), Image)
        btnInsertImage.Location = New Point(1162, 90)
        btnInsertImage.Name = "btnInsertImage"
        btnInsertImage.Size = New Size(36, 29)
        btnInsertImage.TabIndex = 9
        btnInsertImage.UseVisualStyleBackColor = True
        ' 
        ' WikiForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1484, 828)
        Controls.Add(btnInsertImage)
        Controls.Add(btnUnderline)
        Controls.Add(btnItalic)
        Controls.Add(btnBold)
        Controls.Add(btnNewPage)
        Controls.Add(btnSave)
        Controls.Add(btnLoad)
        Controls.Add(txtPageTitle)
        Controls.Add(rtbContent)
        Controls.Add(lstPages)
        Name = "WikiForm"
        Text = "WikiForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstPages As ListBox
    Friend WithEvents rtbContent As RichTextBox
    Friend WithEvents txtPageTitle As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNewPage As Button
    Friend WithEvents btnBold As Button
    Friend WithEvents btnItalic As Button
    Friend WithEvents btnUnderline As Button
    Friend WithEvents btnInsertImage As Button
End Class
