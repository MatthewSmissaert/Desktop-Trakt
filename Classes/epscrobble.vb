<DataContract()> _
Public Class epscrobble

    Private _show As show
    Property show() As show
        Get
            Return _show
        End Get
        Set(ByVal Value As show)
            _show = Value
        End Set
    End Property
    Private _episode As episodenr
    <DataMember(Name:="episode")> _
    Property episode() As episodenr
        Get
            Return _episode
        End Get
        Set(ByVal Value As episodenr)
            _episode = Value
        End Set
    End Property
End Class
