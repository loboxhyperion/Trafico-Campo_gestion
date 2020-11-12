<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SnGestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SnGestion))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.progressLoader = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.PanelChildForm3 = New System.Windows.Forms.Panel()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelChildForm2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Sidebar = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picEstadoPort = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPosY0 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPosX0 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDashBoard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Setup = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Pruebas = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Operacion = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton9 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.PictureBox22 = New System.Windows.Forms.PictureBox()
        Me.bunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Conexion = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrPuertoCom = New System.Windows.Forms.Timer(Me.components)
        Me.tmrSerialInOut = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBlinkAlert = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse4 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse5 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse6 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tmrLoader = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.PanelChildForm3.SuspendLayout()
        Me.PanelChildForm2.SuspendLayout()
        Me.PanelChildForm.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Sidebar.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEstadoPort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.PanelChildForm3)
        Me.Panel3.Controls.Add(Me.PanelChildForm2)
        Me.Panel3.Controls.Add(Me.PanelChildForm)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(315, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1039, 633)
        Me.Panel3.TabIndex = 5
        '
        'Panel8
        '
        Me.Panel8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Controls.Add(Me.progressLoader)
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1039, 226)
        Me.Panel8.TabIndex = 6
        Me.Panel8.TabStop = True
        Me.Panel8.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(426, 398)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 34)
        Me.Label6.TabIndex = 176
        Me.Label6.Text = "Cargando pantalla ..."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'progressLoader
        '
        Me.progressLoader.animated = True
        Me.progressLoader.animationIterval = 2
        Me.progressLoader.animationSpeed = 1
        Me.progressLoader.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.progressLoader.BackgroundImage = CType(resources.GetObject("progressLoader.BackgroundImage"), System.Drawing.Image)
        Me.progressLoader.Font = New System.Drawing.Font("Poppins", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progressLoader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.progressLoader.LabelVisible = True
        Me.progressLoader.LineProgressThickness = 8
        Me.progressLoader.LineThickness = 3
        Me.progressLoader.Location = New System.Drawing.Point(412, 172)
        Me.progressLoader.Margin = New System.Windows.Forms.Padding(10)
        Me.progressLoader.MaxValue = 100
        Me.progressLoader.Name = "progressLoader"
        Me.progressLoader.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.progressLoader.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.progressLoader.Size = New System.Drawing.Size(216, 216)
        Me.progressLoader.TabIndex = 0
        Me.progressLoader.Value = 0
        '
        'PanelChildForm3
        '
        Me.PanelChildForm3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelChildForm3.Controls.Add(Me.RichTextBox2)
        Me.PanelChildForm3.Controls.Add(Me.Label4)
        Me.PanelChildForm3.Location = New System.Drawing.Point(683, 7)
        Me.PanelChildForm3.Name = "PanelChildForm3"
        Me.PanelChildForm3.Size = New System.Drawing.Size(341, 606)
        Me.PanelChildForm3.TabIndex = 2
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.Black
        Me.RichTextBox2.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.Yellow
        Me.RichTextBox2.Location = New System.Drawing.Point(8, 3)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(326, 131)
        Me.RichTextBox2.TabIndex = 211
        Me.RichTextBox2.Text = ""
        Me.RichTextBox2.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(108, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 34)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "SIN USAR"
        '
        'PanelChildForm2
        '
        Me.PanelChildForm2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelChildForm2.Controls.Add(Me.Label1)
        Me.PanelChildForm2.Location = New System.Drawing.Point(341, 7)
        Me.PanelChildForm2.Name = "PanelChildForm2"
        Me.PanelChildForm2.Size = New System.Drawing.Size(341, 606)
        Me.PanelChildForm2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(97, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 34)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SIN USAR"
        '
        'PanelChildForm
        '
        Me.PanelChildForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelChildForm.Controls.Add(Me.Label3)
        Me.PanelChildForm.Location = New System.Drawing.Point(0, 7)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(341, 606)
        Me.PanelChildForm.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(85, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 34)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SIN USAR"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 7
        Me.BunifuFlatButton1.ButtonText = "TEST"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(90, 50)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = True
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(101, 33)
        Me.BunifuFlatButton1.TabIndex = 286
        Me.BunifuFlatButton1.Text = "TEST"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(315, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1039, 100)
        Me.Panel2.TabIndex = 4
        '
        'Panel9
        '
        Me.Panel9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(0, 87)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1039, 10)
        Me.Panel9.TabIndex = 7
        Me.Panel9.TabStop = True
        Me.Panel9.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Location = New System.Drawing.Point(231, 12)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(796, 75)
        Me.Panel7.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Location = New System.Drawing.Point(10, 12)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(206, 75)
        Me.Panel6.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Sidebar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 733)
        Me.Panel1.TabIndex = 3
        '
        'Sidebar
        '
        Me.Sidebar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Sidebar.AutoScroll = True
        Me.Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Sidebar.Controls.Add(Me.Panel4)
        Me.Sidebar.Controls.Add(Me.btnDashBoard)
        Me.Sidebar.Controls.Add(Me.Setup)
        Me.Sidebar.Controls.Add(Me.Pruebas)
        Me.Sidebar.Controls.Add(Me.Operacion)
        Me.Sidebar.Controls.Add(Me.BunifuFlatButton9)
        Me.Sidebar.Controls.Add(Me.Panel5)
        Me.Sidebar.Location = New System.Drawing.Point(10, 12)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(294, 709)
        Me.Sidebar.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BunifuSeparator3)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.picEstadoPort)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.BunifuSeparator2)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.txtPosY0)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtPosX0)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(274, 160)
        Me.Panel4.TabIndex = 14
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(11, 146)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(252, 13)
        Me.BunifuSeparator3.TabIndex = 175
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(64, 109)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 31)
        Me.PictureBox1.TabIndex = 174
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'picEstadoPort
        '
        Me.picEstadoPort.BackColor = System.Drawing.Color.Red
        Me.picEstadoPort.Location = New System.Drawing.Point(229, 37)
        Me.picEstadoPort.Name = "picEstadoPort"
        Me.picEstadoPort.Size = New System.Drawing.Size(22, 19)
        Me.picEstadoPort.TabIndex = 122
        Me.picEstadoPort.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(219, 17)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Estado"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(151, 97)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 15)
        Me.Label12.TabIndex = 133
        Me.Label12.Text = " Sn Y"
        Me.Label12.Visible = False
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(11, 64)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(252, 10)
        Me.BunifuSeparator2.TabIndex = 3
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(122, 77)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 129
        Me.Label7.Text = "CENTRAL:"
        Me.Label7.Visible = False
        '
        'txtPosY0
        '
        Me.txtPosY0.BackColor = System.Drawing.Color.Black
        Me.txtPosY0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosY0.ForeColor = System.Drawing.Color.Yellow
        Me.txtPosY0.Location = New System.Drawing.Point(151, 120)
        Me.txtPosY0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPosY0.MaxLength = 4
        Me.txtPosY0.Name = "txtPosY0"
        Me.txtPosY0.Size = New System.Drawing.Size(47, 20)
        Me.txtPosY0.TabIndex = 131
        Me.txtPosY0.Text = "136"
        Me.txtPosY0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPosY0.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(69, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SIM Campo"
        '
        'txtPosX0
        '
        Me.txtPosX0.BackColor = System.Drawing.Color.Black
        Me.txtPosX0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosX0.ForeColor = System.Drawing.Color.Yellow
        Me.txtPosX0.Location = New System.Drawing.Point(101, 120)
        Me.txtPosX0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPosX0.MaxLength = 4
        Me.txtPosX0.Name = "txtPosX0"
        Me.txtPosX0.Size = New System.Drawing.Size(47, 20)
        Me.txtPosX0.TabIndex = 130
        Me.txtPosX0.Text = "132"
        Me.txtPosX0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPosX0.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(20, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(102, 97)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 15)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = " Sn X "
        Me.Label8.Visible = False
        '
        'btnDashBoard
        '
        Me.btnDashBoard.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnDashBoard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDashBoard.BorderRadius = 7
        Me.btnDashBoard.ButtonText = "         DASHBOARD"
        Me.btnDashBoard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashBoard.DisabledColor = System.Drawing.Color.Gray
        Me.btnDashBoard.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDashBoard.Iconimage = CType(resources.GetObject("btnDashBoard.Iconimage"), System.Drawing.Image)
        Me.btnDashBoard.Iconimage_right = Nothing
        Me.btnDashBoard.Iconimage_right_Selected = Nothing
        Me.btnDashBoard.Iconimage_Selected = Nothing
        Me.btnDashBoard.IconMarginLeft = 0
        Me.btnDashBoard.IconMarginRight = 0
        Me.btnDashBoard.IconRightVisible = True
        Me.btnDashBoard.IconRightZoom = 0R
        Me.btnDashBoard.IconVisible = True
        Me.btnDashBoard.IconZoom = 50.0R
        Me.btnDashBoard.IsTab = False
        Me.btnDashBoard.Location = New System.Drawing.Point(14, 168)
        Me.btnDashBoard.Margin = New System.Windows.Forms.Padding(14, 2, 3, 2)
        Me.btnDashBoard.Name = "btnDashBoard"
        Me.btnDashBoard.Normalcolor = System.Drawing.Color.Transparent
        Me.btnDashBoard.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnDashBoard.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDashBoard.selected = True
        Me.btnDashBoard.Size = New System.Drawing.Size(202, 48)
        Me.btnDashBoard.TabIndex = 14
        Me.btnDashBoard.Text = "         DASHBOARD"
        Me.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashBoard.Textcolor = System.Drawing.Color.White
        Me.btnDashBoard.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Setup
        '
        Me.Setup.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Setup.BackColor = System.Drawing.Color.Transparent
        Me.Setup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Setup.BorderRadius = 7
        Me.Setup.ButtonText = "         SETUP"
        Me.Setup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Setup.DisabledColor = System.Drawing.Color.Gray
        Me.Setup.Iconcolor = System.Drawing.Color.Transparent
        Me.Setup.Iconimage = CType(resources.GetObject("Setup.Iconimage"), System.Drawing.Image)
        Me.Setup.Iconimage_right = Nothing
        Me.Setup.Iconimage_right_Selected = Nothing
        Me.Setup.Iconimage_Selected = Nothing
        Me.Setup.IconMarginLeft = 0
        Me.Setup.IconMarginRight = 0
        Me.Setup.IconRightVisible = True
        Me.Setup.IconRightZoom = 0R
        Me.Setup.IconVisible = True
        Me.Setup.IconZoom = 50.0R
        Me.Setup.IsTab = False
        Me.Setup.Location = New System.Drawing.Point(14, 221)
        Me.Setup.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.Setup.Name = "Setup"
        Me.Setup.Normalcolor = System.Drawing.Color.Transparent
        Me.Setup.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Setup.OnHoverTextColor = System.Drawing.Color.White
        Me.Setup.selected = True
        Me.Setup.Size = New System.Drawing.Size(236, 48)
        Me.Setup.TabIndex = 16
        Me.Setup.Text = "         SETUP"
        Me.Setup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Setup.Textcolor = System.Drawing.Color.White
        Me.Setup.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Pruebas
        '
        Me.Pruebas.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Pruebas.BackColor = System.Drawing.Color.Transparent
        Me.Pruebas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pruebas.BorderRadius = 7
        Me.Pruebas.ButtonText = "         PRUEBAS"
        Me.Pruebas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pruebas.DisabledColor = System.Drawing.Color.Gray
        Me.Pruebas.Iconcolor = System.Drawing.Color.Transparent
        Me.Pruebas.Iconimage = CType(resources.GetObject("Pruebas.Iconimage"), System.Drawing.Image)
        Me.Pruebas.Iconimage_right = Nothing
        Me.Pruebas.Iconimage_right_Selected = Nothing
        Me.Pruebas.Iconimage_Selected = Nothing
        Me.Pruebas.IconMarginLeft = 0
        Me.Pruebas.IconMarginRight = 0
        Me.Pruebas.IconRightVisible = True
        Me.Pruebas.IconRightZoom = 0R
        Me.Pruebas.IconVisible = True
        Me.Pruebas.IconZoom = 60.0R
        Me.Pruebas.IsTab = False
        Me.Pruebas.Location = New System.Drawing.Point(14, 275)
        Me.Pruebas.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.Pruebas.Name = "Pruebas"
        Me.Pruebas.Normalcolor = System.Drawing.Color.Transparent
        Me.Pruebas.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Pruebas.OnHoverTextColor = System.Drawing.Color.White
        Me.Pruebas.selected = True
        Me.Pruebas.Size = New System.Drawing.Size(236, 48)
        Me.Pruebas.TabIndex = 17
        Me.Pruebas.Text = "         PRUEBAS"
        Me.Pruebas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Pruebas.Textcolor = System.Drawing.Color.White
        Me.Pruebas.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Operacion
        '
        Me.Operacion.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Operacion.BackColor = System.Drawing.Color.Transparent
        Me.Operacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Operacion.BorderRadius = 7
        Me.Operacion.ButtonText = "         OPERACION"
        Me.Operacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Operacion.DisabledColor = System.Drawing.Color.Gray
        Me.Operacion.Iconcolor = System.Drawing.Color.Transparent
        Me.Operacion.Iconimage = CType(resources.GetObject("Operacion.Iconimage"), System.Drawing.Image)
        Me.Operacion.Iconimage_right = Nothing
        Me.Operacion.Iconimage_right_Selected = Nothing
        Me.Operacion.Iconimage_Selected = Nothing
        Me.Operacion.IconMarginLeft = 0
        Me.Operacion.IconMarginRight = 0
        Me.Operacion.IconRightVisible = True
        Me.Operacion.IconRightZoom = 0R
        Me.Operacion.IconVisible = True
        Me.Operacion.IconZoom = 50.0R
        Me.Operacion.IsTab = False
        Me.Operacion.Location = New System.Drawing.Point(14, 329)
        Me.Operacion.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.Operacion.Name = "Operacion"
        Me.Operacion.Normalcolor = System.Drawing.Color.Transparent
        Me.Operacion.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Operacion.OnHoverTextColor = System.Drawing.Color.White
        Me.Operacion.selected = True
        Me.Operacion.Size = New System.Drawing.Size(236, 48)
        Me.Operacion.TabIndex = 18
        Me.Operacion.Text = "         OPERACION"
        Me.Operacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Operacion.Textcolor = System.Drawing.Color.White
        Me.Operacion.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton9
        '
        Me.BunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton9.BorderRadius = 7
        Me.BunifuFlatButton9.ButtonText = "         ACERCA DE"
        Me.BunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.Iconimage = CType(resources.GetObject("BunifuFlatButton9.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton9.Iconimage_right = Nothing
        Me.BunifuFlatButton9.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton9.Iconimage_Selected = Nothing
        Me.BunifuFlatButton9.IconMarginLeft = 0
        Me.BunifuFlatButton9.IconMarginRight = 0
        Me.BunifuFlatButton9.IconRightVisible = True
        Me.BunifuFlatButton9.IconRightZoom = 0R
        Me.BunifuFlatButton9.IconVisible = True
        Me.BunifuFlatButton9.IconZoom = 50.0R
        Me.BunifuFlatButton9.IsTab = False
        Me.BunifuFlatButton9.Location = New System.Drawing.Point(14, 383)
        Me.BunifuFlatButton9.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.BunifuFlatButton9.Name = "BunifuFlatButton9"
        Me.BunifuFlatButton9.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton9.selected = True
        Me.BunifuFlatButton9.Size = New System.Drawing.Size(236, 48)
        Me.BunifuFlatButton9.TabIndex = 290
        Me.BunifuFlatButton9.Text = "         ACERCA DE"
        Me.BunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton9.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton9.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel10)
        Me.Panel5.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel5.Controls.Add(Me.bunifuSeparator1)
        Me.Panel5.Location = New System.Drawing.Point(3, 437)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(274, 264)
        Me.Panel5.TabIndex = 13
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel10.Controls.Add(Me.PictureBox22)
        Me.Panel10.Location = New System.Drawing.Point(34, 135)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(199, 94)
        Me.Panel10.TabIndex = 290
        '
        'PictureBox22
        '
        Me.PictureBox22.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox22.BackgroundImage = CType(resources.GetObject("PictureBox22.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox22.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox22.Margin = New System.Windows.Forms.Padding(24, 3, 2, 3)
        Me.PictureBox22.Name = "PictureBox22"
        Me.PictureBox22.Size = New System.Drawing.Size(194, 88)
        Me.PictureBox22.TabIndex = 288
        Me.PictureBox22.TabStop = False
        '
        'bunifuSeparator1
        '
        Me.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bunifuSeparator1.LineThickness = 1
        Me.bunifuSeparator1.Location = New System.Drawing.Point(11, 89)
        Me.bunifuSeparator1.Name = "bunifuSeparator1"
        Me.bunifuSeparator1.Size = New System.Drawing.Size(252, 10)
        Me.bunifuSeparator1.TabIndex = 3
        Me.bunifuSeparator1.Transparency = 255
        Me.bunifuSeparator1.Vertical = False
        '
        'tmrPuertoCom
        '
        Me.tmrPuertoCom.Enabled = True
        Me.tmrPuertoCom.Interval = 1000
        '
        'tmrSerialInOut
        '
        Me.tmrSerialInOut.Interval = 300
        '
        'tmrBlinkAlert
        '
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me.Sidebar
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me.Panel6
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 5
        Me.BunifuElipse3.TargetControl = Me.Panel7
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 5
        Me.BunifuElipse4.TargetControl = Me.PanelChildForm
        '
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 5
        Me.BunifuElipse5.TargetControl = Me.PanelChildForm2
        '
        'BunifuElipse6
        '
        Me.BunifuElipse6.ElipseRadius = 5
        Me.BunifuElipse6.TargetControl = Me.PanelChildForm3
        '
        'tmrLoader
        '
        Me.tmrLoader.Interval = 30
        '
        'SnGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SnGestion"
        Me.Text = "SnGestion"
        Me.Panel3.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.PanelChildForm3.ResumeLayout(False)
        Me.PanelChildForm3.PerformLayout()
        Me.PanelChildForm2.ResumeLayout(False)
        Me.PanelChildForm2.PerformLayout()
        Me.PanelChildForm.ResumeLayout(False)
        Me.PanelChildForm.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Sidebar.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEstadoPort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelChildForm3 As Panel
    Private WithEvents Label4 As Label
    Friend WithEvents PanelChildForm2 As Panel
    Private WithEvents Label1 As Label
    Friend WithEvents PanelChildForm As Panel
    Private WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Sidebar As FlowLayoutPanel
    Friend WithEvents Panel4 As Panel
    Private WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Private WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Private WithEvents btnDashBoard As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents Setup As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents Pruebas As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents Operacion As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents BunifuFlatButton9 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel5 As Panel
    Private WithEvents bunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents PictureBox22 As PictureBox
    Friend WithEvents Conexion As IO.Ports.SerialPort
    Friend WithEvents tmrPuertoCom As Timer
    Friend WithEvents tmrSerialInOut As Timer
    Friend WithEvents picEstadoPort As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPosY0 As TextBox
    Friend WithEvents txtPosX0 As TextBox
    Friend WithEvents Label12 As Label
    Private WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Private WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tmrBlinkAlert As Timer
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse4 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse5 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse6 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents progressLoader As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents tmrLoader As Timer
    Private WithEvents Label6 As Label
    Friend WithEvents Panel10 As Panel
End Class
