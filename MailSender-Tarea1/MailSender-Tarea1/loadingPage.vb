Public Class loadingPage
    'creo un objeto entero quien cuenta los segundos transcurridos
    Private seconds As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerLoading.Tick
        'sumo e igualo los segundos en 1
        seconds += 1
        'Verifico que hallan transcurrido 3 segundos
        If seconds > 3 Then
            'Oculto el formulario de login y muestro el de la aplicacion ademas de detener el tiempo
            Me.Visible = False
            Form1.Visible = True
            TimerLoading.Stop()
        End If

    End Sub

    Private Sub loadingPage_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Creo un intervalo e inicio la aplicacion al iniciar el programa
        TimerLoading.Interval = 1000
        TimerLoading.Start()

    End Sub
End Class