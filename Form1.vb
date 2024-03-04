Public Class Form1

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' Stretch the panel vertically
        Panel1.Height = Me.ClientSize.Height - 15
        Panel2.Height = Me.ClientSize.Height - 15

        For Each ctrl As Control In Panel1.Controls
            ctrl.Left = CInt(Panel1.Width * ctrl.Left / Panel1.ClientSize.Width)
            ctrl.Top = CInt(Panel1.Height * ctrl.Top / Panel1.ClientSize.Height)
            ctrl.Width = CInt(Panel1.Width * ctrl.Width / Panel1.ClientSize.Width)
            ctrl.Height = CInt(Panel1.Height * ctrl.Height / Panel1.ClientSize.Height)
        Next
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim form2 As New chat("")
        form2.Show()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim form2 As New chat("person2")
        form2.Show()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Dim form2 As New chat("person3")
        form2.Show()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Dim form2 As New chat("person4")
        form2.Show()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Dim form2 As New chat("person5")
        form2.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim form2 As New chat("person1")
        form2.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim form2 As New chat("person2")
        form2.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim form2 As New chat("person3")
        form2.Show()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Dim form2 As New chat("person4")
        form2.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim form2 As New chat("person5")
        form2.Show()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Dim login As New login()
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        Dim login As New login()
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
    End Sub
End Class
