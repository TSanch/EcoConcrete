<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.LabelPHImin = New System.Windows.Forms.Label()
        Me.ComboBoxLogin = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPwd = New System.Windows.Forms.TextBox()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonConnect
        '
        Me.ButtonConnect.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.ButtonConnect.FlatAppearance.BorderSize = 2
        Me.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnect.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonConnect.Location = New System.Drawing.Point(33, 113)
        Me.ButtonConnect.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(198, 30)
        Me.ButtonConnect.TabIndex = 14
        Me.ButtonConnect.Text = "CONNECT"
        Me.ButtonConnect.UseVisualStyleBackColor = True
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
        'ComboBoxLogin
        '
        Me.ComboBoxLogin.FormattingEnabled = True
        Me.ComboBoxLogin.Location = New System.Drawing.Point(110, 33)
        Me.ComboBoxLogin.Name = "ComboBoxLogin"
        Me.ComboBoxLogin.Size = New System.Drawing.Size(121, 22)
        Me.ComboBoxLogin.TabIndex = 50
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(58, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 14)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Login:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 14)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Password:"
        '
        'TextBoxPwd
        '
        Me.TextBoxPwd.Location = New System.Drawing.Point(110, 66)
        Me.TextBoxPwd.Name = "TextBoxPwd"
        Me.TextBoxPwd.Size = New System.Drawing.Size(121, 22)
        Me.TextBoxPwd.TabIndex = 54
        '
        'ButtonExit
        '
        Me.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonExit.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonExit.FlatAppearance.BorderSize = 2
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.ForeColor = System.Drawing.Color.Red
        Me.ButtonExit.Location = New System.Drawing.Point(3, 3)
        Me.ButtonExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(22, 27)
        Me.ButtonExit.TabIndex = 55
        Me.ButtonExit.Text = "X"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(253, 167)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.TextBoxPwd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxLogin)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LabelPHImin)
        Me.Controls.Add(Me.ButtonConnect)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmLogin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents LabelPHImin As Label
    Friend WithEvents ComboBoxLogin As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPwd As TextBox
    Friend WithEvents ButtonExit As Button
End Class
