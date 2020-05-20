Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Xml

Public Class FrmDataBase

    Dim Connexion As SqlConnection
    Dim DAdapter As SqlDataAdapter
    Dim Command As SqlCommand

    Dim Mat As MaterialsData

    Dim MatName As String
    Dim MatNameOld As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Connexion.Close()
        DAdapter.Dispose()
        Command.Dispose()
        Mat.Dispose()
        Close()
    End Sub

    Private Sub FrmDataBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Mat = New MaterialsData
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

        Dim Request = "SELECT * FROM MaterialsList"
        Command = New SqlCommand
        Command.Connection = Connexion
        Command.CommandText = Request
        Command.ExecuteNonQuery()


        DAdapter = New SqlDataAdapter(Command)
        DAdapter.Fill(Mat, "MaterialsList")

        ComboBoxMat.DataSource = Mat.Tables("MaterialsList")
        ComboBoxMat.DisplayMember = "Name"
        ComboBoxMat.ValueMember = "Id"

        Dim oData As DataRowView = ComboBoxMat.SelectedItem
        MatName = oData.Row("Name").ToString()

        DiplayData()

    End Sub

    Public Sub DiplayData()

        Try

            Dim Request = "SELECT * FROM " + MatName
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            DAdapter = New SqlDataAdapter(Command)
            DAdapter.Fill(Mat, MatName)

            DataGridView.DataSource = Mat.Tables(MatName)
            DataGridView.Columns("Id").Visible = False
            DataGridView.AutoSize = False

            DataGridView2.DataSource = Mat.Tables("MaterialsList")
            DataGridView2.Columns("Id").Visible = False
            DataGridView2.Columns("Name").Visible = False
            DataGridView2.AutoSize = False

            MatNameOld = MatName

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ButtonNewMat_Click(sender As Object, e As EventArgs) Handles ButtonNewMat.Click

        Dim NewMat(3) As String
        Inputboxes(NewMat)

        If Connexion.State = ConnectionState.Open Then
            Connexion.Close()
        End If
        Try
            Connexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try

            Dim Request = "INSERT INTO MaterialsList (Name, Manufacturer, Cost, Density) VALUES ('" + NewMat(0) + "', '" + NewMat(1) + "', " + NewMat(2) + ", " + NewMat(3) + ")"
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            Request = "SELECT * FROM MaterialsList"
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            Dim DAdapter = New SqlDataAdapter(Command)
            DAdapter.Fill(Mat, "MaterialsList")

            Request = "CREATE TABLE [dbo].[" + NewMat(0) + "] ([Id] INT IDENTITY (1, 1) NOT NULL, [r] FLOAT (53) NOT NULL, [alpha] FLOAT (53) NOT NULL, [d] FLOAT (53) NOT NULL, PRIMARY KEY CLUSTERED ([Id] ASC))"
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            Mat.Tables.Add(NewMat(0))

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Inputboxes(ByRef NewMat() As String)

        Dim Question(3) As String
        Dim i As Integer

        Question(0) = "Name of the material ?"
        Question(1) = "Manufacturer ?"
        Question(2) = "Cost [CAD/Tons] ?"
        Question(3) = "Density [kg/m3] ?"

        For i = 0 To 3
            NewMat(i) = InputBox(Question(i), "NEW MATERIAL" & i, "")
        Next

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
                DataGridView2.EndEdit()

                Dim Request = "SELECT * FROM " + MatName
                Command.CommandText = Request
                Command.ExecuteNonQuery()

                Dim DAdapter As New SqlDataAdapter(Command)
                Dim CmdBuilder As New SqlCommandBuilder(DAdapter)

                DAdapter.Update(Mat, MatName)

                Request = "SELECT * FROM MaterialsList"
                Command.CommandText = Request
                Command.ExecuteNonQuery()

                DAdapter = New SqlDataAdapter(Command)
                CmdBuilder = New SqlCommandBuilder(DAdapter)

                DAdapter.Update(Mat, "MaterialsList")


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
        Dim oData As DataRowView = ComboBoxMat.SelectedItem
        MatName = oData.Row("Name").ToString()

        If MatName <> MatNameOld Then DiplayData()

    End Sub

    Private Sub KeyPaste(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView.KeyDown
        If e.KeyCode = Keys.V And Keys.ControlKey Then
            Paste()
        End If
    End Sub

    Private Sub Paste()

        Dim tArr() As String
        Dim arT() As String
        Dim c, cc, r As Integer

        tArr = Clipboard.GetText().Split(Environment.NewLine)

        r = DataGridView.SelectedCells(0).RowIndex
        c = DataGridView.SelectedCells(0).ColumnIndex

        For i As Integer = 0 To tArr.Length - 1
            arT = tArr(i).Split(vbTab)
            cc = c
            For ii As Integer = 0 To arT.Length - 1
                If cc > DataGridView.ColumnCount - 1 Then Exit For
                If r > DataGridView.Rows.Count - 1 Then
                    Dim Row As DataGridViewRow = DataGridView.Rows(0).Clone()
                    DataGridView.Rows.Add(Row)
                End If

                With DataGridView.Item(cc, r)
                    .Value = arT(ii).TrimStart
                End With
                cc = cc + 1
            Next
            r = r + 1
        Next

    End Sub

End Class