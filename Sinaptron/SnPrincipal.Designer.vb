<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SnPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SnPrincipal))
        Me.Conexion = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTiempo = New System.Windows.Forms.Timer(Me.components)
        Me.tmrIntermitencias = New System.Windows.Forms.Timer(Me.components)
        Me.tmrIntermAmarilla = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPuertoCom = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.picEstadoPort = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPosX1 = New System.Windows.Forms.TextBox()
        Me.txtPosX2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPosY0 = New System.Windows.Forms.TextBox()
        Me.txtPosY1 = New System.Windows.Forms.TextBox()
        Me.txtPosY2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPosX0 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTiempoRojo = New System.Windows.Forms.Button()
        Me.btnTiemposConsultar = New System.Windows.Forms.Button()
        Me.btnTiempoVerde = New System.Windows.Forms.Button()
        Me.btnTiempoAmarillo = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.nudLight = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.btnAmbar = New System.Windows.Forms.Button()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.picSemaforo = New System.Windows.Forms.PictureBox()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.txtAmbar = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnPrender = New System.Windows.Forms.Button()
        Me.btnApagar = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnPrecaucion = New System.Windows.Forms.Button()
        Me.btnPrecaucion2 = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnOffTest = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnSimular = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnTryIn = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnTryOut = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.groupBox27 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.pictureBox15 = New System.Windows.Forms.PictureBox()
        Me.pictureBox16 = New System.Windows.Forms.PictureBox()
        Me.pictureBox17 = New System.Windows.Forms.PictureBox()
        Me.pictureBox18 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBateriaConsulta = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSnY = New System.Windows.Forms.TextBox()
        Me.txtSnX = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.picBattery = New System.Windows.Forms.PictureBox()
        Me.txtNVPanel = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtNVBatt = New System.Windows.Forms.TextBox()
        Me.txtStatusE = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.MapaNodos = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.tmrEstadoBatería = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTiemposSemaforo = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRojo = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.picS7 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.picS9 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.picS8 = New System.Windows.Forms.PictureBox()
        Me.picS6 = New System.Windows.Forms.PictureBox()
        Me.picS5 = New System.Windows.Forms.PictureBox()
        Me.picS4 = New System.Windows.Forms.PictureBox()
        Me.picS2 = New System.Windows.Forms.PictureBox()
        Me.picS3 = New System.Windows.Forms.PictureBox()
        Me.picS1 = New System.Windows.Forms.PictureBox()
        Me.tmrSimulacion = New System.Windows.Forms.Timer(Me.components)
        Me.btnCambiosRemoto = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.picEstadoPort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picSemaforo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.groupBox27.SuspendLayout()
        CType(Me.pictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBattery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picS7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picS9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picS8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picS6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picS5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picS4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picS3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'tmrTiempo
        '
        Me.tmrTiempo.Enabled = True
        '
        'tmrIntermitencias
        '
        Me.tmrIntermitencias.Interval = 500
        '
        'tmrIntermAmarilla
        '
        Me.tmrIntermAmarilla.Interval = 500
        '
        'tmrPuertoCom
        '
        Me.tmrPuertoCom.Enabled = True
        Me.tmrPuertoCom.Interval = 1000
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.picEstadoPort)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.lblHora)
        Me.GroupBox3.Controls.Add(Me.lblFecha)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtPosX1)
        Me.GroupBox3.Controls.Add(Me.txtPosX2)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtPosY0)
        Me.GroupBox3.Controls.Add(Me.txtPosY1)
        Me.GroupBox3.Controls.Add(Me.txtPosY2)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtPosX0)
        Me.GroupBox3.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(315, 221)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Enviar Info"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(257, 199)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(14, 16)
        Me.Button3.TabIndex = 231
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'picEstadoPort
        '
        Me.picEstadoPort.BackColor = System.Drawing.Color.Red
        Me.picEstadoPort.Location = New System.Drawing.Point(257, 55)
        Me.picEstadoPort.Name = "picEstadoPort"
        Me.picEstadoPort.Size = New System.Drawing.Size(47, 40)
        Me.picEstadoPort.TabIndex = 120
        Me.picEstadoPort.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(253, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Estado"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(15, 30)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 71)
        Me.PictureBox2.TabIndex = 173
        Me.PictureBox2.TabStop = False
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.White
        Me.lblHora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHora.Location = New System.Drawing.Point(138, 77)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(68, 23)
        Me.lblHora.TabIndex = 147
        Me.lblHora.Text = "4:20:11"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFecha.Location = New System.Drawing.Point(138, 45)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(102, 23)
        Me.lblFecha.TabIndex = 146
        Me.lblFecha.Text = "3/03/2019"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(71, 77)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(52, 23)
        Me.Label34.TabIndex = 145
        Me.Label34.Text = "Hora:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label33.Location = New System.Drawing.Point(71, 45)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(61, 23)
        Me.Label33.TabIndex = 144
        Me.Label33.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(129, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "RUTA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(16, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "CENTRAL:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(9, 150)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = " Sn X     Sn Y"
        '
        'txtPosX1
        '
        Me.txtPosX1.BackColor = System.Drawing.Color.Black
        Me.txtPosX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPosX1.ForeColor = System.Drawing.Color.Yellow
        Me.txtPosX1.Location = New System.Drawing.Point(110, 172)
        Me.txtPosX1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPosX1.MaxLength = 4
        Me.txtPosX1.Name = "txtPosX1"
        Me.txtPosX1.Size = New System.Drawing.Size(47, 26)
        Me.txtPosX1.TabIndex = 109
        Me.txtPosX1.Text = "133"
        Me.txtPosX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPosX2
        '
        Me.txtPosX2.BackColor = System.Drawing.Color.Black
        Me.txtPosX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPosX2.ForeColor = System.Drawing.Color.Yellow
        Me.txtPosX2.Location = New System.Drawing.Point(213, 172)
        Me.txtPosX2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPosX2.MaxLength = 4
        Me.txtPosX2.Name = "txtPosX2"
        Me.txtPosX2.Size = New System.Drawing.Size(47, 26)
        Me.txtPosX2.TabIndex = 112
        Me.txtPosX2.Text = "133"
        Me.txtPosX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(222, 126)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "DESTINO:"
        '
        'txtPosY0
        '
        Me.txtPosY0.BackColor = System.Drawing.Color.Black
        Me.txtPosY0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPosY0.ForeColor = System.Drawing.Color.Yellow
        Me.txtPosY0.Location = New System.Drawing.Point(58, 173)
        Me.txtPosY0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPosY0.MaxLength = 4
        Me.txtPosY0.Name = "txtPosY0"
        Me.txtPosY0.Size = New System.Drawing.Size(47, 26)
        Me.txtPosY0.TabIndex = 119
        Me.txtPosY0.Text = "136"
        Me.txtPosY0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPosY1
        '
        Me.txtPosY1.BackColor = System.Drawing.Color.Black
        Me.txtPosY1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPosY1.ForeColor = System.Drawing.Color.Yellow
        Me.txtPosY1.Location = New System.Drawing.Point(160, 172)
        Me.txtPosY1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPosY1.MaxLength = 4
        Me.txtPosY1.Name = "txtPosY1"
        Me.txtPosY1.Size = New System.Drawing.Size(47, 26)
        Me.txtPosY1.TabIndex = 110
        Me.txtPosY1.Text = "136"
        Me.txtPosY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPosY2
        '
        Me.txtPosY2.BackColor = System.Drawing.Color.Black
        Me.txtPosY2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPosY2.ForeColor = System.Drawing.Color.Yellow
        Me.txtPosY2.Location = New System.Drawing.Point(263, 172)
        Me.txtPosY2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPosY2.MaxLength = 4
        Me.txtPosY2.Name = "txtPosY2"
        Me.txtPosY2.Size = New System.Drawing.Size(47, 26)
        Me.txtPosY2.TabIndex = 113
        Me.txtPosY2.Text = "136"
        Me.txtPosY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(210, 150)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 16)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = " Sn X    Sn Y"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(111, 150)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 16)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = " Sn X     Sn Y"
        '
        'txtPosX0
        '
        Me.txtPosX0.BackColor = System.Drawing.Color.Black
        Me.txtPosX0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPosX0.ForeColor = System.Drawing.Color.Yellow
        Me.txtPosX0.Location = New System.Drawing.Point(8, 173)
        Me.txtPosX0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPosX0.MaxLength = 4
        Me.txtPosX0.Name = "txtPosX0"
        Me.txtPosX0.Size = New System.Drawing.Size(47, 26)
        Me.txtPosX0.TabIndex = 118
        Me.txtPosX0.Text = "132"
        Me.txtPosX0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 251)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(315, 336)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.GroupBox9)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(23, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(288, 328)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Semaforo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTiempoRojo)
        Me.GroupBox1.Controls.Add(Me.btnTiemposConsultar)
        Me.GroupBox1.Controls.Add(Me.btnTiempoVerde)
        Me.GroupBox1.Controls.Add(Me.btnTiempoAmarillo)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(117, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 152)
        Me.GroupBox1.TabIndex = 180
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultar "
        '
        'btnTiempoRojo
        '
        Me.btnTiempoRojo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTiempoRojo.FlatAppearance.BorderSize = 0
        Me.btnTiempoRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTiempoRojo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTiempoRojo.ForeColor = System.Drawing.Color.White
        Me.btnTiempoRojo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnTiempoRojo.Location = New System.Drawing.Point(38, 21)
        Me.btnTiempoRojo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTiempoRojo.Name = "btnTiempoRojo"
        Me.btnTiempoRojo.Size = New System.Drawing.Size(78, 26)
        Me.btnTiempoRojo.TabIndex = 224
        Me.btnTiempoRojo.Text = "ROJO"
        Me.btnTiempoRojo.UseVisualStyleBackColor = False
        '
        'btnTiemposConsultar
        '
        Me.btnTiemposConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnTiemposConsultar.FlatAppearance.BorderSize = 0
        Me.btnTiemposConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTiemposConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTiemposConsultar.ForeColor = System.Drawing.Color.White
        Me.btnTiemposConsultar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnTiemposConsultar.Location = New System.Drawing.Point(38, 117)
        Me.btnTiemposConsultar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTiemposConsultar.Name = "btnTiemposConsultar"
        Me.btnTiemposConsultar.Size = New System.Drawing.Size(78, 31)
        Me.btnTiemposConsultar.TabIndex = 223
        Me.btnTiemposConsultar.Text = " TIEMPOS"
        Me.btnTiemposConsultar.UseVisualStyleBackColor = False
        Me.btnTiemposConsultar.Visible = False
        '
        'btnTiempoVerde
        '
        Me.btnTiempoVerde.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTiempoVerde.FlatAppearance.BorderSize = 0
        Me.btnTiempoVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTiempoVerde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTiempoVerde.ForeColor = System.Drawing.Color.White
        Me.btnTiempoVerde.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnTiempoVerde.Location = New System.Drawing.Point(38, 84)
        Me.btnTiempoVerde.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTiempoVerde.Name = "btnTiempoVerde"
        Me.btnTiempoVerde.Size = New System.Drawing.Size(78, 27)
        Me.btnTiempoVerde.TabIndex = 226
        Me.btnTiempoVerde.Text = "VERDE"
        Me.btnTiempoVerde.UseVisualStyleBackColor = False
        '
        'btnTiempoAmarillo
        '
        Me.btnTiempoAmarillo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTiempoAmarillo.FlatAppearance.BorderSize = 0
        Me.btnTiempoAmarillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTiempoAmarillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTiempoAmarillo.ForeColor = System.Drawing.Color.White
        Me.btnTiempoAmarillo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnTiempoAmarillo.Location = New System.Drawing.Point(38, 53)
        Me.btnTiempoAmarillo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTiempoAmarillo.Name = "btnTiempoAmarillo"
        Me.btnTiempoAmarillo.Size = New System.Drawing.Size(78, 25)
        Me.btnTiempoAmarillo.TabIndex = 225
        Me.btnTiempoAmarillo.Text = "AMARILLO"
        Me.btnTiempoAmarillo.UseVisualStyleBackColor = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.PictureBox5)
        Me.GroupBox9.Controls.Add(Me.nudLight)
        Me.GroupBox9.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.White
        Me.GroupBox9.Location = New System.Drawing.Point(6, 164)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(105, 55)
        Me.GroupBox9.TabIndex = 180
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Dimerización"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.ErrorImage = Nothing
        Me.PictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox5.Location = New System.Drawing.Point(12, 19)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(31, 27)
        Me.PictureBox5.TabIndex = 231
        Me.PictureBox5.TabStop = False
        '
        'nudLight
        '
        Me.nudLight.BackColor = System.Drawing.Color.Black
        Me.nudLight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudLight.ForeColor = System.Drawing.Color.Yellow
        Me.nudLight.Location = New System.Drawing.Point(48, 20)
        Me.nudLight.Name = "nudLight"
        Me.nudLight.Size = New System.Drawing.Size(38, 26)
        Me.nudLight.TabIndex = 181
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.btnGreen)
        Me.GroupBox2.Controls.Add(Me.btnAmbar)
        Me.GroupBox2.Controls.Add(Me.btnRed)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.picSemaforo)
        Me.GroupBox2.Controls.Add(Me.txtRed)
        Me.GroupBox2.Controls.Add(Me.txtGreen)
        Me.GroupBox2.Controls.Add(Me.txtAmbar)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(117, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 149)
        Me.GroupBox2.TabIndex = 166
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Configurar Tiempos"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(61, 130)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 13)
        Me.Label14.TabIndex = 230
        Me.Label14.Text = "Y:"
        Me.Label14.Visible = False
        '
        'btnGreen
        '
        Me.btnGreen.BackColor = System.Drawing.Color.Transparent
        Me.btnGreen.BackgroundImage = CType(resources.GetObject("btnGreen.BackgroundImage"), System.Drawing.Image)
        Me.btnGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGreen.FlatAppearance.BorderSize = 0
        Me.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnGreen.ForeColor = System.Drawing.Color.White
        Me.btnGreen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGreen.Location = New System.Drawing.Point(121, 87)
        Me.btnGreen.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(22, 22)
        Me.btnGreen.TabIndex = 172
        Me.btnGreen.UseVisualStyleBackColor = False
        '
        'btnAmbar
        '
        Me.btnAmbar.BackColor = System.Drawing.Color.Transparent
        Me.btnAmbar.BackgroundImage = CType(resources.GetObject("btnAmbar.BackgroundImage"), System.Drawing.Image)
        Me.btnAmbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAmbar.FlatAppearance.BorderSize = 0
        Me.btnAmbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAmbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnAmbar.ForeColor = System.Drawing.Color.White
        Me.btnAmbar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAmbar.Location = New System.Drawing.Point(121, 59)
        Me.btnAmbar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAmbar.Name = "btnAmbar"
        Me.btnAmbar.Size = New System.Drawing.Size(22, 22)
        Me.btnAmbar.TabIndex = 171
        Me.btnAmbar.UseVisualStyleBackColor = False
        '
        'btnRed
        '
        Me.btnRed.BackColor = System.Drawing.Color.Transparent
        Me.btnRed.BackgroundImage = CType(resources.GetObject("btnRed.BackgroundImage"), System.Drawing.Image)
        Me.btnRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRed.FlatAppearance.BorderSize = 0
        Me.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnRed.ForeColor = System.Drawing.Color.White
        Me.btnRed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRed.Location = New System.Drawing.Point(121, 31)
        Me.btnRed.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(22, 22)
        Me.btnRed.TabIndex = 170
        Me.btnRed.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(61, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 13)
        Me.Label13.TabIndex = 229
        Me.Label13.Text = "X:"
        Me.Label13.Visible = False
        '
        'picSemaforo
        '
        Me.picSemaforo.BackgroundImage = CType(resources.GetObject("picSemaforo.BackgroundImage"), System.Drawing.Image)
        Me.picSemaforo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSemaforo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picSemaforo.Location = New System.Drawing.Point(5, 21)
        Me.picSemaforo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picSemaforo.Name = "picSemaforo"
        Me.picSemaforo.Size = New System.Drawing.Size(51, 97)
        Me.picSemaforo.TabIndex = 169
        Me.picSemaforo.TabStop = False
        '
        'txtRed
        '
        Me.txtRed.BackColor = System.Drawing.Color.Black
        Me.txtRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRed.ForeColor = System.Drawing.Color.Red
        Me.txtRed.Location = New System.Drawing.Point(61, 31)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(55, 22)
        Me.txtRed.TabIndex = 168
        Me.txtRed.Text = "0"
        Me.txtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGreen
        '
        Me.txtGreen.BackColor = System.Drawing.Color.Black
        Me.txtGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGreen.ForeColor = System.Drawing.Color.Lime
        Me.txtGreen.Location = New System.Drawing.Point(61, 87)
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(55, 22)
        Me.txtGreen.TabIndex = 167
        Me.txtGreen.Text = "0"
        Me.txtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAmbar
        '
        Me.txtAmbar.BackColor = System.Drawing.Color.Black
        Me.txtAmbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmbar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtAmbar.Location = New System.Drawing.Point(61, 59)
        Me.txtAmbar.Name = "txtAmbar"
        Me.txtAmbar.Size = New System.Drawing.Size(55, 22)
        Me.txtAmbar.TabIndex = 166
        Me.txtAmbar.Text = "0"
        Me.txtAmbar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnPrender)
        Me.GroupBox7.Controls.Add(Me.btnApagar)
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        Me.GroupBox7.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(105, 149)
        Me.GroupBox7.TabIndex = 179
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Semaforo"
        '
        'btnPrender
        '
        Me.btnPrender.BackColor = System.Drawing.Color.Transparent
        Me.btnPrender.BackgroundImage = CType(resources.GetObject("btnPrender.BackgroundImage"), System.Drawing.Image)
        Me.btnPrender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrender.FlatAppearance.BorderSize = 0
        Me.btnPrender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrender.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrender.ForeColor = System.Drawing.Color.Black
        Me.btnPrender.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrender.Location = New System.Drawing.Point(27, 44)
        Me.btnPrender.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnPrender.Name = "btnPrender"
        Me.btnPrender.Size = New System.Drawing.Size(37, 37)
        Me.btnPrender.TabIndex = 176
        Me.btnPrender.UseVisualStyleBackColor = False
        '
        'btnApagar
        '
        Me.btnApagar.BackColor = System.Drawing.Color.Transparent
        Me.btnApagar.BackgroundImage = CType(resources.GetObject("btnApagar.BackgroundImage"), System.Drawing.Image)
        Me.btnApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnApagar.FlatAppearance.BorderSize = 0
        Me.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApagar.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApagar.ForeColor = System.Drawing.Color.Black
        Me.btnApagar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnApagar.Location = New System.Drawing.Point(29, 87)
        Me.btnApagar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Size = New System.Drawing.Size(35, 37)
        Me.btnApagar.TabIndex = 177
        Me.btnApagar.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnPrecaucion)
        Me.GroupBox6.Controls.Add(Me.btnPrecaucion2)
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(6, 217)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(105, 97)
        Me.GroupBox6.TabIndex = 178
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Intermitencia"
        '
        'btnPrecaucion
        '
        Me.btnPrecaucion.BackColor = System.Drawing.Color.Red
        Me.btnPrecaucion.FlatAppearance.BorderSize = 0
        Me.btnPrecaucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrecaucion.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrecaucion.ForeColor = System.Drawing.Color.White
        Me.btnPrecaucion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrecaucion.Location = New System.Drawing.Point(13, 21)
        Me.btnPrecaucion.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnPrecaucion.Name = "btnPrecaucion"
        Me.btnPrecaucion.Size = New System.Drawing.Size(66, 27)
        Me.btnPrecaucion.TabIndex = 175
        Me.btnPrecaucion.Text = "ROJO"
        Me.btnPrecaucion.UseVisualStyleBackColor = False
        '
        'btnPrecaucion2
        '
        Me.btnPrecaucion2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrecaucion2.FlatAppearance.BorderSize = 0
        Me.btnPrecaucion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrecaucion2.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrecaucion2.ForeColor = System.Drawing.Color.White
        Me.btnPrecaucion2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrecaucion2.Location = New System.Drawing.Point(13, 58)
        Me.btnPrecaucion2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnPrecaucion2.Name = "btnPrecaucion2"
        Me.btnPrecaucion2.Size = New System.Drawing.Size(66, 27)
        Me.btnPrecaucion2.TabIndex = 178
        Me.btnPrecaucion2.Text = "AMARILLO"
        Me.btnPrecaucion2.UseVisualStyleBackColor = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.GroupBox8)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.btnSimular)
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(23, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(288, 328)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Pruebas"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btnOffTest)
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(43, 218)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(204, 83)
        Me.GroupBox8.TabIndex = 137
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Prueba"
        '
        'btnOffTest
        '
        Me.btnOffTest.BackColor = System.Drawing.Color.Red
        Me.btnOffTest.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOffTest.Location = New System.Drawing.Point(25, 20)
        Me.btnOffTest.Name = "btnOffTest"
        Me.btnOffTest.Size = New System.Drawing.Size(159, 43)
        Me.btnOffTest.TabIndex = 134
        Me.btnOffTest.Text = "APAGAR PRUEBA"
        Me.btnOffTest.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(3, 304)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 15)
        Me.Label16.TabIndex = 225
        Me.Label16.Text = "6.1914201"
        Me.Label16.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(60, 306)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 15)
        Me.Label15.TabIndex = 224
        Me.Label15.Text = "-75.5770031"
        Me.Label15.Visible = False
        '
        'btnSimular
        '
        Me.btnSimular.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSimular.FlatAppearance.BorderSize = 0
        Me.btnSimular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimular.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimular.ForeColor = System.Drawing.Color.Black
        Me.btnSimular.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSimular.Location = New System.Drawing.Point(116, 301)
        Me.btnSimular.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSimular.Name = "btnSimular"
        Me.btnSimular.Size = New System.Drawing.Size(131, 27)
        Me.btnSimular.TabIndex = 178
        Me.btnSimular.Text = "SIMULAR"
        Me.btnSimular.UseVisualStyleBackColor = False
        Me.btnSimular.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnTryIn)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(43, 121)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(204, 79)
        Me.GroupBox5.TabIndex = 136
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Sensores"
        '
        'btnTryIn
        '
        Me.btnTryIn.BackColor = System.Drawing.Color.LimeGreen
        Me.btnTryIn.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTryIn.Location = New System.Drawing.Point(25, 20)
        Me.btnTryIn.Name = "btnTryIn"
        Me.btnTryIn.Size = New System.Drawing.Size(159, 42)
        Me.btnTryIn.TabIndex = 132
        Me.btnTryIn.Text = "PROBAR ENTRADAS"
        Me.btnTryIn.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnTryOut)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(43, 23)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(204, 80)
        Me.GroupBox4.TabIndex = 135
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opticas"
        '
        'btnTryOut
        '
        Me.btnTryOut.BackColor = System.Drawing.Color.LimeGreen
        Me.btnTryOut.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTryOut.Location = New System.Drawing.Point(25, 20)
        Me.btnTryOut.Name = "btnTryOut"
        Me.btnTryOut.Size = New System.Drawing.Size(159, 44)
        Me.btnTryOut.TabIndex = 133
        Me.btnTryOut.Text = "PROBAR SALIDAS"
        Me.btnTryOut.UseVisualStyleBackColor = False
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TabPage6.Controls.Add(Me.TabControl2)
        Me.TabPage6.Location = New System.Drawing.Point(23, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(288, 328)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Sinaptron"
        '
        'TabControl2
        '
        Me.TabControl2.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Location = New System.Drawing.Point(6, 3)
        Me.TabControl2.Multiline = True
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(282, 496)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage7.Controls.Add(Me.Label19)
        Me.TabPage7.Controls.Add(Me.groupBox27)
        Me.TabPage7.Controls.Add(Me.Label12)
        Me.TabPage7.Controls.Add(Me.Label9)
        Me.TabPage7.Controls.Add(Me.btnBateriaConsulta)
        Me.TabPage7.Controls.Add(Me.Label22)
        Me.TabPage7.Controls.Add(Me.txtSnY)
        Me.TabPage7.Controls.Add(Me.txtSnX)
        Me.TabPage7.Controls.Add(Me.Label23)
        Me.TabPage7.Controls.Add(Me.picBattery)
        Me.TabPage7.Controls.Add(Me.txtNVPanel)
        Me.TabPage7.Controls.Add(Me.PictureBox3)
        Me.TabPage7.Controls.Add(Me.txtNVBatt)
        Me.TabPage7.Controls.Add(Me.txtStatusE)
        Me.TabPage7.Controls.Add(Me.PictureBox6)
        Me.TabPage7.Location = New System.Drawing.Point(23, 4)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(255, 488)
        Me.TabPage7.TabIndex = 0
        Me.TabPage7.Text = "Batería"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(155, 196)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 241
        Me.Label19.Text = "Energía"
        '
        'groupBox27
        '
        Me.groupBox27.Controls.Add(Me.Label3)
        Me.groupBox27.Controls.Add(Me.label10)
        Me.groupBox27.Controls.Add(Me.label11)
        Me.groupBox27.Controls.Add(Me.label18)
        Me.groupBox27.Controls.Add(Me.pictureBox15)
        Me.groupBox27.Controls.Add(Me.pictureBox16)
        Me.groupBox27.Controls.Add(Me.pictureBox17)
        Me.groupBox27.Controls.Add(Me.pictureBox18)
        Me.groupBox27.ForeColor = System.Drawing.Color.White
        Me.groupBox27.Location = New System.Drawing.Point(9, 71)
        Me.groupBox27.Name = "groupBox27"
        Me.groupBox27.Size = New System.Drawing.Size(122, 196)
        Me.groupBox27.TabIndex = 234
        Me.groupBox27.TabStop = False
        Me.groupBox27.Text = "Nivel de energia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 238
        Me.Label3.Text = "MALO"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.White
        Me.label10.Location = New System.Drawing.Point(37, 68)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(65, 13)
        Me.label10.TabIndex = 237
        Me.label10.Text = "REGULAR"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.White
        Me.label11.Location = New System.Drawing.Point(37, 108)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(50, 13)
        Me.label11.TabIndex = 236
        Me.label11.Text = "BUENO"
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label18.ForeColor = System.Drawing.Color.White
        Me.label18.Location = New System.Drawing.Point(37, 30)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(79, 13)
        Me.label18.TabIndex = 231
        Me.label18.Text = "EXCELENTE"
        '
        'pictureBox15
        '
        Me.pictureBox15.BackColor = System.Drawing.Color.Red
        Me.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox15.ErrorImage = Nothing
        Me.pictureBox15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pictureBox15.Location = New System.Drawing.Point(12, 150)
        Me.pictureBox15.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pictureBox15.Name = "pictureBox15"
        Me.pictureBox15.Size = New System.Drawing.Size(14, 14)
        Me.pictureBox15.TabIndex = 235
        Me.pictureBox15.TabStop = False
        '
        'pictureBox16
        '
        Me.pictureBox16.BackColor = System.Drawing.Color.Yellow
        Me.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox16.ErrorImage = Nothing
        Me.pictureBox16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pictureBox16.Location = New System.Drawing.Point(12, 68)
        Me.pictureBox16.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pictureBox16.Name = "pictureBox16"
        Me.pictureBox16.Size = New System.Drawing.Size(14, 14)
        Me.pictureBox16.TabIndex = 234
        Me.pictureBox16.TabStop = False
        '
        'pictureBox17
        '
        Me.pictureBox17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox17.ErrorImage = Nothing
        Me.pictureBox17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pictureBox17.Location = New System.Drawing.Point(12, 108)
        Me.pictureBox17.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pictureBox17.Name = "pictureBox17"
        Me.pictureBox17.Size = New System.Drawing.Size(14, 14)
        Me.pictureBox17.TabIndex = 233
        Me.pictureBox17.TabStop = False
        '
        'pictureBox18
        '
        Me.pictureBox18.BackColor = System.Drawing.Color.Lime
        Me.pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox18.ErrorImage = Nothing
        Me.pictureBox18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pictureBox18.Location = New System.Drawing.Point(12, 30)
        Me.pictureBox18.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pictureBox18.Name = "pictureBox18"
        Me.pictureBox18.Size = New System.Drawing.Size(14, 14)
        Me.pictureBox18.TabIndex = 232
        Me.pictureBox18.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(160, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 240
        Me.Label12.Text = "Panel"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(158, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 239
        Me.Label9.Text = "Batería"
        '
        'btnBateriaConsulta
        '
        Me.btnBateriaConsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnBateriaConsulta.FlatAppearance.BorderSize = 0
        Me.btnBateriaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBateriaConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBateriaConsulta.ForeColor = System.Drawing.Color.White
        Me.btnBateriaConsulta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBateriaConsulta.Location = New System.Drawing.Point(21, 283)
        Me.btnBateriaConsulta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBateriaConsulta.Name = "btnBateriaConsulta"
        Me.btnBateriaConsulta.Size = New System.Drawing.Size(214, 25)
        Me.btnBateriaConsulta.TabIndex = 222
        Me.btnBateriaConsulta.Text = "CONSULTAR"
        Me.btnBateriaConsulta.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("ROG Fonts", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(5, 13)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 19)
        Me.Label22.TabIndex = 218
        Me.Label22.Text = "SnX:"
        '
        'txtSnY
        '
        Me.txtSnY.BackColor = System.Drawing.Color.Black
        Me.txtSnY.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSnY.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtSnY.Location = New System.Drawing.Point(190, 13)
        Me.txtSnY.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSnY.Name = "txtSnY"
        Me.txtSnY.Size = New System.Drawing.Size(60, 29)
        Me.txtSnY.TabIndex = 214
        Me.txtSnY.Text = "00"
        Me.txtSnY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSnX
        '
        Me.txtSnX.BackColor = System.Drawing.Color.Black
        Me.txtSnX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSnX.ForeColor = System.Drawing.Color.BlueViolet
        Me.txtSnX.Location = New System.Drawing.Point(126, 13)
        Me.txtSnX.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSnX.Name = "txtSnX"
        Me.txtSnX.Size = New System.Drawing.Size(60, 29)
        Me.txtSnX.TabIndex = 215
        Me.txtSnX.Text = "00"
        Me.txtSnX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("ROG Fonts", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(66, 13)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 19)
        Me.Label23.TabIndex = 219
        Me.Label23.Text = "SnY:"
        '
        'picBattery
        '
        Me.picBattery.BackgroundImage = CType(resources.GetObject("picBattery.BackgroundImage"), System.Drawing.Image)
        Me.picBattery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBattery.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picBattery.Location = New System.Drawing.Point(145, 84)
        Me.picBattery.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picBattery.Name = "picBattery"
        Me.picBattery.Size = New System.Drawing.Size(34, 34)
        Me.picBattery.TabIndex = 206
        Me.picBattery.TabStop = False
        '
        'txtNVPanel
        '
        Me.txtNVPanel.BackColor = System.Drawing.Color.Black
        Me.txtNVPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNVPanel.ForeColor = System.Drawing.Color.Cyan
        Me.txtNVPanel.Location = New System.Drawing.Point(190, 155)
        Me.txtNVPanel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNVPanel.Name = "txtNVPanel"
        Me.txtNVPanel.Size = New System.Drawing.Size(57, 30)
        Me.txtNVPanel.TabIndex = 205
        Me.txtNVPanel.Text = "00"
        Me.txtNVPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox3.Location = New System.Drawing.Point(145, 151)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox3.TabIndex = 207
        Me.PictureBox3.TabStop = False
        '
        'txtNVBatt
        '
        Me.txtNVBatt.BackColor = System.Drawing.Color.Black
        Me.txtNVBatt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNVBatt.ForeColor = System.Drawing.Color.Cyan
        Me.txtNVBatt.Location = New System.Drawing.Point(187, 89)
        Me.txtNVBatt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNVBatt.Name = "txtNVBatt"
        Me.txtNVBatt.Size = New System.Drawing.Size(60, 30)
        Me.txtNVBatt.TabIndex = 202
        Me.txtNVBatt.Text = "00"
        Me.txtNVBatt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStatusE
        '
        Me.txtStatusE.BackColor = System.Drawing.Color.Black
        Me.txtStatusE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatusE.ForeColor = System.Drawing.Color.Cyan
        Me.txtStatusE.Location = New System.Drawing.Point(188, 228)
        Me.txtStatusE.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtStatusE.Name = "txtStatusE"
        Me.txtStatusE.Size = New System.Drawing.Size(59, 30)
        Me.txtStatusE.TabIndex = 210
        Me.txtStatusE.Text = "00"
        Me.txtStatusE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox6.Location = New System.Drawing.Point(145, 224)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox6.TabIndex = 211
        Me.PictureBox6.TabStop = False
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.GroupBox10)
        Me.TabPage5.Location = New System.Drawing.Point(23, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(288, 328)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "Verificaciones"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.MapaNodos)
        Me.GroupBox10.ForeColor = System.Drawing.Color.White
        Me.GroupBox10.Location = New System.Drawing.Point(44, 35)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(204, 80)
        Me.GroupBox10.TabIndex = 136
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Mapa de nodos"
        '
        'MapaNodos
        '
        Me.MapaNodos.BackColor = System.Drawing.Color.LimeGreen
        Me.MapaNodos.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MapaNodos.Location = New System.Drawing.Point(25, 20)
        Me.MapaNodos.Name = "MapaNodos"
        Me.MapaNodos.Size = New System.Drawing.Size(159, 44)
        Me.MapaNodos.TabIndex = 133
        Me.MapaNodos.Text = "Visualizar"
        Me.MapaNodos.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLimpiar.Location = New System.Drawing.Point(1188, 682)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(151, 40)
        Me.btnLimpiar.TabIndex = 209
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.Black
        Me.RichTextBox2.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.Yellow
        Me.RichTextBox2.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(1149, 80)
        Me.RichTextBox2.TabIndex = 210
        Me.RichTextBox2.Text = ""
        '
        'tmrEstadoBatería
        '
        Me.tmrEstadoBatería.Interval = 500
        '
        'tmrTiemposSemaforo
        '
        Me.tmrTiemposSemaforo.Interval = 1000
        '
        'tmrRojo
        '
        Me.tmrRojo.Interval = 500
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage1)
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Location = New System.Drawing.Point(12, 610)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1170, 112)
        Me.TabControl3.TabIndex = 214
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.RichTextBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1162, 86)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Acciones"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.RichTextBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1162, 86)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Eventos"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Black
        Me.RichTextBox1.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Yellow
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1208, 80)
        Me.RichTextBox1.TabIndex = 211
        Me.RichTextBox1.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TextBox17)
        Me.Panel1.Controls.Add(Me.TextBox18)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.TextBox15)
        Me.Panel1.Controls.Add(Me.TextBox16)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.TextBox13)
        Me.Panel1.Controls.Add(Me.TextBox14)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.TextBox11)
        Me.Panel1.Controls.Add(Me.TextBox12)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.TextBox9)
        Me.Panel1.Controls.Add(Me.TextBox10)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.TextBox8)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.picS7)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.picS9)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.picS8)
        Me.Panel1.Controls.Add(Me.picS6)
        Me.Panel1.Controls.Add(Me.picS5)
        Me.Panel1.Controls.Add(Me.picS4)
        Me.Panel1.Controls.Add(Me.picS2)
        Me.Panel1.Controls.Add(Me.picS3)
        Me.Panel1.Controls.Add(Me.picS1)
        Me.Panel1.Location = New System.Drawing.Point(347, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(982, 569)
        Me.Panel1.TabIndex = 215
        '
        'TextBox17
        '
        Me.TextBox17.BackColor = System.Drawing.Color.Black
        Me.TextBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox17.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox17.Location = New System.Drawing.Point(791, 503)
        Me.TextBox17.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox17.MaxLength = 4
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(47, 26)
        Me.TextBox17.TabIndex = 261
        Me.TextBox17.Text = "000"
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox17.Visible = False
        '
        'TextBox18
        '
        Me.TextBox18.BackColor = System.Drawing.Color.Black
        Me.TextBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox18.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox18.Location = New System.Drawing.Point(841, 503)
        Me.TextBox18.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox18.MaxLength = 4
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(47, 26)
        Me.TextBox18.TabIndex = 262
        Me.TextBox18.Text = "000"
        Me.TextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox18.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(792, 481)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(95, 16)
        Me.Label29.TabIndex = 263
        Me.Label29.Text = " Sn X     Sn Y"
        Me.Label29.Visible = False
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.Color.Black
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox15.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox15.Location = New System.Drawing.Point(459, 503)
        Me.TextBox15.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox15.MaxLength = 4
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(47, 26)
        Me.TextBox15.TabIndex = 258
        Me.TextBox15.Text = "000"
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox15.Visible = False
        '
        'TextBox16
        '
        Me.TextBox16.BackColor = System.Drawing.Color.Black
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox16.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox16.Location = New System.Drawing.Point(509, 503)
        Me.TextBox16.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox16.MaxLength = 4
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(47, 26)
        Me.TextBox16.TabIndex = 259
        Me.TextBox16.Text = "000"
        Me.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox16.Visible = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(460, 481)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(95, 16)
        Me.Label28.TabIndex = 260
        Me.Label28.Text = " Sn X     Sn Y"
        Me.Label28.Visible = False
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.Black
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox13.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox13.Location = New System.Drawing.Point(132, 503)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox13.MaxLength = 4
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(47, 26)
        Me.TextBox13.TabIndex = 255
        Me.TextBox13.Text = "000"
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox13.Visible = False
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.Black
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox14.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox14.Location = New System.Drawing.Point(182, 503)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox14.MaxLength = 4
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(47, 26)
        Me.TextBox14.TabIndex = 256
        Me.TextBox14.Text = "000"
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox14.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label27.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label27.Location = New System.Drawing.Point(133, 481)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(95, 16)
        Me.Label27.TabIndex = 257
        Me.Label27.Text = " Sn X     Sn Y"
        Me.Label27.Visible = False
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.Black
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox11.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox11.Location = New System.Drawing.Point(788, 311)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox11.MaxLength = 4
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(47, 26)
        Me.TextBox11.TabIndex = 252
        Me.TextBox11.Text = "000"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox11.Visible = False
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.Black
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox12.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox12.Location = New System.Drawing.Point(838, 311)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox12.MaxLength = 4
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(47, 26)
        Me.TextBox12.TabIndex = 253
        Me.TextBox12.Text = "000"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox12.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(789, 289)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(95, 16)
        Me.Label26.TabIndex = 254
        Me.Label26.Text = " Sn X     Sn Y"
        Me.Label26.Visible = False
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.Black
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox9.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox9.Location = New System.Drawing.Point(460, 311)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox9.MaxLength = 4
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(47, 26)
        Me.TextBox9.TabIndex = 249
        Me.TextBox9.Text = "000"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox9.Visible = False
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.Black
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox10.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox10.Location = New System.Drawing.Point(510, 311)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox10.MaxLength = 4
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(47, 26)
        Me.TextBox10.TabIndex = 250
        Me.TextBox10.Text = "000"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox10.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(461, 289)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(95, 16)
        Me.Label25.TabIndex = 251
        Me.Label25.Text = " Sn X     Sn Y"
        Me.Label25.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Black
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox7.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox7.Location = New System.Drawing.Point(131, 311)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox7.MaxLength = 4
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(47, 26)
        Me.TextBox7.TabIndex = 246
        Me.TextBox7.Text = "000"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox7.Visible = False
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Black
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox8.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox8.Location = New System.Drawing.Point(181, 311)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox8.MaxLength = 4
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(47, 26)
        Me.TextBox8.TabIndex = 247
        Me.TextBox8.Text = "000"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox8.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(132, 289)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(95, 16)
        Me.Label24.TabIndex = 248
        Me.Label24.Text = " Sn X     Sn Y"
        Me.Label24.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Black
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox5.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox5.Location = New System.Drawing.Point(788, 119)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox5.MaxLength = 4
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(47, 26)
        Me.TextBox5.TabIndex = 243
        Me.TextBox5.Text = "000"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox5.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Black
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox6.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox6.Location = New System.Drawing.Point(838, 119)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox6.MaxLength = 4
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(47, 26)
        Me.TextBox6.TabIndex = 244
        Me.TextBox6.Text = "000"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox6.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(789, 97)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(95, 16)
        Me.Label21.TabIndex = 245
        Me.Label21.Text = " Sn X     Sn Y"
        Me.Label21.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Black
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox3.Location = New System.Drawing.Point(459, 119)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox3.MaxLength = 4
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(47, 26)
        Me.TextBox3.TabIndex = 240
        Me.TextBox3.Text = "000"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox3.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Black
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox4.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox4.Location = New System.Drawing.Point(509, 119)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox4.MaxLength = 4
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(47, 26)
        Me.TextBox4.TabIndex = 241
        Me.TextBox4.Text = "000"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox4.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(460, 97)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(95, 16)
        Me.Label20.TabIndex = 242
        Me.Label20.Text = " Sn X     Sn Y"
        Me.Label20.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox1.Location = New System.Drawing.Point(130, 119)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox1.MaxLength = 4
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(47, 26)
        Me.TextBox1.TabIndex = 232
        Me.TextBox1.Text = "000"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox1.Visible = False
        '
        'picS7
        '
        Me.picS7.BackgroundImage = CType(resources.GetObject("picS7.BackgroundImage"), System.Drawing.Image)
        Me.picS7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picS7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picS7.Location = New System.Drawing.Point(76, 431)
        Me.picS7.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picS7.Name = "picS7"
        Me.picS7.Size = New System.Drawing.Size(51, 97)
        Me.picS7.TabIndex = 239
        Me.picS7.TabStop = False
        Me.picS7.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox2.Location = New System.Drawing.Point(180, 119)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox2.MaxLength = 4
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(47, 26)
        Me.TextBox2.TabIndex = 233
        Me.TextBox2.Text = "000"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox2.Visible = False
        '
        'picS9
        '
        Me.picS9.BackgroundImage = CType(resources.GetObject("picS9.BackgroundImage"), System.Drawing.Image)
        Me.picS9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picS9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picS9.Location = New System.Drawing.Point(734, 431)
        Me.picS9.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picS9.Name = "picS9"
        Me.picS9.Size = New System.Drawing.Size(51, 97)
        Me.picS9.TabIndex = 238
        Me.picS9.TabStop = False
        Me.picS9.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(131, 97)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 16)
        Me.Label17.TabIndex = 234
        Me.Label17.Text = " Sn X     Sn Y"
        Me.Label17.Visible = False
        '
        'picS8
        '
        Me.picS8.BackgroundImage = CType(resources.GetObject("picS8.BackgroundImage"), System.Drawing.Image)
        Me.picS8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picS8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picS8.Location = New System.Drawing.Point(405, 431)
        Me.picS8.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picS8.Name = "picS8"
        Me.picS8.Size = New System.Drawing.Size(51, 97)
        Me.picS8.TabIndex = 237
        Me.picS8.TabStop = False
        Me.picS8.Visible = False
        '
        'picS6
        '
        Me.picS6.BackgroundImage = CType(resources.GetObject("picS6.BackgroundImage"), System.Drawing.Image)
        Me.picS6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picS6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picS6.Location = New System.Drawing.Point(734, 240)
        Me.picS6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picS6.Name = "picS6"
        Me.picS6.Size = New System.Drawing.Size(51, 97)
        Me.picS6.TabIndex = 236
        Me.picS6.TabStop = False
        Me.picS6.Visible = False
        '
        'picS5
        '
        Me.picS5.BackgroundImage = CType(resources.GetObject("picS5.BackgroundImage"), System.Drawing.Image)
        Me.picS5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picS5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picS5.Location = New System.Drawing.Point(76, 240)
        Me.picS5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picS5.Name = "picS5"
        Me.picS5.Size = New System.Drawing.Size(51, 97)
        Me.picS5.TabIndex = 235
        Me.picS5.TabStop = False
        Me.picS5.Visible = False
        '
        'picS4
        '
        Me.picS4.BackgroundImage = CType(resources.GetObject("picS4.BackgroundImage"), System.Drawing.Image)
        Me.picS4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picS4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picS4.Location = New System.Drawing.Point(734, 49)
        Me.picS4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picS4.Name = "picS4"
        Me.picS4.Size = New System.Drawing.Size(51, 97)
        Me.picS4.TabIndex = 234
        Me.picS4.TabStop = False
        Me.picS4.Visible = False
        '
        'picS2
        '
        Me.picS2.BackgroundImage = CType(resources.GetObject("picS2.BackgroundImage"), System.Drawing.Image)
        Me.picS2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picS2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picS2.Location = New System.Drawing.Point(76, 49)
        Me.picS2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picS2.Name = "picS2"
        Me.picS2.Size = New System.Drawing.Size(51, 97)
        Me.picS2.TabIndex = 233
        Me.picS2.TabStop = False
        Me.picS2.Visible = False
        '
        'picS3
        '
        Me.picS3.BackgroundImage = CType(resources.GetObject("picS3.BackgroundImage"), System.Drawing.Image)
        Me.picS3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picS3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picS3.Location = New System.Drawing.Point(405, 49)
        Me.picS3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picS3.Name = "picS3"
        Me.picS3.Size = New System.Drawing.Size(51, 97)
        Me.picS3.TabIndex = 232
        Me.picS3.TabStop = False
        Me.picS3.Visible = False
        '
        'picS1
        '
        Me.picS1.BackgroundImage = CType(resources.GetObject("picS1.BackgroundImage"), System.Drawing.Image)
        Me.picS1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picS1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picS1.Location = New System.Drawing.Point(405, 240)
        Me.picS1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picS1.Name = "picS1"
        Me.picS1.Size = New System.Drawing.Size(51, 97)
        Me.picS1.TabIndex = 231
        Me.picS1.TabStop = False
        Me.picS1.Visible = False
        '
        'tmrSimulacion
        '
        Me.tmrSimulacion.Interval = 500
        '
        'btnCambiosRemoto
        '
        Me.btnCambiosRemoto.BackColor = System.Drawing.Color.ForestGreen
        Me.btnCambiosRemoto.FlatAppearance.BorderSize = 0
        Me.btnCambiosRemoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiosRemoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiosRemoto.ForeColor = System.Drawing.Color.White
        Me.btnCambiosRemoto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCambiosRemoto.Location = New System.Drawing.Point(1188, 632)
        Me.btnCambiosRemoto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCambiosRemoto.Name = "btnCambiosRemoto"
        Me.btnCambiosRemoto.Size = New System.Drawing.Size(151, 40)
        Me.btnCambiosRemoto.TabIndex = 217
        Me.btnCambiosRemoto.Text = "SINCRONIZAR A GESTIÓN"
        Me.btnCambiosRemoto.UseVisualStyleBackColor = False
        '
        'SnPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.btnCambiosRemoto)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SnPrincipal"
        Me.Opacity = 0.95R
        Me.Text = "Principal"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.picEstadoPort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picSemaforo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.groupBox27.ResumeLayout(False)
        Me.groupBox27.PerformLayout()
        CType(Me.pictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBattery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picS7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picS9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picS8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picS6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picS5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picS4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picS3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Conexion As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents tmrTiempo As Timer
    Friend WithEvents tmrIntermitencias As Timer
    Friend WithEvents tmrIntermAmarilla As Timer
    Friend WithEvents tmrPuertoCom As Timer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblHora As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPosX1 As TextBox
    Friend WithEvents txtPosX2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPosY0 As TextBox
    Friend WithEvents txtPosY1 As TextBox
    Friend WithEvents txtPosY2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPosX0 As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents picEstadoPort As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSimular As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGreen As Button
    Friend WithEvents btnAmbar As Button
    Friend WithEvents btnRed As Button
    Friend WithEvents picSemaforo As PictureBox
    Friend WithEvents txtRed As TextBox
    Friend WithEvents txtGreen As TextBox
    Friend WithEvents txtAmbar As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btnPrender As Button
    Friend WithEvents btnApagar As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnPrecaucion As Button
    Friend WithEvents btnPrecaucion2 As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btnTryOut As Button
    Friend WithEvents btnTryIn As Button
    Friend WithEvents btnOffTest As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents Label22 As Label
    Friend WithEvents txtSnY As TextBox
    Friend WithEvents txtSnX As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents picBattery As PictureBox
    Friend WithEvents txtNVPanel As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtNVBatt As TextBox
    Friend WithEvents txtStatusE As TextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents btnBateriaConsulta As Button
    Friend WithEvents btnTiemposConsultar As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents tmrEstadoBatería As Timer
    Friend WithEvents tmrTiemposSemaforo As Timer
    Friend WithEvents btnTiempoVerde As Button
    Friend WithEvents btnTiempoAmarillo As Button
    Friend WithEvents btnTiempoRojo As Button
    Friend WithEvents tmrRojo As Timer
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents nudLight As NumericUpDown
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents groupBox27 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents label10 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents label18 As Label
    Friend WithEvents pictureBox15 As PictureBox
    Friend WithEvents pictureBox16 As PictureBox
    Friend WithEvents pictureBox17 As PictureBox
    Friend WithEvents pictureBox18 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picS8 As PictureBox
    Friend WithEvents picS6 As PictureBox
    Friend WithEvents picS5 As PictureBox
    Friend WithEvents picS4 As PictureBox
    Friend WithEvents picS2 As PictureBox
    Friend WithEvents picS3 As PictureBox
    Friend WithEvents picS1 As PictureBox
    Friend WithEvents picS7 As PictureBox
    Friend WithEvents picS9 As PictureBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents MapaNodos As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tmrSimulacion As Timer
    Friend WithEvents btnCambiosRemoto As Button
End Class
