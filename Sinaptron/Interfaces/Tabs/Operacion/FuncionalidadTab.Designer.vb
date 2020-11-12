<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FuncionalidadTab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FuncionalidadTab))
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLuz = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnDimerizacion = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton8 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton10 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tmrInterRoja = New System.Windows.Forms.Timer(Me.components)
        Me.tmrInterAmarilla = New System.Windows.Forms.Timer(Me.components)
        Me.picBattery = New System.Windows.Forms.PictureBox()
        Me.btnIntermitenciaRoja = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnIntermitenciaAmarilla = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPrender = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnApagar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tmrSemafo = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuSwitch3 = New Bunifu.Framework.UI.BunifuSwitch()
        CType(Me.picBattery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 3
        Me.BunifuSeparator5.Location = New System.Drawing.Point(12, 48)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(322, 13)
        Me.BunifuSeparator5.TabIndex = 256
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(96, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 282
        Me.Label9.Text = "Dimerización"
        '
        'txtLuz
        '
        Me.txtLuz.BackColor = System.Drawing.Color.Black
        Me.txtLuz.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLuz.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuz.ForeColor = System.Drawing.Color.White
        Me.txtLuz.HintForeColor = System.Drawing.Color.Empty
        Me.txtLuz.HintText = ""
        Me.txtLuz.isPassword = False
        Me.txtLuz.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtLuz.LineIdleColor = System.Drawing.Color.Gray
        Me.txtLuz.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtLuz.LineThickness = 4
        Me.txtLuz.Location = New System.Drawing.Point(131, 377)
        Me.txtLuz.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLuz.Name = "txtLuz"
        Me.txtLuz.Size = New System.Drawing.Size(57, 35)
        Me.txtLuz.TabIndex = 280
        Me.txtLuz.Text = "0"
        Me.txtLuz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDimerizacion
        '
        Me.btnDimerizacion.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDimerizacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnDimerizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDimerizacion.BorderRadius = 7
        Me.btnDimerizacion.ButtonText = "ENVIAR"
        Me.btnDimerizacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDimerizacion.DisabledColor = System.Drawing.Color.Gray
        Me.btnDimerizacion.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDimerizacion.Iconimage = Nothing
        Me.btnDimerizacion.Iconimage_right = Nothing
        Me.btnDimerizacion.Iconimage_right_Selected = Nothing
        Me.btnDimerizacion.Iconimage_Selected = Nothing
        Me.btnDimerizacion.IconMarginLeft = 0
        Me.btnDimerizacion.IconMarginRight = 0
        Me.btnDimerizacion.IconRightVisible = True
        Me.btnDimerizacion.IconRightZoom = 0R
        Me.btnDimerizacion.IconVisible = True
        Me.btnDimerizacion.IconZoom = 50.0R
        Me.btnDimerizacion.IsTab = False
        Me.btnDimerizacion.Location = New System.Drawing.Point(194, 377)
        Me.btnDimerizacion.Name = "btnDimerizacion"
        Me.btnDimerizacion.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnDimerizacion.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDimerizacion.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDimerizacion.selected = False
        Me.btnDimerizacion.Size = New System.Drawing.Size(70, 35)
        Me.btnDimerizacion.TabIndex = 283
        Me.btnDimerizacion.Text = "ENVIAR"
        Me.btnDimerizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDimerizacion.Textcolor = System.Drawing.Color.White
        Me.btnDimerizacion.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton8
        '
        Me.BunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton8.BorderRadius = 7
        Me.BunifuFlatButton8.ButtonText = "SEMAFORO"
        Me.BunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.Iconimage = Nothing
        Me.BunifuFlatButton8.Iconimage_right = Nothing
        Me.BunifuFlatButton8.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton8.Iconimage_Selected = Nothing
        Me.BunifuFlatButton8.IconMarginLeft = 0
        Me.BunifuFlatButton8.IconMarginRight = 0
        Me.BunifuFlatButton8.IconRightVisible = True
        Me.BunifuFlatButton8.IconRightZoom = 0R
        Me.BunifuFlatButton8.IconVisible = True
        Me.BunifuFlatButton8.IconZoom = 50.0R
        Me.BunifuFlatButton8.IsTab = False
        Me.BunifuFlatButton8.Location = New System.Drawing.Point(2, 6)
        Me.BunifuFlatButton8.Margin = New System.Windows.Forms.Padding(14, 2, 3, 2)
        Me.BunifuFlatButton8.Name = "BunifuFlatButton8"
        Me.BunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton8.selected = True
        Me.BunifuFlatButton8.Size = New System.Drawing.Size(336, 41)
        Me.BunifuFlatButton8.TabIndex = 374
        Me.BunifuFlatButton8.Text = "SEMAFORO"
        Me.BunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton8.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton8.TextFont = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton10
        '
        Me.BunifuFlatButton10.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton10.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton10.BorderRadius = 7
        Me.BunifuFlatButton10.ButtonText = "ACCION"
        Me.BunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton10.Iconimage = Nothing
        Me.BunifuFlatButton10.Iconimage_right = Nothing
        Me.BunifuFlatButton10.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton10.Iconimage_Selected = Nothing
        Me.BunifuFlatButton10.IconMarginLeft = 0
        Me.BunifuFlatButton10.IconMarginRight = 0
        Me.BunifuFlatButton10.IconRightVisible = True
        Me.BunifuFlatButton10.IconRightZoom = 0R
        Me.BunifuFlatButton10.IconVisible = True
        Me.BunifuFlatButton10.IconZoom = 50.0R
        Me.BunifuFlatButton10.IsTab = False
        Me.BunifuFlatButton10.Location = New System.Drawing.Point(2, 66)
        Me.BunifuFlatButton10.Margin = New System.Windows.Forms.Padding(14, 2, 3, 2)
        Me.BunifuFlatButton10.Name = "BunifuFlatButton10"
        Me.BunifuFlatButton10.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton10.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton10.selected = True
        Me.BunifuFlatButton10.Size = New System.Drawing.Size(336, 41)
        Me.BunifuFlatButton10.TabIndex = 386
        Me.BunifuFlatButton10.Text = "ACCION"
        Me.BunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton10.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton10.TextFont = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 7
        Me.BunifuFlatButton2.ButtonText = "INTERMITENCIAS"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 50.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(2, 192)
        Me.BunifuFlatButton2.Margin = New System.Windows.Forms.Padding(14, 2, 3, 2)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = True
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(336, 41)
        Me.BunifuFlatButton2.TabIndex = 388
        Me.BunifuFlatButton2.Text = "INTERMITENCIAS"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 7
        Me.BunifuFlatButton3.ButtonText = "INTENSIDAD DE LUZ"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = Nothing
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 50.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(2, 308)
        Me.BunifuFlatButton3.Margin = New System.Windows.Forms.Padding(14, 2, 3, 2)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = True
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(336, 41)
        Me.BunifuFlatButton3.TabIndex = 389
        Me.BunifuFlatButton3.Text = "INTENSIDAD DE LUZ"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tmrInterRoja
        '
        Me.tmrInterRoja.Interval = 200
        '
        'tmrInterAmarilla
        '
        Me.tmrInterAmarilla.Interval = 200
        '
        'picBattery
        '
        Me.picBattery.BackgroundImage = CType(resources.GetObject("picBattery.BackgroundImage"), System.Drawing.Image)
        Me.picBattery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBattery.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picBattery.Location = New System.Drawing.Point(92, 377)
        Me.picBattery.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picBattery.Name = "picBattery"
        Me.picBattery.Size = New System.Drawing.Size(34, 34)
        Me.picBattery.TabIndex = 281
        Me.picBattery.TabStop = False
        '
        'btnIntermitenciaRoja
        '
        Me.btnIntermitenciaRoja.Activecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnIntermitenciaRoja.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnIntermitenciaRoja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIntermitenciaRoja.BorderRadius = 7
        Me.btnIntermitenciaRoja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnIntermitenciaRoja.ButtonText = "ROJA"
        Me.btnIntermitenciaRoja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIntermitenciaRoja.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnIntermitenciaRoja.Iconcolor = System.Drawing.Color.Transparent
        Me.btnIntermitenciaRoja.Iconimage = Global.Sinaptron.My.Resources.Resources.interrojaoff
        Me.btnIntermitenciaRoja.Iconimage_right = Nothing
        Me.btnIntermitenciaRoja.Iconimage_right_Selected = Nothing
        Me.btnIntermitenciaRoja.Iconimage_Selected = Nothing
        Me.btnIntermitenciaRoja.IconMarginLeft = 0
        Me.btnIntermitenciaRoja.IconMarginRight = 0
        Me.btnIntermitenciaRoja.IconRightVisible = True
        Me.btnIntermitenciaRoja.IconRightZoom = 0R
        Me.btnIntermitenciaRoja.IconVisible = True
        Me.btnIntermitenciaRoja.IconZoom = 50.0R
        Me.btnIntermitenciaRoja.IsTab = False
        Me.btnIntermitenciaRoja.Location = New System.Drawing.Point(12, 244)
        Me.btnIntermitenciaRoja.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.btnIntermitenciaRoja.Name = "btnIntermitenciaRoja"
        Me.btnIntermitenciaRoja.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnIntermitenciaRoja.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnIntermitenciaRoja.OnHoverTextColor = System.Drawing.Color.White
        Me.btnIntermitenciaRoja.selected = True
        Me.btnIntermitenciaRoja.Size = New System.Drawing.Size(158, 48)
        Me.btnIntermitenciaRoja.TabIndex = 251
        Me.btnIntermitenciaRoja.Text = "ROJA"
        Me.btnIntermitenciaRoja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIntermitenciaRoja.Textcolor = System.Drawing.Color.White
        Me.btnIntermitenciaRoja.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnIntermitenciaAmarilla
        '
        Me.btnIntermitenciaAmarilla.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnIntermitenciaAmarilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIntermitenciaAmarilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIntermitenciaAmarilla.BorderRadius = 7
        Me.btnIntermitenciaAmarilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnIntermitenciaAmarilla.ButtonText = "AMARILLA"
        Me.btnIntermitenciaAmarilla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIntermitenciaAmarilla.DisabledColor = System.Drawing.Color.Gray
        Me.btnIntermitenciaAmarilla.Iconcolor = System.Drawing.Color.Transparent
        Me.btnIntermitenciaAmarilla.Iconimage = Global.Sinaptron.My.Resources.Resources.interamarillaoff
        Me.btnIntermitenciaAmarilla.Iconimage_right = Nothing
        Me.btnIntermitenciaAmarilla.Iconimage_right_Selected = Nothing
        Me.btnIntermitenciaAmarilla.Iconimage_Selected = Nothing
        Me.btnIntermitenciaAmarilla.IconMarginLeft = 0
        Me.btnIntermitenciaAmarilla.IconMarginRight = 0
        Me.btnIntermitenciaAmarilla.IconRightVisible = True
        Me.btnIntermitenciaAmarilla.IconRightZoom = 0R
        Me.btnIntermitenciaAmarilla.IconVisible = True
        Me.btnIntermitenciaAmarilla.IconZoom = 50.0R
        Me.btnIntermitenciaAmarilla.IsTab = False
        Me.btnIntermitenciaAmarilla.Location = New System.Drawing.Point(176, 244)
        Me.btnIntermitenciaAmarilla.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.btnIntermitenciaAmarilla.Name = "btnIntermitenciaAmarilla"
        Me.btnIntermitenciaAmarilla.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIntermitenciaAmarilla.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnIntermitenciaAmarilla.OnHoverTextColor = System.Drawing.Color.White
        Me.btnIntermitenciaAmarilla.selected = True
        Me.btnIntermitenciaAmarilla.Size = New System.Drawing.Size(158, 48)
        Me.btnIntermitenciaAmarilla.TabIndex = 250
        Me.btnIntermitenciaAmarilla.Text = "AMARILLA"
        Me.btnIntermitenciaAmarilla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIntermitenciaAmarilla.Textcolor = System.Drawing.Color.White
        Me.btnIntermitenciaAmarilla.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnPrender
        '
        Me.btnPrender.Activecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPrender.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnPrender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrender.BorderRadius = 7
        Me.btnPrender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnPrender.ButtonText = "  PRENDER"
        Me.btnPrender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrender.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnPrender.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPrender.Iconimage = CType(resources.GetObject("btnPrender.Iconimage"), System.Drawing.Image)
        Me.btnPrender.Iconimage_right = Nothing
        Me.btnPrender.Iconimage_right_Selected = Nothing
        Me.btnPrender.Iconimage_Selected = Nothing
        Me.btnPrender.IconMarginLeft = 0
        Me.btnPrender.IconMarginRight = 0
        Me.btnPrender.IconRightVisible = True
        Me.btnPrender.IconRightZoom = 0R
        Me.btnPrender.IconVisible = True
        Me.btnPrender.IconZoom = 50.0R
        Me.btnPrender.IsTab = False
        Me.btnPrender.Location = New System.Drawing.Point(10, 124)
        Me.btnPrender.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.btnPrender.Name = "btnPrender"
        Me.btnPrender.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnPrender.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPrender.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPrender.selected = True
        Me.btnPrender.Size = New System.Drawing.Size(158, 48)
        Me.btnPrender.TabIndex = 238
        Me.btnPrender.Text = "  PRENDER"
        Me.btnPrender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrender.Textcolor = System.Drawing.Color.White
        Me.btnPrender.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnApagar
        '
        Me.btnApagar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnApagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnApagar.BorderRadius = 7
        Me.btnApagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnApagar.ButtonText = "APAGAR"
        Me.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApagar.DisabledColor = System.Drawing.Color.Gray
        Me.btnApagar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnApagar.Iconimage = CType(resources.GetObject("btnApagar.Iconimage"), System.Drawing.Image)
        Me.btnApagar.Iconimage_right = Nothing
        Me.btnApagar.Iconimage_right_Selected = Nothing
        Me.btnApagar.Iconimage_Selected = Nothing
        Me.btnApagar.IconMarginLeft = 0
        Me.btnApagar.IconMarginRight = 0
        Me.btnApagar.IconRightVisible = True
        Me.btnApagar.IconRightZoom = 0R
        Me.btnApagar.IconVisible = True
        Me.btnApagar.IconZoom = 50.0R
        Me.btnApagar.IsTab = False
        Me.btnApagar.Location = New System.Drawing.Point(174, 124)
        Me.btnApagar.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnApagar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnApagar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnApagar.selected = True
        Me.btnApagar.Size = New System.Drawing.Size(158, 48)
        Me.btnApagar.TabIndex = 237
        Me.btnApagar.Text = "APAGAR"
        Me.btnApagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApagar.Textcolor = System.Drawing.Color.White
        Me.btnApagar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tmrSemafo
        '
        Me.tmrSemafo.Interval = 500
        '
        'BunifuSwitch3
        '
        Me.BunifuSwitch3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuSwitch3.BorderRadius = 5
        Me.BunifuSwitch3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuSwitch3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuSwitch3.Location = New System.Drawing.Point(128, 1252)
        Me.BunifuSwitch3.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.BunifuSwitch3.Name = "BunifuSwitch3"
        Me.BunifuSwitch3.Oncolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BunifuSwitch3.Onoffcolor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuSwitch3.Size = New System.Drawing.Size(51, 19)
        Me.BunifuSwitch3.TabIndex = 430
        Me.BunifuSwitch3.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuSwitch3.Value = False
        '
        'FuncionalidadTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(341, 606)
        Me.Controls.Add(Me.BunifuSwitch3)
        Me.Controls.Add(Me.BunifuFlatButton3)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.BunifuFlatButton10)
        Me.Controls.Add(Me.BunifuFlatButton8)
        Me.Controls.Add(Me.btnDimerizacion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.picBattery)
        Me.Controls.Add(Me.txtLuz)
        Me.Controls.Add(Me.BunifuSeparator5)
        Me.Controls.Add(Me.btnIntermitenciaRoja)
        Me.Controls.Add(Me.btnIntermitenciaAmarilla)
        Me.Controls.Add(Me.btnPrender)
        Me.Controls.Add(Me.btnApagar)
        Me.Name = "FuncionalidadTab"
        Me.Text = "FuncionalidadTab"
        CType(Me.picBattery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Private WithEvents btnIntermitenciaRoja As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnIntermitenciaAmarilla As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnPrender As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnApagar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label9 As Label
    Friend WithEvents picBattery As PictureBox
    Friend WithEvents txtLuz As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnDimerizacion As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents BunifuFlatButton8 As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents BunifuFlatButton10 As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tmrInterRoja As Timer
    Friend WithEvents tmrInterAmarilla As Timer
    Friend WithEvents tmrSemafo As Timer
    Friend WithEvents BunifuSwitch3 As Bunifu.Framework.UI.BunifuSwitch
End Class
