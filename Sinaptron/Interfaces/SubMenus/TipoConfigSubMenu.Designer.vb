<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoConfigSubMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TipoConfigSubMenu))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnTipos = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSemaforo = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPareSiga = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ColapzarTipos = New System.Windows.Forms.Timer(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.btnTipos)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSemaforo)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPareSiga)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.MaximumSize = New System.Drawing.Size(340, 160)
        Me.FlowLayoutPanel1.MinimumSize = New System.Drawing.Size(340, 50)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(340, 50)
        Me.FlowLayoutPanel1.TabIndex = 399
        '
        'btnTipos
        '
        Me.btnTipos.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnTipos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnTipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTipos.BorderRadius = 7
        Me.btnTipos.ButtonText = "TIPO DE CONFIGURACION"
        Me.btnTipos.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTipos.DisabledColor = System.Drawing.Color.Gray
        Me.btnTipos.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTipos.Iconimage = Nothing
        Me.btnTipos.Iconimage_right = Global.Sinaptron.My.Resources.Resources.ARROW_DASHBOARD_EXPANDIR
        Me.btnTipos.Iconimage_right_Selected = Nothing
        Me.btnTipos.Iconimage_Selected = Nothing
        Me.btnTipos.IconMarginLeft = 0
        Me.btnTipos.IconMarginRight = 0
        Me.btnTipos.IconRightVisible = True
        Me.btnTipos.IconRightZoom = 0R
        Me.btnTipos.IconVisible = True
        Me.btnTipos.IconZoom = 50.0R
        Me.btnTipos.IsTab = False
        Me.btnTipos.Location = New System.Drawing.Point(2, 0)
        Me.btnTipos.Margin = New System.Windows.Forms.Padding(2, 0, 3, 2)
        Me.btnTipos.Name = "btnTipos"
        Me.btnTipos.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnTipos.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnTipos.OnHoverTextColor = System.Drawing.Color.White
        Me.btnTipos.selected = True
        Me.btnTipos.Size = New System.Drawing.Size(336, 50)
        Me.btnTipos.TabIndex = 375
        Me.btnTipos.Text = "TIPO DE CONFIGURACION"
        Me.btnTipos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnTipos.Textcolor = System.Drawing.Color.White
        Me.btnTipos.TextFont = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSemaforo
        '
        Me.btnSemaforo.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSemaforo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSemaforo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSemaforo.BorderRadius = 7
        Me.btnSemaforo.ButtonText = "      SEMAFORO"
        Me.btnSemaforo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSemaforo.DisabledColor = System.Drawing.Color.Gray
        Me.btnSemaforo.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSemaforo.Iconimage = CType(resources.GetObject("btnSemaforo.Iconimage"), System.Drawing.Image)
        Me.btnSemaforo.Iconimage_right = Nothing
        Me.btnSemaforo.Iconimage_right_Selected = Nothing
        Me.btnSemaforo.Iconimage_Selected = Nothing
        Me.btnSemaforo.IconMarginLeft = 0
        Me.btnSemaforo.IconMarginRight = 0
        Me.btnSemaforo.IconRightVisible = True
        Me.btnSemaforo.IconRightZoom = 0R
        Me.btnSemaforo.IconVisible = True
        Me.btnSemaforo.IconZoom = 50.0R
        Me.btnSemaforo.IsTab = False
        Me.btnSemaforo.Location = New System.Drawing.Point(14, 66)
        Me.btnSemaforo.Margin = New System.Windows.Forms.Padding(14, 14, 0, 2)
        Me.btnSemaforo.Name = "btnSemaforo"
        Me.btnSemaforo.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSemaforo.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSemaforo.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSemaforo.selected = True
        Me.btnSemaforo.Size = New System.Drawing.Size(236, 41)
        Me.btnSemaforo.TabIndex = 374
        Me.btnSemaforo.Text = "      SEMAFORO"
        Me.btnSemaforo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSemaforo.Textcolor = System.Drawing.Color.White
        Me.btnSemaforo.TextFont = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnPareSiga
        '
        Me.btnPareSiga.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnPareSiga.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPareSiga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPareSiga.BorderRadius = 7
        Me.btnPareSiga.ButtonText = "     PARE Y SIGA"
        Me.btnPareSiga.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPareSiga.DisabledColor = System.Drawing.Color.Gray
        Me.btnPareSiga.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPareSiga.Iconimage = CType(resources.GetObject("btnPareSiga.Iconimage"), System.Drawing.Image)
        Me.btnPareSiga.Iconimage_right = Nothing
        Me.btnPareSiga.Iconimage_right_Selected = Nothing
        Me.btnPareSiga.Iconimage_Selected = Nothing
        Me.btnPareSiga.IconMarginLeft = 0
        Me.btnPareSiga.IconMarginRight = 0
        Me.btnPareSiga.IconRightVisible = True
        Me.btnPareSiga.IconRightZoom = 0R
        Me.btnPareSiga.IconVisible = True
        Me.btnPareSiga.IconZoom = 50.0R
        Me.btnPareSiga.IsTab = False
        Me.btnPareSiga.Location = New System.Drawing.Point(14, 109)
        Me.btnPareSiga.Margin = New System.Windows.Forms.Padding(14, 0, 3, 2)
        Me.btnPareSiga.Name = "btnPareSiga"
        Me.btnPareSiga.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPareSiga.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnPareSiga.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPareSiga.selected = True
        Me.btnPareSiga.Size = New System.Drawing.Size(236, 41)
        Me.btnPareSiga.TabIndex = 376
        Me.btnPareSiga.Text = "     PARE Y SIGA"
        Me.btnPareSiga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPareSiga.Textcolor = System.Drawing.Color.White
        Me.btnPareSiga.TextFont = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ColapzarTipos
        '
        Me.ColapzarTipos.Interval = 2
        '
        'TipoConfigSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(341, 606)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "TipoConfigSubMenu"
        Me.Text = "TipoConfigSubMenu"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Private WithEvents btnTipos As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnSemaforo As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnPareSiga As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents ColapzarTipos As Timer
End Class
