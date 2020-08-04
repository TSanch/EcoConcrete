Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.Data.DataRow
Imports System.Xml

Public Class FrmLogin

    'Dim Mat As MaterialsData

    Private LoginList As String = "DABOU ; Public"

    Dim MatNameOld As String = ""

    Public r(,) As Double
    Public alpha(,) As Double
    Public d() As Double

    Dim M As Integer = 1
    Dim n As Integer

    Dim PHIMin

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'FrmMain.DBCon.VerifyConnexion()

        'Dim Request = "SELECT * FROM MaterialsList"

        'Command = New SqlCommand
        'Command.Connection = Connexion
        'Command.CommandText = Request
        'Command.ExecuteNonQuery()

        'Mat = New MaterialsData

        'DAdapter = New SqlDataAdapter(Command)
        'DAdapter.Fill(Mat, "MaterialsList")

        'ComboBoxLogin.DataSource = Mat.Tables("MaterialsList")
        'ComboBoxLogin.DisplayMember = "Name"
        'ComboBoxLogin.ValueMember = "Id"

        ComboBoxLogin.Items.Add("DABOU")
        ComboBoxLogin.Items.Add("Public")

        TextBoxPwd.PasswordChar = "*"

        'Mat = New MaterialsData
        'LoadData()

    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click

        If ComboBoxLogin.SelectedItem = "DABOU" Then

            If TextBoxPwd.Text = "sexyboy" Then

                FrmMain.DBCon.user = "DABOU"
                FrmMain.DBCon.Connexion.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\GCI-DACON-01\Ecoconcrete\Database\Materials.mdf;Integrated Security=True;Connect Timeout=30"
                Close()

            Else
                MessageBox.Show("Wrong Password")
            End If

        ElseIf ComboBoxLogin.SelectedItem = "Public" Then

            FrmMain.DBCon.user = "Public"
            MessageBox.Show("Database in Read Access")
            FrmMain.DBCon.Connexion.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\GCI-DACON-01\Ecoconcrete\Database\MaterialsPublic.mdf;Integrated Security=True;Connect Timeout=30"
            Close()

        Else

            MessageBox.Show("Wrong Login")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click

        Close()
        End

    End Sub

End Class