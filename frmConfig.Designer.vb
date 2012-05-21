<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Skin")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Appearance", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Notifications")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Extra", New System.Windows.Forms.TreeNode() {TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Startup")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Trakt Api")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("General Settings", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.ktvInstellingen = New ComponentFactory.Krypton.Toolkit.KryptonTreeView()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlSkin = New System.Windows.Forms.Panel()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(650, 426)
        Me.KryptonPanel.TabIndex = 0
        '
        'ktvInstellingen
        '
        Me.ktvInstellingen.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.InputControlStandalone
        Me.ktvInstellingen.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.InputControlStandalone
        Me.ktvInstellingen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ktvInstellingen.ItemHeight = 21
        Me.ktvInstellingen.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem
        Me.ktvInstellingen.Location = New System.Drawing.Point(5, 5)
        Me.ktvInstellingen.Margin = New System.Windows.Forms.Padding(5)
        Me.ktvInstellingen.Name = "ktvInstellingen"
        TreeNode1.Name = "tnSkin"
        TreeNode1.Text = "Skin"
        TreeNode2.Name = "tnAppearance"
        TreeNode2.Text = "Appearance"
        TreeNode3.Name = "tnNotifications"
        TreeNode3.Text = "Notifications"
        TreeNode4.Name = "tnExtra"
        TreeNode4.Text = "Extra"
        TreeNode5.Name = "tnStartup"
        TreeNode5.Text = "Startup"
        TreeNode6.Name = "tntraktApi"
        TreeNode6.Text = "Trakt Api"
        TreeNode7.Name = "tnGeneral"
        TreeNode7.Text = "General Settings"
        Me.ktvInstellingen.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode4, TreeNode7})
        Me.ktvInstellingen.Size = New System.Drawing.Size(152, 416)
        Me.ktvInstellingen.TabIndex = 0
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ktvInstellingen, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlSkin, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(650, 426)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'pnlSkin
        '
        Me.pnlSkin.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlSkin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSkin.Location = New System.Drawing.Point(167, 5)
        Me.pnlSkin.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlSkin.Name = "pnlSkin"
        Me.pnlSkin.Size = New System.Drawing.Size(478, 416)
        Me.pnlSkin.TabIndex = 1
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 426)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MinimumSize = New System.Drawing.Size(550, 0)
        Me.Name = "frmConfig"
        Me.Text = "frmConfig"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents ktvInstellingen As ComponentFactory.Krypton.Toolkit.KryptonTreeView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlSkin As System.Windows.Forms.Panel
End Class
