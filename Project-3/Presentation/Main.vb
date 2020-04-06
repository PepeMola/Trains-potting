﻿Public Class Main
    Private n_trains_types As Integer
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Me.OfdPath.InitialDirectory = Application.StartupPath
        If (Me.OfdPath.ShowDialog() = DialogResult.OK) Then
            Me.txtPath.Text = Me.OfdPath.FileName
            Me.btnConnect.Enabled = True
            tabControl.Enabled = False
        End If

    End Sub

    'This Method allow us connect the database and load the info in our Form "Trains-potting"
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim train As Trains = New Trains
        Dim price As Prices = New Prices
        Dim product As Products = New Products
        Dim train_type As TrainTypes = New TrainTypes
        Dim trip As Trips = New Trips
        n_trains_types = 0

        Try
            train.ReadAllTrains(OfdPath.FileName)
            price.ReadAllPrices(OfdPath.FileName)
            product.ReadAllProducts(OfdPath.FileName)
            train_type.ReadAllTrainTypes(OfdPath.FileName)
            trip.ReadAllTrips(OfdPath.FileName)

            MessageBox.Show("Correctly Connected Data Base")
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        'Load TRAINS in List and Combo
        Dim itemTrains As ListViewItem
        For Each t As Trains In train.TraDao.Trains
            itemTrains = New ListViewItem(t.TrainID)
            itemTrains.SubItems.Add(t.TrainType)
            lstViewTrains.Items.Add(itemTrains)
        Next

        'Load PRICES in List View and Combos
        Dim itemPrices As ListViewItem
        Dim pro As Products

        For Each pri As Prices In price.PriDao.Prices
            pro = New Products(pri.ProductID)
            pro.ReadProducts()

            itemPrices = New ListViewItem(pri.ProductID)
            itemPrices.SubItems.Add(pro.ProductDescription)
            itemPrices.SubItems.Add(pri.PriceDate)
            itemPrices.SubItems.Add(pri.EurosPerTon)
            lstViewPrices.Items.Add(itemPrices)

        Next
        'Load PRODUCTS in List and txtBox
        Dim itemProducts As ListViewItem
        For Each p As Products In product.ProDao.Product
            itemProducts = New ListViewItem(p.ProductID)
            itemProducts.SubItems.Add(p.ProductDescription)
            lstViewProducts.Items.Add(itemProducts)
        Next

        'Load TRAIN TYPES in List and combos
        Dim itemTypes As ListViewItem
        For Each type As TrainTypes In train_type.TypDao.TrainTypes

            itemTypes = New ListViewItem(type.TrainTypeID)
            itemTypes.SubItems.Add(type.TrainTypeDescription)
            itemTypes.SubItems.Add(type.MaxCapacity)
            lstViewTrainTypes.Items.Add(itemTypes)
        Next


        'Initialize the cbox in the train section
        tabControl.Enabled = True
        'Disable DB buttons
        Me.btnConnect.Enabled = False
        Me.btnSelect.Enabled = False
        'Add Buttons
        btnAddPrices.Enabled = True
        btnAddTrain.Enabled = True
        btnAddProduct.Enabled = True
        btnAddTrainType.Enabled = True
        'Clean Buttons
        btnCleanPrices.Enabled = False
        btnCleanTrain.Enabled = True
        btnCleanProduct.Enabled = False
        btnCleanTrainType.Enabled = True
        'Update Buttons
        btnUpdatePrices.Enabled = False
        btnUpdateTrain.Enabled = False
        btnUpdateProduct.Enabled = False
        btnUpdateTrainType.Enabled = False
        'Delete Buttons
        btnDeletePrices.Enabled = False
        btnDeleteTrain.Enabled = False
        btnDeleteProduct.Enabled = False
        btnDeleteTrainType.Enabled = True

        'Falta por imlementar el tabQuery y el tabTrips
        'Faltan los botones de esos dos tabs
        'Faltan inicializar los botones y listview que tendran

    End Sub
    '-----------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------LISTS IN EACH TAB---------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------

    'List View in Product
    Private Sub lstViewProducts_Click(sender As Object, e As EventArgs) Handles lstViewProducts.Click
        If Not Me.lstViewProducts.SelectedItems(0) Is Nothing Then
            Dim i As Integer = lstViewProducts.FocusedItem.Index 'Select the afected row
            Try
                txtProductDescription.Text = lstViewProducts.Items(i).SubItems(1).Text
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
            btnAddProduct.Enabled = False
            btnCleanProduct.Enabled = True
            btnUpdateProduct.Enabled = True
            btnDeleteProduct.Enabled = True
        End If
    End Sub

    'List View in Prices
    Private Sub lstViewPrices_Click(sender As Object, e As EventArgs) Handles lstViewPrices.Click
        If Not Me.lstViewPrices.SelectedItems(0) Is Nothing Then
            Dim i As Integer = lstViewPrices.FocusedItem.Index 'Select the afected row
            Try
                cboxProductPrices.Text = lstViewPrices.Items(i).SubItems(1).Text
                dtpDatePrices.Text = lstViewPrices.Items(i).SubItems(2).Text
                txtEurosPrices.Text = lstViewPrices.Items(i).SubItems(3).Text
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
            btnAddPrices.Enabled = False
            btnCleanPrices.Enabled = True
            btnUpdatePrices.Enabled = True
            btnDeletePrices.Enabled = True
        End If
    End Sub

    'List View in Trains
    Private Sub lstViewTrains_Click(sender As Object, e As EventArgs) Handles lstViewTrains.Click
        If Not Me.lstViewTrains.SelectedItems(0) Is Nothing Then
            Dim i As Integer = lstViewTrains.FocusedItem.Index 'Select the afected row
            Try
                txtTrainID.Text = lstViewTrains.Items(i).SubItems(1).Text
                cboxTrain.Text = lstViewTrains.Items(i).SubItems(2).Text
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
            btnAddTrain.Enabled = False
            btnCleanTrain.Enabled = True
            btnUpdateTrain.Enabled = True
            btnDeleteTrain.Enabled = True
        End If
    End Sub

    'List View in Train Types
    Private Sub lstViewTrainTypes_Click(sender As Object, e As EventArgs) Handles lstViewTrainTypes.Click
        If Not Me.lstViewTrainTypes.SelectedItems(0) Is Nothing Then
            Dim i As Integer = lstViewTrainTypes.FocusedItem.Index 'Select the afected row
            Try
                txtTrainTypeDescription.Text = lstViewTrainTypes.Items(i).SubItems(1).Text
                nudMaxCapacity.Text = lstViewTrainTypes.Items(i).SubItems(2).Text
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
            btnAddTrainType.Enabled = False
            btnCleanTrainType.Enabled = True
            btnUpdateTrainType.Enabled = True
            btnDeleteTrainType.Enabled = True
        End If
    End Sub
    'List View in Trips

    '-----------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------BUTTONS OF PRODUCTS TAB---------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------
    'Button Add in PRODUCT
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim pro As Products

        If Me.txtProductDescription.Text <> Nothing Then
            pro = New Products(txtProductDescription.ToString)
            pro.ReadProducts()

            Try
                If pro.InsertProducts() <> 1 Then
                    MessageBox.Show("Error inserting product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim item As New ListViewItem(pro.ProductID)
                item.SubItems.Add(pro.ProductDescription)
                lstViewPrices.Items.Add(item)

                MessageBox.Show(pro.ProductDescription.ToString & " Correctly inserted.")

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'Button Delete in PRODUCT
    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click

    End Sub

    'Button Update in PRODUCT
    Private Sub btnUpdateProduct_Click(sender As Object, e As EventArgs) Handles btnUpdateProduct.Click
        Dim pro As Products
        If Me.txtProductDescription.Text <> String.Empty Then
            pro = New Products()
            pro.ReadProductDescription()
        End If

    End Sub

    'Button Clean in PRODUCT
    Private Sub btnCleanProduct_Click(sender As Object, e As EventArgs) Handles btnCleanProduct.Click
        Me.txtProductDescription.Text = String.Empty
        btnAddProduct.Enabled = True
        btnCleanProduct.Enabled = False
        btnUpdateProduct.Enabled = False
        btnDeleteProduct.Enabled = False
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------BUTTONS OF PRICES TAB-----------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------

    'Button Add in PRICES
    Private Sub btnAddPrices_Click(sender As Object, e As EventArgs) Handles btnAddPrices.Click
        Dim pri As New Prices
        Dim pro As Products

        If Me.txtEurosPrices.Text <> Nothing Then
            pro = New Products(cboxProductPrices.SelectedItem.ToString)
            pro.ReadProductDescription()
            pri.ProductID = pro.ProductID
            pri.PriceDate = dtpDatePrices.Text
            pri.EurosPerTon = Convert.ToDouble(Replace(txtEurosPrices.Text, ",", "."))

            Try
                If pri.InsertPrice() <> 1 Then
                    MessageBox.Show("Error inserting price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim item As New ListViewItem(pri.ProductID)
                item.SubItems.Add(pro.ProductDescription)
                item.SubItems.Add(pri.PriceDate)
                item.SubItems.Add(pri.EurosPerTon)
                lstViewPrices.Items.Add(item)

                MessageBox.Show(pro.ProductDescription.ToString & " " & pri.PriceDate & " Correctly inserted.")

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'Button Update in PRICES
    Private Sub btnUpdatePrices_Click(sender As Object, e As EventArgs) Handles btnUpdatePrices.Click
        Dim pri As New Prices
        Dim pro As Products

        If Me.txtEurosPrices.Text <> Nothing Then
            pro = New Products(cboxProductPrices.SelectedItem.ToString)
            pro.ReadProductDescription()
            pri = New Prices(pro.ProductID, dtpDatePrices.Text)
            pri.EurosPerTon = Convert.ToDouble(Replace(txtEurosPrices.Text, ",", "."))

            Try
                If pri.UpdatePrice() <> 1 Then
                    MessageBox.Show("Error updating Price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                lstViewPrices.SelectedItems(0).SubItems(3).Text = pri.EurosPerTon
                MessageBox.Show(pro.ProductDescription.ToString & " " & pri.PriceDate & "correctly updated.")

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'Button Delete in PRICES
    Private Sub btnDeletePrices_Click(sender As Object, e As EventArgs) Handles btnDeletePrices.Click
        Dim pri As New Prices
        Dim pro As Products

        If Not Me.lstViewPrices.SelectedItems(0) Is Nothing Then
            If MessageBox.Show("Are you sure to remove this?" & lstViewPrices.SelectedItems(0).SubItems(1).Text, "Please, choose to confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                pro = New Products(cboxProductPrices.SelectedItem.ToString)
                pro.ReadProductDescription()
                pri = New Prices(pro.ProductID, dtpDatePrices.Text)
                Try
                    If pri.DeletePrice() <> 1 Then
                        MessageBox.Show("Error removing this price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    lstViewPrices.Items.Remove(lstViewPrices.SelectedItems(0))
                    MessageBox.Show(pro.ProductDescription.ToString & " " & pri.PriceDate & " correctly deleted.")

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    'Button Clean in PRICES
    Private Sub btnCleanPrices_Click(sender As Object, e As EventArgs) Handles btnCleanPrices.Click
        Me.txtEurosPrices.Text = String.Empty
        btnAddProduct.Enabled = True
        btnCleanPrices.Enabled = False
        btnUpdatePrices.Enabled = False
        btnDeletePrices.Enabled = False
    End Sub


    '-----------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------BUTTONS OF TRAINS TAB-----------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------

    'Button Add in TRAIN
    Private Sub btnAddTrain_Click(sender As Object, e As EventArgs) Handles btnAddTrain.Click

    End Sub

    'Button Delete in TRAIN
    Private Sub btnDeleteTrain_Click(sender As Object, e As EventArgs) Handles btnDeleteTrain.Click

    End Sub

    'Button Update in TRAIN
    Private Sub btnUpdateTrain_Click(sender As Object, e As EventArgs) Handles btnUpdateTrain.Click

    End Sub

    'Button Clean in TRAIN
    Private Sub btnCleanTrain_Click(sender As Object, e As EventArgs) Handles btnCleanTrain.Click

    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------BUTTONS OF TRAIN TYPES TAB------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------

    'Button Add in TRAIN TYPES
    Private Sub btnAddTrainType_Click(sender As Object, e As EventArgs) Handles btnAddTrainType.Click
        Dim ty As TrainTypes

        If Me.txtTrainTypeDescription.Text <> Nothing Then
            ty = New TrainTypes(txtTrainTypeDescription.ToString)
            ty.ReadTrainType()

            Try
                If ty.InsertTrainType() <> 1 Then
                    MessageBox.Show("Error inserting train type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim item As New ListViewItem(ty.TrainTypeID)
                item.SubItems.Add(ty.TrainTypeDescription)
                lstViewTrainTypes.Items.Add(item)

                MessageBox.Show(ty.TrainTypeDescription.ToString & " Correctly inserted.")

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'Button Delete in TRAIN TYPES
    Private Sub btnDeleteTrainType_Click(sender As Object, e As EventArgs) Handles btnDeleteTrainType.Click
        Dim ty As TrainTypes
        Dim id As Integer
        If Not Me.lstViewTrainTypes.SelectedItems(0) Is Nothing Then
            If MessageBox.Show("Are you sure to remove this?" & lstViewTrainTypes.SelectedItems(0).SubItems(1).Text, "Please, choose to confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                id = Convert.ToInt32(Val(lstViewTrainTypes.SelectedItems(0).SubItems(0).Text))
                ty = New TrainTypes(id)
                MessageBox.Show(ty.TrainTypeID)
                ty.ReadTrainType()
                Try
                    If ty.DeleteTrainType() <> 1 Then
                        MessageBox.Show("Error removing this price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    lstViewTrainTypes.Items.Remove(lstViewPrices.SelectedItems(0))
                    MessageBox.Show(ty.TrainTypeDescription.ToString & " " & ty.MaxCapacity & " correctly deleted.")

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If

    End Sub

    'Button Update in TRAIN TYPES
    Private Sub btnUpdateTrainType_Click(sender As Object, e As EventArgs) Handles btnUpdateTrainType.Click

    End Sub

    'Button Clean in TRAIN TYPES
    Private Sub btnCleanTrainType_Click(sender As Object, e As EventArgs) Handles btnCleanTrainType.Click
        txtTrainTypeDescription.Text = String.Empty
        nudMaxCapacity.Value = 0
    End Sub

    Private Sub lstTrain_Click(sender As Object, e As EventArgs)

    End Sub
End Class
