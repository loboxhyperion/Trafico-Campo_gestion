<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AntenaPlugAndPlay
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
        Me.lblTimeOut = New System.Windows.Forms.Label()
        Me.lblMessageAntena = New System.Windows.Forms.Label()
        Me.Conexion = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrPuertoCom = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEscuchando = New System.Windows.Forms.Timer(Me.components)
        Me.tmrContador = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblTimeOut
        '
        Me.lblTimeOut.AutoSize = True
        Me.lblTimeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOut.ForeColor = System.Drawing.Color.White
        Me.lblTimeOut.Location = New System.Drawing.Point(374, 229)
        Me.lblTimeOut.Name = "lblTimeOut"
        Me.lblTimeOut.Size = New System.Drawing.Size(53, 37)
        Me.lblTimeOut.TabIndex = 181
        Me.lblTimeOut.Text = "20"
        '
        'lblMessageAntena
        '
        Me.lblMessageAntena.AutoSize = True
        Me.lblMessageAntena.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageAntena.ForeColor = System.Drawing.Color.White
        Me.lblMessageAntena.Location = New System.Drawing.Point(265, 184)
        Me.lblMessageAntena.Name = "lblMessageAntena"
        Me.lblMessageAntena.Size = New System.Drawing.Size(270, 29)
        Me.lblMessageAntena.TabIndex = 180
        Me.lblMessageAntena.Text = "CONECTE LA ANTENA"
        '
        'tmrPuertoCom
        '
        Me.tmrPuertoCom.Enabled = True
        Me.tmrPuertoCom.Interval = 1000
        '
        'tmrEscuchando
        '
        '
        'tmrContador
        '
        Me.tmrContador.Interval = 1000
        '
        'AntenaPlugAndPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 417)
        Me.Controls.Add(Me.lblTimeOut)
        Me.Controls.Add(Me.lblMessageAntena)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AntenaPlugAndPlay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AntenaPlugAndPlay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTimeOut As Label
    Friend WithEvents lblMessageAntena As Label
    Friend WithEvents Conexion As IO.Ports.SerialPort
    Friend WithEvents tmrPuertoCom As Timer
    Friend WithEvents tmrEscuchando As Timer
    Friend WithEvents tmrContador As Timer
End Class
