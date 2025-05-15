Option Strict On
Imports System.Runtime.Remoting.Channels

Public Class PersonPayCheck

    Public Event WriteData(sender As Object, e As MyEventArgs)

    Private Sub objPayCheckFile_WriteData(sender As Object, e As MyEventArgs) Handles Me.WriteData
        WriteRecord(e._strName, e._decPayCheck, e._decPayRate, e._dblWeight, e._decSavings, e._MedicalInsured, e._VisionInsured, e._DentalInsured)
    End Sub

    Public Sub RaiseWrite(_strName As String, decPayCheck As Decimal, decPayRate As Decimal, dblWeight As Double, decSavings As Decimal,
        boolMedicalInsured As Boolean, boolVisionInsured As Boolean, boolDentalInsured As Boolean)
        RaiseEvent WriteData(Me, New MyEventArgs(_strName, decPayCheck, decPayRate, dblWeight, decSavings, boolMedicalInsured, boolVisionInsured, boolDentalInsured))
    End Sub

    Sub WriteRecord(strName As String, decPayCheck As Decimal, decPayRate As Decimal, dblWeight As Double, decSavings As Decimal, boolMedicalInsured As Boolean, boolVisionInsured As Boolean, boolDentalInsured As Boolean)

        Try
            Dim strFileLocation As String = "C:\Users\ScoGen814\OneDrive - Berks Career & Technology Center\Level_2\Programs\VB\PersonClassLibrary\PayChecks.txt"
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(strFileLocation)
            objWriter.Write(strName & ",")
            objWriter.Write(decPayRate & ",")
            objWriter.Write(decPayCheck & ",")
            objWriter.Write(decSavings & ",")
            objWriter.Write(dblWeight & ",")
            objWriter.Write(boolVisionInsured & ",")
            objWriter.Write(boolMedicalInsured & ",")
            objWriter.WriteLine(boolDentalInsured)
            objWriter.Close()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
