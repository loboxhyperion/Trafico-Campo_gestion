<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialEnergiaTab
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
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistorialEnergiaTab))
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend9 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnAutoGraficar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnGraficar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnExcel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.DataGridView1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sinaptron = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bateria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSinaptron = New System.Windows.Forms.ComboBox()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelChart2 = New System.Windows.Forms.Panel()
        Me.label21 = New System.Windows.Forms.Label()
        Me.label22 = New System.Windows.Forms.Label()
        Me.Grafico5 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tmrHistorial = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelChart2.SuspendLayout()
        CType(Me.Grafico5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAutoGraficar
        '
        Me.btnAutoGraficar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAutoGraficar.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnAutoGraficar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAutoGraficar.BorderRadius = 7
        Me.btnAutoGraficar.ButtonText = "Auto Graficar"
        Me.btnAutoGraficar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAutoGraficar.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnAutoGraficar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAutoGraficar.Iconimage = Nothing
        Me.btnAutoGraficar.Iconimage_right = Nothing
        Me.btnAutoGraficar.Iconimage_right_Selected = Nothing
        Me.btnAutoGraficar.Iconimage_Selected = Nothing
        Me.btnAutoGraficar.IconMarginLeft = 0
        Me.btnAutoGraficar.IconMarginRight = 0
        Me.btnAutoGraficar.IconRightVisible = True
        Me.btnAutoGraficar.IconRightZoom = 0R
        Me.btnAutoGraficar.IconVisible = True
        Me.btnAutoGraficar.IconZoom = 50.0R
        Me.btnAutoGraficar.IsTab = False
        Me.btnAutoGraficar.Location = New System.Drawing.Point(565, 71)
        Me.btnAutoGraficar.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.btnAutoGraficar.Name = "btnAutoGraficar"
        Me.btnAutoGraficar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnAutoGraficar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnAutoGraficar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAutoGraficar.selected = True
        Me.btnAutoGraficar.Size = New System.Drawing.Size(151, 33)
        Me.btnAutoGraficar.TabIndex = 300
        Me.btnAutoGraficar.Text = "Auto Graficar"
        Me.btnAutoGraficar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAutoGraficar.Textcolor = System.Drawing.Color.White
        Me.btnAutoGraficar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnGraficar
        '
        Me.btnGraficar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGraficar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGraficar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGraficar.BorderRadius = 7
        Me.btnGraficar.ButtonText = "Graficar"
        Me.btnGraficar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGraficar.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnGraficar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnGraficar.Iconimage = Nothing
        Me.btnGraficar.Iconimage_right = Nothing
        Me.btnGraficar.Iconimage_right_Selected = Nothing
        Me.btnGraficar.Iconimage_Selected = Nothing
        Me.btnGraficar.IconMarginLeft = 0
        Me.btnGraficar.IconMarginRight = 0
        Me.btnGraficar.IconRightVisible = True
        Me.btnGraficar.IconRightZoom = 0R
        Me.btnGraficar.IconVisible = True
        Me.btnGraficar.IconZoom = 50.0R
        Me.btnGraficar.IsTab = False
        Me.btnGraficar.Location = New System.Drawing.Point(403, 71)
        Me.btnGraficar.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.btnGraficar.Name = "btnGraficar"
        Me.btnGraficar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGraficar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnGraficar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGraficar.selected = True
        Me.btnGraficar.Size = New System.Drawing.Size(151, 33)
        Me.btnGraficar.TabIndex = 299
        Me.btnGraficar.Text = "Graficar"
        Me.btnGraficar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGraficar.Textcolor = System.Drawing.Color.White
        Me.btnGraficar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnExcel
        '
        Me.btnExcel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcel.BorderRadius = 7
        Me.btnExcel.ButtonText = "Exportar Excel"
        Me.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcel.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnExcel.Iconcolor = System.Drawing.Color.Transparent
        Me.btnExcel.Iconimage = Nothing
        Me.btnExcel.Iconimage_right = Nothing
        Me.btnExcel.Iconimage_right_Selected = Nothing
        Me.btnExcel.Iconimage_Selected = Nothing
        Me.btnExcel.IconMarginLeft = 0
        Me.btnExcel.IconMarginRight = 0
        Me.btnExcel.IconRightVisible = True
        Me.btnExcel.IconRightZoom = 0R
        Me.btnExcel.IconVisible = True
        Me.btnExcel.IconZoom = 50.0R
        Me.btnExcel.IsTab = False
        Me.btnExcel.Location = New System.Drawing.Point(242, 71)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnExcel.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExcel.OnHoverTextColor = System.Drawing.Color.White
        Me.btnExcel.selected = True
        Me.btnExcel.Size = New System.Drawing.Size(151, 33)
        Me.btnExcel.TabIndex = 298
        Me.btnExcel.Text = "Exportar Excel"
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnExcel.Textcolor = System.Drawing.Color.White
        Me.btnExcel.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DataGridView1
        '
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.DataGridView1.ColumnHeadersHeight = 50
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num, Me.sinaptron, Me.fecha, Me.bateria, Me.panel})
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridView1.DoubleBuffered = True
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.DataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(1, 110)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.DividerHeight = 3
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(553, 481)
        Me.DataGridView1.TabIndex = 297
        '
        'num
        '
        Me.num.HeaderText = "#"
        Me.num.Name = "num"
        '
        'sinaptron
        '
        Me.sinaptron.HeaderText = "Sinaptron"
        Me.sinaptron.Name = "sinaptron"
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        '
        'bateria
        '
        Me.bateria.HeaderText = "Bateria"
        Me.bateria.Name = "bateria"
        '
        'panel
        '
        Me.panel.HeaderText = "Panel"
        Me.panel.Name = "panel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(722, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 20)
        Me.Label1.TabIndex = 296
        Me.Label1.Text = "OFF"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(343, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 294
        Me.Label5.Text = "Sinaptron:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(343, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 295
        Me.Label4.Text = "Sinaptron:"
        '
        'cboSinaptron
        '
        Me.cboSinaptron.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSinaptron.FormattingEnabled = True
        Me.cboSinaptron.Location = New System.Drawing.Point(419, 16)
        Me.cboSinaptron.Name = "cboSinaptron"
        Me.cboSinaptron.Size = New System.Drawing.Size(200, 20)
        Me.cboSinaptron.TabIndex = 293
        Me.cboSinaptron.Text = "Seleccionar"
        '
        'dtpTo
        '
        Me.dtpTo.Checked = False
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(516, 45)
        Me.dtpTo.MaxDate = New Date(2200, 12, 31, 0, 0, 0, 0)
        Me.dtpTo.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(200, 20)
        Me.dtpTo.TabIndex = 291
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(251, 45)
        Me.dtpFrom.MaxDate = New Date(2200, 12, 31, 0, 0, 0, 0)
        Me.dtpFrom.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(200, 20)
        Me.dtpFrom.TabIndex = 290
        Me.dtpFrom.Value = New Date(2020, 9, 14, 6, 3, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(468, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 289
        Me.Label3.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(199, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 288
        Me.Label2.Text = "Desde:"
        '
        'PanelChart2
        '
        Me.PanelChart2.BackgroundImage = CType(resources.GetObject("PanelChart2.BackgroundImage"), System.Drawing.Image)
        Me.PanelChart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelChart2.Controls.Add(Me.label21)
        Me.PanelChart2.Controls.Add(Me.label22)
        Me.PanelChart2.Controls.Add(Me.Grafico5)
        Me.PanelChart2.Location = New System.Drawing.Point(561, 110)
        Me.PanelChart2.Name = "PanelChart2"
        Me.PanelChart2.Size = New System.Drawing.Size(460, 481)
        Me.PanelChart2.TabIndex = 287
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.BackColor = System.Drawing.Color.Transparent
        Me.label21.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label21.ForeColor = System.Drawing.Color.White
        Me.label21.Location = New System.Drawing.Point(35, 48)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(150, 34)
        Me.label21.TabIndex = 8
        Me.label21.Text = "ULTIMOS AÑOS"
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.BackColor = System.Drawing.Color.Transparent
        Me.label22.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label22.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.label22.Location = New System.Drawing.Point(39, 29)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(115, 23)
        Me.label22.TabIndex = 7
        Me.label22.Text = "Siempre contigo"
        '
        'Grafico5
        '
        Me.Grafico5.BackColor = System.Drawing.Color.Transparent
        ChartArea9.AxisX.IsLabelAutoFit = False
        ChartArea9.AxisX.LabelStyle.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea9.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver
        ChartArea9.AxisX.LineColor = System.Drawing.Color.Transparent
        ChartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea9.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent
        ChartArea9.AxisY.IsLabelAutoFit = False
        ChartArea9.AxisY.LabelStyle.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea9.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver
        ChartArea9.AxisY.LineColor = System.Drawing.Color.Transparent
        ChartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea9.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent
        ChartArea9.BackColor = System.Drawing.Color.Transparent
        ChartArea9.Name = "ChartArea1"
        Me.Grafico5.ChartAreas.Add(ChartArea9)
        Legend9.Enabled = False
        Legend9.Name = "Legend1"
        Me.Grafico5.Legends.Add(Legend9)
        Me.Grafico5.Location = New System.Drawing.Point(-1, 111)
        Me.Grafico5.Name = "Grafico5"
        Series9.BorderWidth = 4
        Series9.ChartArea = "ChartArea1"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series9.Color = System.Drawing.Color.DimGray
        Series9.Legend = "Legend1"
        Series9.Name = "Series1"
        Series9.YValuesPerPoint = 2
        Me.Grafico5.Series.Add(Series9)
        Me.Grafico5.Size = New System.Drawing.Size(468, 266)
        Me.Grafico5.TabIndex = 1
        Me.Grafico5.Text = "chart2"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me.DataGridView1
        '
        'tmrHistorial
        '
        Me.tmrHistorial.Enabled = True
        Me.tmrHistorial.Interval = 15000
        '
        'HistorialEnergiaTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1023, 606)
        Me.Controls.Add(Me.btnAutoGraficar)
        Me.Controls.Add(Me.btnGraficar)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboSinaptron)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelChart2)
        Me.Name = "HistorialEnergiaTab"
        Me.Text = "HistorialEnergiaTab"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelChart2.ResumeLayout(False)
        Me.PanelChart2.PerformLayout()
        CType(Me.Grafico5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnAutoGraficar As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnGraficar As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnExcel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DataGridView1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents sinaptron As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents bateria As DataGridViewTextBoxColumn
    Friend WithEvents panel As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboSinaptron As ComboBox
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents PanelChart2 As Panel
    Private WithEvents label21 As Label
    Private WithEvents label22 As Label
    Private WithEvents Grafico5 As DataVisualization.Charting.Chart
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents tmrHistorial As Timer
End Class
