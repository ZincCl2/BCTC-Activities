Option Strict On
Imports System.IO

Public Class InventoryFileClass
    Private strFileLocation As String = "C:\Users\ScoGen814\OneDrive - Berks Career & Technology Center\Level_2\Programs\VB\Car_Inventory_Library\Event_Inventory.txt"
    Public Event WriteData(sender As Object, e As MyEventArgs)

    Private Sub objInventoryFile_WriteData(sender As Object, e As MyEventArgs) Handles Me.WriteData
        Write(e._Color, e._Make, e._Model, e._Number, e._Year, e._Mileage, e._Convertible, e._StickerPrice)
    End Sub
    Public Sub RaiseWrite(strColorR As String, strMakeR As String, strModelR As String, strNumberR As String, intYearR As Integer, dblMileageR As Double, ConvertibleR As Boolean, decStickerPriceR As Decimal)
        RaiseEvent WriteData(Me, New MyEventArgs(strColorR, strMakeR, strModelR, strNumberR, intYearR, dblMileageR, ConvertibleR, decStickerPriceR))
    End Sub

    Public Event ReadFile(sender As Object, e As MyEventArgs)

    Private Sub objInventoryRead_ReadFile(sender As Object, e As MyEventArgs) Handles Me.ReadFile
        Read(e._Color, e._Make, e._Model, e._Number, e._Year, e._Mileage, e._Convertible, e._StickerPrice)
    End Sub
    Public Sub RaiseRead()
        RaiseEvent ReadFile(Me, New MyEventArgs("", "", "", "", 0, 0.0, False, 0))
    End Sub

    Sub Write(strColor As String, strMake As String, strModel As String, strNumber As String, intYear As Integer, dblMileage As Double, Convertible As Boolean, decStickerPrice As Decimal)
        Try
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(strFileLocation)
            objWriter.Write(strMake & ",")
            objWriter.Write(strModel & ",")
            objWriter.Write(strColor & ",")
            objWriter.Write(intYear & ",")
            objWriter.Write(strNumber & ",")
            objWriter.Write(dblMileage & ",")
            objWriter.Write(Convertible & ",")
            objWriter.WriteLine(decStickerPrice)
            objWriter.Close()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Read(ByRef strColor As String, ByRef strMake As String, ByRef strModel As String, ByRef strNumber As String, ByRef intYear As Integer, ByRef dblMileage As Double, ByRef Convertible As Boolean, ByRef decStickerPrice As Decimal)
        Dim objReader As New StreamReader(strFileLocation)
        Dim strSplitArray() As String
        strSplitArray = Split(objReader.ReadLine(), ",")
        strMake = strSplitArray(0)
        strModel = strSplitArray(1)
        strColor = strSplitArray(2)
        intYear = Convert.ToInt32(strSplitArray(3))
        strNumber = strSplitArray(4)
        dblMileage = Convert.ToDouble(strSplitArray(5))
        Convertible = Convert.ToBoolean(strSplitArray(6))
        decStickerPrice = Convert.ToDecimal(strSplitArray(7))

    End Sub
End Class
