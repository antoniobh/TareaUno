Public Class loadingPage
    Private time As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerLoading.Tick
        time += 1

        If time > 3 Then
            Me.Visible = False
            Form1.Visible = True
            TimerLoading.Stop()
        End If

    End Sub

    Private Sub loadingPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        TimerLoading.Interval = 1000
        TimerLoading.Start()

    End Sub
End Class