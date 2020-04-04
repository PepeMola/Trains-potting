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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabMain = New System.Windows.Forms.TabPage()
        Me.tabProduct = New System.Windows.Forms.TabPage()
        Me.gbProductsList = New System.Windows.Forms.GroupBox()
        Me.lstProduct = New System.Windows.Forms.ListBox()
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
        Me.lstTrain = New System.Windows.Forms.ListBox()
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
        Me.lstTrainType = New System.Windows.Forms.ListBox()
        Me.gbTrainTypeBoxes = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
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
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbControlTrainType.SuspendLayout()
        Me.tabPrices.SuspendLayout()
        Me.gbPriceList.SuspendLayout()
        Me.gbControlPrices.SuspendLayout()
        Me.gbPrices.SuspendLayout()
        Me.gbDatabase.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(5, 19)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(87, 23)
        Me.btnSelect.TabIndex = 0
        Me.btnSelect.Text = "Select DB"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(111, 19)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(87, 23)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Connect DB"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabMain)
        Me.tabControl.Controls.Add(Me.tabProduct)
        Me.tabControl.Controls.Add(Me.tabTrains)
        Me.tabControl.Controls.Add(Me.tabTrainTypes)
        Me.tabControl.Controls.Add(Me.tabPrices)
        Me.tabControl.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl.Location = New System.Drawing.Point(15, 12)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(708, 447)
        Me.tabControl.TabIndex = 2
        '
        'tabMain
        '
        Me.tabMain.Location = New System.Drawing.Point(4, 30)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMain.Size = New System.Drawing.Size(700, 413)
        Me.tabMain.TabIndex = 0
        Me.tabMain.Text = "Main"
        Me.tabMain.UseVisualStyleBackColor = True
        '
        'tabProduct
        '
        Me.tabProduct.Controls.Add(Me.gbProductsList)
        Me.tabProduct.Controls.Add(Me.gbProductsBoxes)
        Me.tabProduct.Controls.Add(Me.gbControlProducts)
        Me.tabProduct.Controls.Add(Me.lblProductList)
        Me.tabProduct.Location = New System.Drawing.Point(4, 30)
        Me.tabProduct.Name = "tabProduct"
        Me.tabProduct.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProduct.Size = New System.Drawing.Size(700, 413)
        Me.tabProduct.TabIndex = 1
        Me.tabProduct.Text = "Products"
        Me.tabProduct.UseVisualStyleBackColor = True
        '
        'gbProductsList
        '
        Me.gbProductsList.Controls.Add(Me.lstProduct)
        Me.gbProductsList.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProductsList.Location = New System.Drawing.Point(10, 6)
        Me.gbProductsList.Name = "gbProductsList"
        Me.gbProductsList.Size = New System.Drawing.Size(322, 409)
        Me.gbProductsList.TabIndex = 21
        Me.gbProductsList.TabStop = False
        Me.gbProductsList.Text = "Products List"
        '
        'lstProduct
        '
        Me.lstProduct.FormattingEnabled = True
        Me.lstProduct.ItemHeight = 21
        Me.lstProduct.Location = New System.Drawing.Point(7, 19)
        Me.lstProduct.Name = "lstProduct"
        Me.lstProduct.Size = New System.Drawing.Size(307, 361)
        Me.lstProduct.TabIndex = 0
        '
        'gbProductsBoxes
        '
        Me.gbProductsBoxes.Controls.Add(Me.txtProductDescription)
        Me.gbProductsBoxes.Controls.Add(Me.lblProductDescription)
        Me.gbProductsBoxes.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProductsBoxes.Location = New System.Drawing.Point(339, 164)
        Me.gbProductsBoxes.Name = "gbProductsBoxes"
        Me.gbProductsBoxes.Size = New System.Drawing.Size(339, 251)
        Me.gbProductsBoxes.TabIndex = 20
        Me.gbProductsBoxes.TabStop = False
        Me.gbProductsBoxes.Text = "Selection Product Panel"
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Location = New System.Drawing.Point(10, 42)
        Me.txtProductDescription.Multiline = True
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.Size = New System.Drawing.Size(312, 200)
        Me.txtProductDescription.TabIndex = 6
        '
        'lblProductDescription
        '
        Me.lblProductDescription.AutoSize = True
        Me.lblProductDescription.Location = New System.Drawing.Point(7, 21)
        Me.lblProductDescription.Name = "lblProductDescription"
        Me.lblProductDescription.Size = New System.Drawing.Size(180, 23)
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
        Me.btnAddProduct.Location = New System.Drawing.Point(28, 31)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(115, 42)
        Me.btnAddProduct.TabIndex = 2
        Me.btnAddProduct.Text = "Add"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnCleanProduct
        '
        Me.btnCleanProduct.Location = New System.Drawing.Point(28, 88)
        Me.btnCleanProduct.Name = "btnCleanProduct"
        Me.btnCleanProduct.Size = New System.Drawing.Size(115, 42)
        Me.btnCleanProduct.TabIndex = 3
        Me.btnCleanProduct.Text = "Clean"
        Me.btnCleanProduct.UseVisualStyleBackColor = True
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.Location = New System.Drawing.Point(202, 88)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Size = New System.Drawing.Size(115, 42)
        Me.btnDeleteProduct.TabIndex = 4
        Me.btnDeleteProduct.Text = "Delete"
        Me.btnDeleteProduct.UseVisualStyleBackColor = True
        '
        'btnUpdateProduct
        '
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
        Me.tabTrains.Location = New System.Drawing.Point(4, 30)
        Me.tabTrains.Name = "tabTrains"
        Me.tabTrains.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTrains.Size = New System.Drawing.Size(700, 413)
        Me.tabTrains.TabIndex = 2
        Me.tabTrains.Text = "Trains"
        Me.tabTrains.UseVisualStyleBackColor = True
        '
        'gbTrainsList
        '
        Me.gbTrainsList.Controls.Add(Me.lstTrain)
        Me.gbTrainsList.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTrainsList.Location = New System.Drawing.Point(10, 6)
        Me.gbTrainsList.Name = "gbTrainsList"
        Me.gbTrainsList.Size = New System.Drawing.Size(322, 409)
        Me.gbTrainsList.TabIndex = 20
        Me.gbTrainsList.TabStop = False
        Me.gbTrainsList.Text = "Trains List"
        '
        'lstTrain
        '
        Me.lstTrain.FormattingEnabled = True
        Me.lstTrain.ItemHeight = 21
        Me.lstTrain.Location = New System.Drawing.Point(7, 20)
        Me.lstTrain.Name = "lstTrain"
        Me.lstTrain.Size = New System.Drawing.Size(307, 361)
        Me.lstTrain.TabIndex = 8
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
        Me.lblTrainDescription.Location = New System.Drawing.Point(1, 45)
        Me.lblTrainDescription.Name = "lblTrainDescription"
        Me.lblTrainDescription.Size = New System.Drawing.Size(78, 23)
        Me.lblTrainDescription.TabIndex = 15
        Me.lblTrainDescription.Text = "Train ID"
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
        Me.cboxTrain.FormattingEnabled = True
        Me.cboxTrain.Location = New System.Drawing.Point(82, 109)
        Me.cboxTrain.Name = "cboxTrain"
        Me.cboxTrain.Size = New System.Drawing.Size(245, 29)
        Me.cboxTrain.TabIndex = 17
        '
        'lblTypeTrain
        '
        Me.lblTypeTrain.AutoSize = True
        Me.lblTypeTrain.Location = New System.Drawing.Point(23, 112)
        Me.lblTypeTrain.Name = "lblTypeTrain"
        Me.lblTypeTrain.Size = New System.Drawing.Size(50, 23)
        Me.lblTypeTrain.TabIndex = 16
        Me.lblTypeTrain.Text = "Type"
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
        Me.btnAddTrain.Location = New System.Drawing.Point(28, 31)
        Me.btnAddTrain.Name = "btnAddTrain"
        Me.btnAddTrain.Size = New System.Drawing.Size(115, 42)
        Me.btnAddTrain.TabIndex = 10
        Me.btnAddTrain.Text = "Add"
        Me.btnAddTrain.UseVisualStyleBackColor = True
        '
        'btnUpdateTrain
        '
        Me.btnUpdateTrain.Location = New System.Drawing.Point(202, 31)
        Me.btnUpdateTrain.Name = "btnUpdateTrain"
        Me.btnUpdateTrain.Size = New System.Drawing.Size(115, 42)
        Me.btnUpdateTrain.TabIndex = 13
        Me.btnUpdateTrain.Text = "Update"
        Me.btnUpdateTrain.UseVisualStyleBackColor = True
        '
        'btnCleanTrain
        '
        Me.btnCleanTrain.Location = New System.Drawing.Point(28, 88)
        Me.btnCleanTrain.Name = "btnCleanTrain"
        Me.btnCleanTrain.Size = New System.Drawing.Size(115, 42)
        Me.btnCleanTrain.TabIndex = 11
        Me.btnCleanTrain.Text = "Clean"
        Me.btnCleanTrain.UseVisualStyleBackColor = True
        '
        'btnDeleteTrain
        '
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
        Me.tabTrainTypes.Location = New System.Drawing.Point(4, 30)
        Me.tabTrainTypes.Name = "tabTrainTypes"
        Me.tabTrainTypes.Size = New System.Drawing.Size(700, 413)
        Me.tabTrainTypes.TabIndex = 3
        Me.tabTrainTypes.Text = "Train Types"
        Me.tabTrainTypes.UseVisualStyleBackColor = True
        '
        'gbTrainTypeList
        '
        Me.gbTrainTypeList.Controls.Add(Me.lstTrainType)
        Me.gbTrainTypeList.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTrainTypeList.Location = New System.Drawing.Point(10, 6)
        Me.gbTrainTypeList.Name = "gbTrainTypeList"
        Me.gbTrainTypeList.Size = New System.Drawing.Size(322, 409)
        Me.gbTrainTypeList.TabIndex = 21
        Me.gbTrainTypeList.TabStop = False
        Me.gbTrainTypeList.Text = "Train Types List"
        '
        'lstTrainType
        '
        Me.lstTrainType.FormattingEnabled = True
        Me.lstTrainType.ItemHeight = 21
        Me.lstTrainType.Location = New System.Drawing.Point(7, 19)
        Me.lstTrainType.Name = "lstTrainType"
        Me.lstTrainType.Size = New System.Drawing.Size(307, 361)
        Me.lstTrainType.TabIndex = 8
        '
        'gbTrainTypeBoxes
        '
        Me.gbTrainTypeBoxes.Controls.Add(Me.NumericUpDown1)
        Me.gbTrainTypeBoxes.Controls.Add(Me.lblTrainType)
        Me.gbTrainTypeBoxes.Controls.Add(Me.txtTrainTypeDescription)
        Me.gbTrainTypeBoxes.Controls.Add(Me.lblCapacity)
        Me.gbTrainTypeBoxes.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTrainTypeBoxes.Location = New System.Drawing.Point(339, 178)
        Me.gbTrainTypeBoxes.Name = "gbTrainTypeBoxes"
        Me.gbTrainTypeBoxes.Size = New System.Drawing.Size(338, 238)
        Me.gbTrainTypeBoxes.TabIndex = 20
        Me.gbTrainTypeBoxes.TabStop = False
        Me.gbTrainTypeBoxes.Text = "Selection Train Type Panel"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(189, 160)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(71, 29)
        Me.NumericUpDown1.TabIndex = 18
        '
        'lblTrainType
        '
        Me.lblTrainType.AutoSize = True
        Me.lblTrainType.Location = New System.Drawing.Point(6, 57)
        Me.lblTrainType.Name = "lblTrainType"
        Me.lblTrainType.Size = New System.Drawing.Size(202, 23)
        Me.lblTrainType.TabIndex = 15
        Me.lblTrainType.Text = "Train Type Description"
        '
        'txtTrainTypeDescription
        '
        Me.txtTrainTypeDescription.Location = New System.Drawing.Point(6, 83)
        Me.txtTrainTypeDescription.Multiline = True
        Me.txtTrainTypeDescription.Name = "txtTrainTypeDescription"
        Me.txtTrainTypeDescription.Size = New System.Drawing.Size(324, 51)
        Me.txtTrainTypeDescription.TabIndex = 14
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(6, 160)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(177, 23)
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
        Me.gbControlTrainType.Size = New System.Drawing.Size(338, 152)
        Me.gbControlTrainType.TabIndex = 19
        Me.gbControlTrainType.TabStop = False
        Me.gbControlTrainType.Text = "Control Panel"
        '
        'btnAddTrainType
        '
        Me.btnAddTrainType.Location = New System.Drawing.Point(28, 31)
        Me.btnAddTrainType.Name = "btnAddTrainType"
        Me.btnAddTrainType.Size = New System.Drawing.Size(115, 42)
        Me.btnAddTrainType.TabIndex = 10
        Me.btnAddTrainType.Text = "Add"
        Me.btnAddTrainType.UseVisualStyleBackColor = True
        '
        'btnCleanTrainType
        '
        Me.btnCleanTrainType.Location = New System.Drawing.Point(28, 88)
        Me.btnCleanTrainType.Name = "btnCleanTrainType"
        Me.btnCleanTrainType.Size = New System.Drawing.Size(115, 42)
        Me.btnCleanTrainType.TabIndex = 11
        Me.btnCleanTrainType.Text = "Clean"
        Me.btnCleanTrainType.UseVisualStyleBackColor = True
        '
        'btnUpdateTrainType
        '
        Me.btnUpdateTrainType.Location = New System.Drawing.Point(202, 31)
        Me.btnUpdateTrainType.Name = "btnUpdateTrainType"
        Me.btnUpdateTrainType.Size = New System.Drawing.Size(115, 42)
        Me.btnUpdateTrainType.TabIndex = 13
        Me.btnUpdateTrainType.Text = "Update"
        Me.btnUpdateTrainType.UseVisualStyleBackColor = True
        '
        'btnDeleteTrainType
        '
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
        Me.tabPrices.Location = New System.Drawing.Point(4, 30)
        Me.tabPrices.Name = "tabPrices"
        Me.tabPrices.Size = New System.Drawing.Size(700, 413)
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
        Me.ProductDescription.Width = 80
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
        Me.gbControlPrices.Size = New System.Drawing.Size(338, 152)
        Me.gbControlPrices.TabIndex = 34
        Me.gbControlPrices.TabStop = False
        Me.gbControlPrices.Text = "Control Panel"
        '
        'btnAddPrices
        '
        Me.btnAddPrices.Location = New System.Drawing.Point(28, 31)
        Me.btnAddPrices.Name = "btnAddPrices"
        Me.btnAddPrices.Size = New System.Drawing.Size(115, 42)
        Me.btnAddPrices.TabIndex = 23
        Me.btnAddPrices.Text = "Add"
        Me.btnAddPrices.UseVisualStyleBackColor = True
        '
        'btnCleanPrices
        '
        Me.btnCleanPrices.Location = New System.Drawing.Point(28, 88)
        Me.btnCleanPrices.Name = "btnCleanPrices"
        Me.btnCleanPrices.Size = New System.Drawing.Size(115, 42)
        Me.btnCleanPrices.TabIndex = 24
        Me.btnCleanPrices.Text = "Clean"
        Me.btnCleanPrices.UseVisualStyleBackColor = True
        '
        'btnDeletePrices
        '
        Me.btnDeletePrices.Location = New System.Drawing.Point(202, 88)
        Me.btnDeletePrices.Name = "btnDeletePrices"
        Me.btnDeletePrices.Size = New System.Drawing.Size(115, 42)
        Me.btnDeletePrices.TabIndex = 25
        Me.btnDeletePrices.Text = "Delete"
        Me.btnDeletePrices.UseVisualStyleBackColor = True
        '
        'btnUpdatePrices
        '
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
        Me.gbPrices.Location = New System.Drawing.Point(339, 224)
        Me.gbPrices.Name = "gbPrices"
        Me.gbPrices.Size = New System.Drawing.Size(338, 191)
        Me.gbPrices.TabIndex = 33
        Me.gbPrices.TabStop = False
        Me.gbPrices.Text = "Prices Selection"
        '
        'lblEuroSymbol
        '
        Me.lblEuroSymbol.AutoSize = True
        Me.lblEuroSymbol.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEuroSymbol.Location = New System.Drawing.Point(263, 131)
        Me.lblEuroSymbol.Name = "lblEuroSymbol"
        Me.lblEuroSymbol.Size = New System.Drawing.Size(20, 23)
        Me.lblEuroSymbol.TabIndex = 33
        Me.lblEuroSymbol.Text = "€"
        '
        'txtEurosPrices
        '
        Me.txtEurosPrices.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEurosPrices.Location = New System.Drawing.Point(94, 126)
        Me.txtEurosPrices.Name = "txtEurosPrices"
        Me.txtEurosPrices.Size = New System.Drawing.Size(163, 29)
        Me.txtEurosPrices.TabIndex = 32
        '
        'lblProductPrices
        '
        Me.lblProductPrices.AutoSize = True
        Me.lblProductPrices.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductPrices.Location = New System.Drawing.Point(19, 30)
        Me.lblProductPrices.Name = "lblProductPrices"
        Me.lblProductPrices.Size = New System.Drawing.Size(88, 23)
        Me.lblProductPrices.TabIndex = 27
        Me.lblProductPrices.Text = "Product: "
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(25, 83)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(55, 23)
        Me.lblDate.TabIndex = 30
        Me.lblDate.Text = "Date:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(25, 129)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(57, 23)
        Me.lblPrice.TabIndex = 31
        Me.lblPrice.Text = "Price:"
        '
        'dtpDatePrices
        '
        Me.dtpDatePrices.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDatePrices.Location = New System.Drawing.Point(94, 77)
        Me.dtpDatePrices.Name = "dtpDatePrices"
        Me.dtpDatePrices.Size = New System.Drawing.Size(236, 29)
        Me.dtpDatePrices.TabIndex = 29
        '
        'cboxProductPrices
        '
        Me.cboxProductPrices.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxProductPrices.FormattingEnabled = True
        Me.cboxProductPrices.Location = New System.Drawing.Point(94, 27)
        Me.cboxProductPrices.Name = "cboxProductPrices"
        Me.cboxProductPrices.Size = New System.Drawing.Size(236, 29)
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
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(7, 55)
        Me.txtPath.Multiline = True
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(191, 83)
        Me.txtPath.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(840, 283)
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
        Me.gbDatabase.Location = New System.Drawing.Point(729, 312)
        Me.gbDatabase.Name = "gbDatabase"
        Me.gbDatabase.Size = New System.Drawing.Size(205, 147)
        Me.gbDatabase.TabIndex = 5
        Me.gbDatabase.TabStop = False
        Me.gbDatabase.Text = "Database"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 460)
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
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbControlTrainType.ResumeLayout(False)
        Me.tabPrices.ResumeLayout(False)
        Me.gbPriceList.ResumeLayout(False)
        Me.gbControlPrices.ResumeLayout(False)
        Me.gbPrices.ResumeLayout(False)
        Me.gbPrices.PerformLayout()
        Me.gbDatabase.ResumeLayout(False)
        Me.gbDatabase.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelect As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents tabControl As TabControl
    Friend WithEvents tabMain As TabPage
    Friend WithEvents tabProduct As TabPage
    Friend WithEvents lblProductDescription As Label
    Friend WithEvents txtProductDescription As TextBox
    Friend WithEvents btnUpdateProduct As Button
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents btnCleanProduct As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents lblProductList As Label
    Friend WithEvents lstProduct As ListBox
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
    Friend WithEvents lstTrain As ListBox
    Friend WithEvents lblCapacity As Label
    Friend WithEvents lblTrainType As Label
    Friend WithEvents txtTrainTypeDescription As TextBox
    Friend WithEvents btnUpdateTrainType As Button
    Friend WithEvents btnDeleteTrainType As Button
    Friend WithEvents btnCleanTrainType As Button
    Friend WithEvents btnAddTrainType As Button
    Friend WithEvents lblTrainTypeList As Label
    Friend WithEvents lstTrainType As ListBox
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
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents gbPriceList As GroupBox
    Friend WithEvents lstViewPrices As ListView
    Friend WithEvents ProductDescription As ColumnHeader
    Friend WithEvents PriceDate As ColumnHeader
    Friend WithEvents PricePerTon As ColumnHeader
    Friend WithEvents lblEuroSymbol As Label
    Friend WithEvents ProductID As ColumnHeader
End Class
