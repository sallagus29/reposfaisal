
Imports System.Data.SqlClient
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OpenKoneksi()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim strsql As String
        TBbentuk.Visible = False
        TBid.Visible = False


        Try
            strsql = "select * from Pengajuan"
            cmd = New SqlCommand(strsql, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            Call CloseKoneksi()
            cler_from()
            show_list_Pengajuan()
        Catch ex As Exception
            MsgBox(ex.ToString)




        End Try
    End Sub
    Private Sub cler_from()

        CBB.Text = ""
        TBJP.Text = ""
        TBKP.Text = ""
        TBP.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
    End Sub

    Private Sub BTAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAdd.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        Dim uid As String




        Try


            Call OpenKoneksi()
            Dim query_id As String = "SELECT MAX(IDPengajuan)+1 AS MXID FROM Pengajuan"
            cmd = New SqlCommand(query_id, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            uid = rd("MXID")
            rd.Close()

            query = "INSERT INTO Pengajuan (IDPengajuan,NamaPelaksana,Bidang,JmlPermintaan,BentukDana,Keperluan) " & _
                   "VALUES (" & uid & ",'" & TBP.Text & "','" & CBB.Text & "', '" & TBJP.Text & "','" & TBbentuk.Text & "','" & TBKP.Text & "')"

            cmd = New SqlCommand(query, conn)
            rd = cmd.ExecuteReader
            MsgBox("anda beruntung " + TBP.Text + "  berhasil ngepet!!!")
            rd.Close()
            cler_from()
            LVPengajuan.Clear()

            show_list_Pengajuan()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub show_list_Pengajuan()
        Dim cmd As SqlCommand        Dim dr As SqlDataReader        LVPengajuan.View = View.Details        LVPengajuan.Columns.Add("NO", 50)        LVPengajuan.Columns.Add("Nama Pelaksana", 50)        LVPengajuan.Columns.Add("Bidang", 50)        LVPengajuan.Columns.Add("Jml Permintaan", 50)        LVPengajuan.Columns.Add("Bentuk Dana", 50)        LVPengajuan.Columns.Add("Keperluan", 300)        Call OpenKoneksi()        Dim query_id As String = "select * from Pengajuan"        cmd = New SqlCommand(query_id, conn)        dr = cmd.ExecuteReader        Do While dr.Read            LVPengajuan.Items.Add(dr("IDPengajuan"))            LVPengajuan.Items(LVPengajuan.Items.Count - 1).SubItems.Add(dr("NamaPelaksana"))            LVPengajuan.Items(LVPengajuan.Items.Count - 1).SubItems.Add(dr("Bidang"))            LVPengajuan.Items(LVPengajuan.Items.Count - 1).SubItems.Add(dr("JmlPermintaan"))            LVPengajuan.Items(LVPengajuan.Items.Count - 1).SubItems.Add(dr("BentukDana"))            LVPengajuan.Items(LVPengajuan.Items.Count - 1).SubItems.Add(dr("Keperluan"))        Loop        dr.Close()        Call CloseKoneksi()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Text = "Tunai" Then
            TBbentuk.Text = "Tunai"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Text = "Cek Bank" Then
            TBbentuk.Text = "Cek Bank"
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Text = "Giro" Then
            TBbentuk.Text = "Giro"
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click

    End Sub


    Private Sub Btedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btedit.Click
        Dim cmd As SqlCommand        Dim dr As SqlDataReader
        Dim Idsiapa As String
        

        Try
            Idsiapa = LVPengajuan.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "SELECT * from Pengajuan WHERE IDPengajuan='" + Idsiapa + "'"            cmd = New SqlCommand(query, conn)            dr = cmd.ExecuteReader
            dr.Read()

            TBid.Text = dr("IDPengajuan")
            TBP.Text = dr("NamaPelaksana")
            CBB.Text = dr("Bidang")
            TBbentuk.Text = dr("BentukDana")
            TBJP.Text = dr("jmlpermintaan")
            TBKP.Text = dr("Keperluan")

            If dr("BentukDana").ToString.Trim() = "Tunai" Then
                RadioButton1.Checked = True
            ElseIf dr("BentukDana").ToString.Trim() = "Cek Bank" Then
                RadioButton2.Checked = True
            ElseIf dr("BentukDana").ToString.Trim() = "Giro" Then
                RadioButton3.Checked = True
            End If



            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BTUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTUpdate.Click
        Dim query_gl As String
        Dim cmd_gl As SqlCommand        Dim dr_gl As SqlDataReader
        Try

            Call OpenKoneksi()
            query_gl = "UPDATE Pengajuan SET " & _
                "NamaPelaksana = '" & TBP.Text & "'," & _
                "Bidang ='" & CBB.Text & "'," & _
                "JmlPermintaan = '" & TBJP.Text & "', " & _
                "BentukDana = '" & TBbentuk.Text & "',Keperluan='" & TBKP.Text & "' WHERE IDPengajuan = '" & TBid.Text & "'"
            cmd_gl = New SqlCommand(query_gl, conn)            dr_gl = cmd_gl.ExecuteReader
            dr_gl.Close()

            Call CloseKoneksi()
            cler_from()
            LVPengajuan.Clear()
            show_list_Pengajuan()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdelete.Click
        Dim Idpengajuan As String
        Dim cmd As SqlCommand        Dim dr As SqlDataReader

        Try
            Idpengajuan = LVPengajuan.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "delete from Pengajuan where IDPengajuan='" + Idpengajuan + "'"            cmd = New SqlCommand(query, conn)            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()
            cler_from()
            LVPengajuan.Clear()
            show_list_Pengajuan()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
End Class
