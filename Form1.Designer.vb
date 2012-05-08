<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnRefresh = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.lstProcs = New ComponentFactory.Krypton.Toolkit.KryptonListBox()
        Me.tmrInterval = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslRightInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblScrobble = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblSeason = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblEpisode = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblOutput = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.bgwThreading = New System.ComponentModel.BackgroundWorker()
        Me.KryptonTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.KryptonContextMenu1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenu()
        Me.KryptonContextMenuHeading1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading()
        Me.KryptonContextMenuItems1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.KryptonContextMenuItems3 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.KryptonContextMenuItems2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.KryptonContextMenuCheckButton1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuCheckButton()
        Me.KryptonContextMenuCheckBox1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuCheckBox()
        Me.KryptonContextMenuItem1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.KryptonContextMenuCheckBox2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuCheckBox()
        Me.KryptonContextMenuItem3 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(13, 334)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 33)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Values.Text = "Refresh"
        '
        'KryptonManager1
        '
        Me.KryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver
        '
        'lstProcs
        '
        Me.lstProcs.Dock = System.Windows.Forms.DockStyle.Top
        Me.lstProcs.Location = New System.Drawing.Point(0, 0)
        Me.lstProcs.Name = "lstProcs"
        Me.lstProcs.Size = New System.Drawing.Size(784, 109)
        Me.lstProcs.TabIndex = 1
        '
        'tmrInterval
        '
        Me.tmrInterval.Enabled = True
        Me.tmrInterval.Interval = 2000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tsslRightInfo, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 421)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'tsslRightInfo
        '
        Me.tsslRightInfo.Name = "tsslRightInfo"
        Me.tsslRightInfo.Size = New System.Drawing.Size(667, 17)
        Me.tsslRightInfo.Spring = True
        Me.tsslRightInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'lblScrobble
        '
        Me.lblScrobble.Location = New System.Drawing.Point(0, 196)
        Me.lblScrobble.Name = "lblScrobble"
        Me.lblScrobble.Size = New System.Drawing.Size(62, 20)
        Me.lblScrobble.TabIndex = 3
        Me.lblScrobble.Values.Text = "Tv Show :"
        '
        'lblSeason
        '
        Me.lblSeason.Location = New System.Drawing.Point(0, 222)
        Me.lblSeason.Name = "lblSeason"
        Me.lblSeason.Size = New System.Drawing.Size(55, 20)
        Me.lblSeason.TabIndex = 3
        Me.lblSeason.Values.Text = "Season :"
        '
        'lblEpisode
        '
        Me.lblEpisode.Location = New System.Drawing.Point(0, 248)
        Me.lblEpisode.Name = "lblEpisode"
        Me.lblEpisode.Size = New System.Drawing.Size(59, 20)
        Me.lblEpisode.TabIndex = 3
        Me.lblEpisode.Values.Text = "Episode :"
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(342, 196)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(6, 2)
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.Values.Text = ""
        '
        'bgwThreading
        '
        Me.bgwThreading.WorkerReportsProgress = True
        '
        'KryptonTextBox1
        '
        Me.KryptonTextBox1.Location = New System.Drawing.Point(247, 180)
        Me.KryptonTextBox1.Multiline = True
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.KryptonTextBox1.Size = New System.Drawing.Size(503, 213)
        Me.KryptonTextBox1.TabIndex = 5
        Me.KryptonTextBox1.Text = "KryptonTextBox1"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "DesktopTrakt"
        Me.NotifyIcon1.Visible = True
        '
        'KryptonContextMenu1
        '
        Me.KryptonContextMenu1.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.KryptonContextMenuHeading1, Me.KryptonContextMenuItems1, Me.KryptonContextMenuCheckBox2, Me.KryptonContextMenuItems3})
        '
        'KryptonContextMenuHeading1
        '
        Me.KryptonContextMenuHeading1.ExtraText = ""
        Me.KryptonContextMenuHeading1.Text = "DesktopTrakt"
        '
        'KryptonContextMenuItems1
        '
        Me.KryptonContextMenuItems1.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.KryptonContextMenuItem1})
        '
        'KryptonContextMenuItems3
        '
        Me.KryptonContextMenuItems3.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.KryptonContextMenuItem3})
        '
        'KryptonContextMenuCheckButton1
        '
        Me.KryptonContextMenuCheckButton1.Text = "CheckButton"
        '
        'KryptonContextMenuCheckBox1
        '
        Me.KryptonContextMenuCheckBox1.ExtraText = ""
        '
        'KryptonContextMenuItem1
        '
        Me.KryptonContextMenuItem1.Image = Global.WindowsApplication1.My.Resources.Resources.DesktopTrakt_16x16
        Me.KryptonContextMenuItem1.ImageTransparentColor = System.Drawing.Color.White
        Me.KryptonContextMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.O
        Me.KryptonContextMenuItem1.ShowShortcutKeys = False
        Me.KryptonContextMenuItem1.Text = "&Open DesktopTrakt"
        '
        'KryptonContextMenuCheckBox2
        '
        Me.KryptonContextMenuCheckBox2.AutoClose = True
        Me.KryptonContextMenuCheckBox2.ExtraText = ""
        Me.KryptonContextMenuCheckBox2.Image = Global.WindowsApplication1.My.Resources.Resources.button_ok_16x16
        Me.KryptonContextMenuCheckBox2.ImageTransparentColor = System.Drawing.Color.White
        Me.KryptonContextMenuCheckBox2.Text = "Enable scrobbling"
        '
        'KryptonContextMenuItem3
        '
        Me.KryptonContextMenuItem3.Image = Global.WindowsApplication1.My.Resources.Resources.exit_16x16
        Me.KryptonContextMenuItem3.ImageTransparentColor = System.Drawing.Color.White
        Me.KryptonContextMenuItem3.Text = "&Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 443)
        Me.Controls.Add(Me.KryptonTextBox1)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblEpisode)
        Me.Controls.Add(Me.lblSeason)
        Me.Controls.Add(Me.lblScrobble)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lstProcs)
        Me.Controls.Add(Me.btnRefresh)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desktop Trakt"
        Me.TextExtra = "Alpha version !"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRefresh As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents lstProcs As ComponentFactory.Krypton.Toolkit.KryptonListBox
    Friend WithEvents tmrInterval As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslRightInfo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblScrobble As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblSeason As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblEpisode As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblOutput As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents bgwThreading As System.ComponentModel.BackgroundWorker
    Friend WithEvents KryptonTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents KryptonContextMenu1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents KryptonContextMenuItems1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents KryptonContextMenuItem1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents KryptonContextMenuItems2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents KryptonContextMenuCheckButton1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuCheckButton
    Friend WithEvents KryptonContextMenuHeading1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents KryptonContextMenuCheckBox2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuCheckBox
    Friend WithEvents KryptonContextMenuCheckBox1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuCheckBox
    Friend WithEvents KryptonContextMenuItems3 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents KryptonContextMenuItem3 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem

End Class
