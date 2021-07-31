'*********************************************************************************************************************************
'** Hecho por: Kevin Cubas aka Exelon *******   Clase que contiene metodos para personalizar ventanas            *****************     
'***                                   *******                  	                                              ****************							
'**** Contacto: Kevincubas@unah.hn      *******	  Fecha de creación: 20/07/2021                                    ***************   
'*****   		 Kevin.otaku@hotmail.com *******   Última modificación: 30/06/2021                                  **************			
'******	  	      33598469                *******			                                                         *************							
'*******	        		               *******			                                                          ************							
'*********************************************************************************************************************************

'¡OYE TU!, si, tú... Si utilizas mis metodos para tus trabajos de lenguaje, te agradeceria que me dieras creditos en tu proyecto. :)

Imports System.Runtime.InteropServices 'Libreria para implementar sombras en formularios sin marco
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

    'metodo solo para estetica
    Public Sub visibilidad(gpx As GroupBox, pb As PictureBox)
        gpx.Visible = True
        pb.Visible = False
    End Sub

    Public Sub visibilidadInversa(gpx As GroupBox, pb As PictureBox)
        gpx.Visible = False
        pb.Visible = True
    End Sub

    'Para crear sombrado en las ventanas
    Public SD As Integer
    Public Declare Function GetClassLong Lib "user32" Alias "GetClassLongA" (Dt As IntPtr, UI As Integer) As Integer
    Public Declare Function GetDesktopWindow Lib "user32" () As Integer
    Public Declare Function SetClassLong Lib "user32" Alias "SetClassLongA" (Dt As IntPtr, IDF As Integer, IGT As Integer) As Integer
    Public Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (Wo As IntPtr, Ni As Integer, NK As Integer) As Integer
    'metodo para implementar la sombra
    Public Sub ventanaSombra(form As Form)          '<----- Esta se utiliza en el constructor de la nueva ventana para generar la sombra
        form.FormBorderStyle = FormBorderStyle.None
        Const CS_DROPSHADOW As Integer = &H20000
        SD = SetWindowLong(form.Handle, -8, GetDesktopWindow())
        SetClassLong(form.Handle, -26, GetClassLong(form.Handle, -26) Or CS_DROPSHADOW)
    End Sub
End Class
