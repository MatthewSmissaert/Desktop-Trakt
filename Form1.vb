
Imports System.Net
Imports System.Text
Imports System.IO
Imports ComponentFactory.Krypton.Toolkit
Imports System.Configuration.ConfigurationSettings


Public Class Form1
    Dim strApiKey As String = "47ad48fcf0ecf17c8340e080d28d0b4c"

    Dim arlProcNames As New ArrayList
    Dim intCheckedInID As Integer = 0
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Adding proccess names
        arlProcNames.Add("kmplayer")
        arlProcNames.Add("vlc")

        'AppSettings.Set("blob", "jihhhhhhhhhhhaaaaaaaaaaaaaaaa")


        KryptonMessageBox.Show(AppSettings.Get("blob"))



        'KryptonTextBox1.Text = output
        'tmrInterval.Enabled = False
        ''Json test
        'Dim strJson As String = "{""show"":{""title"":""MythBusters"",""year"":2003,""url"":""http://trakt.tv/show/mythbusters"",""first_aired"":1043308800,""country"":""United States"",""overview"":""So exactly how hard is it to find a needle in a haystack, anyway? And can water dripping on your forehead really drive you nuts? Those are the kinds of questions, myths and urban legends that are put to the test in this humorous series to find out which ones hold water (and keep it from dripping on your forehead and driving you insane)."",""runtime"":60,""network"":""Discovery"",""air_day"":""Sunday"",""air_time"":""9:00pm"",""certification"":""TV-PG"",""imdb_id"":""tt0383126"",""tvdb_id"":""73388"",""tvrage_id"":""4605"",""images"":{""poster"":""http://vicmackey.trakt.tv/images/posters/104.jpg"",""fanart"":""http://vicmackey.trakt.tv/images/fanart/104.jpg"",""banner"":""http://vicmackey.trakt.tv/images/banners/104.jpg""},""ratings"":{""percentage"":96,""votes"":788,""loved"":756,""hated"":32},""genres"":[""Reality""]},""episode"":{""season"":10,""number"":7,""tvdb_id"":4317641,""title"":""Revenge of the Myth"",""overview"":""The MythBusters take fan favorites to another level in the ultimate experimental ramp-up. With fireworks, excavators and exploding limousines, if you want spectacle, this show has it in spades!"",""url"":""http://trakt.tv/show/mythbusters/season/10/episode/7"",""first_aired"":1336287600,""images"":{""screen"":""http://vicmackey.trakt.tv/images/fanart/104-940.jpg""},""ratings"":{""percentage"":100,""votes"":3,""loved"":3,""hated"":0}}}"

        'Dim txtr As System.IO.TextReader = New StringReader(strJson)

        'Dim jsr As New Newtonsoft.Json.JsonTextReader(txtr)

        'Dim jss As New Newtonsoft.Json.JsonSerializer()
        'Dim dict = jss.Deserialize(Of epscrobble)(jsr)

        'KryptonMessageBox.Show(dict.show.title & " - " & dict.show.year & " - " & dict.show.tvrage_id & " - " & dict.episode.overview)
        ''growl testing
        'Dim growl As New Growl.Connector.GrowlConnector()
        'Dim app As New Growl.Connector.Application("DesktopTrakt")
        'app.Icon = "c:\DesktopTrakt.png"
        'Dim tvshowDetected As New Growl.Connector.NotificationType("TVSHOWDETECTED", "Tv show detected!")
        'growl.Register(app, {tvshowDetected})



        '"{""username"": ""matthew"",""password"": """ & strPass & """}"

    End Sub


    Public Sub handle_exe()
        Dim ProcessProperties As New ProcessStartInfo
        ProcessProperties.FileName = "c:\handle.exe"
        ProcessProperties.Arguments = "-p winamp"
        ProcessProperties.WindowStyle = ProcessWindowStyle.Hidden
        ProcessProperties.UseShellExecute = False
        ProcessProperties.RedirectStandardOutput = True
        ProcessProperties.CreateNoWindow = True

        Dim myProcess As Process = Process.Start(ProcessProperties)

        'Dim output As String = myProcess.StandardOutput.ReadToEnd

        Do Until myProcess.StandardOutput.EndOfStream
            KryptonMessageBox.Show(myProcess.StandardOutput.ReadLine)

        Loop

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
        End If
    End Sub


    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        'Clear all the items in the listbox
        lstProcs.Items.Clear()
        'For every process which is running on the computer
        For Each p As Process In Process.GetProcesses


            'If the MainWindowTitle of the process is not empty 
            If p.MainWindowTitle = String.Empty = False And arlProcNames.Contains(p.ProcessName.ToLower) Then
                'Add the process name, the main window title, and the process ID (what windows uses to identify the process) to the listbox)
                lstProcs.Items.Add(p.MainWindowTitle.Replace(" - The KMPlayer", "").Replace(" - Winamp", ""))


            End If
        Next
    End Sub

    Private Sub tmrInterval_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrInterval.Tick
        If intCheckedInID = 0 Then
            tmrInterval.Enabled = False
            Dim strScrobbleName As String
            'Clear all the items in the listbox

            'For every process which is running on the computer
            For Each p As Process In Process.GetProcesses
                'If the MainWindowTitle of the process is not empty 
                If p.MainWindowTitle = String.Empty = False And arlProcNames.Contains(p.ProcessName.ToLower) Then
                    'Add the process name, the main window title, and the process ID (what windows uses to identify the process) to the listbox)
                    strScrobbleName = p.MainWindowTitle.Replace(" - The KMPlayer", "").Replace(" - Winamp", "")
                    If strScrobbleName.IndexOf("-") > 0 Then
                        Dim epScrobble As New episode(strScrobbleName.Split("-")(0), strScrobbleName.Split("-")(1).Trim().Substring(1, 2), strScrobbleName.Split("-")(1).Trim().Substring(4, 2))

                        lblScrobble.Values.ExtraText = epScrobble.showname
                        lblSeason.Values.ExtraText = epScrobble.seasonnr
                        lblEpisode.Values.ExtraText = epScrobble.episodenr
                        intCheckedInID = 1


                        'bgwThreading.RunWorkerAsync(epScrobble)


                        'Dim strEpisodeInfo As String

                        'strEpisodeInfo = WRequest("http://api.trakt.tv/show/episode/summary.json/" & strApiKey & epScrobble.getSummaryFormat, "GET", "")

                        'lblOutput.Text = strEpisodeInfo

                        'lblOutput.Text = "*" & strScrobbleName.Split("-")(1).Trim() & "*"
                        'lblOutput.Text &= ControlChars.NewLine & "season nr: " & strScrobbleName.Split("-")(1).Trim().Substring(1, 2)
                        'lblOutput.Text &= ControlChars.NewLine & "episode nr: " & strScrobbleName.Split("-")(1).Trim().Substring(4, 2)
                        'lblOutput.Text &= ControlChars.NewLine & "episode name: " & strScrobbleName.Split("-")(2).Trim()
                    End If
                    

                Else
                    ' lstProcs.Items.Add(p.ProcessName & " - " & p.MainWindowTitle)

                End If
            Next


        End If

    End Sub
    

    Private Sub bgwThreading_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwThreading.DoWork
        Dim strEpisodeInfo As String


        Dim epscrobble As episode = DirectCast(e.Argument, episode)

        strEpisodeInfo = WRequest("http://api.trakt.tv/show/episode/summary.json/" & strApiKey & epScrobble.getSummaryFormat, "GET", "")



        Me.Invoke(New SetTextBoxTextDelegate(AddressOf SetTextBoxText), strEpisodeInfo)

    End Sub


    Private Sub bgwThreading_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwThreading.RunWorkerCompleted
        tmrInterval.Enabled = True
    End Sub
    'This delegate matches the signature of the SetTextBoxText method so can be used to Invoke it.
    Private Delegate Sub SetTextBoxTextDelegate(ByVal text As String)
    
    'This method sets the TextBox.Text property.
    Private Sub SetTextBoxText(ByVal text As String)
        Me.KryptonTextBox1.Text = text
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Me.Hide()
        e.Cancel = True

    End Sub


   
#Region "Notify Icon and KryptonContextMenu Items"
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.Visible Then
            Me.Hide()
        Else
            Me.Show()
            Me.ShowInTaskbar = True
            Me.WindowState = FormWindowState.Normal
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.BringToFront()

        End If
    End Sub
    Private Sub NotifyIcon1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            'KryptonContextMenu1.Show(New Rectangle(Control.MousePosition, New Size(Control.MousePosition)), KryptonContextMenuPositionH.Before, _
            'KryptonContextMenuPositionV.Above, False, False)
            KryptonContextMenu1.Show(NotifyIcon1, New Rectangle(Cursor.Position, New Size(Cursor.Position)), KryptonContextMenuPositionH.Before, _
                        KryptonContextMenuPositionV.Above, False, False)


            'KryptonMessageBox.Show(Cursor.Position.X.ToString & " - " & Cursor.Position.Y.ToString)

        End If
    End Sub

    Private Sub KryptonContextMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonContextMenuItem1.Click

        Me.Show()
        Me.ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

    Private Sub KryptonContextMenuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonContextMenuItem3.Click
        Application.ExitThread()

    End Sub

#End Region ' "Notify Icon and KryptonContextMenu Items"

    
#Region "Functions"
    'request function to post or get data
    Function WRequest(ByVal URL As String, ByVal method As String, ByVal POSTdata As String) As String
        Dim responseData As String = ""
        Try
            Dim hwrequest As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            hwrequest.Accept = "*/*"
            hwrequest.AllowAutoRedirect = True
            hwrequest.UserAgent = "http_requester/0.1"
            hwrequest.Timeout = 60000
            hwrequest.Method = method
            If hwrequest.Method = "POST" Then
                hwrequest.ContentType = "application/json"
                Dim encoding As New System.Text.ASCIIEncoding() 'Use UTF8Encoding for XML requests
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                hwrequest.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = hwrequest.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim hwresponse As Net.HttpWebResponse = hwrequest.GetResponse()
            If hwresponse.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(hwresponse.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            hwresponse.Close()
        Catch e As Exception
            responseData = "An error occurred: " & e.Message
        End Try
        Return responseData
    End Function

    'string to hash function
    Function getSHA1Hash(ByVal strToHash As String) As String
        Dim sha1Obj As New System.Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function

#End Region 'functions

    Private Sub KryptonContextMenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonContextMenuItem2.Click

        frmConfig.Show()


    End Sub
End Class
