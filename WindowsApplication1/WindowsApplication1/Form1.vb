Public Class Form1

    Dim compName()
    Dim timeLeft()
    Dim timeStart()
    Dim timeEnd()
    Dim timeReminder()

    Dim amountOfJobs As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Public Function ConvertToSecs(ByVal hours As Integer, ByVal minutes As Integer, ByVal seconds As Integer)
        Return (hours * 3600) + (minutes * 60) + seconds
    End Function

    Public Sub ConvertToHMS(ByVal timeInseconds As Integer, ByRef hours As Integer, ByRef minutes As Integer, ByRef seconds As Integer)
        hours = Math.Floor(timeInseconds / 3600)
        minutes = Math.Floor((timeInseconds Mod 3600) / 60)
        seconds = timeInseconds Mod 60
    End Sub








End Class
