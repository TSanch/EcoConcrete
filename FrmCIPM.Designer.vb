<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCIPM
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.Numwa = New System.Windows.Forms.NumericUpDown()
        Me.Numwb = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumCa = New System.Windows.Forms.NumericUpDown()
        Me.NumCb = New System.Windows.Forms.NumericUpDown()
        Me.Numdc = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonCIPM = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.LabelRes = New System.Windows.Forms.Label()
        Me.LabelPHImin = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumPhiStep = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NumPHImin = New System.Windows.Forms.NumericUpDown()
        Me.NumPHIMax = New System.Windows.Forms.NumericUpDown()
        Me.ComboBoxMat = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Numwa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numwb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numdc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPhiStep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPHImin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPHIMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Numwa
        '
        Me.Numwa.Location = New System.Drawing.Point(161, 99)
        Me.Numwa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Numwa.Name = "Numwa"
        Me.Numwa.Size = New System.Drawing.Size(63, 22)
        Me.Numwa.TabIndex = 2
        '
        'Numwb
        '
        Me.Numwb.Location = New System.Drawing.Point(161, 127)
        Me.Numwb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Numwb.Name = "Numwb"
        Me.Numwb.Size = New System.Drawing.Size(63, 22)
        Me.Numwb.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(101, 101)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "wa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(101, 129)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "wb"
        '
        'NumCa
        '
        Me.NumCa.DecimalPlaces = 1
        Me.NumCa.Location = New System.Drawing.Point(161, 180)
        Me.NumCa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumCa.Name = "NumCa"
        Me.NumCa.Size = New System.Drawing.Size(63, 22)
        Me.NumCa.TabIndex = 8
        '
        'NumCb
        '
        Me.NumCb.DecimalPlaces = 1
        Me.NumCb.Location = New System.Drawing.Point(161, 208)
        Me.NumCb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumCb.Name = "NumCb"
        Me.NumCb.Size = New System.Drawing.Size(63, 22)
        Me.NumCb.TabIndex = 9
        '
        'Numdc
        '
        Me.Numdc.Location = New System.Drawing.Point(161, 259)
        Me.Numdc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Numdc.Name = "Numdc"
        Me.Numdc.Size = New System.Drawing.Size(63, 22)
        Me.Numdc.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label5.Location = New System.Drawing.Point(101, 182)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 14)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Ca"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label6.Location = New System.Drawing.Point(101, 210)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 14)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cb"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label7.Location = New System.Drawing.Point(101, 261)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 14)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "dc"
        '
        'ButtonCIPM
        '
        Me.ButtonCIPM.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCIPM.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.ButtonCIPM.FlatAppearance.BorderSize = 2
        Me.ButtonCIPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCIPM.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCIPM.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonCIPM.Location = New System.Drawing.Point(104, 426)
        Me.ButtonCIPM.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonCIPM.Name = "ButtonCIPM"
        Me.ButtonCIPM.Size = New System.Drawing.Size(185, 30)
        Me.ButtonCIPM.TabIndex = 14
        Me.ButtonCIPM.Text = "CIPM"
        Me.ButtonCIPM.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.SystemColors.Control
        Me.Chart1.BorderlineColor = System.Drawing.Color.Black
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(420, 43)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(546, 269)
        Me.Chart1.TabIndex = 15
        Me.Chart1.Text = "Graph"
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.ButtonExit.FlatAppearance.BorderSize = 2
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExit.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.ForeColor = System.Drawing.Color.DarkRed
        Me.ButtonExit.Location = New System.Drawing.Point(0, 462)
        Me.ButtonExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(1000, 38)
        Me.ButtonExit.TabIndex = 16
        Me.ButtonExit.Text = "EXIT"
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'LabelRes
        '
        Me.LabelRes.AutoSize = True
        Me.LabelRes.ForeColor = System.Drawing.Color.DarkOrange
        Me.LabelRes.Location = New System.Drawing.Point(417, 434)
        Me.LabelRes.Name = "LabelRes"
        Me.LabelRes.Size = New System.Drawing.Size(119, 14)
        Me.LabelRes.TabIndex = 17
        Me.LabelRes.Text = "Error Min with    ="
        '
        'LabelPHImin
        '
        Me.LabelPHImin.AutoSize = True
        Me.LabelPHImin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPHImin.ForeColor = System.Drawing.Color.Orange
        Me.LabelPHImin.Location = New System.Drawing.Point(542, 434)
        Me.LabelPHImin.Name = "LabelPHImin"
        Me.LabelPHImin.Size = New System.Drawing.Size(0, 14)
        Me.LabelPHImin.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(635, 315)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "F"
        '
        'NumPhiStep
        '
        Me.NumPhiStep.Location = New System.Drawing.Point(681, 324)
        Me.NumPhiStep.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumPhiStep.Name = "NumPhiStep"
        Me.NumPhiStep.Size = New System.Drawing.Size(63, 22)
        Me.NumPhiStep.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label9.Location = New System.Drawing.Point(507, 433)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "F"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(613, 332)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 14)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Accuracy"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(21, 462)
        Me.Panel1.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Orange
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.Green
        Me.Panel2.Location = New System.Drawing.Point(21, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(979, 37)
        Me.Panel2.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(433, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 14)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Min"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(433, 315)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 17)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "F"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(850, 332)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 14)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Max"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(843, 315)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 17)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "F"
        '
        'NumPHImin
        '
        Me.NumPHImin.DecimalPlaces = 1
        Me.NumPHImin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumPHImin.Location = New System.Drawing.Point(479, 324)
        Me.NumPHImin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumPHImin.Name = "NumPHImin"
        Me.NumPHImin.Size = New System.Drawing.Size(63, 22)
        Me.NumPHImin.TabIndex = 29
        '
        'NumPHIMax
        '
        Me.NumPHIMax.DecimalPlaces = 1
        Me.NumPHIMax.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumPHIMax.Location = New System.Drawing.Point(889, 324)
        Me.NumPHIMax.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumPHIMax.Name = "NumPHIMax"
        Me.NumPHIMax.Size = New System.Drawing.Size(63, 22)
        Me.NumPHIMax.TabIndex = 30
        '
        'ComboBoxMat
        '
        Me.ComboBoxMat.FormattingEnabled = True
        Me.ComboBoxMat.Location = New System.Drawing.Point(161, 59)
        Me.ComboBoxMat.Name = "ComboBoxMat"
        Me.ComboBoxMat.Size = New System.Drawing.Size(121, 22)
        Me.ComboBoxMat.TabIndex = 50
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(77, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 14)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Material :"
        '
        'ButtonSave
        '
        Me.ButtonSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.ButtonSave.FlatAppearance.BorderSize = 2
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonSave.Location = New System.Drawing.Point(767, 426)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(185, 30)
        Me.ButtonSave.TabIndex = 51
        Me.ButtonSave.Text = "Save   "
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(874, 433)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 17)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "F"
        '
        'FrmCIPM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ComboBoxMat)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.NumPHIMax)
        Me.Controls.Add(Me.NumPHImin)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NumPhiStep)
        Me.Controls.Add(Me.LabelPHImin)
        Me.Controls.Add(Me.LabelRes)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.ButtonCIPM)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Numdc)
        Me.Controls.Add(Me.NumCb)
        Me.Controls.Add(Me.NumCa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Numwb)
        Me.Controls.Add(Me.Numwa)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmCIPM"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CIPM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Numwa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Numwb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Numdc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumPhiStep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumPHImin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumPHIMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Numwa As NumericUpDown
    Friend WithEvents Numwb As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumCa As NumericUpDown
    Friend WithEvents NumCb As NumericUpDown
    Friend WithEvents Numdc As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonCIPM As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents ButtonExit As Button
    Friend WithEvents LabelRes As Label
    Friend WithEvents LabelPHImin As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NumPhiStep As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents NumPHImin As NumericUpDown
    Friend WithEvents NumPHIMax As NumericUpDown
    Friend WithEvents ComboBoxMat As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents Label1 As Label
End Class
