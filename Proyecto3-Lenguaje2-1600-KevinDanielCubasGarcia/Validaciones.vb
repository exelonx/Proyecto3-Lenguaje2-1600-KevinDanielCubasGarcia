Public Class Validaciones
    'metodos tipo de datos
    Public Sub validar(tipoValidacion As Integer, key As KeyPressEventArgs)
        Select Case tipoValidacion
            Case 0 'Para Texto
                If Char.IsLetter(key.KeyChar) Then
                    key.Handled = False
                ElseIf Char.IsSeparator(key.KeyChar) Then
                    key.Handled = False
                ElseIf Char.IsControl(key.KeyChar) Then
                    key.Handled = False
                Else
                    key.Handled = True
                    MessageBox.Show("Tipo de dato inválido, solo texto.", "Dato inválido")
                End If
            Case 1  'Para Números
                If Char.IsNumber(key.KeyChar) Then
                    key.Handled = False
                ElseIf Char.IsSeparator(key.KeyChar) Then
                    key.Handled = False
                ElseIf Char.IsControl(key.KeyChar) Then
                    key.Handled = False
                Else
                    key.Handled = True
                    MessageBox.Show("Tipo de dato inválido, solo Números.", "Dato inválido")
                End If
            Case 2 'Para ComboBox
                key.Handled = True
            Case 3 'Para todo tipo de dato menos espacio
                If Char.IsSeparator(key.KeyChar) Then
                    key.Handled = True
                End If
        End Select
    End Sub

    Public Sub validarCantidad(txt As TextBox)
        If txt.Text <> Nothing Then
            If txt.Text = 0 Then
                MessageBox.Show("Número de objetos inválido, ingrese una cantidad superior a 0.", "Dato Inválido")
                txt.Text = 1
                txt.Focus()
            End If
        End If
    End Sub

    'metodos para checkbox
    Public Sub activacionPorCheckBox(chk As CheckBox, objectControl As Control)
        If chk.Checked = True Then
            objectControl.Enabled = True
        Else
            objectControl.Enabled = False
            objectControl.Text = Nothing
        End If
    End Sub

    'metodo para limpiar checkbox
    Public Sub chkClear(chk1 As CheckBox, chk2 As CheckBox, chk3 As CheckBox)
        chk1.Checked = False
        chk2.Checked = False
        chk3.Checked = False
    End Sub
End Class
