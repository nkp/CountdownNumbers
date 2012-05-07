<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CountdownNumbers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btnTarget = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.lblNum0 = New System.Windows.Forms.Label()
        Me.btnFromTheTop = New System.Windows.Forms.Button()
        Me.btnFromTheBottom = New System.Windows.Forms.Button()
        Me.lblSolution = New System.Windows.Forms.Label()
        Me.pnlNumbers = New System.Windows.Forms.Panel()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblNum3 = New System.Windows.Forms.Label()
        Me.lblNum4 = New System.Windows.Forms.Label()
        Me.lblNum5 = New System.Windows.Forms.Label()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblClockFace = New System.Windows.Forms.Label()
        Me.btnSolve = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlNumbers.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.btnTarget})
        Me.ShapeContainer1.Size = New System.Drawing.Size(784, 462)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'btnTarget
        '
        Me.btnTarget.BorderWidth = 2
        Me.btnTarget.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTarget.FillColor = System.Drawing.Color.Red
        Me.btnTarget.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTarget.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central
        Me.btnTarget.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.btnTarget.Location = New System.Drawing.Point(11, 16)
        Me.btnTarget.Name = "btnTarget"
        Me.btnTarget.Size = New System.Drawing.Size(50, 50)
        '
        'lblTarget
        '
        Me.lblTarget.AutoSize = True
        Me.lblTarget.BackColor = System.Drawing.Color.Black
        Me.lblTarget.Font = New System.Drawing.Font("Franklin Gothic Heavy", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarget.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblTarget.Location = New System.Drawing.Point(347, 16)
        Me.lblTarget.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.lblTarget.Size = New System.Drawing.Size(91, 48)
        Me.lblTarget.TabIndex = 1
        Me.lblTarget.Text = "000"
        '
        'lblNum0
        '
        Me.lblNum0.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblNum0.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum0.ForeColor = System.Drawing.Color.White
        Me.lblNum0.Location = New System.Drawing.Point(87, 20)
        Me.lblNum0.MinimumSize = New System.Drawing.Size(80, 80)
        Me.lblNum0.Name = "lblNum0"
        Me.lblNum0.Size = New System.Drawing.Size(80, 80)
        Me.lblNum0.TabIndex = 4
        Me.lblNum0.Text = "75"
        Me.lblNum0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFromTheTop
        '
        Me.btnFromTheTop.Location = New System.Drawing.Point(284, 203)
        Me.btnFromTheTop.Name = "btnFromTheTop"
        Me.btnFromTheTop.Size = New System.Drawing.Size(89, 45)
        Me.btnFromTheTop.TabIndex = 8
        Me.btnFromTheTop.Text = "One From The Top"
        Me.btnFromTheTop.UseVisualStyleBackColor = True
        '
        'btnFromTheBottom
        '
        Me.btnFromTheBottom.Location = New System.Drawing.Point(411, 203)
        Me.btnFromTheBottom.Name = "btnFromTheBottom"
        Me.btnFromTheBottom.Size = New System.Drawing.Size(89, 45)
        Me.btnFromTheBottom.TabIndex = 9
        Me.btnFromTheBottom.Text = "One From The Bottom"
        Me.btnFromTheBottom.UseVisualStyleBackColor = True
        '
        'lblSolution
        '
        Me.lblSolution.AutoSize = True
        Me.lblSolution.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolution.Location = New System.Drawing.Point(142, 261)
        Me.lblSolution.MinimumSize = New System.Drawing.Size(500, 0)
        Me.lblSolution.Name = "lblSolution"
        Me.lblSolution.Size = New System.Drawing.Size(500, 31)
        Me.lblSolution.TabIndex = 10
        Me.lblSolution.Text = "Label6"
        Me.lblSolution.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlNumbers
        '
        Me.pnlNumbers.Controls.Add(Me.lblNum0)
        Me.pnlNumbers.Controls.Add(Me.lblNum1)
        Me.pnlNumbers.Controls.Add(Me.lblNum2)
        Me.pnlNumbers.Controls.Add(Me.lblNum3)
        Me.pnlNumbers.Controls.Add(Me.lblNum4)
        Me.pnlNumbers.Controls.Add(Me.lblNum5)
        Me.pnlNumbers.Location = New System.Drawing.Point(40, 77)
        Me.pnlNumbers.Name = "pnlNumbers"
        Me.pnlNumbers.Size = New System.Drawing.Size(704, 120)
        Me.pnlNumbers.TabIndex = 0
        '
        'lblNum1
        '
        Me.lblNum1.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.ForeColor = System.Drawing.Color.White
        Me.lblNum1.Location = New System.Drawing.Point(177, 20)
        Me.lblNum1.MinimumSize = New System.Drawing.Size(80, 80)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(80, 80)
        Me.lblNum1.TabIndex = 5
        Me.lblNum1.Text = "75"
        Me.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum2
        '
        Me.lblNum2.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.ForeColor = System.Drawing.Color.White
        Me.lblNum2.Location = New System.Drawing.Point(267, 20)
        Me.lblNum2.MinimumSize = New System.Drawing.Size(80, 80)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(80, 80)
        Me.lblNum2.TabIndex = 3
        Me.lblNum2.Text = "75"
        Me.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum3
        '
        Me.lblNum3.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblNum3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum3.ForeColor = System.Drawing.Color.White
        Me.lblNum3.Location = New System.Drawing.Point(357, 20)
        Me.lblNum3.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNum3.MinimumSize = New System.Drawing.Size(80, 80)
        Me.lblNum3.Name = "lblNum3"
        Me.lblNum3.Size = New System.Drawing.Size(80, 80)
        Me.lblNum3.TabIndex = 2
        Me.lblNum3.Text = "100"
        Me.lblNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum4
        '
        Me.lblNum4.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblNum4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum4.ForeColor = System.Drawing.Color.White
        Me.lblNum4.Location = New System.Drawing.Point(447, 20)
        Me.lblNum4.MinimumSize = New System.Drawing.Size(80, 80)
        Me.lblNum4.Name = "lblNum4"
        Me.lblNum4.Size = New System.Drawing.Size(80, 80)
        Me.lblNum4.TabIndex = 1
        Me.lblNum4.Text = "75"
        Me.lblNum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum5
        '
        Me.lblNum5.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblNum5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum5.ForeColor = System.Drawing.Color.White
        Me.lblNum5.Location = New System.Drawing.Point(537, 20)
        Me.lblNum5.MinimumSize = New System.Drawing.Size(80, 80)
        Me.lblNum5.Name = "lblNum5"
        Me.lblNum5.Size = New System.Drawing.Size(80, 80)
        Me.lblNum5.TabIndex = 0
        Me.lblNum5.Text = "75"
        Me.lblNum5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrClock
        '
        '
        'lblClockFace
        '
        Me.lblClockFace.AutoSize = True
        Me.lblClockFace.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClockFace.Location = New System.Drawing.Point(580, 16)
        Me.lblClockFace.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblClockFace.Name = "lblClockFace"
        Me.lblClockFace.Size = New System.Drawing.Size(88, 39)
        Me.lblClockFace.TabIndex = 11
        Me.lblClockFace.Text = "30.0"
        Me.lblClockFace.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnSolve
        '
        Me.btnSolve.Location = New System.Drawing.Point(11, 384)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(75, 30)
        Me.btnSolve.TabIndex = 12
        Me.btnSolve.Text = "Solve"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(11, 420)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'CountdownNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 462)
        Me.Controls.Add(Me.lblClockFace)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.pnlNumbers)
        Me.Controls.Add(Me.lblSolution)
        Me.Controls.Add(Me.btnFromTheBottom)
        Me.Controls.Add(Me.btnFromTheTop)
        Me.Controls.Add(Me.lblTarget)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "CountdownNumbers"
        Me.Text = "Form1"
        Me.pnlNumbers.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents btnTarget As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents lblTarget As System.Windows.Forms.Label
    Friend WithEvents lblNum0 As System.Windows.Forms.Label
    Friend WithEvents btnFromTheTop As System.Windows.Forms.Button
    Friend WithEvents btnFromTheBottom As System.Windows.Forms.Button
    Friend WithEvents lblSolution As System.Windows.Forms.Label
    Friend WithEvents pnlNumbers As System.Windows.Forms.Panel
    Friend WithEvents lblNum1 As System.Windows.Forms.Label
    Friend WithEvents lblNum2 As System.Windows.Forms.Label
    Friend WithEvents lblNum3 As System.Windows.Forms.Label
    Friend WithEvents lblNum4 As System.Windows.Forms.Label
    Friend WithEvents lblNum5 As System.Windows.Forms.Label
    Friend WithEvents tmrClock As System.Windows.Forms.Timer
    Friend WithEvents lblClockFace As System.Windows.Forms.Label
    Friend WithEvents btnSolve As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
