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

    Dim n As Integer
    Private r(,) As Double
    Private alpha(,) As Double
    Private d() As Double

    Dim M As Integer
    Dim nbp As Integer = 0


    Dim PHIMin

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
        NumPhiStep.Value = 3
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
        DataGridView.AutoSize = False


    End Sub

    Private Sub ButtonChoiceMat_Click(sender As Object, e As EventArgs) Handles ButtonChoiceMat.Click

        'InitGraphs()

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
        Close()
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

        Dim foundRows(100) As DataRow

        ReDim MatName(CheckedListBox.CheckedItems.Count - 1)
        For i As Integer = 0 To CheckedListBox.CheckedItems.Count - 1
            MatName(i) = CheckedListBox.GetItemText(CheckedListBox.CheckedItems(i)).ToString()
        Next

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
        DataGridView.Columns("Manufacturer").Visible = True
        DataGridView.Columns("Cost").Visible = True
        DataGridView.Columns("Density").Visible = False
        DataGridView.Columns("PHI").Visible = False
        DataGridView.AutoSize = False

        M = MatName.Length()

        For i As Integer = 0 To M - 1

            Request = "SELECT * FROM " + MatName(i)
            Command.Connection = Connexion
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            Dim DAdapter = New SqlDataAdapter(Command)
            If Mat.Tables.Contains(MatName(i)) Then Mat.Tables(MatName(i)).Clear()
            DAdapter.Fill(Mat, MatName(i))

        Next

        n = Mat.Tables(MatName(0)).Rows.Cast(Of DataRow).Select(Function(dr) dr.ItemArray).ToArray.Length()

        ReDim d(n - 1)
        For j As Integer = 0 To n - 1
            d(j) = Mat.Tables(MatName(0)).Rows.Cast(Of DataRow).Select(Function(dr) dr.ItemArray).ToArray(j)(3)
        Next

        For i As Integer = 0 To M - 1

            Dim MatTable()() As Object = Mat.Tables(MatName(i)).Rows.Cast(Of DataRow).Select(Function(dr) dr.ItemArray).ToArray

            ReDim r(M - 1, n - 1)
            For j As Integer = 0 To n - 1
                r(i, j) = MatTable(j)(1) / 100
            Next

            ReDim alpha(M - 1, n - 1)
            For j As Integer = 0 To n - 1
                alpha(i, j) = MatTable(j)(2)
            Next

        Next

    End Sub

    Private Sub ButtonMixOpt_Click(sender As Object, e As EventArgs) Handles ButtonMixOpt.Click

        Dim Kval As Double = 12.2

        Dim model As New CIPM(M, n, r, alpha, Kval, Numdc.Value, d, Numwa.Value, Numwb.Value, NumCa.Value, NumCb.Value)

        LabelPHImin.Text = ""

        For i As Integer = 0 To nbp - 1

            Dim MatTable()() As Object = Mat.Tables("MaterialsList").Rows.Cast(Of DataRow).Select(Function(dr) dr.ItemArray).ToArray

            Dim p(M - 1) As Double
            For j As Integer = 0 To M - 1
                p(j) = CDbl(MatTable(j)(6 + i))
            Next

            Dim err As Double
            Dim errmin As Double = 100

            For PHI As Double = NumPHImin.Value To NumPHIMax.Value Step 10 ^ (-NumPhiStep.Value)

                err = model.CalcError(PHI, p)
                'frmCIPM_Plot(PHI, err, 1)
                If err < errmin Then
                    errmin = err
                    PHIMin = PHI
                End If

            Next

            'frmCIPM_Plot(PHIMin, errmin, 2)
            Label9.Show()
            LabelRes.Show()

            LabelPHImin.Text += " " + CStr(PHIMin)

        Next


    End Sub

    Private Sub ButtonAddMix_Click(sender As Object, e As EventArgs) Handles ButtonAddMix.Click

        nbp += 1
        Mat.Tables("MaterialsList").Columns.Add("p" + CStr(nbp))

    End Sub

End Class