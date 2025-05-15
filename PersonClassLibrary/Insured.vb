Option Strict On
Public Class Insured
    Inherits ClassPerson
    Private boolMedicalInsured As Boolean
    Private boolVisionInsured As Boolean
    Private boolDentalInsured As Boolean

    Sub New(ByVal strNameAdd As String, ByVal dblWeightAdd As Double, ByVal decPayRateAdd As Decimal, ByVal decSavingsAdd As Decimal,
            ByVal boolMedical As Boolean, ByVal boolDental As Boolean, ByVal boolVision As Boolean)
        MyBase.New(strNameAdd, dblWeightAdd, decPayRateAdd, decSavingsAdd)
        boolMedicalInsured = boolMedical
        boolVisionInsured = boolVision
        boolDentalInsured = boolDental

    End Sub
    Overrides Function PayCheck() As Decimal

        Dim Medical As Decimal = 0.11D
        Dim Vision As Decimal = 0.001D
        Dim Dental As Decimal = 0.0033D
        Dim TotalTax As Decimal
        If (boolMedicalInsured) Then
            TotalTax += Medical
        End If
        If (boolVisionInsured) Then
            TotalTax += Vision
        End If
        If (boolDentalInsured) Then
            TotalTax += Dental
        End If
        decPayCheck -= (decPayCheck * TotalTax)

        objPaycheckFile = New PersonPayCheck
        objPaycheckFile.RaiseWrite(strName, decPayCheck, decPayRate, dblWeight, decSavings, boolMedicalInsured, boolVisionInsured, boolDentalInsured)
        Return decPayCheck
    End Function
    Function Medical() As Boolean
        Return boolMedicalInsured
    End Function
    Function Vision() As Boolean
        Return boolVisionInsured
    End Function
    Function Dental() As Boolean
        Return boolDentalInsured
    End Function
End Class