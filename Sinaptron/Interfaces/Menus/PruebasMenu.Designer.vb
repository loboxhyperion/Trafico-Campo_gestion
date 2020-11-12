<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PruebasMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PruebasMenu))
        Me.Submenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnFuncionalidad = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnBasico = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Submenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Submenu
        '
        Me.Submenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Submenu.AutoSize = True
        Me.Submenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Submenu.Controls.Add(Me.btnBasico)
        Me.Submenu.Controls.Add(Me.btnFuncionalidad)
        Me.Submenu.Location = New System.Drawing.Point(0, 0)
        Me.Submenu.Name = "Submenu"
        Me.Submenu.Size = New System.Drawing.Size(796, 75)
        Me.Submenu.TabIndex = 2
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
        Me.btnFuncionalidad.Location = New System.Drawing.Point(247, 3)
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
        'btnBasico
        '
        Me.btnBasico.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnBasico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBasico.BackColor = System.Drawing.Color.Transparent
        Me.btnBasico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBasico.BorderRadius = 7
        Me.btnBasico.ButtonText = "        BASICO"
        Me.btnBasico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBasico.DisabledColor = System.Drawing.Color.Gray
        Me.btnBasico.Iconcolor = System.Drawing.Color.Transparent
        Me.btnBasico.Iconimage = CType(resources.GetObject("btnBasico.Iconimage"), System.Drawing.Image)
        Me.btnBasico.Iconimage_right = Nothing
        Me.btnBasico.Iconimage_right_Selected = Nothing
        Me.btnBasico.Iconimage_Selected = Nothing
        Me.btnBasico.IconMarginLeft = 0
        Me.btnBasico.IconMarginRight = 0
        Me.btnBasico.IconRightVisible = True
        Me.btnBasico.IconRightZoom = 0R
        Me.btnBasico.IconVisible = True
        Me.btnBasico.IconZoom = 50.0R
        Me.btnBasico.IsTab = False
        Me.btnBasico.Location = New System.Drawing.Point(7, 3)
        Me.btnBasico.Margin = New System.Windows.Forms.Padding(7, 3, 3, 3)
        Me.btnBasico.Name = "btnBasico"
        Me.btnBasico.Normalcolor = System.Drawing.Color.Transparent
        Me.btnBasico.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnBasico.OnHoverTextColor = System.Drawing.Color.White
        Me.btnBasico.selected = True
        Me.btnBasico.Size = New System.Drawing.Size(230, 69)
        Me.btnBasico.TabIndex = 20
        Me.btnBasico.Text = "        BASICO"
        Me.btnBasico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBasico.Textcolor = System.Drawing.Color.White
        Me.btnBasico.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PruebasMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 75)
        Me.Controls.Add(Me.Submenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PruebasMenu"
        Me.Text = "PruebasMenu"
        Me.Submenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Submenu As FlowLayoutPanel
    Private WithEvents btnFuncionalidad As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnBasico As Bunifu.Framework.UI.BunifuFlatButton
End Class
