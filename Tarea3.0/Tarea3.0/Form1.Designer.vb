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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.EfectivoText = New System.Windows.Forms.TextBox()
        Me.OtrosBancosText = New System.Windows.Forms.TextBox()
        Me.ChequePropioText = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChequesPropios = New System.Windows.Forms.CheckBox()
        Me.ChequeBancos = New System.Windows.Forms.CheckBox()
        Me.Efectivo = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Monetarios = New System.Windows.Forms.RadioButton()
        Me.MonetariosPremier = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.SaldoActualText = New System.Windows.Forms.TextBox()
        Me.SaldoTotalText = New System.Windows.Forms.TextBox()
        Me.InteresText = New System.Windows.Forms.TextBox()
        Me.SaldoParcialText = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox3.Controls.Add(Me.EfectivoText)
        Me.GroupBox3.Controls.Add(Me.OtrosBancosText)
        Me.GroupBox3.Controls.Add(Me.ChequePropioText)
        Me.GroupBox3.Location = New System.Drawing.Point(474, 73)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Monto a depositar"
        '
        'EfectivoText
        '
        Me.EfectivoText.Enabled = False
        Me.EfectivoText.Location = New System.Drawing.Point(6, 67)
        Me.EfectivoText.Name = "EfectivoText"
        Me.EfectivoText.Size = New System.Drawing.Size(100, 23)
        Me.EfectivoText.TabIndex = 4
        '
        'OtrosBancosText
        '
        Me.OtrosBancosText.Enabled = False
        Me.OtrosBancosText.Location = New System.Drawing.Point(6, 42)
        Me.OtrosBancosText.Name = "OtrosBancosText"
        Me.OtrosBancosText.Size = New System.Drawing.Size(100, 23)
        Me.OtrosBancosText.TabIndex = 3
        '
        'ChequePropioText
        '
        Me.ChequePropioText.Enabled = False
        Me.ChequePropioText.Location = New System.Drawing.Point(6, 18)
        Me.ChequePropioText.Name = "ChequePropioText"
        Me.ChequePropioText.Size = New System.Drawing.Size(100, 23)
        Me.ChequePropioText.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.NavajoWhite
        Me.GroupBox2.Controls.Add(Me.ChequesPropios)
        Me.GroupBox2.Controls.Add(Me.ChequeBancos)
        Me.GroupBox2.Controls.Add(Me.Efectivo)
        Me.GroupBox2.Location = New System.Drawing.Point(248, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Pago"
        '
        'ChequesPropios
        '
        Me.ChequesPropios.AutoSize = True
        Me.ChequesPropios.Location = New System.Drawing.Point(7, 22)
        Me.ChequesPropios.Name = "ChequesPropios"
        Me.ChequesPropios.Size = New System.Drawing.Size(115, 19)
        Me.ChequesPropios.TabIndex = 7
        Me.ChequesPropios.Text = "Cheques Propios"
        Me.ChequesPropios.UseVisualStyleBackColor = True
        '
        'ChequeBancos
        '
        Me.ChequeBancos.AutoSize = True
        Me.ChequeBancos.Location = New System.Drawing.Point(7, 46)
        Me.ChequeBancos.Name = "ChequeBancos"
        Me.ChequeBancos.Size = New System.Drawing.Size(161, 19)
        Me.ChequeBancos.TabIndex = 8
        Me.ChequeBancos.Text = "Cheques de Otros bancos"
        Me.ChequeBancos.UseVisualStyleBackColor = True
        '
        'Efectivo
        '
        Me.Efectivo.AutoSize = True
        Me.Efectivo.Location = New System.Drawing.Point(7, 69)
        Me.Efectivo.Name = "Efectivo"
        Me.Efectivo.Size = New System.Drawing.Size(68, 19)
        Me.Efectivo.TabIndex = 9
        Me.Efectivo.Text = "Efectivo"
        Me.Efectivo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox1.Controls.Add(Me.Monetarios)
        Me.GroupBox1.Controls.Add(Me.MonetariosPremier)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de depósito"
        '
        'Monetarios
        '
        Me.Monetarios.AutoSize = True
        Me.Monetarios.Location = New System.Drawing.Point(9, 22)
        Me.Monetarios.Name = "Monetarios"
        Me.Monetarios.Size = New System.Drawing.Size(85, 19)
        Me.Monetarios.TabIndex = 0
        Me.Monetarios.TabStop = True
        Me.Monetarios.Text = "Monetarios"
        Me.Monetarios.UseVisualStyleBackColor = True
        '
        'MonetariosPremier
        '
        Me.MonetariosPremier.AutoSize = True
        Me.MonetariosPremier.Location = New System.Drawing.Point(9, 47)
        Me.MonetariosPremier.Name = "MonetariosPremier"
        Me.MonetariosPremier.Size = New System.Drawing.Size(129, 19)
        Me.MonetariosPremier.TabIndex = 3
        Me.MonetariosPremier.TabStop = True
        Me.MonetariosPremier.Text = "Monetarios Premier"
        Me.MonetariosPremier.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(9, 72)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(67, 19)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Ahorros"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'SaldoActualText
        '
        Me.SaldoActualText.Location = New System.Drawing.Point(169, 14)
        Me.SaldoActualText.Name = "SaldoActualText"
        Me.SaldoActualText.Size = New System.Drawing.Size(100, 23)
        Me.SaldoActualText.TabIndex = 31
        '
        'SaldoTotalText
        '
        Me.SaldoTotalText.Location = New System.Drawing.Point(357, 280)
        Me.SaldoTotalText.Name = "SaldoTotalText"
        Me.SaldoTotalText.Size = New System.Drawing.Size(100, 23)
        Me.SaldoTotalText.TabIndex = 30
        '
        'InteresText
        '
        Me.InteresText.Location = New System.Drawing.Point(194, 281)
        Me.InteresText.Name = "InteresText"
        Me.InteresText.Size = New System.Drawing.Size(100, 23)
        Me.InteresText.TabIndex = 29
        '
        'SaldoParcialText
        '
        Me.SaldoParcialText.Location = New System.Drawing.Point(59, 282)
        Me.SaldoParcialText.Name = "SaldoParcialText"
        Me.SaldoParcialText.Size = New System.Drawing.Size(100, 23)
        Me.SaldoParcialText.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 15)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Saldo actual"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(357, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Saldo total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(194, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 15)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Interés"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Saldo parcial"
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(194, 219)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 23
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(599, 282)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(599, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 350)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SaldoActualText)
        Me.Controls.Add(Me.SaldoTotalText)
        Me.Controls.Add(Me.InteresText)
        Me.Controls.Add(Me.SaldoParcialText)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents EfectivoText As TextBox
    Friend WithEvents OtrosBancosText As TextBox
    Friend WithEvents ChequePropioText As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ChequesPropios As CheckBox
    Friend WithEvents ChequeBancos As CheckBox
    Friend WithEvents Efectivo As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Monetarios As RadioButton
    Friend WithEvents MonetariosPremier As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents SaldoActualText As TextBox
    Friend WithEvents SaldoTotalText As TextBox
    Friend WithEvents InteresText As TextBox
    Friend WithEvents SaldoParcialText As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Calcular As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
