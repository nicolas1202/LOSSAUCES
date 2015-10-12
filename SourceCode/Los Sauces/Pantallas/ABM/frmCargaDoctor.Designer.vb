<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargaDoctor
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscaImg = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.cboxGenero = New System.Windows.Forms.ComboBox()
        Me.btnAddTelefono = New System.Windows.Forms.Button()
        Me.lstTelefonos = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHistoriaClinica = New System.Windows.Forms.TextBox()
        Me.txtNumeroPaciente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Imprint MT Shadow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(829, 37)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Datos Doctor"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Image = Global.Los_Sauces.My.Resources.Resources.tilde
        Me.Button2.Location = New System.Drawing.Point(303, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "&Guardar"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(68, 81)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(255, 20)
        Me.txtDireccion.TabIndex = 49
        '
        'txtApellido
        '
        Me.txtApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtApellido.Location = New System.Drawing.Point(68, 57)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(151, 20)
        Me.txtApellido.TabIndex = 48
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(68, 30)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(151, 20)
        Me.txtNombre.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(7, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Telefonos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(7, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(7, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(7, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Nombre:"
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Image = Global.Los_Sauces.My.Resources.Resources.salir
        Me.Button1.Location = New System.Drawing.Point(753, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 28)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "&Salir"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnBuscaImg)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtTelefono)
        Me.GroupBox2.Controls.Add(Me.cboxGenero)
        Me.GroupBox2.Controls.Add(Me.btnAddTelefono)
        Me.GroupBox2.Controls.Add(Me.lstTelefonos)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtApellido)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(510, 219)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Personales"
        '
        'btnBuscaImg
        '
        Me.btnBuscaImg.Location = New System.Drawing.Point(384, 116)
        Me.btnBuscaImg.Name = "btnBuscaImg"
        Me.btnBuscaImg.Size = New System.Drawing.Size(114, 23)
        Me.btnBuscaImg.TabIndex = 66
        Me.btnBuscaImg.Text = "Seleccionar imagen"
        Me.btnBuscaImg.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Los_Sauces.My.Resources.Resources.People_Doctor_Male_icon
        Me.PictureBox1.Location = New System.Drawing.Point(371, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(241, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Genero:"
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTelefono.Location = New System.Drawing.Point(70, 108)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(109, 20)
        Me.txtTelefono.TabIndex = 52
        '
        'cboxGenero
        '
        Me.cboxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxGenero.FormattingEnabled = True
        Me.cboxGenero.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cboxGenero.Location = New System.Drawing.Point(244, 33)
        Me.cboxGenero.Name = "cboxGenero"
        Me.cboxGenero.Size = New System.Drawing.Size(121, 21)
        Me.cboxGenero.TabIndex = 63
        '
        'btnAddTelefono
        '
        Me.btnAddTelefono.Image = Global.Los_Sauces.My.Resources.Resources.icono_mas
        Me.btnAddTelefono.Location = New System.Drawing.Point(185, 105)
        Me.btnAddTelefono.Name = "btnAddTelefono"
        Me.btnAddTelefono.Size = New System.Drawing.Size(42, 24)
        Me.btnAddTelefono.TabIndex = 51
        Me.btnAddTelefono.UseVisualStyleBackColor = True
        '
        'lstTelefonos
        '
        Me.lstTelefonos.FormattingEnabled = True
        Me.lstTelefonos.Location = New System.Drawing.Point(10, 134)
        Me.lstTelefonos.Name = "lstTelefonos"
        Me.lstTelefonos.Size = New System.Drawing.Size(169, 69)
        Me.lstTelefonos.TabIndex = 50
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 307)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(829, 28)
        Me.Panel1.TabIndex = 57
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.txtHistoriaClinica)
        Me.GroupBox3.Controls.Add(Me.txtNumeroPaciente)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(521, 60)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(299, 183)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Laborales"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(64, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 66
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(16, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Legajo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 53)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horarios"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(164, 23)
        Me.MaskedTextBox2.Mask = "00:00"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(44, 20)
        Me.MaskedTextBox2.TabIndex = 47
        Me.MaskedTextBox2.ValidatingType = GetType(Date)
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(58, 23)
        Me.MaskedTextBox1.Mask = "00:00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(44, 20)
        Me.MaskedTextBox1.TabIndex = 46
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(117, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Hasta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(11, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Desde:"
        '
        'txtHistoriaClinica
        '
        Me.txtHistoriaClinica.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtHistoriaClinica.Location = New System.Drawing.Point(131, 131)
        Me.txtHistoriaClinica.Name = "txtHistoriaClinica"
        Me.txtHistoriaClinica.Size = New System.Drawing.Size(100, 20)
        Me.txtHistoriaClinica.TabIndex = 63
        '
        'txtNumeroPaciente
        '
        Me.txtNumeroPaciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNumeroPaciente.Location = New System.Drawing.Point(17, 131)
        Me.txtNumeroPaciente.Name = "txtNumeroPaciente"
        Me.txtNumeroPaciente.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroPaciente.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(17, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Matricula Profesional"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(128, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Especialidad"
        '
        'FrmCargaDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Los_Sauces.My.Resources.Resources.FondoVerde00
        Me.ClientSize = New System.Drawing.Size(829, 335)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmCargaDoctor"
        Me.Text = "frmCargaDoctor"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstTelefonos As System.Windows.Forms.ListBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents btnAddTelefono As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtHistoriaClinica As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroPaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboxGenero As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscaImg As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
