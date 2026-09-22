<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Scan_productos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtprod = New System.Windows.Forms.TextBox()
        Me.Button_volver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtcodigo
        '
        Me.Txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcodigo.Location = New System.Drawing.Point(758, 137)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.Size = New System.Drawing.Size(331, 34)
        Me.Txtcodigo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(452, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingrese el código"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.producto, Me.precio})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(304, 309)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(947, 632)
        Me.DataGridView1.TabIndex = 3
        '
        'codigo
        '
        Me.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "codigo"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.Width = 116
        '
        'producto
        '
        Me.producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.producto.DataPropertyName = "producto"
        Me.producto.HeaderText = "producto"
        Me.producto.MinimumWidth = 6
        Me.producto.Name = "producto"
        Me.producto.Width = 137
        '
        'precio
        '
        Me.precio.DataPropertyName = "precio"
        Me.precio.HeaderText = "precio"
        Me.precio.MinimumWidth = 6
        Me.precio.Name = "precio"
        Me.precio.Width = 110
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(374, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(350, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ingrese el nombre del producto"
        '
        'Txtprod
        '
        Me.Txtprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtprod.Location = New System.Drawing.Point(758, 217)
        Me.Txtprod.Name = "Txtprod"
        Me.Txtprod.Size = New System.Drawing.Size(331, 34)
        Me.Txtprod.TabIndex = 5
        '
        'Button_volver
        '
        Me.Button_volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_volver.Location = New System.Drawing.Point(40, 50)
        Me.Button_volver.Name = "Button_volver"
        Me.Button_volver.Size = New System.Drawing.Size(189, 50)
        Me.Button_volver.TabIndex = 11
        Me.Button_volver.Text = "Volver al menú"
        Me.Button_volver.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_minimarkt_elpuente.My.Resources.Resources.Mini_Market_El_Puente_120px_transparente
        Me.PictureBox1.Location = New System.Drawing.Point(1133, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 71)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Scan_productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1462, 1008)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button_volver)
        Me.Controls.Add(Me.Txtprod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtcodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Scan_productos"
        Me.Text = "Scan_productos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtcodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtprod As TextBox
    Friend WithEvents Button_volver As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
