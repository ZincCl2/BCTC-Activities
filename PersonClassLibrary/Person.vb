Option Strict On
Public Class ClassPerson
    Protected WithEvents objPaycheckFile As PersonPayCheck
    Protected strName As String
    Protected dblWeight As Double
    Protected decSavings As Decimal
    Protected decPayCheck As Decimal
    Protected decPayRate As Decimal
    Sub New(ByVal strNameAdd As String, ByVal dblWeightAdd As Double, ByVal decPayRateAdd As Decimal, ByVal decSavingsAdd As Decimal)
        strName = strNameAdd
        dblWeight = dblWeightAdd
        decPayRate = decPayRateAdd
        decSavings = decSavingsAdd
    End Sub
    Function Name() As String
        Return strName
    End Function
    Sub sEat(ByVal dblPoundsEaten As Double)
        dblWeight += dblPoundsEaten
    End Sub
    Function Eat() As Double
        Return dblWeight
    End Function
    Sub sPayCheck(ByVal intHoursWorked As Integer)
        decPayCheck = Convert.ToDecimal(intHoursWorked * decPayRate)
    End Sub
    Overridable Function PayCheck() As Decimal

        objPayCheckFile = New PersonPayCheck
        objPaycheckFile.RaiseWrite(strName, decPayCheck, decPayRate, dblWeight, decSavings, False, False, False)
        Return decPayCheck
    End Function
    Sub sExercise(ByVal intMinExercised As Integer)
        Dim intPoundsLost As Integer
        intPoundsLost = intMinExercised \ 20
        dblWeight -= intPoundsLost
    End Sub
    Function Exercise() As Double
        Return dblWeight
    End Function
    Sub sPromotion()
        decPayRate += 4.5D
    End Sub
    Function Promotion() As Decimal
        Return decPayRate
    End Function
End Class