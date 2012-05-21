Imports ComponentFactory.Krypton.Toolkit
Public Class frmConfig

    Private Sub frmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ktvInstellingen_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles ktvInstellingen.AfterSelect
        If e.Action = TreeViewAction.ByMouse Then
            KryptonMessageBox.Show(e.Node.Text)

        End If
    End Sub

    
    
End Class
