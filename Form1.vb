Public Class Form1
    Private horses As List(Of Label)
    Private horsePositions As List(Of Integer)
    Private rnd As New Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        horses = New List(Of Label) From {lblHorse1, lblHorse2, lblHorse3, lblHorse4, lblHorse5, lblHorse6, lblHorse7, lblHorse8, lblHorse9, lblHorse10}
        horsePositions = New List(Of Integer)(New Integer(9) {})
        For i As Integer = 1 To 10
            cmbGuess1.Items.Add($"Horse {i}")
            cmbGuess2.Items.Add($"Horse {i}")
        Next
    End Sub

    Private Sub btnStartRace_Click(sender As Object, e As EventArgs) Handles btnStartRace.Click
        If cmbGuess1.SelectedIndex = -1 Or cmbGuess2.SelectedIndex = -1 Then
            MessageBox.Show("Please select two horses to guess.")
            Return
        End If

        lblResults.Text = "Race in progress..."
        ResetRace()

        Dim raceTimer As New Timer With {.Interval = 50}
        AddHandler raceTimer.Tick, Sub()
                                       UpdateRace()
                                       If RaceFinished() Then
                                           raceTimer.Stop()
                                           DisplayResults()
                                       End If
                                   End Sub
        raceTimer.Start()
    End Sub

    Private Sub ResetRace()
        For i As Integer = 0 To horses.Count - 1
            horses(i).Left = 10
            horsePositions(i) = horses(i).Left
        Next
    End Sub

    Private Sub UpdateRace()
        For i As Integer = 0 To horses.Count - 1
            Dim move As Integer = rnd.Next(1, 10)
            horses(i).Left += move
            horsePositions(i) = horses(i).Left
        Next
    End Sub

    Private Function RaceFinished() As Boolean
        For Each pos As Integer In horsePositions
            If pos >= Me.ClientSize.Width - 50 Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub DisplayResults()
        Dim winner As Integer = horsePositions.IndexOf(horsePositions.Max()) + 1
        lblResults.Text = $"Horse {winner} wins the race!"

        Dim guess1 As Integer = cmbGuess1.SelectedIndex + 1
        Dim guess2 As Integer = cmbGuess2.SelectedIndex + 1

        If winner = guess1 Or winner = guess2 Then
            lblResults.Text &= " You guessed correctly!"
        Else
            lblResults.Text &= " Better luck next time!"
        End If
    End Sub
End Class
