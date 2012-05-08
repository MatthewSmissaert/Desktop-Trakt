<DataContract()> _
Public Class show

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
    <DataMember(Name:="year")> _
    Public Property year() As Integer
        Get
            Return m_year
        End Get
        Set(ByVal value As Integer)
            m_year = value
        End Set
    End Property
    Private m_year As Integer

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
    <DataMember(Name:="country")> _
    Public Property country() As String
        Get
            Return m_country
        End Get
        Set(ByVal value As String)
            m_country = value
        End Set
    End Property
    Private m_country As String

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


    <DataMember(Name:="runtime")> _
    Public Property runtime() As Integer
        Get
            Return m_runtime
        End Get
        Set(ByVal value As Integer)
            m_runtime = value
        End Set
    End Property
    Private m_runtime As Integer


    <DataMember(Name:="network")> _
    Public Property network() As String
        Get
            Return m_network
        End Get
        Set(ByVal value As String)
            m_network = value
        End Set
    End Property
    Private m_network As String

    <DataMember(Name:="air_day")> _
    Public Property air_day() As String
        Get
            Return m_air_day
        End Get
        Set(ByVal value As String)
            m_air_day = value
        End Set
    End Property
    Private m_air_day As String

    <DataMember(Name:="air_time")> _
    Public Property air_time() As String
        Get
            Return m_air_time
        End Get
        Set(ByVal value As String)
            m_air_time = value
        End Set
    End Property
    Private m_air_time As String

    <DataMember(Name:="certification")> _
    Public Property certification() As String
        Get
            Return m_certification
        End Get
        Set(ByVal value As String)
            m_certification = value
        End Set
    End Property
    Private m_certification As String

    <DataMember(Name:="imdb_id")> _
    Public Property imdb_id() As String
        Get
            Return m_imdb_id
        End Get
        Set(ByVal value As String)
            m_imdb_id = value
        End Set
    End Property
    Private m_imdb_id As String

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

    <DataMember(Name:="tvrage_id")> _
    Public Property tvrage_id() As String
        Get
            Return m_tvrage_id
        End Get
        Set(ByVal value As String)
            m_tvrage_id = value
        End Set
    End Property
    Private m_tvrage_id As String


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

    <DataMember(Name:="genres")> _
    Public Property genres() As IList
        Get
            Return m_genres
        End Get
        Set(ByVal value As IList)
            m_genres = value
        End Set
    End Property
    Private m_genres As IList


End Class
