Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call OpenKoneksi()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim strsql As String
        TBif.Visible = False
        Tbo.Visible = False
        BTupdate.Visible = False


        Try
            strsql = "select * from Transportation"
            cmd = New SqlCommand(strsql, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            Call CloseKoneksi()
            cler_from()
            LVrequest.Clear()
            show_list_Transportasi()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    Private Sub cler_from()
        TBREQ.Text = ""
        TBID.Text = ""
        TBUNIT.Text = ""
        DTPISUE.Value = Now
        TBDES.Text = ""
        TBAC.Text = ""
        CBTRANS.Text = ""
        TBPHONE.Text = ""
        TBINS.Text = ""
        Tbo.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTSend.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        Dim uid As String




        Try


            Call OpenKoneksi()
            Dim query_id As String = "SELECT MAX(Requestid)+1 AS MXID FROM Transportation"
            cmd = New SqlCommand(query_id, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            uid = rd("MXID")
            rd.Close()



            query = "INSERT INTO Transportation (Requestid,Namerequestor,Requestorid,Unit,Dateisue,Unitdestination,acRegis,Transportation,Phone,Instruction) VALUES (" & uid & ",'" & TBREQ.Text & "','" & TBID.Text & "', '" & TBUNIT.Text & "','" & Format(DTPISUE.Value, "yyyy-MM-dd") & "','" & TBDES.Text & "','" & TBAC.Text & "','" & CBTRANS.Text & "','" & TBPHONE.Text & "','" & TBINS.Text & "')"



            cmd = New SqlCommand(query, conn)
            rd = cmd.ExecuteReader
            rd.Close()

            cler_from()
            LVrequest.Clear()
            show_list_Transportasi()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub show_list_Transportasi()
        Dim cmd As SqlCommand        Dim dr As SqlDataReader        LVrequest.View = View.Details        LVrequest.Columns.Add("NO", 50)        LVrequest.Columns.Add("Name Of Requestor", 125)        LVrequest.Columns.Add("Unit From", 90)        LVrequest.Columns.Add("Unit To", 70)        LVrequest.Columns.Add("Request Date", 100)        LVrequest.Columns.Add("Transportation", 100)        Call OpenKoneksi()        Dim query_id As String = "select * from Transportation"        cmd = New SqlCommand(query_id, conn)        dr = cmd.ExecuteReader        Do While dr.Read            LVrequest.Items.Add(dr("Requestid"))            LVrequest.Items(LVrequest.Items.Count - 1).SubItems.Add(dr("Namerequestor"))            LVrequest.Items(LVrequest.Items.Count - 1).SubItems.Add(dr("Unit"))            LVrequest.Items(LVrequest.Items.Count - 1).SubItems.Add(dr("Unitdestination"))            LVrequest.Items(LVrequest.Items.Count - 1).SubItems.Add(dr("Dateisue"))            LVrequest.Items(LVrequest.Items.Count - 1).SubItems.Add(dr("Transportation"))        Loop        dr.Close()        Call CloseKoneksi()
    End Sub


    Private Sub Tbo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbo.TextChanged
        CBTRANS.Text = Tbo.Text


        CBTRANS.Enabled = False


    End Sub

    Private Sub BTupdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTupdate.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String


        BTSEND.Visible = False
        BTSEND.Visible = True
        Try
            Call OpenKoneksi()
            Dim query_id As String = "SELECT MAX(Requestid)+1 AS MXID FROM Transportation"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()

            query = " Update Transportation SET Namerequestor='" & TBREQ.Text & "',Requestorid='" & TBID.Text & "',Unit='" & TBUNIT.Text & "',Dateisue='" & Format(DTPISUE.Value, "yyyy-MM-dd") & "',Unitdestination='" & TBDES.Text & "',acRegis='" & TBAC.Text & "',Transportation='" & CBTRANS.Text & "',Phone='" & TBPHONE.Text & "',Instruction='" & TBINS.Text & "' where Requestid='" & TBif.Text & "'"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()

            Call CloseKoneksi()
            cler_from()
            LVrequest.Clear()
            show_list_Transportasi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CBTRANS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTRANS.SelectedIndexChanged
        If CBTRANS.Text = "Other" Then
            Tbo.Visible = True
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim cmd As SqlCommand        Dim dr As SqlDataReader
        Dim IDR As String

        BTSEND.Visible = False
        BTupdate.Visible = True
        Try
            IDR = LVrequest.SelectedItems(0).Text
            Call OpenKoneksi()
            Dim query As String = "SELECT * FROM Transportation WHERE Requestid='" + IDR + "'"            cmd = New SqlCommand(query, conn)            dr = cmd.ExecuteReader

            dr.Read()
            TBif.Text = dr("Requestid")
            TBREQ.Text = dr("Namerequestor")
            TBID.Text = dr("Requestorid")
            TBUNIT.Text = dr("Unit")
            DTPISUE.Value = Now
            TBDES.Text = dr("Unitdestination")
            TBAC.Text = dr("acRegis")
            CBTRANS.Text = dr("Transportation")
            TBPHONE.Text = dr("Phone")
            TBINS.Text = dr("Instruction")

            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim Idr As String
        Dim cmd As SqlCommand        Dim dr As SqlDataReader

        Try
            Idr = LVrequest.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "delete from Transportation where Requestid='" + Idr + "'"            cmd = New SqlCommand(query, conn)            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()

            LVrequest.Clear()
            show_list_Transportasi()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Form1_Load_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        show_list_Transportasi()
    End Sub
End Class
