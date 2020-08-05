Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Xml

Public Class FrmDataBase

    Dim Mat As New MaterialsData
    Dim n As Integer = 65
    Dim MatName As String
    Dim MatNameOld As String = ""

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click

        Mat.Dispose()
        Close()

    End Sub

    Private Sub FrmDataBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FrmMain.DBCon.VerifyConnexion()
        FrmMain.DBCon.DBRequest("SELECT * FROM MaterialsList")
        FrmMain.DBCon.MatFill(Mat, "MaterialsList")

        ComboBoxMat.DataSource = Mat.Tables("MaterialsList")
        ComboBoxMat.DisplayMember = "Name"
        ComboBoxMat.ValueMember = "Id"

        Dim oData As DataRowView = ComboBoxMat.SelectedItem
        MatName = oData.Row("Name").ToString()

    End Sub

    Public Sub DiplayData(ByRef MatName As String)

        Try

            FrmMain.DBCon.DBRequest("SELECT * FROM [" + MatName + "]")
            If Mat.Tables.Contains(MatName) Then Mat.Tables(MatName).Clear()
            FrmMain.DBCon.MatFill(Mat, MatName)

            DataGridView.DataSource = Mat.Tables(MatName)
            DataGridView.Columns("Id").Visible = False
            DataGridView.AutoResizeColumns()

            DataGridView2.DataSource = Mat.Tables("MaterialsList")
            DataGridView2.Columns("Id").Visible = False
            DataGridView2.AutoResizeColumns()

            MatNameOld = MatName

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ButtonNewMat_Click(sender As Object, e As EventArgs) Handles ButtonNewMat.Click

        If FrmMain.DBCon.user = "DABOU" Then

            Dim NewMat(4) As String
            Inputboxes(NewMat)

            FrmMain.DBCon.VerifyConnexion()

            Try

                FrmMain.DBCon.DBRequest("INSERT INTO MaterialsList (Name, Manufacturer, Cost, Density) VALUES ('" + NewMat(0) + "', '" + NewMat(1) + "', " + NewMat(2) + ", " + NewMat(3) + ")")
                FrmMain.DBCon.DBRequest("SELECT * FROM MaterialsList")
                FrmMain.DBCon.MatFill(Mat, "MaterialsList")

                FrmMain.DBCon.DBRequest("CREATE TABLE [dbo].[" + NewMat(0) + "] ([Id] INT IDENTITY (1, 1) NOT NULL, [r] FLOAT (53) NULL, [alpha] FLOAT (53) NOT NULL, [d] FLOAT (53) NOT NULL, PRIMARY KEY CLUSTERED ([Id] ASC))")

                For i As Integer = 0 To NewMat(4)
                    FrmMain.DBCon.DBRequest("INSERT INTO [" + NewMat(0) + "] ([r], [alpha], [d]) VALUES (0, 0, 0)")
                Next

                Mat.Tables.Add(NewMat(0))

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else

            MessageBox.Show("Error: Admin access required.")

        End If

    End Sub

    Private Sub Inputboxes(ByRef NewMat() As String)

        Dim Question(4) As String
        Dim i As Integer

        Question(0) = "Name of the material ?"
        Question(1) = "Manufacturer ?"
        Question(2) = "Cost [CAD/Tons] ?"
        Question(3) = "Density [kg/m3] ?"
        Question(4) = "Class number ? Default = 65"

        For i = 0 To 4
            NewMat(i) = InputBox(Question(i), "NEW MATERIAL" & i, "")
        Next

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        If FrmMain.DBCon.user = "DABOU" Then

            Dim oData As DataRowView = ComboBoxMat.SelectedItem
            Dim MatName As String = oData.Row("Name").ToString()

            FrmMain.DBCon.VerifyConnexion()

            Select Case MsgBox("Are you sure to save the material: " + MatName, MsgBoxStyle.YesNo, MatName)
                Case MsgBoxResult.Yes

                    FrmMain.DBCon.DBRequest("SELECT * FROM [" + MatName + "]")
                    FrmMain.DBCon.DBUpdate(Mat, MatName)

                    FrmMain.DBCon.DBRequest("SELECT * FROM MaterialsList")
                    FrmMain.DBCon.DBUpdate(Mat, "MaterialsList")

                    Select Case MsgBox("If some d value are null in " + MatName + ", do you want to delete them ?", MsgBoxStyle.YesNo, MatName)

                        Case MsgBoxResult.Yes

                            FrmMain.DBCon.DBRequest("DELETE FROM [" + MatName + "] WHERE d IS NULL OR d = 0")
                            FrmMain.DBCon.DBUpdate(Mat, MatName)

                            RefreshForm()

                        Case MsgBoxResult.No

                            GoTo B

                    End Select

                Case MsgBoxResult.No

                    GoTo B

            End Select

        Else

            MessageBox.Show("Error: Admin access required.")

        End If
B:
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        If FrmMain.DBCon.user = "DABOU" Then

            Dim oData As DataRowView = ComboBoxMat.SelectedItem
            Dim MatName As String = oData.Row("Name").ToString()

            FrmMain.DBCon.VerifyConnexion()

            Select Case MsgBox("Are you sure to delete the material: " + MatName, MsgBoxStyle.YesNo, MatName)
                Case MsgBoxResult.Yes

                    FrmMain.DBCon.DBRequest("DROP TABLE [" + MatName + "]")
                    Mat.Tables.Remove(MatName)
                    FrmMain.DBCon.DBRequest("DELETE FROM MaterialsList WHERE Name = '" + MatName + "'")

                    FrmMain.DBCon.DBRequest("SELECT * FROM MaterialsList")
                    FrmMain.DBCon.MatFill(Mat, "MaterialsList")

                    RefreshForm()

                Case MsgBoxResult.No

                    GoTo B

            End Select

        Else

            MessageBox.Show("Error: Admin access required.")

        End If
B:
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

        For i As Integer = 0 To tArr.Length - 2
            arT = tArr(i).Split(vbTab)
            cc = c
            For ii As Integer = 0 To arT.Length - 1
                If cc > DataGridView.ColumnCount - 1 Then Exit For
                If r > DataGridView.Rows.Count - 1 Then
                    Dim Row As DataGridViewRow = DataGridView.Rows(0).Clone()
                    DataGridView.Rows.Add(Row)
                End If

                DataGridView.Item(cc, r).Value = CDbl(arT(ii))

                cc += 1
            Next
            r += 1
        Next

    End Sub

    Private Sub ComboBoxMat_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxMat.SelectedValueChanged

        Dim oData As DataRowView = ComboBoxMat.SelectedItem
        MatName = oData.Row("Name").ToString()

        If MatName <> MatNameOld Then DiplayData(MatName)

    End Sub

    Private Sub RefreshForm()

        Dim Frm As New FrmDataBase
        Frm.MdiParent = FrmMain
        Frm.Show()
        Me.Close()

    End Sub

End Class