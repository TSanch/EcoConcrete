Imports Microsoft.VisualBasic.Devices
Imports System.Data.SqlClient
Imports System.Linq.Expressions
Imports System.Runtime.Remoting.Services

Public Class FrmMain

    Private frmC As FrmCIPM
    Private frmD As FrmDataBase
    Private frmM As FrmMix

    Public Connexion As SqlConnection


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

        Do
            Dim login As String = InputBox("Login :", "Connexion to database...")

            If login = "DABOU" Then

                Dim Password As String = InputBox("Password :", "Connexion to database...")

                If Password = "dabou" Then
                    Connexion = New SqlConnection
                    Connexion.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\GCI-DACON-01\Ecoconcrete\Database\Materials.mdf;Integrated Security=True;Connect Timeout=30"

                    If Connexion.State = ConnectionState.Open Then
                        Connexion.Close()
                    End If
                    Try
                        Connexion.Open()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                    GoTo B

                Else
                    MessageBox.Show("Wrong Password")

                End If

            Else

                MessageBox.Show("Wrong Login")

            End If

        Loop
B:
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Connexion.Close()
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
