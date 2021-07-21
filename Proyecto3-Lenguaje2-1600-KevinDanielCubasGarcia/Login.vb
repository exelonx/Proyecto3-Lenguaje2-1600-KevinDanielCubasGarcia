Public Class FormLogin
    Dim Ventana As New VentanaEstilo
    Dim user, pass As String

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnVentanaMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnVentanaSalir.Click
        Close()
    End Sub

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

    Private Sub chkMostrarContra_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrarContra.CheckedChanged
        If chkMostrarContra.Checked = True Then
            txtContraseña.PasswordChar = Nothing
        Else
            txtContraseña.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        'Evitar que se ingrese espacio en blanco
        If Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        'Evitar que se ingrese espacio en blanco
        If Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user = "pedrito"
        pass = "clavounclavito"
    End Sub

    Private Sub btnValidar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnValidar.MouseMove
        btnValidar.ForeColor = Color.Black
    End Sub

    Private Sub btnValidar_MouseLeave(sender As Object, e As EventArgs) Handles btnValidar.MouseLeave
        btnValidar.ForeColor = Color.White
    End Sub

    Private Sub btnCerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCerrar.MouseMove
        btnCerrar.ForeColor = Color.Black
    End Sub

    Private Sub btnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles btnCerrar.MouseLeave
        btnCerrar.ForeColor = Color.White
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        If user = txtUsuario.Text And pass = txtContraseña.Text Then
            MessageBox.Show("Tu madre visual basic", "Tu madre")
        Else
            MessageBox.Show("Usuario y contraseña equivocada, igual chinga tu madre VB.NET")
        End If
    End Sub
End Class
