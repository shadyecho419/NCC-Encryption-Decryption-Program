Option Explicit On

Public Class frmEncyrptMain

    Dim First200 As String
    Dim Second200 As String
    Dim HoldChar As String
    Dim FirstCharRandom As String = ""
    Dim TempStringHolder As String = ""
    Dim MessageChar As String = ""
    Dim EncMessage As String = ""
    Dim Str As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Dim TextMessage As String
    Dim chars() As Char

    Dim MessageLength As Integer
    Dim IntervalMultiplier As Integer
    Dim MessageEndCounter As Integer
    Dim Counter As Integer
    Dim InsCounter As Integer
    Dim Position As Integer
    Dim First As Integer = 5
    Dim Gap As Integer = 3
    Dim IntervalHolder As Integer
    Dim ProgressHolder As Integer
    Dim FirstHolder As Char = ""
    Dim GapHolder As Char = ""

    Dim rnd As Random
    Const MAX As Integer = 200
    Const MIN As Integer = 1

    Dim progress As Integer = 0
    Public path As String = "C:\VBProject"

    Dim dgSlowMotion As New DataGridView

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearRefresh()
    End Sub
    Private Sub ClearRefresh()

        txtEncryptedMessage.Clear()
        txtMessageToEncrypt.Focus()
        pbProgressIndicator.Value = 0
        dgSlowMotion.Rows.Clear()
    End Sub
    Private Sub First200Characters()
        First200 = ""
        Try
            For Counter = MIN To MAX
                First200 &= Str.Chars(rnd.Next(Str.Length))

            Next
        Catch ex As Exception
              ClearVariables()
            ClearRefresh()
        End Try
    End Sub

    Private Sub Last200Characters()
        Second200 = ""

        Try
            For Counter = MIN To MAX
                Second200 &= Str.Chars(rnd.Next(Str.Length))
            Next
        Catch ex As Exception
             ClearVariables()
            ClearRefresh()
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
                            First = MAX + InsCounter
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
            For InsCounter = (Second200.Length) - 1 To 0 Step -1
                Select Case (Second200(InsCounter))
                    Case "a", "e", "i", "o", "u", "A", "E", "I", "O", "U"
                        Counter += 1
                        If Counter = 3 Then
                            Gap = MAX - InsCounter
                            Exit For
                        End If
                End Select
            Next
        Catch ex As Exception
            Counter = 0
            Gap = 3
        End Try
    End Sub
    Private Sub AfterFirstCharRandom()
        Try
            For InsCounter = ((First200.Length)) To (First - 1)
                FirstCharRandom &= Str.Chars(rnd.Next(Str.Length))
            Next

        Catch ex As Exception
            FirstCharRandom = ""
            ClearVariables()
            ClearRefresh()
        End Try
    End Sub
    Private Sub RestMessageFill()
        Dim TimerSet As Boolean = False
        Slow.Enabled = True
        pbProgressIndicator.Value = 0
        pbProgressIndicator.Maximum = chars.Length
        Try
           
            For MessageEndCounter = 0 To chars.Length - 1

                For Counter = 0 To 1
                    HoldChar = chars(MessageEndCounter)
                Next

                If chars(MessageEndCounter) = vbTab Then
                    TempStringHolder &= "~" & RandomGapCharacterGenerator()
                Else
                    
                    If chars(MessageEndCounter) = Space(1) Then
                        TempStringHolder &= "`" & RandomGapCharacterGenerator()
                    Else
                        If chars(MessageEndCounter) = "~" Then
                            TempStringHolder &= "©" & RandomGapCharacterGenerator()
                        Else
                            If chars(MessageEndCounter) = "`" Then
                                TempStringHolder &= "™" & RandomGapCharacterGenerator()
                            Else
                                TempStringHolder &= HoldChar & RandomGapCharacterGenerator()
                            End If
                        End If
                    End If
                End If
                'progress bar for normal and slow motion
                With pbProgressIndicator
                    Do While .Value < .Maximum
                        Slow.Interval += 1
                        If rdNormal.Checked = True Then
                            .Value += 1
                        Else
                            If rdSlow.Checked = True Then
                                If Slow.Interval Mod ((TextMessage.Length) * 25) = 0 Then
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
            Slow.Enabled = False
        Catch ex As Exception
               ClearRefresh()
            ClearVariables()
        End Try
    End Sub
    Private Sub IntoOneBlock()
       
        Try
            EncMessage = TempStringHolder & FirstHolder & GapHolder
            TempStringHolder = ""
            MessageChar = First200 & FirstCharRandom & EncMessage & Second200
            txtEncryptedMessage.Text = MessageChar
        Catch ex As Exception
            ClearVariables()
            ClearRefresh()
        End Try

    End Sub
    Public Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        rnd = New Random
        TextMessage = txtMessageToEncrypt.Text
        chars = CType(TextMessage, Char())
        EncMessage = ""
        FirstCharRandom = ""
        MessageChar = ""

        Try
       
            'generating first 200 random characters at the start of the message
            First200Characters()

            'generating second 200 random characters at the end of the message
            Last200Characters()

            'checks for the fifth vowel from the end of first 200 characters
            FifthVowelInFirst()

            'checks for the 3rd vowel from the end of the last 200 characters
            ThirdVowelInLast()

            'generates random character before first character 
            AfterFirstCharRandom()

            'fill in the rest of the characters reading character after character in the real message and putting it into the encryption
            RestMessageFill()

            'generate ascii codes for first and gap
            firstandgap()

            'put everything into one block
            IntoOneBlock()

            'clear all variables used in program
            ClearVariables()

        Catch ex As Exception
             ClearVariables()
            ClearRefresh()

        End Try

    End Sub
    Public Function RandomGapCharacterGenerator()
        'generate random characters in-between gap
        RandomGapCharacterGenerator = ""
        Try
            For Counter = 0 To Gap - 1
                RandomGapCharacterGenerator &= Str.Chars(rnd.Next(Str.Length))
            Next
        Catch ex As Exception
               RandomGapCharacterGenerator = ""
            ClearVariables()
            ClearRefresh()
        End Try
    End Function
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim folderExists As Boolean

        Try
            folderExists = My.Computer.FileSystem.DirectoryExists(path)
            If folderExists = True Then
                Exit Try
            Else
                My.Computer.FileSystem.CreateDirectory(path)
            End If
        Catch ex As Exception
        End Try


        Try
            Dim fileExists As Boolean
            fileExists = My.Computer.FileSystem.FileExists(path & "\message.txt")
            If fileExists = True Then
                MessageBox.Show("Your last message to the receiver was not deleted, delete now to send a new message", "Secret Message- Encrypt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                My.Computer.FileSystem.DeleteFile(path & "\message.txt", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently)
                My.Computer.FileSystem.WriteAllText(path & "\message.txt", txtEncryptedMessage.Text, True)
                txtEncryptedMessage.Clear()
                txtMessageToEncrypt.Clear()
                MessageBox.Show("Your message has been sent to the recipient", "Secret Message- Encrypt", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                My.Computer.FileSystem.WriteAllText(path & "\message.txt", txtEncryptedMessage.Text, True)
                txtEncryptedMessage.Clear()
                txtMessageToEncrypt.Clear()
                MessageBox.Show("Your message has been sent to the recipient", "Secret Message- Encrypt", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If

        Catch ex As Exception
            
        End Try
    End Sub
    Private Sub ClearVariables()
        First200 = ""
        Second200 = ""
        HoldChar = ""
        FirstCharRandom = ""
        TempStringHolder = ""
        MessageChar = ""
        EncMessage = ""
        TextMessage = ""
        chars = ""
        FirstHolder = ""
        GapHolder = ""

        MessageEndCounter = 0
        Counter = 0
        InsCounter = 0
        Position = 0
        First = 0
        Gap = 0

    End Sub
    Private Sub firstandgap()
        Try
            FirstHolder = Chr(First - MAX)
            GapHolder = Chr(Gap)
        Catch ex As Exception
           FirstHolder = Chr(5)
            GapHolder = Chr(3)
        End Try

    End Sub

    Private Sub frmEncyrptMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtMessageToEncrypt.Focus()
        pbProgressIndicator.Value = 0
        My.Forms.frmLogin.Close()
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

    Private Sub btnEnterPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterPassword.Click
        PasswordEnter()
    End Sub

    Private Sub PasswordEnter()
        If txtPassword.Text = "test" Then
            gbSlow.Visible = True
            chkSlowEnable.Visible = False
            txtMessageToEncrypt.Focus()
            txtPassword.Clear()
            txtPassword.Visible = False
            btnEnterPassword.Visible = False
            lblPassword.Visible = False
            chkSlowDisable.Visible = True
        Else
            MessageBox.Show("Wrong Password, please try again", "Secret Message- Encrypt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Clear()
            txtPassword.Focus()
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
   
   
End Class
