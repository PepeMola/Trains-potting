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
        Me.lstboxProductTrip = New System.Windows.Forms.ListBox()
        Me.nudTonsTrip = New System.Windows.Forms.NumericUpDown()
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
        Me.lstQuery1 = New System.Windows.Forms.ListBox()
        Me.lblTrainIdQuery = New System.Windows.Forms.Label()
        Me.cboxTrainIdQuery = New System.Windows.Forms.ComboBox()
        Me.lblDateEnd = New System.Windows.Forms.Label()
        Me.lblDateStartQuery = New System.Windows.Forms.Label()
        Me.dtpDateEndQuery = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateStartQuery = New System.Windows.Forms.DateTimePicker()
        Me.btnExecute = New System.Windows.Forms.Button()
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
        Me.tabQuery.SuspendLayout()
        Me.gbDatabase.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        resources.ApplyResources(Me.btnSelect, "btnSelect")
        Me.btnSelect.ImageList = Me.iconList
        Me.btnSelect.Name = "btnSelect"
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
        resources.ApplyResources(Me.btnConnect, "btnConnect")
        Me.btnConnect.ImageList = Me.iconList
        Me.btnConnect.Name = "btnConnect"
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
        resources.ApplyResources(Me.tabControl, "tabControl")
        Me.tabControl.ImageList = Me.iconList
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        '
        'tabProduct
        '
        Me.tabProduct.Controls.Add(Me.gbProductsList)
        Me.tabProduct.Controls.Add(Me.gbProductsBoxes)
        Me.tabProduct.Controls.Add(Me.gbControlProducts)
        Me.tabProduct.Controls.Add(Me.lblProductList)
        resources.ApplyResources(Me.tabProduct, "tabProduct")
        Me.tabProduct.Name = "tabProduct"
        Me.tabProduct.UseVisualStyleBackColor = True
        '
        'gbProductsList
        '
        Me.gbProductsList.Controls.Add(Me.lstViewProducts)
        resources.ApplyResources(Me.gbProductsList, "gbProductsList")
        Me.gbProductsList.Name = "gbProductsList"
        Me.gbProductsList.TabStop = False
        '
        'lstViewProducts
        '
        Me.lstViewProducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Description})
        Me.lstViewProducts.FullRowSelect = True
        Me.lstViewProducts.HideSelection = False
        resources.ApplyResources(Me.lstViewProducts, "lstViewProducts")
        Me.lstViewProducts.MultiSelect = False
        Me.lstViewProducts.Name = "lstViewProducts"
        Me.lstViewProducts.UseCompatibleStateImageBehavior = False
        Me.lstViewProducts.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        resources.ApplyResources(Me.ID, "ID")
        '
        'Description
        '
        resources.ApplyResources(Me.Description, "Description")
        '
        'gbProductsBoxes
        '
        Me.gbProductsBoxes.Controls.Add(Me.txtProductDescription)
        Me.gbProductsBoxes.Controls.Add(Me.lblProductDescription)
        resources.ApplyResources(Me.gbProductsBoxes, "gbProductsBoxes")
        Me.gbProductsBoxes.Name = "gbProductsBoxes"
        Me.gbProductsBoxes.TabStop = False
        '
        'txtProductDescription
        '
        resources.ApplyResources(Me.txtProductDescription, "txtProductDescription")
        Me.txtProductDescription.Name = "txtProductDescription"
        '
        'lblProductDescription
        '
        resources.ApplyResources(Me.lblProductDescription, "lblProductDescription")
        Me.lblProductDescription.Name = "lblProductDescription"
        '
        'gbControlProducts
        '
        Me.gbControlProducts.Controls.Add(Me.btnAddProduct)
        Me.gbControlProducts.Controls.Add(Me.btnCleanProduct)
        Me.gbControlProducts.Controls.Add(Me.btnDeleteProduct)
        Me.gbControlProducts.Controls.Add(Me.btnUpdateProduct)
        resources.ApplyResources(Me.gbControlProducts, "gbControlProducts")
        Me.gbControlProducts.Name = "gbControlProducts"
        Me.gbControlProducts.TabStop = False
        '
        'btnAddProduct
        '
        resources.ApplyResources(Me.btnAddProduct, "btnAddProduct")
        Me.btnAddProduct.ImageList = Me.iconList
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnCleanProduct
        '
        resources.ApplyResources(Me.btnCleanProduct, "btnCleanProduct")
        Me.btnCleanProduct.ImageList = Me.iconList
        Me.btnCleanProduct.Name = "btnCleanProduct"
        Me.btnCleanProduct.UseVisualStyleBackColor = True
        '
        'btnDeleteProduct
        '
        resources.ApplyResources(Me.btnDeleteProduct, "btnDeleteProduct")
        Me.btnDeleteProduct.ImageList = Me.iconList
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.UseVisualStyleBackColor = True
        '
        'btnUpdateProduct
        '
        resources.ApplyResources(Me.btnUpdateProduct, "btnUpdateProduct")
        Me.btnUpdateProduct.ImageList = Me.iconList
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.UseVisualStyleBackColor = True
        '
        'lblProductList
        '
        resources.ApplyResources(Me.lblProductList, "lblProductList")
        Me.lblProductList.Name = "lblProductList"
        '
        'tabTrains
        '
        Me.tabTrains.Controls.Add(Me.gbTrainsList)
        Me.tabTrains.Controls.Add(Me.gbTrainsBoxes)
        Me.tabTrains.Controls.Add(Me.gbControlTrains)
        resources.ApplyResources(Me.tabTrains, "tabTrains")
        Me.tabTrains.Name = "tabTrains"
        Me.tabTrains.UseVisualStyleBackColor = True
        '
        'gbTrainsList
        '
        Me.gbTrainsList.Controls.Add(Me.lstViewTrains)
        resources.ApplyResources(Me.gbTrainsList, "gbTrainsList")
        Me.gbTrainsList.Name = "gbTrainsList"
        Me.gbTrainsList.TabStop = False
        '
        'lstViewTrains
        '
        Me.lstViewTrains.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idTrains, Me.trainTypeTrains})
        Me.lstViewTrains.FullRowSelect = True
        Me.lstViewTrains.HideSelection = False
        resources.ApplyResources(Me.lstViewTrains, "lstViewTrains")
        Me.lstViewTrains.MultiSelect = False
        Me.lstViewTrains.Name = "lstViewTrains"
        Me.lstViewTrains.UseCompatibleStateImageBehavior = False
        Me.lstViewTrains.View = System.Windows.Forms.View.Details
        '
        'idTrains
        '
        resources.ApplyResources(Me.idTrains, "idTrains")
        '
        'trainTypeTrains
        '
        resources.ApplyResources(Me.trainTypeTrains, "trainTypeTrains")
        '
        'gbTrainsBoxes
        '
        Me.gbTrainsBoxes.Controls.Add(Me.lblTrainDescription)
        Me.gbTrainsBoxes.Controls.Add(Me.txtTrainID)
        Me.gbTrainsBoxes.Controls.Add(Me.cboxTrain)
        Me.gbTrainsBoxes.Controls.Add(Me.lblTypeTrain)
        resources.ApplyResources(Me.gbTrainsBoxes, "gbTrainsBoxes")
        Me.gbTrainsBoxes.Name = "gbTrainsBoxes"
        Me.gbTrainsBoxes.TabStop = False
        '
        'lblTrainDescription
        '
        resources.ApplyResources(Me.lblTrainDescription, "lblTrainDescription")
        Me.lblTrainDescription.Name = "lblTrainDescription"
        '
        'txtTrainID
        '
        resources.ApplyResources(Me.txtTrainID, "txtTrainID")
        Me.txtTrainID.Name = "txtTrainID"
        '
        'cboxTrain
        '
        Me.cboxTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboxTrain, "cboxTrain")
        Me.cboxTrain.FormattingEnabled = True
        Me.cboxTrain.Name = "cboxTrain"
        '
        'lblTypeTrain
        '
        resources.ApplyResources(Me.lblTypeTrain, "lblTypeTrain")
        Me.lblTypeTrain.Name = "lblTypeTrain"
        '
        'gbControlTrains
        '
        Me.gbControlTrains.Controls.Add(Me.btnAddTrain)
        Me.gbControlTrains.Controls.Add(Me.btnUpdateTrain)
        Me.gbControlTrains.Controls.Add(Me.btnCleanTrain)
        Me.gbControlTrains.Controls.Add(Me.btnDeleteTrain)
        resources.ApplyResources(Me.gbControlTrains, "gbControlTrains")
        Me.gbControlTrains.Name = "gbControlTrains"
        Me.gbControlTrains.TabStop = False
        '
        'btnAddTrain
        '
        resources.ApplyResources(Me.btnAddTrain, "btnAddTrain")
        Me.btnAddTrain.ImageList = Me.iconList
        Me.btnAddTrain.Name = "btnAddTrain"
        Me.btnAddTrain.UseVisualStyleBackColor = True
        '
        'btnUpdateTrain
        '
        resources.ApplyResources(Me.btnUpdateTrain, "btnUpdateTrain")
        Me.btnUpdateTrain.ImageList = Me.iconList
        Me.btnUpdateTrain.Name = "btnUpdateTrain"
        Me.btnUpdateTrain.UseVisualStyleBackColor = True
        '
        'btnCleanTrain
        '
        resources.ApplyResources(Me.btnCleanTrain, "btnCleanTrain")
        Me.btnCleanTrain.ImageList = Me.iconList
        Me.btnCleanTrain.Name = "btnCleanTrain"
        Me.btnCleanTrain.UseVisualStyleBackColor = True
        '
        'btnDeleteTrain
        '
        resources.ApplyResources(Me.btnDeleteTrain, "btnDeleteTrain")
        Me.btnDeleteTrain.ImageList = Me.iconList
        Me.btnDeleteTrain.Name = "btnDeleteTrain"
        Me.btnDeleteTrain.UseVisualStyleBackColor = True
        '
        'tabTrainTypes
        '
        Me.tabTrainTypes.Controls.Add(Me.gbTrainTypeList)
        Me.tabTrainTypes.Controls.Add(Me.gbTrainTypeBoxes)
        Me.tabTrainTypes.Controls.Add(Me.gbControlTrainType)
        Me.tabTrainTypes.Controls.Add(Me.lblTrainTypeList)
        resources.ApplyResources(Me.tabTrainTypes, "tabTrainTypes")
        Me.tabTrainTypes.Name = "tabTrainTypes"
        Me.tabTrainTypes.UseVisualStyleBackColor = True
        '
        'gbTrainTypeList
        '
        Me.gbTrainTypeList.Controls.Add(Me.lstViewTrainTypes)
        resources.ApplyResources(Me.gbTrainTypeList, "gbTrainTypeList")
        Me.gbTrainTypeList.Name = "gbTrainTypeList"
        Me.gbTrainTypeList.TabStop = False
        '
        'lstViewTrainTypes
        '
        Me.lstViewTrainTypes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idTrainTypes, Me.descriptionTrainTypes, Me.capacityTrainTypes})
        resources.ApplyResources(Me.lstViewTrainTypes, "lstViewTrainTypes")
        Me.lstViewTrainTypes.FullRowSelect = True
        Me.lstViewTrainTypes.HideSelection = False
        Me.lstViewTrainTypes.MultiSelect = False
        Me.lstViewTrainTypes.Name = "lstViewTrainTypes"
        Me.lstViewTrainTypes.UseCompatibleStateImageBehavior = False
        Me.lstViewTrainTypes.View = System.Windows.Forms.View.Details
        '
        'idTrainTypes
        '
        resources.ApplyResources(Me.idTrainTypes, "idTrainTypes")
        '
        'descriptionTrainTypes
        '
        resources.ApplyResources(Me.descriptionTrainTypes, "descriptionTrainTypes")
        '
        'capacityTrainTypes
        '
        resources.ApplyResources(Me.capacityTrainTypes, "capacityTrainTypes")
        '
        'gbTrainTypeBoxes
        '
        Me.gbTrainTypeBoxes.Controls.Add(Me.lblTonsTrainType)
        Me.gbTrainTypeBoxes.Controls.Add(Me.nudMaxCapacity)
        Me.gbTrainTypeBoxes.Controls.Add(Me.lblTrainType)
        Me.gbTrainTypeBoxes.Controls.Add(Me.txtTrainTypeDescription)
        Me.gbTrainTypeBoxes.Controls.Add(Me.lblCapacity)
        resources.ApplyResources(Me.gbTrainTypeBoxes, "gbTrainTypeBoxes")
        Me.gbTrainTypeBoxes.Name = "gbTrainTypeBoxes"
        Me.gbTrainTypeBoxes.TabStop = False
        '
        'lblTonsTrainType
        '
        resources.ApplyResources(Me.lblTonsTrainType, "lblTonsTrainType")
        Me.lblTonsTrainType.Name = "lblTonsTrainType"
        '
        'nudMaxCapacity
        '
        resources.ApplyResources(Me.nudMaxCapacity, "nudMaxCapacity")
        Me.nudMaxCapacity.Name = "nudMaxCapacity"
        '
        'lblTrainType
        '
        resources.ApplyResources(Me.lblTrainType, "lblTrainType")
        Me.lblTrainType.Name = "lblTrainType"
        '
        'txtTrainTypeDescription
        '
        resources.ApplyResources(Me.txtTrainTypeDescription, "txtTrainTypeDescription")
        Me.txtTrainTypeDescription.Name = "txtTrainTypeDescription"
        '
        'lblCapacity
        '
        resources.ApplyResources(Me.lblCapacity, "lblCapacity")
        Me.lblCapacity.Name = "lblCapacity"
        '
        'gbControlTrainType
        '
        Me.gbControlTrainType.Controls.Add(Me.btnAddTrainType)
        Me.gbControlTrainType.Controls.Add(Me.btnCleanTrainType)
        Me.gbControlTrainType.Controls.Add(Me.btnUpdateTrainType)
        Me.gbControlTrainType.Controls.Add(Me.btnDeleteTrainType)
        resources.ApplyResources(Me.gbControlTrainType, "gbControlTrainType")
        Me.gbControlTrainType.Name = "gbControlTrainType"
        Me.gbControlTrainType.TabStop = False
        '
        'btnAddTrainType
        '
        resources.ApplyResources(Me.btnAddTrainType, "btnAddTrainType")
        Me.btnAddTrainType.ImageList = Me.iconList
        Me.btnAddTrainType.Name = "btnAddTrainType"
        Me.btnAddTrainType.UseVisualStyleBackColor = True
        '
        'btnCleanTrainType
        '
        resources.ApplyResources(Me.btnCleanTrainType, "btnCleanTrainType")
        Me.btnCleanTrainType.ImageList = Me.iconList
        Me.btnCleanTrainType.Name = "btnCleanTrainType"
        Me.btnCleanTrainType.UseVisualStyleBackColor = True
        '
        'btnUpdateTrainType
        '
        resources.ApplyResources(Me.btnUpdateTrainType, "btnUpdateTrainType")
        Me.btnUpdateTrainType.ImageList = Me.iconList
        Me.btnUpdateTrainType.Name = "btnUpdateTrainType"
        Me.btnUpdateTrainType.UseVisualStyleBackColor = True
        '
        'btnDeleteTrainType
        '
        resources.ApplyResources(Me.btnDeleteTrainType, "btnDeleteTrainType")
        Me.btnDeleteTrainType.ImageList = Me.iconList
        Me.btnDeleteTrainType.Name = "btnDeleteTrainType"
        Me.btnDeleteTrainType.UseVisualStyleBackColor = True
        '
        'lblTrainTypeList
        '
        resources.ApplyResources(Me.lblTrainTypeList, "lblTrainTypeList")
        Me.lblTrainTypeList.Name = "lblTrainTypeList"
        '
        'tabPrices
        '
        Me.tabPrices.Controls.Add(Me.gbPriceList)
        Me.tabPrices.Controls.Add(Me.gbControlPrices)
        Me.tabPrices.Controls.Add(Me.gbPrices)
        Me.tabPrices.Controls.Add(Me.lblPricesList)
        resources.ApplyResources(Me.tabPrices, "tabPrices")
        Me.tabPrices.Name = "tabPrices"
        Me.tabPrices.UseVisualStyleBackColor = True
        '
        'gbPriceList
        '
        Me.gbPriceList.Controls.Add(Me.lstViewPrices)
        resources.ApplyResources(Me.gbPriceList, "gbPriceList")
        Me.gbPriceList.Name = "gbPriceList"
        Me.gbPriceList.TabStop = False
        '
        'lstViewPrices
        '
        Me.lstViewPrices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductID, Me.ProductDescription, Me.PriceDate, Me.PricePerTon})
        Me.lstViewPrices.FullRowSelect = True
        Me.lstViewPrices.HideSelection = False
        resources.ApplyResources(Me.lstViewPrices, "lstViewPrices")
        Me.lstViewPrices.MultiSelect = False
        Me.lstViewPrices.Name = "lstViewPrices"
        Me.lstViewPrices.UseCompatibleStateImageBehavior = False
        Me.lstViewPrices.View = System.Windows.Forms.View.Details
        '
        'ProductID
        '
        resources.ApplyResources(Me.ProductID, "ProductID")
        '
        'ProductDescription
        '
        resources.ApplyResources(Me.ProductDescription, "ProductDescription")
        '
        'PriceDate
        '
        resources.ApplyResources(Me.PriceDate, "PriceDate")
        '
        'PricePerTon
        '
        resources.ApplyResources(Me.PricePerTon, "PricePerTon")
        '
        'gbControlPrices
        '
        Me.gbControlPrices.Controls.Add(Me.btnAddPrices)
        Me.gbControlPrices.Controls.Add(Me.btnCleanPrices)
        Me.gbControlPrices.Controls.Add(Me.btnDeletePrices)
        Me.gbControlPrices.Controls.Add(Me.btnUpdatePrices)
        resources.ApplyResources(Me.gbControlPrices, "gbControlPrices")
        Me.gbControlPrices.Name = "gbControlPrices"
        Me.gbControlPrices.TabStop = False
        '
        'btnAddPrices
        '
        resources.ApplyResources(Me.btnAddPrices, "btnAddPrices")
        Me.btnAddPrices.ImageList = Me.iconList
        Me.btnAddPrices.Name = "btnAddPrices"
        Me.btnAddPrices.UseVisualStyleBackColor = True
        '
        'btnCleanPrices
        '
        resources.ApplyResources(Me.btnCleanPrices, "btnCleanPrices")
        Me.btnCleanPrices.ImageList = Me.iconList
        Me.btnCleanPrices.Name = "btnCleanPrices"
        Me.btnCleanPrices.UseVisualStyleBackColor = True
        '
        'btnDeletePrices
        '
        resources.ApplyResources(Me.btnDeletePrices, "btnDeletePrices")
        Me.btnDeletePrices.ImageList = Me.iconList
        Me.btnDeletePrices.Name = "btnDeletePrices"
        Me.btnDeletePrices.UseVisualStyleBackColor = True
        '
        'btnUpdatePrices
        '
        resources.ApplyResources(Me.btnUpdatePrices, "btnUpdatePrices")
        Me.btnUpdatePrices.ImageList = Me.iconList
        Me.btnUpdatePrices.Name = "btnUpdatePrices"
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
        resources.ApplyResources(Me.gbPrices, "gbPrices")
        Me.gbPrices.Name = "gbPrices"
        Me.gbPrices.TabStop = False
        '
        'lblEuroSymbol
        '
        resources.ApplyResources(Me.lblEuroSymbol, "lblEuroSymbol")
        Me.lblEuroSymbol.Name = "lblEuroSymbol"
        '
        'txtEurosPrices
        '
        resources.ApplyResources(Me.txtEurosPrices, "txtEurosPrices")
        Me.txtEurosPrices.Name = "txtEurosPrices"
        '
        'lblProductPrices
        '
        resources.ApplyResources(Me.lblProductPrices, "lblProductPrices")
        Me.lblProductPrices.Name = "lblProductPrices"
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        '
        'lblPrice
        '
        resources.ApplyResources(Me.lblPrice, "lblPrice")
        Me.lblPrice.Name = "lblPrice"
        '
        'dtpDatePrices
        '
        resources.ApplyResources(Me.dtpDatePrices, "dtpDatePrices")
        Me.dtpDatePrices.Name = "dtpDatePrices"
        '
        'cboxProductPrices
        '
        Me.cboxProductPrices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboxProductPrices, "cboxProductPrices")
        Me.cboxProductPrices.FormattingEnabled = True
        Me.cboxProductPrices.Name = "cboxProductPrices"
        '
        'lblPricesList
        '
        resources.ApplyResources(Me.lblPricesList, "lblPricesList")
        Me.lblPricesList.Name = "lblPricesList"
        '
        'tabTrips
        '
        Me.tabTrips.Controls.Add(Me.gbControlTrip)
        Me.tabTrips.Controls.Add(Me.gbSelectionTrip)
        Me.tabTrips.Controls.Add(Me.gbTripList)
        resources.ApplyResources(Me.tabTrips, "tabTrips")
        Me.tabTrips.Name = "tabTrips"
        Me.tabTrips.UseVisualStyleBackColor = True
        '
        'gbControlTrip
        '
        Me.gbControlTrip.Controls.Add(Me.btnAddTrip)
        Me.gbControlTrip.Controls.Add(Me.btnCleanTrip)
        Me.gbControlTrip.Controls.Add(Me.btnDeleteTrip)
        Me.gbControlTrip.Controls.Add(Me.btnUpdateTrip)
        resources.ApplyResources(Me.gbControlTrip, "gbControlTrip")
        Me.gbControlTrip.Name = "gbControlTrip"
        Me.gbControlTrip.TabStop = False
        '
        'btnAddTrip
        '
        resources.ApplyResources(Me.btnAddTrip, "btnAddTrip")
        Me.btnAddTrip.ImageList = Me.iconList
        Me.btnAddTrip.Name = "btnAddTrip"
        Me.btnAddTrip.UseVisualStyleBackColor = True
        '
        'btnCleanTrip
        '
        resources.ApplyResources(Me.btnCleanTrip, "btnCleanTrip")
        Me.btnCleanTrip.ImageList = Me.iconList
        Me.btnCleanTrip.Name = "btnCleanTrip"
        Me.btnCleanTrip.UseVisualStyleBackColor = True
        '
        'btnDeleteTrip
        '
        resources.ApplyResources(Me.btnDeleteTrip, "btnDeleteTrip")
        Me.btnDeleteTrip.ImageList = Me.iconList
        Me.btnDeleteTrip.Name = "btnDeleteTrip"
        Me.btnDeleteTrip.UseVisualStyleBackColor = True
        '
        'btnUpdateTrip
        '
        resources.ApplyResources(Me.btnUpdateTrip, "btnUpdateTrip")
        Me.btnUpdateTrip.ImageList = Me.iconList
        Me.btnUpdateTrip.Name = "btnUpdateTrip"
        Me.btnUpdateTrip.UseVisualStyleBackColor = True
        '
        'gbSelectionTrip
        '
        Me.gbSelectionTrip.Controls.Add(Me.lstboxProductTrip)
        Me.gbSelectionTrip.Controls.Add(Me.nudTonsTrip)
        Me.gbSelectionTrip.Controls.Add(Me.cboxTrainTrip)
        Me.gbSelectionTrip.Controls.Add(Me.lblTonsTrip)
        Me.gbSelectionTrip.Controls.Add(Me.lblTrainTrip)
        Me.gbSelectionTrip.Controls.Add(Me.lblProductTrip)
        Me.gbSelectionTrip.Controls.Add(Me.lblDateTrip)
        Me.gbSelectionTrip.Controls.Add(Me.dtpTrip)
        resources.ApplyResources(Me.gbSelectionTrip, "gbSelectionTrip")
        Me.gbSelectionTrip.Name = "gbSelectionTrip"
        Me.gbSelectionTrip.TabStop = False
        '
        'lstboxProductTrip
        '
        Me.lstboxProductTrip.FormattingEnabled = True
        resources.ApplyResources(Me.lstboxProductTrip, "lstboxProductTrip")
        Me.lstboxProductTrip.MultiColumn = True
        Me.lstboxProductTrip.Name = "lstboxProductTrip"
        Me.lstboxProductTrip.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        '
        'nudTonsTrip
        '
        resources.ApplyResources(Me.nudTonsTrip, "nudTonsTrip")
        Me.nudTonsTrip.Name = "nudTonsTrip"
        '
        'cboxTrainTrip
        '
        Me.cboxTrainTrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboxTrainTrip, "cboxTrainTrip")
        Me.cboxTrainTrip.FormattingEnabled = True
        Me.cboxTrainTrip.Name = "cboxTrainTrip"
        '
        'lblTonsTrip
        '
        resources.ApplyResources(Me.lblTonsTrip, "lblTonsTrip")
        Me.lblTonsTrip.Name = "lblTonsTrip"
        '
        'lblTrainTrip
        '
        resources.ApplyResources(Me.lblTrainTrip, "lblTrainTrip")
        Me.lblTrainTrip.Name = "lblTrainTrip"
        '
        'lblProductTrip
        '
        resources.ApplyResources(Me.lblProductTrip, "lblProductTrip")
        Me.lblProductTrip.Name = "lblProductTrip"
        '
        'lblDateTrip
        '
        resources.ApplyResources(Me.lblDateTrip, "lblDateTrip")
        Me.lblDateTrip.Name = "lblDateTrip"
        '
        'dtpTrip
        '
        resources.ApplyResources(Me.dtpTrip, "dtpTrip")
        Me.dtpTrip.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTrip.Name = "dtpTrip"
        '
        'gbTripList
        '
        Me.gbTripList.Controls.Add(Me.lstViewTrip)
        resources.ApplyResources(Me.gbTripList, "gbTripList")
        Me.gbTripList.Name = "gbTripList"
        Me.gbTripList.TabStop = False
        '
        'lstViewTrip
        '
        Me.lstViewTrip.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.dateTrip, Me.trainTrip, Me.productTrip, Me.tonsTrip})
        Me.lstViewTrip.FullRowSelect = True
        Me.lstViewTrip.HideSelection = False
        resources.ApplyResources(Me.lstViewTrip, "lstViewTrip")
        Me.lstViewTrip.MultiSelect = False
        Me.lstViewTrip.Name = "lstViewTrip"
        Me.lstViewTrip.UseCompatibleStateImageBehavior = False
        Me.lstViewTrip.View = System.Windows.Forms.View.Details
        '
        'dateTrip
        '
        resources.ApplyResources(Me.dateTrip, "dateTrip")
        '
        'trainTrip
        '
        resources.ApplyResources(Me.trainTrip, "trainTrip")
        '
        'productTrip
        '
        resources.ApplyResources(Me.productTrip, "productTrip")
        '
        'tonsTrip
        '
        resources.ApplyResources(Me.tonsTrip, "tonsTrip")
        '
        'tabQuery
        '
        Me.tabQuery.Controls.Add(Me.lstQuery1)
        Me.tabQuery.Controls.Add(Me.lblTrainIdQuery)
        Me.tabQuery.Controls.Add(Me.cboxTrainIdQuery)
        Me.tabQuery.Controls.Add(Me.lblDateEnd)
        Me.tabQuery.Controls.Add(Me.lblDateStartQuery)
        Me.tabQuery.Controls.Add(Me.dtpDateEndQuery)
        Me.tabQuery.Controls.Add(Me.dtpDateStartQuery)
        Me.tabQuery.Controls.Add(Me.btnExecute)
        resources.ApplyResources(Me.tabQuery, "tabQuery")
        Me.tabQuery.Name = "tabQuery"
        Me.tabQuery.UseVisualStyleBackColor = True
        '
        'lstQuery1
        '
        Me.lstQuery1.FormattingEnabled = True
        resources.ApplyResources(Me.lstQuery1, "lstQuery1")
        Me.lstQuery1.Name = "lstQuery1"
        '
        'lblTrainIdQuery
        '
        resources.ApplyResources(Me.lblTrainIdQuery, "lblTrainIdQuery")
        Me.lblTrainIdQuery.Name = "lblTrainIdQuery"
        '
        'cboxTrainIdQuery
        '
        Me.cboxTrainIdQuery.FormattingEnabled = True
        resources.ApplyResources(Me.cboxTrainIdQuery, "cboxTrainIdQuery")
        Me.cboxTrainIdQuery.Name = "cboxTrainIdQuery"
        '
        'lblDateEnd
        '
        resources.ApplyResources(Me.lblDateEnd, "lblDateEnd")
        Me.lblDateEnd.Name = "lblDateEnd"
        '
        'lblDateStartQuery
        '
        resources.ApplyResources(Me.lblDateStartQuery, "lblDateStartQuery")
        Me.lblDateStartQuery.Name = "lblDateStartQuery"
        '
        'dtpDateEndQuery
        '
        resources.ApplyResources(Me.dtpDateEndQuery, "dtpDateEndQuery")
        Me.dtpDateEndQuery.Name = "dtpDateEndQuery"
        '
        'dtpDateStartQuery
        '
        resources.ApplyResources(Me.dtpDateStartQuery, "dtpDateStartQuery")
        Me.dtpDateStartQuery.Name = "dtpDateStartQuery"
        '
        'btnExecute
        '
        resources.ApplyResources(Me.btnExecute, "btnExecute")
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        resources.ApplyResources(Me.txtPath, "txtPath")
        Me.txtPath.Name = "txtPath"
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Name = "btnExit"
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
        resources.ApplyResources(Me.gbDatabase, "gbDatabase")
        Me.gbDatabase.Name = "gbDatabase"
        Me.gbDatabase.TabStop = False
        '
        'Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbDatabase)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.tabControl)
        Me.Name = "Main"
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
        Me.tabQuery.ResumeLayout(False)
        Me.tabQuery.PerformLayout()
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
    Friend WithEvents lstboxProductTrip As ListBox
    Friend WithEvents btnExecute As Button
    Friend WithEvents lblTrainIdQuery As Label
    Friend WithEvents cboxTrainIdQuery As ComboBox
    Friend WithEvents lblDateEnd As Label
    Friend WithEvents lblDateStartQuery As Label
    Friend WithEvents dtpDateEndQuery As DateTimePicker
    Friend WithEvents dtpDateStartQuery As DateTimePicker
    Friend WithEvents lstQuery1 As ListBox
End Class
