Public Class MyEventArgs
    Inherits EventArgs
    'settting up container for data from the businness classbthat will go through event to write
    Private strPrivName As String
    Public Property _strName As String
        Get
            Return strPrivName
        End Get
        Set(value As String)
            strPrivName = value
        End Set
    End Property
    Private _decPrivPayCheck As Decimal
    Public Property _decPayCheck As Decimal
        Get
            Return _decPrivPayCheck
        End Get
        Set(value As Decimal)
            _decPrivPayCheck = value
        End Set
    End Property
    Private _decPrivPayRate As Decimal
    Public Property _decPayRate As Decimal
        Get
            Return _decPrivPayRate
        End Get
        Set(value As Decimal)
            _decPrivPayRate = value
        End Set
    End Property
    Private _dblPrivWeight As Double
    Public Property _dblWeight As Double
        Get
            Return _dblPrivWeight
        End Get
        Set(value As Double)
            _dblPrivWeight = value
        End Set
    End Property
    Private _decPrivSavings As Decimal
    Public Property _decSavings As Decimal
        Get
            Return _decPrivSavings
        End Get
        Set(value As Decimal)
            _decPrivSavings = value
        End Set
    End Property
    Private _PrivMedicalInsured As Boolean
    Public Property _MedicalInsured As Boolean
        Get
            Return _PrivMedicalInsured
        End Get
        Set(value As Boolean)
            _PrivMedicalInsured = value
        End Set
    End Property
    Private _PrivVisionInsured As Boolean
    Public Property _VisionInsured As Boolean
        Get
            Return _PrivVisionInsured
        End Get
        Set(value As Boolean)
            _PrivVisionInsured = value
        End Set
    End Property
    Private _PrivDentalInsured As Boolean
    Public Property _DentalInsured As Boolean
        Get
            Return _PrivDentalInsured
        End Get
        Set(value As Boolean)
            _PrivDentalInsured = value
        End Set
    End Property
    Sub New(strName As String, decPayCheck As Decimal, decPayRate As Decimal, dblWeight As Double, decSavings As Decimal,
        boolMedicalInsured As Boolean, boolVisionInsured As Boolean, boolDentalInsured As Boolean)
        strPrivName = strName
        _decPrivPayCheck = decPayCheck
        _decPrivPayRate = decPayRate
        _dblPrivWeight = dblWeight
        _decPrivSavings = decSavings
        _PrivMedicalInsured = boolMedicalInsured
        _PrivVisionInsured = boolVisionInsured
        _PrivDentalInsured = boolDentalInsured
    End Sub
End Class