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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureOffline = New System.Windows.Forms.PictureBox()
        Me.onlinePicture = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureOffline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.onlinePicture, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TotalSendSuccess)
        Me.Panel1.Controls.Add(Me.TotalSendwithErrors)
        Me.Panel1.Controls.Add(Me.labelTotalSends)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_sendEmail)
        Me.Panel1.Controls.Add(Me.Emailfield)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(38, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(358, 321)
        Me.Panel1.TabIndex = 1
        '
        'TotalSendSuccess
        '
        Me.TotalSendSuccess.AutoSize = True
        Me.TotalSendSuccess.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TotalSendSuccess.Location = New System.Drawing.Point(166, 261)
        Me.TotalSendSuccess.Name = "TotalSendSuccess"
        Me.TotalSendSuccess.Size = New System.Drawing.Size(13, 13)
        Me.TotalSendSuccess.TabIndex = 27
        Me.TotalSendSuccess.Text = "0"
        '
        'TotalSendwithErrors
        '
        Me.TotalSendwithErrors.AutoSize = True
        Me.TotalSendwithErrors.ForeColor = System.Drawing.Color.Crimson
        Me.TotalSendwithErrors.Location = New System.Drawing.Point(166, 223)
        Me.TotalSendwithErrors.Name = "TotalSendwithErrors"
        Me.TotalSendwithErrors.Size = New System.Drawing.Size(13, 13)
        Me.TotalSendwithErrors.TabIndex = 26
        Me.TotalSendwithErrors.Text = "0"
        '
        'labelTotalSends
        '
        Me.labelTotalSends.AutoSize = True
        Me.labelTotalSends.ForeColor = System.Drawing.Color.DodgerBlue
        Me.labelTotalSends.Location = New System.Drawing.Point(166, 183)
        Me.labelTotalSends.Name = "labelTotalSends"
        Me.labelTotalSends.Size = New System.Drawing.Size(13, 13)
        Me.labelTotalSends.TabIndex = 25
        Me.labelTotalSends.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Enviados correctamente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Enviados con errores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Correos enviados"
        '
        'btn_sendEmail
        '
        Me.btn_sendEmail.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_sendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sendEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_sendEmail.Location = New System.Drawing.Point(255, 134)
        Me.btn_sendEmail.Name = "btn_sendEmail"
        Me.btn_sendEmail.Size = New System.Drawing.Size(75, 23)
        Me.btn_sendEmail.TabIndex = 21
        Me.btn_sendEmail.Text = "Enviar"
        Me.btn_sendEmail.UseVisualStyleBackColor = False
        '
        'Emailfield
        '
        Me.Emailfield.Location = New System.Drawing.Point(39, 136)
        Me.Emailfield.Name = "Emailfield"
        Me.Emailfield.Size = New System.Drawing.Size(215, 20)
        Me.Emailfield.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Correo electrónico "
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(49, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(265, 66)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.PictureOffline)
        Me.Panel2.Controls.Add(Me.onlinePicture)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(-1, 371)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(435, 29)
        Me.Panel2.TabIndex = 28
        '
        'PictureOffline
        '
        Me.PictureOffline.Image = CType(resources.GetObject("PictureOffline.Image"), System.Drawing.Image)
        Me.PictureOffline.Location = New System.Drawing.Point(6, 1)
        Me.PictureOffline.Name = "PictureOffline"
        Me.PictureOffline.Size = New System.Drawing.Size(29, 25)
        Me.PictureOffline.TabIndex = 2
        Me.PictureOffline.TabStop = False
        Me.PictureOffline.Visible = False
        '
        'onlinePicture
        '
        Me.onlinePicture.Image = CType(resources.GetObject("onlinePicture.Image"), System.Drawing.Image)
        Me.onlinePicture.Location = New System.Drawing.Point(5, 1)
        Me.onlinePicture.Name = "onlinePicture"
        Me.onlinePicture.Size = New System.Drawing.Size(30, 30)
        Me.onlinePicture.TabIndex = 1
        Me.onlinePicture.TabStop = False
        Me.onlinePicture.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Detectando red..."
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(265, 7)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(88, 13)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Volver a detectar"
        Me.LinkLabel1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(433, 397)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(449, 436)
        Me.MinimumSize = New System.Drawing.Size(449, 436)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pura Vida Paradise"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureOffline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.onlinePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TotalSendSuccess As Label
    Friend WithEvents TotalSendwithErrors As Label
    Friend WithEvents labelTotalSends As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_sendEmail As Button
    Friend WithEvents Emailfield As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents onlinePicture As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureOffline As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
