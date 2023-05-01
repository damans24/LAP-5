<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AnalysisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumberOfTrialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunSimulationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetSimulationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.upperSpecificationLabel = New System.Windows.Forms.Label()
        Me.lowerSpecificationLabel = New System.Windows.Forms.Label()
        Me.processMeanLabel = New System.Windows.Forms.Label()
        Me.standardDeviationLabel = New System.Windows.Forms.Label()
        Me.upperSpecificationText = New System.Windows.Forms.TextBox()
        Me.lowerSpecificationText = New System.Windows.Forms.TextBox()
        Me.processMeanText = New System.Windows.Forms.TextBox()
        Me.standardDevText = New System.Windows.Forms.TextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.pointsNumberText = New System.Windows.Forms.TextBox()
        Me.percentDefectiveText = New System.Windows.Forms.TextBox()
        Me.pointsNumberLabel = New System.Windows.Forms.Label()
        Me.percentDefectiveLabel = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.standardDev1 = New System.Windows.Forms.RadioButton()
        Me.standardDev2 = New System.Windows.Forms.RadioButton()
        Me.standardDev3 = New System.Windows.Forms.RadioButton()
        Me.standardDev4 = New System.Windows.Forms.RadioButton()
        Me.standardDev5 = New System.Windows.Forms.RadioButton()
        Me.standardDev6 = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnalysisToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(909, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AnalysisToolStripMenuItem
        '
        Me.AnalysisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NumberOfTrialsToolStripMenuItem, Me.RunSimulationToolStripMenuItem, Me.ResetSimulationToolStripMenuItem})
        Me.AnalysisToolStripMenuItem.Name = "AnalysisToolStripMenuItem"
        Me.AnalysisToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.AnalysisToolStripMenuItem.Text = "&Analysis"
        '
        'NumberOfTrialsToolStripMenuItem
        '
        Me.NumberOfTrialsToolStripMenuItem.Name = "NumberOfTrialsToolStripMenuItem"
        Me.NumberOfTrialsToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.NumberOfTrialsToolStripMenuItem.Text = "&Number of Trials"
        '
        'RunSimulationToolStripMenuItem
        '
        Me.RunSimulationToolStripMenuItem.Name = "RunSimulationToolStripMenuItem"
        Me.RunSimulationToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.RunSimulationToolStripMenuItem.Text = "&Run Simulation"
        '
        'ResetSimulationToolStripMenuItem
        '
        Me.ResetSimulationToolStripMenuItem.Name = "ResetSimulationToolStripMenuItem"
        Me.ResetSimulationToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ResetSimulationToolStripMenuItem.Text = "Re&set Simulation"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(55, 29)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.standardDevText)
        Me.groupBox1.Controls.Add(Me.processMeanText)
        Me.groupBox1.Controls.Add(Me.lowerSpecificationText)
        Me.groupBox1.Controls.Add(Me.upperSpecificationText)
        Me.groupBox1.Controls.Add(Me.standardDeviationLabel)
        Me.groupBox1.Controls.Add(Me.processMeanLabel)
        Me.groupBox1.Controls.Add(Me.lowerSpecificationLabel)
        Me.groupBox1.Controls.Add(Me.upperSpecificationLabel)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(37, 59)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(413, 250)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Process Inputs"
        '
        'upperSpecificationLabel
        '
        Me.upperSpecificationLabel.Location = New System.Drawing.Point(19, 48)
        Me.upperSpecificationLabel.Name = "upperSpecificationLabel"
        Me.upperSpecificationLabel.Size = New System.Drawing.Size(209, 32)
        Me.upperSpecificationLabel.TabIndex = 0
        Me.upperSpecificationLabel.Text = "Upper Specification:"
        '
        'lowerSpecificationLabel
        '
        Me.lowerSpecificationLabel.Location = New System.Drawing.Point(19, 89)
        Me.lowerSpecificationLabel.Name = "lowerSpecificationLabel"
        Me.lowerSpecificationLabel.Size = New System.Drawing.Size(209, 32)
        Me.lowerSpecificationLabel.TabIndex = 1
        Me.lowerSpecificationLabel.Text = "Lower Specification:"
        '
        'processMeanLabel
        '
        Me.processMeanLabel.Location = New System.Drawing.Point(19, 152)
        Me.processMeanLabel.Name = "processMeanLabel"
        Me.processMeanLabel.Size = New System.Drawing.Size(162, 32)
        Me.processMeanLabel.TabIndex = 2
        Me.processMeanLabel.Text = "Process Mean:"
        '
        'standardDeviationLabel
        '
        Me.standardDeviationLabel.Location = New System.Drawing.Point(19, 193)
        Me.standardDeviationLabel.Name = "standardDeviationLabel"
        Me.standardDeviationLabel.Size = New System.Drawing.Size(209, 32)
        Me.standardDeviationLabel.TabIndex = 3
        Me.standardDeviationLabel.Text = "Standard Deviation:"
        '
        'upperSpecificationText
        '
        Me.upperSpecificationText.Location = New System.Drawing.Point(235, 48)
        Me.upperSpecificationText.Multiline = True
        Me.upperSpecificationText.Name = "upperSpecificationText"
        Me.upperSpecificationText.Size = New System.Drawing.Size(147, 32)
        Me.upperSpecificationText.TabIndex = 4
        '
        'lowerSpecificationText
        '
        Me.lowerSpecificationText.Location = New System.Drawing.Point(235, 89)
        Me.lowerSpecificationText.Multiline = True
        Me.lowerSpecificationText.Name = "lowerSpecificationText"
        Me.lowerSpecificationText.Size = New System.Drawing.Size(147, 32)
        Me.lowerSpecificationText.TabIndex = 5
        '
        'processMeanText
        '
        Me.processMeanText.Location = New System.Drawing.Point(235, 152)
        Me.processMeanText.Multiline = True
        Me.processMeanText.Name = "processMeanText"
        Me.processMeanText.Size = New System.Drawing.Size(147, 32)
        Me.processMeanText.TabIndex = 6
        '
        'standardDevText
        '
        Me.standardDevText.Location = New System.Drawing.Point(235, 193)
        Me.standardDevText.Multiline = True
        Me.standardDevText.Name = "standardDevText"
        Me.standardDevText.Size = New System.Drawing.Size(147, 32)
        Me.standardDevText.TabIndex = 7
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.percentDefectiveLabel)
        Me.groupBox2.Controls.Add(Me.pointsNumberLabel)
        Me.groupBox2.Controls.Add(Me.percentDefectiveText)
        Me.groupBox2.Controls.Add(Me.pointsNumberText)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(37, 328)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(413, 133)
        Me.groupBox2.TabIndex = 2
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Results"
        '
        'pointsNumberText
        '
        Me.pointsNumberText.Location = New System.Drawing.Point(235, 31)
        Me.pointsNumberText.Multiline = True
        Me.pointsNumberText.Name = "pointsNumberText"
        Me.pointsNumberText.ReadOnly = True
        Me.pointsNumberText.Size = New System.Drawing.Size(147, 32)
        Me.pointsNumberText.TabIndex = 5
        '
        'percentDefectiveText
        '
        Me.percentDefectiveText.Location = New System.Drawing.Point(235, 81)
        Me.percentDefectiveText.Multiline = True
        Me.percentDefectiveText.Name = "percentDefectiveText"
        Me.percentDefectiveText.ReadOnly = True
        Me.percentDefectiveText.Size = New System.Drawing.Size(147, 32)
        Me.percentDefectiveText.TabIndex = 5
        '
        'pointsNumberLabel
        '
        Me.pointsNumberLabel.Location = New System.Drawing.Point(19, 31)
        Me.pointsNumberLabel.Name = "pointsNumberLabel"
        Me.pointsNumberLabel.Size = New System.Drawing.Size(189, 32)
        Me.pointsNumberLabel.TabIndex = 6
        Me.pointsNumberLabel.Text = "Number of Points:"
        '
        'percentDefectiveLabel
        '
        Me.percentDefectiveLabel.Location = New System.Drawing.Point(19, 81)
        Me.percentDefectiveLabel.Name = "percentDefectiveLabel"
        Me.percentDefectiveLabel.Size = New System.Drawing.Size(199, 32)
        Me.percentDefectiveLabel.TabIndex = 7
        Me.percentDefectiveLabel.Text = "Percent Defective:"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.standardDev6)
        Me.groupBox3.Controls.Add(Me.standardDev5)
        Me.groupBox3.Controls.Add(Me.standardDev4)
        Me.groupBox3.Controls.Add(Me.standardDev3)
        Me.groupBox3.Controls.Add(Me.standardDev2)
        Me.groupBox3.Controls.Add(Me.standardDev1)
        Me.groupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox3.Location = New System.Drawing.Point(514, 59)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(319, 282)
        Me.groupBox3.TabIndex = 3
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Standard Deviations"
        '
        'standardDev1
        '
        Me.standardDev1.AutoSize = True
        Me.standardDev1.Location = New System.Drawing.Point(30, 48)
        Me.standardDev1.Name = "standardDev1"
        Me.standardDev1.Size = New System.Drawing.Size(240, 30)
        Me.standardDev1.TabIndex = 0
        Me.standardDev1.TabStop = True
        Me.standardDev1.Text = "1 Standard Deviation"
        Me.standardDev1.UseVisualStyleBackColor = True
        '
        'standardDev2
        '
        Me.standardDev2.AutoSize = True
        Me.standardDev2.Location = New System.Drawing.Point(30, 84)
        Me.standardDev2.Name = "standardDev2"
        Me.standardDev2.Size = New System.Drawing.Size(240, 30)
        Me.standardDev2.TabIndex = 1
        Me.standardDev2.TabStop = True
        Me.standardDev2.Text = "2 Standard Deviation"
        Me.standardDev2.UseVisualStyleBackColor = True
        '
        'standardDev3
        '
        Me.standardDev3.AutoSize = True
        Me.standardDev3.Location = New System.Drawing.Point(30, 120)
        Me.standardDev3.Name = "standardDev3"
        Me.standardDev3.Size = New System.Drawing.Size(240, 30)
        Me.standardDev3.TabIndex = 2
        Me.standardDev3.TabStop = True
        Me.standardDev3.Text = "3 Standard Deviation"
        Me.standardDev3.UseVisualStyleBackColor = True
        '
        'standardDev4
        '
        Me.standardDev4.AutoSize = True
        Me.standardDev4.Location = New System.Drawing.Point(30, 156)
        Me.standardDev4.Name = "standardDev4"
        Me.standardDev4.Size = New System.Drawing.Size(240, 30)
        Me.standardDev4.TabIndex = 3
        Me.standardDev4.TabStop = True
        Me.standardDev4.Text = "4 Standard Deviation"
        Me.standardDev4.UseVisualStyleBackColor = True
        '
        'standardDev5
        '
        Me.standardDev5.AutoSize = True
        Me.standardDev5.Location = New System.Drawing.Point(30, 193)
        Me.standardDev5.Name = "standardDev5"
        Me.standardDev5.Size = New System.Drawing.Size(240, 30)
        Me.standardDev5.TabIndex = 4
        Me.standardDev5.TabStop = True
        Me.standardDev5.Text = "5 Standard Deviation"
        Me.standardDev5.UseVisualStyleBackColor = True
        '
        'standardDev6
        '
        Me.standardDev6.AutoSize = True
        Me.standardDev6.Location = New System.Drawing.Point(30, 231)
        Me.standardDev6.Name = "standardDev6"
        Me.standardDev6.Size = New System.Drawing.Size(240, 30)
        Me.standardDev6.TabIndex = 5
        Me.standardDev6.TabStop = True
        Me.standardDev6.Text = "6 Standard Deviation"
        Me.standardDev6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 503)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AnalysisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumberOfTrialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunSimulationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetSimulationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents groupBox1 As GroupBox
    Friend WithEvents standardDevText As TextBox
    Friend WithEvents processMeanText As TextBox
    Friend WithEvents lowerSpecificationText As TextBox
    Friend WithEvents upperSpecificationText As TextBox
    Friend WithEvents standardDeviationLabel As Label
    Friend WithEvents processMeanLabel As Label
    Friend WithEvents lowerSpecificationLabel As Label
    Friend WithEvents upperSpecificationLabel As Label
    Friend WithEvents groupBox2 As GroupBox
    Friend WithEvents percentDefectiveLabel As Label
    Friend WithEvents pointsNumberLabel As Label
    Friend WithEvents percentDefectiveText As TextBox
    Friend WithEvents pointsNumberText As TextBox
    Friend WithEvents groupBox3 As GroupBox
    Friend WithEvents standardDev6 As RadioButton
    Friend WithEvents standardDev5 As RadioButton
    Friend WithEvents standardDev4 As RadioButton
    Friend WithEvents standardDev3 As RadioButton
    Friend WithEvents standardDev2 As RadioButton
    Friend WithEvents standardDev1 As RadioButton
End Class
