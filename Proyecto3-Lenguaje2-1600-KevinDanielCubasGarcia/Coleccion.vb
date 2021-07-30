Public Class Coleccion
    Private nfactura As Integer
    Private nombre As String
    Private metodoPago As String
    Private Membresia As String
    Private st, desc, iva, total As Double
    Private dataGridC(4, 50)

    Public Property get_Factura() As Integer
        Get
            Return nfactura
        End Get
        Set(value As Integer)
            nfactura = value
        End Set
    End Property

    Public Property get_Nombre() As Integer
        Get
            Return nombre
        End Get
        Set(value As Integer)
            nombre = value
        End Set
    End Property

    Public Property get_MetodoPago() As Integer
        Get
            Return metodoPago
        End Get
        Set(value As Integer)
            metodoPago = value
        End Set
    End Property
    Public Property get_Membresia() As Integer
        Get
            Return Membresia
        End Get
        Set(value As Integer)
            Membresia = value
        End Set
    End Property
    Public Property get_ST() As Integer
        Get
            Return st
        End Get
        Set(value As Integer)
            st = value
        End Set
    End Property
    Public Property get_Desc() As Integer
        Get
            Return desc
        End Get
        Set(value As Integer)
            desc = value
        End Set
    End Property

End Class
