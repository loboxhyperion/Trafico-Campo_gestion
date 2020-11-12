<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OperacionesMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OperacionesMenu))
        Me.Submenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnFuncionalidad = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnConsultas = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Submenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Submenu
        '
        Me.Submenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Submenu.AutoSize = True
        Me.Submenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Submenu.Controls.Add(Me.btnFuncionalidad)
        Me.Submenu.Controls.Add(Me.btnConsultas)
        Me.Submenu.Controls.Add(Me.BunifuFlatButton5)
        Me.Submenu.Location = New System.Drawing.Point(0, 0)
        Me.Submenu.Name = "Submenu"
        Me.Submenu.Size = New System.Drawing.Size(796, 75)
        Me.Submenu.TabIndex = 1
        '
        'btnFuncionalidad
        '
        Me.btnFuncionalidad.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnFuncionalidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFuncionalidad.BackColor = System.Drawing.Color.Transparent
        Me.btnFuncionalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFuncionalidad.BorderRadius = 7
        Me.btnFuncionalidad.ButtonText = "        FUNCIONALIDAD"
        Me.btnFuncionalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFuncionalidad.DisabledColor = System.Drawing.Color.Gray
        Me.btnFuncionalidad.Iconcolor = System.Drawing.Color.Transparent
        Me.btnFuncionalidad.Iconimage = CType(resources.GetObject("btnFuncionalidad.Iconimage"), System.Drawing.Image)
        Me.btnFuncionalidad.Iconimage_right = Nothing
        Me.btnFuncionalidad.Iconimage_right_Selected = Nothing
        Me.btnFuncionalidad.Iconimage_Selected = Nothing
        Me.btnFuncionalidad.IconMarginLeft = 0
        Me.btnFuncionalidad.IconMarginRight = 0
        Me.btnFuncionalidad.IconRightVisible = True
        Me.btnFuncionalidad.IconRightZoom = 0R
        Me.btnFuncionalidad.IconVisible = True
        Me.btnFuncionalidad.IconZoom = 50.0R
        Me.btnFuncionalidad.IsTab = False
        Me.btnFuncionalidad.Location = New System.Drawing.Point(7, 3)
        Me.btnFuncionalidad.Margin = New System.Windows.Forms.Padding(7, 3, 3, 3)
        Me.btnFuncionalidad.Name = "btnFuncionalidad"
        Me.btnFuncionalidad.Normalcolor = System.Drawing.Color.Transparent
        Me.btnFuncionalidad.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnFuncionalidad.OnHoverTextColor = System.Drawing.Color.White
        Me.btnFuncionalidad.selected = True
        Me.btnFuncionalidad.Size = New System.Drawing.Size(230, 69)
        Me.btnFuncionalidad.TabIndex = 19
        Me.btnFuncionalidad.Text = "        FUNCIONALIDAD"
        Me.btnFuncionalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFuncionalidad.Textcolor = System.Drawing.Color.White
        Me.btnFuncionalidad.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnConsultas
        '
        Me.btnConsultas.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnConsultas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsultas.BackColor = System.Drawing.Color.Transparent
        Me.btnConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultas.BorderRadius = 7
        Me.btnConsultas.ButtonText = "         CONSULTAS"
        Me.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultas.DisabledColor = System.Drawing.Color.Gray
        Me.btnConsultas.Iconcolor = System.Drawing.Color.Transparent
        Me.btnConsultas.Iconimage = CType(resources.GetObject("btnConsultas.Iconimage"), System.Drawing.Image)
        Me.btnConsultas.Iconimage_right = Nothing
        Me.btnConsultas.Iconimage_right_Selected = Nothing
        Me.btnConsultas.Iconimage_Selected = Nothing
        Me.btnConsultas.IconMarginLeft = 0
        Me.btnConsultas.IconMarginRight = 0
        Me.btnConsultas.IconRightVisible = True
        Me.btnConsultas.IconRightZoom = 0R
        Me.btnConsultas.IconVisible = True
        Me.btnConsultas.IconZoom = 50.0R
        Me.btnConsultas.IsTab = False
        Me.btnConsultas.Location = New System.Drawing.Point(254, 3)
        Me.btnConsultas.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Normalcolor = System.Drawing.Color.Transparent
        Me.btnConsultas.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnConsultas.OnHoverTextColor = System.Drawing.Color.White
        Me.btnConsultas.selected = True
        Me.btnConsultas.Size = New System.Drawing.Size(230, 69)
        Me.btnConsultas.TabIndex = 20
        Me.btnConsultas.Text = "         CONSULTAS"
        Me.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultas.Textcolor = System.Drawing.Color.White
        Me.btnConsultas.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BunifuFlatButton5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 7
        Me.BunifuFlatButton5.ButtonText = "         REGISTROS"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = CType(resources.GetObject("BunifuFlatButton5.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 50.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(501, 3)
        Me.BunifuFlatButton5.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = True
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(230, 69)
        Me.BunifuFlatButton5.TabIndex = 21
        Me.BunifuFlatButton5.Text = "         REGISTROS"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'OperacionesMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(796, 75)
        Me.Controls.Add(Me.Submenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OperacionesMenu"
        Me.Text = "OperacionesMenu"
        Me.Submenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Submenu As FlowLayoutPanel
    Private WithEvents btnFuncionalidad As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnConsultas As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
End Class
