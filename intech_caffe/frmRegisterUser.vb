Public Class frmRegisterUser
    Dim funk As New funksionet

    Private Sub frmRegisterUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.MainMenuStrip = Main.MenuStrip1
    End Sub

    Private Sub frmRegisterUser_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
        ElseIf s = "" Then
            MessageBox.Show("Ju lutem zgjidheni statusin e perdoruesit !", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                sql = "Insert into tblPuntoret(Emri, Mbiemri, Gjinia, Adresa, Tel, Username, Password, Statusi) values('" & Me.txtEmri.Text & "','" & Me.txtMbiemri.Text & "','" & g & "','" & Me.txtAdresa.Text & "','" & Me.txtTel.Text & "','" & Me.txtUsername.Text & "','" & Me.txtPassword.Text & "','" & s & "')"
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
                If Me.rdbF.Checked = True Then
                    Me.rdbF.Checked = False
                Else
                    Me.rdbM.Checked = False
                End If

                Dim sql2 As String
                sql2 = "Select ID, Emri, Mbiemri, Gjinia, Adresa, Tel, Username from tblPuntoret"
                funk.selektimi(sql2, Me.dtgPuntoret, "ID Desc")
            End Try
        End If
    End Sub
End Class