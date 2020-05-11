Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.Data.DataRow
Imports System.Xml

Public Class FrmCIPM

    Dim Connexion As New SqlConnection
    Dim Mat As New MaterialsData
    Dim Command As New SqlCommand

    Dim M As Integer = 1


    Private Sub FrmCIPM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelRes.Hide()
        Label9.Hide()

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

        Numwa.Value = 1
        Numwb.Value = 1
        NumCa.Value = 1.5
        NumCb.Value = 0.2
        Numdc.Value = 25
        NumPHImin.Value = 0.2
        NumPhiStep.Value = 3
        NumPHIMax.Value = 0.8

        Chart1.Hide()

    End Sub

    Private Sub ButtonCIPM_Click(sender As Object, e As EventArgs) Handles ButtonCIPM.Click

        Dim Kval As Double = 12.2

        InitGraphs()

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

        Dim Request = "SELECT * FROM " + MatName
        Command.CommandText = Request
        Command.ExecuteNonQuery()

        Dim DAdapter As New SqlDataAdapter(Command)
        DAdapter.Fill(Mat, MatName)

        Dim MatTable()() As Object = Mat.Tables(MatName).Rows.Cast(Of DataRow).Select(Function(dr) dr.ItemArray).ToArray
        Dim n = MatTable.Count()

        Dim r(M - 1, n - 1) As Double
        For i As Integer = 0 To n - 1
            r(0, i) = MatTable(i)(2) / 100
        Next

        Dim alpha(M - 1, n - 1) As Double
        For i As Integer = 0 To n - 1
            alpha(0, i) = MatTable(i)(3)
        Next

        Dim d(n - 1) As Double
        For i As Integer = 0 To n - 1
            d(i) = MatTable(i)(4)
        Next

        Dim model As New CIPM(M, n, r, alpha, Kval, Numdc.Value, d, Numwa.Value, Numwb.Value, NumCa.Value, NumCb.Value)

        Dim err As Double
        Dim errmin As Double = 100
        Dim PHImin As Double

        For PHI As Double = NumPHImin.Value To NumPHIMax.Value Step 10 ^ (-NumPhiStep.Value)
            err = model.CalcError(PHI)
            frmCIPM_Plot(PHI, err, 1)
            If err < errmin Then
                errmin = err
                PHImin = PHI
            End If

        Next

        frmCIPM_Plot(PHImin, errmin, 2)
        Label9.Show()
        LabelRes.Show()
        LabelPHImin.Text = CStr(PHImin)

    End Sub

    Private Sub frmCIPM_Plot(ByVal x As Double, ByVal y As Double, ByVal choice As Integer)

        Chart1.Show()

        Select Case choice
            Case 1
                Chart1.Series("Plot").Points.AddXY(x, y)
            Case 2
                Chart1.Series("PlotMin").Points.AddXY(x, y)
        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Close()
    End Sub

    Private Sub InitGraphs()
        Chart1.Titles.Add("Model Values")
        Chart1.ChartAreas.Clear()
        Chart1.ChartAreas.Add("Default")

        With Chart1.ChartAreas("Default")
            .AxisX.Title = "Compacity [.]"
            .AxisX.MajorGrid.LineColor = Color.SkyBlue
            .AxisY.Title = "Malax Energy [.]"
            .AxisY.Maximum = NumPHImin.Value
            .AxisY.Maximum = NumPHIMax.Value
            .AxisY.MajorGrid.LineColor = Color.SkyBlue
        End With

        Chart1.Series.Clear()
        Chart1.Series.Add("Plot")
        Chart1.Series("Plot").Color = Color.Red
        Chart1.Series("Plot").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series.Add("PlotMin")
        Chart1.Series("PlotMin").Color = Color.Blue
        Chart1.Series("PlotMin").MarkerSize = 10
        Chart1.Series("PlotMin").ChartType = DataVisualization.Charting.SeriesChartType.Point
    End Sub


End Class