Public Class Form1
    Dim status As Integer
    Dim nameVoxl As String = "You have not set a name yet! Tell voxl 'My name is !' and then your name for voxl to know you."
    Private Sub FlatClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatClose1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        FlatProgressBar1.Value += 1
        If FlatProgressBar1.Value = 100 Then
            FlatProgressBar1.Value = 0
        End If
        If chat.SelectedItem = "" Then
        Else
            My.Computer.Clipboard.SetText(chat.SelectedItem)
        End If

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click
        chat.AddItem("You: " + msg.Text)
        If msg.Text.Contains("yo ") Or msg.Text.Contains("hello ") Or msg.Text.Contains("hi ") Then
            chat.AddItem("VOXL: hi!")
        ElseIf msg.Text.Contains("my name is !") Then
            Dim argument As String = msg.Text.Split("!"c)(1)
            nameVoxl = argument
            chat.AddItem("Nice to meet you, " + nameVoxl + "!")
        ElseIf msg.Text.Contains("what is my name") Then
            chat.AddItem("Your name is '" + nameVoxl + "'. Why didn't you know that already?")
        ElseIf msg.Text.Contains("who are you") Then
            chat.AddItem("...")
        ElseIf msg.Text.Contains("version") Or msg.Text.Contains("ver") Then
            chat.AddItem("Version: 1.0 alpha. The source code is availible on:" + vbNewLine + "github.com/duckiety/")
        ElseIf msg.Text.Contains("fuck") Or msg.Text.Contains("shit") Or msg.Text.Contains("nigger") Or msg.Text.Contains("nigga") Or msg.Text.Contains("cunt") Then
            msg.Text = "http://giphy.com/gifs/fuck-you-go-yourself-forget-xT0GqCrlLMD42vUq8U"
            'chat.items.Clear()
            chat.AddItem("http://giphy.com/gifs/fuck-you-go-yourself-forget-xT0GqCrlLMD42vUq8U")
            swearprotection.Show()
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MessageBox.Show("in order for VOXL to detect your message, put a space after your message if you have only put 1 word in. Also, if you click on  a message sent in chat, VOXL automatically copys it for you.")
        Dim size As String = "300,300"

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        status += 1
        FlatStatusBar1.Text = "status: on. Thanks for using VOXL.  " + status.ToString
    End Sub

    Private Sub msg_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub
End Class
