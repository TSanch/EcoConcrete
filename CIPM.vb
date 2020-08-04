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
    Private Phi As Double

    Public Sub New(ByRef NbMaterialsval As Double, ByRef nval As Double, ByRef rval(,) As Double, ByRef alphaval(,) As Double, ByRef Kval As Double,
            ByRef dcval As Double, ByRef dval() As Double, ByRef waval As Double, ByRef wbval As Double, ByRef Caval As Double, ByRef Cbval As Double, ByRef Phival As Double)

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
        Phi = Phival

        Calcab()

    End Sub

    Public Sub SetPhi(ByRef Phival As Double)

        Phi = Phival

    End Sub

    Public Sub SetAlpha(ByRef Alphaval As Double)

        For k As Integer = 0 To NbMaterials - 1
            For j As Integer = 0 To n - 1
                alpha(k, j) = Alphaval
            Next
        Next

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

    Public Function CalcError(ByRef pval() As Double) As Double

        Dim Kcalc As Double = 0
        Dim PhiBeta, Phi2Beta As Double
        Dim beta, betaj As Double
        Dim r2 As Double

        p = pval

        For i As Integer = 0 To n - 1

            PhiBeta = 0
            Phi2Beta = 0

            For k As Integer = 0 To NbMaterials - 1

                beta = (1 + 1 / Kcipm) * alpha(k, i)
                PhiBeta += p(k) * r(k, i) * Phi / beta

                r2 = 0

                For j As Integer = 0 To (i - 1)

                    betaj = (1 + 1 / Kcipm) * alpha(k, j)
                    r2 += (1 - b(i, j) * (1 - 1 / betaj)) * r(k, j) * Phi

                Next

                For j As Integer = (i + 1) To (n - 1)

                    betaj = (1 + 1 / Kcipm) * alpha(k, j)
                    r2 += a(i, j) * r(k, j) * Phi / betaj

                Next

                Phi2Beta += p(k) * (1 - r2)

            Next

            Kcalc += PhiBeta / (Phi2Beta - PhiBeta)

        Next

        Return Math.Abs(Kcalc - Kcipm) / Kcipm

    End Function

End Class
