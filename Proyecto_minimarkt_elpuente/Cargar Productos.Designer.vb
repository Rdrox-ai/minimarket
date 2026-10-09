<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cargar_Productos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txtproducto = New System.Windows.Forms.TextBox()
        Me.Txtprecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_nuevo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button_volver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtcodigo
        '
        Me.Txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txtcodigo.Location = New System.Drawing.Point(202, 123)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.Size = New System.Drawing.Size(281, 34)
        Me.Txtcodigo.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(233, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Ingrese el código"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.producto, Me.precio})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Location = New System.Drawing.Point(233, 230)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(842, 561)
        Me.DataGridView1.TabIndex = 6
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
        'Txtproducto
        '
        Me.Txtproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txtproducto.Location = New System.Drawing.Point(567, 123)
        Me.Txtproducto.Name = "Txtproducto"
        Me.Txtproducto.Size = New System.Drawing.Size(299, 34)
        Me.Txtproducto.TabIndex = 8
        '
        'Txtprecio
        '
        Me.Txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txtprecio.Location = New System.Drawing.Point(961, 123)
        Me.Txtprecio.Name = "Txtprecio"
        Me.Txtprecio.Size = New System.Drawing.Size(235, 34)
        Me.Txtprecio.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(547, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(350, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ingrese el nombre del producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(974, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 29)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Ingrese el precio"
        '
        'Button_nuevo
        '
        Me.Button_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_nuevo.Location = New System.Drawing.Point(1125, 230)
        Me.Button_nuevo.Name = "Button_nuevo"
        Me.Button_nuevo.Size = New System.Drawing.Size(119, 40)
        Me.Button_nuevo.TabIndex = 9
        Me.Button_nuevo.Text = "Nuevo"
        Me.Button_nuevo.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1125, 306)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 40)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button_volver
        '
        Me.Button_volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_volver.Location = New System.Drawing.Point(23, 31)
        Me.Button_volver.Name = "Button_volver"
        Me.Button_volver.Size = New System.Drawing.Size(184, 40)
        Me.Button_volver.TabIndex = 10
        Me.Button_volver.Text = "Volver al menú"
        Me.Button_volver.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Proyecto_minimarkt_elpuente.My.Resources.Resources.Mini_Market_El_Puente_120px_transparente
        Me.PictureBox1.Location = New System.Drawing.Point(1174, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 61)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Cargar_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1346, 890)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button_volver)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button_nuevo)
        Me.Controls.Add(Me.Txtprecio)
        Me.Controls.Add(Me.Txtproducto)
        Me.Controls.Add(Me.Txtcodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Cargar_Productos"
        Me.Text = "Cargar_Productos"
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
    Friend WithEvents Txtproducto As TextBox
    Friend WithEvents Txtprecio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_nuevo As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button_volver As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
