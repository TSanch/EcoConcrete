Imports Microsoft.VisualBasic.Devices
Imports Microsoft.VisualBasic.Logging
Imports System.Data.SqlClient
Imports System.Linq.Expressions
Imports System.Runtime.Remoting.Services
Imports System.Linq
Imports System.IO

Public Class FrmMain

    Private frmC As FrmCIPM
    Private frmD As FrmDataBase
    Private frmM As FrmMix
    Private frmA As AboutBox

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

    Private Sub VersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionToolStripMenuItem.Click

        frmA = New AboutBox
        frmA.ShowDialog()

    End Sub

    Private Sub ManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualToolStripMenuItem.Click

        Dim manual As Byte() = My.Resources.Design_of_Ecological_Concrete_by_Particule_Packing_Optimization
        Using tmp As New FileStream("Design-of-Ecological-Concrete-by-Particule-Packing-Optimization.pdf", FileMode.Create)
            tmp.Write(manual, 0, manual.Length)
        End Using
        Process.Start("Design-of-Ecological-Concrete-by-Particule-Packing-Optimization.pdf")

    End Sub
End Class
