<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connection_UI
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
    'Se puede update usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Accept_Button = New System.Windows.Forms.Button()
        Me.Path_Button = New System.Windows.Forms.Button()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.PathBox = New System.Windows.Forms.TextBox()
        Me.Continue_Button = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ofdPath = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Accept_Button
        '
        Me.Accept_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Accept_Button.Location = New System.Drawing.Point(55, 157)
        Me.Accept_Button.Name = "Accept_Button"
        Me.Accept_Button.Size = New System.Drawing.Size(75, 32)
        Me.Accept_Button.TabIndex = 1
        Me.Accept_Button.Text = "Accept"
        Me.Accept_Button.UseVisualStyleBackColor = True
        '
        'Path_Button
        '
        Me.Path_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Path_Button.Location = New System.Drawing.Point(55, 107)
        Me.Path_Button.Name = "Path_Button"
        Me.Path_Button.Size = New System.Drawing.Size(125, 44)
        Me.Path_Button.TabIndex = 2
        Me.Path_Button.Text = "Select from..."
        Me.Path_Button.UseVisualStyleBackColor = True
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(196, 270)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(0, 17)
        Me.StateLabel.TabIndex = 5
        '
        'PathBox
        '
        Me.PathBox.Location = New System.Drawing.Point(242, 118)
        Me.PathBox.Name = "PathBox"
        Me.PathBox.Size = New System.Drawing.Size(472, 22)
        Me.PathBox.TabIndex = 6
        '
        'Continue_Button
        '
        Me.Continue_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Continue_Button.Enabled = False
        Me.Continue_Button.Location = New System.Drawing.Point(643, 202)
        Me.Continue_Button.Name = "Continue_Button"
        Me.Continue_Button.Size = New System.Drawing.Size(108, 85)
        Me.Continue_Button.TabIndex = 7
        Me.Continue_Button.Text = "Go to App"
        Me.Continue_Button.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(276, 41)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(303, 22)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "INSERT A DATABASE FILE"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TrenesBBDD.My.Resources.Resources._1877811
        Me.PictureBox1.Location = New System.Drawing.Point(186, 107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ofdPath
        '
        Me.ofdPath.FileName = "OpenFileDialog1"
        '
        'Connection_UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(783, 312)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Continue_Button)
        Me.Controls.Add(Me.PathBox)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.Path_Button)
        Me.Controls.Add(Me.Accept_Button)
        Me.Name = "Connection_UI"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Accept_Button As Button
    Friend WithEvents Path_Button As Button
    Friend WithEvents StateLabel As Label
    Friend WithEvents PathBox As TextBox
    Friend WithEvents Continue_Button As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ofdPath As OpenFileDialog
End Class
