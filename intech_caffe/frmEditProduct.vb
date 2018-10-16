Public Class frmEditProduct
    Dim funk As New funksionet
    Dim id As Integer

    Private Sub frmEditProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtKerko.Focus()
        Me.WindowState = FormWindowState.Maximized
        Me.MainMenuStrip = Main.MenuStrip1
    End Sub

    Private Sub frmEditProduct_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub txtKerko_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKerko.TextChanged
        Dim sql As String
        sql = "Select ID_Produkti, Grupi, Kategori, Emri, Tipi, Cmimi, TVSH from tblProdukti where Emri Like '" & Me.txtKerko.Text & "%'"
        funk.selektimi(sql, Me.dtgProduktet, "ID_Produkti Desc")
    End Sub

    Private Sub dtgProduktet_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgProduktet.CellClick
        Dim g As String
        Dim t As String

        Try

        id = Me.dtgProduktet.CurrentRow.Cells("ID_Produkti").Value

        Me.txtEmri.Text = Me.dtgProduktet.CurrentRow.Cells("Emri").Value

        g = Me.dtgProduktet.CurrentRow.Cells("Grupi").Value
        If g = "0" Then
            Me.cmbGrupi.Text = "Ushqim"
        Else
            Me.cmbGrupi.Text = "Pije"
        End If

        Me.cmbKategoria.Text = Me.dtgProduktet.CurrentRow.Cells("Kategori").Value

        t = Me.dtgProduktet.CurrentRow.Cells("Tipi").Value
        If t = "3" Then
            Me.rdb2PSh.Checked = True
        ElseIf t = "2" Then
            Me.rdbP.Checked = True
        Else
            Me.rdbSh.Checked = True
        End If

        Me.txtCmimi.Text = Me.dtgProduktet.CurrentRow.Cells("Cmimi").Value
        Me.txtTVSH.Text = Me.dtgProduktet.CurrentRow.Cells("TVSH").Value
        Catch ex As Exception
            MessageBox.Show("Ju lutem zgjidhni produktin !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim sql As String = "Delete from tblProdukti where ID_Produkti=" & id
        Try
            funk.insertimi_fshij_ndrysho(sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            txtKerko_TextChanged(sender, e)
            Me.txtEmri.Text = ""
            Me.txtEmri.Focus()
            Me.cmbKategoria.Text = ""
            Me.cmbGrupi.Text = ""
            Me.txtCmimi.Text = ""
            Me.txtTVSH.Text = ""
            Me.cmbKategoria.Text = ""
            Me.txtKerko_TextChanged(sender, e)

            If Me.rdb2PSh.Checked = True Then
                Me.rdb2PSh.Checked = False
            Else
                Me.rdbP.Checked = False
                Me.rdbSh.Checked = False
            End If

            id = Nothing
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim tipi As String = ""
        Dim grupi As String = ""
        Dim sql As String = ""

        If Me.rdbP.Checked = True Then
            tipi = "2"
        ElseIf Me.rdbSh.Checked = True Then
            tipi = "1"
        ElseIf Me.rdb2PSh.Checked = True Then
            tipi = "3"
        End If

        If Me.cmbGrupi.Text = "Ushqim" Then
            grupi = "0"
        ElseIf Me.cmbGrupi.Text = "Pije" Then
            grupi = "1"
        End If


        If grupi = "" Then
            MessageBox.Show("Ju lutem zgjidheni grupin !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Me.cmbKategoria.Text = "" Then
            MessageBox.Show("Ju lutem zgjidheni kategorin !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Me.txtEmri.Text = "" Then
            MessageBox.Show("Ju lutem shkruani emrin e produktit !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tipi = "" Then
            MessageBox.Show("Ju lutem zgjidheni tipin e produktit !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Me.txtCmimi.Text = "" Then
            MessageBox.Show("Ju lutem shkruani cmimin e produktit !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Me.txtTVSH.Text = "" Then
            MessageBox.Show("Ju lutem shkruani TVSH e produktit !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                sql = "Update tblProdukti set Grupi='" & grupi & "', Kategori='" & Me.cmbKategoria.Text & "', Emri='" & Me.txtEmri.Text & "', Tipi='" & tipi & "', Cmimi=" & Int32.Parse(Me.txtCmimi.Text) & ", TVSH=" & Int32.Parse(Me.txtTVSH.Text) & " where ID_Produkti=" & id
                funk.insertimi_fshij_ndrysho(sql)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Me.txtEmri.Text = ""
                Me.txtEmri.Focus()
                Me.cmbKategoria.Text = ""
                Me.txtTVSH.Text = ""
                Me.txtCmimi.Text = ""
                Me.cmbKategoria.Text = ""
                If Me.rdbP.Checked = True Then
                    Me.rdbP.Checked = False
                Else
                    Me.rdbSh.Checked = False
                    Me.rdb2PSh.Checked = False
                End If
                Me.txtKerko_TextChanged(sender, e)

            End Try
        End If
    End Sub
End Class