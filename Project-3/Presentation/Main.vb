Public Class Main
    Private n_Train_types As Integer

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

    'This Method allow us connect the database and load the info in our Form "Train-potting"
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim train As Train = New Train
        Dim price As Prices = New Prices
        Dim product As Product = New Product
        Dim train_type As TrainTypes = New TrainTypes
        Dim trip As Trips = New Trips
        n_Train_types = 0

        Try
            train.ReadAllTrain(OfdPath.FileName)
            price.ReadAllPrices(OfdPath.FileName)
            product.ReadAllProduct(OfdPath.FileName)
            train_type.ReadAllTrainTypes(OfdPath.FileName)
            trip.ReadAllTrips(OfdPath.FileName)

            MessageBox.Show("Correctly Connected Data Base")
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        'Load Train in List and Combo
        Dim itemTrain As ListViewItem
        For Each t As Train In train.TraDao.Train
            itemTrain = New ListViewItem(t.TrainID)
            itemTrain.SubItems.Add(t.TrainType)
            lstViewTrains.Items.Add(itemTrain)
        Next

        'Load PRICES in List View and Combos
        Dim itemPrices As ListViewItem
        Dim pro As Product

        For Each pri As Prices In price.PriDao.Prices
            pro = New Product(pri.ProductID)
            pro.ReadProductDescription()
            itemPrices = New ListViewItem(pri.ProductID)
            itemPrices.SubItems.Add(pro.ProductDescription)
            itemPrices.SubItems.Add(pri.PriceDate)
            itemPrices.SubItems.Add(pri.EurosPerTon)
            lstViewPrices.Items.Add(itemPrices)

        Next

        'Load Product in List and txtBox
        Dim itemProduct As ListViewItem
        For Each p As Product In product.ProDao.Product
            p.ReadProductDescription()
            itemProduct = New ListViewItem(p.ProductID)
            itemProduct.SubItems.Add(p.ProductDescription)
            lstViewProducts.Items.Add(itemProduct)
        Next

        'Load TRAIN TYPES in List and combos
        Dim itemTypes As ListViewItem
        For Each type As TrainTypes In train_type.TypDao.TrainTypes

            itemTypes = New ListViewItem(type.TrainTypeID)
            itemTypes.SubItems.Add(type.TrainTypeDescription)
            itemTypes.SubItems.Add(type.MaxCapacity)
            lstViewTrainTypes.Items.Add(itemTypes)
            n_Train_types += 1
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
        btnCleanPrices.Enabled = True
        btnCleanTrain.Enabled = True
        btnCleanProduct.Enabled = True
        btnCleanTrainType.Enabled = True
        'Update Buttons
        btnUpdatePrices.Enabled = True
        btnUpdateTrain.Enabled = True
        btnUpdateProduct.Enabled = True
        btnUpdateTrainType.Enabled = True
        'Delete Buttons
        btnDeletePrices.Enabled = True
        btnDeleteTrain.Enabled = True
        btnDeleteProduct.Enabled = True
        btnDeleteTrainType.Enabled = True

        'Falta por imlementar el tabQuery y el tabTrips
        'Faltan los botones de esos dos tabs
        'Faltan inicializar los botones y listview que tendran

    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------BUTTONS OF Product TAB---------------------------------------------------------------------------
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
            btnAddTrainType.Enabled = False
            btnCleanTrainType.Enabled = True
            btnUpdateTrainType.Enabled = True
            btnDeleteTrainType.Enabled = True
        End If
    End Sub

    'Button Add in PRODUCT
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim pro As Product

        If Me.txtProductDescription.Text <> String.Empty Then 'if the textbox is empty we can not add nothing so the button do nothing
            pro = New Product(Me.txtProductDescription.Text)
            pro.ReadProductDescription()

            If (pro.isProductDescription = 0) Then 'If the product description is registered in the data base, it is not added
                Try
                    If pro.InsertProduct() <> 1 Then 'If the product is correctly inserted the method insert() return us the value: 1
                        MessageBox.Show("Error inserting product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    pro.ReadProductDescription() 'With this new call to the method we obtain its ID and now we can add the ID to the list view 
                    Dim item As New ListViewItem(pro.ProductID)
                    item.SubItems.Add(pro.ProductDescription)
                    lstViewProducts.Items.Add(item)

                    MessageBox.Show("'" & pro.ProductDescription.ToString & "' correctly inserted.")
                    txtProductDescription.Text = String.Empty

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("This product already exists.")
            End If
        End If
    End Sub

    'Button Delete in PRODUCT
    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        Dim pro As New Product

        If Not Me.lstViewProducts.SelectedItems(0).SubItems(0).Text = "" Then
            If MessageBox.Show("Are yoou sure to remove this? " & lstViewProducts.SelectedItems(0).SubItems(1).Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                pro = New Product(Me.txtProductDescription.Text)
                pro.ReadProductDescription()
                Try
                    If pro.DeleteProduct() <> 1 Then
                        MessageBox.Show("Error removing product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    lstViewProducts.Items.Remove(lstViewProducts.SelectedItems(0))
                    MessageBox.Show("'" & pro.ProductDescription.ToString & "' correctly removed.")
                    txtProductDescription.Text = String.Empty
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
        End If
    End Sub

    'Button Update in PRODUCT
    Private Sub btnUpdateProduct_Click(sender As Object, e As EventArgs) Handles btnUpdateProduct.Click
        Dim pro As Product
        If Me.txtProductDescription.Text <> String.Empty Then
            pro = New Product(Me.txtProductDescription.Text)
            pro.ProductID = Integer.Parse(lstViewProducts.SelectedItems(0).Text)

            Try
                If pro.UpdateProduct() <> 1 Then
                    MessageBox.Show("Error updating product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                lstViewProducts.SelectedItems(0).SubItems(1).Text = pro.ProductDescription
                MessageBox.Show("'" & pro.ProductDescription.ToString & "' correctly updated.")
                txtProductDescription.Text = String.Empty
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    'Button Clean in PRODUCT
    Private Sub btnCleanProduct_Click(sender As Object, e As EventArgs) Handles btnCleanProduct.Click
        Me.txtProductDescription.Text = String.Empty
        btnAddProduct.Enabled = False
        btnCleanProduct.Enabled = True
        btnUpdateProduct.Enabled = True
        btnDeleteProduct.Enabled = True
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------BUTTONS OF PRICES TAB-----------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------
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
        End If
    End Sub

    'Button Add in PRICES
    Private Sub btnAddPrices_Click(sender As Object, e As EventArgs) Handles btnAddPrices.Click
        Dim pri As New Prices
        Dim pro As Product

        If Me.txtEurosPrices.Text <> Nothing Then
            pro = New Product(cboxProductPrices.SelectedItem.ToString)
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
        Dim pro As Product

        If Me.txtEurosPrices.Text <> Nothing Then
            pro = New Product(cboxProductPrices.SelectedItem.ToString)
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
        Dim pro As Product

        If Not Me.lstViewPrices.SelectedItems(0) Is Nothing Then
            If MessageBox.Show("Are you sure to remove this? " & lstViewPrices.SelectedItems(0).SubItems(1).Text, " Please, choose to confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                pro = New Product(cboxProductPrices.SelectedItem.ToString)
                pro.ReadProductDescription()
                pri = New Prices(pro.ProductID, dtpDatePrices.Text)
                Try
                    If pri.DeletePrice() <> 1 Then
                        MessageBox.Show("Error removing this price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    lstViewPrices.Items.Remove(lstViewPrices.SelectedItems(0))
                    MessageBox.Show("' " & pro.ProductDescription.ToString & " " & pri.PriceDate & "' correctly deleted.")

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    'Button Clean in PRICES
    Private Sub btnCleanPrices_Click(sender As Object, e As EventArgs) Handles btnCleanPrices.Click
        Me.txtEurosPrices.Text = String.Empty
        btnAddProduct.Enabled = False
        btnCleanPrices.Enabled = True
        btnUpdatePrices.Enabled = True
        btnDeletePrices.Enabled = True
    End Sub


    '-----------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------BUTTONS OF Train TAB-----------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------
    'List View in Train
    Private Sub lstViewTrain_Click(sender As Object, e As EventArgs) Handles lstViewTrains.Click
        If Not Me.lstViewTrains.SelectedItems(0) Is Nothing Then
            Dim i As Integer = lstViewTrains.FocusedItem.Index 'Select the afected row
            Try
                txtTrainID.Text = lstViewTrains.Items(i).SubItems(1).Text
                cboxTrain.Text = lstViewTrains.Items(i).SubItems(2).Text
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
            btnAddTrain.Enabled = True
            btnCleanTrain.Enabled = True
            btnUpdateTrain.Enabled = True
            btnDeleteTrain.Enabled = True
        End If
    End Sub

    'Button Add in TRAIN
    Private Sub btnAddTrain_Click(sender As Object, e As EventArgs) Handles btnAddTrain.Click
        Dim t As New Train
        Dim type As New TrainTypes
        If Me.txtTrainID.Text <> String.Empty And Me.cboxTrain.Text <> Nothing Then
            t = New Train(Me.txtTrainID.Text)
            t.TrainID = Me.txtTrainID.Text
            t.TrainType = Convert.ToInt32(Me.cboxTrain.Text)

            Try
                If t.InsertTrain() <> 1 Then 'If the train is correctly inserted the method insert() return us the value: 1
                    MessageBox.Show("Error inserting Train.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                'With this new call to the method we obtain its ID and now we can add the ID to the list view 
                t.ReadTrain()
                Dim item As New ListViewItem(t.TrainID)
                item.SubItems.Add(t.TrainType)
                lstViewTrains.Items.Add(item)

                MessageBox.Show("'" & t.TrainID.ToString & t.TrainType.ToString & "' correctly inserted.")
                txtProductDescription.Text = String.Empty

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        Else
            MessageBox.Show("Please fill the boxes to add a new Train.")

        End If
    End Sub

    'Button Delete in TRAIN
    Private Sub btnDeleteTrain_Click(sender As Object, e As EventArgs) Handles btnDeleteTrain.Click
        Dim t As New Train

        If Not Me.lstViewTrains.SelectedItems(0).SubItems(0).Text = "" Then
            If MessageBox.Show("Are yoou sure to remove this? " & lstViewTrains.SelectedItems(0).SubItems(1).Text, "Please, confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                t = New Train(Me.txtTrainID.Text)
                t.ReadTrain()
                Try
                    If t.DeleteTrain() <> 1 Then
                        MessageBox.Show("Error removing train.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    lstViewTrains.Items.Remove(lstViewTrains.SelectedItems(0))
                    MessageBox.Show("'" & t.TrainID.ToString & "' correctly removed.")
                    txtTrainID.Text = String.Empty
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
        End If
    End Sub

    'Button Update in TRAIN
    Private Sub btnUpdateTrain_Click(sender As Object, e As EventArgs) Handles btnUpdateTrain.Click

    End Sub

    'Button Clean in TRAIN
    Private Sub btnCleanTrain_Click(sender As Object, e As EventArgs) Handles btnCleanTrain.Click
        txtTrainID.Text = String.Empty
        cboxTrain.Text = String.Empty
        btnAddTrain.Enabled = False
        btnCleanTrain.Enabled = True
        btnUpdateTrain.Enabled = True
        btnDeleteTrain.Enabled = True
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------BUTTONS OF TRAIN TYPES TAB------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------
    'List View in Train Types
    Private Sub lstViewTrainTypes_Click(sender As Object, e As EventArgs) Handles lstViewTrainTypes.Click
        If Not Me.lstViewTrainTypes.SelectedItems(0) Is Nothing Then
            Dim i As Integer = lstViewTrainTypes.FocusedItem.Index 'Select the afected row
            Try
                txtTrainTypeDescription.Text = lstViewTrainTypes.Items(i).SubItems(1).Text
                nudMaxCapacity.Text = lstViewTrainTypes.Items(i).SubItems(2).Text
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            btnAddTrainType.Enabled = False
            btnCleanTrainType.Enabled = True
            btnUpdateTrainType.Enabled = True
            btnDeleteTrainType.Enabled = True
        End If
    End Sub

    'Button Add in TRAIN TYPES
    Private Sub btnAddTrainType_Click(sender As Object, e As EventArgs) Handles btnAddTrainType.Click
        Dim ty As TrainTypes

        If Me.txtTrainTypeDescription.Text <> Nothing Then
            ty = New TrainTypes()
            ty.TrainTypeDescription = txtTrainTypeDescription.Text
            ty.MaxCapacity = nudMaxCapacity.Value
            ty.TrainTypeID = n_Train_types
            Try
                If ty.InsertTrainType() <> 1 Then
                    MessageBox.Show("Error inserting traintype.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

                Dim item As New ListViewItem(ty.TrainTypeID)
                item.SubItems.Add(ty.TrainTypeDescription)
                item.SubItems.Add(ty.MaxCapacity)
                lstViewTrainTypes.Items.Add(item)

                MessageBox.Show(ty.TrainTypeDescription.ToString & " Correctly inserted.")
                n_Train_types += 1
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    'Button Delete in TRAIN TYPES
    Private Sub btnDeleteTrainType_Click(sender As Object, e As EventArgs) Handles btnDeleteTrainType.Click
        Dim ty As TrainTypes
        Dim id As Integer
        If Not Me.lstViewTrainTypes.SelectedItems(0) Is Nothing Then
            If MessageBox.Show("Are you sure to remove this traintype?" & lstViewTrainTypes.SelectedItems(0).SubItems(1).Text, "Please, choose to confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                id = Convert.ToInt32(Val(lstViewTrainTypes.SelectedItems(0).SubItems(0).Text))
                ty = New TrainTypes(id)

                Try
                    If ty.DeleteTrainType() <> 1 Then
                        MessageBox.Show("Error removing this price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    lstViewTrainTypes.Items.Remove(lstViewTrainTypes.SelectedItems(0))
                    MessageBox.Show(ty.TrainTypeID & " was correctly deleted.")

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If

    End Sub

    'Button Update in TRAIN TYPES
    Private Sub btnUpdateTrainType_Click(sender As Object, e As EventArgs) Handles btnUpdateTrainType.Click
        Dim ty As TrainTypes
        Dim id As Integer
        If Not Me.lstViewTrainTypes.SelectedItems(0) Is Nothing Then
            If MessageBox.Show("Are you sure to update this traintype?" & lstViewTrainTypes.SelectedItems(0).SubItems(1).Text, "Please, choose to confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Try
                    id = Convert.ToInt32(Val(lstViewTrainTypes.SelectedItems(0).SubItems(0).Text))
                    ty = New TrainTypes(id)
                    ty.MaxCapacity = nudMaxCapacity.Value
                    ty.TrainTypeDescription = txtTrainTypeDescription.Text

                    If ty.UpdateTrainType() <> 1 Then
                        MessageBox.Show("Error updating this traintype.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    lstViewTrainTypes.SelectedItems(0).SubItems(1).Text = ty.TrainTypeDescription
                    lstViewTrainTypes.SelectedItems(0).SubItems(2).Text = ty.MaxCapacity.ToString
                    MessageBox.Show(ty.TrainTypeDescription.ToString & " " & ty.MaxCapacity & " correctly update.")
                    txtTrainTypeDescription.Text = String.Empty
                    nudMaxCapacity.Value = 0

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
        End If
    End Sub

    'Button Clean in TRAIN TYPES
    Private Sub btnCleanTrainType_Click(sender As Object, e As EventArgs) Handles btnCleanTrainType.Click
        txtTrainTypeDescription.Text = String.Empty
        nudMaxCapacity.Value = 0
    End Sub

    Private Sub lstTrain_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabControl.Enabled = False
    End Sub
End Class
