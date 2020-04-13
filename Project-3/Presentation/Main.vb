Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabControl.Enabled = False
    End Sub

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
        Dim train_type As TrainType = New TrainType
        Dim trip As Trip = New Trip

        Try
            train.ReadAllTrain(OfdPath.FileName)
            price.ReadAllPrices(OfdPath.FileName)
            product.ReadAllProduct(OfdPath.FileName)
            train_type.ReadAllTrainType(OfdPath.FileName)
            trip.ReadAllTrip(OfdPath.FileName)

            MessageBox.Show("Correctly Connected Data Base")
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        'Load Train in List and Combo
        Dim itemTrain As ListViewItem
        Dim ty As TrainType

        For Each t As Train In train.TraDao.Train
            ty = New TrainType(t.TrainType)
            ty.ReadTrainType()
            itemTrain = New ListViewItem(t.TrainID)
            itemTrain.SubItems.Add(ty.TrainTypeDescription)
            lstViewTrains.Items.Add(itemTrain)
            Me.cboxTrainTrip.Items.Add(t.TrainID)
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
            Me.cboxProductPrices.Items.Add(p.ProductDescription) 'Adding each product to the combobox in prices tab
            Me.cboxProductTrip.Items.Add(p.ProductDescription)
        Next

        'Load TRAIN TYPES in List
        Dim itemTypes As ListViewItem
        For Each type As TrainType In train_type.TypDao.TrainType
            type.ReadTrainTypeDescription()
            itemTypes = New ListViewItem(type.TrainTypeID)
            itemTypes.SubItems.Add(type.TrainTypeDescription)
            itemTypes.SubItems.Add(type.MaxCapacity)
            lstViewTrainTypes.Items.Add(itemTypes)
            Me.cboxTrain.Items.Add(type.TrainTypeDescription) 'Adding each train type to the combobox in train tab
        Next

        'Load TRIP in list
        Dim itemTrip As ListViewItem
        Dim pr As Product
        For Each tri As Trip In trip.TrDao.Trip
            pr = New Product(tri.Product)
            pr.ReadProduct()
            itemTrip = New ListViewItem(tri.TripDate)
            itemTrip.SubItems.Add(tri.Train)
            itemTrip.SubItems.Add(pr.ProductDescription)
            itemTrip.SubItems.Add(tri.TonsTransported)
            lstViewTrip.Items.Add(itemTrip)
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
        btnAddTrip.Enabled = True

        'Clean Buttons
        btnCleanPrices.Enabled = False
        btnCleanTrain.Enabled = False
        btnCleanProduct.Enabled = False
        btnCleanTrainType.Enabled = False
        btnCleanTrip.Enabled = False

        'Update Buttons
        btnUpdatePrices.Enabled = False
        btnUpdateTrain.Enabled = False
        btnUpdateProduct.Enabled = False
        btnUpdateTrainType.Enabled = False
        btnUpdateTrip.Enabled = False

        'Delete Buttons
        btnDeletePrices.Enabled = False
        btnDeleteTrain.Enabled = False
        btnDeleteProduct.Enabled = False
        btnDeleteTrainType.Enabled = False
        btnDeleteTrip.Enabled = False

        'Falta diseñar el tab de queries
        'Faltan inicializar los botones y listview de queriestab

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
            btnAddProduct.Enabled = False
            btnCleanProduct.Enabled = True
            btnUpdateProduct.Enabled = True
            btnDeleteProduct.Enabled = True
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
                    Me.cboxProductPrices.Items.Add(pro.ProductDescription) 'Adding each product to the combobox in prices tab
                    Me.cboxProductTrip.Items.Add(pro.ProductDescription)

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

        If Not Me.lstViewProducts.SelectedItems(0).SubItems(0).Text Is Nothing Then
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
            Me.txtProductDescription.Text = String.Empty
            btnAddProduct.Enabled = True
            btnCleanProduct.Enabled = False
            btnUpdateProduct.Enabled = False
            btnDeleteProduct.Enabled = False
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
            Me.txtProductDescription.Text = String.Empty
            btnAddProduct.Enabled = True
            btnCleanProduct.Enabled = False
            btnUpdateProduct.Enabled = False
            btnDeleteProduct.Enabled = False
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
        btnAddPrices.Enabled = False
        btnCleanPrices.Enabled = True
        btnUpdatePrices.Enabled = True
        btnDeletePrices.Enabled = True
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
        btnAddPrices.Enabled = True
        btnCleanPrices.Enabled = False
        btnUpdatePrices.Enabled = False
        btnDeletePrices.Enabled = False
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------BUTTONS OF Train TAB------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------
    'List View in Train
    Private Sub lstViewTrain_Click(sender As Object, e As EventArgs) Handles lstViewTrains.Click
        If Not Me.lstViewTrains.SelectedItems(0) Is Nothing Then
            Dim i As Integer = lstViewTrains.FocusedItem.Index 'Select the afected row
            Try
                Me.txtTrainID.Text = lstViewTrains.Items(i).SubItems(0).Text
                Me.cboxTrain.Text = lstViewTrains.Items(i).SubItems(1).Text
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            Me.txtTrainID.Enabled = False
            btnAddTrain.Enabled = False
            btnCleanTrain.Enabled = True
            btnUpdateTrain.Enabled = True
            btnDeleteTrain.Enabled = True
        End If
    End Sub

    'Button Add in TRAIN
    Private Sub btnAddTrain_Click(sender As Object, e As EventArgs) Handles btnAddTrain.Click
        Dim t As New Train
        Dim type As TrainType
        If Me.txtTrainID.Text <> String.Empty And Me.cboxTrain.Text <> Nothing Then
            type = New TrainType(Me.cboxTrain.Text)
            type.ReadTrainTypeDescription()
            t = New Train(Me.txtTrainID.Text)
            t.TrainType = type.TrainTypeID

            If (t.isTrain = 0) Then
                Try
                    If t.InsertTrain() <> 1 Then 'If the train is correctly inserted the method insert() return us the value: 1
                        MessageBox.Show("Error inserting Train.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    Dim item As New ListViewItem(t.TrainID)
                    item.SubItems.Add(type.TrainTypeDescription)
                    lstViewTrains.Items.Add(item)

                    Me.cboxTrainTrip.Items.Add(t.TrainID)

                    MessageBox.Show(" ID: '" & t.TrainID.ToString & "' as " & type.TrainTypeDescription.ToString & " type." & vbCrLf & " Correctly inserted.")
                    Me.txtTrainID.Text = String.Empty
                    Me.cboxTrain.Text = String.Empty
                    btnAddTrain.Enabled = True
                    btnCleanTrain.Enabled = False
                    btnUpdateTrain.Enabled = False
                    btnDeleteTrain.Enabled = False
                    Me.txtTrainID.Enabled = True
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            ElseIf (t.isTrain <> 0) Then
                MessageBox.Show("This train already exists, you can not add this.")
                Me.txtTrainID.Text = String.Empty
                Me.cboxTrain.Text = String.Empty
                btnAddTrain.Enabled = True
                btnCleanTrain.Enabled = False
                btnUpdateTrain.Enabled = False
                btnDeleteTrain.Enabled = False
                Me.txtTrainID.Enabled = True
                Exit Sub
            End If
        Else
            MessageBox.Show("Please fill all the boxes to add a new Train.")
            Me.txtTrainID.Text = String.Empty
            Me.cboxTrain.Text = String.Empty
            btnAddTrain.Enabled = True
            btnCleanTrain.Enabled = False
            btnUpdateTrain.Enabled = False
            btnDeleteTrain.Enabled = False
            Me.txtTrainID.Enabled = True
        End If
    End Sub

    'Button Delete in TRAIN
    Private Sub btnDeleteTrain_Click(sender As Object, e As EventArgs) Handles btnDeleteTrain.Click
        Dim t As New Train
        Dim type As TrainType
        If Not Me.lstViewTrains.SelectedItems(0).SubItems(0).Text = "" Then
            If MessageBox.Show("Are you sure to update this?" & vbCrLf & " ID: " & lstViewTrains.SelectedItems(0).Text & " as " & lstViewTrains.SelectedItems(0).SubItems(1).Text & vbCrLf, "Please, confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                type = New TrainType(Me.cboxTrain.Text)
                type.ReadTrainTypeDescription()
                t = New Train(Me.txtTrainID.Text)
                t.TrainType = type.TrainTypeID

                Try
                    If t.DeleteTrain() <> 1 Then
                        MessageBox.Show("Error removing train.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    lstViewTrains.Items.Remove(lstViewTrains.SelectedItems(0))
                    MessageBox.Show("ID: '" & t.TrainID.ToString & "' as " & type.TrainTypeDescription.ToString & " correctly removed.")
                    Me.txtTrainID.Text = String.Empty
                    Me.cboxTrain.Text = String.Empty
                    btnAddTrain.Enabled = True
                    btnCleanTrain.Enabled = False
                    btnUpdateTrain.Enabled = False
                    btnDeleteTrain.Enabled = False
                    Me.txtTrainID.Enabled = True
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txtTrainID.Text = String.Empty
                    Me.cboxTrain.Text = String.Empty
                    btnAddTrain.Enabled = True
                    btnCleanTrain.Enabled = False
                    btnUpdateTrain.Enabled = False
                    btnDeleteTrain.Enabled = False
                    Me.txtTrainID.Enabled = True
                    Exit Sub
                End Try
            End If
        End If
    End Sub

    'Button Update in TRAIN
    Private Sub btnUpdateTrain_Click(sender As Object, e As EventArgs) Handles btnUpdateTrain.Click
        Dim t As New Train
        Dim type As TrainType
        If Not Me.lstViewTrains.SelectedItems(0).SubItems(0).Text = String.Empty Then
            If MessageBox.Show("Are you sure to update this?" & vbCrLf & " ID: " & lstViewTrains.SelectedItems(0).Text & " as " & lstViewTrains.SelectedItems(0).SubItems(1).Text & vbCrLf, "Please, confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                type = New TrainType(Me.cboxTrain.Text)
                type.ReadTrainTypeDescription()
                t = New Train(lstViewTrains.SelectedItems(0).Text)
                t.TrainType = type.TrainTypeID

                Try
                    If t.UpdateTrain() <> 1 Then
                        MessageBox.Show("Error updating train.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    lstViewTrains.SelectedItems(0).SubItems(0).Text = t.TrainID
                    lstViewTrains.SelectedItems(0).SubItems(1).Text = type.TrainTypeDescription
                    MessageBox.Show("ID: '" & t.TrainID.ToString & "' as " & type.TrainTypeDescription.ToString & " correctly updated.")
                    Me.txtTrainID.Text = String.Empty
                    Me.cboxTrain.Text = String.Empty
                    btnAddTrain.Enabled = True
                    btnCleanTrain.Enabled = False
                    btnUpdateTrain.Enabled = False
                    btnDeleteTrain.Enabled = False
                    Me.txtTrainID.Enabled = True
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

            End If
        End If

    End Sub

    'Button Clean in TRAIN
    Private Sub btnCleanTrain_Click(sender As Object, e As EventArgs) Handles btnCleanTrain.Click
        Me.txtTrainID.Text = String.Empty
        Me.cboxTrain.Text = String.Empty
        btnAddTrain.Enabled = True
        btnCleanTrain.Enabled = False
        btnUpdateTrain.Enabled = False
        btnDeleteTrain.Enabled = False
        Me.txtTrainID.Enabled = True
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------BUTTONS OF TRAIN TYPES TAB------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------
    'List View in TRAIN TYPES
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
        Dim ty As TrainType

        If Me.txtTrainTypeDescription.Text <> String.Empty And Me.nudMaxCapacity.Value > 0 Then
            ty = New TrainType(Me.txtTrainTypeDescription.Text)
            ty.ReadTrainTypeDescription()
            ty.MaxCapacity = Me.nudMaxCapacity.Value

            If (ty.isType = 0) Then
                Try
                    If ty.InsertTrainType() <> 1 Then
                        MessageBox.Show("Error inserting traintype.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    ty.ReadTrainTypeDescription()
                    Dim item As New ListViewItem(ty.TrainTypeID)
                    item.SubItems.Add(ty.TrainTypeDescription)
                    item.SubItems.Add(ty.MaxCapacity)
                    lstViewTrainTypes.Items.Add(item)
                    Me.cboxTrain.Items.Add(ty.TrainTypeDescription) 'Adding each train type to the combobox in train tab

                    MessageBox.Show("ID: " & ty.TrainTypeID & " as '" & ty.TrainTypeDescription.ToString & "' description, with: " & ty.MaxCapacity &
                        " tons maximum.", "Correctly inserted.")
                    Me.txtTrainTypeDescription.Text = String.Empty
                    Me.nudMaxCapacity.Value = 0

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            Else
                MessageBox.Show("This type of train already exists.")
                Exit Sub
            End If
        ElseIf Me.nudMaxCapacity.Value <= 0 Then
            MessageBox.Show("Please, select the maximum capacity of this train type.")
            Exit Sub
        ElseIf Me.txtTrainTypeDescription.Text Is String.Empty Then
            MessageBox.Show("Please, write a description for this train type.")
            Exit Sub
        End If
    End Sub

    'Button Delete in TRAIN TYPES
    Private Sub btnDeleteTrainType_Click(sender As Object, e As EventArgs) Handles btnDeleteTrainType.Click
        Dim ty As TrainType
        If Not Me.lstViewTrainTypes.SelectedItems(0) Is Nothing Then
            If MessageBox.Show(" " & lstViewTrainTypes.SelectedItems(0).SubItems(1).Text & vbCrLf & " Please, choose to confirm...", "Are you sure to remove this traintype?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ty = New TrainType(Me.txtTrainTypeDescription.Text)
                ty.ReadTrainTypeDescription()

                Try
                    If ty.DeleteTrainType() <> 1 Then
                        MessageBox.Show("Error removing this Train Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    lstViewTrainTypes.Items.Remove(lstViewTrainTypes.SelectedItems(0))
                    MessageBox.Show("ID: " & ty.TrainTypeID & " Description: " & ty.TrainTypeDescription.ToString & " was correctly deleted.")
                    txtTrainTypeDescription.Text = String.Empty
                    nudMaxCapacity.Value = 0
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    'Button Update In TRAIN TYPES
    Private Sub btnUpdateTrainType_Click(sender As Object, e As EventArgs) Handles btnUpdateTrainType.Click
        Dim ty As TrainType
        If Not Me.lstViewTrainTypes.SelectedItems(0) Is Nothing Then
            If MessageBox.Show("Are you sure to update this Train Type?" & lstViewTrainTypes.SelectedItems(0).SubItems(1).Text, vbCrLf & "Please, choose to confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    ty = New TrainType(Me.txtTrainTypeDescription.Text)
                    ty.TrainTypeID = Integer.Parse(lstViewTrainTypes.SelectedItems(0).Text)
                    ty.MaxCapacity = nudMaxCapacity.Value
                    ty.TrainTypeDescription = txtTrainTypeDescription.Text

                    If ty.UpdateTrainType() <> 1 Then
                        MessageBox.Show("Error updating this traintype.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    lstViewTrainTypes.SelectedItems(0).SubItems(1).Text = ty.TrainTypeDescription
                    lstViewTrainTypes.SelectedItems(0).SubItems(2).Text = ty.MaxCapacity.ToString
                    MessageBox.Show(ty.TrainTypeDescription.ToString & " " & ty.MaxCapacity & " correctly updated.")
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
        btnAddTrainType.Enabled = True
        btnCleanTrainType.Enabled = False
        btnUpdateTrainType.Enabled = False
        btnDeleteTrainType.Enabled = False
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------BUTTONS OF TRIP TAB------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------
    'List View in Trip
    Private Sub lstViewTrip_Click(sender As Object, e As EventArgs) Handles lstViewTrip.Click
        If Not Me.lstViewTrip.SelectedItems(0) Is Nothing Then
            Dim i As Integer = lstViewTrip.FocusedItem.Index 'Select the afected row
            Try
                Me.dtpTrip.Text = lstViewTrip.Items(i).SubItems(0).Text
                Me.cboxTrainTrip.Text = lstViewTrip.Items(i).SubItems(1).Text
                Me.cboxProductTrip.Text = lstViewTrip.Items(i).SubItems(2).Text
                Me.nudTonsTrip.Text = lstViewTrip.Items(i).SubItems(3).Text
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            btnAddTrip.Enabled = False
            btnCleanTrip.Enabled = True
            btnUpdateTrip.Enabled = True
            btnDeleteTrip.Enabled = True
        End If
    End Sub

    'Button Add in Trip 
    Private Sub btnAddTrip_Click(sender As Object, e As EventArgs) Handles btnAddTrip.Click
        Dim tri As Trip : Dim pro As Product : Dim t As Train : Dim ty As TrainType

        If Not Me.dtpTrip.Text <= DateTime.Now Then
            If Me.cboxTrainTrip.Text <> Nothing And Me.cboxProductTrip.Text <> Nothing Then

                pro = New Product(Me.cboxProductTrip.Text)
                pro.ReadProductDescription()
                t = New Train(Me.cboxTrainTrip.Text)
                t.ReadTrainType()
                ty = New TrainType(t.TrainID)
                ty.ReadTrainTypeDescription()

                If Me.nudTonsTrip.Value > 0 And Me.nudTonsTrip.Value < ty.MaxCapacity Then

                    tri = New Trip(Me.dtpTrip.Text)
                    tri.Train = t.TrainID
                    tri.Product = pro.ProductID
                    tri.TonsTransported = Me.nudTonsTrip.Value

                    If (tri.isTrip = 0) Then
                        Try
                            If tri.InsertTrip <> 1 Then 'If the trip is correctly inserted the method insert() return us the value: 1
                                MessageBox.Show("Error inserting Trip.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If

                            Dim item As New ListViewItem(tri.TripDate)
                            item.SubItems.Add(t.TrainID)
                            item.SubItems.Add(pro.ProductDescription)
                            item.SubItems.Add(tri.TonsTransported)
                            lstViewTrip.Items.Add(item)

                            Me.dtpTrip.ResetText()
                            Me.cboxTrainTrip.Text = String.Empty
                            Me.cboxProductTrip.Text = String.Empty
                            Me.nudTonsTrip.Value = 0
                            btnAddTrip.Enabled = True
                            btnDeleteTrip.Enabled = False
                            btnUpdateTrip.Enabled = False
                            btnCleanTrip.Enabled = False

                        Catch ex As Exception
                            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End Try
                    Else
                        MessageBox.Show("This trip already exists.")
                        Exit Sub
                        Me.dtpTrip.ResetText()
                        Me.cboxTrainTrip.Text = String.Empty
                        Me.cboxProductTrip.Text = String.Empty
                        Me.nudTonsTrip.Value = 0
                        btnAddTrip.Enabled = True
                        btnDeleteTrip.Enabled = False
                        btnUpdateTrip.Enabled = False
                        btnCleanTrip.Enabled = False
                    End If
                Else
                    MessageBox.Show("Please type a number of tons between 1 and the Maximum capacity of the selected train.")
                    Exit Sub
                    Me.nudTonsTrip.Value = 0
                    btnAddTrip.Enabled = True
                    btnDeleteTrip.Enabled = False
                    btnUpdateTrip.Enabled = False
                    btnCleanTrip.Enabled = True
                End If
            Else
                MessageBox.Show("Please select a train or product to continue.")
                Exit Sub
                btnAddTrip.Enabled = True
                btnDeleteTrip.Enabled = False
                btnUpdateTrip.Enabled = False
                btnCleanTrip.Enabled = False
            End If
        Else
            MessageBox.Show("The date entered is before the current date, please enter a valid date.")
            Me.dtpTrip.ResetText()
            Me.cboxProductTrip.Text = String.Empty
            Me.cboxTrainTrip.Text = String.Empty
            Me.nudTonsTrip.Value = 0
            Exit Sub
        End If
    End Sub

    Private Sub btnDeleteTrip_Click(sender As Object, e As EventArgs) Handles btnDeleteTrip.Click

    End Sub

    Private Sub btnUpdateTrip_Click(sender As Object, e As EventArgs) Handles btnUpdateTrip.Click

    End Sub

    Private Sub btnCleanTrip_Click(sender As Object, e As EventArgs) Handles btnCleanTrip.Click
        Me.dtpTrip.ResetText()
        Me.cboxTrainTrip.Text = String.Empty
        Me.cboxProductTrip.Text = String.Empty
        Me.nudTonsTrip.Value = 0
        btnAddTrip.Enabled = True
        btnDeleteTrip.Enabled = False
        btnUpdateTrip.Enabled = False
        btnCleanTrip.Enabled = False
    End Sub

End Class
