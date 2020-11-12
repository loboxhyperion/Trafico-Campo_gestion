<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PruebasTab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PruebasTab))
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.btnTryIn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnTryOut = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnOffTest = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuFlatButton8 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton10 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SuspendLayout()
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 3
        Me.BunifuSeparator5.Location = New System.Drawing.Point(7, 46)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(322, 13)
        Me.BunifuSeparator5.TabIndex = 259
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = False
        '
        'btnTryIn
        '
        Me.btnTryIn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTryIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnTryIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTryIn.BorderRadius = 7
        Me.btnTryIn.ButtonText = "PROBAR SENSORES"
        Me.btnTryIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTryIn.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnTryIn.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTryIn.Iconimage = CType(resources.GetObject("btnTryIn.Iconimage"), System.Drawing.Image)
        Me.btnTryIn.Iconimage_right = Nothing
        Me.btnTryIn.Iconimage_right_Selected = Nothing
        Me.btnTryIn.Iconimage_Selected = Nothing
        Me.btnTryIn.IconMarginLeft = 0
        Me.btnTryIn.IconMarginRight = 0
        Me.btnTryIn.IconRightVisible = True
        Me.btnTryIn.IconRightZoom = 0R
        Me.btnTryIn.IconVisible = True
        Me.btnTryIn.IconZoom = 50.0R
        Me.btnTryIn.IsTab = False
        Me.btnTryIn.Location = New System.Drawing.Point(56, 257)
        Me.btnTryIn.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.btnTryIn.Name = "btnTryIn"
        Me.btnTryIn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnTryIn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTryIn.OnHoverTextColor = System.Drawing.Color.White
        Me.btnTryIn.selected = True
        Me.btnTryIn.Size = New System.Drawing.Size(218, 33)
        Me.btnTryIn.TabIndex = 283
        Me.btnTryIn.Text = "PROBAR SENSORES"
        Me.btnTryIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnTryIn.Textcolor = System.Drawing.Color.White
        Me.btnTryIn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnTryOut
        '
        Me.btnTryOut.Activecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTryOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnTryOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTryOut.BorderRadius = 7
        Me.btnTryOut.ButtonText = "PROBAR OPTICAS"
        Me.btnTryOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTryOut.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnTryOut.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTryOut.Iconimage = CType(resources.GetObject("btnTryOut.Iconimage"), System.Drawing.Image)
        Me.btnTryOut.Iconimage_right = Nothing
        Me.btnTryOut.Iconimage_right_Selected = Nothing
        Me.btnTryOut.Iconimage_Selected = Nothing
        Me.btnTryOut.IconMarginLeft = 0
        Me.btnTryOut.IconMarginRight = 0
        Me.btnTryOut.IconRightVisible = True
        Me.btnTryOut.IconRightZoom = 0R
        Me.btnTryOut.IconVisible = True
        Me.btnTryOut.IconZoom = 50.0R
        Me.btnTryOut.IsTab = False
        Me.btnTryOut.Location = New System.Drawing.Point(56, 134)
        Me.btnTryOut.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.btnTryOut.Name = "btnTryOut"
        Me.btnTryOut.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnTryOut.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTryOut.OnHoverTextColor = System.Drawing.Color.White
        Me.btnTryOut.selected = True
        Me.btnTryOut.Size = New System.Drawing.Size(218, 33)
        Me.btnTryOut.TabIndex = 284
        Me.btnTryOut.Text = "PROBAR OPTICAS"
        Me.btnTryOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnTryOut.Textcolor = System.Drawing.Color.White
        Me.btnTryOut.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnOffTest
        '
        Me.btnOffTest.Activecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnOffTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnOffTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOffTest.BorderRadius = 7
        Me.btnOffTest.ButtonText = "APAGAR PRUEBAS"
        Me.btnOffTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOffTest.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnOffTest.Iconcolor = System.Drawing.Color.Transparent
        Me.btnOffTest.Iconimage = CType(resources.GetObject("btnOffTest.Iconimage"), System.Drawing.Image)
        Me.btnOffTest.Iconimage_right = Nothing
        Me.btnOffTest.Iconimage_right_Selected = Nothing
        Me.btnOffTest.Iconimage_Selected = Nothing
        Me.btnOffTest.IconMarginLeft = 0
        Me.btnOffTest.IconMarginRight = 0
        Me.btnOffTest.IconRightVisible = True
        Me.btnOffTest.IconRightZoom = 0R
        Me.btnOffTest.IconVisible = True
        Me.btnOffTest.IconZoom = 50.0R
        Me.btnOffTest.IsTab = False
        Me.btnOffTest.Location = New System.Drawing.Point(56, 324)
        Me.btnOffTest.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.btnOffTest.Name = "btnOffTest"
        Me.btnOffTest.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnOffTest.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnOffTest.OnHoverTextColor = System.Drawing.Color.White
        Me.btnOffTest.selected = True
        Me.btnOffTest.Size = New System.Drawing.Size(218, 33)
        Me.btnOffTest.TabIndex = 285
        Me.btnOffTest.Text = "APAGAR PRUEBAS"
        Me.btnOffTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnOffTest.Textcolor = System.Drawing.Color.White
        Me.btnOffTest.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(10, 590)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(322, 13)
        Me.BunifuSeparator1.TabIndex = 286
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuFlatButton8
        '
        Me.BunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton8.BorderRadius = 7
        Me.BunifuFlatButton8.ButtonText = "PRUEBAS"
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
        Me.BunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton8.selected = True
        Me.BunifuFlatButton8.Size = New System.Drawing.Size(336, 41)
        Me.BunifuFlatButton8.TabIndex = 375
        Me.BunifuFlatButton8.Text = "PRUEBAS"
        Me.BunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton8.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton8.TextFont = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton10
        '
        Me.BunifuFlatButton10.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton10.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton10.BorderRadius = 7
        Me.BunifuFlatButton10.ButtonText = "ENTRADAS"
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
        Me.BunifuFlatButton10.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuFlatButton10.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton10.selected = True
        Me.BunifuFlatButton10.Size = New System.Drawing.Size(336, 41)
        Me.BunifuFlatButton10.TabIndex = 387
        Me.BunifuFlatButton10.Text = "ENTRADAS"
        Me.BunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton10.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton10.TextFont = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 7
        Me.BunifuFlatButton1.ButtonText = "SALIDAS"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(2, 191)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(14, 2, 3, 2)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = True
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(336, 41)
        Me.BunifuFlatButton1.TabIndex = 388
        Me.BunifuFlatButton1.Text = "SALIDAS"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PruebasTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(341, 606)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.BunifuFlatButton10)
        Me.Controls.Add(Me.BunifuFlatButton8)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.btnOffTest)
        Me.Controls.Add(Me.btnTryOut)
        Me.Controls.Add(Me.btnTryIn)
        Me.Controls.Add(Me.BunifuSeparator5)
        Me.Name = "PruebasTab"
        Me.Text = "S"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Private WithEvents btnTryIn As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnTryOut As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnOffTest As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Private WithEvents BunifuFlatButton8 As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents BunifuFlatButton10 As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
End Class
