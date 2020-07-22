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

    Private r(,) As Double
    Private alpha(,) As Double
    Private d() As Double

    Dim M As Integer = 1
    Dim n As Integer

    Dim PHIMin As Double = 0
    Dim AlphaMin As Double = 0

    Private Sub FrmCIPM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelPHImin.Hide()
        Labelalphamin.Hide()

        Chart1.Titles.Add("Model Values")
        Chart1.ChartAreas.Clear()
        Chart1.ChartAreas.Add("Default")
        With Chart1.ChartAreas("Default")
            .AxisX.MajorGrid.LineColor = Color.SkyBlue
            .AxisY.Title = "Malax Energy [.]"
            .AxisY.Maximum = 0
            .AxisY.Maximum = 1
            .AxisY.MajorGrid.LineColor = Color.SkyBlue
        End With

        Connexion = New SqlConnection
        'Connexion.ConnectionString = "Data Source = 132.203.72.135;Initial Catalog=\\GCI-DACON-01\ECOCONCRETE\DATABASE\MATERIALS.MDF;Persist Security Info=True;User ID=sa;Password=***********"
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

        Mat = New MaterialsData

        DAdapter = New SqlDataAdapter(Command)
        DAdapter.Fill(Mat, "MaterialsList")

        ComboBoxMat.DataSource = Mat.Tables("MaterialsList")
        ComboBoxMat.DisplayMember = "Name"
        ComboBoxMat.ValueMember = "Id"

        NumK.Value = 12.2
        Numwa.Value = 1
        Numwb.Value = 1
        NumCa.Value = 1.5
        NumCb.Value = 0.2
        Numdc.Value = 125
        NumPHImin.Value = 0.2
        NumPhiStep.Value = 4
        NumPHIMax.Value = 0.8
        NumAlphaMax.Value = 0.45
        NumAlphaMin.Value = 0.35
        NumAlphaStep.Value = 4

        Chart1.Hide()

        Dim oData As DataRowView = ComboBoxMat.SelectedItem
        MatName = oData.Row("Name").ToString()

        Mat = New MaterialsData
        LoadData()

    End Sub

    Private Sub ButtonPhi_Click(sender As Object, e As EventArgs) Handles ButtonPhi.Click

        InitGraphs()
        Chart1.ChartAreas("Default").AxisX.Title = "Phi [.]"

        Dim p(M - 1) As Double
        For j As Integer = 0 To M - 1
            p(j) = 1
        Next

        Dim model As New CIPM(M, n, r, alpha, NumK.Value, Numdc.Value, d, Numwa.Value, Numwb.Value, NumCa.Value, NumCb.Value, 0)

        Dim ilength As Integer = (NumPHIMax.Value - NumPHImin.Value) / (10 ^ (-NumPhiStep.Value))
        Dim vect_err(ilength) As Double
        Dim vect_phi(ilength) As Double

        Dim errfound As Boolean = False
        Dim errmin As Double = 100
        Dim i As Integer = 0

        For PHI As Double = NumPHImin.Value To NumPHIMax.Value Step 10 ^ (-NumPhiStep.Value)

            vect_phi(i) = PHI
            model.SetPhi(vect_phi(i))
            vect_err(i) = model.CalcError(p)

            If (vect_err(i) < errmin) And (errfound = False) Then
                errmin = vect_err(i)
                PHIMin = vect_phi(i)
            End If
            If vect_err(i) > errmin Then
                errfound = True
            End If

            i += 1

        Next

        frmCIPM_Plot(vect_phi, vect_err, NumPHImin.Value, NumPHIMax.Value)
        frmCIPM_Plot(PHIMin, errmin, NumPHImin.Value, NumPHIMax.Value)

        LabelPHImin.Show()
        PHIMin = Math.Round(PHIMin, 3)
        LabelPHImin.Text = CStr(PHIMin)

    End Sub

    Private Sub ButtonAlpha_Click(sender As Object, e As EventArgs) Handles ButtonAlpha.Click

        Dim Kval As Double = 12.2
        Dim Phi As Double

        InitGraphs()
        Chart1.ChartAreas("Default").AxisX.Title = "Alpha [.]"

        Dim p(M - 1) As Double
        For j As Integer = 0 To M - 1
            p(j) = 1
        Next

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

        Try

            Dim Request = "SELECT PHI FROM MaterialsList WHERE Name = '" + MatName + "'"
            Command.Connection = Connexion
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            Dim reader As SqlDataReader = Command.ExecuteReader()
            reader.Read()
            Phi = CDbl(reader.GetString(0))
            MessageBox.Show("Phi = " + Phi.ToString())

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            GoTo b

        End Try

        Dim model As New CIPM(M, n, r, alpha, Kval, Numdc.Value, d, Numwa.Value, Numwb.Value, NumCa.Value, NumCb.Value, Phi)

        Dim ilength As Integer = (NumAlphaMax.Value - NumAlphaMin.Value) / (10 ^ (-NumAlphaStep.Value))

        Dim vect_err(ilength) As Double
        Dim vect_alpha(ilength) As Double

        Dim errfound As Boolean = False
        Dim errmin As Double = 100
        Dim i As Integer = 0

        For ALPHA As Double = NumAlphaMin.Value To NumAlphaMax.Value Step 10 ^ (-NumAlphaStep.Value)

            vect_alpha(i) = ALPHA
            model.SetAlpha(vect_alpha(i))
            vect_err(i) = model.CalcError(p)

            If (vect_err(i) < errmin) And (errfound = False) Then
                errmin = vect_err(i)
                AlphaMin = vect_alpha(i)
            End If
            If vect_err(i) > errmin Then
                errfound = True
            End If

            i += 1

        Next

        frmCIPM_Plot(vect_alpha, vect_err, NumAlphaMin.Value, NumAlphaMax.Value)
        frmCIPM_Plot(AlphaMin, errmin, NumAlphaMin.Value, NumAlphaMax.Value)

        Labelalphamin.Show()
        AlphaMin = Math.Round(AlphaMin, 3)
        Labelalphamin.Text = CStr(AlphaMin)
b:

    End Sub

    Private Sub frmCIPM_Plot(ByVal x() As Double, ByVal y() As Double, ByVal xmin As Double, ByVal xmax As Double)

        Chart1.Show()
        Chart1.ChartAreas("Default").AxisX.Minimum = xmin
        Chart1.ChartAreas("Default").AxisX.Maximum = xmax

        For i As Integer = 0 To x.Length - 1
            Chart1.Series("Plot").Points.AddXY(x(i), y(i))
        Next

    End Sub

    Private Sub frmCIPM_Plot(ByVal x As Double, ByVal y As Double, ByVal xmin As Double, ByVal xmax As Double)

        Chart1.Show()
        Chart1.ChartAreas("Default").AxisX.Minimum = xmin
        Chart1.ChartAreas("Default").AxisX.Maximum = xmax

        Chart1.Series("PlotMin").Points.AddXY(x, y)


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

    Private Sub ButtonSavePhi_Click(sender As Object, e As EventArgs) Handles ButtonSavePhi.Click

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

        Dim Question As String = "Value of PHI ?"
        Dim PHIMinManual As String = CStr(PHIMin)
        PHIMinManual = InputBox(Question, "SAVE PHI", CStr(PHIMin))

        Try

            Dim Request = "UPDATE MaterialsList SET PHI = " + PHIMinManual + " WHERE Name = '" + MatName + "'"
            Command.Connection = Connexion
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            Request = "UPDATE MaterialsList SET K = " + CStr(NumK.Value) + " WHERE Name = '" + MatName + "'"
            Command.Connection = Connexion
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            Request = "SELECT * FROM MaterialsList"
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            Dim DAdapter As New SqlDataAdapter(Command)
            DAdapter.Fill(Mat, "MaterialsList")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub ButtonSaveAlpha_Click(sender As Object, e As EventArgs) Handles ButtonSaveAlpha.Click

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

        Dim Question As String = "Value of Alpha ?"
        Dim AlphaMinManual As String = CStr(AlphaMin)
        AlphaMinManual = InputBox(Question, "SAVE Alpha", CStr(AlphaMin))

        Try

            Dim Request = "UPDATE [" + MatName + "] Set alpha = " + CStr(AlphaMin)
            Command.Connection = Connexion
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            Request = "UPDATE MaterialsList SET K = " + CStr(NumK.Value) + " WHERE Name = '" + MatName + "'"
            Command.Connection = Connexion
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            Request = "SELECT * FROM MaterialsList"
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            Dim DAdapter As New SqlDataAdapter(Command)
            DAdapter.Fill(Mat, "MaterialsList")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

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

        Dim Request = "SELECT * FROM [" + MatName + "]"
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

        Try
            Request = "SELECT K FROM MaterialsList WHERE Name = '" + MatName + "'"
            Command.Connection = Connexion
            Command.CommandText = Request
            Command.ExecuteNonQuery()

            Dim reader As SqlDataReader = Command.ExecuteReader()
            reader.Read()
            NumK.Value = CDbl(reader.GetString(0))

        Catch ex As Exception
            MessageBox.Show("No value for K in " + MatName + ". Default value = 12.2")
            NumK.Value = 12.2
        End Try

        MatNameOld = MatName

    End Sub

    Protected Overrides Sub Finalize()
        Connexion.Close()
        DAdapter.Dispose()
        Command.Dispose()
        Mat.Dispose()
        MyBase.Finalize()
    End Sub

End Class