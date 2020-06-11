<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMix
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            Command.Dispose()
            Connexion.Dispose()
            DAdapter.Dispose()
            Mat.Dispose()
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
        Me.ButtonChoiceMat = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.LabelRes = New System.Windows.Forms.Label()
        Me.LabelPHImin = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.MaterialsListTableAdapter1 = New EcoConcrete.MaterialsDataSetTableAdapters.MaterialsListTableAdapter()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.ButtonMixOpt = New System.Windows.Forms.Button()
        Me.ButtonAddMix = New System.Windows.Forms.Button()
        Me.NumPHIMax = New System.Windows.Forms.NumericUpDown()
        Me.NumPHImin = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumPhiStep = New System.Windows.Forms.NumericUpDown()
        CType(Me.Numwa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numwb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numdc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPHIMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPHImin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPhiStep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Numwa
        '
        Me.Numwa.Location = New System.Drawing.Point(889, 59)
        Me.Numwa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Numwa.Name = "Numwa"
        Me.Numwa.Size = New System.Drawing.Size(63, 22)
        Me.Numwa.TabIndex = 2
        '
        'Numwb
        '
        Me.Numwb.Location = New System.Drawing.Point(889, 87)
        Me.Numwb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Numwb.Name = "Numwb"
        Me.Numwb.Size = New System.Drawing.Size(63, 22)
        Me.Numwb.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(829, 61)
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
        Me.Label4.Location = New System.Drawing.Point(829, 89)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "wb"
        '
        'NumCa
        '
        Me.NumCa.DecimalPlaces = 1
        Me.NumCa.Location = New System.Drawing.Point(889, 118)
        Me.NumCa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumCa.Name = "NumCa"
        Me.NumCa.Size = New System.Drawing.Size(63, 22)
        Me.NumCa.TabIndex = 8
        '
        'NumCb
        '
        Me.NumCb.DecimalPlaces = 1
        Me.NumCb.Location = New System.Drawing.Point(889, 146)
        Me.NumCb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumCb.Name = "NumCb"
        Me.NumCb.Size = New System.Drawing.Size(63, 22)
        Me.NumCb.TabIndex = 9
        '
        'Numdc
        '
        Me.Numdc.Location = New System.Drawing.Point(889, 174)
        Me.Numdc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Numdc.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.Numdc.Name = "Numdc"
        Me.Numdc.Size = New System.Drawing.Size(63, 22)
        Me.Numdc.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label5.Location = New System.Drawing.Point(829, 120)
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
        Me.Label6.Location = New System.Drawing.Point(829, 148)
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
        Me.Label7.Location = New System.Drawing.Point(829, 176)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 14)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "dc"
        '
        'ButtonChoiceMat
        '
        Me.ButtonChoiceMat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonChoiceMat.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.ButtonChoiceMat.FlatAppearance.BorderSize = 2
        Me.ButtonChoiceMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonChoiceMat.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonChoiceMat.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonChoiceMat.Location = New System.Drawing.Point(47, 252)
        Me.ButtonChoiceMat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonChoiceMat.Name = "ButtonChoiceMat"
        Me.ButtonChoiceMat.Size = New System.Drawing.Size(161, 30)
        Me.ButtonChoiceMat.TabIndex = 14
        Me.ButtonChoiceMat.Text = "Materials selected"
        Me.ButtonChoiceMat.UseVisualStyleBackColor = True
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
        Me.LabelRes.Location = New System.Drawing.Point(360, 268)
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
        Me.LabelPHImin.Location = New System.Drawing.Point(485, 268)
        Me.LabelPHImin.Name = "LabelPHImin"
        Me.LabelPHImin.Size = New System.Drawing.Size(0, 14)
        Me.LabelPHImin.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label9.Location = New System.Drawing.Point(450, 267)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "F"
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(44, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 14)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Material :"
        '
        'CheckedListBox
        '
        Me.CheckedListBox.BackColor = System.Drawing.Color.OldLace
        Me.CheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox.FormattingEnabled = True
        Me.CheckedListBox.Location = New System.Drawing.Point(47, 76)
        Me.CheckedListBox.Name = "CheckedListBox"
        Me.CheckedListBox.Size = New System.Drawing.Size(161, 170)
        Me.CheckedListBox.TabIndex = 53
        '
        'MaterialsListTableAdapter1
        '
        Me.MaterialsListTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToResizeRows = False
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView.BackgroundColor = System.Drawing.Color.OldLace
        Me.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView.Location = New System.Drawing.Point(286, 87)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(483, 170)
        Me.DataGridView.TabIndex = 54
        '
        'ButtonMixOpt
        '
        Me.ButtonMixOpt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonMixOpt.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.ButtonMixOpt.FlatAppearance.BorderSize = 2
        Me.ButtonMixOpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMixOpt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMixOpt.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonMixOpt.Location = New System.Drawing.Point(824, 315)
        Me.ButtonMixOpt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonMixOpt.Name = "ButtonMixOpt"
        Me.ButtonMixOpt.Size = New System.Drawing.Size(161, 30)
        Me.ButtonMixOpt.TabIndex = 55
        Me.ButtonMixOpt.Text = "Calculate Mix"
        Me.ButtonMixOpt.UseVisualStyleBackColor = True
        '
        'ButtonAddMix
        '
        Me.ButtonAddMix.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonAddMix.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.ButtonAddMix.FlatAppearance.BorderSize = 2
        Me.ButtonAddMix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddMix.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddMix.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonAddMix.Location = New System.Drawing.Point(452, 51)
        Me.ButtonAddMix.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonAddMix.Name = "ButtonAddMix"
        Me.ButtonAddMix.Size = New System.Drawing.Size(161, 30)
        Me.ButtonAddMix.TabIndex = 56
        Me.ButtonAddMix.Text = "Add Mix"
        Me.ButtonAddMix.UseVisualStyleBackColor = True
        '
        'NumPHIMax
        '
        Me.NumPHIMax.DecimalPlaces = 1
        Me.NumPHIMax.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumPHIMax.Location = New System.Drawing.Point(889, 240)
        Me.NumPHIMax.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumPHIMax.Name = "NumPHIMax"
        Me.NumPHIMax.Size = New System.Drawing.Size(63, 22)
        Me.NumPHIMax.TabIndex = 65
        '
        'NumPHImin
        '
        Me.NumPHImin.DecimalPlaces = 1
        Me.NumPHImin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumPHImin.Location = New System.Drawing.Point(889, 212)
        Me.NumPHImin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumPHImin.Name = "NumPHImin"
        Me.NumPHImin.Size = New System.Drawing.Size(63, 22)
        Me.NumPHImin.TabIndex = 64
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(843, 248)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 14)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Max"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(829, 240)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 17)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "F"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(843, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 14)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Min"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(829, 213)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 17)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "F"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(821, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 14)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Accuracy"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(829, 267)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 17)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "F"
        '
        'NumPhiStep
        '
        Me.NumPhiStep.Location = New System.Drawing.Point(889, 266)
        Me.NumPhiStep.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumPhiStep.Name = "NumPhiStep"
        Me.NumPhiStep.Size = New System.Drawing.Size(63, 22)
        Me.NumPhiStep.TabIndex = 57
        '
        'FrmMix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.NumPHIMax)
        Me.Controls.Add(Me.NumPHImin)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NumPhiStep)
        Me.Controls.Add(Me.ButtonAddMix)
        Me.Controls.Add(Me.ButtonMixOpt)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.CheckedListBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LabelPHImin)
        Me.Controls.Add(Me.LabelRes)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonChoiceMat)
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
        Me.Name = "FrmMix"
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
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumPHIMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumPHImin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumPhiStep, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ButtonChoiceMat As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents LabelRes As Label
    Friend WithEvents LabelPHImin As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents CheckedListBox As CheckedListBox
    Friend WithEvents MaterialsListTableAdapter1 As MaterialsDataSetTableAdapters.MaterialsListTableAdapter
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents ButtonMixOpt As Button
    Friend WithEvents ButtonAddMix As Button
    Friend WithEvents NumPHIMax As NumericUpDown
    Friend WithEvents NumPHImin As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NumPhiStep As NumericUpDown
End Class
