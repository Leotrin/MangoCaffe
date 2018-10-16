Public Class frmProduktetGrupor
    Dim funk As New funksionet

    Dim id As Integer
    Dim id2 As Integer
    Dim idf As Integer
    Private Sub frmProduktetGrupor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.MainMenuStrip = Main.MenuStrip1
        Dim sql As String
        sql = "SELECT distinct Emri FROM tblProdukti where Tipi='1' Group by Emri ORDER BY Emri Desc "
        funk.mbushja_e_listave(sql, Me.cmbEmriZgjedhes, "Emri")

       
    End Sub

    Private Sub frmProduktetGrupor_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub dtg()
        Dim sql As String
        sql = "Select P.ID_Produkti, P.Emri, PG.Sasi from tblProdukti as P, tblProd_P as PG where ID_P=" & id & " and ID_Produkti=ID_P2"
        funk.selektimi(sql, dtgProduktet, "ID_Produkti Desc")
    End Sub

    Private Sub cmbEmriZgjedhes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmriZgjedhes.SelectedIndexChanged
        Dim sql As String
        Dim sql2 As String


        sql = "SELECT distinct Emri FROM tblProdukti where Tipi<>'1' Group by Emri ORDER BY Emri Desc "
        funk.mbushja_e_listave(sql, Me.listProduktet, "Emri")
        Me.lblEProdukti.Text = Me.cmbEmriZgjedhes.Text

        sql2 = "Select ID_Produkti from tblProdukti where Emri='" & Me.cmbEmriZgjedhes.Text & "'"
        funk.con.ConnectionString = funk.cnString
        funk.con.Open()
        funk.da = New System.Data.SqlClient.SqlDataAdapter(sql2, funk.con)
        funk.da.Fill(funk.ds, funk.database)
        id = funk.ds.Tables(funk.database).Rows(0).Item(0)
        funk.ds.Tables(funk.database).Reset()
        funk.con.Close()
        dtg()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        Dim sql2 As String
        Dim sasia As Integer = Int32.Parse(Me.txtSasia.Text)

        sql = "Select ID_Produkti from tblProdukti where Emri = '" & Me.listProduktet.SelectedItem & "'"
        funk.con.ConnectionString = funk.cnString
        funk.con.Open()
        funk.da = New System.Data.SqlClient.SqlDataAdapter(sql, funk.con)
        funk.da.Fill(funk.ds, funk.database)
        id2 = funk.ds.Tables(funk.database).Rows(0).Item(0)
        funk.ds.Tables(funk.database).Reset()
        funk.con.Close()

        sql2 = "Insert into tblProd_P(ID_P,ID_P2,Sasi) values(" & id & ", " & id2 & ", " & sasia & ")"
        funk.insertimi_fshij_ndrysho(sql2)
        dtg()
        Me.cmbEmriZgjedhes.Text = ""
        Me.txtSasia.Text = ""
        Me.listProduktet.Items.Clear()

    End Sub

    Private Sub dtgProduktet_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgProduktet.CellClick
        idf = Me.dtgProduktet.CurrentRow.Cells("ID_Produkti").Value
    End Sub

    Private Sub btnFshij_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFshij.Click
        Dim sql As String
        sql = "Delete from tblProd_P where ID_P=" & id & " and ID_P2=" & idf
        funk.insertimi_fshij_ndrysho(sql)
        dtg()

    End Sub
End Class