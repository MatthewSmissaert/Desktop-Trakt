<Serializable()> _
Public Class episode
    Private _showname As String

    Property showname() As String
        Get
            Return _showname
        End Get
        Set(ByVal Value As String)
            _showname = Value
        End Set
    End Property
    Public Function getShowNameScrobble() As String
        Return _showname.ToLower.Trim.Replace(" ", "-")

    End Function

    Public Function getSummaryFormat() As String
        Return "/" & _showname.ToLower.Trim.Replace(" ", "-") & "/" & _seasonnr & "/" & _episodenr


    End Function

    Private _seasonnr As Integer

    Property seasonnr() As Integer
        Get
            Return _seasonnr
        End Get
        Set(ByVal Value As Integer)
            _seasonnr = Value
        End Set
    End Property

    Private _episodenr As Integer

    Property episodenr() As Integer
        Get
            Return _episodenr
        End Get
        Set(ByVal Value As Integer)
            _episodenr = Value
        End Set
    End Property
    Private _episodename As String

    Property episodename() As String
        Get
            Return _episodename
        End Get
        Set(ByVal Value As String)
            _episodename = Value
        End Set
    End Property


    Public Sub New(ByVal strShowname As String, ByVal intseasonnr As Integer, ByVal intepisodenr As Integer)
        _showname = strShowname
        _seasonnr = intseasonnr
        _episodenr = intepisodenr

    End Sub

End Class
