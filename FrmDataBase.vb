Imports System.Data.SqlClient

Public Class FrmDataBase

    Dim Connexion As New SqlConnection
    Dim Mat As New MaterialsData
    Dim Command As New SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Connexion.Close()
        Close()
    End Sub

    Private Sub FrmDataBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connexion.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\EcoConcrete\Materials.mdf;Integrated Security=True"
        If Connexion.State = ConnectionState.Open Then
            Connexion.Close()
        End If
        Try
            Connexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim Request = "SELECT * FROM MaterialsList"
        Command.Connection = Connexion
        Command.CommandText = Request
        Command.ExecuteNonQuery()


        Dim DAdapter = New SqlDataAdapter(Command)
        DAdapter.Fill(Mat, "MaterialsList")

        ComboBoxMat.DataSource = Mat.Tables("MaterialsList")
        ComboBoxMat.DisplayMember = "Name"
        ComboBoxMat.ValueMember = "Id"

        DiplayData()

    End Sub

    Public Sub DiplayData()

        Try
            Dim oData As DataRowView = ComboBoxMat.SelectedItem
            Dim MatName As String = oData.Row("Name").ToString()

            Dim Request = "SELECT * FROM " + MatName
            Dim Command = New SqlCommand(Request, Connexion)

            Dim DAdapter = New SqlDataAdapter(Command)
            DAdapter.Fill(Mat, MatName)

            DataGridView.DataSource = Mat.Tables(MatName)
            DataGridView.Columns("Id").Visible = False
            DataGridView.AutoSize = True

            DAdapter.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ButtonNewMat_Click(sender As Object, e As EventArgs) Handles ButtonNewMat.Click

        Dim NewMat As String = InputBox("New Material", "Name of the new material", "Cement")

        If Connexion.State = ConnectionState.Open Then
            Connexion.Close()
        End If
        Try
            Connexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            Dim Request = "CREATE TABLE [dbo].[" + NewMat + "] ([Id] INT IDENTITY (1, 1) NOT NULL, [p] FLOAT (53) NOT NULL, [r] FLOAT (53) NOT NULL, [alpha] FLOAT (53) NOT NULL, [d] FLOAT (53) NOT NULL, PRIMARY KEY CLUSTERED ([Id] ASC))"
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            'Request = "SELECT * FROM " + NewMat
            'Command.CommandText = Request
            'Command.ExecuteNonQuery()
            'Dim DAdapter As New SqlDataAdapter(Command)

            Mat.Tables.Add(NewMat)
            'DAdapter.Fill(Mat, NewMat)

            Request = "INSERT INTO MaterialsList VALUES ('" + NewMat + "')"
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            Request = "SELECT * FROM MaterialsList"
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            Dim DAdapter = New SqlDataAdapter(Command)
            DAdapter.Fill(Mat, "MaterialsList")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        Dim oData As DataRowView = ComboBoxMat.SelectedItem
        Dim MatName As String = oData.Row("Name").ToString()

        If Connexion.State = ConnectionState.Open Then
            Connexion.Close()
        End If
        Try
            Connexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Select Case MsgBox("Are you sure to save the material: " + MatName, MsgBoxStyle.YesNo, MatName)
            Case MsgBoxResult.Yes

                DataGridView.EndEdit()

                Dim Request = "SELECT * FROM " + MatName
                Command.CommandText = Request
                Command.ExecuteNonQuery()

                Dim DAdapter As New SqlDataAdapter(Command)
                Dim CmdBuilder As New SqlCommandBuilder(DAdapter)

                DAdapter.Update(Mat, MatName)

            Case MsgBoxResult.No

        End Select



    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        Dim oData As DataRowView = ComboBoxMat.SelectedItem
        Dim MatName As String = oData.Row("Name").ToString()

        If Connexion.State = ConnectionState.Open Then
            Connexion.Close()
        End If
        Try
            Connexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Select Case MsgBox("Are you sure to delete the material: " + MatName, MsgBoxStyle.YesNo, MatName)
            Case MsgBoxResult.Yes
                Dim Request = "DROP TABLE " + MatName
                Command.CommandText = Request
                Command.ExecuteNonQuery()

                Mat.Tables.Remove(MatName)

                Request = "DELETE FROM MaterialsList WHERE Name = '" + MatName + "'"
                Command.CommandText = Request
                Command.ExecuteNonQuery()

                Request = "SELECT * FROM MaterialsList"
                Command.CommandText = Request
                Command.ExecuteNonQuery()

                Dim DAdapter As New SqlDataAdapter(Command)
                DAdapter.Fill(Mat, "MaterialsList")

            Case MsgBoxResult.No

        End Select

    End Sub

    Private Sub ComboBoxMat_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxMat.SelectionChangeCommitted

        DiplayData()

    End Sub
End Class