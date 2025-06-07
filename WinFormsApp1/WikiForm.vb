Public Class WikiForm
    Private wiki As New WikiManager()

    Private Sub WikiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshPageList()
    End Sub

    Private Sub RefreshPageList()
        lstPages.Items.Clear()
        For Each page In wiki.GetAllPages()
            lstPages.Items.Add(page)
        Next
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadPageByTitle(txtPageTitle.Text.Trim())
    End Sub

    Private Sub LoadPageByTitle(title As String)
        If title = "" Then Return

        Dim rawRtf As String = wiki.LoadPage(title)
        If rawRtf = "" Then
            rtbContent.Clear()
            MessageBox.Show("Page not found.")
            Return
        End If

        rtbContent.Rtf = rawRtf

        HighlightLinks()
        txtPageTitle.Text = title
    End Sub

    Private Sub HighlightLinks()
        Dim pattern As String = "\[\[(.*?)\]\]"
        Dim matches = System.Text.RegularExpressions.Regex.Matches(rtbContent.Text, pattern)

        ' Remove all existing formatting
        rtbContent.SelectAll()
        rtbContent.SelectionColor = Color.Black
        rtbContent.SelectionFont = New Font(rtbContent.Font, FontStyle.Regular)

        For Each m As System.Text.RegularExpressions.Match In matches
            Dim linkText = m.Groups(1).Value
            Dim start = m.Index
            Dim length = m.Length

            ' Select the whole [[PageName]] text
            rtbContent.Select(start, length)

            ' Replace it with just PageName (without brackets)
            rtbContent.SelectedText = linkText

            ' Now select the inserted PageName and make it look like a link
            rtbContent.Select(start, linkText.Length)
            rtbContent.SelectionColor = Color.Blue
            rtbContent.SelectionFont = New Font(rtbContent.Font, FontStyle.Underline)
        Next

        ' Deselect text
        rtbContent.Select(0, 0)
    End Sub

    Private Sub rtbContent_MouseClick(sender As Object, e As MouseEventArgs) Handles rtbContent.MouseClick
        Dim index = rtbContent.GetCharIndexFromPosition(e.Location)

        ' Check all links by finding all blue underlined text
        Dim text = rtbContent.Text
        Dim position As Integer = 0

        ' Loop through the text and find words with blue underlined formatting
        While position < text.Length
            rtbContent.Select(position, 1)
            If rtbContent.SelectionColor = Color.Blue AndAlso rtbContent.SelectionFont.Underline Then
                Dim linkStart = position
                Dim linkLength = 1
                position += 1

                ' Find full extent of link text
                While position < text.Length
                    rtbContent.Select(position, 1)
                    If rtbContent.SelectionColor = Color.Blue AndAlso rtbContent.SelectionFont.Underline Then
                        linkLength += 1
                        position += 1
                    Else
                        Exit While
                    End If
                End While

                ' If click is inside this link text, load the page
                If index >= linkStart AndAlso index < linkStart + linkLength Then
                    Dim pageName = rtbContent.Text.Substring(linkStart, linkLength)
                    LoadPageByTitle(pageName)
                    Exit Sub
                End If
            Else
                position += 1
            End If
        End While
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim title As String = txtPageTitle.Text.Trim()
        If title <> "" Then
            wiki.SavePage(title, rtbContent.Rtf) ' Save the full RTF content (including formatting)
            RefreshPageList()
        End If
    End Sub

    Private Sub btnNewPage_Click(sender As Object, e As EventArgs) Handles btnNewPage.Click
        txtPageTitle.Text = ""
        rtbContent.Clear()
    End Sub

    Private Sub lstPages_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPages.SelectedIndexChanged
        If lstPages.SelectedIndex >= 0 Then
            LoadPageByTitle(lstPages.SelectedItem.ToString())
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub rtbContent_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class

