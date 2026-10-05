Imports System.Drawing
Imports System.Drawing.Printing

' Representa una línea del ticket
Public Class ItemTicket
    Public Property Codigo As String
    Public Property Producto As String
    Public Property Precio As Decimal
    Public Property Cantidad As Double
    Public Property Subtotal As Decimal
End Class

Module Impresion

    ' ===== Datos del negocio (ajústalos a los tuyos) =====
    Private Const NOMBRE_NEGOCIO As String = "MINIMARKET EL PUENTE"
    Private Const DIRECCION_NEGOCIO As String = "Altos - Paraguay"
    Private Const RUC_NEGOCIO As String = "RUC: 0000000000-0"
    Private Const TELEFONO_NEGOCIO As String = "Tel: (000) 000-000"

    ' ===== Datos de la venta actual =====
    Private items As List(Of ItemTicket)
    Private clienteNombre As String
    Private clienteRuc As String
    Private totalVenta As Decimal
    Private montoRecibido As Decimal
    Private vueltoVenta As Decimal

    ' ===== Variables de dibujo =====
    Private pg As Graphics
    Private px As Single
    Private py As Single
    Private pancho As Single

    ''' <summary>
    ''' Imprime el ticket de venta. Si vistaPrevia = True muestra una vista previa en pantalla.
    ''' </summary>
    Public Sub ImprimirTicket(listaItems As List(Of ItemTicket),
                              nombre As String,
                              ruc As String,
                              total As Decimal,
                              recibido As Decimal,
                              vuelto As Decimal,
                              Optional vistaPrevia As Boolean = False)

        items = listaItems
        clienteNombre = If(String.IsNullOrWhiteSpace(nombre), "SIN NOMBRE", nombre.Trim())
        clienteRuc = If(String.IsNullOrWhiteSpace(ruc), "---", ruc.Trim())
        totalVenta = total
        montoRecibido = recibido
        vueltoVenta = vuelto

        Dim doc As New PrintDocument()
        ' Papel de ticket de 80 mm (315 centésimas de pulgada de ancho)
        doc.DefaultPageSettings.PaperSize = New PaperSize("Ticket80", 315, 1100)
        doc.DefaultPageSettings.Margins = New Margins(10, 10, 10, 10)
        AddHandler doc.PrintPage, AddressOf ImprimirPagina

        Try
            If vistaPrevia Then
                Using dlg As New PrintPreviewDialog()
                    dlg.Document = doc
                    dlg.WindowState = FormWindowState.Maximized
                    dlg.ShowDialog()
                End Using
            Else
                doc.Print() ' usa la impresora predeterminada de Windows
            End If
        Catch ex As Exception
            MsgBox("No se pudo imprimir el ticket: " & ex.Message, MsgBoxStyle.Critical, "Error de impresión")
        Finally
            RemoveHandler doc.PrintPage, AddressOf ImprimirPagina
            doc.Dispose()
        End Try
    End Sub

    Private Sub ImprimirPagina(sender As Object, e As PrintPageEventArgs)
        pg = e.Graphics
        px = e.MarginBounds.Left
        py = e.MarginBounds.Top
        pancho = e.MarginBounds.Width

        Using fNormal As New Font("Consolas", 8),
              fNegrita As New Font("Consolas", 8, FontStyle.Bold),
              fTitulo As New Font("Consolas", 11, FontStyle.Bold),
              fTotal As New Font("Consolas", 10, FontStyle.Bold)

            ' --- Encabezado del negocio ---
            TextoCentrado(NOMBRE_NEGOCIO, fTitulo)
            TextoCentrado(DIRECCION_NEGOCIO, fNormal)
            TextoCentrado(RUC_NEGOCIO, fNormal)
            TextoCentrado(TELEFONO_NEGOCIO, fNormal)
            Separador(fNormal)

            ' --- Datos de la venta y del cliente ---
            TextoIzquierda("Fecha: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fNormal)
            TextoIzquierda("Cliente: " & clienteNombre, fNormal)
            TextoIzquierda("RUC: " & clienteRuc, fNormal)
            Separador(fNormal)

            ' --- Detalle de productos ---
            TextoDosColumnas("DETALLE", "SUBTOTAL", fNegrita)
            Separador(fNormal)

            Dim subtotalGeneral As Decimal = 0
            For Each it As ItemTicket In items
                TextoIzquierda(it.Producto, fNormal) ' admite varias líneas si el nombre es largo
                TextoDosColumnas(
                    "  " & it.Cantidad.ToString("0.##") & " x " & it.Precio.ToString("N0"),
                    it.Subtotal.ToString("N0"),
                    fNormal)
                subtotalGeneral += it.Subtotal
            Next
            Separador(fNormal)

            ' --- Totales ---
            TextoDosColumnas("SUBTOTAL:", subtotalGeneral.ToString("N0"), fNormal)
            TextoDosColumnas("TOTAL A PAGAR:", totalVenta.ToString("N0"), fTotal)
            TextoDosColumnas("Recibido:", montoRecibido.ToString("N0"), fNormal)
            TextoDosColumnas("Vuelto:", vueltoVenta.ToString("N0"), fNormal)
            Separador(fNormal)

            ' IVA incluido en el precio (10%). Ajusta si manejas otras tasas (5% o exentas).
            Dim iva10 As Decimal = Math.Round(totalVenta / 11D, 0)
            TextoDosColumnas("IVA 10% incluido:", iva10.ToString("N0"), fNormal)
            Separador(fNormal)

            TextoCentrado("¡Gracias por su compra!", fNegrita)
        End Using

        e.HasMorePages = False
    End Sub

    ' ===== Helpers de dibujo =====

    Private Sub TextoCentrado(texto As String, fuente As Font)
        Dim h As Single = fuente.GetHeight(pg)
        Using fmt As New StringFormat()
            fmt.Alignment = StringAlignment.Center
            pg.DrawString(texto, fuente, Brushes.Black, New RectangleF(px, py, pancho, h), fmt)
        End Using
        py += h
    End Sub

    ' Texto alineado a la izquierda con salto de línea automático
    Private Sub TextoIzquierda(texto As String, fuente As Font)
        Dim tam As SizeF = pg.MeasureString(texto, fuente, CInt(pancho))
        pg.DrawString(texto, fuente, Brushes.Black, New RectangleF(px, py, pancho, tam.Height))
        py += tam.Height
    End Sub

    Private Sub TextoDosColumnas(izquierda As String, derecha As String, fuente As Font)
        Dim h As Single = fuente.GetHeight(pg)
        Dim rect As New RectangleF(px, py, pancho, h)
        pg.DrawString(izquierda, fuente, Brushes.Black, rect)
        Using fmt As New StringFormat()
            fmt.Alignment = StringAlignment.Far
            pg.DrawString(derecha, fuente, Brushes.Black, rect, fmt)
        End Using
        py += h
    End Sub

    Private Sub Separador(fuente As Font)
        Dim h As Single = fuente.GetHeight(pg)
        Dim yLinea As Single = py + h / 2
        pg.DrawLine(Pens.Black, px, yLinea, px + pancho, yLinea)
        py += h
    End Sub

End Module
