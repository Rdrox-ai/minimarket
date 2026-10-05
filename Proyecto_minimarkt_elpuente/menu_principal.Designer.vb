<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menu_principal
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
        Me.Button_escanear = New System.Windows.Forms.Button()
        Me.Button_cargar = New System.Windows.Forms.Button()
        Me.Button_eliminar = New System.Windows.Forms.Button()
        Me.Button_editar = New System.Windows.Forms.Button()
        Me.Sumar_productos = New System.Windows.Forms.Button()
        Me.Button_volver = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btnreporte = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_escanear
        '
        Me.Button_escanear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_escanear.Location = New System.Drawing.Point(63, 342)
        Me.Button_escanear.Name = "Button_escanear"
        Me.Button_escanear.Size = New System.Drawing.Size(333, 103)
        Me.Button_escanear.TabIndex = 1
        Me.Button_escanear.Text = "Escanear Productos"
        Me.Button_escanear.UseVisualStyleBackColor = True
        '
        'Button_cargar
        '
        Me.Button_cargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_cargar.Location = New System.Drawing.Point(63, 449)
        Me.Button_cargar.Name = "Button_cargar"
        Me.Button_cargar.Size = New System.Drawing.Size(333, 103)
        Me.Button_cargar.TabIndex = 2
        Me.Button_cargar.Text = "Cargar Productos"
        Me.Button_cargar.UseVisualStyleBackColor = True
        '
        'Button_eliminar
        '
        Me.Button_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_eliminar.Location = New System.Drawing.Point(63, 662)
        Me.Button_eliminar.Name = "Button_eliminar"
        Me.Button_eliminar.Size = New System.Drawing.Size(333, 103)
        Me.Button_eliminar.TabIndex = 4
        Me.Button_eliminar.Text = "Eliminar Productos"
        Me.Button_eliminar.UseVisualStyleBackColor = True
        '
        'Button_editar
        '
        Me.Button_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_editar.Location = New System.Drawing.Point(63, 555)
        Me.Button_editar.Name = "Button_editar"
        Me.Button_editar.Size = New System.Drawing.Size(333, 103)
        Me.Button_editar.TabIndex = 3
        Me.Button_editar.Text = "Editar Precios"
        Me.Button_editar.UseVisualStyleBackColor = True
        '
        'Sumar_productos
        '
        Me.Sumar_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sumar_productos.Location = New System.Drawing.Point(63, 235)
        Me.Sumar_productos.Name = "Sumar_productos"
        Me.Sumar_productos.Size = New System.Drawing.Size(333, 103)
        Me.Sumar_productos.TabIndex = 0
        Me.Sumar_productos.Text = "Venta"
        Me.Sumar_productos.UseVisualStyleBackColor = True
        '
        'Button_volver
        '
        Me.Button_volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_volver.Location = New System.Drawing.Point(52, 40)
        Me.Button_volver.Name = "Button_volver"
        Me.Button_volver.Size = New System.Drawing.Size(226, 73)
        Me.Button_volver.TabIndex = 5
        Me.Button_volver.Text = "Salir"
        Me.Button_volver.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_minimarkt_elpuente.My.Resources.Resources.Copilot_20260719_084343
        Me.PictureBox1.Location = New System.Drawing.Point(457, -45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1226, 842)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Btnreporte
        '
        Me.Btnreporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnreporte.Location = New System.Drawing.Point(63, 771)
        Me.Btnreporte.Name = "Btnreporte"
        Me.Btnreporte.Size = New System.Drawing.Size(333, 103)
        Me.Btnreporte.TabIndex = 4
        Me.Btnreporte.Text = "Reporte de ventas"
        Me.Btnreporte.UseVisualStyleBackColor = True
        '
        'menu_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1821, 890)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button_volver)
        Me.Controls.Add(Me.Button_editar)
        Me.Controls.Add(Me.Btnreporte)
        Me.Controls.Add(Me.Button_eliminar)
        Me.Controls.Add(Me.Button_cargar)
        Me.Controls.Add(Me.Sumar_productos)
        Me.Controls.Add(Me.Button_escanear)
        Me.Name = "menu_principal"
        Me.Text = "menu_principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_escanear As Button
    Friend WithEvents Button_cargar As Button
    Friend WithEvents Button_eliminar As Button
    Friend WithEvents Button_editar As Button
    Friend WithEvents Sumar_productos As Button
    Friend WithEvents Button_volver As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Btnreporte As Button
End Class
