Public Class images
    <DataMember(Name:="poster")> _
    Public Property poster() As String
        Get
            Return m_poster
        End Get
        Set(ByVal value As String)
            m_poster = value
        End Set
    End Property
    Private m_poster As String
    <DataMember(Name:="fanart")> _
    Public Property fanart() As String
        Get
            Return m_fanart
        End Get
        Set(ByVal value As String)
            m_fanart = value
        End Set
    End Property
    Private m_fanart As String
    <DataMember(Name:="banner")> _
    Public Property banner() As String
        Get
            Return m_banner
        End Get
        Set(ByVal value As String)
            m_banner = value
        End Set
    End Property
    Private m_banner As String
    <DataMember(Name:="screen")> _
    Public Property screen() As String
        Get
            Return m_screen
        End Get
        Set(ByVal value As String)
            m_screen = value
        End Set
    End Property
    Private m_screen As String

End Class
