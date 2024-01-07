Imports System.Data.Odbc
Public Class Laporan
    Dim Conn As New OdbcConnection
    Dim Da As OdbcDataAdapter
    Dim Rd As OdbcDataReader
    Dim cmd As OdbcCommand
    Dim dtb As New DataTable
    Sub viewdata()
        cmd = New OdbcCommand("select * from tbl_jual", Conn)
        Da = New OdbcDataAdapter(cmd)
        Da.Fill(dtb)
        Conn.Close()
        Conn.Dispose()
    End Sub
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dtb.Clear()
        Conn = New OdbcConnection("server=localhost;uid=root;password='';Database=db_thrifting")
        Dim myrpt As New myreport
        viewdata()
        myrpt.Database.Tables("tbl_jual").SetDataSource(dtb)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub
End Class