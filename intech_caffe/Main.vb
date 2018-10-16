Public Class Main

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Login.Show()
        Me.Hide()
        Login.txtPassword.Text = ""
        Login.txtUsername.Text = ""
        Login.txtUsername.Focus()

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Main_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick

    End Sub

    Private Sub RegisterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem1.Click
        Dim f As New frmRegisterUser
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub EditDeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDeleteToolStripMenuItem.Click
        Dim f As New frmEditUser
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub RegisterToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem2.Click
        Dim f As New frmRegisterProduct
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub EditDeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDeleteToolStripMenuItem1.Click
        Dim f As New frmEditProduct
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub ProduktetPerberesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProduktetPerberesToolStripMenuItem.Click
        Dim f As New frmProduktetGrupor
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub HyrjeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HyrjeToolStripMenuItem.Click
        Dim f As New frmHyrjetNeMagazin
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub MbylleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MbylleToolStripMenuItem.Click
        End
    End Sub

    Private Sub Main_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ShitjetToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShitjetToolStripMenuItem1.Click
        Dim f As New frmShitjet
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub ShitjeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShitjeToolStripMenuItem.Click
        Dim f As New frmHyrjetNeGjendje
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        ShitjetToolStripMenuItem1_Click(sender, e)
    End Sub

    Private Sub RaportiDitorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RaportiDitorToolStripMenuItem.Click
        Dim f As New frmRaportetDitore
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ShitjetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShitjetToolStripMenuItem.Click
        Dim f As New frmRaportet
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub GjendjaEProdukteveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GjendjaEProdukteveToolStripMenuItem.Click
        Dim f As New frmGjendjaEProdukteve
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PerNeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerNeToolStripMenuItem.Click
        Dim f As New frmPerNe
        f.MdiParent = Me
        f.Show()
    End Sub
End Class