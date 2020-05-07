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
        Me.components = New System.ComponentModel.Container()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.PropertiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PropertiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ButtonSave.Location = New System.Drawing.Point(881, 416)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(107, 40)
        Me.ButtonSave.TabIndex = 27
        Me.ButtonSave.Text = "Save Data"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'FrmDataBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = Global.EcoConcrete.My.MySettings.Default.Autosize
        Me.BackColor = Global.EcoConcrete.My.MySettings.Default.BackColor
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1008, 514)
        Me.ControlBox = False
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
        Me.Text = "CIPM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PropertiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonExit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PropertiesBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ButtonSave As Button
End Class
