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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarTelefono = New System.Windows.Forms.Button()
        Me.btnBuscaImg = New System.Windows.Forms.Button()
        Me.pboxPerfil = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.cboxGenero = New System.Windows.Forms.ComboBox()
        Me.btnAgregarTelefono = New System.Windows.Forms.Button()
        Me.lstTelefonos = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtLegajo = New System.Windows.Forms.TextBox()
        Me.cboxEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHastaHorario = New System.Windows.Forms.MaskedTextBox()
        Me.txtDesdeHorario = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumeroPaciente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCodPostal = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pboxPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
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
        'btnGuardar
        '
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnGuardar.Image = Global.Los_Sauces.My.Resources.Resources.tilde
        Me.btnGuardar.Location = New System.Drawing.Point(427, 354)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(88, 32)
        Me.btnGuardar.TabIndex = 54
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(68, 57)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(151, 20)
        Me.txtApellido.TabIndex = 48
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(68, 30)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(151, 20)
        Me.txtNombre.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(7, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Telefonos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(7, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Calle:"
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
        'btnSalir
        '
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSalir.Image = Global.Los_Sauces.My.Resources.Resources.salir
        Me.btnSalir.Location = New System.Drawing.Point(753, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(76, 28)
        Me.btnSalir.TabIndex = 39
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.btnEliminarTelefono)
        Me.GroupBox2.Controls.Add(Me.btnBuscaImg)
        Me.GroupBox2.Controls.Add(Me.pboxPerfil)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtTelefono)
        Me.GroupBox2.Controls.Add(Me.cboxGenero)
        Me.GroupBox2.Controls.Add(Me.btnAgregarTelefono)
        Me.GroupBox2.Controls.Add(Me.lstTelefonos)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtApellido)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(510, 308)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Personales"
        '
        'btnEliminarTelefono
        '
        Me.btnEliminarTelefono.Image = Global.Los_Sauces.My.Resources.Resources.icono_eliminar
        Me.btnEliminarTelefono.Location = New System.Drawing.Point(185, 230)
        Me.btnEliminarTelefono.Name = "btnEliminarTelefono"
        Me.btnEliminarTelefono.Size = New System.Drawing.Size(42, 24)
        Me.btnEliminarTelefono.TabIndex = 67
        Me.btnEliminarTelefono.UseVisualStyleBackColor = True
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
        'pboxPerfil
        '
        Me.pboxPerfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pboxPerfil.ErrorImage = Global.Los_Sauces.My.Resources.Resources.People_Doctor_Male_icon
        Me.pboxPerfil.Image = Global.Los_Sauces.My.Resources.Resources.People_Doctor_Male_icon
        Me.pboxPerfil.InitialImage = Global.Los_Sauces.My.Resources.Resources.People_Doctor_Male_icon
        Me.pboxPerfil.Location = New System.Drawing.Point(371, 19)
        Me.pboxPerfil.Name = "pboxPerfil"
        Me.pboxPerfil.Size = New System.Drawing.Size(127, 91)
        Me.pboxPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxPerfil.TabIndex = 65
        Me.pboxPerfil.TabStop = False
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
        Me.txtTelefono.Location = New System.Drawing.Point(70, 203)
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
        'btnAgregarTelefono
        '
        Me.btnAgregarTelefono.Image = Global.Los_Sauces.My.Resources.Resources.add
        Me.btnAgregarTelefono.Location = New System.Drawing.Point(185, 200)
        Me.btnAgregarTelefono.Name = "btnAgregarTelefono"
        Me.btnAgregarTelefono.Size = New System.Drawing.Size(42, 24)
        Me.btnAgregarTelefono.TabIndex = 51
        Me.btnAgregarTelefono.UseVisualStyleBackColor = True
        '
        'lstTelefonos
        '
        Me.lstTelefonos.FormattingEnabled = True
        Me.lstTelefonos.Location = New System.Drawing.Point(10, 229)
        Me.lstTelefonos.Name = "lstTelefonos"
        Me.lstTelefonos.Size = New System.Drawing.Size(169, 69)
        Me.lstTelefonos.TabIndex = 50
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 399)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(829, 28)
        Me.Panel1.TabIndex = 57
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtLegajo)
        Me.GroupBox3.Controls.Add(Me.cboxEspecialidad)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.txtNumeroPaciente)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(521, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(299, 179)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Laborales"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(137, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Especialidad:"
        '
        'txtLegajo
        '
        Me.txtLegajo.Location = New System.Drawing.Point(64, 19)
        Me.txtLegajo.Name = "txtLegajo"
        Me.txtLegajo.ReadOnly = True
        Me.txtLegajo.Size = New System.Drawing.Size(100, 20)
        Me.txtLegajo.TabIndex = 66
        '
        'cboxEspecialidad
        '
        Me.cboxEspecialidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboxEspecialidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboxEspecialidad.FormattingEnabled = True
        Me.cboxEspecialidad.Location = New System.Drawing.Point(138, 135)
        Me.cboxEspecialidad.Name = "cboxEspecialidad"
        Me.cboxEspecialidad.Size = New System.Drawing.Size(155, 21)
        Me.cboxEspecialidad.TabIndex = 68
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
        Me.GroupBox1.Controls.Add(Me.txtHastaHorario)
        Me.GroupBox1.Controls.Add(Me.txtDesdeHorario)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 53)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horarios"
        '
        'txtHastaHorario
        '
        Me.txtHastaHorario.Location = New System.Drawing.Point(164, 23)
        Me.txtHastaHorario.Mask = "00:00"
        Me.txtHastaHorario.Name = "txtHastaHorario"
        Me.txtHastaHorario.Size = New System.Drawing.Size(44, 20)
        Me.txtHastaHorario.TabIndex = 47
        Me.txtHastaHorario.ValidatingType = GetType(Date)
        '
        'txtDesdeHorario
        '
        Me.txtDesdeHorario.Location = New System.Drawing.Point(58, 23)
        Me.txtDesdeHorario.Mask = "00:00"
        Me.txtDesdeHorario.Name = "txtDesdeHorario"
        Me.txtDesdeHorario.Size = New System.Drawing.Size(44, 20)
        Me.txtDesdeHorario.TabIndex = 46
        Me.txtDesdeHorario.ValidatingType = GetType(Date)
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
        'txtNumeroPaciente
        '
        Me.txtNumeroPaciente.Location = New System.Drawing.Point(20, 136)
        Me.txtNumeroPaciente.Name = "txtNumeroPaciente"
        Me.txtNumeroPaciente.Size = New System.Drawing.Size(102, 20)
        Me.txtNumeroPaciente.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(16, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Matricula Profesional:"
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(46, 24)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(179, 20)
        Me.txtCalle.TabIndex = 68
        '
        'txtNro
        '
        Me.txtNro.Location = New System.Drawing.Point(274, 24)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(56, 20)
        Me.txtNro.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(241, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Nro:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtCodPostal)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtPais)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtProvincia)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtLocalidad)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtCalle)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtNro)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 83)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(355, 112)
        Me.GroupBox4.TabIndex = 71
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dirección"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(69, 54)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(98, 20)
        Me.txtLocalidad.TabIndex = 72
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(7, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Localidad:"
        '
        'txtProvincia
        '
        Me.txtProvincia.Location = New System.Drawing.Point(234, 54)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(98, 20)
        Me.txtProvincia.TabIndex = 74
        Me.txtProvincia.Text = "Mendoza"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(172, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Provincia:"
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(69, 80)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(98, 20)
        Me.txtPais.TabIndex = 78
        Me.txtPais.Text = "Argentina"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(7, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "Pais:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(173, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 13)
        Me.Label16.TabIndex = 79
        Me.Label16.Text = "CodPostal:"
        '
        'txtCodPostal
        '
        Me.txtCodPostal.Location = New System.Drawing.Point(234, 80)
        Me.txtCodPostal.Name = "txtCodPostal"
        Me.txtCodPostal.Size = New System.Drawing.Size(98, 20)
        Me.txtCodPostal.TabIndex = 80
        '
        'FrmCargaDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Los_Sauces.My.Resources.Resources.FondoVerde00
        Me.ClientSize = New System.Drawing.Size(829, 427)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmCargaDoctor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmCargaDoctor"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pboxPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstTelefonos As System.Windows.Forms.ListBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarTelefono As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLegajo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHastaHorario As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDesdeHorario As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboxGenero As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscaImg As System.Windows.Forms.Button
    Friend WithEvents pboxPerfil As System.Windows.Forms.PictureBox
    Friend WithEvents btnEliminarTelefono As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboxEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPais As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtProvincia As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNro As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPostal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
