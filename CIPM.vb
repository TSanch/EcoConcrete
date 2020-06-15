Imports Microsoft.VisualBasic.Logging
Imports Microsoft.Win32

Public Class CIPM

    Private NbMaterials As Double
    Private n As Double
    Private p() As Double
    Private r(,) As Double
    Private alpha(,) As Double
    Private Kcipm As Double
    Private dc As Double
    Private d(n - 1) As Double
    Private wa As Double
    Private wb As Double
    Private Ca As Double
    Private Cb As Double
    Private a(,) As Double
    Private b(,) As Double

    Public Sub New(ByVal NbMaterialsval As Double, ByVal nval As Double, ByVal rval(,) As Double, ByVal alphaval(,) As Double, ByVal Kval As Double,
            ByVal dcval As Double, ByVal dval() As Double, ByVal waval As Double, ByVal wbval As Double, ByVal Caval As Double, ByVal Cbval As Double)

        NbMaterials = NbMaterialsval
        n = nval

        r = rval
        alpha = alphaval
        Kcipm = Kval
        dc = dcval
        d = dval
        wa = waval
        wb = wbval
        Ca = Caval
        Cb = Cbval

        Calcab()

    End Sub

    Private Sub Calcab()

        Dim logdd As Double
        Dim w0a, w0b As Double

        ReDim a(n - 1, n - 1)
        ReDim b(n - 1, n - 1)

        For i As Integer = 0 To n - 1
            For j As Integer = 0 To n - 1

                w0a = wa

                If d(j) < dc Then
                    w0a = wa * Ca
                End If

                logdd = Math.Log10(d(i) / d(j))

                If logdd < w0a Then
                    a(i, j) = 1 - logdd / w0a
                Else
                    a(i, j) = 0
                End If

                w0b = wb
                If d(i) < dc Then
                    w0b = wb * Cb
                End If

                logdd = Math.Log10(d(j) / d(i))

                If logdd < w0b Then
                    b(i, j) = 1 - logdd / w0b
                Else
                    b(i, j) = 0
                End If
            Next
        Next

    End Sub

    Public Function CalcError(ByVal PHI As Double, ByVal pval() As Double) As Double

        Dim Kcalc As Double = 0
        Dim PhiBeta, Phi2Beta As Double
        Dim beta, betaj As Double
        Dim r2 As Double

        p = pval

        For i As Integer = 0 To n - 1

            PhiBeta = 0
            Phi2Beta = 0

            'Loop on the materials
            For k As Integer = 0 To NbMaterials - 1

                beta = (1 + 1 / Kcipm) * alpha(k, i)
                PhiBeta += p(k) * r(k, i) * PHI / beta

                'Loop on the complete granulometry
                r2 = 0

                For j As Integer = 0 To (i - 2)

                    betaj = (1 + 1 / Kcipm) * alpha(k, j)
                    r2 += (1 - b(i, j) * (1 - 1 / betaj)) * r(k, j) * PHI

                Next

                For j As Integer = i To (n - 1)

                    betaj = (1 + 1 / Kcipm) * alpha(k, j)
                    r2 += a(i, j) * r(k, j) * PHI / betaj

                Next

                Phi2Beta += p(k) * (1 - r2)

            Next

            Kcalc += PhiBeta / (Phi2Beta - PhiBeta)

        Next

        Return Math.Abs(Kcalc - Kcipm) / Kcipm

    End Function

End Class
