Imports System.ComponentModel

Public Class Form1
    Private x = 0
    Private Sub btn_sendEmail_Click_1(sender As Object, e As EventArgs) Handles btn_sendEmail.Click
        If isMail() Then
            Emailfield.Enabled = False
            btn_sendEmail.Enabled = False
            btn_sendEmail.BackColor = Color.Plum
            btn_sendEmail.Text = "Enviando..."
            Timer1.Interval = 1000
            Timer1.Start()
        Else
            MsgBox("Dirección de correo electrónico inválida", vbCritical + vbOKOnly, "Datos erróneos")
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        x = x + 1
        If (x = 2) Then
            btn_sendEmail.Text = "Enviado"
        End If

        If (x = 3) Then
            btn_sendEmail.Text = "Enviar"
            x = 0
            Timer1.Stop()
            Emailfield.Enabled = True
            btn_sendEmail.Enabled = True
            btn_sendEmail.BackColor = Color.DarkMagenta
            Emailfield.Text = ""
            Emailfield.Focus()
        End If


    End Sub
    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        loadingPage.Close()
    End Sub

    Private Function isMail()
        For i = 0 To Emailfield.Text.Length - 1
            'verifico que el valor en la posicion Index sea un @
            If Emailfield.Text.Chars(i) = "@" Then
                'verifico que la cedena no comience con el @
                If i > 0 Then
                    Dim afterArroba = Emailfield.Text.Substring(i + 1)
                    If afterArroba.Contains("@") Then
                        Return False
                    Else
                        If afterArroba.Length > 2 Then
                            If afterArroba.Contains(".") Then
                                If afterArroba.Chars(0) <> "[a,.]" And afterArroba.Chars(afterArroba.Length - 1) <> "." Then
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




    Public Function IsConnectionAvailable() As Boolean
        ' Returns True if connection is available
        ' Replace www.yoursite.com with a site that
        ' is guaranteed to be online - perhaps your
        ' corporate site, or microsoft.com
        Dim objUrl As New System.Uri("http://www.google.com/")
        ' Setup WebRequest
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objResp As System.Net.WebResponse
        Try
            ' Attempt to get response and return True
            objResp = objWebReq.GetResponse
            objResp.Close()
            objWebReq = Nothing
            Return True
        Catch ex As Exception
            ' Error, exit and return False
            objWebReq = Nothing
            Return False
        End Try
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkInternet()
    End Sub

    Private Sub checkInternet()
        If IsConnectionAvailable() Then
            Label5.Text = "Internet Estable"
            PictureOffline.Visible = False
            onlinePicture.Visible = True
            LinkLabel1.Visible = False
            Emailfield.Enabled = True
            btn_sendEmail.Enabled = True
        Else
            Label5.Text = "No se detecto una conexión a internet"
            PictureOffline.Visible = True
            onlinePicture.Visible = False
            LinkLabel1.Visible = True
            Emailfield.Enabled = False
            btn_sendEmail.Enabled = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.Text = "Detectando red..."
        checkInternet()
    End Sub
End Class
