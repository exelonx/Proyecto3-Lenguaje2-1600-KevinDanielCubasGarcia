Public Class FormTecnologia
    Dim ventana As New VentanaEstilo
    Dim validacion As New Validaciones

    'Procedimientos
    Public Sub visibilidad(indice As Integer)
        Select Case indice
            Case 0
                gpxProducto.Visible = True
                gpxAccesorios.Visible = True
                PictureBox3.Visible = False
                pbAccesorios.Visible = False
            Case 1
                gpxAccesorios.Visible = False
                pbAccesorios.Visible = True
        End Select

    End Sub

    Public Sub accesorios(txt1 As String, txt2 As String, txt3 As String)
        chkAcces1.Text = txt1
        chkAcces2.Text = txt2
        chkAcces3.Text = txt3
    End Sub

    Public Sub visibilidad(bool As Boolean)
        'chkAcces2.Visible = bool
        chkAcces3.Visible = bool
        'cmbAcces1.Visible = bool
        cmbAcces2.Visible = bool
        cmbAcces3.Visible = bool
    End Sub

    Public Sub seleccionProducto()
        If rbComputadoras.Checked = True Then
            'Productos
            gpxProducto.Text = "Computadoras"
            cmbProducto.Text = Nothing
            cmbProducto.Items.Clear()
            cmbProducto.Items.Add("DELL 15.6/R5 3500U L.19,890.00")
            cmbProducto.Items.Add("HP PAV 15.6/R3 3250U L.14,490.00")
            cmbProducto.Items.Add("DELL G3 15.6/i5 10MA L.19,890.00")
            'Accesorios
            accesorios("Mouse", "Monitores", "Routers")
            visibilidad(True)
            visibilidad(0)
        ElseIf rbCelulares.Checked = True Then
            gpxProducto.Text = "Celulares"
            cmbProducto.Text = Nothing
            cmbProducto.Items.Clear()
            cmbProducto.Items.Add("HUAWEI Y9A 128GB Negro L.9,390.00")
            cmbProducto.Items.Add("SAMSUNG S21 ULTRA Negro L.34,551.00")
            cmbProducto.Items.Add("MOTOROLA G8 Power Azul L. 3,689.99")
            visibilidad(0)
            accesorios("Cargador", "Protector L. 300", "")
            visibilidad(False)
        Else
            gpxProducto.Text = "Solo Accesorios"
            cmbProducto.Text = Nothing
            cmbProducto.Items.Clear()
            cmbProducto.Items.Add("Laptop DELL 15.6/R5 3500U L.19,890.00")
            cmbProducto.Items.Add("Laptop HP PAV 15.6/R3 3250U L.14,490.00")
            cmbProducto.Items.Add("Laptop DELL G3 15.6/i5 10MA L.19,890.00")
            visibilidad(1)

            visibilidad(True)
        End If
    End Sub

    Private Sub FormTecnologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox3.Location = New Point(189, 42)
        pbAccesorios.Location = New Point(333, 42)
        Me.Size = New Size(730, 307)

    End Sub
    'Ventana personalizada
    Private Sub panelVentana_MouseDown(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseDown
        ventana.setUbicacionMouse(e)
    End Sub

    Private Sub panelVentana_MouseUp(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseUp
        Ventana.clickVentana = False
    End Sub

    Private Sub panelVentana_MouseMove(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseMove
        ventana.ventanaPresionada(Me, e, panelVentana)
    End Sub

    'Botones de cerrar y minimizar
    Private Sub btnVentanaMin_Click(sender As Object, e As EventArgs) Handles btnVentanaMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnVentanaSalir_Click(sender As Object, e As EventArgs) Handles btnVentanaSalir.Click
        Close()
    End Sub

    Private Sub rbConsolas_CheckedChanged(sender As Object, e As EventArgs) Handles rbConsolas.CheckedChanged
        seleccionProducto()
    End Sub

    Private Sub cmbProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbProducto.KeyPress
        validacion.validar(2, e)
    End Sub

    Private Sub txtCantidadProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadProducto.KeyPress
        validacion.validar(1, e)
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbAcces1.KeyPress
        validacion.validar(2, e)
    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbAcces2.KeyPress
        validacion.validar(2, e)
    End Sub

    Private Sub ComboBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbAcces3.KeyPress
        validacion.validar(2, e)
    End Sub

    Private Sub rbComputadoras_CheckedChanged(sender As Object, e As EventArgs) Handles rbComputadoras.CheckedChanged
        seleccionProducto()
    End Sub

    Private Sub rbCelulares_CheckedChanged(sender As Object, e As EventArgs) Handles rbCelulares.CheckedChanged
        seleccionProducto()
    End Sub

End Class