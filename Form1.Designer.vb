<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHorse1 = New Label()
        lblHorse2 = New Label()
        lblHorse3 = New Label()
        lblHorse4 = New Label()
        lblHorse5 = New Label()
        lblHorse6 = New Label()
        lblHorse7 = New Label()
        lblHorse8 = New Label()
        lblHorse9 = New Label()
        lblHorse10 = New Label()
        cmbGuess1 = New ComboBox()
        cmbGuess2 = New ComboBox()
        btnStartRace = New Button()
        lblResults = New Label()
        SuspendLayout()
        ' 
        ' lblHorse1
        ' 
        lblHorse1.AutoSize = True
        lblHorse1.Location = New Point(48, 14)
        lblHorse1.Name = "lblHorse1"
        lblHorse1.Size = New Size(47, 15)
        lblHorse1.TabIndex = 0
        lblHorse1.Text = "Horse 1"
        ' 
        ' lblHorse2
        ' 
        lblHorse2.AutoSize = True
        lblHorse2.Location = New Point(48, 36)
        lblHorse2.Name = "lblHorse2"
        lblHorse2.Size = New Size(47, 15)
        lblHorse2.TabIndex = 1
        lblHorse2.Text = "Horse 2"
        ' 
        ' lblHorse3
        ' 
        lblHorse3.AutoSize = True
        lblHorse3.Location = New Point(48, 60)
        lblHorse3.Name = "lblHorse3"
        lblHorse3.Size = New Size(47, 15)
        lblHorse3.TabIndex = 2
        lblHorse3.Text = "Horse 3"
        ' 
        ' lblHorse4
        ' 
        lblHorse4.AutoSize = True
        lblHorse4.Location = New Point(48, 83)
        lblHorse4.Name = "lblHorse4"
        lblHorse4.Size = New Size(47, 15)
        lblHorse4.TabIndex = 3
        lblHorse4.Text = "Horse 4"
        ' 
        ' lblHorse5
        ' 
        lblHorse5.AutoSize = True
        lblHorse5.Location = New Point(48, 106)
        lblHorse5.Name = "lblHorse5"
        lblHorse5.Size = New Size(47, 15)
        lblHorse5.TabIndex = 4
        lblHorse5.Text = "Horse 5"
        ' 
        ' lblHorse6
        ' 
        lblHorse6.AutoSize = True
        lblHorse6.Location = New Point(48, 127)
        lblHorse6.Name = "lblHorse6"
        lblHorse6.Size = New Size(47, 15)
        lblHorse6.TabIndex = 5
        lblHorse6.Text = "Horse 6"
        ' 
        ' lblHorse7
        ' 
        lblHorse7.AutoSize = True
        lblHorse7.Location = New Point(48, 147)
        lblHorse7.Name = "lblHorse7"
        lblHorse7.Size = New Size(47, 15)
        lblHorse7.TabIndex = 6
        lblHorse7.Text = "Horse 7"
        ' 
        ' lblHorse8
        ' 
        lblHorse8.AutoSize = True
        lblHorse8.Location = New Point(48, 171)
        lblHorse8.Name = "lblHorse8"
        lblHorse8.Size = New Size(47, 15)
        lblHorse8.TabIndex = 7
        lblHorse8.Text = "Horse 8"
        ' 
        ' lblHorse9
        ' 
        lblHorse9.AutoSize = True
        lblHorse9.Location = New Point(48, 195)
        lblHorse9.Name = "lblHorse9"
        lblHorse9.Size = New Size(47, 15)
        lblHorse9.TabIndex = 8
        lblHorse9.Text = "Horse 9"
        ' 
        ' lblHorse10
        ' 
        lblHorse10.AutoSize = True
        lblHorse10.Location = New Point(42, 219)
        lblHorse10.Name = "lblHorse10"
        lblHorse10.Size = New Size(53, 15)
        lblHorse10.TabIndex = 9
        lblHorse10.Text = "Horse 10"
        ' 
        ' cmbGuess1
        ' 
        cmbGuess1.FormattingEnabled = True
        cmbGuess1.Location = New Point(263, 106)
        cmbGuess1.Name = "cmbGuess1"
        cmbGuess1.Size = New Size(121, 23)
        cmbGuess1.TabIndex = 10
        cmbGuess1.Text = "Guess 2"
        ' 
        ' cmbGuess2
        ' 
        cmbGuess2.FormattingEnabled = True
        cmbGuess2.Location = New Point(263, 52)
        cmbGuess2.Name = "cmbGuess2"
        cmbGuess2.Size = New Size(121, 23)
        cmbGuess2.TabIndex = 11
        cmbGuess2.Text = "Guess 1"
        ' 
        ' btnStartRace
        ' 
        btnStartRace.Location = New Point(178, 332)
        btnStartRace.Name = "btnStartRace"
        btnStartRace.Size = New Size(75, 23)
        btnStartRace.TabIndex = 12
        btnStartRace.Text = "Start Race"
        btnStartRace.UseVisualStyleBackColor = True
        ' 
        ' lblResults
        ' 
        lblResults.AutoSize = True
        lblResults.Location = New Point(188, 304)
        lblResults.Name = "lblResults"
        lblResults.Size = New Size(44, 15)
        lblResults.TabIndex = 13
        lblResults.Text = "Results"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResults)
        Controls.Add(btnStartRace)
        Controls.Add(cmbGuess2)
        Controls.Add(cmbGuess1)
        Controls.Add(lblHorse10)
        Controls.Add(lblHorse9)
        Controls.Add(lblHorse8)
        Controls.Add(lblHorse7)
        Controls.Add(lblHorse6)
        Controls.Add(lblHorse5)
        Controls.Add(lblHorse4)
        Controls.Add(lblHorse3)
        Controls.Add(lblHorse2)
        Controls.Add(lblHorse1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHorse1 As Label
    Friend WithEvents lblHorse2 As Label
    Friend WithEvents lblHorse3 As Label
    Friend WithEvents lblHorse4 As Label
    Friend WithEvents lblHorse5 As Label
    Friend WithEvents lblHorse6 As Label
    Friend WithEvents lblHorse7 As Label
    Friend WithEvents lblHorse8 As Label
    Friend WithEvents lblHorse9 As Label
    Friend WithEvents lblHorse10 As Label
    Friend WithEvents cmbGuess1 As ComboBox
    Friend WithEvents cmbGuess2 As ComboBox
    Friend WithEvents btnStartRace As Button
    Friend WithEvents lblResults As Label

End Class
