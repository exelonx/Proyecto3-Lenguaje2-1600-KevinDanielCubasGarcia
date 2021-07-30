Public Class Nodo
    Public nfactura As Integer
    Public nodo As Nodo
    Public nombre As String
    Public metodoPago As String
    Public Membresia As String
    Public st, desc, iva, total As Double
    Public dataGridC(4, 50) As String
    Public contFilas, indexFila As Integer

    Public Sub New(factura As Integer, sig As Nodo, nombre As String, metodoPago As String, membresia As String, datagrid As DataGridView, st As Double, desc As Double, iva As Double, total As Double)
        nfactura = factura
        nodo = sig
        Me.nombre = nombre
        Me.metodoPago = metodoPago
        Me.Membresia = membresia
        Do While (indexFila < datagrid.Rows.Count)
            dataGridC(0, indexFila) = datagrid(0, indexFila).Value.ToString
            dataGridC(1, indexFila) = datagrid(1, indexFila).Value.ToString
            dataGridC(2, indexFila) = datagrid(2, indexFila).Value.ToString
            dataGridC(3, indexFila) = datagrid(3, indexFila).Value.ToString
            dataGridC(4, indexFila) = datagrid(4, indexFila).Value.ToString
            indexFila += 1
            If indexFila = contFilas - 1 Then
                indexFila = 0
                Exit sub
            End If
        Loop
        Me.st = st
        Me.desc = desc
        Me.iva = iva
        Me.total = total
    End Sub
End Class
