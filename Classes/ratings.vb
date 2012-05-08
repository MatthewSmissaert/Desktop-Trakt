Public Class ratings
    <DataMember(Name:="percentage")> _
    Public Property percentage() As Integer
        Get
            Return m_percentage
        End Get
        Set(ByVal value As Integer)
            m_percentage = value
        End Set
    End Property
    Private m_percentage As Integer

    <DataMember(Name:="votes")> _
    Public Property votes() As Integer
        Get
            Return m_votes
        End Get
        Set(ByVal value As Integer)
            m_votes = value
        End Set
    End Property
    Private m_votes As Integer

    <DataMember(Name:="loved")> _
    Public Property loved() As Integer
        Get
            Return m_loved
        End Get
        Set(ByVal value As Integer)
            m_loved = value
        End Set
    End Property
    Private m_loved As Integer

    <DataMember(Name:="hated")> _
    Public Property hated() As Integer
        Get
            Return m_hated
        End Get
        Set(ByVal value As Integer)
            m_hated = value
        End Set
    End Property
    Private m_hated As Integer
End Class
