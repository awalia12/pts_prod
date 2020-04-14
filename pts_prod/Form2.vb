Public Class Form2

    Dim total As Integer = 0
    Dim sqlnya, Hasil, jk As String
    Sub panggildata()
        konek()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM tb_hasil", conn)
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
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call panggildata()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            total += 1
        End If
        If CheckBox3.Checked = True Then
            total += 1
        End If
        If CheckBox5.Checked = True Then
            total += 1
        End If
        If CheckBox7.Checked = True Then
            total += 1
        End If
        If CheckBox9.Checked = True Then
            total += 1
        End If
        If CheckBox11.Checked = True Then
            total += 1
        End If
        If CheckBox13.Checked = True Then
            total += 1
        End If
        If CheckBox15.Checked = True Then
            total += 1
        End If
        If CheckBox17.Checked = True Then
            total += 1
        End If
        If CheckBox19.Checked = True Then
            total += 1
        End If
        If CheckBox21.Checked = True Then
            total += 1
        End If
        If CheckBox23.Checked = True Then
            total += 1
        End If
        If CheckBox25.Checked = True Then
            total += 1
        End If
        If CheckBox27.Checked = True Then
            total += 1
        End If
        If CheckBox29.Checked = True Then
            total += 1
        End If
        If CheckBox31.Checked = True Then
            total += 1
        End If
        If CheckBox33.Checked = True Then
            total += 1
        End If
        If CheckBox35.Checked = True Then
            total += 1
        End If
        If CheckBox37.Checked = True Then
            total += 1
        End If
        If CheckBox39.Checked = True Then
            total += 1
        End If
        If CheckBox41.Checked = True Then
            total += 1
        End If
        If total < 8 Then
            Hasil = "Resiko rendah"
            MsgBox("Anda beresiko rendah terkena Covid-19")
            sqlnya = "insert into tb_hasil(Nama,NIS,JK,Hasil)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & Hasil & "')"
            Call jalan()
            MsgBox("Data berhasil tersimpan")
            Call panggildata()
        ElseIf total < 15 Then
            Hasil = "Resiko sedang"
            MsgBox("Anda beresiko sedang terkena Covid-19")
            sqlnya = "insert into tb_hasil(Nama,NIS,JK,Hasil)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & Hasil & "')"
            Call jalan()
            MsgBox("Data berhasil tersimpan")
            Call panggildata()
        ElseIf total > 14 Then
            Hasil = "Resiko tinggi"
            MsgBox("Anda beresiko tinggi terkena Covid-19")
            sqlnya = "insert into tb_hasil(Nama,NIS,JK,Hasil)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & Hasil & "')"
            Call jalan()
            MsgBox("Data berhasil tersimpan")
            Call panggildata()
        End If
        Form3.Show()
    End Sub
End Class