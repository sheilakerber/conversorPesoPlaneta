<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.rbtMercurio = New System.Windows.Forms.RadioButton()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.rbtUrano = New System.Windows.Forms.RadioButton()
        Me.rbtSaturno = New System.Windows.Forms.RadioButton()
        Me.rbtJupiter = New System.Windows.Forms.RadioButton()
        Me.rbtMarte = New System.Windows.Forms.RadioButton()
        Me.rbtVenus = New System.Windows.Forms.RadioButton()
        Me.lblRersultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(143, 278)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'rbtMercurio
        '
        Me.rbtMercurio.AutoSize = True
        Me.rbtMercurio.Location = New System.Drawing.Point(158, 104)
        Me.rbtMercurio.Name = "rbtMercurio"
        Me.rbtMercurio.Size = New System.Drawing.Size(73, 19)
        Me.rbtMercurio.TabIndex = 1
        Me.rbtMercurio.TabStop = True
        Me.rbtMercurio.Text = "Mercúrio"
        Me.rbtMercurio.UseVisualStyleBackColor = True
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(117, 65)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(150, 23)
        Me.txtPeso.TabIndex = 2
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(76, 68)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(35, 15)
        Me.lblPeso.TabIndex = 3
        Me.lblPeso.Text = "Peso:"
        '
        'rbtUrano
        '
        Me.rbtUrano.AutoSize = True
        Me.rbtUrano.Location = New System.Drawing.Point(158, 229)
        Me.rbtUrano.Name = "rbtUrano"
        Me.rbtUrano.Size = New System.Drawing.Size(57, 19)
        Me.rbtUrano.TabIndex = 4
        Me.rbtUrano.TabStop = True
        Me.rbtUrano.Text = "Urano"
        Me.rbtUrano.UseVisualStyleBackColor = True
        '
        'rbtSaturno
        '
        Me.rbtSaturno.AutoSize = True
        Me.rbtSaturno.Location = New System.Drawing.Point(158, 204)
        Me.rbtSaturno.Name = "rbtSaturno"
        Me.rbtSaturno.Size = New System.Drawing.Size(66, 19)
        Me.rbtSaturno.TabIndex = 5
        Me.rbtSaturno.TabStop = True
        Me.rbtSaturno.Text = "Saturno"
        Me.rbtSaturno.UseVisualStyleBackColor = True
        '
        'rbtJupiter
        '
        Me.rbtJupiter.AutoSize = True
        Me.rbtJupiter.Location = New System.Drawing.Point(158, 179)
        Me.rbtJupiter.Name = "rbtJupiter"
        Me.rbtJupiter.Size = New System.Drawing.Size(60, 19)
        Me.rbtJupiter.TabIndex = 6
        Me.rbtJupiter.TabStop = True
        Me.rbtJupiter.Text = "Jupíter"
        Me.rbtJupiter.UseVisualStyleBackColor = True
        '
        'rbtMarte
        '
        Me.rbtMarte.AutoSize = True
        Me.rbtMarte.Location = New System.Drawing.Point(158, 154)
        Me.rbtMarte.Name = "rbtMarte"
        Me.rbtMarte.Size = New System.Drawing.Size(56, 19)
        Me.rbtMarte.TabIndex = 7
        Me.rbtMarte.TabStop = True
        Me.rbtMarte.Text = "Marte"
        Me.rbtMarte.UseVisualStyleBackColor = True
        '
        'rbtVenus
        '
        Me.rbtVenus.AutoSize = True
        Me.rbtVenus.Location = New System.Drawing.Point(158, 129)
        Me.rbtVenus.Name = "rbtVenus"
        Me.rbtVenus.Size = New System.Drawing.Size(56, 19)
        Me.rbtVenus.TabIndex = 8
        Me.rbtVenus.TabStop = True
        Me.rbtVenus.Text = "Venus"
        Me.rbtVenus.UseVisualStyleBackColor = True
        '
        'lblRersultado
        '
        Me.lblRersultado.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRersultado.Location = New System.Drawing.Point(24, 352)
        Me.lblRersultado.Name = "lblRersultado"
        Me.lblRersultado.Size = New System.Drawing.Size(291, 21)
        Me.lblRersultado.TabIndex = 9
        Me.lblRersultado.Text = "Seu resultado aparecerá aqui!"
        Me.lblRersultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 428)
        Me.Controls.Add(Me.lblRersultado)
        Me.Controls.Add(Me.rbtVenus)
        Me.Controls.Add(Me.rbtMarte)
        Me.Controls.Add(Me.rbtJupiter)
        Me.Controls.Add(Me.rbtSaturno)
        Me.Controls.Add(Me.rbtUrano)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.rbtMercurio)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "Form1"
        Me.Text = "Conversor - Peso X Planeta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents rbtMercurio As RadioButton
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents lblPeso As Label
    Friend WithEvents rbtUrano As RadioButton
    Friend WithEvents rbtSaturno As RadioButton
    Friend WithEvents rbtJupiter As RadioButton
    Friend WithEvents rbtMarte As RadioButton
    Friend WithEvents rbtVenus As RadioButton
    Friend WithEvents lblRersultado As Label
End Class
