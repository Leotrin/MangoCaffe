Imports System.Data.SqlClient
Public Class frmEditUser
    Dim funk As New funksionet
    Dim id As Integer
    Private Sub frmEditUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.MainMenuStrip = Main.MenuStrip1
        Me.txtKerko_TextChanged(sender, e)
    End Sub

    Private Sub frmEditUser_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub txtKerko_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKerko.TextChanged
        Dim sql As String
        sql = "Select ID, Emri, Mbiemri, Gjinia, Adresa, Tel, Username from tblPuntoret where Username Like '" & Me.txtKerko.Text & "%'"
        funk.selektimi(sql, Me.dtgPuntoret, "ID Desc")
    End Sub

    Private Sub dtgPuntoret_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgPuntoret.CellClick
        Me.cmbStatus.Text = ""
        Dim sql As String
        Dim g As String
        id = Me.dtgPuntoret.CurrentRow.Cells("ID").Value
        Me.txtEmri.Text = Me.dtgPuntoret.CurrentRow.Cells("Emri").Value
        Me.txtMbiemri.Text = Me.dtgPuntoret.CurrentRow.Cells("Mbiemri").Value
        Me.txtAdresa.Text = Me.dtgPuntoret.CurrentRow.Cells("Adresa").Value
        Me.txtTel.Text = Me.dtgPuntoret.CurrentRow.Cells("Tel").Value
        Me.txtUsername.Text = Me.dtgPuntoret.CurrentRow.Cells("Username").Value
        g = Me.dtgPuntoret.CurrentRow.Cells("Gjinia").Value

        Select Case g
            Case "M"
                Me.rdbM.Checked = True
            Case "F"
                Me.rdbF.Checked = True
        End Select

        sql = "Select Password, Statusi from tblPuntoret where id =" & Int32.Parse(Me.dtgPuntoret.CurrentRow.Cells("ID").Value)

        funk.con.ConnectionString = funk.cnString
        funk.con.Open()
        funk.da = New SqlDataAdapter(Sql, funk.con)
        funk.da.Fill(funk.ds, funk.database)
        Me.txtPassword.Text = funk.ds.Tables(funk.database).Rows(0).Item(0)

        Select Case funk.ds.Tables(funk.database).Rows(0).Item(1)
            Case "1"
                Me.cmbStatus.Text = "Administrator"
            Case "2"
                Me.cmbStatus.Text = "Menaxher"
            Case "3"
                Me.cmbStatus.Text = "Punetor"
        End Select
        funk.ds.Tables(funk.database).Reset()
        funk.con.Close()
    End Sub

    Private Sub dtgPuntoret_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgPuntoret.CellContentClick

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim sql As String = "Delete from tblPuntoret where ID=" & id
        Try
            funk.insertimi_fshij_ndrysho(sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            txtKerko_TextChanged(sender, e)
            Me.txtEmri.Text = ""
            Me.txtEmri.Focus()
            Me.txtMbiemri.Text = ""
            Me.txtTel.Text = ""
            Me.txtAdresa.Text = ""
            Me.txtPassword.Text = ""
            Me.txtUsername.Text = ""
            Me.cmbStatus.Text = ""
            Me.txtKerko_TextChanged(sender, e)
            If Me.rdbF.Checked = True Then
                Me.rdbF.Checked = False
            Else
                Me.rdbM.Checked = False
            End If
            id = Nothing
        End Try


    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim g As String = ""
        Dim s As String = ""
        Dim sql As String
        If Me.rdbF.Checked = True Then
            g = "F"
        ElseIf Me.rdbM.Checked = True Then
            g = "M"
        End If

        If Me.cmbStatus.Text = "Administrator" Then
            s = "1"
        ElseIf Me.cmbStatus.Text = "Menaxher" Then
            s = "2"
        ElseIf Me.cmbStatus.Text = "Punetor" Then
            s = "3"
        End If
        If Me.txtEmri.Text = "" Then
            MessageBox.Show("Ju lutem shkruani emrin !", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Me.txtMbiemri.Text = "" Then
            MessageBox.Show("Ju lutem shkruani mbuemrin !", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Me.txtAdresa.Text = "" Then
            MessageBox.Show("Ju lutem shkruani adresen !", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Me.txtTel.Text = "" Then
            MessageBox.Show("Ju lutem shkruani numrin e tel !", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Me.txtUsername.Text = "" Then
            MessageBox.Show("Ju lutem shkruani emrin e perdoruesit (username) !", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Me.txtPassword.Text = "" Then
            MessageBox.Show("Ju lutem shkruani fjalkalimin (password) !", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf g = "" Then
            MessageBox.Show("Ju lutem zgjidhni gjinin !", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Me.cmbStatus.Text = "" Then
            MessageBox.Show("Ju lutem zgjidheni statusin e perdoruesit !", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                sql = "Update tblPuntoret set Emri ='" & Me.txtEmri.Text & "', Mbiemri='" & Me.txtMbiemri.Text & "', Gjinia='" & g & "', Adresa='" & Me.txtAdresa.Text & "', Tel='" & Me.txtTel.Text & "', Username='" & Me.txtUsername.Text & "', Password='" & Me.txtPassword.Text & "', Statusi='" & s & "' where ID=" & id
                funk.insertimi_fshij_ndrysho(sql)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Me.txtEmri.Text = ""
                Me.txtEmri.Focus()
                Me.txtMbiemri.Text = ""
                Me.txtTel.Text = ""
                Me.txtAdresa.Text = ""
                Me.txtPassword.Text = ""
                Me.txtUsername.Text = ""
                Me.cmbStatus.Text = ""
                Me.txtKerko_TextChanged(sender, e)
                If Me.rdbF.Checked = True Then
                    Me.rdbF.Checked = False
                Else
                    Me.rdbM.Checked = False
                End If
                id = Nothing
            End Try
        End If
    End Sub
End Class