﻿Public Class Main

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
        For Each t As Trains In train.TraDao.Trains
            Me.lstTrain.Items.Add(t.TrainID)
        Next

        'Load PRICES in List View and Combos
        Dim item As ListViewItem
        Dim pro As Products

        For Each pri As Prices In price.PriDao.Prices
            pro = New Products(pri.ProductID)
            pro.ReadProducts()

            item = New ListViewItem(pri.ProductID)
            item.SubItems.Add(pro.ProductDescription)
            item.SubItems.Add(pri.PriceDate)
            item.SubItems.Add(pri.EurosPerTon)
            lstViewPrices.Items.Add(item)

        Next
        'Load PRODUCTS in List and txtBox
        For Each p As Products In product.ProDao.Product
            Me.lstProduct.Items.Add(p.ProductID)
            Me.cboxProductPrices.Items.Add(p.ProductDescription)
        Next
        'Paulino comento esto
        'cboxProductPrices.SelectedIndex = 0 'We will use this to append the first element in the cbox in Prices

        'Load TRAIN TYPES in List and combos
        For Each type As TrainTypes In train_type.TypDao.TrainTypes
            Me.lstTrain.Items.Add(type.TrainTypeID)
        Next
        'Initialize the cbox in the train section
        cboxTrain.Items.Add(1)
        cboxTrain.Items.Add(2)
        cboxTrain.Items.Add(3)

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
    '-----------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------BUTTONS OF PRODUCTS TAB---------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------
    'Button Add in PRODUCT
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim p As Products
        If Me.txtProductDescription.Text <> String.Empty Then
            p = New Products()
            p.ProductDescription = Me.txtProductDescription.Text
            Try
                If p.InsertProducts() <> 1 Then
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

    'Button Delete in PRODUCT
    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click

    End Sub

    'Button Update in PRODUCT
    Private Sub btnUpdateProduct_Click(sender As Object, e As EventArgs) Handles btnUpdateProduct.Click

    End Sub

    'Button Clean in PRODUCT
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

    Private Sub lstViewPrices_Click(sender As Object, e As EventArgs) Handles lstViewPrices.Click
        If Me.lstViewPrices.SelectedItems(0) Is Nothing Then
            Dim i As Integer = lstViewPrices.FocusedItem.Index 'Select the afected row
            Try
                cboxProductPrices.Text = lstViewPrices.Items(i).SubItems(1).Text
                dtpDatePrices.Text = lstViewPrices.Items(i).SubItems(2).Text
                txtEurosPrices.Text = lstViewPrices.Items(i).SubItems(3).Text
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End If
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

                MessageBox.Show(pro.ProductDescription.ToString & " " & pri.PriceDate & " Correctly inserted.")

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            btnAddPrices.Enabled = True
            btnCleanPrices.Enabled = False
            btnUpdatePrices.Enabled = False
            btnDeletePrices.Enabled = False
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
            If MessageBox.Show("Are you sure to remove this? " & lstViewPrices.SelectedItems(0).SubItems(1).Text, "Please, choose to confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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
        btnCleanProduct.Enabled = False
        btnUpdateProduct.Enabled = False
        btnDeleteProduct.Enabled = False
    End Sub

<<<<<<< HEAD

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

    End Sub

    'Button Delete in TRAIN TYPES
    Private Sub btnDeleteTrainType_Click(sender As Object, e As EventArgs) Handles btnDeleteTrainType.Click

    End Sub

    'Button Update in TRAIN TYPES
    Private Sub btnUpdateTrainType_Click(sender As Object, e As EventArgs) Handles btnUpdateTrainType.Click

    End Sub

    'Button Clean in TRAIN TYPES
    Private Sub btnCleanTrainType_Click(sender As Object, e As EventArgs) Handles btnCleanTrainType.Click

    End Sub

    Private Sub lstTrain_Click(sender As Object, e As EventArgs) Handles lstTrain.Click
        If Not Me.lstTrain.SelectedItems Is Nothing Then
            Try
                Me.txtTrainID.Text = lstTrain.SelectedItem.ToString

=======
    'Menu trains
    Private Sub btnAddTrain_Click(sender As Object, e As EventArgs) Handles btnAddTrain.Click
        Dim t As Trains
        If (Me.cboxTrain.SelectedItem <> Nothing) And (Me.txtTrainID.Text <> String.Empty) Then
            t = New Trains()
            t.TrainID = txtTrainID.Text.ToUpper
            t.TrainType = cboxTrain.SelectedItem
            lstTrain.Items.Add(t.TrainID)
            lstTrain.Items.Add(t.TrainType)
            Try
                If t.InsertTrain() <> 1 Then
                    MessageBox.Show("Error inserting train.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                lstProduct.Items.Add(t.TrainID)
                MessageBox.Show(t.TrainType.ToString & " inserted.")
>>>>>>> 58e3b8fdb08d8f74451eaf1d9b4be6ac4dd5dfc9

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

<<<<<<< HEAD
            'Change buttons state
            btnAddTrain.Enabled = True
            btnCleanTrain.Enabled = False
            btnUpdateTrain.Enabled = False
            btnDeleteTrain.Enabled = False

        End If
    End Sub





    '-----------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------BUTTONS OF TRAIN TYPES TAB-----------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------



=======
            'Change buttons' state
        End If
        btnAddProduct.Enabled = True
        btnCleanProduct.Enabled = True
        btnUpdateProduct.Enabled = True
        btnDeleteProduct.Enabled = True
    End Sub

    Private Sub btnCleanTrain_Click(sender As Object, e As EventArgs) Handles btnCleanTrain.Click
        txtTrainID.Text = Nothing
    End Sub

    Private Sub btnDeleteTrain_Click(sender As Object, e As EventArgs) Handles btnDeleteTrain.Click

    End Sub

    Private Sub btnUpdateTrain_Click(sender As Object, e As EventArgs) Handles btnUpdateTrain.Click

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
>>>>>>> 58e3b8fdb08d8f74451eaf1d9b4be6ac4dd5dfc9
End Class
