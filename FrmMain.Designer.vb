<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim MenuStrip1 As System.Windows.Forms.MenuStrip
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptmisationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CIPMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        MenuStrip1 = New System.Windows.Forms.MenuStrip()
        MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectToolStripMenuItem, Me.DatabaseToolStripMenuItem, Me.OptmisationToolStripMenuItem, Me.ToolStripMenuItem1})
        MenuStrip1.Location = New System.Drawing.Point(21, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New System.Drawing.Size(779, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        AddHandler MenuStrip1.MouseDown, AddressOf Me.MenuStrip1_MouseDown
        AddHandler MenuStrip1.MouseMove, AddressOf Me.MenuStrip1_MouseMove
        AddHandler MenuStrip1.MouseUp, AddressOf Me.MenuStrip1_MouseUp
        '
        'ProjectToolStripMenuItem
        '
        Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.ProjectToolStripMenuItem.Text = "Project"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'OptmisationToolStripMenuItem
        '
        Me.OptmisationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CIPMToolStripMenuItem})
        Me.OptmisationToolStripMenuItem.Name = "OptmisationToolStripMenuItem"
        Me.OptmisationToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.OptmisationToolStripMenuItem.Text = "Optimisation"
        '
        'CIPMToolStripMenuItem
        '
        Me.CIPMToolStripMenuItem.Name = "CIPMToolStripMenuItem"
        Me.CIPMToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.CIPMToolStripMenuItem.Text = "CIPM"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualToolStripMenuItem, Me.VersionToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(28, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ManualToolStripMenuItem.Text = "Manual"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.VersionToolStripMenuItem.Text = "Version"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(21, 420)
        Me.Panel1.TabIndex = 2
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(800, 420)
        Me.Controls.Add(MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "EcoConcrete"
        Me.TransparencyKey = System.Drawing.Color.Red
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptmisationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CIPMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class
