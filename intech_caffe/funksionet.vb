Imports System.Data.SqlClient
Public Class funksionet

    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public ds As New DataSet
    Public da As SqlDataAdapter
    Public rd As SqlDataReader

    Public inc As Integer
    Public maxrow As Integer

    Public username As String


    Public database As String = "resto"
    Public server As String = "LEOTRIN-PC"
    Public usernameAdministrator As String = "sa"
    Public passwordAdministrator As String = "plus66extream"
    Public cnString As String = "Data Source=" & server & ";Initial Catalog=" & database & ";User ID=" & usernameAdministrator & ";Password=" & passwordAdministrator



    Public Sub Identifikimi(ByVal sql As String)
        con.ConnectionString = cnString
        con.Open()
        da = New SqlDataAdapter(sql, con)
        da.Fill(ds, database)
        inc = 0
        maxrow = ds.Tables(database).Rows.Count
        If maxrow >= 1 Then
            Login.Hide()
            userid = ds.Tables(database).Rows(inc).Item(0)
            Main.Text = "Welcome : " & ds.Tables(database).Rows(inc).Item(1) & " " & ds.Tables(database).Rows(inc).Item(2)
            If ds.Tables(database).Rows(inc).Item(8) = "1" Then
                Main.Show()
            ElseIf ds.Tables(database).Rows(inc).Item(8) = "2" Then

                Main.RegisterToolStripMenuItem.Visible = False
                Main.ProductToolStripMenuItem.Visible = False
                Main.HyrjeToolStripMenuItem.Visible = False
                Main.RegisterToolStripMenuItem.Visible = False
                Main.ShitjeToolStripMenuItem.Visible = False
                Main.RaporteToolStripMenuItem.Visible = False
                Main.PerNeToolStripMenuItem.Visible = True
                Main.ToolStrip1.Visible = True
                Main.Show()
            End If
        Else
            Login.Label3.Text = "Incorrect username or password!"
            Login.txtUsername.Focus()
        End If
        ds.Tables(database).Reset()
        con.Close()
    End Sub

    Public Sub insertimi_fshij_ndrysho(ByVal sql As String)
        con.ConnectionString = cnString
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Public Sub selektimi(ByVal sql As String, ByVal grid As DataGridView, ByVal sortimi As String)
        con.ConnectionString = cnString
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        Try
            Dim adp As New SqlDataAdapter
            Dim ds As New DataSet
            Dim dv As New DataView

            adp.SelectCommand = cmd
            adp.Fill(ds, "dataset")
            dv.Table = ds.Tables(0)
            dv.Sort = sortimi
            grid.DataSource = dv
            grid.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub mbushja_e_listave(ByVal sql As String, ByVal list As Object, ByVal kolona As String)
        con.ConnectionString = cnString

        con.Open()
        list.Items.Clear()
        cmd.Connection = con
        cmd.CommandText = sql
        rd = cmd.ExecuteReader
        While (rd.Read)
            list.Items.Add(rd(kolona))

        End While
        list.SelectedIndex = -1
        rd.Close()
        con.Close()
    End Sub


End Class
