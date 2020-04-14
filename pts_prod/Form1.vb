Public Class Form1

    Dim sqlnya, jk, jenkes As String
    Sub panggildata()
        konek()
        da = New OleDb.OleDbDataAdapter("SELECT * From tb_hasil", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_hasil")
    End Sub
    Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call panggildata()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            jk = RadioButton1.Text
            jenkes = ("Laki-laki")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            jk = RadioButton2.Text
            jenkes = ("Perempuan")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form2.TextBox1.Text = TextBox1.Text
        Form2.TextBox2.Text = TextBox2.Text
        Form2.TextBox3.Text = jk
        Me.Hide()
        Form2.Show()
    End Sub
End Class
