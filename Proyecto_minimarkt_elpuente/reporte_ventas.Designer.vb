<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte_ventas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.lblHoy = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.btnHoy = New System.Windows.Forms.Button()
        Me.btnSemana = New System.Windows.Forms.Button()
        Me.btnMes = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.lblResumen = New System.Windows.Forms.Label()
        Me.lblSemana = New System.Windows.Forms.Label()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.Button_volver = New System.Windows.Forms.Button()
        Me.DETALLE = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpDesde
        '
        Me.dtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.dtpDesde.Location = New System.Drawing.Point(37, 232)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(382, 34)
        Me.dtpDesde.TabIndex = 0
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnConsultar.Location = New System.Drawing.Point(282, 108)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(126, 58)
        Me.btnConsultar.TabIndex = 1
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'dgvVentas
        '
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVentas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVentas.Location = New System.Drawing.Point(445, 138)
        Me.dgvVentas.Name = "dgvVentas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVentas.RowHeadersWidth = 51
        Me.dgvVentas.RowTemplate.Height = 24
        Me.dgvVentas.Size = New System.Drawing.Size(1087, 415)
        Me.dgvVentas.TabIndex = 2
        '
        'lblHoy
        '
        Me.lblHoy.AutoSize = True
        Me.lblHoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblHoy.Location = New System.Drawing.Point(322, 720)
        Me.lblHoy.Name = "lblHoy"
        Me.lblHoy.Size = New System.Drawing.Size(86, 29)
        Me.lblHoy.TabIndex = 3
        Me.lblHoy.Text = "Label1"
        '
        'dtpHasta
        '
        Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.dtpHasta.Location = New System.Drawing.Point(37, 335)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(382, 34)
        Me.dtpHasta.TabIndex = 0
        '
        'btnHoy
        '
        Me.btnHoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnHoy.Location = New System.Drawing.Point(100, 453)
        Me.btnHoy.Name = "btnHoy"
        Me.btnHoy.Size = New System.Drawing.Size(126, 58)
        Me.btnHoy.TabIndex = 1
        Me.btnHoy.Text = "Hoy"
        Me.btnHoy.UseVisualStyleBackColor = True
        '
        'btnSemana
        '
        Me.btnSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnSemana.Location = New System.Drawing.Point(100, 531)
        Me.btnSemana.Name = "btnSemana"
        Me.btnSemana.Size = New System.Drawing.Size(126, 58)
        Me.btnSemana.TabIndex = 1
        Me.btnSemana.Text = "Semana"
        Me.btnSemana.UseVisualStyleBackColor = True
        '
        'btnMes
        '
        Me.btnMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnMes.Location = New System.Drawing.Point(245, 531)
        Me.btnMes.Name = "btnMes"
        Me.btnMes.Size = New System.Drawing.Size(126, 58)
        Me.btnMes.TabIndex = 1
        Me.btnMes.Text = "Mes"
        Me.btnMes.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnExportar.Location = New System.Drawing.Point(100, 625)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(126, 58)
        Me.btnExportar.TabIndex = 1
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalle.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDetalle.Location = New System.Drawing.Point(973, 580)
        Me.dgvDetalle.Name = "dgvDetalle"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDetalle.RowHeadersWidth = 51
        Me.dgvDetalle.RowTemplate.Height = 24
        Me.dgvDetalle.Size = New System.Drawing.Size(539, 247)
        Me.dgvDetalle.TabIndex = 2
        '
        'lblResumen
        '
        Me.lblResumen.AutoSize = True
        Me.lblResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblResumen.Location = New System.Drawing.Point(322, 800)
        Me.lblResumen.Name = "lblResumen"
        Me.lblResumen.Size = New System.Drawing.Size(86, 29)
        Me.lblResumen.TabIndex = 3
        Me.lblResumen.Text = "Label1"
        '
        'lblSemana
        '
        Me.lblSemana.AutoSize = True
        Me.lblSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblSemana.Location = New System.Drawing.Point(518, 720)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(86, 29)
        Me.lblSemana.TabIndex = 3
        Me.lblSemana.Text = "Label1"
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblMes.Location = New System.Drawing.Point(518, 800)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(86, 29)
        Me.lblMes.TabIndex = 3
        Me.lblMes.Text = "Label1"
        '
        'Button_volver
        '
        Me.Button_volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_volver.Location = New System.Drawing.Point(37, 28)
        Me.Button_volver.Name = "Button_volver"
        Me.Button_volver.Size = New System.Drawing.Size(210, 50)
        Me.Button_volver.TabIndex = 12
        Me.Button_volver.Text = "Volver al menú"
        Me.Button_volver.UseVisualStyleBackColor = True
        '
        'DETALLE
        '
        Me.DETALLE.AutoSize = True
        Me.DETALLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.DETALLE.Location = New System.Drawing.Point(752, 580)
        Me.DETALLE.Name = "DETALLE"
        Me.DETALLE.Size = New System.Drawing.Size(192, 29)
        Me.DETALLE.TabIndex = 3
        Me.DETALLE.Text = "Detalle de venta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(34, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Consulta por fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(32, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(34, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hasta:"
        '
        'reporte_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1573, 863)
        Me.Controls.Add(Me.Button_volver)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DETALLE)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.lblSemana)
        Me.Controls.Add(Me.lblResumen)
        Me.Controls.Add(Me.lblHoy)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnMes)
        Me.Controls.Add(Me.btnSemana)
        Me.Controls.Add(Me.btnHoy)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.dtpDesde)
        Me.Name = "reporte_ventas"
        Me.Text = "reporte_ventas"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents btnConsultar As Button
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents lblHoy As Label
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents btnHoy As Button
    Friend WithEvents btnSemana As Button
    Friend WithEvents btnMes As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents lblResumen As Label
    Friend WithEvents lblSemana As Label
    Friend WithEvents lblMes As Label
    Friend WithEvents Button_volver As Button
    Friend WithEvents DETALLE As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
