Public Class Validaciones
    '*********************************************************************************************************************************
    '**	Hecho por: Kevin Cubas aka Exelon *******   Clase con metodos para hacer valicaciones                        *****************     
    '***                                   *******   Fecha de creación: 20/07/2021         	                          ****************							
    '**** Contacto: Kevincubas@unah.hn      *******	  Última modificación: 30/06/2021                                  ***************   
    '*****   		 Kevin.otaku@hotmail.com *******                                                                    **************			
    '******	  	      33598469                *******			                                                         *************							
    '*******	        		               *******			                                                          ************							
    '*********************************************************************************************************************************
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
            If txt.Text = 0 Or txt.Text > 20 Then
                MessageBox.Show("Rango de productos inválidos, debe ser mayor de 0 y menor a 20.", "Dato Inválido")
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

    'Metodo para activar groupbox por rb
    Public Sub setGroupBoxEnabledRB(rb As RadioButton, gpx As GroupBox)
        If rb.Checked = True Then
            gpx.Enabled = True
        Else
            gpx.Enabled = False
        End If
    End Sub

    'Metodo para activar groupbox por chk
    Public Sub setGroupBoxEnabledCHK(chk As CheckBox, gpx As GroupBox)
        If chk.Checked = True Then
            gpx.Enabled = True
        Else
            gpx.Enabled = False
        End If
    End Sub

    'Metodo aviso si se trata de cerrar un formulario sin guardar
    Public Function alertaDatosSinGuardar(productos As Integer) As Boolean
        Dim decision As Boolean
        If productos > 0 Then
            If MsgBox("Áun tiene productos en la lista sin guardar, la información se perdera." + vbCr + "¿Desea continuar?" + vbYesNo, "Información sin guardar") = vbYes Then
                Return decision = True
            Else
                Return decision = False
            End If
        Else
            Return decision = False
        End If
    End Function
End Class
