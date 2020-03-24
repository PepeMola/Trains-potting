Public Class Main
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Me.OfdPath.InitialDirectory = Application.StartupPath
        If (Me.OfdPath.ShowDialog() = DialogResult.OK) Then
            Me.txtPath.Text = Me.OfdPath.FileName
            Me.btnConnect.Enabled = True
        End If

    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim cli As Cliente = New Cliente

        Try
            cli.LeerTodosClientes(Me.OfdPath.FileName)
            MessageBox.Show("BASE DE DATOS CONECTADA CORRECTAMENTE")
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End Try

        For Each c As Cliente In cli.cliDao.Clientes
            'Me.lstClientes.Items.Add(c.DNI)
        Next

        Me.btnConnect.Enabled = False
        Me.btnSelect.Enabled = False
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        Me.txtProductDescription.Text = String.Empty
    End Sub


End Class
