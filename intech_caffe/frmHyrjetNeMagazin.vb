Imports System.Data.SqlClient
Public Class frmHyrjetNeMagazin

    Dim produktid As Integer
    Dim id As Integer
    Dim funk As New funksionet

    Dim grupi As Integer
    Dim idaf As Integer

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim rd As SqlDataReader

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.listemri.Items.Clear()
        Me.TextBox1.Text = ""
        Dim sql As String
        sql = "SELECT distinct Kategori FROM tblProdukti where Tipi<>'1' and Grupi='0' Group by Kategori ORDER BY Kategori Desc "
        funk.mbushja_e_listave(sql, Me.listKategori, "Kategori")
        grupi = 0

    End Sub

    Private Sub listKategori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listKategori.SelectedIndexChanged

        Dim sql As String
        sql = "SELECT distinct Emri FROM tblProdukti where Tipi<>'1' and Kategori='" & Me.listKategori.SelectedItem & "' Group by Emri ORDER BY Emri Desc "
        funk.mbushja_e_listave(sql, Me.listemri, "Emri")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.listemri.Items.Clear()
        Me.TextBox1.Text = ""
        Dim sql As String
        sql = "SELECT distinct Kategori FROM tblProdukti where Tipi<>'1' and Grupi='1' Group by Kategori ORDER BY Kategori Desc "
        funk.mbushja_e_listave(sql, Me.listKategori, "Kategori")
        grupi = 1

    End Sub

    Private Sub frmHyrjetNeMagazin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        Try
            con.ConnectionString = funk.cnString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select * from tblF where State=1 and HD=1"
            rd = cmd.ExecuteReader

            If rd.Read = True Then
                rd.Close()

                da = New SqlDataAdapter("Select Id from tblF where State=1 and HD=1", con)
                da.Fill(ds, funk.database)
                id = ds.Tables(funk.database).Rows(0).Item(0)
                ds.Tables(funk.database).Reset()


                Dim sql As String
                sql = "Select P.ID_Produkti, P.Kategori, P.Emri, FB.Sasia, FB.Cmimi from tblProdukti as P,tblFB as FB where FB.FID=" & id & " and P.ID_Produkti = FB.PID"
                funk.selektimi(sql, Me.dtgfaturamagazin, "ID_Produkti Desc")

            End If
        Catch ex As Exception

        Finally

            con.Close()
        End Try

    End Sub

    Private Sub frmHyrjetNeMagazin_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Try
            con.ConnectionString = funk.cnString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select * from tblF where State = 1 and HD=1"
            rd = cmd.ExecuteReader

            If rd.Read = True Then
                rd.Close()

                da = New SqlDataAdapter("Select id from tblF where State = 1 and HD=1", con)
                da.Fill(ds, funk.database)
                id = ds.Tables(funk.database).Rows(0).Item(0)
                ds.Tables(funk.database).Reset()

            Else

                rd.Close()
                cmd.CommandText = "Insert Into tblF(EID, Date, State, HD) values(" & userid & ", @datasot , 1,1)"
                cmd.Parameters.Add(New SqlParameter("@datasot", SqlDbType.Date))
                cmd.Parameters("@datasot").Value = Date.Parse(Date.Now.ToShortDateString)
                cmd.ExecuteNonQuery()

                da = New SqlDataAdapter("Select id from tblF where State = 1 and HD=1", con)
                da.Fill(ds, funk.database)
                id = ds.Tables(funk.database).Rows(0).Item(0)
                ds.Tables(funk.database).Reset()

            End If

            cmd.CommandText = "Select PID from tblFB where FID = " & id & " and PID= " & produktid
            rd = cmd.ExecuteReader


            If rd.Read = True Then
                rd.Close()

                cmd.CommandText = "Update tblFB set Sasia = Sasia + " & Me.numQuantity.Value & " where FID = " & id & " and PID=" & produktid
                cmd.ExecuteNonQuery()
            Else
                rd.Close()

                cmd.CommandText = "Insert into tblFB(FID,PID,Sasia,Cmimi) values(" & id & ", " & produktid & ", " & Me.numQuantity.Value & ", " & Int32.Parse(Me.TextBox1.Text) & ")"
                cmd.ExecuteNonQuery()
            End If

        Catch ex As Exception
            MessageBox.Show("Nuk lejohet qe cmimi te jet i zbrzet !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            con.Close()

            Dim sql As String
            sql = "Select P.ID_Produkti, P.Kategori, P.Emri, FB.Sasia, FB.Cmimi from tblProdukti as P,tblFB as FB where FB.FID=" & id & " and P.ID_Produkti = FB.PID"
            funk.selektimi(sql, Me.dtgfaturamagazin, "ID_Produkti Desc")

        End Try
            
    End Sub

    Private Sub listemri_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listemri.SelectedIndexChanged

        Try
            con.ConnectionString = funk.cnString
            con.Open()
            da = New SqlDataAdapter("Select ID_Produkti from tblProdukti where Tipi<>'1' and Grupi='" & grupi & "' and Kategori='" & Me.listKategori.SelectedItem & "' and Emri='" & Me.listemri.SelectedItem & "'", con)
            da.Fill(ds, funk.database)
            produktid = ds.Tables(funk.database).Rows(0).Item(0)
            ds.Tables(funk.database).Reset()
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtgfaturamagazin_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgfaturamagazin.CellClick
        Try
            idaf = Me.dtgfaturamagazin.CurrentRow.Cells("ID_Produkti").Value
        Catch ex As Exception

        End Try


    End Sub

 
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        funk.insertimi_fshij_ndrysho("Delete from tblFB where PID=" & idaf & " and FID=" & id)

        Dim sql As String
        sql = "Select P.ID_Produkti, P.Kategori, P.Emri, FB.Sasia, FB.Cmimi from tblProdukti as P,tblFB as FB where FB.FID=" & id & " and P.ID_Produkti = FB.PID"
        funk.selektimi(sql, Me.dtgfaturamagazin, "ID_Produkti Desc")


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim totali As Integer = 0
            funk.inc = 0
            funk.maxrow = Me.dtgfaturamagazin.Rows.Count
            Dim produktid, sasia As Integer

            con.ConnectionString = funk.cnString
            con.Open()
           

            Do
                sasia = Me.dtgfaturamagazin.Rows(funk.inc).Cells("Sasia").Value
                produktid = Me.dtgfaturamagazin.Rows(funk.inc).Cells("ID_Produkti").Value
                cmd.CommandText = "Update tblProdukti set Sasia=Sasia+" & sasia & " where ID_Produkti=" & produktid
                cmd.ExecuteNonQuery()

                funk.inc = funk.inc + 1

            Loop Until (funk.inc = funk.maxrow)
        Catch ex As Exception

        Finally
            con.Close()

        End Try


        funk.insertimi_fshij_ndrysho("Update tblF set State=0 where HD=1 and Id=" & id)
        Me.dtgfaturamagazin.DataSource = vbEmpty
        Me.listemri.Items.Clear()
        Me.listKategori.Items.Clear()
        Me.TextBox1.Text = ""
    End Sub
End Class