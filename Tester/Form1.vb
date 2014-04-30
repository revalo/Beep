Imports Beeper
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        beep(262, 200)
        ' a hertz (A4) for half a second
        beep(262, 200)
        ' a# 4 hertz for half a second
        beep(294, 200)
        ' b hertz for half a second
        beep(262, 200)
        ' c hertz for half a second
        beep(349, 200)
        ' c# hertz for half a second
        beep(330, 200)
        ' d hertz (A4) for half a second
        beep(262, 200)
        ' d# hertz for half a second
        beep(262, 200)
        ' e hertz for half a second
        beep(294, 200)
        ' f hertz for half a second
        beep(262, 200)
        ' f# hertz for half a second
        beep(392, 200)
        ' g hertz (A4) for half a second
        beep(349, 200)
        ' g# hertz for half a second
        beep(262, 200)
        ' a hertz for half a second
        beep(262, 200)
        ' 587 hertz for half a second
        beep(482, 200)
        ' 659 hertz for half a second
        beep(440, 200)
        ' d hertz (A4) for half a second
        beep(349, 200)
        ' d# hertz for half a second
        beep(330, 200)
        ' e hertz for half a second
        beep(294, 200)
        ' f hertz for half a second
        beep(482, 200)
        ' f# hertz for half a second
        beep(482, 200)
        ' g hertz (A4) for half a second
        beep(440, 200)
        ' g# hertz for half a second
        beep(349, 200)
        ' a hertz for half a second
        beep(392, 200)
        ' 587 hertz for half a second
        beep(349, 200)
        ' 659 hertz for half a second
    End Sub
    Sub beep(ByVal freq As Integer, ByVal ms As Integer)
        Beeper.beepnow(freq, ms)
    End Sub
End Class
