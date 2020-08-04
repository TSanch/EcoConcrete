Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.Data.DataRow
Imports System.Xml

Public Class FrmMix

    Dim Mat As New MaterialsData

    Dim MatName(10) As String
    Dim MatNameOld As String = ""

    Private r(,) As Double
    Private alpha(,) As Double
    Private d() As Double

    Dim M As Integer
    Dim n As Integer
    Dim nbp As Integer = 0

    Dim PHIMin() As Double

    Private Sub FrmCIPM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelRes.Hide()
        Label9.Hide()

        FrmMain.DBCon.VerifyConnexion()

        FrmMain.DBCon.DBRequest("SELECT * FROM MaterialsList")
        FrmMain.DBCon.MatFill(Mat, "MaterialsList")

        For i As Integer = 0 To Mat.Tables("MaterialsList").Rows.Count - 1

            CheckedListBox.Items.Add(Mat.Tables("MaterialsList")(i)(1))

        Next

        NumK.Value = 12.2
        Numwa.Value = 1
        Numwb.Value = 1
        NumCa.Value = 1.5
        NumCb.Value = 0.2
        Numdc.Value = 125
        NumPHImin.Value = 0.2
        NumPhiStep.Value = 4
        NumPHIMax.Value = 0.8
        Numdp.Value = 6

        DataGridView.DataSource = Mat.Tables("MaterialsList")
        DataGridView.Columns("Id").Visible = False
        DataGridView.Columns("Name").Visible = True
        DataGridView.Columns("Manufacturer").Visible = True
        DataGridView.Columns("Cost").Visible = True
        DataGridView.Columns("Density").Visible = False
        DataGridView.Columns("PHI").Visible = False
        DataGridView.AutoResizeColumns()

        Mat.Tables.Add("p")
        DataGridViewPhiMin.DataSource = Mat.Tables("p")

    End Sub

    Private Sub ButtonChoiceMat_Click(sender As Object, e As EventArgs) Handles ButtonChoiceMat.Click

        ReDim MatName(CheckedListBox.CheckedItems.Count - 1)
        For i As Integer = 0 To CheckedListBox.CheckedItems.Count - 1
            MatName(i) = CheckedListBox.GetItemText(CheckedListBox.CheckedItems(i)).ToString()
        Next

        LoadData()
        DataGridView.AutoResizeColumns()

    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click

        Mat.Dispose()
        MyBase.Finalize()

    End Sub

    Private Sub LoadData()

        FrmMain.DBCon.VerifyConnexion()

        Dim listName As String = String.Join("','", MatName)
        FrmMain.DBCon.DBRequest("SELECT * FROM MaterialsList WHERE Name IN ('" + listName + "')")

        Mat.Tables("MaterialsList").Clear()
        FrmMain.DBCon.MatFill(Mat, "MaterialsList")

        DataGridView.DataSource = Mat.Tables("MaterialsList")
        DataGridView.Columns("Id").Visible = False
        DataGridView.Columns("Name").Visible = True
        DataGridView.Columns("Manufacturer").Visible = False
        DataGridView.Columns("Cost").Visible = False
        DataGridView.Columns("Density").Visible = False
        DataGridView.Columns("PHI").Visible = False
        DataGridView.Columns("K").Visible = False

        M = MatName.Length()

        For i As Integer = 0 To M - 1

            FrmMain.DBCon.DBRequest("SELECT * FROM [" + MatName(i) + "]")
            If Mat.Tables.Contains(MatName(i)) Then Mat.Tables(MatName(i)).Clear()
            FrmMain.DBCon.MatFill(Mat, MatName(i))

        Next

        n = Mat.Tables(MatName(0)).Rows.Cast(Of DataRow).Select(Function(dr) dr.ItemArray).ToArray.Length()

        ReDim d(n - 1)
        For j As Integer = 0 To n - 1
            d(j) = Mat.Tables(MatName(0)).Rows.Cast(Of DataRow).Select(Function(dr) dr.ItemArray).ToArray(j)(3)
        Next

        ReDim r(M - 1, n - 1)
        ReDim alpha(M - 1, n - 1)

        For i As Integer = 0 To M - 1

            Dim MatTable()() As Object = Mat.Tables(MatName(i)).Rows.Cast(Of DataRow).Select(Function(dr) dr.ItemArray).ToArray

            Dim n_new As Integer = MatTable.Length()
            If n_new <> n Then
                MessageBox.Show("Error: n are differents. Please verify the database!")
                GoTo B
            End If

            For j As Integer = 0 To n - 1

                r(i, j) = MatTable(j)(1) / 100
                alpha(i, j) = MatTable(j)(2)

                Dim d_new As Double = MatTable(j)(3)
                If d_new <> d(j) Then
                    MessageBox.Show("Error: d() are differents. Please verify the database!")
                    GoTo B
                End If
            Next

        Next
B:
    End Sub

    Private Sub ButtonMixOpt_Click(sender As Object, e As EventArgs) Handles ButtonMixOpt.Click

        Dim model As New CIPM(M, n, r, alpha, NumK.Value, Numdc.Value, d, Numwa.Value, Numwb.Value, NumCa.Value, NumCb.Value, 0)
        Dim MatTable()() As Object = Mat.Tables("MaterialsList").Rows.Cast(Of DataRow).Select(Function(dr) dr.ItemArray).ToArray

        ReDim PHIMin(nbp - 1)

        Mat.Tables("p").Rows.Add()

        For i As Integer = 0 To nbp - 1

            Dim p(M - 1) As Double
            For j As Integer = 0 To M - 1
                p(j) = CDbl(MatTable(j)(9 + i))
            Next


            Dim jlength As Integer = (NumPHIMax.Value - NumPHImin.Value) / (10 ^ (-NumPhiStep.Value))
            Dim vect_err(jlength) As Double
            Dim vect_phi(jlength) As Double

            Dim errfound As Boolean = False
            Dim err As Double
            Dim errmin As Double = 100
            Dim k As Integer = 0

            For PHI As Double = NumPHImin.Value To NumPHIMax.Value Step 10 ^ (-NumPhiStep.Value)

                vect_phi(k) = PHI
                model.SetPhi(vect_phi(k))
                vect_err(k) = model.CalcError(p)

                If (vect_err(k) < errmin) And (errfound = False) Then
                    errmin = vect_err(k)
                    PHIMin(i) = Math.Round(vect_phi(k), 3)
                End If

                k += 1

            Next

            Label9.Show()
            LabelRes.Show()

            Mat.Tables("p")(0)(i) = PHIMin(i)

        Next



    End Sub

    Private Sub ButtonAddMix_Click(sender As Object, e As EventArgs) Handles ButtonAddMix.Click

        nbp += 1
        Mat.Tables("MaterialsList").Columns.Add("p" + CStr(nbp))

        Dim column As DataColumn = New DataColumn("p" + CStr(nbp))
        column.DataType = System.Type.GetType("System.Double")
        Mat.Tables("p").Columns.Add(column)

        DataGridView.AutoResizeColumns()

    End Sub

    Private Sub ButtonMixAuto_Click(sender As Object, e As EventArgs) Handles ButtonMixAuto.Click

        Dim model As New CIPM(M, n, r, alpha, NumK.Value, Numdc.Value, d, Numwa.Value, Numwb.Value, NumCa.Value, NumCb.Value, 0)
        Dim MatTable()() As Object = Mat.Tables("MaterialsList").Rows.Cast(Of DataRow).Select(Function(dr) dr.ItemArray).ToArray

        MessageBox.Show("Fonction en développement !")

        'Dim combi As Double = Numdp.Value ^ M
        'Dim pauto(M - 1, combi - 1) As Double

        Try

            Dim cas(Numdp.Value - 1) As Integer
            Dim sumcas As Integer = 0

            For i As Integer = 0 To Numdp.Value - 1

                cas(i) = Numdp.Value - i
                sumcas += cas(i)

            Next

            Dim p(M - 1, sumcas - 1) As Double

            For i As Integer = 0 To M - 2

                Dim pmin As Double = 0
                Dim pmax As Double = 1
                Dim dp = (pmax - pmin) / (Numdp.Value - 1)
                Dim countiii As Integer = 0

                For ii As Integer = 0 To Numdp.Value - 1

                    For iii As Integer = 0 To cas(ii) - 1
                        p(i, iii + countiii) = pmin + dp * iii
                    Next

                    countiii += cas(ii)

                Next
            Next

            For i As Integer = 0 To sumcas - 1

                Dim sump As Double = 0

                For ii As Integer = 0 To M - 2

                    sump += p(ii, i)

                Next

                If sump < 1 Then
                    p(M - 1, i) = 1 - sump
                Else
                    MessageBox.Show("Error Sum p > 1 !")
                    GoTo B
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error auto calculation : pmin or pmax value are not given !")
        End Try
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

End Class