<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetupMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetupMenu))
        Me.Submenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnConfiguracion = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Submenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Submenu
        '
        Me.Submenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Submenu.AutoSize = True
        Me.Submenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Submenu.Controls.Add(Me.btnConfiguracion)
        Me.Submenu.Location = New System.Drawing.Point(0, 0)
        Me.Submenu.Name = "Submenu"
        Me.Submenu.Size = New System.Drawing.Size(796, 75)
        Me.Submenu.TabIndex = 3
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnConfiguracion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfiguracion.BackColor = System.Drawing.Color.Transparent
        Me.btnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfiguracion.BorderRadius = 7
        Me.btnConfiguracion.ButtonText = "        TIPO DE CONFIGURACION "
        Me.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfiguracion.DisabledColor = System.Drawing.Color.Gray
        Me.btnConfiguracion.Iconcolor = System.Drawing.Color.Transparent
        Me.btnConfiguracion.Iconimage = CType(resources.GetObject("btnConfiguracion.Iconimage"), System.Drawing.Image)
        Me.btnConfiguracion.Iconimage_right = Nothing
        Me.btnConfiguracion.Iconimage_right_Selected = Nothing
        Me.btnConfiguracion.Iconimage_Selected = Nothing
        Me.btnConfiguracion.IconMarginLeft = 0
        Me.btnConfiguracion.IconMarginRight = 0
        Me.btnConfiguracion.IconRightVisible = True
        Me.btnConfiguracion.IconRightZoom = 0R
        Me.btnConfiguracion.IconVisible = True
        Me.btnConfiguracion.IconZoom = 50.0R
        Me.btnConfiguracion.IsTab = False
        Me.btnConfiguracion.Location = New System.Drawing.Point(7, 3)
        Me.btnConfiguracion.Margin = New System.Windows.Forms.Padding(7, 3, 3, 3)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Normalcolor = System.Drawing.Color.Transparent
        Me.btnConfiguracion.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnConfiguracion.OnHoverTextColor = System.Drawing.Color.White
        Me.btnConfiguracion.selected = True
        Me.btnConfiguracion.Size = New System.Drawing.Size(270, 69)
        Me.btnConfiguracion.TabIndex = 19
        Me.btnConfiguracion.Text = "        TIPO DE CONFIGURACION "
        Me.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfiguracion.Textcolor = System.Drawing.Color.White
        Me.btnConfiguracion.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SetupMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 75)
        Me.Controls.Add(Me.Submenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SetupMenu"
        Me.Text = "SetupMenu"
        Me.Submenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Submenu As FlowLayoutPanel
    Private WithEvents btnConfiguracion As Bunifu.Framework.UI.BunifuFlatButton
End Class
