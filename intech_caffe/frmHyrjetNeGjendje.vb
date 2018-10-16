Imports System.Data.SqlClient
Public Class frmHyrjetNeGjendje

    Dim funk As New funksionet

    Dim sasia As Integer
    Dim grupi As Integer
    Dim produktid As Integer

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim rd, rdd As SqlDataReader
    Dim tr, trr As SqlTransaction

    Private Sub frmHyrjetNeGjendje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.listemri.Items.Clear()
        Me.TextBox1.Text = ""
        Dim sql As String
        sql = "SELECT distinct Kategori FROM tblProdukti where Tipi<>'2' and Grupi='0' Group by Kategori ORDER BY Kategori Desc "
        funk.mbushja_e_listave(sql, Me.listKategori, "Kategori")
        grupi = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.listemri.Items.Clear()
        Me.TextBox1.Text = ""
        Dim sql As String
        sql = "SELECT distinct Kategori FROM tblProdukti where Tipi<>'2' and Sasia > 0 and Grupi='1' Group by Kategori ORDER BY Kategori Desc "
        funk.mbushja_e_listave(sql, Me.listKategori, "Kategori")
        grupi = 1

    End Sub

    Private Sub listKategori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listKategori.SelectedIndexChanged
        Dim sql As String
        sql = "SELECT distinct Emri FROM tblProdukti where Tipi<>'2' and Sasia > 0 and Kategori='" & Me.listKategori.SelectedItem & "' Group by Emri ORDER BY Emri Desc "
        funk.mbushja_e_listave(sql, Me.listemri, "Emri")

    End Sub

    Private Sub listemri_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listemri.SelectedIndexChanged


        Try
            con.ConnectionString = funk.cnString
            con.Open()
            da = New SqlDataAdapter("Select ID_Produkti,Cmimi+(Cmimi/100*TVSH) as [Cmimi],Sasia from tblProdukti where Sasia > 0 and Tipi<>'2'  and Grupi='" & grupi & "' and Kategori='" & Me.listKategori.SelectedItem & "' and Emri='" & Me.listemri.SelectedItem & "'", con)
            da.Fill(ds, funk.database)
            produktid = ds.Tables(funk.database).Rows(0).Item(0)
            Me.TextBox1.Text = ds.Tables(funk.database).Rows(0).Item(1)
            sasia = ds.Tables(funk.database).Rows(0).Item(2)
            ds.Tables(funk.database).Reset()
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim cmdd As New SqlCommand

        Dim sasiaeprod As Integer = Me.numQuantity.Value

        Dim produktid2, sasi, numriireshtave, incc As Integer
        incc = 0

        If Int32.Parse(Me.numQuantity.Value) > sasia Then
            MessageBox.Show("Nuk keni aq artikuj sa deshironi te transferoni ne shitore !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Close()

            con.ConnectionString = funk.cnString

            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select * from tblProdukti where ID_Produkti=" & produktid & " and Tipi='1'"
            rd = cmd.ExecuteReader

            If rd.Read = True Then
                rd.Close()

                Try

                    da = New SqlDataAdapter("Select ID_P2,Sasi from tblProd_P where ID_P=" & produktid, con)
                    da.Fill(ds, funk.database)
                    numriireshtave = ds.Tables(funk.database).Rows.Count

                    Do
                        produktid2 = ds.Tables(funk.database).Rows(incc).Item(0)
                        sasi = ds.Tables(funk.database).Rows(incc).Item(1)

                        Dim sasiaeprodukteve As Integer = sasiaeprod * sasi

                        con.Close()
                        con.Open()

                        cmdd.Connection = con
                        cmdd.CommandText = "Select * from tblProd_SH where IDP=" & produktid2
                        rdd = cmdd.ExecuteReader

                        If rdd.Read = True Then
                            rdd.Close()
                            trr = con.BeginTransaction()
                            Try

                                Dim cmd2 As New SqlCommand("Update tblProdukti set Sasia=Sasia-(" & sasiaeprodukteve & ") where ID_Produkti=" & produktid2, con, trr)
                                cmd2.ExecuteNonQuery()

                                Dim cmd3 As New SqlCommand("Update tblProd_SH set Sasia=Sasia+(" & sasiaeprodukteve & ") where IDP=" & produktid2, con, trr)
                                cmd3.ExecuteNonQuery()

                                trr.Commit()
                            Catch ex As SqlException
                                trr.Rollback()

                            Finally
                                con.Close()
                                Me.listemri.Items.Clear()
                                Me.listKategori.Items.Clear()
                                Me.TextBox1.Text = ""
                                Me.numQuantity.Value = 1
                            End Try

                        Else
                            rdd.Close()
                            trr = con.BeginTransaction()
                            Try

                                Dim cmd2 As New SqlCommand("Update tblProdukti set Sasia=Sasia-(" & sasiaeprodukteve & ") where ID_Produkti=" & produktid2, con, trr)
                                cmd2.ExecuteNonQuery()

                                Dim cmd3 As New SqlCommand("Insert into tblProd_SH values(" & produktid2 & ", " & sasiaeprodukteve & ")", con, trr)
                                cmd3.ExecuteNonQuery()

                                trr.Commit()
                            Catch ex As SqlException
                                trr.Rollback()

                            Finally
                                con.Close()
                                Me.listemri.Items.Clear()
                                Me.listKategori.Items.Clear()
                                Me.TextBox1.Text = ""
                                Me.numQuantity.Value = 1
                            End Try
                        End If

                        incc = incc + 1
                        sasiaeprodukteve = 0
                    Loop Until (incc = numriireshtave)
                    ds.Tables(funk.database).Reset()
                Catch ex As SqlException

                    MessageBox.Show("Futja e produkteve perberese ne gjendje nuk u krye !")
                End Try

                

            End If
            con.Close()

            con.Open()
            cmd.CommandText = "Select * from tblProd_SH where IDP=" & produktid
            rd = cmd.ExecuteReader

            If rd.Read = True Then
                rd.Close()
                tr = con.BeginTransaction()
                Try

                    Dim cmd2 As New SqlCommand("Update tblProdukti set Sasia=Sasia-" & sasiaeprod & " where ID_Produkti=" & produktid, con, tr)
                    cmd2.ExecuteNonQuery()

                    Dim cmd3 As New SqlCommand("Update tblProd_SH set Sasia=Sasia+" & sasiaeprod & " where IDP=" & produktid, con, tr)
                    cmd3.ExecuteNonQuery()

                    tr.Commit()
                Catch ex As SqlException
                    tr.Rollback()

                Finally
                    con.Close()
                    Me.listemri.Items.Clear()
                    Me.listKategori.Items.Clear()
                    Me.TextBox1.Text = ""
                    Me.numQuantity.Value = 1
                End Try

            Else

                rd.Close()
                tr = con.BeginTransaction()
                Try

                    Dim cmd2 As New SqlCommand("Update tblProdukti set Sasia=Sasia-" & sasiaeprod & " where ID_Produkti=" & produktid, con, tr)
                    cmd2.ExecuteNonQuery()

                    Dim cmd3 As New SqlCommand("Insert into tblProd_SH values(" & produktid & ", " & sasiaeprod & ")", con, tr)
                    cmd3.ExecuteNonQuery()

                    tr.Commit()
                Catch ex As SqlException
                    tr.Rollback()

                Finally
                    con.Close()
                    Me.listemri.Items.Clear()
                    Me.listKategori.Items.Clear()
                    Me.TextBox1.Text = ""
                    Me.numQuantity.Value = 1
                End Try
            End If
            con.Close()

            End If

        Dim sql As String
        sql = "Select P.ID_Produkti, P.Kategori, P.Emri, PSH.Sasia, Cmimi+((Cmimi/100)*TVSH) as [Cmimi] from tblProdukti as P, tblProd_SH as PSH where P.ID_Produkti = PSH.IDP"
        funk.selektimi(sql, Me.dtgfaturamagazin, "ID_Produkti Desc")
    End Sub

    Private Sub frmHyrjetNeGjendje_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class