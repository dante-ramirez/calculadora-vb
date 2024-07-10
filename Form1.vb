Public Class Form1
    Sub operacion()
        If PANTALLITA.Text <> "" Then
            valor = PANTALLITA.Text
            PANTALLITA.Text = ""
        End If
    End Sub

    Sub total()
        If PANTALLITA.Text <> "" Then
            ovalor = PANTALLITA.Text
            If (operador.Equals("+")) Then
                PANTALLITA.Text = valor + ovalor
            ElseIf (operador.Equals("-")) Then
                PANTALLITA.Text = valor - ovalor
            ElseIf (operador.Equals("*")) Then
                PANTALLITA.Text = valor * ovalor
            ElseIf (operador.Equals("/")) Then
                PANTALLITA.Text = valor / ovalor
            End If
        End If
    End Sub


    Dim operador As String
    Dim valor As Double
    Dim ovalor As Double = 0

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles PUNTO.Click
        PANTALLITA.Text = ""
        ovalor = 0
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles IGUAL.Click
        total()
        ovalor = 0
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles DIV.Click
        If ovalor <> 0 Then
            total()
        Else
            operador = "/"
            operacion()
        End If
    End Sub

    Private Sub BORRAR_Click(sender As Object, e As EventArgs) Handles BORRAR.Click
        If PANTALLITA.Text <> "" Then

            PANTALLITA.Text = PANTALLITA.Text.Substring(0, PANTALLITA.Text.Length - 1)
        End If
    End Sub

    Private Sub UNO_Click(sender As Object, e As EventArgs) Handles UNO.Click
        PANTALLITA.Text = PANTALLITA.Text + "1"
    End Sub

    Private Sub DOS_Click(sender As Object, e As EventArgs) Handles DOS.Click
        PANTALLITA.Text = PANTALLITA.Text + "2"
    End Sub

    Private Sub SEIS_Click(sender As Object, e As EventArgs) Handles SEIS.Click
        PANTALLITA.Text = PANTALLITA.Text + "6"
    End Sub

    Private Sub CINCO_Click(sender As Object, e As EventArgs) Handles CINCO.Click
        PANTALLITA.Text = PANTALLITA.Text + "5"
    End Sub

    Private Sub TRES_Click(sender As Object, e As EventArgs) Handles TRES.Click
        PANTALLITA.Text = PANTALLITA.Text + "3"
    End Sub

    Private Sub CUATRO_Click(sender As Object, e As EventArgs) Handles CUATRO.Click
        PANTALLITA.Text = PANTALLITA.Text + "4"
    End Sub

    Private Sub SIETE_Click(sender As Object, e As EventArgs) Handles SIETE.Click
        PANTALLITA.Text = PANTALLITA.Text + "7"
    End Sub

    Private Sub OCHO_Click(sender As Object, e As EventArgs) Handles OCHO.Click
        PANTALLITA.Text = PANTALLITA.Text + "8"
    End Sub

    Private Sub NUEVE_Click(sender As Object, e As EventArgs) Handles NUEVE.Click
        PANTALLITA.Text = PANTALLITA.Text + "9"
    End Sub

    Private Sub CERO_Click(sender As Object, e As EventArgs) Handles CERO.Click
        PANTALLITA.Text = PANTALLITA.Text + "0"
    End Sub

    Private Sub SUM_Click(sender As Object, e As EventArgs) Handles SUM.Click
        If ovalor <> 0 Then
            total()
        Else
            operador = "+"
            operacion()
        End If
    End Sub

    Private Sub MULT_Click(sender As Object, e As EventArgs) Handles MULT.Click
        If ovalor <> 0 Then
            total()
        Else
            operador = "*"
            operacion()
        End If
    End Sub

    Private Sub REST_Click(sender As Object, e As EventArgs) Handles REST.Click
        If ovalor <> 0 Then
            total()
        Else
            operador = "-"
            operacion()
        End If
    End Sub

End Class
