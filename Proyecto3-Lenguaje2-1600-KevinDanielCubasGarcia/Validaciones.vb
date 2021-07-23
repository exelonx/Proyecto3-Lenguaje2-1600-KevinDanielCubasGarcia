Public Class Validaciones
    'metodos
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

End Class
