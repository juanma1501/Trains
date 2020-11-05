<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.Ranking_Button = New System.Windows.Forms.Button()
        Me.Products_Button = New System.Windows.Forms.Button()
        Me.Trains_Button = New System.Windows.Forms.Button()
        Me.Trips_Button = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ranking_Button
        '
        Me.Ranking_Button.BackgroundImage = Global.TrenesBBDD.My.Resources.Resources.rankings_fondo__2_
        Me.Ranking_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ranking_Button.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ranking_Button.ForeColor = System.Drawing.Color.Black
        Me.Ranking_Button.Location = New System.Drawing.Point(150, 583)
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
        Me.Products_Button.Location = New System.Drawing.Point(150, 484)
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
        Me.Trains_Button.Location = New System.Drawing.Point(150, 385)
        Me.Trains_Button.Name = "Trains_Button"
        Me.Trains_Button.Size = New System.Drawing.Size(354, 69)
        Me.Trains_Button.TabIndex = 2
        Me.Trains_Button.Text = "Trains"
        Me.Trains_Button.UseVisualStyleBackColor = True
        '
        'Trips_Button
        '
        Me.Trips_Button.BackgroundImage = Global.TrenesBBDD.My.Resources.Resources.trip_fondo
        Me.Trips_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Trips_Button.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Trips_Button.ForeColor = System.Drawing.Color.Black
        Me.Trips_Button.Location = New System.Drawing.Point(150, 282)
        Me.Trips_Button.Name = "Trips_Button"
        Me.Trips_Button.Size = New System.Drawing.Size(354, 69)
        Me.Trips_Button.TabIndex = 1
        Me.Trips_Button.Text = "Trips"
        Me.Trips_Button.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TrenesBBDD.My.Resources.Resources.f29e7f0d_c91d_4da8_8e43_cbb1b21c334d_200x200
        Me.PictureBox1.Location = New System.Drawing.Point(171, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(315, 273)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrenesBBDD.My.Resources.Resources.fondo_app_4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(686, 685)
        Me.Controls.Add(Me.Ranking_Button)
        Me.Controls.Add(Me.Products_Button)
        Me.Controls.Add(Me.Trains_Button)
        Me.Controls.Add(Me.Trips_Button)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainMenu"
        Me.Text = "JuJoEr"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Trips_Button As Button
    Friend WithEvents Trains_Button As Button
    Friend WithEvents Products_Button As Button
    Friend WithEvents Ranking_Button As Button
End Class
