Public Class frmGjendjaEProdukteve

    Dim funk As New funksionet

    Private Sub frmGjendjaEProdukteve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmGjendjaEProdukteve_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        sql = "Select P.ID_Produkti, P.Kategori, P.Emri, PSH.Sasia, P.Cmimi+(P.Cmimi/100*P.TVSH) as Cmimi from tblProdukti as P, tblProd_SH as PSH where PSH.IDP=P.ID_Produkti and Tipi <> 2 and PSH.Sasia > 1 "
        funk.selektimi(sql, Me.dtgProduktet, "ID_Produkti DESC")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sql As String
        sql = "Select P.ID_Produkti, P.Kategori, P.Emri, P.Sasia, P.Cmimi+(P.Cmimi/100*P.TVSH) as Cmimi from tblProdukti as P where P.Sasia > 1 "
        funk.selektimi(sql, Me.dtgProduktet, "ID_Produkti DESC")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sql As String
        sql = "Select P.ID_Produkti, P.Kategori, P.Emri, PSH.Sasia, P.Cmimi+(P.Cmimi/100*P.TVSH) as Cmimi from tblProdukti as P, tblProd_SH as PSH where PSH.IDP=P.ID_Produkti and Tipi <> 2 and PSH.Sasia between 1 and 10 "
        funk.selektimi(sql, Me.dtgProduktet, "ID_Produkti DESC")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim sql As String
        sql = "Select P.ID_Produkti, P.Kategori, P.Emri, P.Sasia, P.Cmimi+(P.Cmimi/100*P.TVSH) as Cmimi from tblProdukti as P where P.Sasia between 1 and 10 "
        funk.selektimi(sql, Me.dtgProduktet, "ID_Produkti DESC")
    End Sub
End Class