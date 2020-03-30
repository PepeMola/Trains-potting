Public Class Main
    'Hola a los chavales
    Private train As Trains
    Private price As Prices
    Private product As Products
    Private train_type As TrainTypes
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
        Me.train = New Trains
        Me.price = New Prices
        Me.product = New Products
        Me.train_type = New TrainTypes
        Try
            Me.train.ReadAllTrains(OfdPath.FileName)
            Me.price.ReadAllPrices(OfdPath.FileName)
            Me.product.ReadAllProducts(OfdPath.FileName)
            Me.train_type.ReadAllTrainTypes(OfdPath.FileName)
            MessageBox.Show("BASE DE DATOS CONECTADA CORRECTAMENTE")
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        For Each c As Trains In Me.train.TraDao.Trains
            Me.lstTrain.Items.Add(c.TrainID)
        Next

        For Each c As Prices In Me.price.PriDao.Prices
            Me.lstTrain.Items.Add(c.PriceDate)
        Next

        For Each c As Products In Me.product.ProDao.Product
            Me.lstTrain.Items.Add(c.ProductID)
        Next

        For Each c As TrainTypes In Me.train_type.TypDao.TrainTypes
            Me.lstTrain.Items.Add(c.TrainTypeID)
        Next

        Me.btnConnect.Enabled = False
        Me.btnSelect.Enabled = False
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        Me.txtProductDescription.Text = String.Empty
    End Sub

End Class
