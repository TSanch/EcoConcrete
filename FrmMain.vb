Imports Microsoft.VisualBasic.Devices
Imports Microsoft.VisualBasic.Logging
Imports System.Data.SqlClient
Imports System.Linq.Expressions
Imports System.Runtime.Remoting.Services
Imports System.Linq



Public Class FrmMain

    Private frmC As FrmCIPM
    Private frmD As FrmDataBase
    Private frmM As FrmMix

    Public DBCon As New DBconnexion

    Private Sub CIPMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CIPMToolStripMenuItem.Click

        frmC = New FrmCIPM
        frmC.MdiParent = Me
        frmC.Show()

    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        My.Application.ChangeCulture("en-US")
        Me.IsMdiContainer = True
        Me.WindowState = FormWindowState.Normal
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        DBCon.Connexion.Close()
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
