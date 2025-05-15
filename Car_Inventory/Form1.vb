Option Strict On
Imports Car_Inventory_Library
Public Class Form1
    Private strSpecialChars() As String = {"!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "-", "=", "+", "[", "]", "\", "{", "}", "|", ":", ";", "'", ",", ".", "/", "<", ">", "?"}
    Private objCurrentVehicle As Object
    Friend objNormal As NormalClass
    Private objConvertible As ConvertibleClass
    Private VehicleList As New List(Of Object)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strNumber As String
        Dim intYear As Integer
        Dim dblMileage As Double
        Dim strMake As String
        Dim strModel As String
        Dim decStandardPrice As Decimal
        Dim decStickerPrice As Decimal
        Dim strColor As String = "White"

        Try
            If tbxNumber.Text.Length > 16 AndAlso tbxNumber.Text <> "" AndAlso tbxMake.Text <> "" AndAlso tbxMileage.Text <> "" AndAlso
                tbxModel.Text <> "" AndAlso tbxYear.Text <> "" AndAlso tbxStandardPrice.Text <> "" AndAlso cboColor.Text <> "" Then
                strNumber = tbxNumber.Text
                Dim boolSpecial As Boolean
                For intControl As Integer = 0 To 28
                    If strNumber.Contains(strSpecialChars(intControl)) Then
                        boolSpecial = True
                        intControl = 29
                    End If
                Next
                If boolSpecial Then
                    MsgBox("VIN contains special characters", MsgBoxStyle.OkOnly)
                    tbxNumber.Text = ""
                Else
                    intYear = Convert.ToInt32(tbxYear.Text)
                    dblMileage = Convert.ToDouble(tbxMileage.Text)
                    strMake = tbxMake.Text
                    decStandardPrice = Convert.ToDecimal(tbxStandardPrice.Text)
                    strModel = tbxModel.Text

                    'Get seleceted Color
                    strColor = cboColor.Text

                    'Create instance of proper class
                    If cbxConvertible.Checked Then
                        objConvertible = New ConvertibleClass(strColor, strMake, strModel, strNumber, intYear, dblMileage, cbxConvertible.Checked, decStandardPrice)
                        decStickerPrice = objConvertible.CalculatePrice()
                        VehicleList.Add(objConvertible)

                    Else
                        objNormal = New NormalClass(strColor, strMake, strModel, strNumber, intYear, dblMileage, cbxConvertible.Checked, decStandardPrice)
                        decStickerPrice = objNormal.CalculatePrice()
                        VehicleList.Add(objNormal)
                    End If

                    lstInventory.Items.Add(strNumber)
                    lblStickerPrice.Text = "Sticker Price: " & decStickerPrice.ToString("C2")
                End If

            Else
                MsgBox("Enter Proper Values", MsgBoxStyle.OkOnly)
                tbxNumber.Text = ""
                tbxMake.Text = ""
                tbxMileage.Text = ""
                tbxModel.Text = ""
                tbxYear.Text = ""
                cboColor.Text = ""
                tbxStandardPrice.Text = ""
            End If
        Catch ex As FormatException
            MsgBox("Format Error", MsgBoxStyle.OkOnly)
        Catch ex As OverflowException
            MsgBox("Overflow Error", MsgBoxStyle.OkOnly)
        Catch ex As SystemException
            MsgBox("Unkown Error", MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub btnDisplayInventory_Click(sender As Object, e As EventArgs)
        frmFileViewer.Show()
    End Sub
    Private Sub lstInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstInventory.SelectedIndexChanged
        Try
            Dim intIndex As Integer
            intIndex = lstInventory.SelectedIndex
            objCurrentVehicle = VehicleList.Item(intIndex)
            If objCurrentVehicle.GetType() = objConvertible.GetType() Then
                objConvertible = CType(objCurrentVehicle, ConvertibleClass)
                tbxMake.Text = objConvertible.Make()
                tbxModel.Text = objConvertible.Model()
                cboColor.Text = objConvertible.Color()
                tbxNumber.Text = objConvertible.Number().ToString
                tbxMileage.Text = objConvertible.Mileage().ToString()
                cbxConvertible.Checked = objConvertible.Convertible()
                lblStickerPrice.Text = "Sticker Price: " & objConvertible.StickerPrice().ToString("C")
                tbxStandardPrice.Text = objConvertible.StandardPrice().ToString("C")
            Else
                objNormal = CType(objCurrentVehicle, NormalClass)
                tbxMake.Text = objNormal.Make()
                tbxModel.Text = objNormal.Model()
                cboColor.Text = objNormal.Color()
                tbxNumber.Text = objNormal.Number().ToString
                tbxMileage.Text = objNormal.Mileage().ToString()
                cbxConvertible.Checked = objNormal.Convertible()
                lblStickerPrice.Text = "Sticker Price: " & objNormal.StickerPrice().ToString("C")
                tbxStandardPrice.Text = objNormal.StandardPrice().ToString("C")
            End If
        Catch ex As System.ArgumentOutOfRangeException
            MsgBox("Out Of Range", MsgBoxStyle.OkOnly)
        Catch ex As System.NullReferenceException
            MsgBox("Null", MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub DisplayCurrentInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayCurrentInventoryToolStripMenuItem.Click
        frmFileViewer.Show()
    End Sub

    Private Sub CloseFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseFormToolStripMenuItem.Click
        Close()
    End Sub
End Class
