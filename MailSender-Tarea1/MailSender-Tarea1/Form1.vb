Public Class Form1
    Private x = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        If isMail() Then
            Emailfield.Enabled = False
            btn_sendEmail.Enabled = False
            btn_sendEmail.BackColor = Color.Plum
            btn_sendEmail.Text = "Enviando..."
            Timer1.Start()
            Timer1.Interval = 1000
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
            Emailfield.Focus()
        End If


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



End Class
