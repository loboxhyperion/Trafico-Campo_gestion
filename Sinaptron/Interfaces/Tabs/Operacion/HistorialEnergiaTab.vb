Public Class HistorialEnergiaTab
    Dim FlagAutoGraficar As Boolean = False

    Dim nombreSinap As String

    Private Sub HistorialEnergiaTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nombreSinap = ""
        'Le damos formato a los DataTimerPicker
        dtpFrom.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
        dtpTo.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"

        ' dtpFrom.Value = DateTime.ParseExact("14/09/2020 6:30 a.m", "dd//MM/yyyy hh:mm:ss tt ", CultureInfo.CurrentCulture, DateTimeStyles.None)

        Try
            'OPERACION TERNARIA
            Dim result = IIf(nombreSinap <> "", Energia.Consultar(nombreSinap), Energia.ConsultarTodo())

            If result.Count > 0 Then
                'si de estadoSinpatron pasa por aca
                If nombreSinap <> "" Then

                    'Carga los datos del datagridview
                    CargarDatos(result, False)

                Else
                    For Each item In result
                        If Not cboSinaptron.Items.Contains(item.Item(1)) Then
                            cboSinaptron.Items.Add(item.Item(1))
                        End If

                    Next
                End If
            Else
                'no hay nada para mostrar
            End If

        Catch ex As Exception

        End Try
    End Sub
    'Método para llenar datos de fecha
    Private Sub CargarDatos(result, FlagFiltro)

        For Each item In result
            'con filtro
            If FlagFiltro Then

                If (CDate(item.Item(2).ToString) >= CDate(dtpFrom.Value) And CDate(item.Item(2).ToString) <= CDate(dtpTo.Value)) Then

                    Dim countRows As Integer = DataGridView1.Rows.Add() 'Cuenta el numero de filas actuales
                    DataGridView1.Rows.Item(countRows).Cells(0).Value = countRows + 1

                    DataGridView1.Rows.Item(countRows).Cells(1).Value = item.Item(1)
                    DataGridView1.Rows.Item(countRows).Cells(2).Value = item.Item(2)
                    DataGridView1.Rows.Item(countRows).Cells(3).Value = item.Item(3)
                    DataGridView1.Rows.Item(countRows).Cells(4).Value = item.Item(4)
                End If
            Else
                Dim countRows As Integer = DataGridView1.Rows.Add() 'Cuenta el numero de filas actuales
                DataGridView1.Rows.Item(countRows).Cells(0).Value = countRows + 1

                DataGridView1.Rows.Item(countRows).Cells(1).Value = item.Item(1)
                DataGridView1.Rows.Item(countRows).Cells(2).Value = item.Item(2)
                DataGridView1.Rows.Item(countRows).Cells(3).Value = item.Item(3)
                DataGridView1.Rows.Item(countRows).Cells(4).Value = item.Item(4)
            End If

        Next
    End Sub

    Private Sub Graficar()
        Try
            DataGridView1.Rows.Clear()
            Grafico5.Series.Clear()
            Grafico5.Series.Add("Bateria")
            Grafico5.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
            Grafico5.Series(0).Color = Color.Red
            Grafico5.Series(0).MarkerSize = 5
            Grafico5.Series(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle

            Grafico5.ChartAreas(0).AxisX.Interval = 1
            'Chart1.ChartAreas(0).AxisY.Interval = 0.5
            Grafico5.ChartAreas(0).AxisY.Minimum = 8
            Grafico5.ChartAreas(0).AxisY.Maximum = 14


            'Chart2.Series.Clear()
            ' Chart2.Series.Add("Panel")
            'Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
            'Chart2.Series(0).Color = Color.Red
            ' Chart2.Series(0).MarkerSize = 10
            ' Chart2.Series(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            'Chart2.ChartAreas(0).AxisX.Interval = 1
            'Chart1.ChartAreas(0).AxisY.Interval = 0.5
            'Chart2.ChartAreas(0).AxisY.Minimum = 8
            'Chart2.ChartAreas(0).AxisY.Maximum = 14

            'MessageBox.Show(cboSinaptron.SelectedItem)
            'Dim result = Energia.Consultar(cboSinaptron.SelectedItem)
            Dim result = Energia.Consultar("X:132 Y:135")
            If result.Count > 0 Then
                'Carga los datos del datagridview
                CargarDatos(result, True)
                'Grafica los datos
                For Each item In result

                    'si pasa el filtro de la fecha pasa
                    If CDate(item.Item(2).ToString) >= CDate(dtpFrom.Value) And CDate(item.Item(2).ToString) <= CDate(dtpTo.Value) Then
                        'Title
                        'Chart1.Titles.Add(item.Item(2).ToString())

                        'Data
                        'Chart1.ChartAreas(0).AxisX.LabelStyle.Angle = -90

                        Grafico5.Series("Bateria").Points.AddXY(item.Item(2).ToString(), item.Item(3).ToDouble)
                        'Chart1.Series("Bateria").ToolTip = item.Item(2).ToString()

                        'Title

                        'Data
                        'Chart2.Series("Panel").Points.AddXY(item.Item(2).ToString, item.Item(4).ToDouble)

                    End If

                Next

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tmrHistorial_Tick(sender As Object, e As EventArgs) Handles tmrHistorial.Tick
        If FlagAutoGraficar Then
            dtpTo.Value = Format(Date.Now, "dd/MM/yyyy HH:mm:ss tt")
            Graficar()
        End If
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        ExportarExcel.llenarExcel(DataGridView1)
    End Sub

    Private Sub btnGraficar_Click(sender As Object, e As EventArgs) Handles btnGraficar.Click
        Graficar()
    End Sub

    Private Sub btnAutoGraficar_Click(sender As Object, e As EventArgs) Handles btnAutoGraficar.Click
        If Not FlagAutoGraficar Then
            Label1.Text = "ON"
            Label1.ForeColor = Color.Green
            FlagAutoGraficar = True
        Else
            Label1.Text = "OFF"
            Label1.ForeColor = Color.Red
            FlagAutoGraficar = False
        End If
    End Sub


End Class