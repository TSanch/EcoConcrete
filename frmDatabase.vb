Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient

Public Class FrmDatabase
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub NumericUpDown7_ValueChanged(sender As Object, e As EventArgs) Handles Numdc.ValueChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub FrmCIPM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelRes.Hide()
        Label9.Hide()

        NumM.Value = 1
        Numn.Value = 8
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

        Dim r(,) As Double
        Dim alpha(,) As Double
        Dim Kval As Double

        InitGraphs()

        r = {{0.04, 0.44, 6.16, 24.98, 37.23, 25.43, 5.69, 0.05}}
        For i As Integer = 0 To Numn.Value - 1
            r(0, i) /= 100
        Next

        alpha = New Double(NumM.Value - 1, Numn.Value - 1) {}
        For i As Integer = 0 To (NumM.Value - 1)
            For j As Integer = 0 To (Numn.Value - 1)
                alpha(i, j) = 0.385
            Next
        Next

        Kval = 12.2

        Dim d = {60.7, 28.3, 13.2, 6.1, 2.9, 1.3, 0.6, 0.3}

        Dim model As New CIPM(NumM.Value, Numn.Value, r, alpha, Kval, Numdc.Value, d, Numwa.Value, Numwb.Value, NumCa.Value, NumCb.Value)

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