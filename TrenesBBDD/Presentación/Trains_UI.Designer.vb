<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Trains_UI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Trains_UI))
        Me.ListBoxTrains = New System.Windows.Forms.ListBox()
        Me.GBOptions = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GBId = New System.Windows.Forms.GroupBox()
        Me.IdBox = New System.Windows.Forms.TextBox()
        Me.GBType = New System.Windows.Forms.GroupBox()
        Me.TypeBox = New System.Windows.Forms.TextBox()
        Me.GBCapacity = New System.Windows.Forms.GroupBox()
        Me.CapacityBox = New System.Windows.Forms.TextBox()
        Me.GBDescription = New System.Windows.Forms.GroupBox()
        Me.DescriptionBox = New System.Windows.Forms.TextBox()
        Me.GBUpdate = New System.Windows.Forms.GroupBox()
        Me.BtReturn = New System.Windows.Forms.Button()
        Me.BtClean = New System.Windows.Forms.Button()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GBTypeID = New System.Windows.Forms.GroupBox()
        Me.TrainTypeBox = New System.Windows.Forms.TextBox()
        Me.GBTypesOption = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.ListBoxTypes = New System.Windows.Forms.ListBox()
        Me.GBTrainInfo = New System.Windows.Forms.GroupBox()
        Me.TypesInfo = New System.Windows.Forms.GroupBox()
        Me.GBUpdate2 = New System.Windows.Forms.GroupBox()
        Me.Return2 = New System.Windows.Forms.Button()
        Me.Delete2 = New System.Windows.Forms.Button()
        Me.Save2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBOptions.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBId.SuspendLayout()
        Me.GBType.SuspendLayout()
        Me.GBCapacity.SuspendLayout()
        Me.GBDescription.SuspendLayout()
        Me.GBUpdate.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBTypeID.SuspendLayout()
        Me.GBTypesOption.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBTrainInfo.SuspendLayout()
        Me.TypesInfo.SuspendLayout()
        Me.GBUpdate2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxTrains
        '
        Me.ListBoxTrains.FormattingEnabled = True
        Me.ListBoxTrains.ItemHeight = 16
        Me.ListBoxTrains.Location = New System.Drawing.Point(37, 106)
        Me.ListBoxTrains.Name = "ListBoxTrains"
        Me.ListBoxTrains.Size = New System.Drawing.Size(139, 372)
        Me.ListBoxTrains.TabIndex = 0
        '
        'GBOptions
        '
        Me.GBOptions.Controls.Add(Me.PictureBox2)
        Me.GBOptions.Controls.Add(Me.PictureBox3)
        Me.GBOptions.Controls.Add(Me.PictureBox1)
        Me.GBOptions.Location = New System.Drawing.Point(211, 137)
        Me.GBOptions.Name = "GBOptions"
        Me.GBOptions.Size = New System.Drawing.Size(274, 105)
        Me.GBOptions.TabIndex = 1
        Me.GBOptions.TabStop = False
        Me.GBOptions.Text = "Train Options"
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
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.TrenesBBDD.My.Resources.Resources.añadir_tren
        Me.PictureBox3.Location = New System.Drawing.Point(23, 30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(62, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.TrenesBBDD.My.Resources.Resources.eliminar_png
        Me.PictureBox1.Location = New System.Drawing.Point(107, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'GBId
        '
        Me.GBId.Controls.Add(Me.IdBox)
        Me.GBId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBId.Location = New System.Drawing.Point(23, 36)
        Me.GBId.Name = "GBId"
        Me.GBId.Size = New System.Drawing.Size(274, 55)
        Me.GBId.TabIndex = 2
        Me.GBId.TabStop = False
        Me.GBId.Text = "Train ID"
        '
        'IdBox
        '
        Me.IdBox.Location = New System.Drawing.Point(23, 21)
        Me.IdBox.Name = "IdBox"
        Me.IdBox.Size = New System.Drawing.Size(227, 24)
        Me.IdBox.TabIndex = 0
        '
        'GBType
        '
        Me.GBType.Controls.Add(Me.TypeBox)
        Me.GBType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBType.Location = New System.Drawing.Point(23, 111)
        Me.GBType.Name = "GBType"
        Me.GBType.Size = New System.Drawing.Size(274, 53)
        Me.GBType.TabIndex = 3
        Me.GBType.TabStop = False
        Me.GBType.Text = "TrainType "
        '
        'TypeBox
        '
        Me.TypeBox.Location = New System.Drawing.Point(23, 21)
        Me.TypeBox.Name = "TypeBox"
        Me.TypeBox.Size = New System.Drawing.Size(227, 24)
        Me.TypeBox.TabIndex = 1
        '
        'GBCapacity
        '
        Me.GBCapacity.Controls.Add(Me.CapacityBox)
        Me.GBCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBCapacity.Location = New System.Drawing.Point(19, 107)
        Me.GBCapacity.Name = "GBCapacity"
        Me.GBCapacity.Size = New System.Drawing.Size(274, 53)
        Me.GBCapacity.TabIndex = 4
        Me.GBCapacity.TabStop = False
        Me.GBCapacity.Text = "Max Capacity"
        '
        'CapacityBox
        '
        Me.CapacityBox.Location = New System.Drawing.Point(23, 21)
        Me.CapacityBox.Name = "CapacityBox"
        Me.CapacityBox.Size = New System.Drawing.Size(227, 24)
        Me.CapacityBox.TabIndex = 2
        '
        'GBDescription
        '
        Me.GBDescription.Controls.Add(Me.DescriptionBox)
        Me.GBDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDescription.Location = New System.Drawing.Point(19, 166)
        Me.GBDescription.Name = "GBDescription"
        Me.GBDescription.Size = New System.Drawing.Size(274, 63)
        Me.GBDescription.TabIndex = 4
        Me.GBDescription.TabStop = False
        Me.GBDescription.Text = "Train Type Description"
        '
        'DescriptionBox
        '
        Me.DescriptionBox.Location = New System.Drawing.Point(23, 21)
        Me.DescriptionBox.Multiline = True
        Me.DescriptionBox.Name = "DescriptionBox"
        Me.DescriptionBox.Size = New System.Drawing.Size(227, 22)
        Me.DescriptionBox.TabIndex = 1
        '
        'GBUpdate
        '
        Me.GBUpdate.Controls.Add(Me.BtReturn)
        Me.GBUpdate.Controls.Add(Me.BtClean)
        Me.GBUpdate.Controls.Add(Me.BtSave)
        Me.GBUpdate.Enabled = False
        Me.GBUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBUpdate.Location = New System.Drawing.Point(211, 25)
        Me.GBUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.GBUpdate.Name = "GBUpdate"
        Me.GBUpdate.Padding = New System.Windows.Forms.Padding(4)
        Me.GBUpdate.Size = New System.Drawing.Size(251, 105)
        Me.GBUpdate.TabIndex = 20
        Me.GBUpdate.TabStop = False
        Me.GBUpdate.Text = "Update Buttons"
        '
        'BtReturn
        '
        Me.BtReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtReturn.FlatAppearance.BorderSize = 0
        Me.BtReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtReturn.Image = CType(resources.GetObject("BtReturn.Image"), System.Drawing.Image)
        Me.BtReturn.Location = New System.Drawing.Point(21, 43)
        Me.BtReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.BtReturn.Name = "BtReturn"
        Me.BtReturn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtReturn.Size = New System.Drawing.Size(64, 47)
        Me.BtReturn.TabIndex = 7
        Me.BtReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtReturn.UseVisualStyleBackColor = True
        '
        'BtClean
        '
        Me.BtClean.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtClean.FlatAppearance.BorderSize = 0
        Me.BtClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtClean.Image = CType(resources.GetObject("BtClean.Image"), System.Drawing.Image)
        Me.BtClean.Location = New System.Drawing.Point(93, 43)
        Me.BtClean.Margin = New System.Windows.Forms.Padding(4)
        Me.BtClean.Name = "BtClean"
        Me.BtClean.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtClean.Size = New System.Drawing.Size(59, 47)
        Me.BtClean.TabIndex = 8
        Me.BtClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtClean.UseVisualStyleBackColor = True
        '
        'BtSave
        '
        Me.BtSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtSave.FlatAppearance.BorderSize = 0
        Me.BtSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtSave.Image = CType(resources.GetObject("BtSave.Image"), System.Drawing.Image)
        Me.BtSave.Location = New System.Drawing.Point(158, 43)
        Me.BtSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtSave.Size = New System.Drawing.Size(66, 47)
        Me.BtSave.TabIndex = 9
        Me.BtSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.TrenesBBDD.My.Resources.Resources.retroceso
        Me.PictureBox4.Location = New System.Drawing.Point(37, 502)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(90, 76)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'GBTypeID
        '
        Me.GBTypeID.Controls.Add(Me.TrainTypeBox)
        Me.GBTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBTypeID.Location = New System.Drawing.Point(19, 41)
        Me.GBTypeID.Name = "GBTypeID"
        Me.GBTypeID.Size = New System.Drawing.Size(274, 53)
        Me.GBTypeID.TabIndex = 4
        Me.GBTypeID.TabStop = False
        Me.GBTypeID.Text = "TrainType ID"
        '
        'TrainTypeBox
        '
        Me.TrainTypeBox.Location = New System.Drawing.Point(23, 21)
        Me.TrainTypeBox.Name = "TrainTypeBox"
        Me.TrainTypeBox.Size = New System.Drawing.Size(227, 24)
        Me.TrainTypeBox.TabIndex = 1
        '
        'GBTypesOption
        '
        Me.GBTypesOption.Controls.Add(Me.PictureBox5)
        Me.GBTypesOption.Controls.Add(Me.PictureBox6)
        Me.GBTypesOption.Controls.Add(Me.PictureBox7)
        Me.GBTypesOption.Location = New System.Drawing.Point(712, 137)
        Me.GBTypesOption.Name = "GBTypesOption"
        Me.GBTypesOption.Size = New System.Drawing.Size(275, 105)
        Me.GBTypesOption.TabIndex = 24
        Me.GBTypesOption.TabStop = False
        Me.GBTypesOption.Text = "Train Types Options"
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.TrenesBBDD.My.Resources.Resources.editar
        Me.PictureBox5.Location = New System.Drawing.Point(187, 30)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(63, 60)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.TrenesBBDD.My.Resources.Resources.añadir_tren
        Me.PictureBox6.Location = New System.Drawing.Point(23, 30)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(62, 60)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 23
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = Global.TrenesBBDD.My.Resources.Resources.eliminar_png
        Me.PictureBox7.Location = New System.Drawing.Point(107, 30)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(62, 60)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 21
        Me.PictureBox7.TabStop = False
        '
        'ListBoxTypes
        '
        Me.ListBoxTypes.FormattingEnabled = True
        Me.ListBoxTypes.ItemHeight = 16
        Me.ListBoxTypes.Location = New System.Drawing.Point(1055, 116)
        Me.ListBoxTypes.Name = "ListBoxTypes"
        Me.ListBoxTypes.Size = New System.Drawing.Size(189, 372)
        Me.ListBoxTypes.TabIndex = 25
        '
        'GBTrainInfo
        '
        Me.GBTrainInfo.Controls.Add(Me.GBId)
        Me.GBTrainInfo.Controls.Add(Me.GBType)
        Me.GBTrainInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBTrainInfo.Location = New System.Drawing.Point(211, 259)
        Me.GBTrainInfo.Name = "GBTrainInfo"
        Me.GBTrainInfo.Size = New System.Drawing.Size(316, 188)
        Me.GBTrainInfo.TabIndex = 28
        Me.GBTrainInfo.TabStop = False
        Me.GBTrainInfo.Text = "Train Information"
        '
        'TypesInfo
        '
        Me.TypesInfo.Controls.Add(Me.GBTypeID)
        Me.TypesInfo.Controls.Add(Me.GBCapacity)
        Me.TypesInfo.Controls.Add(Me.GBDescription)
        Me.TypesInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypesInfo.Location = New System.Drawing.Point(712, 259)
        Me.TypesInfo.Name = "TypesInfo"
        Me.TypesInfo.Size = New System.Drawing.Size(311, 246)
        Me.TypesInfo.TabIndex = 29
        Me.TypesInfo.TabStop = False
        Me.TypesInfo.Text = "Train Type Info"
        '
        'GBUpdate2
        '
        Me.GBUpdate2.Controls.Add(Me.Return2)
        Me.GBUpdate2.Controls.Add(Me.Delete2)
        Me.GBUpdate2.Controls.Add(Me.Save2)
        Me.GBUpdate2.Enabled = False
        Me.GBUpdate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBUpdate2.Location = New System.Drawing.Point(712, 25)
        Me.GBUpdate2.Margin = New System.Windows.Forms.Padding(4)
        Me.GBUpdate2.Name = "GBUpdate2"
        Me.GBUpdate2.Padding = New System.Windows.Forms.Padding(4)
        Me.GBUpdate2.Size = New System.Drawing.Size(251, 105)
        Me.GBUpdate2.TabIndex = 21
        Me.GBUpdate2.TabStop = False
        Me.GBUpdate2.Text = "Update Buttons"
        '
        'Return2
        '
        Me.Return2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Return2.FlatAppearance.BorderSize = 0
        Me.Return2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Return2.Image = CType(resources.GetObject("Return2.Image"), System.Drawing.Image)
        Me.Return2.Location = New System.Drawing.Point(21, 43)
        Me.Return2.Margin = New System.Windows.Forms.Padding(4)
        Me.Return2.Name = "Return2"
        Me.Return2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Return2.Size = New System.Drawing.Size(64, 47)
        Me.Return2.TabIndex = 7
        Me.Return2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Return2.UseVisualStyleBackColor = True
        '
        'Delete2
        '
        Me.Delete2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Delete2.FlatAppearance.BorderSize = 0
        Me.Delete2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete2.Image = CType(resources.GetObject("Delete2.Image"), System.Drawing.Image)
        Me.Delete2.Location = New System.Drawing.Point(93, 43)
        Me.Delete2.Margin = New System.Windows.Forms.Padding(4)
        Me.Delete2.Name = "Delete2"
        Me.Delete2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Delete2.Size = New System.Drawing.Size(59, 47)
        Me.Delete2.TabIndex = 8
        Me.Delete2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Delete2.UseVisualStyleBackColor = True
        '
        'Save2
        '
        Me.Save2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save2.FlatAppearance.BorderSize = 0
        Me.Save2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save2.Image = CType(resources.GetObject("Save2.Image"), System.Drawing.Image)
        Me.Save2.Location = New System.Drawing.Point(158, 43)
        Me.Save2.Margin = New System.Windows.Forms.Padding(4)
        Me.Save2.Name = "Save2"
        Me.Save2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Save2.Size = New System.Drawing.Size(66, 47)
        Me.Save2.TabIndex = 9
        Me.Save2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Save2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(43, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 32)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "TRAINS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(1093, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 32)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "TYPES"
        '
        'Trains_UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1358, 606)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GBUpdate2)
        Me.Controls.Add(Me.TypesInfo)
        Me.Controls.Add(Me.GBTrainInfo)
        Me.Controls.Add(Me.ListBoxTypes)
        Me.Controls.Add(Me.GBTypesOption)
        Me.Controls.Add(Me.GBUpdate)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.GBOptions)
        Me.Controls.Add(Me.ListBoxTrains)
        Me.Name = "Trains_UI"
        Me.Text = "Form2"
        Me.GBOptions.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBId.ResumeLayout(False)
        Me.GBId.PerformLayout()
        Me.GBType.ResumeLayout(False)
        Me.GBType.PerformLayout()
        Me.GBCapacity.ResumeLayout(False)
        Me.GBCapacity.PerformLayout()
        Me.GBDescription.ResumeLayout(False)
        Me.GBDescription.PerformLayout()
        Me.GBUpdate.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBTypeID.ResumeLayout(False)
        Me.GBTypeID.PerformLayout()
        Me.GBTypesOption.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBTrainInfo.ResumeLayout(False)
        Me.TypesInfo.ResumeLayout(False)
        Me.GBUpdate2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxTrains As ListBox
    Friend WithEvents GBOptions As GroupBox
    Friend WithEvents GBId As GroupBox
    Friend WithEvents GBType As GroupBox
    Friend WithEvents GBCapacity As GroupBox
    Friend WithEvents GBDescription As GroupBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents IdBox As TextBox
    Friend WithEvents TypeBox As TextBox
    Friend WithEvents CapacityBox As TextBox
    Friend WithEvents DescriptionBox As TextBox
    Friend WithEvents GBUpdate As GroupBox
    Friend WithEvents BtReturn As Button
    Friend WithEvents BtClean As Button
    Friend WithEvents BtSave As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GBTypeID As GroupBox
    Friend WithEvents TrainTypeBox As TextBox
    Friend WithEvents GBTypesOption As GroupBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents ListBoxTypes As ListBox
    Friend WithEvents GBTrainInfo As GroupBox
    Friend WithEvents TypesInfo As GroupBox
    Friend WithEvents GBUpdate2 As GroupBox
    Friend WithEvents Return2 As Button
    Friend WithEvents Delete2 As Button
    Friend WithEvents Save2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
