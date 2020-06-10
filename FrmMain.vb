Imports Microsoft.VisualBasic.Devices
Imports System.Data.SqlClient
Public Class FrmMain

    Private frmC As FrmCIPM
    Private frmD As FrmDataBase
    Private frmM As FrmMix
    Private mov As Boolean = False
    Private movx As Integer = 0
    Private movy As Integer = 0

    Private Sub CIPMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CIPMToolStripMenuItem.Click
        frmC = New FrmCIPM
        frmC.MdiParent = Me
        frmC.Show()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Application.ChangeCulture("en_CA")
        Me.IsMdiContainer = True
        Me.WindowState = FormWindowState.Normal
        Me.Location = Screen.AllScreens(1).WorkingArea.Location
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        frmD = New FrmDataBase
        frmD.MdiParent = Me
        frmD.Show()
    End Sub

    Private Sub MIXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MIXToolStripMenuItem.Click
        frmM = New FrmMix
        frmM.MdiParent = Me
        frmM.Show()
    End Sub
End Class
