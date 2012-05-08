<DataContract()> _
Public Class episodenr
    <DataMember(Name:="season")> _
    Public Property season() As Integer
        Get
            Return m_season
        End Get
        Set(ByVal value As Integer)
            m_season = value
        End Set
    End Property
    Private m_season As Integer

    <DataMember(Name:="number")> _
    Public Property number() As Integer
        Get
            Return m_number
        End Get
        Set(ByVal value As Integer)
            m_number = value
        End Set
    End Property
    Private m_number As Integer

    <DataMember(Name:="tvdb_id")> _
    Public Property tvdb_id() As String
        Get
            Return m_tvdb_id
        End Get
        Set(ByVal value As String)
            m_tvdb_id = value
        End Set
    End Property
    Private m_tvdb_id As String

    <DataMember(Name:="title")> _
    Public Property title() As String
        Get
            Return m_title
        End Get
        Set(ByVal value As String)
            m_title = value
        End Set
    End Property
    Private m_title As String

    <DataMember(Name:="overview")> _
    Public Property overview() As String
        Get
            Return m_overview
        End Get
        Set(ByVal value As String)
            m_overview = value
        End Set
    End Property
    Private m_overview As String

    <DataMember(Name:="url")> _
    Public Property url() As String
        Get
            Return m_url
        End Get
        Set(ByVal value As String)
            m_url = value
        End Set
    End Property
    Private m_url As String
    <DataMember(Name:="first_aired")> _
    Public Property first_aired() As Integer
        Get
            Return m_first_aired
        End Get
        Set(ByVal value As Integer)
            m_first_aired = value
        End Set
    End Property
    Private m_first_aired As Integer
    <DataMember(Name:="images")> _
    Public Property images() As images
        Get
            Return m_images
        End Get
        Set(ByVal value As images)
            m_images = value
        End Set
    End Property
    Private m_images As images

    <DataMember(Name:="ratings")> _
    Public Property ratings() As ratings
        Get
            Return m_ratings
        End Get
        Set(ByVal value As ratings)
            m_ratings = value
        End Set
    End Property
    Private m_ratings As ratings

End Class
