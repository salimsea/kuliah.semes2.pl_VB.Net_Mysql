Public Class Form1
    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim sql, npm, nama As String
        npm = txt_npm.Text
        nama = txt_nama.Text

        openDB()
        sql = "INSERT INTO tb_mahasiswa VALUES('" & npm & "', '" & nama & "')"
        conn.Execute(sql)
        closeDB()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim sql, npm, nama As String
        npm = txt_npm_update.Text
        nama = txt_nama_update.Text

        openDB()
        sql = "UPDATE tb_mahasiswa SET nama = '" & nama & "' WHERE npm = '" & npm & "' "
        conn.Execute(sql)
        closeDB()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim sql, npm, nama As String
        npm = txt_npm_delete.Text
        nama = txt_nama_delete.Text

        openDB()
        sql = "DELETE FROM tb_mahasiswa WHERE npm = '" & npm & "' AND nama = '" & nama & "' "
        conn.Execute(sql)
        closeDB()
    End Sub
End Class