Public Class Form1
    Private trialNumber, standardDev As Integer
    Private upperSpec, lowerSpec, processMean, percentDefective As Double

    Private Sub NumberOfTrialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumberOfTrialsToolStripMenuItem.Click

        InputTrials()

    End Sub

    Private Function InputTrials() As Integer

        Dim message As String

        Try
            trialNumber = 50
            message = "Number of trials"
            trialNumber = InputBox("Enter a value", message, "50")

            Do While trialNumber <= 50

            Loop
            trialNumber -= 1

        Catch ex As Exception
            message = "Invalid entry"
            MessageBox.Show(message)
        End Try

    End Function

    Private Sub RunSimulationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunSimulationToolStripMenuItem.Click


        Dim message As String
        Try
            upperSpec = upperSpecificationText.Text
            lowerSpec = lowerSpecificationText.Text
            processMean = processMeanText.Text
            standardDev = standardDevText.Text
            If upperSpec < 0 Or lowerSpec < 0 Or processMean < 0 Or standardDev < 0 Then
                message = "Numbers must must be positive"
                MessageBox.Show(message)
                Exit Sub
            ElseIf upperSpec <= lowerSpec Then
                message = "Upper specification must be greater than lower"
                MessageBox.Show(message)
                Exit Sub
            End If
            If standardDev1.Checked Then
                standardDev = 1
            ElseIf standardDev2.Checked Then
                standardDev = 2
            ElseIf standardDev3.Checked Then
                standardDev = 3
            ElseIf standardDev4.Checked Then
                standardDev = 4
            ElseIf standardDev5.Checked Then
                standardDev = 5
            ElseIf standardDev6.Checked Then
                standardDev = 6
            Else
                message = "Select a standard deviation button"
                MessageBox.Show(message)
                Exit Sub
            End If
        Catch ex As Exception
            message = "Invalid entry"
            MessageBox.Show(message, "Error")
            Exit Sub
        End Try

    End Sub

End Class
