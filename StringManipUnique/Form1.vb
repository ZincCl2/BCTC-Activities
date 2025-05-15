'Count the number of vowels or consonants in a word

Option Strict On
Public Class Form1
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Dim strWordFull As String
        Dim strWord As String
        Dim strVow As String = ""
        Dim strVowTemp As String = ""
        Dim intInsert As Integer = 0
        Dim intIteration As Integer = 0
        Dim intIndex As Integer
        Dim intChecks As Integer = 0
        Try
            strWordFull = tbxWord.Text
            strWord = strWordFull.ToLower

            Do
                intChecks = 0

                If strWord.Contains("a") Then
                    intIndex = strWord.IndexOf("a")
                    strVowTemp = strWord.Substring(intIndex, 1)
                    strVow = strVow.Insert(intInsert, strVowTemp)
                    strWord = strWord.Remove(intIndex, 1)
                    intInsert += 1
                    intChecks += 1
                End If
                If strWord.Contains("e") Then

                    intIndex = strWord.IndexOf("e")
                    strVowTemp = strWord.Substring(intIndex, 1)
                    strVow = strVow.Insert(intInsert, strVowTemp)
                    strWord = strWord.Remove(intIndex, 1)
                    intInsert += 1
                    intChecks += 1
                End If
                If strWord.Contains("i") Then
                    intIndex = strWord.IndexOf("i")
                    strVowTemp = strWord.Substring(intIndex, 1)
                    strVow = strVow.Insert(intInsert, strVowTemp)
                    strWord = strWord.Remove(intIndex, 1)
                    intInsert += 1
                    intChecks += 1
                End If
                If strWord.Contains("o") Then
                    intIndex = strWord.IndexOf("o")
                    strVowTemp = strWord.Substring(intIndex, 1)
                    strVow = strVow.Insert(intInsert, strVowTemp)
                    strWord = strWord.Remove(intIndex, 1)
                    intInsert += 1
                    intChecks += 1
                End If
                If strWord.Contains("u") Then

                    intIndex = strWord.IndexOf("u")
                    strVowTemp = strWord.Substring(intIndex, 1)
                    strVow = strVow.Insert(intInsert, strVowTemp)
                    strWord = strWord.Remove(intIndex, 1)
                    intInsert += 1
                    intChecks += 1

                End If

            Loop While intChecks <> 0

            lblCons.Text = "Number of Consonants: " & strWordFull.Length - strVow.Length
            lblVow.Text = "Number of Vowels: " & strVow.Length

        Catch ex As FormatException
            MsgBox("Can't Convert Value", MsgBoxStyle.Critical)
        Catch ex As OverflowException
            MsgBox("Value to large", MsgBoxStyle.Critical)
        Catch ex As NullReferenceException
            MsgBox("Null Reference", MsgBoxStyle.Critical)
        Catch ex As SystemException
            MsgBox("Unexpected Error", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class