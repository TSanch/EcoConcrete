Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.Data.DataRow
Imports System.Xml

Public Class FrmCIPM

    Dim Connexion As SqlConnection
    Dim DAdapter As SqlDataAdapter
    Dim Command As SqlCommand

    Dim Mat As MaterialsData

    Dim MatName As String
    Dim MatNameOld As String = ""

    Public r(,) As Double
    Public alpha(,) As Double
    Public d() As Double

    Dim M As Integer = 1
    Dim n As Integer

    Dim PHIMin

    Private Sub FrmCIPM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelRes.Hide()
        Label9.Hide()

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

        Connexion = New SqlConnection
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
        Command = New SqlCommand
        Command.Connection = Connexion
        Command.CommandText = Request
        Command.ExecuteNonQuery()

        Mat = New MaterialsData

        DAdapter = New SqlDataAdapter(Command)
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

        Dim oData As DataRowView = ComboBoxMat.SelectedItem
        MatName = oData.Row("Name").ToString()

        Mat = New MaterialsData
        LoadData()

    End Sub

    Private Sub ButtonCIPM_Click(sender As Object, e As EventArgs) Handles ButtonCIPM.Click

        Dim Kval As Double = 12.2

        InitGraphs()

        Dim model As New CIPM(M, n, r, alpha, Kval, Numdc.Value, d, Numwa.Value, Numwb.Value, NumCa.Value, NumCb.Value)

        Dim err As Double
        Dim errmin As Double = 100

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

        Chart1.ChartAreas("Default").AxisY.Minimum = 0
        Chart1.ChartAreas("Default").AxisY.Maximum = 0.3
        Chart1.ChartAreas("Default").AxisX.Minimum = NumPHImin.Value
        Chart1.ChartAreas("Default").AxisX.Maximum = NumPHIMax.Value

        Select Case choice
            Case 1
                Chart1.Series("Plot").Points.AddXY(x, y)
            Case 2
                Chart1.Series("PlotMin").Points.AddXY(x, y)
        End Select

    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Connexion.Close()
        DAdapter.Dispose()
        Command.Dispose()
        Mat.Dispose()
        Close()
    End Sub

    Private Sub InitGraphs()

        Chart1.Series.Clear()
        Chart1.Series.Add("Plot")
        Chart1.Series("Plot").Color = Color.Red
        Chart1.Series("Plot").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series.Add("PlotMin")
        Chart1.Series("PlotMin").Color = Color.Blue
        Chart1.Series("PlotMin").MarkerSize = 10
        Chart1.Series("PlotMin").ChartType = DataVisualization.Charting.SeriesChartType.Point

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

        Select Case MsgBox("Are you sure to save PHI for " + MatName, MsgBoxStyle.YesNo, MatName)
            Case MsgBoxResult.Yes

                Dim Request = "UPDATE MaterialsList SET PHI = " + PHIMin.ToString() + " WHERE Name = '" + MatName + "'"
                Command.Connection = Connexion
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

        If MatName <> MatNameOld Then LoadData()

    End Sub

    Private Sub LoadData()

        If Connexion.State = ConnectionState.Open Then
            Connexion.Close()
        End If
        Try
            Connexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim Request = "SELECT * FROM " + MatName
        Command.Connection = Connexion
        Command.CommandText = Request
        Command.ExecuteNonQuery()

        Dim DAdapter = New SqlDataAdapter(Command)
        DAdapter.Fill(Mat, MatName)

        Dim MatTable()() As Object = Mat.Tables(MatName).Rows.Cast(Of DataRow).Select(Function(dr) dr.ItemArray).ToArray
        n = MatTable.Count()

        ReDim r(M - 1, n - 1)
        For i As Integer = 0 To n - 1
            r(0, i) = MatTable(i)(1) / 100
        Next

        ReDim alpha(M - 1, n - 1)
        For i As Integer = 0 To n - 1
            alpha(0, i) = MatTable(i)(2)
        Next

        ReDim d(n - 1)
        For i As Integer = 0 To n - 1
            d(i) = MatTable(i)(3)
        Next

        MatNameOld = MatName

    End Sub

End Class