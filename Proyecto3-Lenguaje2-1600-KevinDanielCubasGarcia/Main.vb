Public Class Main
    Dim ventana As New VentanaEstilo
    'Ventana personalizada
    Private Sub panelVentana_MouseDown(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseDown
        Ventana.clickVentana = True
        Ventana.x = e.X
        Ventana.y = e.Y
    End Sub

    Private Sub panelVentana_MouseUp(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseUp
        Ventana.clickVentana = False
    End Sub

    Private Sub panelVentana_MouseMove(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseMove
        Ventana.ventanaPresionada(Me, MousePosition.X, MousePosition.Y)
    End Sub

    'Botones de cerrar y minimizar
    Private Sub btnVentanaMin_Click(sender As Object, e As EventArgs) Handles btnVentanaMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnVentanaSalir_Click(sender As Object, e As EventArgs) Handles btnVentanaSalir.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormTecnologia.Show()
    End Sub
End Class