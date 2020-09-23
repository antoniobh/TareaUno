Imports System
Imports System.Net.Mail
Imports System.Net.Mime

Module MailManager
    Public Function send(sendMailTo As String) As Boolean
        Try

            'Creo las variables de la imagen y datos del correo
            Dim email As String = "gerardo.benavides@uhispano.ac.cr"
            Dim password As String = "HHbt37Y02"
            Dim fileURL As String = "C:\paisaje.jpg"


            'Creacion de los objetos nesesarios para el envio del correo
            Dim mail As MailMessage = New MailMessage()
            Dim SmtpServer As SmtpClient = New SmtpClient("smtp-mail.outlook.com")
            Dim text As String = "Buenas tardes, Dr. Andrés Salas Jimenez, PhD Es un gusto mostrarle una imagen de un lugar donde usted puede ir junto con nosotros si visita Costa Rica.Vista del Destino TROPICAL. Cordialmente,~Lic. Lizandro Castalleda Arkemita~Secretario General de Turismo~Costa Rica"
            Dim plainView As AlternateView = AlternateView.CreateAlternateViewFromString(text, System.Text.Encoding.UTF8, MediaTypeNames.Text.Plain)
            Dim html As String = TemplateHtml.getHtml()
            Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(html, System.Text.Encoding.UTF8, MediaTypeNames.Text.Html)
            Dim img As LinkedResource = New LinkedResource(fileURL, MediaTypeNames.Image.Jpeg)

            'confuguracion del objeto mail
            mail.From = New MailAddress(email) 'Cambiar esto por una variable
            mail.[To].Add(sendMailTo) 'Cambiar esto por una variable
            mail.Subject = "TAREA # 1,"

            'confuguracion del campo de imagenn
            img.ContentId = "imagen"

            'Agredo el campo de imagen al template del formulario
            htmlView.LinkedResources.Add(img)

            'agrego elemento HTML y elemento plano al objeto MAIL
            mail.AlternateViews.Add(plainView)
            mail.AlternateViews.Add(htmlView)

            'configuro el puesto y las credenciales del correo
            SmtpServer.Port = 25
            SmtpServer.Credentials = New System.Net.NetworkCredential(email, password) 'Cambiar esto por una variable
            SmtpServer.EnableSsl = True

            'Envio el correo configurado
            SmtpServer.Send(mail)
            'Muestro un mensaje de notificacion al usuario
            MsgBox("Correo enviado satisfactoriamente", vbInformation + vbOKOnly, "Correo enviado")
            'Regreso Verdadero, ya que el correo se envio sin problemas
            Return True
        Catch ex As Exception
            'envio un mensaje notificando al usuario que algo salio mal
            MsgBox(ex.Message.ToString(), vbCritical + vbOKOnly, "Correo no enviado")
            'regreso falso ya que el correo no se envio
            Return False
        End Try

    End Function
End Module

