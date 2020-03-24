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
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabMain = New System.Windows.Forms.TabPage()
        Me.tabProduct = New System.Windows.Forms.TabPage()
        Me.lblProductDescription = New System.Windows.Forms.Label()
        Me.txtProductDescription = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblProductList = New System.Windows.Forms.Label()
        Me.lstProduct = New System.Windows.Forms.ListBox()
        Me.tabTrains = New System.Windows.Forms.TabPage()
        Me.cboxTrain = New System.Windows.Forms.ComboBox()
        Me.lblTypeTrain = New System.Windows.Forms.Label()
        Me.lblTrainDescription = New System.Windows.Forms.Label()
        Me.txtTrainID = New System.Windows.Forms.TextBox()
        Me.btnUpdateTrain = New System.Windows.Forms.Button()
        Me.btnDeleteTrain = New System.Windows.Forms.Button()
        Me.btnCleanTrain = New System.Windows.Forms.Button()
        Me.btnAddTrain = New System.Windows.Forms.Button()
        Me.lblTrainList = New System.Windows.Forms.Label()
        Me.lstTrain = New System.Windows.Forms.ListBox()
        Me.tabTrainTypes = New System.Windows.Forms.TabPage()
        Me.txtCapacityTrainTypes = New System.Windows.Forms.TextBox()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.lblTrainType = New System.Windows.Forms.Label()
        Me.txtTrainTypeDescription = New System.Windows.Forms.TextBox()
        Me.btnUpdateTrainType = New System.Windows.Forms.Button()
        Me.btnDeleteTrainType = New System.Windows.Forms.Button()
        Me.btnTrainType = New System.Windows.Forms.Button()
        Me.btnAddTrainType = New System.Windows.Forms.Button()
        Me.lblTrainTypeList = New System.Windows.Forms.Label()
        Me.lstTrainType = New System.Windows.Forms.ListBox()
        Me.tabPrices = New System.Windows.Forms.TabPage()
        Me.gbBtnPrices = New System.Windows.Forms.GroupBox()
        Me.btnAddPrices = New System.Windows.Forms.Button()
        Me.gbPrices = New System.Windows.Forms.GroupBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPriceProduct = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.dtpPrices = New System.Windows.Forms.DateTimePicker()
        Me.cboxProductPrices = New System.Windows.Forms.ComboBox()
        Me.btnUpdatePrices = New System.Windows.Forms.Button()
        Me.btnDeletePrices = New System.Windows.Forms.Button()
        Me.btnCleanPrices = New System.Windows.Forms.Button()
        Me.lblPricesList = New System.Windows.Forms.Label()
        Me.lstPrices = New System.Windows.Forms.ListBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.OfdPath = New System.Windows.Forms.OpenFileDialog()
        Me.gbDatabase = New System.Windows.Forms.GroupBox()
        Me.tabControl.SuspendLayout()
        Me.tabProduct.SuspendLayout()
        Me.tabTrains.SuspendLayout()
        Me.tabTrainTypes.SuspendLayout()
        Me.tabPrices.SuspendLayout()
        Me.gbBtnPrices.SuspendLayout()
        Me.gbPrices.SuspendLayout()
        Me.gbDatabase.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(4, 19)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 0
        Me.btnSelect.Text = "Select DB"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(95, 19)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
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
        Me.tabControl.Location = New System.Drawing.Point(12, 12)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(476, 409)
        Me.tabControl.TabIndex = 2
        '
        'tabMain
        '
        Me.tabMain.Location = New System.Drawing.Point(4, 22)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMain.Size = New System.Drawing.Size(468, 383)
        Me.tabMain.TabIndex = 0
        Me.tabMain.Text = "Main"
        Me.tabMain.UseVisualStyleBackColor = True
        '
        'tabProduct
        '
        Me.tabProduct.Controls.Add(Me.lblProductDescription)
        Me.tabProduct.Controls.Add(Me.txtProductDescription)
        Me.tabProduct.Controls.Add(Me.btnUpdate)
        Me.tabProduct.Controls.Add(Me.btnDelete)
        Me.tabProduct.Controls.Add(Me.btnClean)
        Me.tabProduct.Controls.Add(Me.btnAdd)
        Me.tabProduct.Controls.Add(Me.lblProductList)
        Me.tabProduct.Controls.Add(Me.lstProduct)
        Me.tabProduct.Location = New System.Drawing.Point(4, 22)
        Me.tabProduct.Name = "tabProduct"
        Me.tabProduct.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProduct.Size = New System.Drawing.Size(468, 383)
        Me.tabProduct.TabIndex = 1
        Me.tabProduct.Text = "Products"
        Me.tabProduct.UseVisualStyleBackColor = True
        '
        'lblProductDescription
        '
        Me.lblProductDescription.AutoSize = True
        Me.lblProductDescription.Location = New System.Drawing.Point(205, 198)
        Me.lblProductDescription.Name = "lblProductDescription"
        Me.lblProductDescription.Size = New System.Drawing.Size(100, 13)
        Me.lblProductDescription.TabIndex = 7
        Me.lblProductDescription.Text = "Product Description"
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Location = New System.Drawing.Point(208, 225)
        Me.txtProductDescription.Multiline = True
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.Size = New System.Drawing.Size(176, 129)
        Me.txtProductDescription.TabIndex = 6
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(309, 92)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(309, 139)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.Location = New System.Drawing.Point(208, 139)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(75, 23)
        Me.btnClean.TabIndex = 3
        Me.btnClean.Text = "Clean"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(208, 92)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblProductList
        '
        Me.lblProductList.Location = New System.Drawing.Point(6, 24)
        Me.lblProductList.Name = "lblProductList"
        Me.lblProductList.Size = New System.Drawing.Size(131, 15)
        Me.lblProductList.TabIndex = 1
        Me.lblProductList.Text = "Product List"
        '
        'lstProduct
        '
        Me.lstProduct.FormattingEnabled = True
        Me.lstProduct.Location = New System.Drawing.Point(6, 51)
        Me.lstProduct.Name = "lstProduct"
        Me.lstProduct.Size = New System.Drawing.Size(178, 303)
        Me.lstProduct.TabIndex = 0
        '
        'tabTrains
        '
        Me.tabTrains.Controls.Add(Me.cboxTrain)
        Me.tabTrains.Controls.Add(Me.lblTypeTrain)
        Me.tabTrains.Controls.Add(Me.lblTrainDescription)
        Me.tabTrains.Controls.Add(Me.txtTrainID)
        Me.tabTrains.Controls.Add(Me.btnUpdateTrain)
        Me.tabTrains.Controls.Add(Me.btnDeleteTrain)
        Me.tabTrains.Controls.Add(Me.btnCleanTrain)
        Me.tabTrains.Controls.Add(Me.btnAddTrain)
        Me.tabTrains.Controls.Add(Me.lblTrainList)
        Me.tabTrains.Controls.Add(Me.lstTrain)
        Me.tabTrains.Location = New System.Drawing.Point(4, 22)
        Me.tabTrains.Name = "tabTrains"
        Me.tabTrains.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTrains.Size = New System.Drawing.Size(468, 383)
        Me.tabTrains.TabIndex = 2
        Me.tabTrains.Text = "Trains"
        Me.tabTrains.UseVisualStyleBackColor = True
        '
        'cboxTrain
        '
        Me.cboxTrain.FormattingEnabled = True
        Me.cboxTrain.Location = New System.Drawing.Point(272, 234)
        Me.cboxTrain.Name = "cboxTrain"
        Me.cboxTrain.Size = New System.Drawing.Size(121, 21)
        Me.cboxTrain.TabIndex = 17
        '
        'lblTypeTrain
        '
        Me.lblTypeTrain.AutoSize = True
        Me.lblTypeTrain.Location = New System.Drawing.Point(219, 237)
        Me.lblTypeTrain.Name = "lblTypeTrain"
        Me.lblTypeTrain.Size = New System.Drawing.Size(31, 13)
        Me.lblTypeTrain.TabIndex = 16
        Me.lblTypeTrain.Text = "Type"
        '
        'lblTrainDescription
        '
        Me.lblTrainDescription.AutoSize = True
        Me.lblTrainDescription.Location = New System.Drawing.Point(205, 196)
        Me.lblTrainDescription.Name = "lblTrainDescription"
        Me.lblTrainDescription.Size = New System.Drawing.Size(45, 13)
        Me.lblTrainDescription.TabIndex = 15
        Me.lblTrainDescription.Text = "Train ID"
        '
        'txtTrainID
        '
        Me.txtTrainID.Location = New System.Drawing.Point(272, 193)
        Me.txtTrainID.Multiline = True
        Me.txtTrainID.Name = "txtTrainID"
        Me.txtTrainID.Size = New System.Drawing.Size(121, 22)
        Me.txtTrainID.TabIndex = 14
        '
        'btnUpdateTrain
        '
        Me.btnUpdateTrain.Location = New System.Drawing.Point(309, 92)
        Me.btnUpdateTrain.Name = "btnUpdateTrain"
        Me.btnUpdateTrain.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateTrain.TabIndex = 13
        Me.btnUpdateTrain.Text = "Update"
        Me.btnUpdateTrain.UseVisualStyleBackColor = True
        '
        'btnDeleteTrain
        '
        Me.btnDeleteTrain.Location = New System.Drawing.Point(309, 139)
        Me.btnDeleteTrain.Name = "btnDeleteTrain"
        Me.btnDeleteTrain.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteTrain.TabIndex = 12
        Me.btnDeleteTrain.Text = "Delete"
        Me.btnDeleteTrain.UseVisualStyleBackColor = True
        '
        'btnCleanTrain
        '
        Me.btnCleanTrain.Location = New System.Drawing.Point(208, 139)
        Me.btnCleanTrain.Name = "btnCleanTrain"
        Me.btnCleanTrain.Size = New System.Drawing.Size(75, 23)
        Me.btnCleanTrain.TabIndex = 11
        Me.btnCleanTrain.Text = "Clean"
        Me.btnCleanTrain.UseVisualStyleBackColor = True
        '
        'btnAddTrain
        '
        Me.btnAddTrain.Location = New System.Drawing.Point(208, 92)
        Me.btnAddTrain.Name = "btnAddTrain"
        Me.btnAddTrain.Size = New System.Drawing.Size(75, 23)
        Me.btnAddTrain.TabIndex = 10
        Me.btnAddTrain.Text = "Add"
        Me.btnAddTrain.UseVisualStyleBackColor = True
        '
        'lblTrainList
        '
        Me.lblTrainList.Location = New System.Drawing.Point(6, 24)
        Me.lblTrainList.Name = "lblTrainList"
        Me.lblTrainList.Size = New System.Drawing.Size(131, 15)
        Me.lblTrainList.TabIndex = 9
        Me.lblTrainList.Text = "Train List"
        '
        'lstTrain
        '
        Me.lstTrain.FormattingEnabled = True
        Me.lstTrain.Location = New System.Drawing.Point(6, 51)
        Me.lstTrain.Name = "lstTrain"
        Me.lstTrain.Size = New System.Drawing.Size(178, 303)
        Me.lstTrain.TabIndex = 8
        '
        'tabTrainTypes
        '
        Me.tabTrainTypes.Controls.Add(Me.txtCapacityTrainTypes)
        Me.tabTrainTypes.Controls.Add(Me.lblCapacity)
        Me.tabTrainTypes.Controls.Add(Me.lblTrainType)
        Me.tabTrainTypes.Controls.Add(Me.txtTrainTypeDescription)
        Me.tabTrainTypes.Controls.Add(Me.btnUpdateTrainType)
        Me.tabTrainTypes.Controls.Add(Me.btnDeleteTrainType)
        Me.tabTrainTypes.Controls.Add(Me.btnTrainType)
        Me.tabTrainTypes.Controls.Add(Me.btnAddTrainType)
        Me.tabTrainTypes.Controls.Add(Me.lblTrainTypeList)
        Me.tabTrainTypes.Controls.Add(Me.lstTrainType)
        Me.tabTrainTypes.Location = New System.Drawing.Point(4, 22)
        Me.tabTrainTypes.Name = "tabTrainTypes"
        Me.tabTrainTypes.Size = New System.Drawing.Size(468, 383)
        Me.tabTrainTypes.TabIndex = 3
        Me.tabTrainTypes.Text = "Train Types"
        Me.tabTrainTypes.UseVisualStyleBackColor = True
        '
        'txtCapacityTrainTypes
        '
        Me.txtCapacityTrainTypes.Location = New System.Drawing.Point(215, 290)
        Me.txtCapacityTrainTypes.Multiline = True
        Me.txtCapacityTrainTypes.Name = "txtCapacityTrainTypes"
        Me.txtCapacityTrainTypes.Size = New System.Drawing.Size(176, 53)
        Me.txtCapacityTrainTypes.TabIndex = 17
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(212, 271)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(98, 13)
        Me.lblCapacity.TabIndex = 16
        Me.lblCapacity.Text = "Maximum Capacity:"
        '
        'lblTrainType
        '
        Me.lblTrainType.AutoSize = True
        Me.lblTrainType.Location = New System.Drawing.Point(212, 189)
        Me.lblTrainType.Name = "lblTrainType"
        Me.lblTrainType.Size = New System.Drawing.Size(114, 13)
        Me.lblTrainType.TabIndex = 15
        Me.lblTrainType.Text = "Train Type Description"
        '
        'txtTrainTypeDescription
        '
        Me.txtTrainTypeDescription.Location = New System.Drawing.Point(215, 214)
        Me.txtTrainTypeDescription.Multiline = True
        Me.txtTrainTypeDescription.Name = "txtTrainTypeDescription"
        Me.txtTrainTypeDescription.Size = New System.Drawing.Size(176, 51)
        Me.txtTrainTypeDescription.TabIndex = 14
        '
        'btnUpdateTrainType
        '
        Me.btnUpdateTrainType.Location = New System.Drawing.Point(316, 81)
        Me.btnUpdateTrainType.Name = "btnUpdateTrainType"
        Me.btnUpdateTrainType.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateTrainType.TabIndex = 13
        Me.btnUpdateTrainType.Text = "Update"
        Me.btnUpdateTrainType.UseVisualStyleBackColor = True
        '
        'btnDeleteTrainType
        '
        Me.btnDeleteTrainType.Location = New System.Drawing.Point(316, 128)
        Me.btnDeleteTrainType.Name = "btnDeleteTrainType"
        Me.btnDeleteTrainType.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteTrainType.TabIndex = 12
        Me.btnDeleteTrainType.Text = "Delete"
        Me.btnDeleteTrainType.UseVisualStyleBackColor = True
        '
        'btnTrainType
        '
        Me.btnTrainType.Location = New System.Drawing.Point(215, 128)
        Me.btnTrainType.Name = "btnTrainType"
        Me.btnTrainType.Size = New System.Drawing.Size(75, 23)
        Me.btnTrainType.TabIndex = 11
        Me.btnTrainType.Text = "Clean"
        Me.btnTrainType.UseVisualStyleBackColor = True
        '
        'btnAddTrainType
        '
        Me.btnAddTrainType.Location = New System.Drawing.Point(215, 81)
        Me.btnAddTrainType.Name = "btnAddTrainType"
        Me.btnAddTrainType.Size = New System.Drawing.Size(75, 23)
        Me.btnAddTrainType.TabIndex = 10
        Me.btnAddTrainType.Text = "Add"
        Me.btnAddTrainType.UseVisualStyleBackColor = True
        '
        'lblTrainTypeList
        '
        Me.lblTrainTypeList.Location = New System.Drawing.Point(13, 13)
        Me.lblTrainTypeList.Name = "lblTrainTypeList"
        Me.lblTrainTypeList.Size = New System.Drawing.Size(131, 15)
        Me.lblTrainTypeList.TabIndex = 9
        Me.lblTrainTypeList.Text = "Train Type List"
        '
        'lstTrainType
        '
        Me.lstTrainType.FormattingEnabled = True
        Me.lstTrainType.Location = New System.Drawing.Point(13, 40)
        Me.lstTrainType.Name = "lstTrainType"
        Me.lstTrainType.Size = New System.Drawing.Size(178, 303)
        Me.lstTrainType.TabIndex = 8
        '
        'tabPrices
        '
        Me.tabPrices.Controls.Add(Me.gbBtnPrices)
        Me.tabPrices.Controls.Add(Me.gbPrices)
        Me.tabPrices.Controls.Add(Me.lblPricesList)
        Me.tabPrices.Controls.Add(Me.lstPrices)
        Me.tabPrices.Location = New System.Drawing.Point(4, 22)
        Me.tabPrices.Name = "tabPrices"
        Me.tabPrices.Size = New System.Drawing.Size(468, 383)
        Me.tabPrices.TabIndex = 4
        Me.tabPrices.Text = "Prices"
        Me.tabPrices.UseVisualStyleBackColor = True
        '
        'gbBtnPrices
        '
        Me.gbBtnPrices.Controls.Add(Me.btnAddPrices)
        Me.gbBtnPrices.Controls.Add(Me.btnCleanPrices)
        Me.gbBtnPrices.Controls.Add(Me.btnDeletePrices)
        Me.gbBtnPrices.Controls.Add(Me.btnUpdatePrices)
        Me.gbBtnPrices.Location = New System.Drawing.Point(202, 46)
        Me.gbBtnPrices.Name = "gbBtnPrices"
        Me.gbBtnPrices.Size = New System.Drawing.Size(253, 100)
        Me.gbBtnPrices.TabIndex = 34
        Me.gbBtnPrices.TabStop = False
        Me.gbBtnPrices.Text = "Controller"
        '
        'btnAddPrices
        '
        Me.btnAddPrices.Location = New System.Drawing.Point(9, 19)
        Me.btnAddPrices.Name = "btnAddPrices"
        Me.btnAddPrices.Size = New System.Drawing.Size(102, 23)
        Me.btnAddPrices.TabIndex = 23
        Me.btnAddPrices.Text = "Add"
        Me.btnAddPrices.UseVisualStyleBackColor = True
        '
        'gbPrices
        '
        Me.gbPrices.Controls.Add(Me.txtPrice)
        Me.gbPrices.Controls.Add(Me.lblPriceProduct)
        Me.gbPrices.Controls.Add(Me.lblDate)
        Me.gbPrices.Controls.Add(Me.lblPrice)
        Me.gbPrices.Controls.Add(Me.dtpPrices)
        Me.gbPrices.Controls.Add(Me.cboxProductPrices)
        Me.gbPrices.Location = New System.Drawing.Point(202, 152)
        Me.gbPrices.Name = "gbPrices"
        Me.gbPrices.Size = New System.Drawing.Size(253, 202)
        Me.gbPrices.TabIndex = 33
        Me.gbPrices.TabStop = False
        Me.gbPrices.Text = "Prices Selection"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(71, 147)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(168, 20)
        Me.txtPrice.TabIndex = 32
        '
        'lblPriceProduct
        '
        Me.lblPriceProduct.AutoSize = True
        Me.lblPriceProduct.Location = New System.Drawing.Point(6, 150)
        Me.lblPriceProduct.Name = "lblPriceProduct"
        Me.lblPriceProduct.Size = New System.Drawing.Size(50, 13)
        Me.lblPriceProduct.TabIndex = 27
        Me.lblPriceProduct.Text = "Product: "
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(16, 127)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 30
        Me.lblDate.Text = "Date:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(15, 22)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 31
        Me.lblPrice.Text = "Price:"
        '
        'dtpPrices
        '
        Me.dtpPrices.Location = New System.Drawing.Point(71, 121)
        Me.dtpPrices.Name = "dtpPrices"
        Me.dtpPrices.Size = New System.Drawing.Size(168, 20)
        Me.dtpPrices.TabIndex = 29
        '
        'cboxProductPrices
        '
        Me.cboxProductPrices.FormattingEnabled = True
        Me.cboxProductPrices.Location = New System.Drawing.Point(71, 19)
        Me.cboxProductPrices.Name = "cboxProductPrices"
        Me.cboxProductPrices.Size = New System.Drawing.Size(168, 21)
        Me.cboxProductPrices.TabIndex = 28
        '
        'btnUpdatePrices
        '
        Me.btnUpdatePrices.Location = New System.Drawing.Point(142, 19)
        Me.btnUpdatePrices.Name = "btnUpdatePrices"
        Me.btnUpdatePrices.Size = New System.Drawing.Size(105, 23)
        Me.btnUpdatePrices.TabIndex = 26
        Me.btnUpdatePrices.Text = "Update"
        Me.btnUpdatePrices.UseVisualStyleBackColor = True
        '
        'btnDeletePrices
        '
        Me.btnDeletePrices.Location = New System.Drawing.Point(142, 60)
        Me.btnDeletePrices.Name = "btnDeletePrices"
        Me.btnDeletePrices.Size = New System.Drawing.Size(105, 23)
        Me.btnDeletePrices.TabIndex = 25
        Me.btnDeletePrices.Text = "Delete"
        Me.btnDeletePrices.UseVisualStyleBackColor = True
        '
        'btnCleanPrices
        '
        Me.btnCleanPrices.Location = New System.Drawing.Point(9, 60)
        Me.btnCleanPrices.Name = "btnCleanPrices"
        Me.btnCleanPrices.Size = New System.Drawing.Size(102, 23)
        Me.btnCleanPrices.TabIndex = 24
        Me.btnCleanPrices.Text = "Clean"
        Me.btnCleanPrices.UseVisualStyleBackColor = True
        '
        'lblPricesList
        '
        Me.lblPricesList.Location = New System.Drawing.Point(18, 26)
        Me.lblPricesList.Name = "lblPricesList"
        Me.lblPricesList.Size = New System.Drawing.Size(131, 15)
        Me.lblPricesList.TabIndex = 22
        Me.lblPricesList.Text = "Prices List"
        '
        'lstPrices
        '
        Me.lstPrices.FormattingEnabled = True
        Me.lstPrices.Location = New System.Drawing.Point(18, 53)
        Me.lstPrices.Name = "lstPrices"
        Me.lstPrices.Size = New System.Drawing.Size(178, 303)
        Me.lstPrices.TabIndex = 21
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(6, 55)
        Me.txtPath.Multiline = True
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(164, 83)
        Me.txtPath.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(544, 140)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
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
        Me.gbDatabase.Location = New System.Drawing.Point(494, 270)
        Me.gbDatabase.Name = "gbDatabase"
        Me.gbDatabase.Size = New System.Drawing.Size(176, 147)
        Me.gbDatabase.TabIndex = 5
        Me.gbDatabase.TabStop = False
        Me.gbDatabase.Text = "Database"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 433)
        Me.Controls.Add(Me.gbDatabase)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.tabControl)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.tabControl.ResumeLayout(False)
        Me.tabProduct.ResumeLayout(False)
        Me.tabProduct.PerformLayout()
        Me.tabTrains.ResumeLayout(False)
        Me.tabTrains.PerformLayout()
        Me.tabTrainTypes.ResumeLayout(False)
        Me.tabTrainTypes.PerformLayout()
        Me.tabPrices.ResumeLayout(False)
        Me.gbBtnPrices.ResumeLayout(False)
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
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClean As Button
    Friend WithEvents btnAdd As Button
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
    Friend WithEvents lblTrainList As Label
    Friend WithEvents lstTrain As ListBox
    Friend WithEvents txtCapacityTrainTypes As TextBox
    Friend WithEvents lblCapacity As Label
    Friend WithEvents lblTrainType As Label
    Friend WithEvents txtTrainTypeDescription As TextBox
    Friend WithEvents btnUpdateTrainType As Button
    Friend WithEvents btnDeleteTrainType As Button
    Friend WithEvents btnTrainType As Button
    Friend WithEvents btnAddTrainType As Button
    Friend WithEvents lblTrainTypeList As Label
    Friend WithEvents lstTrainType As ListBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpPrices As DateTimePicker
    Friend WithEvents cboxProductPrices As ComboBox
    Friend WithEvents lblPriceProduct As Label
    Friend WithEvents btnUpdatePrices As Button
    Friend WithEvents btnDeletePrices As Button
    Friend WithEvents btnCleanPrices As Button
    Friend WithEvents btnAddPrices As Button
    Friend WithEvents lblPricesList As Label
    Friend WithEvents lstPrices As ListBox
    Friend WithEvents gbBtnPrices As GroupBox
    Friend WithEvents gbPrices As GroupBox
    Friend WithEvents gbDatabase As GroupBox
End Class
