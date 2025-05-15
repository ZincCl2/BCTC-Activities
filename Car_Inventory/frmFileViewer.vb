Imports Car_Inventory_Library
Imports System.Reflection


Public Class frmFileViewer
    Private boolImported As Boolean = False
    Private intfilelength As Integer
    Private index As Integer
    Public Event Read(sender As Object, e As MyEventArgs)
    Private WithEvents objInventoryRead As New InventoryFileClass
    Private Sub frmFileViewer_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        objInventoryRead.RaiseRead()
    End Sub
    Sub DisplayData(e As MyEventArgs)
        Try

            lstImportInventory.Items.Add(e._Make & ", " & e._Model & ", " & e._Year & ", " & e._Number & ", " & e._Mileage & ", " & e._Convertible & ", " & e._StickerPrice)

        Catch ex As ArgumentNullException
            MsgBox("Null", MsgBoxStyle.OkOnly)
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class