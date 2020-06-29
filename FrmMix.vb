Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.Data.DataRow
Imports System.Xml

Public Class FrmMix

    Dim Connexion As SqlConnection
    Dim DAdapter As SqlDataAdapter
    Dim Command As SqlCommand

    Dim Mat As MaterialsData

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

        'Chart1.Titles.Add("Model Values")
        'Chart1.ChartAreas.Clear()
        'Chart1.ChartAreas.Add("Default")
        'With Chart1.ChartAreas("Default")
        '.AxisX.Title = "Compacity [.]"
        '.AxisX.MajorGrid.LineColor = Color.SkyBlue
        '.AxisY.Title = "Malax Energy [.]"
        '.AxisY.Maximum = NumPHImin.Value
        '.AxisY.Maximum = NumPHIMax.Value
        '.AxisY.MajorGrid.LineColor = Color.SkyBlue
        'End With

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

        Dim Request As String = "SELECT * FROM MaterialsList"
        Command = New SqlCommand
        Command.Connection = Connexion
        Command.CommandText = Request
        Command.ExecuteNonQuery()

        Mat = New MaterialsData

        DAdapter = New SqlDataAdapter(Command)
        DAdapter.Fill(Mat, "MaterialsList")

        For i As Integer = 0 To Mat.Tables("MaterialsList").Rows.Count - 1

            CheckedListBox.Items.Add(Mat.Tables("MaterialsList")(i)(1))

        Next

        'CheckedListBox.DisplayMember = "Name"
        'CheckedListBox.ValueMember = "Id"

        Numwa.Value = 1
        Numwb.Value = 1
        NumCa.Value = 1.5
        NumCb.Value = 0.2
        Numdc.Value = 125
        NumPHImin.Value = 0.2
        NumPhiStep.Value = 4
        NumPHIMax.Value = 0.8

        'Chart1.Hide()

        'Mat.Tables("MaterialsList").Columns.Add("p" + CStr(nbp))

        'Ajouter colomne pour proportions p

        DataGridView.DataSource = Mat.Tables("MaterialsList")
        DataGridView.Columns("Id").Visible = False
        DataGridView.Columns("Name").Visible = True
        DataGridView.Columns("Manufacturer").Visible = True
        DataGridView.Columns("Cost").Visible = True
        DataGridView.Columns("Density").Visible = False
        DataGridView.Columns("PHI").Visible = False
        DataGridView.AutoResizeColumns()

    End Sub

    Private Sub ButtonChoiceMat_Click(sender As Object, e As EventArgs) Handles ButtonChoiceMat.Click

        ReDim MatName(CheckedListBox.CheckedItems.Count - 1)
        For i As Integer = 0 To CheckedListBox.CheckedItems.Count - 1
            MatName(i) = CheckedListBox.GetItemText(CheckedListBox.CheckedItems(i)).ToString()
        Next

        LoadData()

    End Sub

    'Private Sub frmCIPM_Plot(ByVal x As Double, ByVal y As Double, ByVal choice As Integer)

    '    Chart1.Show()

    '    Chart1.ChartAreas("Default").AxisY.Minimum = 0
    '    Chart1.ChartAreas("Default").AxisY.Maximum = 0.3
    '    Chart1.ChartAreas("Default").AxisX.Minimum = NumPHImin.Value
    '    Chart1.ChartAreas("Default").AxisX.Maximum = NumPHIMax.Value

    '    Select Case choice
    '        Case 1
    '            Chart1.Series("Plot").Points.AddXY(x, y)
    '        Case 2
    '            Chart1.Series("PlotMin").Points.AddXY(x, y)
    '    End Select

    'End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Connexion.Close()
        DAdapter.Dispose()
        Command.Dispose()
        Mat.Dispose()
        MyBase.Finalize()
    End Sub

    'Private Sub InitGraphs()

    '    Chart1.Series.Clear()
    '    Chart1.Series.Add("Plot")
    '    Chart1.Series("Plot").Color = Color.Red
    '    Chart1.Series("Plot").ChartType = DataVisualization.Charting.SeriesChartType.Line
    '    Chart1.Series.Add("PlotMin")
    '    Chart1.Series("PlotMin").Color = Color.Blue
    '    Chart1.Series("PlotMin").MarkerSize = 10
    '    Chart1.Series("PlotMin").ChartType = DataVisualization.Charting.SeriesChartType.Point

    'End Sub

    Private Sub LoadData()

        If Connexion.State = ConnectionState.Open Then
            Connexion.Close()
        End If
        Try
            Connexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        Dim listName As String = String.Join("','", MatName)
        Dim Request As String = "SELECT * FROM MaterialsList WHERE Name IN ('" + listName + "')"
        Command = New SqlCommand
        Command.Connection = Connexion
        Command.CommandText = Request
        Command.ExecuteNonQuery()

        Mat.Tables("MaterialsList").Clear()

        DAdapter = New SqlDataAdapter(Command)
        DAdapter.Fill(Mat, "MaterialsList")

        DataGridView.DataSource = Mat.Tables("MaterialsList")
        DataGridView.Columns("Id").Visible = False
        DataGridView.Columns("Name").Visible = True
        DataGridView.Columns("Manufacturer").Visible = False
        DataGridView.Columns("Cost").Visible = False
        DataGridView.Columns("Density").Visible = False
        DataGridView.Columns("PHI").Visible = False
        DataGridView.AutoSize = False

        M = MatName.Length()

        'Dim Phi_values(M - 1) As Double

        For i As Integer = 0 To M - 1

            Request = "SELECT * FROM [" + MatName(i) + "]"
            Command.Connection = Connexion
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            Dim DAdapter = New SqlDataAdapter(Command)
            If Mat.Tables.Contains(MatName(i)) Then Mat.Tables(MatName(i)).Clear()
            DAdapter.Fill(Mat, MatName(i))

            'Phi_values(i) = Mat.Tables("MaterialsList").Rows.Cast(Of DataRow).Select(Function(dr) dr.ItemArray).ToArray(j)(5)

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

        Dim Kval As Double = 12.2

        Dim model As New CIPM(M, n, r, alpha, Kval, Numdc.Value, d, Numwa.Value, Numwb.Value, NumCa.Value, NumCb.Value, 0)

        LabelPHImin.Text = ""

        ReDim PHIMin(nbp - 1)

        For i As Integer = 0 To nbp - 1

            Dim MatTable()() As Object = Mat.Tables("MaterialsList").Rows.Cast(Of DataRow).Select(Function(dr) dr.ItemArray).ToArray

            Dim p(M - 1) As Double
            For j As Integer = 0 To M - 1
                p(j) = CDbl(MatTable(j)(6 + i))
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

            LabelPHImin.Text += " " + CStr(PHIMin(i))

        Next


    End Sub

    Private Sub ButtonAddMix_Click(sender As Object, e As EventArgs) Handles ButtonAddMix.Click

        nbp += 1
        Mat.Tables("MaterialsList").Columns.Add("p" + CStr(nbp))

    End Sub

End Class