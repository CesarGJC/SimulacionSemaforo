Public Class Form1
    Dim semaforo As Integer
    Private estadoSemaforo As Integer ' 0 = Rojo, 1 = Amarillo, 2 = Verde
    Private interseccion As Integer ' Posición X de la intersección
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSimular.Click

    End Sub
    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        semaforo = semaforo + 1
        If semaforo = 1 Then
            btnRojo1.Visible = False
            btnAmarillo1.Visible = True
            btnVerde1.Visible = True
            btnRojo2.Visible = True
            btnAmarillo2.Visible = True
            btnVerde2.Visible = False
            estadoSemaforo = 0
        End If
        If semaforo = 4 Then
            btnRojo1.Visible = True
            btnAmarillo1.Visible = False
            btnVerde1.Visible = True
            btnRojo2.Visible = True
            btnAmarillo2.Visible = False
            btnVerde2.Visible = True
            estadoSemaforo = 0
        End If
        If semaforo = 6 Then
            btnRojo1.Visible = True
            btnAmarillo1.Visible = True
            btnVerde1.Visible = False
            btnRojo2.Visible = False
            btnAmarillo2.Visible = True
            btnVerde2.Visible = True
            estadoSemaforo = 1
            timerAutos.Enabled = True
        End If
        If semaforo = 9 Then
            semaforo = 0
        End If
    End Sub
    Public Sub DetenerAuto()
        If estadoSemaforo = 0 Then

        End If
    End Sub
    Public Sub timerAutos_Tick(sender As Object, e As EventArgs) Handles timerAutos.Tick
        picAuto1.Left += 2
        Label1.Text = picAuto1.Left
        If estadoSemaforo = 0 Then
            If picAuto1.Left = 500 Then
                timerAutos.Enabled = False
            End If
        End If

        If picAuto1.Left >= Me.ClientSize.Width - picAuto1.Width Then
            picAuto1.Left = 0
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        semaforo = 0
        Timer1.Enabled = True
        Timer1.Interval = 1000
        timerAutos.Interval = 1
        timerAutos.Enabled = True

        estadoSemaforo = 0 ' Inicialmente en rojo
    End Sub
End Class
