<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class snControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(snControl))
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.txtLat = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtCarr = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.CrearSinap = New System.Windows.Forms.Button()
        Me.txtCall = New System.Windows.Forms.TextBox()
        Me.EliminarSinap = New System.Windows.Forms.Button()
        Me.txtRef = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDir = New System.Windows.Forms.RichTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtSnY = New System.Windows.Forms.TextBox()
        Me.txtLong = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSnX = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCloseForm = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEditar.Location = New System.Drawing.Point(115, 345)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(79, 23)
        Me.btnEditar.TabIndex = 59
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'txtLat
        '
        Me.txtLat.BackColor = System.Drawing.Color.Black
        Me.txtLat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLat.ForeColor = System.Drawing.Color.Yellow
        Me.txtLat.Location = New System.Drawing.Point(97, 55)
        Me.txtLat.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtLat.Name = "txtLat"
        Me.txtLat.ReadOnly = True
        Me.txtLat.Size = New System.Drawing.Size(184, 26)
        Me.txtLat.TabIndex = 300
        Me.txtLat.Text = "6.2568953403654035"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(148, 231)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(77, 18)
        Me.Label30.TabIndex = 54
        Me.Label30.Text = "Carrera"
        '
        'txtCarr
        '
        Me.txtCarr.BackColor = System.Drawing.Color.Black
        Me.txtCarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarr.ForeColor = System.Drawing.Color.Yellow
        Me.txtCarr.Location = New System.Drawing.Point(233, 227)
        Me.txtCarr.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCarr.Name = "txtCarr"
        Me.txtCarr.Size = New System.Drawing.Size(68, 26)
        Me.txtCarr.TabIndex = 53
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(12, 231)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(50, 18)
        Me.Label31.TabIndex = 52
        Me.Label31.Text = "Calle"
        '
        'CrearSinap
        '
        Me.CrearSinap.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.CrearSinap.Enabled = False
        Me.CrearSinap.FlatAppearance.BorderSize = 0
        Me.CrearSinap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CrearSinap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CrearSinap.ForeColor = System.Drawing.Color.White
        Me.CrearSinap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CrearSinap.Location = New System.Drawing.Point(11, 345)
        Me.CrearSinap.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CrearSinap.Name = "CrearSinap"
        Me.CrearSinap.Size = New System.Drawing.Size(79, 23)
        Me.CrearSinap.TabIndex = 39
        Me.CrearSinap.Text = "Crear"
        Me.CrearSinap.UseVisualStyleBackColor = False
        '
        'txtCall
        '
        Me.txtCall.BackColor = System.Drawing.Color.Black
        Me.txtCall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCall.ForeColor = System.Drawing.Color.Yellow
        Me.txtCall.Location = New System.Drawing.Point(66, 227)
        Me.txtCall.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCall.Name = "txtCall"
        Me.txtCall.Size = New System.Drawing.Size(68, 26)
        Me.txtCall.TabIndex = 51
        '
        'EliminarSinap
        '
        Me.EliminarSinap.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.EliminarSinap.Enabled = False
        Me.EliminarSinap.FlatAppearance.BorderSize = 0
        Me.EliminarSinap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EliminarSinap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.EliminarSinap.ForeColor = System.Drawing.Color.White
        Me.EliminarSinap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.EliminarSinap.Location = New System.Drawing.Point(226, 345)
        Me.EliminarSinap.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.EliminarSinap.Name = "EliminarSinap"
        Me.EliminarSinap.Size = New System.Drawing.Size(79, 23)
        Me.EliminarSinap.TabIndex = 40
        Me.EliminarSinap.Text = "Borrar"
        Me.EliminarSinap.UseVisualStyleBackColor = False
        '
        'txtRef
        '
        Me.txtRef.BackColor = System.Drawing.Color.Black
        Me.txtRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRef.ForeColor = System.Drawing.Color.Yellow
        Me.txtRef.Location = New System.Drawing.Point(11, 5)
        Me.txtRef.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.ReadOnly = True
        Me.txtRef.Size = New System.Drawing.Size(91, 26)
        Me.txtRef.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(12, 267)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 18)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Direccion:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtDir)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.txtSnY)
        Me.Panel1.Controls.Add(Me.txtRef)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.txtCarr)
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.txtLong)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Controls.Add(Me.txtCall)
        Me.Panel1.Controls.Add(Me.txtLat)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CrearSinap)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtSnX)
        Me.Panel1.Controls.Add(Me.EliminarSinap)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnCloseForm)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 383)
        Me.Panel1.TabIndex = 214
        '
        'txtDir
        '
        Me.txtDir.BackColor = System.Drawing.Color.Black
        Me.txtDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDir.ForeColor = System.Drawing.Color.Yellow
        Me.txtDir.Location = New System.Drawing.Point(10, 288)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(295, 50)
        Me.txtDir.TabIndex = 301
        Me.txtDir.Text = ""
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(313, 6)
        Me.Panel3.TabIndex = 1
        '
        'txtSnY
        '
        Me.txtSnY.BackColor = System.Drawing.Color.Black
        Me.txtSnY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSnY.ForeColor = System.Drawing.Color.Yellow
        Me.txtSnY.Location = New System.Drawing.Point(206, 178)
        Me.txtSnY.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSnY.Name = "txtSnY"
        Me.txtSnY.Size = New System.Drawing.Size(54, 26)
        Me.txtSnY.TabIndex = 175
        Me.txtSnY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLong
        '
        Me.txtLong.BackColor = System.Drawing.Color.Black
        Me.txtLong.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtLong.ForeColor = System.Drawing.Color.Yellow
        Me.txtLong.Location = New System.Drawing.Point(97, 88)
        Me.txtLong.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtLong.Name = "txtLong"
        Me.txtLong.Size = New System.Drawing.Size(184, 26)
        Me.txtLong.TabIndex = 175
        Me.txtLong.Text = "-75.56089639663696"
        Me.txtLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(35, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 18)
        Me.Label10.TabIndex = 226
        Me.Label10.Text = "Long:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(123, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 18)
        Me.Label11.TabIndex = 228
        Me.Label11.Text = "SnY:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(35, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 225
        Me.Label3.Text = "Lat:"
        '
        'txtSnX
        '
        Me.txtSnX.BackColor = System.Drawing.Color.Black
        Me.txtSnX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSnX.ForeColor = System.Drawing.Color.Yellow
        Me.txtSnX.Location = New System.Drawing.Point(206, 134)
        Me.txtSnX.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSnX.Name = "txtSnX"
        Me.txtSnX.Size = New System.Drawing.Size(54, 26)
        Me.txtSnX.TabIndex = 174
        Me.txtSnX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(123, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 18)
        Me.Label12.TabIndex = 227
        Me.Label12.Text = "SnX:"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox4.Location = New System.Drawing.Point(51, 129)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(51, 77)
        Me.PictureBox4.TabIndex = 171
        Me.PictureBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(112, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Info del Semaforo"
        '
        'btnCloseForm
        '
        Me.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCloseForm.Font = New System.Drawing.Font("ROG Fonts", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCloseForm.Location = New System.Drawing.Point(284, 4)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.Size = New System.Drawing.Size(29, 30)
        Me.btnCloseForm.TabIndex = 0
        Me.btnCloseForm.Text = "X"
        Me.btnCloseForm.UseVisualStyleBackColor = False
        '
        'snControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(325, 393)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "snControl"
        Me.Text = "snControl"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEditar As Button
    Friend WithEvents txtLat As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtCarr As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents CrearSinap As Button
    Friend WithEvents txtCall As TextBox
    Friend WithEvents EliminarSinap As Button
    Friend WithEvents txtRef As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSnY As TextBox
    Friend WithEvents txtLong As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSnX As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCloseForm As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtDir As RichTextBox
End Class
