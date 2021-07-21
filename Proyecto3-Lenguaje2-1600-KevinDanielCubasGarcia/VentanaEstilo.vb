Public Class VentanaEstilo
    'Atributos publicos
    Public clickVentana
    Public x, y

    'Metodos
    Public Sub ventanaPresionada(form As Form, mousePositionX As Integer, mousePositionY As Integer)
        If clickVentana = True Then
            form.SetDesktopLocation(mousePositionX - x, mousePositionY - y)
        End If
    End Sub
End Class
