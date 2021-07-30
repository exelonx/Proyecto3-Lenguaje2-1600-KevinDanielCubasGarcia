Public Class Nodo
    Public nfactura As Integer
    Public nodo As Nodo
    Public nombre As String
    Public metodoPago As String
    Public Membresia As String
    Public st, desc, iva, total As Double
    Public dataGridC(4, 50) As String

    Public Sub New(factura As Integer, sig As Nodo, nombre As String, metodoPago As String, membresia As String, datagrid As DataGridView, st As Double, desc As Double, iva As Double, total As Double)
        nfactura = factura
        nodo = sig
        Me.nombre = nombre
        Me.metodoPago = metodoPago
        Me.Membresia = membresia
        For i = 0 To 4
            For j = 0 To datagrid.Rows.Count - 1
                dataGridC(i, j) = datagrid(i, j).Value.ToString
            Next
        Next
        Me.st = st
        Me.desc = desc
        Me.iva = iva
        Me.total = total
    End Sub
End Class
