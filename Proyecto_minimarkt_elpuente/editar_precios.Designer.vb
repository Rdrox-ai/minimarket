<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editar_precios
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
        Me.buttoneditar = New System.Windows.Forms.Button()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtprecio = New System.Windows.Forms.TextBox()
        Me.Button_volver = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtprod = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttoneditar
        '
        Me.buttoneditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.buttoneditar.Location = New System.Drawing.Point(730, 206)
        Me.buttoneditar.Name = "buttoneditar"
        Me.buttoneditar.Size = New System.Drawing.Size(105, 45)
        Me.buttoneditar.TabIndex = 13
        Me.buttoneditar.Text = "editar"
        Me.buttoneditar.UseVisualStyleBackColor = True
        '
        'Txtcodigo
        '
        Me.Txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txtcodigo.Location = New System.Drawing.Point(372, 110)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.Size = New System.Drawing.Size(288, 34)
        Me.Txtcodigo.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(97, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Ingrese el nuevo precio"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
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
        Me.DataGridView1.Location = New System.Drawing.Point(262, 298)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1023, 564)
        Me.DataGridView1.TabIndex = 10
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(162, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Ingrese el código"
        '
        'Txtprecio
        '
        Me.Txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txtprecio.Location = New System.Drawing.Point(372, 218)
        Me.Txtprecio.Name = "Txtprecio"
        Me.Txtprecio.Size = New System.Drawing.Size(288, 34)
        Me.Txtprecio.TabIndex = 12
        '
        'Button_volver
        '
        Me.Button_volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button_volver.Location = New System.Drawing.Point(34, 35)
        Me.Button_volver.Name = "Button_volver"
        Me.Button_volver.Size = New System.Drawing.Size(184, 40)
        Me.Button_volver.TabIndex = 14
        Me.Button_volver.Text = "Volver al menú"
        Me.Button_volver.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(12, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(350, 29)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Ingrese el nombre del producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(688, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 29)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "o"
        '
        'Txtprod
        '
        Me.Txtprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txtprod.Location = New System.Drawing.Point(372, 164)
        Me.Txtprod.Name = "Txtprod"
        Me.Txtprod.Size = New System.Drawing.Size(288, 34)
        Me.Txtprod.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Proyecto_minimarkt_elpuente.My.Resources.Resources.Mini_Market_El_Puente_120px_transparente
        Me.PictureBox1.Location = New System.Drawing.Point(1579, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 57)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'editar_precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1803, 899)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Txtprod)
        Me.Controls.Add(Me.Button_volver)
        Me.Controls.Add(Me.buttoneditar)
        Me.Controls.Add(Me.Txtprecio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtcodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "editar_precios"
        Me.Text = "editar_precios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttoneditar As Button
    Friend WithEvents Txtcodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtprecio As TextBox
    Friend WithEvents Button_volver As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txtprod As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
