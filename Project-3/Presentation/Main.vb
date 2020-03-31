Public Class Main

    Private train As Trains
    Private price As Prices
    Private product As Products
    Private train_type As TrainTypes
    Private trip As Trips

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

    'This Method allow us connect the database and load the info in our Form "Trains-potting"
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        Me.train = New Trains
        Me.price = New Prices
        Me.product = New Products
        Me.train_type = New TrainTypes
        Me.trip = New Trips

        Try
            Me.train.ReadAllTrains(OfdPath.FileName)
            Me.price.ReadAllPrices(OfdPath.FileName)
            Me.product.ReadAllProducts(OfdPath.FileName)
            Me.train_type.ReadAllTrainTypes(OfdPath.FileName)
            Me.trip.ReadAllTrips(OfdPath.FileName)

            MessageBox.Show("Correctly Connected Data Base")

        Catch ex As Exception

            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End Try

        'Load TRAINS in List and Combo
        For Each t As Trains In Me.train.TraDao.Trains
            Me.lstTrain.Items.Add(t.TrainID)
        Next

        'Load PRICES in List View and Combos
        Dim item As ListViewItem
        Dim pro As Products

        For Each pri As Prices In Me.price.PriDao.Prices
            pro = New Products(pri.ProductID)
            pro.ReadProducts()

            item = New ListViewItem(pri.ProductID)
            item.SubItems.Add(pro.ProductDescription)
            item.SubItems.Add(pri.PriceDate)
            item.SubItems.Add(pri.EurosPerTon)
            lstViewPrices.Items.Add(item)

        Next
        'Load PRODUCTS in List and txtBox
        For Each p As Products In Me.product.ProDao.Product
            Me.lstProduct.Items.Add(p.ProductID)
            Me.cboxProductPrices.Items.Add(p.ProductDescription)
        Next
        cboxProductPrices.SelectedIndex = 0 'We will use this to append the first element in the cbox in Prices

        'Load TRAIN TYPES in List and combos
        For Each type As TrainTypes In Me.train_type.TypDao.TrainTypes
            Me.lstTrain.Items.Add(type.TrainTypeID)
        Next

        tabControl.Enabled = True
        Me.btnConnect.Enabled = False
        Me.btnSelect.Enabled = False
        'Add Buttons
        btnAddPrices.Enabled = True
        btnAddTrain.Enabled = True
        btnAddProduct.Enabled = True
        btnAddTrainType.Enabled = True
        'Clean Buttons
        btnCleanPrices.Enabled = False
        btnCleanTrain.Enabled = False
        btnCleanProduct.Enabled = False
        btnCleanTrainType.Enabled = False
        'Update Buttons
        btnUpdatePrices.Enabled = False
        btnUpdateTrain.Enabled = False
        btnUpdateProduct.Enabled = False
        btnUpdateTrainType.Enabled = False
        'Delete Buttons
        btnDeletePrices.Enabled = False
        btnDeleteTrain.Enabled = False
        btnDeleteProduct.Enabled = False
        btnDeleteTrainType.Enabled = False

    End Sub

    'Button Add in PRODUCT TAB
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim p As Products
        If Me.txtProductDescription.Text <> String.Empty Then
            p = New Products()
            p.ProductDescription = Me.txtProductDescription.Text
            Try
                If p.InsertProducts() <> -1 Then
                    MessageBox.Show("Error inserting product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                lstProduct.Items.Add(p.ProductDescription)
                MessageBox.Show(p.ProductDescription.ToString & " inserted.")

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            'Change buttons' state
            btnAddProduct.Enabled = True
            btnCleanProduct.Enabled = False
            btnUpdateProduct.Enabled = False
            btnDeleteProduct.Enabled = False

        End If
    End Sub

    'Button Clean in PRODUCT TAB
    Private Sub btnCleanProduct_Click(sender As Object, e As EventArgs) Handles btnCleanProduct.Click
        Me.txtProductDescription.Text = String.Empty
        btnAddProduct.Enabled = True
        btnCleanProduct.Enabled = False
        btnUpdateProduct.Enabled = False
        btnDeleteProduct.Enabled = False
    End Sub

    Private Sub lstProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProduct.SelectedIndexChanged
        If Not Me.lstProduct.SelectedItems Is Nothing Then
            Try

                Me.txtProductDescription.Text = lstProduct.SelectedItem.ToString

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            'Change buttons' state
            btnAddProduct.Enabled = True
            btnCleanProduct.Enabled = False
            btnUpdateProduct.Enabled = False
            btnDeleteProduct.Enabled = False

        End If
    End Sub
End Class
