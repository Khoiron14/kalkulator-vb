Public Class Form1
    Dim tmp As Decimal
    Dim op As String

    'remove dot when no number after dot
    Private Sub rmvDot()
        With TextBox1
            If .Text(.Text.Length - 1) = "." Then
                .Text = .Text.Remove(.Text.Length - 1, 1)
            End If
        End With
    End Sub

    'adding number
    Private Sub addNum(num As Integer)
        If TextBox1.Text <> "0" Then
            TextBox1.Text += num.ToString
        Else
            TextBox1.Text = num.ToString
        End If
    End Sub

    Private Sub setResult(operation As String)
        If op <> "" Then
            Select Case op
                Case "+"
                    tmp = tmp + CDec(TextBox1.Text)
                Case "-"
                    tmp = tmp - CDec(TextBox1.Text)
                Case "x"
                    tmp = tmp * CDec(TextBox1.Text)
                Case "/"
                    tmp = tmp / CDec(TextBox1.Text)
                Case "%"
                    tmp = tmp Mod CDec(TextBox1.Text)
            End Select
        Else
            tmp = CDec(TextBox1.Text)
        End If

        op = operation
    End Sub

    Private Sub add(operation As String)
        If TextBox1.Text <> "0" Then
            Label1.Text += TextBox1.Text + operation
            setResult(operation)
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If TextBox1.Text(0) <> "0" Then
            TextBox1.Text += "0"
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        addNum(1)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        addNum(2)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        addNum(3)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        addNum(4)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        addNum(5)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        addNum(6)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        addNum(7)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        addNum(8)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        addNum(9)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Not TextBox1.Text.Contains(".") Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = ""
        TextBox1.Text = "0"
        tmp = Nothing
        op = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With TextBox1
            If .Text.Length = 2 And .Text(0) = "-" Then
                .Text = "0"
            ElseIf .Text.Length = 1 Then
                .Text = "0"
            Else
                .Text = .Text.Remove(.Text.Length - 1, 1)
            End If
        End With
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        rmvDot()
        add("+")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        rmvDot()
        add("-")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        rmvDot()
        add("x")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        rmvDot()
        add("/")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        rmvDot()
        add("%")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If tmp <> Nothing Then
            If TextBox1.Text <> "" And Label1.Text <> "" Then
                setResult(Label1.Text.Substring(Label1.Text.Length - 1))
            End If

            Label1.Text = ""
            TextBox1.Text = tmp.ToString("G29") 'good decimal format
            tmp = Nothing
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If TextBox1.Text <> "0" AndAlso TextBox1.Text <> "" Then
            TextBox1.Text = CDec(TextBox1.Text) * -1
        End If
    End Sub
End Class
