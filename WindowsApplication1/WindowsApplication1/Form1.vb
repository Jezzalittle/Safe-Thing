Public Class Form1

    Dim compName()
    Dim timeStart()

    Dim timeReminder()
    Dim timeReminderInSecs

    Dim sortArray() As Integer
    Dim tempArray() As Integer
    Dim timeLeftSec()

    Dim timeLeft()
    Dim timeLeftSecs

    Dim amountOfJobs As Integer = 0

    Dim FILE_NAME As String = ("C:\Users\Public\TimeLock\Saved_Data.txt")

    Dim targetDate()
    Dim targetDateDays
    Dim targetDateInSecs()

    Dim days
    Dim hours
    Dim minutes
    Dim seconds

    Dim firstLoop = False



    Sub Bubblesort(Array() As Integer, index() As Integer, Length As Integer)
        Dim I As Integer
        Dim J As Integer
        Dim Temp As Integer
        Dim tempIndex As Integer

        For I = Length To 1 Step -1 'the last element on the array does not get sorted.    
            For J = 0 To I - 1
                If Array(J) > Array(J + 1) Then  ' Compare neighboring elements    
                    Temp = Array(J)
                    tempIndex = index(J)
                    Array(J) = Array(J + 1)
                    index(J) = index(J + 1)
                    Array(J + 1) = Temp
                    index(J + 1) = tempIndex


                End If
            Next
        Next
    End Sub


    Public Sub ConvertToHMS(ByVal timeInseconds As Integer, ByRef hours As Integer, ByRef minutes As Integer, ByRef seconds As Integer)
        hours = Math.Floor(timeInseconds / 3600)
        minutes = Math.Floor((timeInseconds Mod 3600) / 60)
        seconds = timeInseconds Mod 60
    End Sub

    Public Function ConvertToSecs(ByVal hours As Integer, ByVal minutes As Integer, ByVal seconds As Integer)
        Return (hours * 3600) + (minutes * 60) + seconds
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEntJob.Click


        targetDateDays = 0

        If firstLoop = True Then
            amountOfJobs = amountOfJobs + 1
        End If

        ReDim Preserve compName(amountOfJobs)
        ReDim Preserve timeStart(amountOfJobs)
        ReDim Preserve timeReminder(amountOfJobs)
        ReDim Preserve timeLeft(amountOfJobs)
        ReDim Preserve targetDate(amountOfJobs)
        ReDim Preserve targetDateInSecs(amountOfJobs)
        ReDim Preserve sortArray(amountOfJobs)
        ReDim Preserve tempArray(amountOfJobs)
        ReDim Preserve timeLeftSec(amountOfJobs)

        targetDateInSecs(amountOfJobs) = (ConvertToSecs(Date.Now.Hour, Date.Now.Minute, Date.Now.Second) + (Val(LabJobTime.Text) * 3600))
        ConvertToHMS(targetDateInSecs(amountOfJobs), hours, minutes, seconds)

        While hours > 24
            targetDateDays = targetDateDays + 1
            hours = hours - 24
        End While

        If targetDateDays > 0 Then
            If minutes < 10 Then
                targetDate(amountOfJobs) = targetDateDays & "d " & hours & " : 0" & minutes
            Else
                targetDate(amountOfJobs) = targetDateDays & "d " & hours & " : " & minutes
            End If
        Else
            If minutes < 10 Then
                targetDate(amountOfJobs) = hours & " : 0" & minutes
            Else
                targetDate(amountOfJobs) = hours & " : " & minutes
            End If
        End If

        timeLeftSec(amountOfJobs) = targetDateInSecs(amountOfJobs) - ConvertToSecs(Date.Now.Hour, Date.Now.Minute, Date.Now.Second)





        ConvertToHMS(timeLeftSec(amountOfJobs), hours, minutes, seconds)

        If minutes < 10 Then
            timeLeft(amountOfJobs) = hours & " : 0" & minutes
        Else
            timeLeft(amountOfJobs) = hours & " : " & minutes
        End If

        timeReminderInSecs = Val(LabReminderTime.Text) * 3600
        ConvertToHMS(timeReminderInSecs, hours, minutes, seconds)

        If minutes < 10 Then
            timeReminder(amountOfJobs) = hours & " : 0" & minutes
        Else
            timeReminder(amountOfJobs) = hours & " : " & minutes
        End If

        compName(amountOfJobs) = LabCompName.Text

        If Date.Now.Minute < 10 Then
            timeStart(amountOfJobs) = Date.Now.Hour & " : 0" & Date.Now.Minute
        Else
            timeStart(amountOfJobs) = Date.Now.Hour & " : " & Date.Now.Minute
        End If





        For i = 0 To amountOfJobs

            tempArray(i) = timeLeftSec(i)


        Next

        For i = 0 To amountOfJobs

            sortArray(i) = i


        Next


        Bubblesort(tempArray, sortArray, amountOfJobs)




        For i = 0 To amountOfJobs
            Console.WriteLine(tempArray(i) & " " & i)


        Next






        DataGridView1.Rows.Clear()


        For i = 0 To amountOfJobs

            DataGridView1.Rows.Add(compName(sortArray(i)), timeLeft(sortArray(i)), timeStart(sortArray(i)), targetDate(sortArray(i)), timeReminder(sortArray(i)))

        Next






        If firstLoop = False Then
            Timer1.Start()
        End If

        firstLoop = True

        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

        If My.Computer.FileSystem.FileExists(FILE_NAME) Then 'Checks to see if file Exists
            objWriter.WriteLine(amountOfJobs)
            For i As Integer = 0 To amountOfJobs
                objWriter.WriteLine(compName(i))
                objWriter.WriteLine(timeLeft(i))
                objWriter.WriteLine(timeStart(i))
                objWriter.WriteLine(targetDate(i))
                objWriter.WriteLine(timeReminder(i))
                objWriter.WriteLine(targetDateInSecs(i))
            Next
            objWriter.Close()
        Else
            MessageBox.Show("Saved_Data.txt Does Not Exist") 'if file does not exsit display 
        End If



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        DataGridView1.Rows.Clear()

        For i As Integer = 0 To amountOfJobs


            Dim tempTimeLeft = 0
            tempTimeLeft = targetDateInSecs(i) - ConvertToSecs(Date.Now.Hour, Date.Now.Minute, Date.Now.Second)
            ConvertToHMS(tempTimeLeft, hours, minutes, seconds)
            If minutes < 10 Then
                timeLeft(i) = hours & " : 0" & minutes
            Else
                timeLeft(i) = hours & " : " & minutes
            End If






            For j As Integer = 0 To amountOfJobs
            Next

            If targetDateInSecs(sortArray(i)) > ConvertToSecs(Date.Now.Hour, Date.Now.Minute, Date.Now.Second) Then
                Console.WriteLine(timeLeftSec(sortArray(i)))
                DataGridView1.Rows.Add(compName(sortArray(i)), timeLeft(sortArray(i)), timeStart(sortArray(i)), targetDate(sortArray(i)), timeReminder(sortArray(i)))

            End If


            If timeLeft(i) = timeReminder(i) Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                MsgBox(compName(i) & " Has " & timeReminder(i) & " Time Left")
            End If





        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim j As Integer = 0

        If My.Computer.FileSystem.FileExists(FILE_NAME) Then 'Checks to see if file Exists

            Dim objRead As New System.IO.StreamReader(FILE_NAME)
            If objRead.EndOfStream = True Then


                amountOfJobs = objRead.ReadLine()


                ReDim Preserve compName(amountOfJobs)
                ReDim Preserve timeStart(amountOfJobs)
                ReDim Preserve timeReminder(amountOfJobs)
                ReDim Preserve timeLeft(amountOfJobs)
                ReDim Preserve targetDate(amountOfJobs)
                ReDim Preserve targetDateInSecs(amountOfJobs)

                If amountOfJobs > 0 Then

                    For j = 0 To amountOfJobs

                        compName(j) = objRead.ReadLine()
                        timeLeft(j) = objRead.ReadLine()
                        timeStart(j) = objRead.ReadLine()
                        targetDate(j) = objRead.ReadLine()
                        timeReminder(j) = objRead.ReadLine()
                        targetDateInSecs(j) = objRead.ReadLine()

                        DataGridView1.Rows.Add(compName(j), timeLeft(j), timeStart(j), targetDate(j), timeReminder(j))


                        Timer1.Start()
                    Next
                End If


            End If
            objRead.Close()
        Else
            MessageBox.Show("Test3.txt Does Not Exist") 'if file does not exsit 
        End If
    End Sub

End Class