Imports System.ComponentModel


Public Class Form1

    'Declaracion de variables

    'Los segundos del timer
    'Correos enviados
    'Correos No enviados
    'Correos enviados

    Private seconds = 0
    Private requests = 0
    Private notSends = 0
    Private sendsSuccess = 0
    Private Sub btn_sendEmail_Click_1(sender As Object, e As EventArgs) Handles btn_sendEmail.Click

        'Verificacion de que el valor ingresado sea un correo valido
        If isMail() Then

            'Deshabilitacion del boton, campo de texto  y cambios visuales, configuracion e inicializacion del Timer
            Emailfield.Enabled = False
            btn_sendEmail.Enabled = False
            btn_sendEmail.BackColor = Color.Plum
            btn_sendEmail.Text = "Enviando..."
            Timer1.Interval = 1000
            Timer1.Start()
        Else
            'Mensaje al usuario en caso de que el correo no sea valido.
            MsgBox("Dirección de correo electrónico inválida", vbCritical + vbOKOnly, "Datos erróneos")
        End If

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'suma de 1 a la variable de segundos cuando hallan transcurrido 1000ms o bien 1 segundo
        seconds = seconds + 1

        'Evaluacion de que halla transcurrido 1 segundo, con el fin de hacer un poco mas duradero el cambio visual
        If (seconds = 1) Then
            'sumo un valor a las solicitudes realizadas y asigno el valor al label correspondiente
            requests = requests + 1
            labelTotalSends.Text = requests

            'Intento enviar el correo, la funcion retorna verdadero en caso de enviar el correo y false en caso contrario
            If MailManager.send(Emailfield.Text) Then
                'Realizo el cambio del texto del boton, agrego un valor a los enviados satisfactoriamente y lo asigno a su etiqueta
                btn_sendEmail.Text = "Enviado"
                sendsSuccess = sendsSuccess + 1
                TotalSendSuccess.Text = sendsSuccess
                Emailfield.Text = ""
            Else
                'Realizo el cambio del texto del boton, agrego un valor a los no enviados y lo asigno a su etiqueta
                btn_sendEmail.Text = "No enviado"
                notSends = notSends + 1
                TotalSendwithErrors.Text = notSends

            End If
        End If

        'Pregunto si el valor de los segundos corresponde a 2 y restablesco los valores de los campos correspondientes y reinicio el contador del reloj
        If (seconds = 2) Then
            btn_sendEmail.Text = "Enviar"
            seconds = 0
            Timer1.Stop()
            Emailfield.Enabled = True
            btn_sendEmail.Enabled = True
            btn_sendEmail.BackColor = Color.DarkMagenta
            Emailfield.Focus()
        End If


    End Sub
    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Cierro el formulario principal, con el fin de cerrar la aplicacion completamente.
        loadingPage.Close()
    End Sub

    'Funcion que verifica si el campo es o no un Email, devolviendo verdadero o falso segun corresponda
    Private Function isMail()
        'Creo un ciclo que va desde 0 hasta el largo del correo digitado
        For i = 0 To Emailfield.Text.Length - 1
            'verifico que el valor en la posicion Index sea un @
            If Emailfield.Text.Chars(i) = "@" Then
                'verifico que la cadena no comience con el @
                If i > 0 Then
                    'sustraigo un nuevo String partiendo del @
                    Dim afterArroba = Emailfield.Text.Substring(i + 1)
                    'Verifico que no existan mas @ despues del primero que se encuentra, si es asi devuelvo falso
                    If afterArroba.Contains("@") Then
                        Return False
                    Else
                        'Pregunto si la longitud del nuevo arreglo es superior a 2 ya que al menos deberia de haber una letra un punto y una letra
                        If afterArroba.Length > 2 Then
                            'verifico que existan puntos en la cadena
                            If afterArroba.Contains(".") Then
                                'verifico que la cadena no comience o termine con un punto
                                If afterArroba.Chars(0) <> "." And afterArroba.Chars(afterArroba.Length - 1) <> "." Then
                                    'Regreso verdadero ya que todas las prubas fueron aprobadas
                                    Return True
                                End If
                            End If
                        End If
                    End If
                End If
                Return False
            End If
        Next
        Return False

    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Verifico la coneccion a internet al iniciar el formulario
        checkInternet()
    End Sub

    Private Sub checkInternet()
        'llamo la funcion de verificacion de internet
        If IsConnectionAvailable() Then
            'En caso de haber. oculto las etiquetas e imagenes correspondientes
            labelNetworkStatus.Text = "Internet Estable"
            PictureOffline.Visible = False
            onlinePicture.Visible = True
            labelDetectconection.Visible = False
            Emailfield.Enabled = True
            btn_sendEmail.Enabled = True
        Else
            'En caso de no haber. oculto las etiquetas e imagenes correspondientes
            labelNetworkStatus.Text = "No se detecto una conexión a internet"
            PictureOffline.Visible = True
            onlinePicture.Visible = False
            labelDetectconection.Visible = True
            Emailfield.Enabled = False
            btn_sendEmail.Enabled = False
        End If
    End Sub

    'funcion que verifica que exista una coneccion a internet
    Public Function IsConnectionAvailable() As Boolean

        'Creo un objeto de solicitud y uno de respuesta
        Dim request As System.Net.WebRequest
        Dim response As System.Net.WebResponse
        'Agrego a la solicitud el parametro de uri
        request = System.Net.WebRequest.Create(New System.Uri("http://www.google.com/"))
        'Intento realiar la peticion
        Try
            'igualo el objeto de respuesta a lo obtenido por la consulta, en caso de existir respuesta
            response = request.GetResponse
            'cierro la respuesta
            response.Close()
            'limpio la respuesta para su siguiente peticion
            request = Nothing
            'regreso verdadero ya que si hay respuesta del servidor, por lo tanto internet
            Return True
        Catch ex As Exception
            'limpio la respuesta para su siguiente peticion
            request = Nothing
            'Regreso falso dado que no hay respuesta, por lo cual no hay internet
            Return False
        End Try
    End Function

    Private Sub labelDetectconection_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles labelDetectconection.LinkClicked
        'La etiqueta aparece unicamente en caso de no haber internet, dando la oportunidad al usuario de revisar la coneccion nuevamente
        labelDetectconection.Text = "Detectando red..."
        checkInternet()
    End Sub
End Class
