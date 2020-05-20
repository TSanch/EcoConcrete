<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDataBase
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
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonNewMat = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.ComboBoxMat = New System.Windows.Forms.ComboBox()
        Me.LabelInfos = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ButtonExit.Location = New System.Drawing.Point(0, 476)
        Me.ButtonExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(1008, 38)
        Me.ButtonExit.TabIndex = 16
        Me.ButtonExit.Text = "EXIT"
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(21, 476)
        Me.Panel1.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Orange
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.Green
        Me.Panel2.Location = New System.Drawing.Point(21, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(987, 37)
        Me.Panel2.TabIndex = 24
        '
        'ButtonSave
        '
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonSave.Location = New System.Drawing.Point(839, 416)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(107, 40)
        Me.ButtonSave.TabIndex = 27
        Me.ButtonSave.Text = "Save Data"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(337, 53)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 36
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonNewMat
        '
        Me.ButtonNewMat.Location = New System.Drawing.Point(256, 53)
        Me.ButtonNewMat.Name = "ButtonNewMat"
        Me.ButtonNewMat.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNewMat.TabIndex = 37
        Me.ButtonNewMat.Text = "New..."
        Me.ButtonNewMat.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 14)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Material :"
        '
        'DataGridView
        '
        Me.DataGridView.AllowDrop = True
        Me.DataGridView.BackgroundColor = System.Drawing.Color.OldLace
        Me.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(38, 118)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(795, 338)
        Me.DataGridView.TabIndex = 47
        '
        'ComboBoxMat
        '
        Me.ComboBoxMat.FormattingEnabled = True
        Me.ComboBoxMat.Location = New System.Drawing.Point(119, 54)
        Me.ComboBoxMat.Name = "ComboBoxMat"
        Me.ComboBoxMat.Size = New System.Drawing.Size(121, 22)
        Me.ComboBoxMat.TabIndex = 48
        '
        'LabelInfos
        '
        Me.LabelInfos.AutoSize = True
        Me.LabelInfos.Location = New System.Drawing.Point(431, 57)
        Me.LabelInfos.Name = "LabelInfos"
        Me.LabelInfos.Size = New System.Drawing.Size(0, 14)
        Me.LabelInfos.TabIndex = 49
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.OldLace
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView2.Location = New System.Drawing.Point(487, 43)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(459, 89)
        Me.DataGridView2.TabIndex = 50
        '
        'FrmDataBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.OldLace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1008, 514)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.LabelInfos)
        Me.Controls.Add(Me.ComboBoxMat)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonNewMat)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonExit)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmDataBase"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DataBase"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonExit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonNewMat As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents ComboBoxMat As ComboBox
    Friend WithEvents LabelInfos As Label
    Friend WithEvents DataGridView2 As DataGridView
End Class
