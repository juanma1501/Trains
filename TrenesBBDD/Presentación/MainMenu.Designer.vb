<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Ranking_Button = New System.Windows.Forms.Button()
        Me.Products_Button = New System.Windows.Forms.Button()
        Me.Trains_Button = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxDate = New System.Windows.Forms.ListBox()
        Me.GBOptions = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Añadir = New System.Windows.Forms.PictureBox()
        Me.Delete = New System.Windows.Forms.PictureBox()
        Me.GBUpdate = New System.Windows.Forms.GroupBox()
        Me.BtCancelarPer = New System.Windows.Forms.Button()
        Me.BtLimpiarPer = New System.Windows.Forms.Button()
        Me.BtGuardarPer = New System.Windows.Forms.Button()
        Me.GBTrain = New System.Windows.Forms.GroupBox()
        Me.GBType = New System.Windows.Forms.GroupBox()
        Me.TextBoxType = New System.Windows.Forms.TextBox()
        Me.GBTrainID = New System.Windows.Forms.GroupBox()
        Me.TextBoxTrainID = New System.Windows.Forms.TextBox()
        Me.GBDate = New System.Windows.Forms.GroupBox()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.GBProducts = New System.Windows.Forms.GroupBox()
        Me.GBProductID = New System.Windows.Forms.GroupBox()
        Me.TextBoxProductID = New System.Windows.Forms.TextBox()
        Me.GBDescription = New System.Windows.Forms.GroupBox()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.GBTons = New System.Windows.Forms.GroupBox()
        Me.TextBoxTons = New System.Windows.Forms.TextBox()
        Me.ListBoxTrips = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBOptions.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Añadir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBUpdate.SuspendLayout()
        Me.GBTrain.SuspendLayout()
        Me.GBType.SuspendLayout()
        Me.GBTrainID.SuspendLayout()
        Me.GBDate.SuspendLayout()
        Me.GBProducts.SuspendLayout()
        Me.GBProductID.SuspendLayout()
        Me.GBDescription.SuspendLayout()
        Me.GBTons.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ranking_Button
        '
        Me.Ranking_Button.BackgroundImage = Global.TrenesBBDD.My.Resources.Resources.rankings_fondo__2_
        Me.Ranking_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ranking_Button.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ranking_Button.ForeColor = System.Drawing.Color.Black
        Me.Ranking_Button.Location = New System.Drawing.Point(1099, 520)
        Me.Ranking_Button.Name = "Ranking_Button"
        Me.Ranking_Button.Size = New System.Drawing.Size(354, 69)
        Me.Ranking_Button.TabIndex = 4
        Me.Ranking_Button.Text = "Rankings"
        Me.Ranking_Button.UseVisualStyleBackColor = True
        '
        'Products_Button
        '
        Me.Products_Button.BackgroundImage = Global.TrenesBBDD.My.Resources.Resources.products_fondo__2_
        Me.Products_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Products_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Products_Button.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Products_Button.ForeColor = System.Drawing.Color.Black
        Me.Products_Button.Location = New System.Drawing.Point(1099, 398)
        Me.Products_Button.Name = "Products_Button"
        Me.Products_Button.Size = New System.Drawing.Size(354, 69)
        Me.Products_Button.TabIndex = 3
        Me.Products_Button.Text = "Products"
        Me.Products_Button.UseVisualStyleBackColor = True
        '
        'Trains_Button
        '
        Me.Trains_Button.BackgroundImage = Global.TrenesBBDD.My.Resources.Resources.tren_fondo__3_
        Me.Trains_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Trains_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Trains_Button.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Trains_Button.ForeColor = System.Drawing.Color.Black
        Me.Trains_Button.Location = New System.Drawing.Point(1099, 285)
        Me.Trains_Button.Name = "Trains_Button"
        Me.Trains_Button.Size = New System.Drawing.Size(354, 69)
        Me.Trains_Button.TabIndex = 2
        Me.Trains_Button.Text = "Trains"
        Me.Trains_Button.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TrenesBBDD.My.Resources.Resources.f29e7f0d_c91d_4da8_8e43_cbb1b21c334d_200x200
        Me.PictureBox1.Location = New System.Drawing.Point(667, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(231, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(136, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 23)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(17, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 23)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Trains"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(58, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 32)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "TRIPS"
        '
        'ListBoxDate
        '
        Me.ListBoxDate.FormattingEnabled = True
        Me.ListBoxDate.ItemHeight = 16
        Me.ListBoxDate.Location = New System.Drawing.Point(107, 256)
        Me.ListBoxDate.Name = "ListBoxDate"
        Me.ListBoxDate.Size = New System.Drawing.Size(131, 372)
        Me.ListBoxDate.TabIndex = 63
        '
        'GBOptions
        '
        Me.GBOptions.Controls.Add(Me.Label6)
        Me.GBOptions.Controls.Add(Me.Label5)
        Me.GBOptions.Controls.Add(Me.Label4)
        Me.GBOptions.Controls.Add(Me.PictureBox2)
        Me.GBOptions.Controls.Add(Me.Añadir)
        Me.GBOptions.Controls.Add(Me.Delete)
        Me.GBOptions.Location = New System.Drawing.Point(288, 201)
        Me.GBOptions.Name = "GBOptions"
        Me.GBOptions.Size = New System.Drawing.Size(274, 120)
        Me.GBOptions.TabIndex = 62
        Me.GBOptions.TabStop = False
        Me.GBOptions.Text = "Trip Options"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(195, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Edit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(113, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Delete"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(34, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Add"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.TrenesBBDD.My.Resources.Resources.editar
        Me.PictureBox2.Location = New System.Drawing.Point(187, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'Añadir
        '
        Me.Añadir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Añadir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Añadir.Image = Global.TrenesBBDD.My.Resources.Resources.añadir_tren
        Me.Añadir.Location = New System.Drawing.Point(23, 30)
        Me.Añadir.Name = "Añadir"
        Me.Añadir.Size = New System.Drawing.Size(62, 60)
        Me.Añadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Añadir.TabIndex = 23
        Me.Añadir.TabStop = False
        '
        'Delete
        '
        Me.Delete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Delete.Image = Global.TrenesBBDD.My.Resources.Resources.eliminar_png
        Me.Delete.Location = New System.Drawing.Point(107, 30)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(62, 60)
        Me.Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Delete.TabIndex = 21
        Me.Delete.TabStop = False
        '
        'GBUpdate
        '
        Me.GBUpdate.Controls.Add(Me.BtCancelarPer)
        Me.GBUpdate.Controls.Add(Me.BtLimpiarPer)
        Me.GBUpdate.Controls.Add(Me.BtGuardarPer)
        Me.GBUpdate.Enabled = False
        Me.GBUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBUpdate.Location = New System.Drawing.Point(648, 202)
        Me.GBUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GBUpdate.Name = "GBUpdate"
        Me.GBUpdate.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GBUpdate.Size = New System.Drawing.Size(251, 105)
        Me.GBUpdate.TabIndex = 61
        Me.GBUpdate.TabStop = False
        Me.GBUpdate.Text = "Update Buttons"
        '
        'BtCancelarPer
        '
        Me.BtCancelarPer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtCancelarPer.FlatAppearance.BorderSize = 0
        Me.BtCancelarPer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCancelarPer.Image = CType(resources.GetObject("BtCancelarPer.Image"), System.Drawing.Image)
        Me.BtCancelarPer.Location = New System.Drawing.Point(21, 43)
        Me.BtCancelarPer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtCancelarPer.Name = "BtCancelarPer"
        Me.BtCancelarPer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtCancelarPer.Size = New System.Drawing.Size(64, 47)
        Me.BtCancelarPer.TabIndex = 7
        Me.BtCancelarPer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtCancelarPer.UseVisualStyleBackColor = True
        '
        'BtLimpiarPer
        '
        Me.BtLimpiarPer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtLimpiarPer.FlatAppearance.BorderSize = 0
        Me.BtLimpiarPer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtLimpiarPer.Image = CType(resources.GetObject("BtLimpiarPer.Image"), System.Drawing.Image)
        Me.BtLimpiarPer.Location = New System.Drawing.Point(93, 43)
        Me.BtLimpiarPer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtLimpiarPer.Name = "BtLimpiarPer"
        Me.BtLimpiarPer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtLimpiarPer.Size = New System.Drawing.Size(59, 47)
        Me.BtLimpiarPer.TabIndex = 8
        Me.BtLimpiarPer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtLimpiarPer.UseVisualStyleBackColor = True
        '
        'BtGuardarPer
        '
        Me.BtGuardarPer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtGuardarPer.FlatAppearance.BorderSize = 0
        Me.BtGuardarPer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtGuardarPer.Image = CType(resources.GetObject("BtGuardarPer.Image"), System.Drawing.Image)
        Me.BtGuardarPer.Location = New System.Drawing.Point(158, 43)
        Me.BtGuardarPer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtGuardarPer.Name = "BtGuardarPer"
        Me.BtGuardarPer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtGuardarPer.Size = New System.Drawing.Size(66, 47)
        Me.BtGuardarPer.TabIndex = 9
        Me.BtGuardarPer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtGuardarPer.UseVisualStyleBackColor = True
        '
        'GBTrain
        '
        Me.GBTrain.Controls.Add(Me.GBType)
        Me.GBTrain.Controls.Add(Me.GBTrainID)
        Me.GBTrain.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBTrain.Location = New System.Drawing.Point(289, 443)
        Me.GBTrain.Name = "GBTrain"
        Me.GBTrain.Size = New System.Drawing.Size(249, 223)
        Me.GBTrain.TabIndex = 59
        Me.GBTrain.TabStop = False
        Me.GBTrain.Text = "Train"
        '
        'GBType
        '
        Me.GBType.Controls.Add(Me.TextBoxType)
        Me.GBType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBType.Location = New System.Drawing.Point(15, 138)
        Me.GBType.Name = "GBType"
        Me.GBType.Size = New System.Drawing.Size(219, 59)
        Me.GBType.TabIndex = 1
        Me.GBType.TabStop = False
        Me.GBType.Text = "Train Type"
        '
        'TextBoxType
        '
        Me.TextBoxType.ForeColor = System.Drawing.Color.Black
        Me.TextBoxType.Location = New System.Drawing.Point(22, 21)
        Me.TextBoxType.Name = "TextBoxType"
        Me.TextBoxType.Size = New System.Drawing.Size(161, 27)
        Me.TextBoxType.TabIndex = 3
        '
        'GBTrainID
        '
        Me.GBTrainID.Controls.Add(Me.TextBoxTrainID)
        Me.GBTrainID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBTrainID.Location = New System.Drawing.Point(15, 55)
        Me.GBTrainID.Name = "GBTrainID"
        Me.GBTrainID.Size = New System.Drawing.Size(219, 61)
        Me.GBTrainID.TabIndex = 0
        Me.GBTrainID.TabStop = False
        Me.GBTrainID.Text = "Train ID"
        '
        'TextBoxTrainID
        '
        Me.TextBoxTrainID.Location = New System.Drawing.Point(22, 22)
        Me.TextBoxTrainID.Name = "TextBoxTrainID"
        Me.TextBoxTrainID.Size = New System.Drawing.Size(161, 27)
        Me.TextBoxTrainID.TabIndex = 2
        '
        'GBDate
        '
        Me.GBDate.Controls.Add(Me.TextBoxDate)
        Me.GBDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDate.Location = New System.Drawing.Point(288, 368)
        Me.GBDate.Name = "GBDate"
        Me.GBDate.Size = New System.Drawing.Size(249, 58)
        Me.GBDate.TabIndex = 60
        Me.GBDate.TabStop = False
        Me.GBDate.Text = "Date"
        '
        'TextBoxDate
        '
        Me.TextBoxDate.Location = New System.Drawing.Point(37, 19)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.Size = New System.Drawing.Size(161, 27)
        Me.TextBoxDate.TabIndex = 3
        '
        'GBProducts
        '
        Me.GBProducts.Controls.Add(Me.GBProductID)
        Me.GBProducts.Controls.Add(Me.GBDescription)
        Me.GBProducts.Controls.Add(Me.GBTons)
        Me.GBProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBProducts.Location = New System.Drawing.Point(648, 317)
        Me.GBProducts.Name = "GBProducts"
        Me.GBProducts.Size = New System.Drawing.Size(297, 349)
        Me.GBProducts.TabIndex = 58
        Me.GBProducts.TabStop = False
        Me.GBProducts.Text = "Product Transported"
        '
        'GBProductID
        '
        Me.GBProductID.Controls.Add(Me.TextBoxProductID)
        Me.GBProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBProductID.Location = New System.Drawing.Point(31, 51)
        Me.GBProductID.Name = "GBProductID"
        Me.GBProductID.Size = New System.Drawing.Size(219, 61)
        Me.GBProductID.TabIndex = 5
        Me.GBProductID.TabStop = False
        Me.GBProductID.Text = "Product ID"
        '
        'TextBoxProductID
        '
        Me.TextBoxProductID.Location = New System.Drawing.Point(21, 21)
        Me.TextBoxProductID.Name = "TextBoxProductID"
        Me.TextBoxProductID.Size = New System.Drawing.Size(179, 27)
        Me.TextBoxProductID.TabIndex = 4
        '
        'GBDescription
        '
        Me.GBDescription.Controls.Add(Me.TextBoxDescription)
        Me.GBDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDescription.Location = New System.Drawing.Point(31, 267)
        Me.GBDescription.Name = "GBDescription"
        Me.GBDescription.Size = New System.Drawing.Size(219, 56)
        Me.GBDescription.TabIndex = 7
        Me.GBDescription.TabStop = False
        Me.GBDescription.Text = "Product Description"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Location = New System.Drawing.Point(21, 21)
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(179, 27)
        Me.TextBoxDescription.TabIndex = 6
        '
        'GBTons
        '
        Me.GBTons.Controls.Add(Me.TextBoxTons)
        Me.GBTons.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBTons.Location = New System.Drawing.Point(31, 154)
        Me.GBTons.Name = "GBTons"
        Me.GBTons.Size = New System.Drawing.Size(219, 61)
        Me.GBTons.TabIndex = 2
        Me.GBTons.TabStop = False
        Me.GBTons.Text = "Tons Transported"
        '
        'TextBoxTons
        '
        Me.TextBoxTons.Location = New System.Drawing.Point(21, 21)
        Me.TextBoxTons.Name = "TextBoxTons"
        Me.TextBoxTons.Size = New System.Drawing.Size(179, 27)
        Me.TextBoxTons.TabIndex = 4
        '
        'ListBoxTrips
        '
        Me.ListBoxTrips.FormattingEnabled = True
        Me.ListBoxTrips.ItemHeight = 16
        Me.ListBoxTrips.Location = New System.Drawing.Point(11, 256)
        Me.ListBoxTrips.Name = "ListBoxTrips"
        Me.ListBoxTrips.Size = New System.Drawing.Size(82, 372)
        Me.ListBoxTrips.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(1147, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(238, 32)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "INFORMATION"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1488, 684)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxDate)
        Me.Controls.Add(Me.GBOptions)
        Me.Controls.Add(Me.GBUpdate)
        Me.Controls.Add(Me.GBTrain)
        Me.Controls.Add(Me.GBDate)
        Me.Controls.Add(Me.GBProducts)
        Me.Controls.Add(Me.ListBoxTrips)
        Me.Controls.Add(Me.Ranking_Button)
        Me.Controls.Add(Me.Products_Button)
        Me.Controls.Add(Me.Trains_Button)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainMenu"
        Me.Text = "JuJoEr"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBOptions.ResumeLayout(False)
        Me.GBOptions.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Añadir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Delete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBUpdate.ResumeLayout(False)
        Me.GBTrain.ResumeLayout(False)
        Me.GBType.ResumeLayout(False)
        Me.GBType.PerformLayout()
        Me.GBTrainID.ResumeLayout(False)
        Me.GBTrainID.PerformLayout()
        Me.GBDate.ResumeLayout(False)
        Me.GBDate.PerformLayout()
        Me.GBProducts.ResumeLayout(False)
        Me.GBProductID.ResumeLayout(False)
        Me.GBProductID.PerformLayout()
        Me.GBDescription.ResumeLayout(False)
        Me.GBDescription.PerformLayout()
        Me.GBTons.ResumeLayout(False)
        Me.GBTons.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Trains_Button As Button
    Friend WithEvents Products_Button As Button
    Friend WithEvents Ranking_Button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxDate As ListBox
    Friend WithEvents GBOptions As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Añadir As PictureBox
    Friend WithEvents Delete As PictureBox
    Friend WithEvents GBUpdate As GroupBox
    Friend WithEvents BtCancelarPer As Button
    Friend WithEvents BtLimpiarPer As Button
    Friend WithEvents BtGuardarPer As Button
    Friend WithEvents GBTrain As GroupBox
    Friend WithEvents GBType As GroupBox
    Friend WithEvents TextBoxType As TextBox
    Friend WithEvents GBTrainID As GroupBox
    Friend WithEvents TextBoxTrainID As TextBox
    Friend WithEvents GBDate As GroupBox
    Friend WithEvents TextBoxDate As TextBox
    Friend WithEvents GBProducts As GroupBox
    Friend WithEvents GBProductID As GroupBox
    Friend WithEvents TextBoxProductID As TextBox
    Friend WithEvents GBDescription As GroupBox
    Friend WithEvents TextBoxDescription As TextBox
    Friend WithEvents GBTons As GroupBox
    Friend WithEvents TextBoxTons As TextBox
    Friend WithEvents ListBoxTrips As ListBox
    Friend WithEvents Label7 As Label
End Class
