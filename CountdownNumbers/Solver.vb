Public Class Solver

    ' Have found depth first search produces some odd results.
    ' Consider using depth first search to build a graph and then use dijkstra to calculate
    ' shortest distance between the nodes. Large single operations are considered more expensive
    ' than smaller operations.

    Public Target As Integer
    Public Numbers() As Integer

    Private Const ADD As Integer = 0
    Private Const SUB1 As Integer = 1
    Private Const SUB2 As Integer = 2
    Private Const MUL As Integer = 3
    Private Const DIV1 As Integer = 4
    Private Const DIV2 As Integer = 5

    Private Shared Operators() As Char = {"+", "-", "-", "×", "÷", "÷"}

    Private WorkingStack As Stack(Of Integer())
    Private Solution()() As Integer

    Public Sub New(ByVal Target As Integer, ByVal Numbers() As Integer)
        Me.Target = Target
        Me.Numbers = Numbers
        Me.WorkingStack = New Stack(Of Integer())
        Me.Solution = {}
    End Sub

    Public Function GetSolutionString() As String
        If Me.Solution.Length = 0 Then Return "No Solution."
        Dim Solution As String = ""
        For Each Expression() As Integer In Me.Solution
            Solution &= String.Format("{0} {1} {2} = {3}" & vbCrLf, Expression(0), Operators(Expression(1)), Expression(2), Expression(3))
        Next
        Return Solution
    End Function

    Public Function GetSolutionArray() As String()
        Dim Solution(UBound(Me.Solution)) As String
        If Me.Solution.Length = 0 Then Return Solution
        For i As Integer = 0 To UBound(Me.Solution)
            Dim Expression() As Integer = Me.Solution(i)
            Solution(i) = String.Format("{0} {1} {2} = {3}", Expression(0), Operators(Expression(1)), Expression(2), Expression(3))
        Next
        Return Solution
    End Function

    Private Shared Function Evaluate(ByVal Num1 As Integer, ByVal Op As Integer, ByVal Num2 As Integer) As Integer
        Select Case Op
            Case ADD
                Return Num1 + Num2
            Case SUB1
                Return Num1 - Num2
            Case SUB2
                Return Num2 - Num1
            Case MUL
                Return Num1 * Num2
            Case DIV1
                Return Num1 / Num2
            Case DIV2
                Return Num2 / Num1
        End Select
        Return 0
    End Function

    Private Sub SaveWorking(ByVal Num1 As Integer, ByVal Op As Integer, ByVal Num2 As Integer, ByVal Result As Integer)
        If Op = SUB2 Or Op = DIV2 Then
            ' Ensure operands in division and subtraction are saved the correct way round.
            Me.WorkingStack.Push({Num2, Op, Num1, Result})
        Else
            Me.WorkingStack.Push({Num1, Op, Num2, Result})
        End If
    End Sub

    Private Function DFS(ByVal Depth As Integer, ByRef AvailNumbers As List(Of Integer)) As Integer
        Dim Result As Integer = 0

        If Depth < 1 Then
            Return 0
        End If

        For i As Integer = 0 To AvailNumbers.Count - 1
            Dim Num1 As Integer = AvailNumbers(i)
            AvailNumbers.RemoveAt(i)
            For j As Integer = i To AvailNumbers.Count - 1

                Dim Num2 As Integer = AvailNumbers(j)
                AvailNumbers.RemoveAt(j)

                For Op As Integer = 0 To 5
                    Select Case Op
                        Case SUB1
                            If Num1 < Num2 Then Continue For ' Prevent negatives
                        Case SUB2
                            If Num2 < Num1 Then Continue For
                        Case DIV1
                            If Num2 <= 1 Then Continue For ' n / 1 = n, n / 0 = inf
                            If Num1 Mod Num2 <> 0 Then Continue For
                        Case DIV2
                            If Num1 <= 1 Then Continue For
                            If Num2 Mod Num1 <> 0 Then Continue For
                        Case MUL
                            If Num1 = 1 Or Num2 = 1 Then Continue For ' n * 1 = n
                    End Select

                    Result = Evaluate(Num1, Op, Num2)
                    AvailNumbers.Add(Result)

                    If Result = Me.Target Then
                        ' Save working to the stack.
                        Me.SaveWorking(Num1, Op, Num2, Result)
                        Return 1
                    ElseIf Me.DFS(Depth - 1, AvailNumbers) = 1 Then
                        ' Push an earlier step of working to the top of the stack.
                        Me.SaveWorking(Num1, Op, Num2, Result)
                        Return 1
                    End If
                    AvailNumbers.Remove(Result)
                Next
                AvailNumbers.Insert(j, Num2)
            Next
            AvailNumbers.Insert(i, Num1)
        Next
        Return 0
    End Function

    Public Sub Solve()
        Me.Solution = {}
        For d As Integer = 1 To Me.Numbers.Length
            Me.WorkingStack = New Stack(Of Integer())
            If DFS(d, Me.Numbers.ToList()) = 1 Then
                Me.Solution = Me.WorkingStack.ToArray()
                Exit For
            End If
        Next
    End Sub

End Class