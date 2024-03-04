Public Class login

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            Button1_Click(Me, EventArgs.Empty)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user, pass As String
        user = TextBox1.Text
        pass = TextBox2.Text
        If (user = "Miss.K.T" And pass = "12345678") Then
            MsgBox("Login Successful",, "Login Sucess")
            Dim form1 As New Form1()
            AddHandler form1.FormClosed, AddressOf Form1_FormClosed ' Add event handler for Form1's FormClosed event
            form1.Show()
            Me.Hide() ' Hide Form2 instead of closing it
        Else
            MsgBox("Inccorrect Username or Password.",, "Invalid Credentials")
        End If
    End Sub
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs)
        Me.Close() ' Close Form2 when Form1 is closed
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.PasswordChar = "*" Then
            TextBox2.PasswordChar = ""
            'Button2.Text = "😉"
            Button2.Text = "😶"
        Else
            TextBox2.PasswordChar = "*"
            Button2.Text = "🫣"
        End If
    End Sub
End Class