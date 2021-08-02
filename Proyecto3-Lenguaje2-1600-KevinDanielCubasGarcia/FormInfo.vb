
Public Class FormInfo
    Dim Ventana As New VentanaEstilo

    Private Sub btnVentanaSalir_Click(sender As Object, e As EventArgs) Handles btnVentanaSalir.Click
        Close()
    End Sub
    Private Sub btnVentanaSalir_MouseMove(sender As Object, e As MouseEventArgs) Handles btnVentanaSalir.MouseMove
        btnVentanaSalir.ForeColor = Color.White
    End Sub

    Private Sub btnVentanaSalir_MouseLeave(sender As Object, e As EventArgs) Handles btnVentanaSalir.MouseLeave
        btnVentanaSalir.ForeColor = Color.Black
    End Sub


    Private Sub FormInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Enabled = True
    End Sub

    Private Sub FormInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        pbE.SizeMode = PictureBoxSizeMode.Zoom
        My.Computer.Audio.Stop()
        pbE.Image = Nothing
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim easterEgg As String
        Dim usuario As String
        usuario = Environ("username")
        easterEgg = InputBox(vbCr + vbCr + "I AM THE STORM THAT IS...", "NOW I'M   M O T I V A T E D", "??????????", 200, 200)
        If "approaching" = LCase(easterEgg) Then
            pbE.Image = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.nieve
            My.Computer.Audio.Play(Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.OST, AudioPlayMode.BackgroundLoop)
        Else
            MessageBox.Show("Respuesta equivocada :(", "¡OH NO!")
            easterEgg = InputBox(vbCr + vbCr + "LOST IN...", "Estamos en un paraiso?", "??????????", 200, 200)
            If "paradise" = LCase(easterEgg) Then
                Process.Start("https://www.youtube.com/watch?v=6riDJMI-Y8U")
                MessageBox.Show("¡Buen trabajo " & usuario & ", adivinaste!", "Estamos perdidos en un paraiso :)")
            Else
                Process.Start("https://www.google.com/search?q=" & usuario & "%20te%20equivocaste%20de%20nuevo...")
                MessageBox.Show(usuario & "... Nope.", "¿Adónde vamos a parar?...")
                easterEgg = InputBox(vbCr + vbCr + "black goku se transforma en ssj...", "El ambiente está muy rosa, ¿No crees?", "??????????", 200, 200)
                If "rosa" = LCase(easterEgg) Then
                    'pbE.SizeMode = PictureBoxSizeMode.StretchImage
                    pbE.Image = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.petalos
                    My.Computer.Audio.Play(Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.OSTvictoria, AudioPlayMode.Background)
                    MessageBox.Show("Ah " & usuario & ", veo que eres una persona de cultura.", "¡La tercera es la vencida!")
                Else
                    Process.Start("https://www.youtube.com/watch?v=umDr0mPuyQc")
                    Me.Close()
                End If
            End If
        End If
        PictureBox1.Enabled = False
    End Sub
End Class