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
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(167, 195)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(200, 22)
        Me.dtpDesde.TabIndex = 0
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(167, 444)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 1
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'dgvVentas
        '
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(379, 332)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.RowHeadersWidth = 51
        Me.dgvVentas.RowTemplate.Height = 24
        Me.dgvVentas.Size = New System.Drawing.Size(461, 290)
        Me.dgvVentas.TabIndex = 2
        '
        'lblHoy
        '
        Me.lblHoy.AutoSize = True
        Me.lblHoy.Location = New System.Drawing.Point(533, 119)
        Me.lblHoy.Name = "lblHoy"
        Me.lblHoy.Size = New System.Drawing.Size(51, 17)
        Me.lblHoy.TabIndex = 3
        Me.lblHoy.Text = "Label1"
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(167, 277)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(200, 22)
        Me.dtpHasta.TabIndex = 0
        '
        'btnHoy
        '
        Me.btnHoy.Location = New System.Drawing.Point(248, 444)
        Me.btnHoy.Name = "btnHoy"
        Me.btnHoy.Size = New System.Drawing.Size(75, 23)
        Me.btnHoy.TabIndex = 1
        Me.btnHoy.Text = "Hoy"
        Me.btnHoy.UseVisualStyleBackColor = True
        '
        'btnSemana
        '
        Me.btnSemana.Location = New System.Drawing.Point(167, 488)
        Me.btnSemana.Name = "btnSemana"
        Me.btnSemana.Size = New System.Drawing.Size(75, 23)
        Me.btnSemana.TabIndex = 1
        Me.btnSemana.Text = "Semana"
        Me.btnSemana.UseVisualStyleBackColor = True
        '
        'btnMes
        '
        Me.btnMes.Location = New System.Drawing.Point(248, 488)
        Me.btnMes.Name = "btnMes"
        Me.btnMes.Size = New System.Drawing.Size(75, 23)
        Me.btnMes.TabIndex = 1
        Me.btnMes.Text = "Mes"
        Me.btnMes.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(167, 531)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 23)
        Me.btnExportar.TabIndex = 1
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'dgvDetalle
        '
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(844, 119)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.RowHeadersWidth = 51
        Me.dgvDetalle.RowTemplate.Height = 24
        Me.dgvDetalle.Size = New System.Drawing.Size(339, 246)
        Me.dgvDetalle.TabIndex = 2
        '
        'lblResumen
        '
        Me.lblResumen.AutoSize = True
        Me.lblResumen.Location = New System.Drawing.Point(533, 179)
        Me.lblResumen.Name = "lblResumen"
        Me.lblResumen.Size = New System.Drawing.Size(51, 17)
        Me.lblResumen.TabIndex = 3
        Me.lblResumen.Text = "Label1"
        '
        'lblSemana
        '
        Me.lblSemana.AutoSize = True
        Me.lblSemana.Location = New System.Drawing.Point(616, 119)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(51, 17)
        Me.lblSemana.TabIndex = 3
        Me.lblSemana.Text = "Label1"
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(747, 119)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(51, 17)
        Me.lblMes.TabIndex = 3
        Me.lblMes.Text = "Label1"
        '
        'reporte_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 669)
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
End Class
