<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.btnMac = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnSignIn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnRecuperarClave = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMac
        '
        Me.btnMac.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnMac.FlatAppearance.BorderSize = 0
        Me.btnMac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMac.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnMac.ForeColor = System.Drawing.Color.White
        Me.btnMac.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnMac.Location = New System.Drawing.Point(418, 325)
        Me.btnMac.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnMac.Name = "btnMac"
        Me.btnMac.Size = New System.Drawing.Size(95, 25)
        Me.btnMac.TabIndex = 210
        Me.btnMac.Text = "MAC"
        Me.btnMac.UseVisualStyleBackColor = False
        Me.btnMac.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(323, 280)
        Me.PictureBox1.TabIndex = 211
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(387, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 37)
        Me.Label3.TabIndex = 217
        Me.Label3.Text = "Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(387, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 37)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "Usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(532, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 48)
        Me.Label1.TabIndex = 212
        Me.Label1.Text = "LOGIN"
        '
        'txtPassword
        '
        Me.txtPassword.AcceptsTab = True
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(563, 227)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(206, 26)
        Me.txtPassword.TabIndex = 214
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(563, 157)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(206, 26)
        Me.txtUsuario.TabIndex = 213
        '
        'btnSignIn
        '
        Me.btnSignIn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignIn.BorderRadius = 7
        Me.btnSignIn.ButtonText = "CONECTAR"
        Me.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignIn.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSignIn.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnSignIn.Location = New System.Drawing.Point(615, 271)
        Me.btnSignIn.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSignIn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSignIn.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSignIn.selected = True
        Me.btnSignIn.Size = New System.Drawing.Size(152, 33)
        Me.btnSignIn.TabIndex = 349
        Me.btnSignIn.Text = "CONECTAR"
        Me.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSignIn.Textcolor = System.Drawing.Color.White
        Me.btnSignIn.TextFont = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnRecuperarClave
        '
        Me.btnRecuperarClave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRecuperarClave.BackColor = System.Drawing.Color.Transparent
        Me.btnRecuperarClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRecuperarClave.BorderRadius = 7
        Me.btnRecuperarClave.ButtonText = "¿HAS OLVIDADO TU CONTRASEÑA?"
        Me.btnRecuperarClave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecuperarClave.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnRecuperarClave.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecuperarClave.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRecuperarClave.Iconimage = Nothing
        Me.btnRecuperarClave.Iconimage_right = Nothing
        Me.btnRecuperarClave.Iconimage_right_Selected = Nothing
        Me.btnRecuperarClave.Iconimage_Selected = Nothing
        Me.btnRecuperarClave.IconMarginLeft = 0
        Me.btnRecuperarClave.IconMarginRight = 0
        Me.btnRecuperarClave.IconRightVisible = True
        Me.btnRecuperarClave.IconRightZoom = 0R
        Me.btnRecuperarClave.IconVisible = True
        Me.btnRecuperarClave.IconZoom = 50.0R
        Me.btnRecuperarClave.IsTab = False
        Me.btnRecuperarClave.Location = New System.Drawing.Point(352, 276)
        Me.btnRecuperarClave.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.btnRecuperarClave.Name = "btnRecuperarClave"
        Me.btnRecuperarClave.Normalcolor = System.Drawing.Color.Transparent
        Me.btnRecuperarClave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnRecuperarClave.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRecuperarClave.selected = True
        Me.btnRecuperarClave.Size = New System.Drawing.Size(242, 22)
        Me.btnRecuperarClave.TabIndex = 350
        Me.btnRecuperarClave.Text = "¿HAS OLVIDADO TU CONTRASEÑA?"
        Me.btnRecuperarClave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRecuperarClave.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnRecuperarClave.TextFont = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LoginForm
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 378)
        Me.Controls.Add(Me.btnRecuperarClave)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnMac)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMac As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsuario As TextBox
    Private WithEvents btnSignIn As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnRecuperarClave As Bunifu.Framework.UI.BunifuFlatButton
End Class
