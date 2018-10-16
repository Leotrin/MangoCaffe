Public Class frmRegisterProduct

    Dim funk As New funksionet

    Private Sub frmRegisterProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.MainMenuStrip = Main.MenuStrip1
    End Sub

    Private Sub frmRegisterProduct_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRegjistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegjistro.Click
        Dim tipi As String = ""
        Dim grupi As String = ""
        Dim sql As String = ""
        Dim selectim As String = ""

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
                If tipi = "1" Then
                    sql = "Insert into tblProdukti(Grupi, Kategori, Emri, Sasia, Tipi, Cmimi, TVSH) values('" & grupi & "','" & Me.cmbKategoria.Text & "', '" & Me.txtEmri.Text & "', 500000000 ,'" & tipi & "'," & Int32.Parse(Me.txtCmimi.Text) & "," & Int32.Parse(Me.txtTVSH.Text) & ")"
                    funk.insertimi_fshij_ndrysho(sql)
                Else
                    sql = "Insert into tblProdukti(Grupi, Kategori, Emri, Sasia, Tipi, Cmimi, TVSH) values('" & grupi & "','" & Me.cmbKategoria.Text & "', '" & Me.txtEmri.Text & "', 0 ,'" & tipi & "'," & Int32.Parse(Me.txtCmimi.Text) & "," & Int32.Parse(Me.txtTVSH.Text) & ")"
                    funk.insertimi_fshij_ndrysho(sql)
                End If
                
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
                selectim = "Select * from tblProdukti"
                funk.selektimi(selectim, Me.dtgProduktet, "ID_Produkti Desc")

            End Try

        End If
    End Sub
End Class