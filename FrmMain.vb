Imports Microsoft.VisualBasic.Devices
Imports System.Data.SqlClient
Public Class FrmMain

    Private frmC As FrmCIPM
    Private frmD As FrmDataBase
    Private mov As Boolean = False
    Private movx As Integer = 0
    Private movy As Integer = 0

    Private Sub CIPMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CIPMToolStripMenuItem.Click
        frmC = New FrmCIPM
        frmC.MdiParent = Me
        frmC.Show()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Application.ChangeCulture("en_US")
        Me.IsMdiContainer = True
        Me.WindowState = FormWindowState.Normal
        Me.Location = Screen.AllScreens(1).WorkingArea.Location
        'frmC.Left = 0
        'frmC.Top = 0
        'frmC.Height = Me.Height
        'frmC.Width = Me.Width
        'frmC.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs)

        mov = True
        movx = e.X
        movy = e.Y

    End Sub

    Private Sub MenuStrip1_MouseMove(sender As Object, e As MouseEventArgs)

        If mov Then
            Me.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy)
        End If

    End Sub

    Private Sub MenuStrip1_MouseUp(sender As Object, e As MouseEventArgs)

        mov = False

    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        frmD = New FrmDataBase
        frmD.MdiParent = Me
        frmD.Show()
    End Sub
End Class
