Imports System.IO
Imports System.Data.SqlClient

Public Class FrmDataBase

    Dim Connexion As New SqlConnection
    Dim Command As New SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Connexion.Close()
        Close()
    End Sub

    Private Sub FrmDataBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connexion.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=P:\Software\Ecoconcrete\Materials.mdf;Integrated Security=True"
        If Connexion.State = ConnectionState.Open Then
            Connexion.Close()
        End If
        Try
            Connexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Command = Connexion.CreateCommand()
        Command.CommandType = CommandType.Text
        Command.CommandText = "SELECT * FROM MaterialsList"
        Command.ExecuteNonQuery()

        Dim DAdapter As New SqlDataAdapter(Command)
        DAdapter.Fill(DataSet, "MaterialsList")

        ComboBoxMat.DataSource = DataSet.Tables(0)
        ComboBoxMat.DisplayMember = "Name"

        'DiplayData()

    End Sub

    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click

        Command = Connexion.CreateCommand()
        Command.CommandType = CommandType.Text
        Command.CommandText = "INSERT INTO " + ComboBoxMat.SelectedItem.ToString() + " VALUES (" + NumericUpDown1.Text + "," + NumericUpDown2.Text + "," _
            + NumericUpDown3.Text + "," + NumericUpDown4.Text + ")"

        Try
            Command.ExecuteNonQuery()
            MessageBox.Show("Record Inserted Successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Command.Dispose()
        'DiplayData()

    End Sub

    Public Sub DiplayData()

        Try
            Command = Connexion.CreateCommand()
            Command.CommandType = CommandType.Text
            Command.CommandText = "SELECT * FROM " + ComboBoxMat.SelectedItem.ToString()
            Command.ExecuteNonQuery()

            Dim DAdapter As New SqlDataAdapter(Command)
            DAdapter.Fill(DataSet, ComboBoxMat.SelectedItem.ToString())

            Dim View As New DataView(DataSet.Tables(ComboBoxMat.SelectedItem.ToString()))

            DataGridView1.DataSource = View

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Command.Dispose()

    End Sub

    Private Sub ButtonNewMat_Click(sender As Object, e As EventArgs) Handles ButtonNewMat.Click

        Dim NewMat As String = InputBox("New Material", "Name of the new material", "Cement")

        Try
            Command = Connexion.CreateCommand()
            Command.CommandType = CommandType.Text

            Command.CommandText = "CREATE TABLE " + NewMat + "(Id Int Not NULL IDENTITY, p FLOAT(53) Not NULL, r FLOAT(53) Not NULL, alpha FLOAT(53) Not NULL, d FLOAT(53) Not NULL, PRIMARY KEY CLUSTERED (Id ASC))"
            Command.ExecuteNonQuery()

            Dim DAdapter As New SqlDataAdapter(Command)
            DAdapter.Fill(DataSet, NewMat)

            Command.CommandText = "INSERT INTO MaterialsList VALUES ('" + NewMat + "')"
            Command.ExecuteNonQuery()

            DAdapter = New SqlDataAdapter(Command)
            DAdapter.Fill(DataSet, "MaterialsList")

            ComboBoxMat.DataSource = DataSet.Tables("MaterialsList")
            ComboBoxMat.ValueMember = "Id"
            ComboBoxMat.DisplayMember = "Name"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub ComboBoxMat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMat.SelectedIndexChanged

        DiplayData()

    End Sub
End Class