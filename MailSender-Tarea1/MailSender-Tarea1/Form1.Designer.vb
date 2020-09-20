<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MzSombraPanel1 = New MZControls.MZSombraPanel()
        Me.TotalSendSuccess = New System.Windows.Forms.Label()
        Me.TotalSendwithErrors = New System.Windows.Forms.Label()
        Me.labelTotalSends = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_sendEmail = New System.Windows.Forms.Button()
        Me.Emailfield = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MzSombraPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(434, 401)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MzSombraPanel1
        '
        Me.MzSombraPanel1.AddControl = Nothing
        Me.MzSombraPanel1.BackColor = System.Drawing.Color.Transparent
        Me.MzSombraPanel1.Controls.Add(Me.TotalSendSuccess)
        Me.MzSombraPanel1.Controls.Add(Me.TotalSendwithErrors)
        Me.MzSombraPanel1.Controls.Add(Me.labelTotalSends)
        Me.MzSombraPanel1.Controls.Add(Me.Label4)
        Me.MzSombraPanel1.Controls.Add(Me.Label3)
        Me.MzSombraPanel1.Controls.Add(Me.Label2)
        Me.MzSombraPanel1.Controls.Add(Me.btn_sendEmail)
        Me.MzSombraPanel1.Controls.Add(Me.Emailfield)
        Me.MzSombraPanel1.Controls.Add(Me.Label1)
        Me.MzSombraPanel1.Controls.Add(Me.PictureBox2)
        Me.MzSombraPanel1.Location = New System.Drawing.Point(57, 44)
        Me.MzSombraPanel1.Name = "MzSombraPanel1"
        Me.MzSombraPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MzSombraPanel1.Size = New System.Drawing.Size(334, 301)
        Me.MzSombraPanel1.TabIndex = 0
        Me.MzSombraPanel1.TipoDeSombra = MZControls.MZSombraPanel.ShadowsPanel.Nula
        '
        'TotalSendSuccess
        '
        Me.TotalSendSuccess.AutoSize = True
        Me.TotalSendSuccess.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TotalSendSuccess.Location = New System.Drawing.Point(150, 262)
        Me.TotalSendSuccess.Name = "TotalSendSuccess"
        Me.TotalSendSuccess.Size = New System.Drawing.Size(13, 13)
        Me.TotalSendSuccess.TabIndex = 17
        Me.TotalSendSuccess.Text = "0"
        '
        'TotalSendwithErrors
        '
        Me.TotalSendwithErrors.AutoSize = True
        Me.TotalSendwithErrors.ForeColor = System.Drawing.Color.Crimson
        Me.TotalSendwithErrors.Location = New System.Drawing.Point(150, 224)
        Me.TotalSendwithErrors.Name = "TotalSendwithErrors"
        Me.TotalSendwithErrors.Size = New System.Drawing.Size(13, 13)
        Me.TotalSendwithErrors.TabIndex = 16
        Me.TotalSendwithErrors.Text = "0"
        '
        'labelTotalSends
        '
        Me.labelTotalSends.AutoSize = True
        Me.labelTotalSends.ForeColor = System.Drawing.Color.DodgerBlue
        Me.labelTotalSends.Location = New System.Drawing.Point(150, 184)
        Me.labelTotalSends.Name = "labelTotalSends"
        Me.labelTotalSends.Size = New System.Drawing.Size(13, 13)
        Me.labelTotalSends.TabIndex = 15
        Me.labelTotalSends.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Enviados correctamente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Enviados con errores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Correos enviados"
        '
        'btn_sendEmail
        '
        Me.btn_sendEmail.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_sendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sendEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_sendEmail.Location = New System.Drawing.Point(239, 135)
        Me.btn_sendEmail.Name = "btn_sendEmail"
        Me.btn_sendEmail.Size = New System.Drawing.Size(75, 23)
        Me.btn_sendEmail.TabIndex = 11
        Me.btn_sendEmail.Text = "Enviar"
        Me.btn_sendEmail.UseVisualStyleBackColor = False
        '
        'Emailfield
        '
        Me.Emailfield.Location = New System.Drawing.Point(23, 137)
        Me.Emailfield.Name = "Emailfield"
        Me.Emailfield.Size = New System.Drawing.Size(215, 20)
        Me.Emailfield.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Correo electrónico "
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(33, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(265, 66)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(433, 397)
        Me.Controls.Add(Me.MzSombraPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(449, 436)
        Me.MinimumSize = New System.Drawing.Size(449, 436)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pura Vida Paradise"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MzSombraPanel1.ResumeLayout(False)
        Me.MzSombraPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MzSombraPanel1 As MZControls.MZSombraPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TotalSendSuccess As Label
    Friend WithEvents TotalSendwithErrors As Label
    Friend WithEvents labelTotalSends As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_sendEmail As Button
    Friend WithEvents Emailfield As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
