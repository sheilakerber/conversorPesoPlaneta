Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If (txtPeso.Text = Nothing Or Not IsNumeric(txtPeso.Text)) Then
            MessageBox.Show("Insira um valor numérico no campo 'peso'.")
            Exit Sub
        End If

        If (Not rbtMercurio.Checked And Not rbtVenus.Checked And Not rbtMarte.Checked And Not rbtJupiter.Checked And Not rbtSaturno.Checked And Not rbtUrano.Checked) Then
            MessageBox.Show("Selecione um planeta.")
            Exit Sub
        End If

        Dim peso As Double = txtPeso.Text

        If (rbtMercurio.Checked) Then
            lblRersultado.Text = "Seu peso no planeta Mercúrio é " & (peso * 0.37) & " Kg."
        ElseIf (rbtVenus.Checked) Then
            lblRersultado.Text = "Seu peso no planeta Venus é " & (peso * 0.88) & " Kg."
        ElseIf (rbtMarte.Checked) Then
            lblRersultado.Text = "Seu peso no planeta Marte é " & (peso * 0.38) & " Kg."
        ElseIf (rbtJupiter.Checked) Then
            lblRersultado.Text = "Seu peso no planeta Júpiter é " & (peso * 2.26) & " Kg."
        ElseIf (rbtSaturno.Checked) Then
            lblRersultado.Text = "Seu peso no planeta Saturno é " & (peso * 1.15) & " Kg."
        ElseIf (rbtUrano.Checked) Then
            lblRersultado.Text = "Seu peso no planeta Urano é " & (peso * 1.17) & " Kg."
        End If
    End Sub
End Class
