Public Class CountdownNumbers

    '' Constant definitions.
    Private Const MAX_NUMS As Integer = 6
    Private Const MAX_TIME As Double = 30 ' Seconds
    Private Const TICK_INTERVAL As Double = 0.1 ' Seconds

    ' Lower Bound <= Target < UpperBound
    Private Const TARGET_LOWER_BOUND As Integer = 100
    Private Const TARGET_UPPER_BOUND As Integer = 1000

    ' Literally the minimum number of steps to obtain a solution. 
    ' Choose 1 or more. If 0 then unsolvable puzzles included.
    Private Const DEFAULT_DIFFICULTY As Integer = 1

    Private Const FontSize2Digits As Single = 36
    Private Const FontSize3Digits As Single = 27

    Private Shared ReadOnly ActiveBackColor As System.Drawing.Color = Color.RoyalBlue
    Private Shared ReadOnly InactiveBackColor As System.Drawing.Color = Color.Brown

    Private Shared ReadOnly FromTheTop() As Integer = {100, 75, 50, 25}
    Private Shared ReadOnly FromTheBottom() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9}

    Private Enum Statuses
        ChoosingNumbers = 0
        NumbersSet = 1
        ChoosingTarget = 2
        Ticking = 3
        AwaitingSolution = 4
        Finished = 5
    End Enum

    Private RandomN As Random
    Private Status As Integer
    Private Difficulty As Integer = DEFAULT_DIFFICULTY
    Private TimeRemaining As Double = MAX_TIME

    Private Numbers As List(Of Integer)
    Private Target As Integer
    Private SolutionString As String


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.tmrClock.Interval = (TICK_INTERVAL * 1000) ' Convert seconds to milliseconds
        Me.Reset()
    End Sub

    Private Function GetNumbersFromTheTop() As Integer()
        Return Me.Numbers.Where(Function(Num As Integer)
                                    Return FromTheTop.Contains(Num)
                                End Function).ToArray()
    End Function

    Private Function GetNumbersFromTheBottom() As Integer()
        Return Me.Numbers.Where(Function(Num As Integer)
                                    Return FromTheBottom.Contains(Num)
                                End Function).ToArray()
    End Function

    Private Sub RenderNumbers()
        Dim i As Integer = 0
        For Each Number As Integer In Me.Numbers
            If Math.Log10(Number) >= 2 Then
                Me.pnlNumbers.Controls(i).Font = New Font(Me.pnlNumbers.Controls(i).Font.FontFamily.Name, FontSize3Digits)
            Else
                Me.pnlNumbers.Controls(i).Font = New Font(Me.pnlNumbers.Controls(i).Font.FontFamily.Name, FontSize2Digits)
            End If
            Me.pnlNumbers.Controls(i).Text = Number
            Me.pnlNumbers.Controls(i).BackColor = ActiveBackColor
            i += 1
        Next
        For i = i To Me.pnlNumbers.Controls.Count - 1
            Me.pnlNumbers.Controls(i).Text = ""
            Me.pnlNumbers.Controls(i).BackColor = InactiveBackColor
        Next
    End Sub

    Private Sub btnFromTheTop_Click(sender As System.Object, e As System.EventArgs) Handles btnFromTheTop.Click
        If Me.Status <> Statuses.ChoosingNumbers Then Exit Sub
        If Me.GetNumbersFromTheTop().Length >= FromTheTop.Length Then Exit Sub
        ' Add a number randomly chosen from FromTheTop to the numbers list.
        Dim RandomN As New Random
        Dim Number As Integer = FromTheTop(RandomN.Next(FromTheTop.Length))

        While Me.GetNumbersFromTheTop().Contains(Number)
            Number = FromTheTop(RandomN.Next(FromTheTop.Length))
        End While
        Me.Numbers.Add(Number)
        Me.RenderNumbers()
        If Me.Numbers.Count = MAX_NUMS Then Me.Status = Statuses.NumbersSet
    End Sub

    Private Sub btnFromTheBottom_Click(sender As System.Object, e As System.EventArgs) Handles btnFromTheBottom.Click
        If Me.Status <> Statuses.ChoosingNumbers Then Exit Sub
        ' Add a number randomly chosen from FromTheBottom to the numbers list.
        Dim RandomN As New Random
        Me.Numbers.Add(FromTheBottom(RandomN.Next(FromTheBottom.Length)))
        Me.RenderNumbers()
        If Me.Numbers.Count = MAX_NUMS Then Me.Status = Statuses.NumbersSet
    End Sub

    Private Sub ChooseTarget()
        Dim RandomN As New Random
        While True
            Dim NewTarget As Integer = RandomN.Next(TARGET_LOWER_BOUND, TARGET_UPPER_BOUND)
            Dim Solvr As New Solver(NewTarget, Me.Numbers.ToArray())
            Solvr.Solve()
            If Solvr.GetSolutionArray().Length >= Me.Difficulty Then
                Me.Target = NewTarget
                Me.SolutionString = Solvr.GetSolutionString()
                Exit While
            End If
        End While
    End Sub

    Private Sub btnTarget_Click(sender As System.Object, e As System.EventArgs) Handles btnTarget.Click
        If Me.Status <> Statuses.NumbersSet Then Exit Sub
        Me.Status = Statuses.ChoosingTarget
        Me.tmrClock.Start()
        Me.ChooseTarget()
        Me.tmrClock.Stop()
        Me.lblTarget.Text = Me.Target
        Me.Status = Statuses.Ticking
        Me.TimeRemaining = MAX_TIME
        Me.tmrClock.Start()
    End Sub

    Private Sub tmrClock_Tick(sender As System.Object, e As System.EventArgs) Handles tmrClock.Tick
        If Me.Status = Statuses.ChoosingTarget Then
            Me.lblTarget.Text = Me.RandomN.Next(TARGET_LOWER_BOUND, TARGET_UPPER_BOUND)
        ElseIf Me.Status = Statuses.Ticking Then
            Me.TimeRemaining -= TICK_INTERVAL
            ' Update countdown clock.
            If Me.TimeRemaining <= 0 Then
                Me.tmrClock.Stop()
                Me.lblClockFace.Text = "Time's up!"
                Me.Status = Statuses.AwaitingSolution
                Exit Sub
            End If
            Me.lblClockFace.Text = FormatNumber(Me.TimeRemaining, 1)
        End If
    End Sub


    Private Sub btnSolve_Click(sender As System.Object, e As System.EventArgs) Handles btnSolve.Click
        If Me.Status <> Statuses.AwaitingSolution Then Exit Sub
        Me.lblSolution.Text = Me.SolutionString
        Me.Status = Statuses.Finished
    End Sub

    Private Sub Reset()
        Me.Numbers = New List(Of Integer)
        Me.RandomN = New Random
        Me.lblTarget.Text = "000"
        Me.Target = 0
        Me.TimeRemaining = MAX_TIME
        Me.lblClockFace.Text = FormatNumber(Me.TimeRemaining, 1)
        Me.lblSolution.Text = ""
        Me.RenderNumbers()
        Me.Status = Statuses.ChoosingNumbers
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Me.Reset()
    End Sub
End Class
