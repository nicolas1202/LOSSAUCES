﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABMPaciente
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
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.grdConsulta = New System.Windows.Forms.DataGridView()
        Me.Legajo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Especialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.grdConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(532, 25)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(135, 20)
        Me.txtBuscar.TabIndex = 10
        '
        'grdConsulta
        '
        Me.grdConsulta.AllowUserToAddRows = False
        Me.grdConsulta.AllowUserToDeleteRows = False
        Me.grdConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Legajo, Me.Nombre, Me.Apellido, Me.Especialidad, Me.Matricula})
        Me.grdConsulta.Location = New System.Drawing.Point(29, 51)
        Me.grdConsulta.Name = "grdConsulta"
        Me.grdConsulta.ReadOnly = True
        Me.grdConsulta.RowHeadersVisible = False
        Me.grdConsulta.Size = New System.Drawing.Size(638, 280)
        Me.grdConsulta.TabIndex = 6
        '
        'Legajo
        '
        Me.Legajo.DataPropertyName = "nroleg"
        Me.Legajo.HeaderText = "Legajo"
        Me.Legajo.Name = "Legajo"
        Me.Legajo.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "nomae"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "apemae"
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Especialidad
        '
        Me.Especialidad.DataPropertyName = "nroesp"
        Me.Especialidad.HeaderText = "Especialidad"
        Me.Especialidad.Name = "Especialidad"
        Me.Especialidad.ReadOnly = True
        '
        'Matricula
        '
        Me.Matricula.DataPropertyName = "nromat"
        Me.Matricula.HeaderText = "Matricula"
        Me.Matricula.Name = "Matricula"
        Me.Matricula.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Los_Sauces.My.Resources.Resources.lupa
        Me.PictureBox1.Location = New System.Drawing.Point(508, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 14)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.MediumPurple
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.Image = Global.Los_Sauces.My.Resources.Resources.remove_male_user_16
        Me.btnEliminar.Location = New System.Drawing.Point(542, 337)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(125, 28)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar doctor"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.MediumPurple
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.Image = Global.Los_Sauces.My.Resources.Resources.editar_user
        Me.btnModificar.Location = New System.Drawing.Point(294, 337)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(125, 28)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "Modificar doctor"
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.MediumPurple
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.Image = Global.Los_Sauces.My.Resources.Resources.agregar_persona
        Me.btnAgregar.Location = New System.Drawing.Point(29, 337)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(125, 28)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar doctor"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'FrmABMPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 388)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.grdConsulta)
        Me.Name = "FrmABMPaciente"
        Me.Text = "FrmABMPaciente"
        CType(Me.grdConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents grdConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents Legajo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Especialidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Matricula As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
