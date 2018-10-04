Public Class Client
    'all clients property/variables will be here
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


    Private policy As String
    Public Property policyNumber() As String
        Get
            Return policy
        End Get
        Set(ByVal value As String)
            policy = value
        End Set
    End Property


    Private fname As String
    Public Property firstName() As String
        Get
            Return fname
        End Get
        Set(ByVal value As String)
            fname = value
        End Set
    End Property

    Private lname As String
    Public Property lastName() As String
        Get
            Return lname
        End Get
        Set(ByVal value As String)
            lname = value
        End Set
    End Property

    Private mname As String
    Public Property middleName() As String
        Get
            Return mname
        End Get
        Set(ByVal value As String)
            mname = value
        End Set
    End Property

    Private genderValue As String
    Public Property gender() As String
        Get
            Return genderValue
        End Get
        Set(ByVal value As String)
            genderValue = value
        End Set
    End Property


    Private addressValue As String
    Public Property address() As String
        Get
            Return addressValue
        End Get
        Set(ByVal value As String)
            addressValue = value
        End Set
    End Property

    Private contactNumber As Integer
    Public Property contact() As Integer
        Get
            Return contactNumber
        End Get
        Set(ByVal value As Integer)
            contactNumber = value
        End Set
    End Property

    Private civilStatus As String
    Public Property civil() As String
        Get
            Return civilStatus
        End Get
        Set(ByVal value As String)
            civilStatus = value
        End Set
    End Property

    Private birthday As String
    Public Property birthDate() As String
        Get
            Return birthday
        End Get
        Set(ByVal value As String)
            birthday = value
        End Set
    End Property


    Private promo As String
    Public Property promoOfficer() As String
        Get
            Return promo
        End Get
        Set(ByVal value As String)
            promo = value
        End Set
    End Property


    Private sales As String
    Public Property salesOfficer() As String
        Get
            Return sales
        End Get
        Set(ByVal value As String)
            sales = value
        End Set
    End Property


    Private appoint As String
    Public Property appointDate() As String
        Get
            Return appoint
        End Get
        Set(ByVal value As String)
            appoint = value
        End Set
    End Property

    Private insured As String
    Public Property insuredDate() As String
        Get
            Return insured
        End Get
        Set(ByVal value As String)
            insured = value
        End Set
    End Property



End Class
