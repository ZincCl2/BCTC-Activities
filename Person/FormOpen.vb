Option Strict On
Imports PersonClassLibrary
Public Class frmOpen

    Friend UninsuredPerson As ClassPerson
    Friend InsuredPerson As Insured
    Friend CurrentPerson As Object
    Friend PersonList As New List(Of Object)
    Friend intNameIndex As Integer
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim strNameAdd As String
            Dim dblWeightAdd As Double
            Dim decPayRateAdd As Decimal
            Dim decSavingsAdd As Decimal
            strNameAdd = tbxName.Text
            If strNameAdd <> "" Then
                dblWeightAdd = Convert.ToDouble(tbxWeight.Text)
                decPayRateAdd = Convert.ToDecimal(tbxPayRate.Text)
                decSavingsAdd = Convert.ToDecimal(tbxSavings.Text)
                lbxNames.Items.Add(strNameAdd)
                If cbxMedical.Checked Or cbxVision.Checked Or cbxDental.Checked Then
                    InsuredPerson = New Insured(strNameAdd, dblWeightAdd, decPayRateAdd, decSavingsAdd, cbxMedical.Checked, cbxDental.Checked, cbxVision.Checked)
                    PersonList.Add(InsuredPerson)
                Else
                    UninsuredPerson = New ClassPerson(strNameAdd, dblWeightAdd, decPayRateAdd, decSavingsAdd)
                    PersonList.Add(UninsuredPerson)
                End If
            End If
        Catch ex As FormatException
            MsgBox("Format Error", MsgBoxStyle.OkOnly)
            tbxName.Text = ""
            tbxWeight.Text = ""
            tbxPayRate.Text = ""
            tbxSavings.Text = ""
        Catch ex As OverflowException
            MsgBox("Value Too Large", MsgBoxStyle.OkOnly)
            tbxName.Text = ""
            tbxWeight.Text = ""
            tbxPayRate.Text = ""
            tbxSavings.Text = ""
        Catch ex As SystemException
            MsgBox("Unknown Error", MsgBoxStyle.OkOnly)
            tbxName.Text = ""
            tbxWeight.Text = ""
            tbxPayRate.Text = ""
            tbxSavings.Text = ""
        End Try
    End Sub
    Private Sub lbxNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxNames.SelectedIndexChanged
        Try
            intNameIndex = lbxNames.SelectedIndex
            CurrentPerson = PersonList.Item(intNameIndex)
            frmPerson.Show()
            Hide()
        Catch ex As System.ArgumentOutOfRangeException
            MsgBox("Out Of Range")
        Catch ex As System.NullReferenceException
            MsgBox("Null")
        End Try
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class