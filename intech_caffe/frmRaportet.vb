Imports System.Data.SqlClient
Public Class frmRaportet

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Dim id As Integer

    Dim funk As New funksionet
    Private Sub frmRaportet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmRaportet_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.ConnectionString = funk.cnString
        con.Open()
        cmd.Connection = con

        Try

            cmd.CommandText = "Select tblF.ID, Date , SUM(tblFB.Sasia*tblFB.Cmimi) as Totali ,tblPuntoret.Username from tblF,tblFB, tblPuntoret where tblFB.FID=tblF.Id and tblF.EID=tblPuntoret.ID and HD=-1 and State=0 and Date between @data1 and @data2 Group by tblF.id ,tblf.date, tblPuntoret.Username"
            cmd.Parameters.Add(New System.Data.SqlClient.SqlParameter("@data1", SqlDbType.Date))
            cmd.Parameters("@data1").Value = Date.Parse(DateTimePicker1.Value)
            cmd.Parameters.Add(New System.Data.SqlClient.SqlParameter("@data2", SqlDbType.Date))
            cmd.Parameters("@data2").Value = Date.Parse(DateTimePicker2.Value)
            Dim adp As New SqlDataAdapter
            Dim ds As New DataSet
            Dim dv As New DataView

            adp.SelectCommand = cmd
            adp.Fill(ds, "dataset")
            dv.Table = ds.Tables(0)
            dv.Sort = "ID Desc"
            Me.dtgFaturat.DataSource = dv
            Me.dtgFaturat.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
        cmd.Parameters.Clear()


        Try

            Dim inc As Integer = 0
            Dim maxrow As Integer
            Dim totali_ditor As Integer = 0

            maxrow = Me.dtgFaturat.RowCount

            Do
                totali_ditor = totali_ditor + Me.dtgFaturat.Rows(inc).Cells("Totali").Value
                inc = inc + 1
            Loop Until (inc = maxrow)

            Me.totaliDitor.Text = totali_ditor & " den"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtgFaturat_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFaturat.CellClick

        con.ConnectionString = funk.cnString
        con.Open()
        cmd.Connection = con

        Try
            id = Me.dtgFaturat.CurrentRow.Cells("ID").Value
            cmd.CommandText = "Select tblFB.FID, tblProdukti.Kategori, tblProdukti.Emri, tblFB.Sasia, tblFB.Cmimi, tblFB.Sasia*tblFB.Cmimi as Totali  from tblFB, tblProdukti where tblFB.FID=" & id & " and tblFB.PID=tblProdukti.ID_Produkti"
            Dim adp As New SqlDataAdapter
            Dim ds As New DataSet
            Dim dv As New DataView

            adp.SelectCommand = cmd
            adp.Fill(ds, "dataset")
            dv.Table = ds.Tables(0)
            dv.Sort = "FID Desc"
            Me.dtgFatura.DataSource = dv
            Me.dtgFatura.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try


        Try
            Dim inc As Integer = 0
            Dim maxrow As Integer
            Dim totali_ditor As Integer = 0

            maxrow = Me.dtgFatura.RowCount

            Do
                totali_ditor = totali_ditor + Me.dtgFatura.Rows(inc).Cells("Totali").Value
                inc = inc + 1
            Loop Until (inc = maxrow)

            Me.Totali.Text = totali_ditor & " den"
        Catch ex As Exception

        End Try


    End Sub
End Class