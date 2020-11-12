<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CambiarClave
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.selectPregunta1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRespuesta1 = New System.Windows.Forms.TextBox()
        Me.txtRespuesta2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.selectPregunta2 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRespuesta3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.selectPregunta3 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRepeatPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSignIn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnId = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnValidarRespuestas = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(1, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 13)
        Me.Label9.TabIndex = 281
        Me.Label9.Text = "Pregunta secreta n° .1"
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 3
        Me.BunifuSeparator5.Location = New System.Drawing.Point(4, 430)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(381, 13)
        Me.BunifuSeparator5.TabIndex = 376
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = False
        '
        'selectPregunta1
        '
        Me.selectPregunta1.BackColor = System.Drawing.Color.Transparent
        Me.selectPregunta1.BorderRadius = 5
        Me.selectPregunta1.ForeColor = System.Drawing.Color.Black
        Me.selectPregunta1.Items = New String() {"Seleccionar uno", "¿Dónde fue tu primer viaje?", "¿Cómo se llamaba tu primera mascota?", "¿Cuando compraste tu primer carro?", "¿Cuál sería tu trabajo ideal?"}
        Me.selectPregunta1.Location = New System.Drawing.Point(168, 75)
        Me.selectPregunta1.Name = "selectPregunta1"
        Me.selectPregunta1.NomalColor = System.Drawing.Color.White
        Me.selectPregunta1.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.selectPregunta1.selectedIndex = 0
        Me.selectPregunta1.Size = New System.Drawing.Size(217, 32)
        Me.selectPregunta1.TabIndex = 378
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(62, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 381
        Me.Label2.Text = "Tu respuesta"
        '
        'txtRespuesta1
        '
        Me.txtRespuesta1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespuesta1.Location = New System.Drawing.Point(168, 126)
        Me.txtRespuesta1.Name = "txtRespuesta1"
        Me.txtRespuesta1.Size = New System.Drawing.Size(217, 31)
        Me.txtRespuesta1.TabIndex = 382
        Me.txtRespuesta1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRespuesta2
        '
        Me.txtRespuesta2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespuesta2.Location = New System.Drawing.Point(168, 237)
        Me.txtRespuesta2.Name = "txtRespuesta2"
        Me.txtRespuesta2.Size = New System.Drawing.Size(217, 31)
        Me.txtRespuesta2.TabIndex = 386
        Me.txtRespuesta2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(62, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 385
        Me.Label1.Text = "Tu respuesta"
        '
        'selectPregunta2
        '
        Me.selectPregunta2.BackColor = System.Drawing.Color.Transparent
        Me.selectPregunta2.BorderRadius = 5
        Me.selectPregunta2.ForeColor = System.Drawing.Color.Black
        Me.selectPregunta2.Items = New String() {"Seleccionar uno", "¿Dónde fue tu primer viaje?", "¿Cómo se llamaba tu primera mascota?", "¿Cuando compraste tu primer carro?", "¿Cuál sería tu trabajo ideal?"}
        Me.selectPregunta2.Location = New System.Drawing.Point(168, 186)
        Me.selectPregunta2.Name = "selectPregunta2"
        Me.selectPregunta2.NomalColor = System.Drawing.Color.White
        Me.selectPregunta2.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.selectPregunta2.selectedIndex = 0
        Me.selectPregunta2.Size = New System.Drawing.Size(217, 32)
        Me.selectPregunta2.TabIndex = 384
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(1, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 13)
        Me.Label3.TabIndex = 383
        Me.Label3.Text = "Pregunta secreta n° .2"
        '
        'txtRespuesta3
        '
        Me.txtRespuesta3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespuesta3.Location = New System.Drawing.Point(168, 352)
        Me.txtRespuesta3.Name = "txtRespuesta3"
        Me.txtRespuesta3.Size = New System.Drawing.Size(217, 31)
        Me.txtRespuesta3.TabIndex = 390
        Me.txtRespuesta3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(62, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 389
        Me.Label4.Text = "Tu respuesta"
        '
        'selectPregunta3
        '
        Me.selectPregunta3.BackColor = System.Drawing.Color.Transparent
        Me.selectPregunta3.BorderRadius = 5
        Me.selectPregunta3.ForeColor = System.Drawing.Color.Black
        Me.selectPregunta3.Items = New String() {"Seleccionar uno", "¿Dónde fue tu primer viaje?", "¿Cómo se llamaba tu primera mascota?", "¿Cuando compraste tu primer carro?", "¿Cuál sería tu trabajo ideal?"}
        Me.selectPregunta3.Location = New System.Drawing.Point(168, 301)
        Me.selectPregunta3.Name = "selectPregunta3"
        Me.selectPregunta3.NomalColor = System.Drawing.Color.White
        Me.selectPregunta3.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.selectPregunta3.selectedIndex = 0
        Me.selectPregunta3.Size = New System.Drawing.Size(217, 32)
        Me.selectPregunta3.TabIndex = 388
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(1, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 13)
        Me.Label5.TabIndex = 387
        Me.Label5.Text = "Pregunta secreta n° .3"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(168, 513)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(217, 31)
        Me.txtPassword.TabIndex = 392
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(64, 523)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 391
        Me.Label6.Text = "Contraseña"
        '
        'txtRepeatPassword
        '
        Me.txtRepeatPassword.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepeatPassword.Location = New System.Drawing.Point(168, 570)
        Me.txtRepeatPassword.Name = "txtRepeatPassword"
        Me.txtRepeatPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRepeatPassword.Size = New System.Drawing.Size(217, 31)
        Me.txtRepeatPassword.TabIndex = 394
        Me.txtRepeatPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(9, 580)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 13)
        Me.Label7.TabIndex = 393
        Me.Label7.Text = "Repite la contraseña"
        '
        'btnSignIn
        '
        Me.btnSignIn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSignIn.BackColor = System.Drawing.Color.Green
        Me.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignIn.BorderRadius = 7
        Me.btnSignIn.ButtonText = "Guardar"
        Me.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignIn.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSignIn.Enabled = False
        Me.btnSignIn.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSignIn.Iconimage = Nothing
        Me.btnSignIn.Iconimage_right = Nothing
        Me.btnSignIn.Iconimage_right_Selected = Nothing
        Me.btnSignIn.Iconimage_Selected = Nothing
        Me.btnSignIn.IconMarginLeft = 0
        Me.btnSignIn.IconMarginRight = 0
        Me.btnSignIn.IconRightVisible = True
        Me.btnSignIn.IconRightZoom = 0R
        Me.btnSignIn.IconVisible = True
        Me.btnSignIn.IconZoom = 50.0R
        Me.btnSignIn.IsTab = False
        Me.btnSignIn.Location = New System.Drawing.Point(267, 619)
        Me.btnSignIn.Margin = New System.Windows.Forms.Padding(11, 2, 2, 2)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Normalcolor = System.Drawing.Color.Green
        Me.btnSignIn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSignIn.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSignIn.selected = True
        Me.btnSignIn.Size = New System.Drawing.Size(118, 24)
        Me.btnSignIn.TabIndex = 395
        Me.btnSignIn.Text = "Guardar"
        Me.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSignIn.Textcolor = System.Drawing.Color.White
        Me.btnSignIn.TextFont = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 7
        Me.BunifuFlatButton1.ButtonText = "PREGUNTAS DE SEGURIDAD"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Global.Sinaptron.My.Resources.Resources.ARROW_DASHBOARD_EXPANDIR
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(4, 11)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(14, 2, 3, 2)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = True
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(381, 41)
        Me.BunifuFlatButton1.TabIndex = 377
        Me.BunifuFlatButton1.Text = "PREGUNTAS DE SEGURIDAD"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnId
        '
        Me.btnId.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnId.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnId.BorderRadius = 7
        Me.btnId.ButtonText = "NUEVA  CONTRASEÑA"
        Me.btnId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnId.DisabledColor = System.Drawing.Color.Gray
        Me.btnId.Iconcolor = System.Drawing.Color.Transparent
        Me.btnId.Iconimage = Nothing
        Me.btnId.Iconimage_right = Global.Sinaptron.My.Resources.Resources.ARROW_DASHBOARD_EXPANDIR
        Me.btnId.Iconimage_right_Selected = Nothing
        Me.btnId.Iconimage_Selected = Nothing
        Me.btnId.IconMarginLeft = 0
        Me.btnId.IconMarginRight = 0
        Me.btnId.IconRightVisible = True
        Me.btnId.IconRightZoom = 0R
        Me.btnId.IconVisible = True
        Me.btnId.IconZoom = 50.0R
        Me.btnId.IsTab = False
        Me.btnId.Location = New System.Drawing.Point(4, 448)
        Me.btnId.Margin = New System.Windows.Forms.Padding(14, 2, 3, 2)
        Me.btnId.Name = "btnId"
        Me.btnId.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnId.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnId.OnHoverTextColor = System.Drawing.Color.White
        Me.btnId.selected = True
        Me.btnId.Size = New System.Drawing.Size(381, 41)
        Me.btnId.TabIndex = 375
        Me.btnId.Text = "NUEVA  CONTRASEÑA"
        Me.btnId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnId.Textcolor = System.Drawing.Color.White
        Me.btnId.TextFont = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnValidarRespuestas
        '
        Me.btnValidarRespuestas.Activecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnValidarRespuestas.BackColor = System.Drawing.Color.Green
        Me.btnValidarRespuestas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnValidarRespuestas.BorderRadius = 7
        Me.btnValidarRespuestas.ButtonText = "Validar Repuestas"
        Me.btnValidarRespuestas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnValidarRespuestas.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnValidarRespuestas.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidarRespuestas.Iconcolor = System.Drawing.Color.Transparent
        Me.btnValidarRespuestas.Iconimage = Nothing
        Me.btnValidarRespuestas.Iconimage_right = Nothing
        Me.btnValidarRespuestas.Iconimage_right_Selected = Nothing
        Me.btnValidarRespuestas.Iconimage_Selected = Nothing
        Me.btnValidarRespuestas.IconMarginLeft = 0
        Me.btnValidarRespuestas.IconMarginRight = 0
        Me.btnValidarRespuestas.IconRightVisible = True
        Me.btnValidarRespuestas.IconRightZoom = 0R
        Me.btnValidarRespuestas.IconVisible = True
        Me.btnValidarRespuestas.IconZoom = 50.0R
        Me.btnValidarRespuestas.IsTab = False
        Me.btnValidarRespuestas.Location = New System.Drawing.Point(233, 401)
        Me.btnValidarRespuestas.Margin = New System.Windows.Forms.Padding(11, 2, 2, 2)
        Me.btnValidarRespuestas.Name = "btnValidarRespuestas"
        Me.btnValidarRespuestas.Normalcolor = System.Drawing.Color.Green
        Me.btnValidarRespuestas.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnValidarRespuestas.OnHoverTextColor = System.Drawing.Color.White
        Me.btnValidarRespuestas.selected = True
        Me.btnValidarRespuestas.Size = New System.Drawing.Size(151, 24)
        Me.btnValidarRespuestas.TabIndex = 396
        Me.btnValidarRespuestas.Text = "Validar Repuestas"
        Me.btnValidarRespuestas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnValidarRespuestas.Textcolor = System.Drawing.Color.White
        Me.btnValidarRespuestas.TextFont = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CambiarClave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(395, 651)
        Me.Controls.Add(Me.btnValidarRespuestas)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.txtRepeatPassword)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRespuesta3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.selectPregunta3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRespuesta2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.selectPregunta2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRespuesta1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.selectPregunta1)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.BunifuSeparator5)
        Me.Controls.Add(Me.btnId)
        Me.Controls.Add(Me.Label9)
        Me.Name = "CambiarClave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Clave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Private WithEvents btnId As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Private WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents selectPregunta1 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRespuesta1 As TextBox
    Friend WithEvents txtRespuesta2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents selectPregunta2 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRespuesta3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents selectPregunta3 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRepeatPassword As TextBox
    Friend WithEvents Label7 As Label
    Private WithEvents btnSignIn As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnValidarRespuestas As Bunifu.Framework.UI.BunifuFlatButton
End Class
