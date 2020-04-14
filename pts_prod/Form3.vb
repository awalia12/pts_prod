Public Class Form3

    Dim sqlnya As String
    Sub panggildata()
        konek()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM tb_hasil", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_hasil")
        DataGridView1.DataSource = ds.Tables("tb_hasil")
        DataGridView1.Enabled = True
    End Sub
    Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panggildata()
    End Sub
End Class