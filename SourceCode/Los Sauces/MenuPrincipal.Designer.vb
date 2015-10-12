<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnInformes = New System.Windows.Forms.Button()
        Me.btnVolverPortada = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(82, 265)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(168, 39)
        Me.btnCargar.TabIndex = 1
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(128, 310)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(168, 43)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(128, 396)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(168, 41)
        Me.btnBorrar.TabIndex = 3
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(452, 226)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(169, 40)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnInformes
        '
        Me.btnInformes.Location = New System.Drawing.Point(452, 310)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(169, 43)
        Me.btnInformes.TabIndex = 5
        Me.btnInformes.Text = "Informes"
        Me.btnInformes.UseVisualStyleBackColor = True
        '
        'btnVolverPortada
        '
        Me.btnVolverPortada.Location = New System.Drawing.Point(452, 396)
        Me.btnVolverPortada.Name = "btnVolverPortada"
        Me.btnVolverPortada.Size = New System.Drawing.Size(169, 41)
        Me.btnVolverPortada.TabIndex = 6
        Me.btnVolverPortada.Text = "Volver a portada"
        Me.btnVolverPortada.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(322, 464)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(106, 38)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(82, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 39)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Doctor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Los_Sauces.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(786, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(785, 575)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVolverPortada)
        Me.Controls.Add(Me.btnInformes)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Los Sauces - Menu Principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnInformes As System.Windows.Forms.Button
    Friend WithEvents btnVolverPortada As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
