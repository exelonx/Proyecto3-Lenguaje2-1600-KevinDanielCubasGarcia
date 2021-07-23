Public Class VentanaEstilo
    'Atributos publicos
    Public clickVentana
    Public x, y

    'Metodos para mover ventana
    Public Sub ventanaPresionada(form As Form, mouse As MouseEventArgs, panel As Panel)
        If clickVentana = True Then
            form.SetDesktopLocation(Panel.MousePosition.X - x, Panel.MousePosition.Y - y)
        End If
    End Sub

    'Metodo cerrar
    Public Sub cierreTotal(form1 As Form, form2 As Form, form3 As Form, form4 As Form, form5 As Form, form6 As Form, form7 As Form, form8 As Form)
    End Sub

    'Metodo para asignar valores
    Public Sub setUbicacionMouse(mouse As MouseEventArgs)
        clickVentana = True
        x = mouse.X
        y = mouse.Y
    End Sub
End Class
