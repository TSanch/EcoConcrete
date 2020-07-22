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
            Connexion.Close()
            DAdapter.Dispose()
            Command.Dispose()
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
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
        Me.ButtonPhi = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.LabelPHImin = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumPhiStep = New System.Windows.Forms.NumericUpDown()
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
        Me.ButtonSavePhi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonAlpha = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.NumAlphaMax = New System.Windows.Forms.NumericUpDown()
        Me.NumAlphaMin = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.NumAlphaStep = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ButtonSaveAlpha = New System.Windows.Forms.Button()
        Me.Labelalphamin = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NumK = New System.Windows.Forms.NumericUpDown()
        CType(Me.Numwa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numwb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numdc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPhiStep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPHImin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPHIMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumAlphaMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumAlphaMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumAlphaStep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Numwa
        '
        Me.Numwa.Location = New System.Drawing.Point(161, 139)
        Me.Numwa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Numwa.Name = "Numwa"
        Me.Numwa.Size = New System.Drawing.Size(63, 22)
        Me.Numwa.TabIndex = 2
        '
        'Numwb
        '
        Me.Numwb.Location = New System.Drawing.Point(161, 167)
        Me.Numwb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Numwb.Name = "Numwb"
        Me.Numwb.Size = New System.Drawing.Size(63, 22)
        Me.Numwb.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(101, 141)
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
        Me.Label4.Location = New System.Drawing.Point(101, 169)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "wb"
        '
        'NumCa
        '
        Me.NumCa.DecimalPlaces = 2
        Me.NumCa.Location = New System.Drawing.Point(161, 199)
        Me.NumCa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumCa.Name = "NumCa"
        Me.NumCa.Size = New System.Drawing.Size(63, 22)
        Me.NumCa.TabIndex = 8
        '
        'NumCb
        '
        Me.NumCb.DecimalPlaces = 2
        Me.NumCb.Location = New System.Drawing.Point(161, 227)
        Me.NumCb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumCb.Name = "NumCb"
        Me.NumCb.Size = New System.Drawing.Size(63, 22)
        Me.NumCb.TabIndex = 9
        '
        'Numdc
        '
        Me.Numdc.Location = New System.Drawing.Point(161, 259)
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
        Me.Label5.Location = New System.Drawing.Point(101, 201)
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
        Me.Label6.Location = New System.Drawing.Point(101, 229)
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
        'ButtonPhi
        '
        Me.ButtonPhi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonPhi.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.ButtonPhi.FlatAppearance.BorderSize = 2
        Me.ButtonPhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPhi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPhi.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonPhi.Location = New System.Drawing.Point(104, 318)
        Me.ButtonPhi.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonPhi.Name = "ButtonPhi"
        Me.ButtonPhi.Size = New System.Drawing.Size(185, 30)
        Me.ButtonPhi.TabIndex = 14
        Me.ButtonPhi.Text = "Calculate      "
        Me.ButtonPhi.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.SystemColors.Control
        Me.Chart1.BorderlineColor = System.Drawing.Color.Black
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(289, 43)
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
        'LabelPHImin
        '
        Me.LabelPHImin.AutoSize = True
        Me.LabelPHImin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPHImin.ForeColor = System.Drawing.Color.Orange
        Me.LabelPHImin.Location = New System.Drawing.Point(790, 327)
        Me.LabelPHImin.Name = "LabelPHImin"
        Me.LabelPHImin.Size = New System.Drawing.Size(0, 14)
        Me.LabelPHImin.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(444, 315)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "F"
        '
        'NumPhiStep
        '
        Me.NumPhiStep.Location = New System.Drawing.Point(490, 324)
        Me.NumPhiStep.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumPhiStep.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumPhiStep.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NumPhiStep.Name = "NumPhiStep"
        Me.NumPhiStep.Size = New System.Drawing.Size(63, 22)
        Me.NumPhiStep.TabIndex = 19
        Me.NumPhiStep.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(422, 332)
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
        Me.Label11.Location = New System.Drawing.Point(308, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 14)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Min"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(308, 315)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 17)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "F"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(567, 332)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 14)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Max"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(560, 315)
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
        Me.NumPHImin.Location = New System.Drawing.Point(354, 324)
        Me.NumPHImin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumPHImin.Name = "NumPHImin"
        Me.NumPHImin.Size = New System.Drawing.Size(63, 22)
        Me.NumPHImin.TabIndex = 29
        '
        'NumPHIMax
        '
        Me.NumPHIMax.DecimalPlaces = 1
        Me.NumPHIMax.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumPHIMax.Location = New System.Drawing.Point(606, 324)
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
        'ButtonSavePhi
        '
        Me.ButtonSavePhi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonSavePhi.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.ButtonSavePhi.FlatAppearance.BorderSize = 2
        Me.ButtonSavePhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSavePhi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSavePhi.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonSavePhi.Location = New System.Drawing.Point(688, 318)
        Me.ButtonSavePhi.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonSavePhi.Name = "ButtonSavePhi"
        Me.ButtonSavePhi.Size = New System.Drawing.Size(65, 30)
        Me.ButtonSavePhi.TabIndex = 51
        Me.ButtonSavePhi.Text = "Save                    "
        Me.ButtonSavePhi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(761, 324)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "F ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(219, 325)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 17)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "F"
        '
        'ButtonAlpha
        '
        Me.ButtonAlpha.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonAlpha.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.ButtonAlpha.FlatAppearance.BorderSize = 2
        Me.ButtonAlpha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAlpha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAlpha.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonAlpha.Location = New System.Drawing.Point(104, 365)
        Me.ButtonAlpha.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonAlpha.Name = "ButtonAlpha"
        Me.ButtonAlpha.Size = New System.Drawing.Size(185, 30)
        Me.ButtonAlpha.TabIndex = 54
        Me.ButtonAlpha.Text = "Calculate      "
        Me.ButtonAlpha.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label16.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label16.Location = New System.Drawing.Point(219, 371)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 17)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "a"
        '
        'NumAlphaMax
        '
        Me.NumAlphaMax.DecimalPlaces = 2
        Me.NumAlphaMax.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NumAlphaMax.Location = New System.Drawing.Point(606, 371)
        Me.NumAlphaMax.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumAlphaMax.Name = "NumAlphaMax"
        Me.NumAlphaMax.Size = New System.Drawing.Size(63, 22)
        Me.NumAlphaMax.TabIndex = 64
        '
        'NumAlphaMin
        '
        Me.NumAlphaMin.DecimalPlaces = 2
        Me.NumAlphaMin.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NumAlphaMin.Location = New System.Drawing.Point(354, 371)
        Me.NumAlphaMin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumAlphaMin.Name = "NumAlphaMin"
        Me.NumAlphaMin.Size = New System.Drawing.Size(63, 22)
        Me.NumAlphaMin.TabIndex = 63
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(567, 379)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 14)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "Max"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label18.Location = New System.Drawing.Point(560, 362)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 17)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "a"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(308, 379)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 14)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Min"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label20.Location = New System.Drawing.Point(308, 362)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 17)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "a"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(422, 379)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 14)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "Accuracy"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label22.Location = New System.Drawing.Point(444, 362)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(18, 17)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "a"
        '
        'NumAlphaStep
        '
        Me.NumAlphaStep.Location = New System.Drawing.Point(490, 371)
        Me.NumAlphaStep.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumAlphaStep.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumAlphaStep.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NumAlphaStep.Name = "NumAlphaStep"
        Me.NumAlphaStep.Size = New System.Drawing.Size(63, 22)
        Me.NumAlphaStep.TabIndex = 56
        Me.NumAlphaStep.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Symbol", 10.0!)
        Me.Label23.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label23.Location = New System.Drawing.Point(761, 371)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 17)
        Me.Label23.TabIndex = 66
        Me.Label23.Text = "a ="
        '
        'ButtonSaveAlpha
        '
        Me.ButtonSaveAlpha.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonSaveAlpha.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.ButtonSaveAlpha.FlatAppearance.BorderSize = 2
        Me.ButtonSaveAlpha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveAlpha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveAlpha.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonSaveAlpha.Location = New System.Drawing.Point(688, 365)
        Me.ButtonSaveAlpha.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonSaveAlpha.Name = "ButtonSaveAlpha"
        Me.ButtonSaveAlpha.Size = New System.Drawing.Size(65, 30)
        Me.ButtonSaveAlpha.TabIndex = 65
        Me.ButtonSaveAlpha.Text = "Save                    "
        Me.ButtonSaveAlpha.UseVisualStyleBackColor = True
        '
        'Labelalphamin
        '
        Me.Labelalphamin.AutoSize = True
        Me.Labelalphamin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelalphamin.ForeColor = System.Drawing.Color.Orange
        Me.Labelalphamin.Location = New System.Drawing.Point(790, 374)
        Me.Labelalphamin.Name = "Labelalphamin"
        Me.Labelalphamin.Size = New System.Drawing.Size(0, 14)
        Me.Labelalphamin.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label9.Location = New System.Drawing.Point(101, 113)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 14)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "K"
        '
        'NumK
        '
        Me.NumK.DecimalPlaces = 1
        Me.NumK.Location = New System.Drawing.Point(161, 111)
        Me.NumK.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumK.Name = "NumK"
        Me.NumK.Size = New System.Drawing.Size(63, 22)
        Me.NumK.TabIndex = 68
        '
        'FrmCIPM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NumK)
        Me.Controls.Add(Me.Labelalphamin)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.ButtonSaveAlpha)
        Me.Controls.Add(Me.NumAlphaMax)
        Me.Controls.Add(Me.NumAlphaMin)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.NumAlphaStep)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ButtonAlpha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonSavePhi)
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
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NumPhiStep)
        Me.Controls.Add(Me.LabelPHImin)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.ButtonPhi)
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
        CType(Me.NumAlphaMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumAlphaMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumAlphaStep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumK, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ButtonPhi As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents ButtonExit As Button
    Friend WithEvents LabelPHImin As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NumPhiStep As NumericUpDown
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
    Friend WithEvents ButtonSavePhi As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonAlpha As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents NumAlphaMax As NumericUpDown
    Friend WithEvents NumAlphaMin As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents NumAlphaStep As NumericUpDown
    Friend WithEvents Label23 As Label
    Friend WithEvents ButtonSaveAlpha As Button
    Friend WithEvents Labelalphamin As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NumK As NumericUpDown
End Class
