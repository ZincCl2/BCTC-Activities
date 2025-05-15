Option Strict On
Public Class ConvertibleClass
    Inherits NormalClass
    Sub New(strColor As String, strMake As String, strModel As String, strNumber As String, intYear As Integer, dblMileage As Double, Convertible As Boolean, decStandardPrice As Decimal)
        MyBase.New(strColor, strMake, strModel, strNumber, intYear, dblMileage, Convertible, decStandardPrice)

    End Sub
    Public Overrides Function CalculatePrice() As Decimal
        If strCarColor = "Black" Then
            decCarStickerPrice = decCarStandardPrice - (decCarStandardPrice * 0.15D)
        ElseIf strCarColor = "Dark Gray" Then
            decCarStickerPrice = decCarStandardPrice * 1.21D
        ElseIf strCarColor = "Red" Then
            decCarStickerPrice = decCarStandardPrice * 1.09D
        Else
            decCarStickerPrice = decCarStandardPrice
        End If
        decCarStickerPrice *= 1.26D
        objInventoryFile = New InventoryFileClass
        objInventoryFile.RaiseWrite(strCarColor, strCarMake, strCarModel, strCarNumber, intCarYear, dblCarMileage, boolCarConvertible, decCarStickerPrice)
        Return decCarStickerPrice
    End Function
End Class
