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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnSimular = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnRojo1 = New System.Windows.Forms.Button()
        Me.btnAmarillo1 = New System.Windows.Forms.Button()
        Me.btnVerde1 = New System.Windows.Forms.Button()
        Me.btnVerde2 = New System.Windows.Forms.Button()
        Me.btnAmarillo2 = New System.Windows.Forms.Button()
        Me.btnRojo2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picAuto1 = New System.Windows.Forms.PictureBox()
        Me.timerAutos = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAuto1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(46, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "PATRULLA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(127, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "BOMBERO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(208, 83)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "AMBULANCIA"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnSimular
        '
        Me.btnSimular.Location = New System.Drawing.Point(127, 54)
        Me.btnSimular.Name = "btnSimular"
        Me.btnSimular.Size = New System.Drawing.Size(75, 23)
        Me.btnSimular.TabIndex = 3
        Me.btnSimular.Text = "SIMULAR"
        Me.btnSimular.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(127, 112)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "SALIR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(710, 180)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'btnRojo1
        '
        Me.btnRojo1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRojo1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRojo1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRojo1.Location = New System.Drawing.Point(733, 192)
        Me.btnRojo1.Name = "btnRojo1"
        Me.btnRojo1.Size = New System.Drawing.Size(20, 21)
        Me.btnRojo1.TabIndex = 7
        Me.btnRojo1.UseVisualStyleBackColor = False
        '
        'btnAmarillo1
        '
        Me.btnAmarillo1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAmarillo1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAmarillo1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAmarillo1.Location = New System.Drawing.Point(733, 219)
        Me.btnAmarillo1.Name = "btnAmarillo1"
        Me.btnAmarillo1.Size = New System.Drawing.Size(20, 21)
        Me.btnAmarillo1.TabIndex = 8
        Me.btnAmarillo1.UseVisualStyleBackColor = False
        '
        'btnVerde1
        '
        Me.btnVerde1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVerde1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVerde1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVerde1.Location = New System.Drawing.Point(733, 246)
        Me.btnVerde1.Name = "btnVerde1"
        Me.btnVerde1.Size = New System.Drawing.Size(20, 21)
        Me.btnVerde1.TabIndex = 9
        Me.btnVerde1.UseVisualStyleBackColor = False
        '
        'btnVerde2
        '
        Me.btnVerde2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVerde2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVerde2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVerde2.Location = New System.Drawing.Point(550, 454)
        Me.btnVerde2.Name = "btnVerde2"
        Me.btnVerde2.Size = New System.Drawing.Size(20, 21)
        Me.btnVerde2.TabIndex = 13
        Me.btnVerde2.UseVisualStyleBackColor = False
        '
        'btnAmarillo2
        '
        Me.btnAmarillo2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAmarillo2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAmarillo2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAmarillo2.Location = New System.Drawing.Point(550, 427)
        Me.btnAmarillo2.Name = "btnAmarillo2"
        Me.btnAmarillo2.Size = New System.Drawing.Size(20, 21)
        Me.btnAmarillo2.TabIndex = 12
        Me.btnAmarillo2.UseVisualStyleBackColor = False
        '
        'btnRojo2
        '
        Me.btnRojo2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRojo2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRojo2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRojo2.Location = New System.Drawing.Point(550, 400)
        Me.btnRojo2.Name = "btnRojo2"
        Me.btnRojo2.Size = New System.Drawing.Size(20, 21)
        Me.btnRojo2.TabIndex = 11
        Me.btnRojo2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(527, 388)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(67, 97)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'picAuto1
        '
        Me.picAuto1.BackColor = System.Drawing.Color.Transparent
        Me.picAuto1.Image = CType(resources.GetObject("picAuto1.Image"), System.Drawing.Image)
        Me.picAuto1.Location = New System.Drawing.Point(-100, 323)
        Me.picAuto1.Name = "picAuto1"
        Me.picAuto1.Size = New System.Drawing.Size(128, 62)
        Me.picAuto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAuto1.TabIndex = 14
        Me.picAuto1.TabStop = False
        '
        'timerAutos
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(821, 587)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1304, 702)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picAuto1)
        Me.Controls.Add(Me.btnVerde2)
        Me.Controls.Add(Me.btnAmarillo2)
        Me.Controls.Add(Me.btnRojo2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnVerde1)
        Me.Controls.Add(Me.btnAmarillo1)
        Me.Controls.Add(Me.btnRojo1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnSimular)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAuto1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnSimular As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnRojo1 As Button
    Friend WithEvents btnAmarillo1 As Button
    Friend WithEvents btnVerde1 As Button
    Friend WithEvents btnVerde2 As Button
    Friend WithEvents btnAmarillo2 As Button
    Friend WithEvents btnRojo2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents picAuto1 As PictureBox
    Friend WithEvents timerAutos As Timer
    Friend WithEvents Label1 As Label
End Class
