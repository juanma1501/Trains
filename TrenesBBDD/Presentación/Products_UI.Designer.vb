<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Products_UI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Products_UI))
        Me.ListBoxProducts = New System.Windows.Forms.ListBox()
        Me.GBOption = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.GBDescription = New System.Windows.Forms.GroupBox()
        Me.GBId = New System.Windows.Forms.GroupBox()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.GBEuros = New System.Windows.Forms.GroupBox()
        Me.TextBoxEuros = New System.Windows.Forms.TextBox()
        Me.GBUpdate = New System.Windows.Forms.GroupBox()
        Me.BTReturn = New System.Windows.Forms.Button()
        Me.BTDelete = New System.Windows.Forms.Button()
        Me.BTSave = New System.Windows.Forms.Button()
        Me.GBDate = New System.Windows.Forms.GroupBox()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GBPriceID = New System.Windows.Forms.GroupBox()
        Me.TextBoxPriceID = New System.Windows.Forms.TextBox()
        Me.ListBoxPrices = New System.Windows.Forms.ListBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.GBUdpdatePrice = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GBPriceOption = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.GBProductInfo = New System.Windows.Forms.GroupBox()
        Me.GBPriceInfo = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ListBoxDate = New System.Windows.Forms.ListBox()
        Me.ListBoxEuros = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBOption.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBDescription.SuspendLayout()
        Me.GBId.SuspendLayout()
        Me.GBEuros.SuspendLayout()
        Me.GBUpdate.SuspendLayout()
        Me.GBDate.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBPriceID.SuspendLayout()
        Me.GBUdpdatePrice.SuspendLayout()
        Me.GBPriceOption.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBProductInfo.SuspendLayout()
        Me.GBPriceInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxProducts
        '
        Me.ListBoxProducts.FormattingEnabled = True
        Me.ListBoxProducts.ItemHeight = 16
        Me.ListBoxProducts.Location = New System.Drawing.Point(46, 126)
        Me.ListBoxProducts.Name = "ListBoxProducts"
        Me.ListBoxProducts.Size = New System.Drawing.Size(319, 420)
        Me.ListBoxProducts.TabIndex = 0
        '
        'GBOption
        '
        Me.GBOption.Controls.Add(Me.PictureBox3)
        Me.GBOption.Controls.Add(Me.PictureBox2)
        Me.GBOption.Controls.Add(Me.PictureBox1)
        Me.GBOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBOption.Location = New System.Drawing.Point(395, 187)
        Me.GBOption.Name = "GBOption"
        Me.GBOption.Size = New System.Drawing.Size(291, 115)
        Me.GBOption.TabIndex = 1
        Me.GBOption.TabStop = False
        Me.GBOption.Text = "Product Option"
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.TrenesBBDD.My.Resources.Resources.eliminar_pro
        Me.PictureBox3.Location = New System.Drawing.Point(199, 43)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(54, 52)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.TrenesBBDD.My.Resources.Resources.editar_producto_png
        Me.PictureBox2.Location = New System.Drawing.Point(110, 43)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.TrenesBBDD.My.Resources.Resources.agregar_producto
        Me.PictureBox1.Location = New System.Drawing.Point(25, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDescription.Location = New System.Drawing.Point(10, 21)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(275, 40)
        Me.TextBoxDescription.TabIndex = 2
        '
        'GBDescription
        '
        Me.GBDescription.Controls.Add(Me.TextBoxDescription)
        Me.GBDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDescription.Location = New System.Drawing.Point(10, 163)
        Me.GBDescription.Name = "GBDescription"
        Me.GBDescription.Size = New System.Drawing.Size(291, 74)
        Me.GBDescription.TabIndex = 3
        Me.GBDescription.TabStop = False
        Me.GBDescription.Text = "Description of the product"
        '
        'GBId
        '
        Me.GBId.Controls.Add(Me.TextBoxId)
        Me.GBId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBId.Location = New System.Drawing.Point(10, 31)
        Me.GBId.Name = "GBId"
        Me.GBId.Size = New System.Drawing.Size(291, 100)
        Me.GBId.TabIndex = 4
        Me.GBId.TabStop = False
        Me.GBId.Text = "Product ID"
        '
        'TextBoxId
        '
        Me.TextBoxId.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxId.Location = New System.Drawing.Point(25, 43)
        Me.TextBoxId.Multiline = True
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(217, 22)
        Me.TextBoxId.TabIndex = 0
        '
        'GBEuros
        '
        Me.GBEuros.Controls.Add(Me.TextBoxEuros)
        Me.GBEuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEuros.Location = New System.Drawing.Point(25, 218)
        Me.GBEuros.Name = "GBEuros"
        Me.GBEuros.Size = New System.Drawing.Size(271, 64)
        Me.GBEuros.TabIndex = 5
        Me.GBEuros.TabStop = False
        Me.GBEuros.Text = "Euros Per Ton"
        '
        'TextBoxEuros
        '
        Me.TextBoxEuros.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxEuros.Location = New System.Drawing.Point(25, 26)
        Me.TextBoxEuros.Multiline = True
        Me.TextBoxEuros.Name = "TextBoxEuros"
        Me.TextBoxEuros.Size = New System.Drawing.Size(217, 32)
        Me.TextBoxEuros.TabIndex = 2
        '
        'GBUpdate
        '
        Me.GBUpdate.Controls.Add(Me.BTReturn)
        Me.GBUpdate.Controls.Add(Me.BTDelete)
        Me.GBUpdate.Controls.Add(Me.BTSave)
        Me.GBUpdate.Enabled = False
        Me.GBUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBUpdate.Location = New System.Drawing.Point(395, 65)
        Me.GBUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.GBUpdate.Name = "GBUpdate"
        Me.GBUpdate.Padding = New System.Windows.Forms.Padding(4)
        Me.GBUpdate.Size = New System.Drawing.Size(251, 115)
        Me.GBUpdate.TabIndex = 19
        Me.GBUpdate.TabStop = False
        Me.GBUpdate.Text = "Update Buttons"
        '
        'BTReturn
        '
        Me.BTReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTReturn.FlatAppearance.BorderSize = 0
        Me.BTReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTReturn.Image = CType(resources.GetObject("BTReturn.Image"), System.Drawing.Image)
        Me.BTReturn.Location = New System.Drawing.Point(21, 43)
        Me.BTReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.BTReturn.Name = "BTReturn"
        Me.BTReturn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTReturn.Size = New System.Drawing.Size(64, 47)
        Me.BTReturn.TabIndex = 7
        Me.BTReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTReturn.UseVisualStyleBackColor = True
        '
        'BTDelete
        '
        Me.BTDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTDelete.FlatAppearance.BorderSize = 0
        Me.BTDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTDelete.Image = CType(resources.GetObject("BTDelete.Image"), System.Drawing.Image)
        Me.BTDelete.Location = New System.Drawing.Point(93, 43)
        Me.BTDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BTDelete.Name = "BTDelete"
        Me.BTDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTDelete.Size = New System.Drawing.Size(64, 47)
        Me.BTDelete.TabIndex = 8
        Me.BTDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTDelete.UseVisualStyleBackColor = True
        '
        'BTSave
        '
        Me.BTSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTSave.FlatAppearance.BorderSize = 0
        Me.BTSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTSave.Image = CType(resources.GetObject("BTSave.Image"), System.Drawing.Image)
        Me.BTSave.Location = New System.Drawing.Point(158, 43)
        Me.BTSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BTSave.Name = "BTSave"
        Me.BTSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTSave.Size = New System.Drawing.Size(64, 47)
        Me.BTSave.TabIndex = 9
        Me.BTSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTSave.UseVisualStyleBackColor = True
        '
        'GBDate
        '
        Me.GBDate.Controls.Add(Me.TextBoxDate)
        Me.GBDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDate.Location = New System.Drawing.Point(25, 133)
        Me.GBDate.Name = "GBDate"
        Me.GBDate.Size = New System.Drawing.Size(271, 79)
        Me.GBDate.TabIndex = 6
        Me.GBDate.TabStop = False
        Me.GBDate.Text = "Price Date"
        '
        'TextBoxDate
        '
        Me.TextBoxDate.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxDate.Location = New System.Drawing.Point(25, 33)
        Me.TextBoxDate.Multiline = True
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.Size = New System.Drawing.Size(217, 22)
        Me.TextBoxDate.TabIndex = 1
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.TrenesBBDD.My.Resources.Resources.retroceso
        Me.PictureBox4.Location = New System.Drawing.Point(46, 568)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(90, 76)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'GBPriceID
        '
        Me.GBPriceID.Controls.Add(Me.TextBoxPriceID)
        Me.GBPriceID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPriceID.Location = New System.Drawing.Point(25, 27)
        Me.GBPriceID.Name = "GBPriceID"
        Me.GBPriceID.Size = New System.Drawing.Size(271, 100)
        Me.GBPriceID.TabIndex = 5
        Me.GBPriceID.TabStop = False
        Me.GBPriceID.Text = "Product ID"
        '
        'TextBoxPriceID
        '
        Me.TextBoxPriceID.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxPriceID.Location = New System.Drawing.Point(25, 43)
        Me.TextBoxPriceID.Multiline = True
        Me.TextBoxPriceID.Name = "TextBoxPriceID"
        Me.TextBoxPriceID.Size = New System.Drawing.Size(217, 22)
        Me.TextBoxPriceID.TabIndex = 0
        '
        'ListBoxPrices
        '
        Me.ListBoxPrices.FormattingEnabled = True
        Me.ListBoxPrices.ItemHeight = 16
        Me.ListBoxPrices.Location = New System.Drawing.Point(1211, 176)
        Me.ListBoxPrices.Name = "ListBoxPrices"
        Me.ListBoxPrices.Size = New System.Drawing.Size(90, 356)
        Me.ListBoxPrices.TabIndex = 23
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox6.Location = New System.Drawing.Point(1190, 149)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(123, 21)
        Me.TextBox6.TabIndex = 25
        Me.TextBox6.Text = "Product ID"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GBUdpdatePrice
        '
        Me.GBUdpdatePrice.Controls.Add(Me.Button1)
        Me.GBUdpdatePrice.Controls.Add(Me.Button2)
        Me.GBUdpdatePrice.Controls.Add(Me.Button3)
        Me.GBUdpdatePrice.Enabled = False
        Me.GBUdpdatePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBUdpdatePrice.Location = New System.Drawing.Point(908, 65)
        Me.GBUdpdatePrice.Margin = New System.Windows.Forms.Padding(4)
        Me.GBUdpdatePrice.Name = "GBUdpdatePrice"
        Me.GBUdpdatePrice.Padding = New System.Windows.Forms.Padding(4)
        Me.GBUdpdatePrice.Size = New System.Drawing.Size(251, 115)
        Me.GBUdpdatePrice.TabIndex = 20
        Me.GBUdpdatePrice.TabStop = False
        Me.GBUdpdatePrice.Text = "Update Buttons"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(21, 43)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(64, 47)
        Me.Button1.TabIndex = 7
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(93, 43)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(64, 47)
        Me.Button2.TabIndex = 8
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(158, 43)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(64, 47)
        Me.Button3.TabIndex = 9
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GBPriceOption
        '
        Me.GBPriceOption.Controls.Add(Me.PictureBox5)
        Me.GBPriceOption.Controls.Add(Me.PictureBox6)
        Me.GBPriceOption.Controls.Add(Me.PictureBox7)
        Me.GBPriceOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPriceOption.Location = New System.Drawing.Point(868, 187)
        Me.GBPriceOption.Name = "GBPriceOption"
        Me.GBPriceOption.Size = New System.Drawing.Size(291, 115)
        Me.GBPriceOption.TabIndex = 3
        Me.GBPriceOption.TabStop = False
        Me.GBPriceOption.Text = "Product Option"
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.TrenesBBDD.My.Resources.Resources.eliminar_png
        Me.PictureBox5.Location = New System.Drawing.Point(199, 43)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(54, 52)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.TrenesBBDD.My.Resources.Resources.editar
        Me.PictureBox6.Location = New System.Drawing.Point(110, 43)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(51, 52)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 1
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = Global.TrenesBBDD.My.Resources.Resources.añadir_tren_buena
        Me.PictureBox7.Location = New System.Drawing.Point(25, 43)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(54, 52)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'GBProductInfo
        '
        Me.GBProductInfo.Controls.Add(Me.GBId)
        Me.GBProductInfo.Controls.Add(Me.GBDescription)
        Me.GBProductInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBProductInfo.Location = New System.Drawing.Point(395, 308)
        Me.GBProductInfo.Name = "GBProductInfo"
        Me.GBProductInfo.Size = New System.Drawing.Size(325, 247)
        Me.GBProductInfo.TabIndex = 26
        Me.GBProductInfo.TabStop = False
        Me.GBProductInfo.Text = "Product Info"
        '
        'GBPriceInfo
        '
        Me.GBPriceInfo.Controls.Add(Me.GBPriceID)
        Me.GBPriceInfo.Controls.Add(Me.GBEuros)
        Me.GBPriceInfo.Controls.Add(Me.GBDate)
        Me.GBPriceInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPriceInfo.Location = New System.Drawing.Point(841, 308)
        Me.GBPriceInfo.Name = "GBPriceInfo"
        Me.GBPriceInfo.Size = New System.Drawing.Size(318, 299)
        Me.GBPriceInfo.TabIndex = 27
        Me.GBPriceInfo.TabStop = False
        Me.GBPriceInfo.Text = "Price Info"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox1.Location = New System.Drawing.Point(1319, 148)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(69, 22)
        Me.TextBox1.TabIndex = 28
        Me.TextBox1.Text = "Date"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox2.Location = New System.Drawing.Point(1429, 148)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(69, 22)
        Me.TextBox2.TabIndex = 29
        Me.TextBox2.Text = "Price"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListBoxDate
        '
        Me.ListBoxDate.FormattingEnabled = True
        Me.ListBoxDate.ItemHeight = 16
        Me.ListBoxDate.Location = New System.Drawing.Point(1319, 176)
        Me.ListBoxDate.Name = "ListBoxDate"
        Me.ListBoxDate.Size = New System.Drawing.Size(90, 356)
        Me.ListBoxDate.TabIndex = 30
        '
        'ListBoxEuros
        '
        Me.ListBoxEuros.FormattingEnabled = True
        Me.ListBoxEuros.ItemHeight = 16
        Me.ListBoxEuros.Location = New System.Drawing.Point(1429, 176)
        Me.ListBoxEuros.Name = "ListBoxEuros"
        Me.ListBoxEuros.Size = New System.Drawing.Size(90, 356)
        Me.ListBoxEuros.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(95, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 32)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "PRODUCTS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(1296, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 32)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "PRICES"
        '
        'Products_UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1531, 684)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBoxEuros)
        Me.Controls.Add(Me.ListBoxDate)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GBPriceInfo)
        Me.Controls.Add(Me.GBProductInfo)
        Me.Controls.Add(Me.GBPriceOption)
        Me.Controls.Add(Me.GBUdpdatePrice)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.ListBoxPrices)
        Me.Controls.Add(Me.GBUpdate)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.GBOption)
        Me.Controls.Add(Me.ListBoxProducts)
        Me.Name = "Products_UI"
        Me.Text = "Products"
        Me.GBOption.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBDescription.ResumeLayout(False)
        Me.GBDescription.PerformLayout()
        Me.GBId.ResumeLayout(False)
        Me.GBId.PerformLayout()
        Me.GBEuros.ResumeLayout(False)
        Me.GBEuros.PerformLayout()
        Me.GBUpdate.ResumeLayout(False)
        Me.GBDate.ResumeLayout(False)
        Me.GBDate.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBPriceID.ResumeLayout(False)
        Me.GBPriceID.PerformLayout()
        Me.GBUdpdatePrice.ResumeLayout(False)
        Me.GBPriceOption.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBProductInfo.ResumeLayout(False)
        Me.GBPriceInfo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxProducts As ListBox
    Friend WithEvents GBOption As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxDescription As TextBox
    Friend WithEvents GBDescription As GroupBox
    Friend WithEvents GBId As GroupBox
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents GBEuros As GroupBox
    Friend WithEvents GBUpdate As GroupBox
    Friend WithEvents BTReturn As Button
    Friend WithEvents BTDelete As Button
    Friend WithEvents BTSave As Button
    Friend WithEvents GBDate As GroupBox
    Friend WithEvents TextBoxEuros As TextBox
    Friend WithEvents TextBoxDate As TextBox
    Friend WithEvents GBPriceID As GroupBox
    Friend WithEvents TextBoxPriceID As TextBox
    Friend WithEvents ListBoxPrices As ListBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents GBUdpdatePrice As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GBPriceOption As GroupBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents GBProductInfo As GroupBox
    Friend WithEvents GBPriceInfo As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ListBoxDate As ListBox
    Friend WithEvents ListBoxEuros As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
