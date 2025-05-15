Option Strict On
Imports PersonClassLibrary
Public Class frmPerson

    Private Sub frmPerson_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If frmOpen.CurrentPerson.GetType() = frmOpen.InsuredPerson.GetType() Then
            frmOpen.InsuredPerson = CType(frmOpen.CurrentPerson, Insured)
            lblDefaultWeight.Text = "Current Weight: " & frmOpen.InsuredPerson.Eat() & " lbs"
            lblName.Text = "Name: " & frmOpen.InsuredPerson.Name()
            lblPromotion.Text = "PayRate: " & frmOpen.InsuredPerson.Promotion().ToString("C")
            If frmOpen.InsuredPerson.Dental() Then
                cbxDental.Checked = True
            End If
            If frmOpen.InsuredPerson.Medical() Then
                cbxMedical.Checked = True
            End If
            If frmOpen.InsuredPerson.Vision() Then
                cbxVision.Checked = True
            End If
        Else
            frmOpen.UninsuredPerson = CType(frmOpen.CurrentPerson, ClassPerson)
            lblDefaultWeight.Text = "Current Weight: " & frmOpen.UninsuredPerson.Eat() & " lbs"
            lblName.Text = "Name: " & frmOpen.UninsuredPerson.Name()
            lblPromotion.Text = "PayRate: " & frmOpen.UninsuredPerson.Promotion().ToString("C")
        End If
    End Sub
    Private Sub btnEat_Click(sender As Object, e As EventArgs) Handles btnEat.Click
        Dim dblPoundsEaten As Double
        dblPoundsEaten = Convert.ToDouble(InputBox("Enter pounds of food eaten", "Eat", "4"))
        If frmOpen.CurrentPerson.GetType() = frmOpen.InsuredPerson.GetType() Then
            frmOpen.InsuredPerson = CType(frmOpen.CurrentPerson, Insured)
            frmOpen.InsuredPerson.sEat(dblPoundsEaten)
            lblWeight.Text = "Current Weight: " & frmOpen.InsuredPerson.Eat() & " lbs."
        Else
            frmOpen.UninsuredPerson = CType(frmOpen.CurrentPerson, ClassPerson)
            frmOpen.UninsuredPerson.sEat(dblPoundsEaten)
            lblWeight.Text = "Current Weight: " & frmOpen.UninsuredPerson.Eat() & " lbs."
        End If
    End Sub
    Private Sub btnExercise_Click(sender As Object, e As EventArgs) Handles btnExercise.Click
        Dim intMinExercised As Integer
        intMinExercised = Convert.ToInt32(InputBox("Enter # of minutes exercised", "Exercise", "40"))
        If frmOpen.CurrentPerson.GetType() = frmOpen.InsuredPerson.GetType() Then
            frmOpen.InsuredPerson = CType(frmOpen.CurrentPerson, Insured)
            frmOpen.InsuredPerson.sExercise(intMinExercised)
            lblWeight.Text = "Current Weight: " & frmOpen.InsuredPerson.Exercise() & " lbs."
        Else
            frmOpen.UninsuredPerson = CType(frmOpen.CurrentPerson, ClassPerson)
            frmOpen.UninsuredPerson.sExercise(intMinExercised)
            lblWeight.Text = "Current Weight: " & frmOpen.UninsuredPerson.Exercise() & " lbs."
        End If
    End Sub
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim intHoursWorked As Integer
        Dim PayCheck As Decimal
        intHoursWorked = Convert.ToInt32(InputBox("Enter # of hours Worked", "Pay", "40"))
        If frmOpen.CurrentPerson.GetType() = frmOpen.InsuredPerson.GetType() Then
            frmOpen.InsuredPerson = CType(frmOpen.CurrentPerson, Insured)
            frmOpen.InsuredPerson.sPayCheck(intHoursWorked)
            PayCheck = frmOpen.InsuredPerson.PayCheck()
        Else
            frmOpen.UninsuredPerson = CType(frmOpen.CurrentPerson, ClassPerson)
            frmOpen.UninsuredPerson.sPayCheck(intHoursWorked)
            PayCheck = frmOpen.UninsuredPerson.PayCheck()
        End If
        lblPayCheck.Text = "Pay Check: " & PayCheck.ToString("C")

    End Sub
    Private Sub btnPromote_Click(sender As Object, e As EventArgs) Handles btnPromote.Click
        Dim PayRate As Decimal
        If frmOpen.CurrentPerson.GetType() = frmOpen.InsuredPerson.GetType() Then
            frmOpen.InsuredPerson = CType(frmOpen.CurrentPerson, Insured)
            frmOpen.InsuredPerson.sPromotion()
            PayRate = frmOpen.InsuredPerson.Promotion()
        Else
            frmOpen.UninsuredPerson = CType(frmOpen.CurrentPerson, ClassPerson)
            frmOpen.UninsuredPerson.sPromotion()
            PayRate = frmOpen.UninsuredPerson.Promotion()
        End If
        lblPromotion.Text = "PayRate: " & PayRate.ToString("C")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If frmOpen.CurrentPerson.GetType() = frmOpen.InsuredPerson.GetType() Then
            frmOpen.InsuredPerson = CType(frmOpen.CurrentPerson, Insured)
            frmOpen.PersonList(frmOpen.intNameIndex) = frmOpen.InsuredPerson
        Else
            frmOpen.UninsuredPerson = CType(frmOpen.CurrentPerson, ClassPerson)
            frmOpen.PersonList(frmOpen.intNameIndex) = frmOpen.UninsuredPerson
        End If
        frmOpen.Show()
        Close()
    End Sub
End Class