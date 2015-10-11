<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargaDatos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCargarDatos = New System.Windows.Forms.Button()
        Me.rBtnPaciente = New System.Windows.Forms.RadioButton()
        Me.rBtnDoctor = New System.Windows.Forms.RadioButton()
        Me.rBtnEnfermero = New System.Windows.Forms.RadioButton()
        Me.rBtnParamedico = New System.Windows.Forms.RadioButton()
        Me.rBtnTurno = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione opcion para cargar datos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Volver a Menu Principal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCargarDatos
        '
        Me.btnCargarDatos.Location = New System.Drawing.Point(41, 299)
        Me.btnCargarDatos.Name = "btnCargarDatos"
        Me.btnCargarDatos.Size = New System.Drawing.Size(97, 29)
        Me.btnCargarDatos.TabIndex = 4
        Me.btnCargarDatos.Text = "Cargar datos"
        Me.btnCargarDatos.UseVisualStyleBackColor = True
        '
        'rBtnPaciente
        '
        Me.rBtnPaciente.AutoSize = True
        Me.rBtnPaciente.Location = New System.Drawing.Point(41, 171)
        Me.rBtnPaciente.Name = "rBtnPaciente"
        Me.rBtnPaciente.Size = New System.Drawing.Size(67, 17)
        Me.rBtnPaciente.TabIndex = 10
        Me.rBtnPaciente.TabStop = True
        Me.rBtnPaciente.Text = "Paciente"
        Me.rBtnPaciente.UseVisualStyleBackColor = True
        '
        'rBtnDoctor
        '
        Me.rBtnDoctor.AutoSize = True
        Me.rBtnDoctor.Location = New System.Drawing.Point(41, 195)
        Me.rBtnDoctor.Name = "rBtnDoctor"
        Me.rBtnDoctor.Size = New System.Drawing.Size(57, 17)
        Me.rBtnDoctor.TabIndex = 11
        Me.rBtnDoctor.TabStop = True
        Me.rBtnDoctor.Text = "Doctor"
        Me.rBtnDoctor.UseVisualStyleBackColor = True
        '
        'rBtnEnfermero
        '
        Me.rBtnEnfermero.AutoSize = True
        Me.rBtnEnfermero.Location = New System.Drawing.Point(41, 219)
        Me.rBtnEnfermero.Name = "rBtnEnfermero"
        Me.rBtnEnfermero.Size = New System.Drawing.Size(73, 17)
        Me.rBtnEnfermero.TabIndex = 12
        Me.rBtnEnfermero.TabStop = True
        Me.rBtnEnfermero.Text = "Enfermero"
        Me.rBtnEnfermero.UseVisualStyleBackColor = True
        '
        'rBtnParamedico
        '
        Me.rBtnParamedico.AutoSize = True
        Me.rBtnParamedico.Location = New System.Drawing.Point(41, 243)
        Me.rBtnParamedico.Name = "rBtnParamedico"
        Me.rBtnParamedico.Size = New System.Drawing.Size(81, 17)
        Me.rBtnParamedico.TabIndex = 13
        Me.rBtnParamedico.TabStop = True
        Me.rBtnParamedico.Text = "Paramedico"
        Me.rBtnParamedico.UseVisualStyleBackColor = True
        '
        'rBtnTurno
        '
        Me.rBtnTurno.AutoSize = True
        Me.rBtnTurno.Location = New System.Drawing.Point(41, 267)
        Me.rBtnTurno.Name = "rBtnTurno"
        Me.rBtnTurno.Size = New System.Drawing.Size(53, 17)
        Me.rBtnTurno.TabIndex = 14
        Me.rBtnTurno.TabStop = True
        Me.rBtnTurno.Text = "Turno"
        Me.rBtnTurno.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Los_Sauces.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CargaDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(623, 494)
        Me.Controls.Add(Me.rBtnTurno)
        Me.Controls.Add(Me.rBtnParamedico)
        Me.Controls.Add(Me.rBtnEnfermero)
        Me.Controls.Add(Me.rBtnDoctor)
        Me.Controls.Add(Me.rBtnPaciente)
        Me.Controls.Add(Me.btnCargarDatos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "CargaDatos"
        Me.Text = "Los Sauces - Cargar datos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnCargarDatos As System.Windows.Forms.Button
    Friend WithEvents rBtnPaciente As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnDoctor As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnEnfermero As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnParamedico As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnTurno As System.Windows.Forms.RadioButton
End Class
