Public Class chat

    Public Sub New(ByVal labelClicked As String)
        InitializeComponent()

        ' You can use buttonClicked to perform specific actions
        ' based on which button was clicked in Form1
        If labelClicked = "person1" Then
            Label12_Click(Me, EventArgs.Empty)
        ElseIf labelClicked = "person2" Then
            Label13_Click(Me, EventArgs.Empty)
        ElseIf labelClicked = "person3" Then
            Label14_Click(Me, EventArgs.Empty)
        ElseIf labelClicked = "person4" Then
            Label15_Click(Me, EventArgs.Empty)
        ElseIf labelClicked = "person5" Then
            Label16_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            Button1_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg, msg2 As String
        If TextBox1.Text IsNot "" Then
            msg = "🛫  " + TextBox1.Text
            msg2 = " 🛬  " + TextBox1.Text
            ListBox1.Items.Add(msg)
            ListBox1.Items.Add(" ")
            ListBox2.Items.Add(" ")
            ListBox2.Items.Add(msg2)
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        MsgBox("Privacy Mode: All Seen Messages Will Disappear as soon as you leave the Chat",, "Privacy Mode Info")

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        If Label1.Text = "Person1" Then
            MsgBox("Chat is Already Open!!")
        Else
            PictureBox2.ImageLocation = "I:\devimages\logo1.png"
            Label1.Text = "Person1"
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
        End If
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        If Label1.Text = "Person2" Then
            MsgBox("Chat is Already Open!!")
        Else
            Label1.Text = "Person2"
            PictureBox2.ImageLocation = "I:\devimages\logo2.png"
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
        End If
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        If Label1.Text = "Person3" Then
            MsgBox("Chat is Already Open!!")
        Else
            Label1.Text = "Person3"
            PictureBox2.ImageLocation = "I:\devimages\logo3.png"
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
        End If
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        If Label1.Text = "Person4" Then
            MsgBox("Chat is Already Open!!")
        Else
            Label1.Text = "Person4"
            PictureBox2.ImageLocation = "I:\devimages\logo4.png"
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
        End If
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        If Label1.Text = "Person5" Then
            MsgBox("Chat is Already Open!!",, "Chat")
        Else
            Label1.Text = "Person5"
            PictureBox2.ImageLocation = "I:\devimages\picture4.png"
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
        End If
    End Sub

End Class