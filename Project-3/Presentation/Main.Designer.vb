<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.iconList = New System.Windows.Forms.ImageList(Me.components)
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabProduct = New System.Windows.Forms.TabPage()
        Me.gbProductsList = New System.Windows.Forms.GroupBox()
        Me.lstViewProducts = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbProductsBoxes = New System.Windows.Forms.GroupBox()
        Me.txtProductDescription = New System.Windows.Forms.TextBox()
        Me.lblProductDescription = New System.Windows.Forms.Label()
        Me.gbControlProducts = New System.Windows.Forms.GroupBox()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnCleanProduct = New System.Windows.Forms.Button()
        Me.btnDeleteProduct = New System.Windows.Forms.Button()
        Me.btnUpdateProduct = New System.Windows.Forms.Button()
        Me.lblProductList = New System.Windows.Forms.Label()
        Me.tabTrains = New System.Windows.Forms.TabPage()
        Me.gbTrainsList = New System.Windows.Forms.GroupBox()
        Me.lstViewTrains = New System.Windows.Forms.ListView()
        Me.idTrains = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.trainTypeTrains = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbTrainsBoxes = New System.Windows.Forms.GroupBox()
        Me.lblTrainDescription = New System.Windows.Forms.Label()
        Me.txtTrainID = New System.Windows.Forms.TextBox()
        Me.cboxTrain = New System.Windows.Forms.ComboBox()
        Me.lblTypeTrain = New System.Windows.Forms.Label()
        Me.gbControlTrains = New System.Windows.Forms.GroupBox()
        Me.btnAddTrain = New System.Windows.Forms.Button()
        Me.btnUpdateTrain = New System.Windows.Forms.Button()
        Me.btnCleanTrain = New System.Windows.Forms.Button()
        Me.btnDeleteTrain = New System.Windows.Forms.Button()
        Me.tabTrainTypes = New System.Windows.Forms.TabPage()
        Me.gbTrainTypeList = New System.Windows.Forms.GroupBox()
        Me.lstViewTrainTypes = New System.Windows.Forms.ListView()
        Me.idTrainTypes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.descriptionTrainTypes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.capacityTrainTypes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbTrainTypeBoxes = New System.Windows.Forms.GroupBox()
        Me.lblTonsTrainType = New System.Windows.Forms.Label()
        Me.nudMaxCapacity = New System.Windows.Forms.NumericUpDown()
        Me.lblTrainType = New System.Windows.Forms.Label()
        Me.txtTrainTypeDescription = New System.Windows.Forms.TextBox()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.gbControlTrainType = New System.Windows.Forms.GroupBox()
        Me.btnAddTrainType = New System.Windows.Forms.Button()
        Me.btnCleanTrainType = New System.Windows.Forms.Button()
        Me.btnUpdateTrainType = New System.Windows.Forms.Button()
        Me.btnDeleteTrainType = New System.Windows.Forms.Button()
        Me.lblTrainTypeList = New System.Windows.Forms.Label()
        Me.tabPrices = New System.Windows.Forms.TabPage()
        Me.gbPriceList = New System.Windows.Forms.GroupBox()
        Me.lstViewPrices = New System.Windows.Forms.ListView()
        Me.ProductID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PriceDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PricePerTon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbControlPrices = New System.Windows.Forms.GroupBox()
        Me.btnAddPrices = New System.Windows.Forms.Button()
        Me.btnCleanPrices = New System.Windows.Forms.Button()
        Me.btnDeletePrices = New System.Windows.Forms.Button()
        Me.btnUpdatePrices = New System.Windows.Forms.Button()
        Me.gbPrices = New System.Windows.Forms.GroupBox()
        Me.lblEuroSymbol = New System.Windows.Forms.Label()
        Me.txtEurosPrices = New System.Windows.Forms.TextBox()
        Me.lblProductPrices = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.dtpDatePrices = New System.Windows.Forms.DateTimePicker()
        Me.cboxProductPrices = New System.Windows.Forms.ComboBox()
        Me.lblPricesList = New System.Windows.Forms.Label()
        Me.tabTrips = New System.Windows.Forms.TabPage()
        Me.gbControlTrip = New System.Windows.Forms.GroupBox()
        Me.btnAddTrip = New System.Windows.Forms.Button()
        Me.btnCleanTrip = New System.Windows.Forms.Button()
        Me.btnDeleteTrip = New System.Windows.Forms.Button()
        Me.btnUpdateTrip = New System.Windows.Forms.Button()
        Me.gbSelectionTrip = New System.Windows.Forms.GroupBox()
        Me.nudTonsTrip = New System.Windows.Forms.NumericUpDown()
        Me.cboxProductTrip = New System.Windows.Forms.ComboBox()
        Me.cboxTrainTrip = New System.Windows.Forms.ComboBox()
        Me.lblTonsTrip = New System.Windows.Forms.Label()
        Me.lblTrainTrip = New System.Windows.Forms.Label()
        Me.lblProductTrip = New System.Windows.Forms.Label()
        Me.lblDateTrip = New System.Windows.Forms.Label()
        Me.dtpTrip = New System.Windows.Forms.DateTimePicker()
        Me.gbTripList = New System.Windows.Forms.GroupBox()
        Me.lstViewTrip = New System.Windows.Forms.ListView()
        Me.dateTrip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.trainTrip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productTrip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tonsTrip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabQuery = New System.Windows.Forms.TabPage()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.OfdPath = New System.Windows.Forms.OpenFileDialog()
        Me.gbDatabase = New System.Windows.Forms.GroupBox()
        Me.tabControl.SuspendLayout()
        Me.tabProduct.SuspendLayout()
        Me.gbProductsList.SuspendLayout()
        Me.gbProductsBoxes.SuspendLayout()
        Me.gbControlProducts.SuspendLayout()
        Me.tabTrains.SuspendLayout()
        Me.gbTrainsList.SuspendLayout()
        Me.gbTrainsBoxes.SuspendLayout()
        Me.gbControlTrains.SuspendLayout()
        Me.tabTrainTypes.SuspendLayout()
        Me.gbTrainTypeList.SuspendLayout()
        Me.gbTrainTypeBoxes.SuspendLayout()
        CType(Me.nudMaxCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbControlTrainType.SuspendLayout()
        Me.tabPrices.SuspendLayout()
        Me.gbPriceList.SuspendLayout()
        Me.gbControlPrices.SuspendLayout()
        Me.gbPrices.SuspendLayout()
        Me.tabTrips.SuspendLayout()
        Me.gbControlTrip.SuspendLayout()
        Me.gbSelectionTrip.SuspendLayout()
        CType(Me.nudTonsTrip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTripList.SuspendLayout()
        Me.gbDatabase.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelect.ImageKey = "selectButton.png"
        Me.btnSelect.ImageList = Me.iconList
        Me.btnSelect.Location = New System.Drawing.Point(7, 24)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(191, 25)
        Me.btnSelect.TabIndex = 0
        Me.btnSelect.Text = "Select DB"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'iconList
        '
        Me.iconList.ImageStream = CType(resources.GetObject("iconList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iconList.TransparentColor = System.Drawing.Color.Transparent
        Me.iconList.Images.SetKeyName(0, "productTab.png")
        Me.iconList.Images.SetKeyName(1, "trainTab.png")
        Me.iconList.Images.SetKeyName(2, "trainTypeTab.png")
        Me.iconList.Images.SetKeyName(3, "priceTab.png")
        Me.iconList.Images.SetKeyName(4, "tripTab.png")
        Me.iconList.Images.SetKeyName(5, "queryTab.png")
        Me.iconList.Images.SetKeyName(6, "addButton.png")
        Me.iconList.Images.SetKeyName(7, "cleanButton.png")
        Me.iconList.Images.SetKeyName(8, "deleteButton.png")
        Me.iconList.Images.SetKeyName(9, "updateButton.png")
        Me.iconList.Images.SetKeyName(10, "selectButton.png")
        Me.iconList.Images.SetKeyName(11, "dbIcon.png")
        '
        'btnConnect
        '
        Me.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConnect.ImageIndex = 11
        Me.btnConnect.ImageList = Me.iconList
        Me.btnConnect.Location = New System.Drawing.Point(8, 55)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(191, 28)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Connect DB"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabProduct)
        Me.tabControl.Controls.Add(Me.tabTrains)
        Me.tabControl.Controls.Add(Me.tabTrainTypes)
        Me.tabControl.Controls.Add(Me.tabPrices)
        Me.tabControl.Controls.Add(Me.tabTrips)
        Me.tabControl.Controls.Add(Me.tabQuery)
        Me.tabControl.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl.ImageList = Me.iconList
        Me.tabControl.Location = New System.Drawing.Point(15, 12)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(708, 455)
        Me.tabControl.TabIndex = 5
        '
        'tabProduct
        '
        Me.tabProduct.Controls.Add(Me.gbProductsList)
        Me.tabProduct.Controls.Add(Me.gbProductsBoxes)
        Me.tabProduct.Controls.Add(Me.gbControlProducts)
        Me.tabProduct.Controls.Add(Me.lblProductList)
        Me.tabProduct.ImageIndex = 0
        Me.tabProduct.Location = New System.Drawing.Point(4, 26)
        Me.tabProduct.Name = "tabProduct"
        Me.tabProduct.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProduct.Size = New System.Drawing.Size(700, 425)
        Me.tabProduct.TabIndex = 1
        Me.tabProduct.Text = "Products"
        Me.tabProduct.UseVisualStyleBackColor = True
        '
        'gbProductsList
        '
        Me.gbProductsList.Controls.Add(Me.lstViewProducts)
        Me.gbProductsList.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProductsList.Location = New System.Drawing.Point(10, 6)
        Me.gbProductsList.Name = "gbProductsList"
        Me.gbProductsList.Size = New System.Drawing.Size(322, 409)
        Me.gbProductsList.TabIndex = 21
        Me.gbProductsList.TabStop = False
        Me.gbProductsList.Text = "Products List"
        '
        'lstViewProducts
        '
        Me.lstViewProducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Description})
        Me.lstViewProducts.FullRowSelect = True
        Me.lstViewProducts.HideSelection = False
        Me.lstViewProducts.Location = New System.Drawing.Point(6, 18)
        Me.lstViewProducts.MultiSelect = False
        Me.lstViewProducts.Name = "lstViewProducts"
        Me.lstViewProducts.Size = New System.Drawing.Size(310, 382)
        Me.lstViewProducts.TabIndex = 40
        Me.lstViewProducts.UseCompatibleStateImageBehavior = False
        Me.lstViewProducts.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 40
        '
        'Description
        '
        Me.Description.Text = "Product Description"
        Me.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Description.Width = 265
        '
        'gbProductsBoxes
        '
        Me.gbProductsBoxes.Controls.Add(Me.txtProductDescription)
        Me.gbProductsBoxes.Controls.Add(Me.lblProductDescription)
        Me.gbProductsBoxes.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProductsBoxes.Location = New System.Drawing.Point(339, 248)
        Me.gbProductsBoxes.Name = "gbProductsBoxes"
        Me.gbProductsBoxes.Size = New System.Drawing.Size(339, 167)
        Me.gbProductsBoxes.TabIndex = 20
        Me.gbProductsBoxes.TabStop = False
        Me.gbProductsBoxes.Text = "Selection Product Panel"
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Location = New System.Drawing.Point(10, 63)
        Me.txtProductDescription.Multiline = True
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.Size = New System.Drawing.Size(312, 95)
        Me.txtProductDescription.TabIndex = 6
        '
        'lblProductDescription
        '
        Me.lblProductDescription.AutoSize = True
        Me.lblProductDescription.Location = New System.Drawing.Point(7, 33)
        Me.lblProductDescription.Name = "lblProductDescription"
        Me.lblProductDescription.Size = New System.Drawing.Size(142, 17)
        Me.lblProductDescription.TabIndex = 7
        Me.lblProductDescription.Text = "Product Description"
        '
        'gbControlProducts
        '
        Me.gbControlProducts.Controls.Add(Me.btnAddProduct)
        Me.gbControlProducts.Controls.Add(Me.btnCleanProduct)
        Me.gbControlProducts.Controls.Add(Me.btnDeleteProduct)
        Me.gbControlProducts.Controls.Add(Me.btnUpdateProduct)
        Me.gbControlProducts.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbControlProducts.Location = New System.Drawing.Point(339, 6)
        Me.gbControlProducts.Name = "gbControlProducts"
        Me.gbControlProducts.Size = New System.Drawing.Size(338, 152)
        Me.gbControlProducts.TabIndex = 19
        Me.gbControlProducts.TabStop = False
        Me.gbControlProducts.Text = "Control Panel"
        '
        'btnAddProduct
        '
        Me.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddProduct.ImageIndex = 6
        Me.btnAddProduct.ImageList = Me.iconList
        Me.btnAddProduct.Location = New System.Drawing.Point(28, 31)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(115, 42)
        Me.btnAddProduct.TabIndex = 2
        Me.btnAddProduct.Text = "Add"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnCleanProduct
        '
        Me.btnCleanProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCleanProduct.ImageIndex = 7
        Me.btnCleanProduct.ImageList = Me.iconList
        Me.btnCleanProduct.Location = New System.Drawing.Point(28, 88)
        Me.btnCleanProduct.Name = "btnCleanProduct"
        Me.btnCleanProduct.Size = New System.Drawing.Size(115, 42)
        Me.btnCleanProduct.TabIndex = 3
        Me.btnCleanProduct.Text = "Clean"
        Me.btnCleanProduct.UseVisualStyleBackColor = True
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteProduct.ImageIndex = 8
        Me.btnDeleteProduct.ImageList = Me.iconList
        Me.btnDeleteProduct.Location = New System.Drawing.Point(202, 88)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Size = New System.Drawing.Size(115, 42)
        Me.btnDeleteProduct.TabIndex = 4
        Me.btnDeleteProduct.Text = "Delete"
        Me.btnDeleteProduct.UseVisualStyleBackColor = True
        '
        'btnUpdateProduct
        '
        Me.btnUpdateProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateProduct.ImageIndex = 9
        Me.btnUpdateProduct.ImageList = Me.iconList
        Me.btnUpdateProduct.Location = New System.Drawing.Point(202, 31)
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.Size = New System.Drawing.Size(115, 42)
        Me.btnUpdateProduct.TabIndex = 5
        Me.btnUpdateProduct.Text = "Update"
        Me.btnUpdateProduct.UseVisualStyleBackColor = True
        '
        'lblProductList
        '
        Me.lblProductList.Location = New System.Drawing.Point(7, 24)
        Me.lblProductList.Name = "lblProductList"
        Me.lblProductList.Size = New System.Drawing.Size(153, 15)
        Me.lblProductList.TabIndex = 1
        Me.lblProductList.Text = "Product List"
        '
        'tabTrains
        '
        Me.tabTrains.Controls.Add(Me.gbTrainsList)
        Me.tabTrains.Controls.Add(Me.gbTrainsBoxes)
        Me.tabTrains.Controls.Add(Me.gbControlTrains)
        Me.tabTrains.ImageKey = "trainTab.png"
        Me.tabTrains.Location = New System.Drawing.Point(4, 26)
        Me.tabTrains.Name = "tabTrains"
        Me.tabTrains.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTrains.Size = New System.Drawing.Size(700, 425)
        Me.tabTrains.TabIndex = 2
        Me.tabTrains.Text = "Trains"
        Me.tabTrains.UseVisualStyleBackColor = True
        '
        'gbTrainsList
        '
        Me.gbTrainsList.Controls.Add(Me.lstViewTrains)
        Me.gbTrainsList.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTrainsList.Location = New System.Drawing.Point(10, 6)
        Me.gbTrainsList.Name = "gbTrainsList"
        Me.gbTrainsList.Size = New System.Drawing.Size(322, 409)
        Me.gbTrainsList.TabIndex = 20
        Me.gbTrainsList.TabStop = False
        Me.gbTrainsList.Text = "Trains List"
        '
        'lstViewTrains
        '
        Me.lstViewTrains.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idTrains, Me.trainTypeTrains})
        Me.lstViewTrains.FullRowSelect = True
        Me.lstViewTrains.HideSelection = False
        Me.lstViewTrains.Location = New System.Drawing.Point(6, 18)
        Me.lstViewTrains.MultiSelect = False
        Me.lstViewTrains.Name = "lstViewTrains"
        Me.lstViewTrains.Size = New System.Drawing.Size(310, 377)
        Me.lstViewTrains.TabIndex = 0
        Me.lstViewTrains.UseCompatibleStateImageBehavior = False
        Me.lstViewTrains.View = System.Windows.Forms.View.Details
        '
        'idTrains
        '
        Me.idTrains.Text = "ID"
        Me.idTrains.Width = 130
        '
        'trainTypeTrains
        '
        Me.trainTypeTrains.Text = "Train Type"
        Me.trainTypeTrains.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trainTypeTrains.Width = 175
        '
        'gbTrainsBoxes
        '
        Me.gbTrainsBoxes.Controls.Add(Me.lblTrainDescription)
        Me.gbTrainsBoxes.Controls.Add(Me.txtTrainID)
        Me.gbTrainsBoxes.Controls.Add(Me.cboxTrain)
        Me.gbTrainsBoxes.Controls.Add(Me.lblTypeTrain)
        Me.gbTrainsBoxes.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTrainsBoxes.Location = New System.Drawing.Point(339, 224)
        Me.gbTrainsBoxes.Name = "gbTrainsBoxes"
        Me.gbTrainsBoxes.Size = New System.Drawing.Size(338, 191)
        Me.gbTrainsBoxes.TabIndex = 19
        Me.gbTrainsBoxes.TabStop = False
        Me.gbTrainsBoxes.Text = "Selection Train Panel"
        '
        'lblTrainDescription
        '
        Me.lblTrainDescription.AutoSize = True
        Me.lblTrainDescription.Location = New System.Drawing.Point(6, 49)
        Me.lblTrainDescription.Name = "lblTrainDescription"
        Me.lblTrainDescription.Size = New System.Drawing.Size(65, 17)
        Me.lblTrainDescription.TabIndex = 15
        Me.lblTrainDescription.Text = "Train ID:"
        '
        'txtTrainID
        '
        Me.txtTrainID.Location = New System.Drawing.Point(85, 46)
        Me.txtTrainID.Multiline = True
        Me.txtTrainID.Name = "txtTrainID"
        Me.txtTrainID.Size = New System.Drawing.Size(245, 22)
        Me.txtTrainID.TabIndex = 14
        '
        'cboxTrain
        '
        Me.cboxTrain.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxTrain.FormattingEnabled = True
        Me.cboxTrain.Location = New System.Drawing.Point(82, 109)
        Me.cboxTrain.Name = "cboxTrain"
        Me.cboxTrain.Size = New System.Drawing.Size(245, 25)
        Me.cboxTrain.TabIndex = 17
        '
        'lblTypeTrain
        '
        Me.lblTypeTrain.AutoSize = True
        Me.lblTypeTrain.Location = New System.Drawing.Point(27, 112)
        Me.lblTypeTrain.Name = "lblTypeTrain"
        Me.lblTypeTrain.Size = New System.Drawing.Size(44, 17)
        Me.lblTypeTrain.TabIndex = 16
        Me.lblTypeTrain.Text = "Type:"
        '
        'gbControlTrains
        '
        Me.gbControlTrains.Controls.Add(Me.btnAddTrain)
        Me.gbControlTrains.Controls.Add(Me.btnUpdateTrain)
        Me.gbControlTrains.Controls.Add(Me.btnCleanTrain)
        Me.gbControlTrains.Controls.Add(Me.btnDeleteTrain)
        Me.gbControlTrains.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbControlTrains.Location = New System.Drawing.Point(339, 6)
        Me.gbControlTrains.Name = "gbControlTrains"
        Me.gbControlTrains.Size = New System.Drawing.Size(338, 152)
        Me.gbControlTrains.TabIndex = 18
        Me.gbControlTrains.TabStop = False
        Me.gbControlTrains.Text = "Control Panel"
        '
        'btnAddTrain
        '
        Me.btnAddTrain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddTrain.ImageIndex = 6
        Me.btnAddTrain.ImageList = Me.iconList
        Me.btnAddTrain.Location = New System.Drawing.Point(28, 31)
        Me.btnAddTrain.Name = "btnAddTrain"
        Me.btnAddTrain.Size = New System.Drawing.Size(115, 42)
        Me.btnAddTrain.TabIndex = 10
        Me.btnAddTrain.Text = "Add"
        Me.btnAddTrain.UseVisualStyleBackColor = True
        '
        'btnUpdateTrain
        '
        Me.btnUpdateTrain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateTrain.ImageIndex = 9
        Me.btnUpdateTrain.ImageList = Me.iconList
        Me.btnUpdateTrain.Location = New System.Drawing.Point(202, 31)
        Me.btnUpdateTrain.Name = "btnUpdateTrain"
        Me.btnUpdateTrain.Size = New System.Drawing.Size(115, 42)
        Me.btnUpdateTrain.TabIndex = 13
        Me.btnUpdateTrain.Text = "Update"
        Me.btnUpdateTrain.UseVisualStyleBackColor = True
        '
        'btnCleanTrain
        '
        Me.btnCleanTrain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCleanTrain.ImageIndex = 7
        Me.btnCleanTrain.ImageList = Me.iconList
        Me.btnCleanTrain.Location = New System.Drawing.Point(28, 88)
        Me.btnCleanTrain.Name = "btnCleanTrain"
        Me.btnCleanTrain.Size = New System.Drawing.Size(115, 42)
        Me.btnCleanTrain.TabIndex = 11
        Me.btnCleanTrain.Text = "Clean"
        Me.btnCleanTrain.UseVisualStyleBackColor = True
        '
        'btnDeleteTrain
        '
        Me.btnDeleteTrain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteTrain.ImageIndex = 8
        Me.btnDeleteTrain.ImageList = Me.iconList
        Me.btnDeleteTrain.Location = New System.Drawing.Point(202, 88)
        Me.btnDeleteTrain.Name = "btnDeleteTrain"
        Me.btnDeleteTrain.Size = New System.Drawing.Size(115, 42)
        Me.btnDeleteTrain.TabIndex = 12
        Me.btnDeleteTrain.Text = "Delete"
        Me.btnDeleteTrain.UseVisualStyleBackColor = True
        '
        'tabTrainTypes
        '
        Me.tabTrainTypes.Controls.Add(Me.gbTrainTypeList)
        Me.tabTrainTypes.Controls.Add(Me.gbTrainTypeBoxes)
        Me.tabTrainTypes.Controls.Add(Me.gbControlTrainType)
        Me.tabTrainTypes.Controls.Add(Me.lblTrainTypeList)
        Me.tabTrainTypes.ImageIndex = 2
        Me.tabTrainTypes.Location = New System.Drawing.Point(4, 26)
        Me.tabTrainTypes.Name = "tabTrainTypes"
        Me.tabTrainTypes.Size = New System.Drawing.Size(700, 425)
        Me.tabTrainTypes.TabIndex = 3
        Me.tabTrainTypes.Text = "Train Types"
        Me.tabTrainTypes.UseVisualStyleBackColor = True
        '
        'gbTrainTypeList
        '
        Me.gbTrainTypeList.Controls.Add(Me.lstViewTrainTypes)
        Me.gbTrainTypeList.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTrainTypeList.Location = New System.Drawing.Point(10, 6)
        Me.gbTrainTypeList.Name = "gbTrainTypeList"
        Me.gbTrainTypeList.Size = New System.Drawing.Size(322, 409)
        Me.gbTrainTypeList.TabIndex = 21
        Me.gbTrainTypeList.TabStop = False
        Me.gbTrainTypeList.Text = "Train Types List"
        '
        'lstViewTrainTypes
        '
        Me.lstViewTrainTypes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idTrainTypes, Me.descriptionTrainTypes, Me.capacityTrainTypes})
        Me.lstViewTrainTypes.Font = New System.Drawing.Font("Segoe UI Historic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstViewTrainTypes.FullRowSelect = True
        Me.lstViewTrainTypes.HideSelection = False
        Me.lstViewTrainTypes.Location = New System.Drawing.Point(6, 24)
        Me.lstViewTrainTypes.MultiSelect = False
        Me.lstViewTrainTypes.Name = "lstViewTrainTypes"
        Me.lstViewTrainTypes.Size = New System.Drawing.Size(310, 371)
        Me.lstViewTrainTypes.TabIndex = 41
        Me.lstViewTrainTypes.UseCompatibleStateImageBehavior = False
        Me.lstViewTrainTypes.View = System.Windows.Forms.View.Details
        '
        'idTrainTypes
        '
        Me.idTrainTypes.Text = "ID"
        Me.idTrainTypes.Width = 30
        '
        'descriptionTrainTypes
        '
        Me.descriptionTrainTypes.Text = "Train Type Description"
        Me.descriptionTrainTypes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.descriptionTrainTypes.Width = 163
        '
        'capacityTrainTypes
        '
        Me.capacityTrainTypes.Text = "Max. Capacity"
        Me.capacityTrainTypes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.capacityTrainTypes.Width = 112
        '
        'gbTrainTypeBoxes
        '
        Me.gbTrainTypeBoxes.Controls.Add(Me.lblTonsTrainType)
        Me.gbTrainTypeBoxes.Controls.Add(Me.nudMaxCapacity)
        Me.gbTrainTypeBoxes.Controls.Add(Me.lblTrainType)
        Me.gbTrainTypeBoxes.Controls.Add(Me.txtTrainTypeDescription)
        Me.gbTrainTypeBoxes.Controls.Add(Me.lblCapacity)
        Me.gbTrainTypeBoxes.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTrainTypeBoxes.Location = New System.Drawing.Point(339, 178)
        Me.gbTrainTypeBoxes.Name = "gbTrainTypeBoxes"
        Me.gbTrainTypeBoxes.Size = New System.Drawing.Size(349, 238)
        Me.gbTrainTypeBoxes.TabIndex = 20
        Me.gbTrainTypeBoxes.TabStop = False
        Me.gbTrainTypeBoxes.Text = "Selection Train Type Panel"
        '
        'lblTonsTrainType
        '
        Me.lblTonsTrainType.AutoSize = True
        Me.lblTonsTrainType.Location = New System.Drawing.Point(236, 151)
        Me.lblTonsTrainType.Name = "lblTonsTrainType"
        Me.lblTonsTrainType.Size = New System.Drawing.Size(40, 17)
        Me.lblTonsTrainType.TabIndex = 19
        Me.lblTonsTrainType.Text = "Tons"
        '
        'nudMaxCapacity
        '
        Me.nudMaxCapacity.Location = New System.Drawing.Point(159, 149)
        Me.nudMaxCapacity.Name = "nudMaxCapacity"
        Me.nudMaxCapacity.Size = New System.Drawing.Size(71, 25)
        Me.nudMaxCapacity.TabIndex = 18
        Me.nudMaxCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTrainType
        '
        Me.lblTrainType.AutoSize = True
        Me.lblTrainType.Location = New System.Drawing.Point(6, 25)
        Me.lblTrainType.Name = "lblTrainType"
        Me.lblTrainType.Size = New System.Drawing.Size(161, 17)
        Me.lblTrainType.TabIndex = 15
        Me.lblTrainType.Text = "Train Type Description"
        '
        'txtTrainTypeDescription
        '
        Me.txtTrainTypeDescription.Location = New System.Drawing.Point(10, 51)
        Me.txtTrainTypeDescription.Multiline = True
        Me.txtTrainTypeDescription.Name = "txtTrainTypeDescription"
        Me.txtTrainTypeDescription.Size = New System.Drawing.Size(324, 51)
        Me.txtTrainTypeDescription.TabIndex = 14
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(5, 151)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(138, 17)
        Me.lblCapacity.TabIndex = 16
        Me.lblCapacity.Text = "Maximum Capacity:"
        '
        'gbControlTrainType
        '
        Me.gbControlTrainType.Controls.Add(Me.btnAddTrainType)
        Me.gbControlTrainType.Controls.Add(Me.btnCleanTrainType)
        Me.gbControlTrainType.Controls.Add(Me.btnUpdateTrainType)
        Me.gbControlTrainType.Controls.Add(Me.btnDeleteTrainType)
        Me.gbControlTrainType.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbControlTrainType.Location = New System.Drawing.Point(339, 6)
        Me.gbControlTrainType.Name = "gbControlTrainType"
        Me.gbControlTrainType.Size = New System.Drawing.Size(349, 152)
        Me.gbControlTrainType.TabIndex = 19
        Me.gbControlTrainType.TabStop = False
        Me.gbControlTrainType.Text = "Control Panel"
        '
        'btnAddTrainType
        '
        Me.btnAddTrainType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddTrainType.ImageIndex = 6
        Me.btnAddTrainType.ImageList = Me.iconList
        Me.btnAddTrainType.Location = New System.Drawing.Point(28, 31)
        Me.btnAddTrainType.Name = "btnAddTrainType"
        Me.btnAddTrainType.Size = New System.Drawing.Size(115, 42)
        Me.btnAddTrainType.TabIndex = 10
        Me.btnAddTrainType.Text = "Add"
        Me.btnAddTrainType.UseVisualStyleBackColor = True
        '
        'btnCleanTrainType
        '
        Me.btnCleanTrainType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCleanTrainType.ImageIndex = 7
        Me.btnCleanTrainType.ImageList = Me.iconList
        Me.btnCleanTrainType.Location = New System.Drawing.Point(28, 88)
        Me.btnCleanTrainType.Name = "btnCleanTrainType"
        Me.btnCleanTrainType.Size = New System.Drawing.Size(115, 42)
        Me.btnCleanTrainType.TabIndex = 11
        Me.btnCleanTrainType.Text = "Clean"
        Me.btnCleanTrainType.UseVisualStyleBackColor = True
        '
        'btnUpdateTrainType
        '
        Me.btnUpdateTrainType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateTrainType.ImageIndex = 9
        Me.btnUpdateTrainType.ImageList = Me.iconList
        Me.btnUpdateTrainType.Location = New System.Drawing.Point(202, 31)
        Me.btnUpdateTrainType.Name = "btnUpdateTrainType"
        Me.btnUpdateTrainType.Size = New System.Drawing.Size(115, 42)
        Me.btnUpdateTrainType.TabIndex = 13
        Me.btnUpdateTrainType.Text = "Update"
        Me.btnUpdateTrainType.UseVisualStyleBackColor = True
        '
        'btnDeleteTrainType
        '
        Me.btnDeleteTrainType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteTrainType.ImageIndex = 8
        Me.btnDeleteTrainType.ImageList = Me.iconList
        Me.btnDeleteTrainType.Location = New System.Drawing.Point(202, 88)
        Me.btnDeleteTrainType.Name = "btnDeleteTrainType"
        Me.btnDeleteTrainType.Size = New System.Drawing.Size(115, 42)
        Me.btnDeleteTrainType.TabIndex = 12
        Me.btnDeleteTrainType.Text = "Delete"
        Me.btnDeleteTrainType.UseVisualStyleBackColor = True
        '
        'lblTrainTypeList
        '
        Me.lblTrainTypeList.Location = New System.Drawing.Point(15, 13)
        Me.lblTrainTypeList.Name = "lblTrainTypeList"
        Me.lblTrainTypeList.Size = New System.Drawing.Size(153, 15)
        Me.lblTrainTypeList.TabIndex = 9
        Me.lblTrainTypeList.Text = "Train Type List"
        '
        'tabPrices
        '
        Me.tabPrices.Controls.Add(Me.gbPriceList)
        Me.tabPrices.Controls.Add(Me.gbControlPrices)
        Me.tabPrices.Controls.Add(Me.gbPrices)
        Me.tabPrices.Controls.Add(Me.lblPricesList)
        Me.tabPrices.ImageIndex = 3
        Me.tabPrices.Location = New System.Drawing.Point(4, 26)
        Me.tabPrices.Name = "tabPrices"
        Me.tabPrices.Size = New System.Drawing.Size(700, 425)
        Me.tabPrices.TabIndex = 4
        Me.tabPrices.Text = "Prices"
        Me.tabPrices.UseVisualStyleBackColor = True
        '
        'gbPriceList
        '
        Me.gbPriceList.Controls.Add(Me.lstViewPrices)
        Me.gbPriceList.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPriceList.Location = New System.Drawing.Point(10, 6)
        Me.gbPriceList.Name = "gbPriceList"
        Me.gbPriceList.Size = New System.Drawing.Size(322, 409)
        Me.gbPriceList.TabIndex = 35
        Me.gbPriceList.TabStop = False
        Me.gbPriceList.Text = "Prices List"
        '
        'lstViewPrices
        '
        Me.lstViewPrices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductID, Me.ProductDescription, Me.PriceDate, Me.PricePerTon})
        Me.lstViewPrices.FullRowSelect = True
        Me.lstViewPrices.HideSelection = False
        Me.lstViewPrices.Location = New System.Drawing.Point(6, 20)
        Me.lstViewPrices.MultiSelect = False
        Me.lstViewPrices.Name = "lstViewPrices"
        Me.lstViewPrices.Size = New System.Drawing.Size(307, 383)
        Me.lstViewPrices.TabIndex = 0
        Me.lstViewPrices.UseCompatibleStateImageBehavior = False
        Me.lstViewPrices.View = System.Windows.Forms.View.Details
        '
        'ProductID
        '
        Me.ProductID.Text = "ID"
        Me.ProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ProductID.Width = 30
        '
        'ProductDescription
        '
        Me.ProductDescription.Text = "Product"
        Me.ProductDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ProductDescription.Width = 90
        '
        'PriceDate
        '
        Me.PriceDate.Text = "Price Date"
        Me.PriceDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PriceDate.Width = 90
        '
        'PricePerTon
        '
        Me.PricePerTon.Text = "Euros/Tons"
        Me.PricePerTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PricePerTon.Width = 90
        '
        'gbControlPrices
        '
        Me.gbControlPrices.Controls.Add(Me.btnAddPrices)
        Me.gbControlPrices.Controls.Add(Me.btnCleanPrices)
        Me.gbControlPrices.Controls.Add(Me.btnDeletePrices)
        Me.gbControlPrices.Controls.Add(Me.btnUpdatePrices)
        Me.gbControlPrices.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbControlPrices.Location = New System.Drawing.Point(339, 6)
        Me.gbControlPrices.Name = "gbControlPrices"
        Me.gbControlPrices.Size = New System.Drawing.Size(349, 152)
        Me.gbControlPrices.TabIndex = 34
        Me.gbControlPrices.TabStop = False
        Me.gbControlPrices.Text = "Control Panel"
        '
        'btnAddPrices
        '
        Me.btnAddPrices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddPrices.ImageIndex = 6
        Me.btnAddPrices.ImageList = Me.iconList
        Me.btnAddPrices.Location = New System.Drawing.Point(28, 31)
        Me.btnAddPrices.Name = "btnAddPrices"
        Me.btnAddPrices.Size = New System.Drawing.Size(115, 42)
        Me.btnAddPrices.TabIndex = 23
        Me.btnAddPrices.Text = "Add"
        Me.btnAddPrices.UseVisualStyleBackColor = True
        '
        'btnCleanPrices
        '
        Me.btnCleanPrices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCleanPrices.ImageIndex = 7
        Me.btnCleanPrices.ImageList = Me.iconList
        Me.btnCleanPrices.Location = New System.Drawing.Point(28, 88)
        Me.btnCleanPrices.Name = "btnCleanPrices"
        Me.btnCleanPrices.Size = New System.Drawing.Size(115, 42)
        Me.btnCleanPrices.TabIndex = 24
        Me.btnCleanPrices.Text = "Clean"
        Me.btnCleanPrices.UseVisualStyleBackColor = True
        '
        'btnDeletePrices
        '
        Me.btnDeletePrices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeletePrices.ImageIndex = 8
        Me.btnDeletePrices.ImageList = Me.iconList
        Me.btnDeletePrices.Location = New System.Drawing.Point(202, 88)
        Me.btnDeletePrices.Name = "btnDeletePrices"
        Me.btnDeletePrices.Size = New System.Drawing.Size(115, 42)
        Me.btnDeletePrices.TabIndex = 25
        Me.btnDeletePrices.Text = "Delete"
        Me.btnDeletePrices.UseVisualStyleBackColor = True
        '
        'btnUpdatePrices
        '
        Me.btnUpdatePrices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdatePrices.ImageIndex = 9
        Me.btnUpdatePrices.ImageList = Me.iconList
        Me.btnUpdatePrices.Location = New System.Drawing.Point(202, 31)
        Me.btnUpdatePrices.Name = "btnUpdatePrices"
        Me.btnUpdatePrices.Size = New System.Drawing.Size(115, 42)
        Me.btnUpdatePrices.TabIndex = 26
        Me.btnUpdatePrices.Text = "Update"
        Me.btnUpdatePrices.UseVisualStyleBackColor = True
        '
        'gbPrices
        '
        Me.gbPrices.Controls.Add(Me.lblEuroSymbol)
        Me.gbPrices.Controls.Add(Me.txtEurosPrices)
        Me.gbPrices.Controls.Add(Me.lblProductPrices)
        Me.gbPrices.Controls.Add(Me.lblDate)
        Me.gbPrices.Controls.Add(Me.lblPrice)
        Me.gbPrices.Controls.Add(Me.dtpDatePrices)
        Me.gbPrices.Controls.Add(Me.cboxProductPrices)
        Me.gbPrices.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPrices.Location = New System.Drawing.Point(339, 243)
        Me.gbPrices.Name = "gbPrices"
        Me.gbPrices.Size = New System.Drawing.Size(349, 172)
        Me.gbPrices.TabIndex = 33
        Me.gbPrices.TabStop = False
        Me.gbPrices.Text = "Prices Selection"
        '
        'lblEuroSymbol
        '
        Me.lblEuroSymbol.AutoSize = True
        Me.lblEuroSymbol.Font = New System.Drawing.Font("Segoe UI Historic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEuroSymbol.Location = New System.Drawing.Point(176, 123)
        Me.lblEuroSymbol.Name = "lblEuroSymbol"
        Me.lblEuroSymbol.Size = New System.Drawing.Size(23, 25)
        Me.lblEuroSymbol.TabIndex = 33
        Me.lblEuroSymbol.Text = "€"
        '
        'txtEurosPrices
        '
        Me.txtEurosPrices.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEurosPrices.Location = New System.Drawing.Point(81, 123)
        Me.txtEurosPrices.Name = "txtEurosPrices"
        Me.txtEurosPrices.Size = New System.Drawing.Size(89, 25)
        Me.txtEurosPrices.TabIndex = 32
        Me.txtEurosPrices.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblProductPrices
        '
        Me.lblProductPrices.AutoSize = True
        Me.lblProductPrices.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductPrices.Location = New System.Drawing.Point(6, 31)
        Me.lblProductPrices.Name = "lblProductPrices"
        Me.lblProductPrices.Size = New System.Drawing.Size(69, 17)
        Me.lblProductPrices.TabIndex = 27
        Me.lblProductPrices.Text = "Product: "
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(15, 83)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(43, 17)
        Me.lblDate.TabIndex = 30
        Me.lblDate.Text = "Date:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(13, 129)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(45, 17)
        Me.lblPrice.TabIndex = 31
        Me.lblPrice.Text = "Price:"
        '
        'dtpDatePrices
        '
        Me.dtpDatePrices.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDatePrices.Location = New System.Drawing.Point(81, 77)
        Me.dtpDatePrices.Name = "dtpDatePrices"
        Me.dtpDatePrices.Size = New System.Drawing.Size(262, 25)
        Me.dtpDatePrices.TabIndex = 29
        '
        'cboxProductPrices
        '
        Me.cboxProductPrices.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxProductPrices.FormattingEnabled = True
        Me.cboxProductPrices.Location = New System.Drawing.Point(81, 27)
        Me.cboxProductPrices.Name = "cboxProductPrices"
        Me.cboxProductPrices.Size = New System.Drawing.Size(262, 25)
        Me.cboxProductPrices.TabIndex = 28
        '
        'lblPricesList
        '
        Me.lblPricesList.Location = New System.Drawing.Point(21, 26)
        Me.lblPricesList.Name = "lblPricesList"
        Me.lblPricesList.Size = New System.Drawing.Size(153, 15)
        Me.lblPricesList.TabIndex = 22
        Me.lblPricesList.Text = "Prices List"
        '
        'tabTrips
        '
        Me.tabTrips.Controls.Add(Me.gbControlTrip)
        Me.tabTrips.Controls.Add(Me.gbSelectionTrip)
        Me.tabTrips.Controls.Add(Me.gbTripList)
        Me.tabTrips.ImageIndex = 4
        Me.tabTrips.Location = New System.Drawing.Point(4, 26)
        Me.tabTrips.Name = "tabTrips"
        Me.tabTrips.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTrips.Size = New System.Drawing.Size(700, 425)
        Me.tabTrips.TabIndex = 0
        Me.tabTrips.Text = "Trips"
        Me.tabTrips.UseVisualStyleBackColor = True
        '
        'gbControlTrip
        '
        Me.gbControlTrip.Controls.Add(Me.btnAddTrip)
        Me.gbControlTrip.Controls.Add(Me.btnCleanTrip)
        Me.gbControlTrip.Controls.Add(Me.btnDeleteTrip)
        Me.gbControlTrip.Controls.Add(Me.btnUpdateTrip)
        Me.gbControlTrip.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbControlTrip.Location = New System.Drawing.Point(356, 6)
        Me.gbControlTrip.Name = "gbControlTrip"
        Me.gbControlTrip.Size = New System.Drawing.Size(338, 152)
        Me.gbControlTrip.TabIndex = 35
        Me.gbControlTrip.TabStop = False
        Me.gbControlTrip.Text = "Control Panel"
        '
        'btnAddTrip
        '
        Me.btnAddTrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddTrip.ImageIndex = 6
        Me.btnAddTrip.ImageList = Me.iconList
        Me.btnAddTrip.Location = New System.Drawing.Point(28, 31)
        Me.btnAddTrip.Name = "btnAddTrip"
        Me.btnAddTrip.Size = New System.Drawing.Size(115, 42)
        Me.btnAddTrip.TabIndex = 23
        Me.btnAddTrip.Text = "Add"
        Me.btnAddTrip.UseVisualStyleBackColor = True
        '
        'btnCleanTrip
        '
        Me.btnCleanTrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCleanTrip.ImageIndex = 7
        Me.btnCleanTrip.ImageList = Me.iconList
        Me.btnCleanTrip.Location = New System.Drawing.Point(28, 88)
        Me.btnCleanTrip.Name = "btnCleanTrip"
        Me.btnCleanTrip.Size = New System.Drawing.Size(115, 42)
        Me.btnCleanTrip.TabIndex = 24
        Me.btnCleanTrip.Text = "Clean"
        Me.btnCleanTrip.UseVisualStyleBackColor = True
        '
        'btnDeleteTrip
        '
        Me.btnDeleteTrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteTrip.ImageIndex = 8
        Me.btnDeleteTrip.ImageList = Me.iconList
        Me.btnDeleteTrip.Location = New System.Drawing.Point(202, 88)
        Me.btnDeleteTrip.Name = "btnDeleteTrip"
        Me.btnDeleteTrip.Size = New System.Drawing.Size(115, 42)
        Me.btnDeleteTrip.TabIndex = 25
        Me.btnDeleteTrip.Text = "Delete"
        Me.btnDeleteTrip.UseVisualStyleBackColor = True
        '
        'btnUpdateTrip
        '
        Me.btnUpdateTrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateTrip.ImageIndex = 9
        Me.btnUpdateTrip.ImageList = Me.iconList
        Me.btnUpdateTrip.Location = New System.Drawing.Point(202, 31)
        Me.btnUpdateTrip.Name = "btnUpdateTrip"
        Me.btnUpdateTrip.Size = New System.Drawing.Size(115, 42)
        Me.btnUpdateTrip.TabIndex = 26
        Me.btnUpdateTrip.Text = "Update"
        Me.btnUpdateTrip.UseVisualStyleBackColor = True
        '
        'gbSelectionTrip
        '
        Me.gbSelectionTrip.Controls.Add(Me.nudTonsTrip)
        Me.gbSelectionTrip.Controls.Add(Me.cboxProductTrip)
        Me.gbSelectionTrip.Controls.Add(Me.cboxTrainTrip)
        Me.gbSelectionTrip.Controls.Add(Me.lblTonsTrip)
        Me.gbSelectionTrip.Controls.Add(Me.lblTrainTrip)
        Me.gbSelectionTrip.Controls.Add(Me.lblProductTrip)
        Me.gbSelectionTrip.Controls.Add(Me.lblDateTrip)
        Me.gbSelectionTrip.Controls.Add(Me.dtpTrip)
        Me.gbSelectionTrip.Location = New System.Drawing.Point(356, 164)
        Me.gbSelectionTrip.Name = "gbSelectionTrip"
        Me.gbSelectionTrip.Size = New System.Drawing.Size(338, 255)
        Me.gbSelectionTrip.TabIndex = 2
        Me.gbSelectionTrip.TabStop = False
        Me.gbSelectionTrip.Text = "Trip Selection Panel"
        '
        'nudTonsTrip
        '
        Me.nudTonsTrip.Location = New System.Drawing.Point(77, 193)
        Me.nudTonsTrip.Name = "nudTonsTrip"
        Me.nudTonsTrip.Size = New System.Drawing.Size(71, 25)
        Me.nudTonsTrip.TabIndex = 7
        Me.nudTonsTrip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboxProductTrip
        '
        Me.cboxProductTrip.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxProductTrip.FormattingEnabled = True
        Me.cboxProductTrip.Location = New System.Drawing.Point(77, 138)
        Me.cboxProductTrip.Name = "cboxProductTrip"
        Me.cboxProductTrip.Size = New System.Drawing.Size(255, 25)
        Me.cboxProductTrip.TabIndex = 6
        '
        'cboxTrainTrip
        '
        Me.cboxTrainTrip.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxTrainTrip.FormattingEnabled = True
        Me.cboxTrainTrip.Location = New System.Drawing.Point(77, 79)
        Me.cboxTrainTrip.Name = "cboxTrainTrip"
        Me.cboxTrainTrip.Size = New System.Drawing.Size(255, 25)
        Me.cboxTrainTrip.TabIndex = 5
        '
        'lblTonsTrip
        '
        Me.lblTonsTrip.AutoSize = True
        Me.lblTonsTrip.Location = New System.Drawing.Point(25, 195)
        Me.lblTonsTrip.Name = "lblTonsTrip"
        Me.lblTonsTrip.Size = New System.Drawing.Size(44, 17)
        Me.lblTonsTrip.TabIndex = 4
        Me.lblTonsTrip.Text = "Tons:"
        Me.lblTonsTrip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTrainTrip
        '
        Me.lblTrainTrip.AutoSize = True
        Me.lblTrainTrip.Location = New System.Drawing.Point(21, 82)
        Me.lblTrainTrip.Name = "lblTrainTrip"
        Me.lblTrainTrip.Size = New System.Drawing.Size(46, 17)
        Me.lblTrainTrip.TabIndex = 3
        Me.lblTrainTrip.Text = "Train:"
        '
        'lblProductTrip
        '
        Me.lblProductTrip.AutoSize = True
        Me.lblProductTrip.Location = New System.Drawing.Point(6, 141)
        Me.lblProductTrip.Name = "lblProductTrip"
        Me.lblProductTrip.Size = New System.Drawing.Size(64, 17)
        Me.lblProductTrip.TabIndex = 2
        Me.lblProductTrip.Text = "Product:"
        '
        'lblDateTrip
        '
        Me.lblDateTrip.AutoSize = True
        Me.lblDateTrip.Location = New System.Drawing.Point(24, 30)
        Me.lblDateTrip.Name = "lblDateTrip"
        Me.lblDateTrip.Size = New System.Drawing.Size(43, 17)
        Me.lblDateTrip.TabIndex = 1
        Me.lblDateTrip.Text = "Date:"
        '
        'dtpTrip
        '
        Me.dtpTrip.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTrip.Location = New System.Drawing.Point(77, 24)
        Me.dtpTrip.Name = "dtpTrip"
        Me.dtpTrip.Size = New System.Drawing.Size(255, 25)
        Me.dtpTrip.TabIndex = 0
        '
        'gbTripList
        '
        Me.gbTripList.Controls.Add(Me.lstViewTrip)
        Me.gbTripList.Location = New System.Drawing.Point(6, 6)
        Me.gbTripList.Name = "gbTripList"
        Me.gbTripList.Size = New System.Drawing.Size(344, 413)
        Me.gbTripList.TabIndex = 0
        Me.gbTripList.TabStop = False
        Me.gbTripList.Text = "Trips List"
        '
        'lstViewTrip
        '
        Me.lstViewTrip.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.dateTrip, Me.trainTrip, Me.productTrip, Me.tonsTrip})
        Me.lstViewTrip.FullRowSelect = True
        Me.lstViewTrip.HideSelection = False
        Me.lstViewTrip.Location = New System.Drawing.Point(9, 15)
        Me.lstViewTrip.MultiSelect = False
        Me.lstViewTrip.Name = "lstViewTrip"
        Me.lstViewTrip.Size = New System.Drawing.Size(329, 383)
        Me.lstViewTrip.TabIndex = 1
        Me.lstViewTrip.UseCompatibleStateImageBehavior = False
        Me.lstViewTrip.View = System.Windows.Forms.View.Details
        '
        'dateTrip
        '
        Me.dateTrip.Text = "Date"
        Me.dateTrip.Width = 90
        '
        'trainTrip
        '
        Me.trainTrip.Text = "Train"
        Me.trainTrip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trainTrip.Width = 90
        '
        'productTrip
        '
        Me.productTrip.Text = "Product"
        Me.productTrip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.productTrip.Width = 90
        '
        'tonsTrip
        '
        Me.tonsTrip.Text = "Tons"
        Me.tonsTrip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tabQuery
        '
        Me.tabQuery.ImageIndex = 5
        Me.tabQuery.Location = New System.Drawing.Point(4, 26)
        Me.tabQuery.Name = "tabQuery"
        Me.tabQuery.Size = New System.Drawing.Size(700, 425)
        Me.tabQuery.TabIndex = 5
        Me.tabQuery.Text = "Queries"
        Me.tabQuery.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(8, 89)
        Me.txtPath.Multiline = True
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(191, 104)
        Me.txtPath.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(841, 38)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'OfdPath
        '
        Me.OfdPath.FileName = "OfdPath"
        '
        'gbDatabase
        '
        Me.gbDatabase.Controls.Add(Me.btnSelect)
        Me.gbDatabase.Controls.Add(Me.btnConnect)
        Me.gbDatabase.Controls.Add(Me.txtPath)
        Me.gbDatabase.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatabase.Location = New System.Drawing.Point(729, 265)
        Me.gbDatabase.Name = "gbDatabase"
        Me.gbDatabase.Size = New System.Drawing.Size(205, 198)
        Me.gbDatabase.TabIndex = 5
        Me.gbDatabase.TabStop = False
        Me.gbDatabase.Text = "Database"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 479)
        Me.Controls.Add(Me.gbDatabase)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.tabControl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Trains-potting"
        Me.tabControl.ResumeLayout(False)
        Me.tabProduct.ResumeLayout(False)
        Me.gbProductsList.ResumeLayout(False)
        Me.gbProductsBoxes.ResumeLayout(False)
        Me.gbProductsBoxes.PerformLayout()
        Me.gbControlProducts.ResumeLayout(False)
        Me.tabTrains.ResumeLayout(False)
        Me.gbTrainsList.ResumeLayout(False)
        Me.gbTrainsBoxes.ResumeLayout(False)
        Me.gbTrainsBoxes.PerformLayout()
        Me.gbControlTrains.ResumeLayout(False)
        Me.tabTrainTypes.ResumeLayout(False)
        Me.gbTrainTypeList.ResumeLayout(False)
        Me.gbTrainTypeBoxes.ResumeLayout(False)
        Me.gbTrainTypeBoxes.PerformLayout()
        CType(Me.nudMaxCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbControlTrainType.ResumeLayout(False)
        Me.tabPrices.ResumeLayout(False)
        Me.gbPriceList.ResumeLayout(False)
        Me.gbControlPrices.ResumeLayout(False)
        Me.gbPrices.ResumeLayout(False)
        Me.gbPrices.PerformLayout()
        Me.tabTrips.ResumeLayout(False)
        Me.gbControlTrip.ResumeLayout(False)
        Me.gbSelectionTrip.ResumeLayout(False)
        Me.gbSelectionTrip.PerformLayout()
        CType(Me.nudTonsTrip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTripList.ResumeLayout(False)
        Me.gbDatabase.ResumeLayout(False)
        Me.gbDatabase.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelect As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents tabControl As TabControl
    Friend WithEvents tabTrips As TabPage
    Friend WithEvents tabProduct As TabPage
    Friend WithEvents lblProductDescription As Label
    Friend WithEvents txtProductDescription As TextBox
    Friend WithEvents btnUpdateProduct As Button
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents btnCleanProduct As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents lblProductList As Label
    Friend WithEvents tabTrains As TabPage
    Friend WithEvents tabTrainTypes As TabPage
    Friend WithEvents tabPrices As TabPage
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents OfdPath As OpenFileDialog
    Friend WithEvents cboxTrain As ComboBox
    Friend WithEvents lblTypeTrain As Label
    Friend WithEvents lblTrainDescription As Label
    Friend WithEvents txtTrainID As TextBox
    Friend WithEvents btnUpdateTrain As Button
    Friend WithEvents btnDeleteTrain As Button
    Friend WithEvents btnCleanTrain As Button
    Friend WithEvents btnAddTrain As Button
    Friend WithEvents lblCapacity As Label
    Friend WithEvents lblTrainType As Label
    Friend WithEvents txtTrainTypeDescription As TextBox
    Friend WithEvents btnUpdateTrainType As Button
    Friend WithEvents btnDeleteTrainType As Button
    Friend WithEvents btnCleanTrainType As Button
    Friend WithEvents btnAddTrainType As Button
    Friend WithEvents lblTrainTypeList As Label
    Friend WithEvents txtEurosPrices As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpDatePrices As DateTimePicker
    Friend WithEvents cboxProductPrices As ComboBox
    Friend WithEvents lblProductPrices As Label
    Friend WithEvents btnUpdatePrices As Button
    Friend WithEvents btnDeletePrices As Button
    Friend WithEvents btnCleanPrices As Button
    Friend WithEvents btnAddPrices As Button
    Friend WithEvents lblPricesList As Label
    Friend WithEvents gbControlPrices As GroupBox
    Friend WithEvents gbPrices As GroupBox
    Friend WithEvents gbDatabase As GroupBox
    Friend WithEvents gbProductsList As GroupBox
    Friend WithEvents gbProductsBoxes As GroupBox
    Friend WithEvents gbControlProducts As GroupBox
    Friend WithEvents gbTrainsList As GroupBox
    Friend WithEvents gbTrainsBoxes As GroupBox
    Friend WithEvents gbControlTrains As GroupBox
    Friend WithEvents gbTrainTypeBoxes As GroupBox
    Friend WithEvents gbControlTrainType As GroupBox
    Friend WithEvents gbTrainTypeList As GroupBox
    Friend WithEvents nudMaxCapacity As NumericUpDown
    Friend WithEvents gbPriceList As GroupBox
    Friend WithEvents lstViewPrices As ListView
    Friend WithEvents ProductDescription As ColumnHeader
    Friend WithEvents PriceDate As ColumnHeader
    Friend WithEvents PricePerTon As ColumnHeader
    Friend WithEvents lblEuroSymbol As Label
    Friend WithEvents ProductID As ColumnHeader
    Friend WithEvents lstViewProducts As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Description As ColumnHeader
    Friend WithEvents lstViewTrains As ListView
    Friend WithEvents idTrains As ColumnHeader
    Friend WithEvents trainTypeTrains As ColumnHeader
    Friend WithEvents lstViewTrainTypes As ListView
    Friend WithEvents idTrainTypes As ColumnHeader
    Friend WithEvents descriptionTrainTypes As ColumnHeader
    Friend WithEvents capacityTrainTypes As ColumnHeader
    Friend WithEvents tabQuery As TabPage
    Friend WithEvents iconList As ImageList
    Friend WithEvents gbSelectionTrip As GroupBox
    Friend WithEvents gbTripList As GroupBox
    Friend WithEvents gbControlTrip As GroupBox
    Friend WithEvents btnAddTrip As Button
    Friend WithEvents btnCleanTrip As Button
    Friend WithEvents btnDeleteTrip As Button
    Friend WithEvents btnUpdateTrip As Button
    Friend WithEvents lblTonsTrainType As Label
    Friend WithEvents nudTonsTrip As NumericUpDown
    Friend WithEvents cboxProductTrip As ComboBox
    Friend WithEvents cboxTrainTrip As ComboBox
    Friend WithEvents lblTonsTrip As Label
    Friend WithEvents lblTrainTrip As Label
    Friend WithEvents lblProductTrip As Label
    Friend WithEvents lblDateTrip As Label
    Friend WithEvents dtpTrip As DateTimePicker
    Friend WithEvents lstViewTrip As ListView
    Friend WithEvents dateTrip As ColumnHeader
    Friend WithEvents trainTrip As ColumnHeader
    Friend WithEvents productTrip As ColumnHeader
    Friend WithEvents tonsTrip As ColumnHeader
End Class
