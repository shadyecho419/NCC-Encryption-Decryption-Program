Option Explicit On
Public Class frmDecrypt
    Public path As String = "C:\VBProject"
    Dim Position As Integer
    Dim First As Integer
    Dim Gap As Integer
    Dim GapHolder As Integer
    Dim FirstHolder As Integer
    Const MAX As Integer = 200
    Dim rnd As Random
    Dim GeneralInteger As Integer = 0

    Dim MessageCounter As Integer
    Dim Counter As Integer
    Dim InsCounter As Integer
    Dim TestFirst As Integer
    Dim TestGap As Integer
    Dim LengthExtractHold As Integer

    Dim HoldChar As String
    Dim chars() As Char
    Dim EncMessage As String
    Dim First200 As String = ""
    Dim Last200 As String = ""
    Dim TempStringHolder As String = ""
    Dim TempStringHolder2 As String = ""
    Dim TempStringHolder3 As String = ""
    Dim FirstRealChar As String = ""
    Dim StripMessage As String = ""
    Dim RestMessage As String = ""
    Dim ProgressHolder As String = ""
    Dim MessageStat As Boolean

    Private Sub frmDecrypt_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            MessageBox.Show("Sending message to the Recycle bin, delete message if you are done viewing it", "Secret Message- Decrypt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            My.Computer.FileSystem.DeleteFile(path & "\message.txt", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch ex As Exception
               End
        End Try
         End Sub

    Public Sub frmDecrypt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            My.Forms.LoginForm1.Close()
            EncMessage = My.Computer.FileSystem.ReadAllText(path & "\message.txt")
            MessageBox.Show("You have received a new message", "Secret Message- Decrypt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            pbProgressIndicator.Value = 0
            LengthExtractHold = EncMessage.Length
        Catch ex As Exception
            MessageBox.Show("Failed to load message from disk, verify that message exists and try again.", "Secret Message- Decrypt")
            End
        End Try
       
    End Sub

    Public Sub First200Characters()
         'this code to find first and gap like in encryption method.
        Try
            First200 = EncMessage.Substring(0, MAX)
        Catch ex As Exception
            ClearAllVariables()
            ClearAndReset()
           End Try

    End Sub
    Public Sub Last200Characters()

        Try
            'picks up last 200 characters from string block
            For InsCounter = ((EncMessage.Length - 1) - (MAX - 1)) To (EncMessage.Length - 1) 'To  'Step -1
                HoldChar = chars(InsCounter)
                Last200 &= HoldChar
            Next

        Catch ex As Exception
            ClearAllVariables()
            ClearAndReset()
        End Try

    End Sub
    Private Sub FifthVowelInFirst()
        'finding fifth vowel in first 200 characters
        Try
            Counter = 0
            For InsCounter = 0 To (First200.Length) - 1
                Select Case (First200(InsCounter))
                    Case "a", "e", "i", "o", "u", "A", "E", "I", "O", "U"
                        Counter += 1
                        If Counter = 5 Then
                            TestFirst = MAX + InsCounter
                            Exit For
                        End If
                End Select
            Next
        Catch ex As Exception
            Counter = 0
            First = 5
        End Try
    End Sub
    Private Sub ThirdVowelInLast()
        Try
            'finding 3rd vowel from end of last 200 characters
            Counter = 0
            For InsCounter = (Last200.Length) - 1 To 0 Step -1
                Select Case (Last200(InsCounter))
                    Case "a", "e", "i", "o", "u", "A", "E", "I", "O", "U"
                        Counter += 1
                        If Counter = 3 Then
                            TestGap = MAX - InsCounter
                            Exit For
                        End If
                End Select
            Next
        Catch ex As Exception
            Counter = 0
            Gap = 3

        End Try
    End Sub
    Private Sub FistAndGapFinder()
        Try
            TempStringHolder = EncMessage.Remove(GeneralInteger, MAX - 1)
            TempStringHolder2 = TempStringHolder
            TempStringHolder = ""
            TempStringHolder = TempStringHolder2.Remove(GeneralInteger, First)
            TempStringHolder2 = ""
            TempStringHolder2 = TempStringHolder
            TempStringHolder = ""
            TempStringHolder = TempStringHolder2.Substring(GeneralInteger, ((TempStringHolder2.Length - 1) - (MAX - 1)))
            TempStringHolder2 = ""
            TempStringHolder2 = TempStringHolder
            TempStringHolder = ""
            TempStringHolder = TempStringHolder2.Remove(GeneralInteger, TempStringHolder2.Length - 2)
            TempStringHolder2 = ""


            TempStringHolder3 = TempStringHolder.Chars(0)
            FirstHolder = Asc(TempStringHolder3)
            TempStringHolder3 = ""
            TempStringHolder3 = TempStringHolder.Substring(1)
            GapHolder = Asc(TempStringHolder3)
            TempStringHolder3 = ""
            TempStringHolder = ""
            FirstHolder += MAX
        Catch ex As Exception
            FirstHolder = 5
            GapHolder = 3
        End Try
    End Sub
   
    Private Sub RestMessagePicker()
        Try
            Dim TimerSet As Boolean = False
            StripMessage = EncMessage
            TempStringHolder3 = EncMessage.Remove(0, First)
            EncMessage = ""
            EncMessage = TempStringHolder3
            TempStringHolder3 = ""
            TempStringHolder3 = EncMessage.Substring(0, (EncMessage.Length - MAX))
            pbProgressIndicator.Maximum = (TempStringHolder3.Length - 1) 'this length is used in progress bar
            pbProgressIndicator.Minimum = 0

            For MessageCounter = First To (StripMessage.Length) - ((MAX)) Step (Gap + 1)
                'vb tab and space
                If StripMessage(MessageCounter) = "~" Then
                    TempStringHolder &= vbTab
                Else
                    If StripMessage(MessageCounter) = "`" Then
                        TempStringHolder &= Space(1)
                    Else
                        If StripMessage(MessageCounter) = "©" Then
                            TempStringHolder &= "~"
                        Else
                            If StripMessage(MessageCounter) = "™" Then
                                TempStringHolder &= "`"
                            Else
                                If StripMessage(MessageCounter) <> "~" And StripMessage(MessageCounter) <> "`" Then
                                    TempStringHolder &= StripMessage(MessageCounter)
                                End If
                        End If
                    End If
                End If
                end if
                'progress bar for normal and slow motion
                With pbProgressIndicator
                    Do While .Value < .Maximum
                        Slow.Interval += 1
                        If rdNormal.Checked = True Then
                            .Value += 1
                        Else
                            If rdSlow.Checked = True Then
                                If Slow.Interval Mod ((TempStringHolder3.Length) * 20) = 0 Then
                                    TimerSet = True
                                End If
                            End If
                            If TimerSet = True Then
                                .Value += 1
                                TimerSet = False
                            End If
                        End If
                    Loop
                End With
            Next
            RestMessage = TempStringHolder.Substring(0, TempStringHolder.Length - 1)
        Catch ex As Exception
            ClearAndReset()
            ClearAllVariables()
            End Try

    End Sub
    Private Sub btnDecrypt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
        rnd = New Random
        chars = CType(EncMessage, Char())

        'finds first 200 characters in message block
        First200Characters()

        'finds last 200 characters in message block
        Last200Characters()

        'tests to see if first is true
        FifthVowelInFirst()

        'tests to see if gap is true
        ThirdVowelInLast()

        'finds first and gap from ascii codes
        FistAndGapFinder()
        'security check, see if first and gap from file is the same as that from block
        FirstAndGapCompare()

        'picks the rest of the characters in the message
        RestMessagePicker()

        'displays message
        txtRealMessage.Text = RestMessage

        'clears all strings used
        ClearAllVariables()
        EncMessage = My.Computer.FileSystem.ReadAllText(path & "\message.txt")
    End Sub

    Private Sub btnClear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearAndReset()
    End Sub
    Private Sub ClearAndReset()
        Try
            txtRealMessage.Clear()
            ClearAllVariables()
            EncMessage = My.Computer.FileSystem.ReadAllText(path & "\message.txt")
            pbProgressIndicator.Value = 0
        Catch ex As Exception
            MessageBox.Show("Failed to load file from disk, verify that file exists and try again.", "Secret Message- Decrypt")
            End
        End Try

    End Sub
    Private Sub ClearAllVariables()
        Try
            TempStringHolder2 = ""
            TempStringHolder = ""
            TempStringHolder3 = ""
            HoldChar = ""
            FirstRealChar = ""
            RestMessage = ""
            StripMessage = ""
            Last200 = ""
            First200 = ""
            First = 5
            Gap = 3
            TestFirst = 0
            TestGap = 0
        Catch ex As Exception
            ClearAndReset()

        End Try
    End Sub
    Private Sub chkSlowEnable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSlowEnable.CheckedChanged
        SlowMotionEnable()
    End Sub
    Private Sub SlowMotionEnable()
        chkSlowDisable.Checked = False
        If chkSlowEnable.Checked = True Then
            txtPassword.Visible = True
            btnEnterPassword.Visible = True
            txtPassword.Focus()
            chkSlowEnable.Visible = False
            lblPassword.Visible = True
        Else
            Exit Sub
        End If
    End Sub
    Private Sub chkSlowDisable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSlowDisable.CheckedChanged
        If chkSlowDisable.Checked = True Then
            txtPassword.Visible = False
            btnEnterPassword.Visible = False
            chkSlowEnable.Visible = True
            chkSlowEnable.Checked = False
            chkSlowDisable.Visible = False
            gbSlow.Visible = False
            rdNormal.Checked = True
            rdSlow.Checked = False
            lblPassword.Visible = False
        End If
    End Sub
    Private Sub btnEnterPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterPassword.Click
        PasswordEnter()
    End Sub
    Private Sub PasswordEnter()

        If txtPassword.Text = "test" Then
            gbSlow.Visible = True
            chkSlowEnable.Visible = False
            txtPassword.Clear()
            txtPassword.Visible = False
            btnEnterPassword.Visible = False
            lblPassword.Visible = False
            chkSlowDisable.Visible = True
        Else
            MessageBox.Show("Wrong Password,Please try again.", "Secret Message- Decrypt")
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub
    Private Function FirstAndGapCompare() As Boolean
        Try
            If TestFirst = FirstHolder And TestGap = GapHolder Then
                FirstAndGapCompare = True
            Else
                FirstAndGapCompare = False
            End If
            If FirstAndGapCompare = True Then
                'assign first and gap information to variables and decode message
                First = FirstHolder
                Gap = GapHolder
            Else
                MessageBox.Show("Message from Sender has been corrupted, delete message", "Secret Message- Decrypt", MessageBoxButtons.OK, MessageBoxIcon.Error)
                My.Computer.FileSystem.DeleteFile(path & "\message.txt", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently)
                End
            End If
        Catch ex As Exception
            MessageBox.Show("Message not deleted, program is closing", "Secret Message- Decrypt", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
       
    End Function
End Class
