<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroEventos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nombreEventoTextbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.descripcionEventoTextbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fechaInicioDateTime = New System.Windows.Forms.DateTimePicker()
        Me.fechaFinDateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.horaInicioTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.horaFinTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.capcidadPersonasTextbox = New System.Windows.Forms.TextBox()
        Me.seccionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.SeccionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacidadColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.seccionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(355, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de Eventos"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(433, 432)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(94, 29)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre"
        '
        'nombreEventoTextbox
        '
        Me.nombreEventoTextbox.Location = New System.Drawing.Point(36, 108)
        Me.nombreEventoTextbox.Name = "nombreEventoTextbox"
        Me.nombreEventoTextbox.Size = New System.Drawing.Size(264, 27)
        Me.nombreEventoTextbox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripcion"
        '
        'descripcionEventoTextbox
        '
        Me.descripcionEventoTextbox.Location = New System.Drawing.Point(36, 168)
        Me.descripcionEventoTextbox.Multiline = True
        Me.descripcionEventoTextbox.Name = "descripcionEventoTextbox"
        Me.descripcionEventoTextbox.Size = New System.Drawing.Size(264, 195)
        Me.descripcionEventoTextbox.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha de Inicio"
        '
        'fechaInicioDateTime
        '
        Me.fechaInicioDateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaInicioDateTime.Location = New System.Drawing.Point(306, 108)
        Me.fechaInicioDateTime.Name = "fechaInicioDateTime"
        Me.fechaInicioDateTime.Size = New System.Drawing.Size(221, 27)
        Me.fechaInicioDateTime.TabIndex = 9
        Me.fechaInicioDateTime.Value = New Date(2023, 7, 1, 14, 12, 25, 0)
        '
        'fechaFinDateTime
        '
        Me.fechaFinDateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaFinDateTime.Location = New System.Drawing.Point(306, 168)
        Me.fechaFinDateTime.Name = "fechaFinDateTime"
        Me.fechaFinDateTime.Size = New System.Drawing.Size(221, 27)
        Me.fechaFinDateTime.TabIndex = 11
        Me.fechaFinDateTime.Value = New Date(2023, 7, 1, 14, 12, 25, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(306, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fecha de Finalizacion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(306, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Hora de Inicio"
        '
        'horaInicioTimePicker
        '
        Me.horaInicioTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.horaInicioTimePicker.Location = New System.Drawing.Point(306, 221)
        Me.horaInicioTimePicker.Name = "horaInicioTimePicker"
        Me.horaInicioTimePicker.Size = New System.Drawing.Size(220, 27)
        Me.horaInicioTimePicker.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(307, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Hora de finalizacion"
        '
        'horaFinTimePicker
        '
        Me.horaFinTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.horaFinTimePicker.Location = New System.Drawing.Point(306, 279)
        Me.horaFinTimePicker.Name = "horaFinTimePicker"
        Me.horaFinTimePicker.Size = New System.Drawing.Size(221, 27)
        Me.horaFinTimePicker.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(306, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Capacidad de personas"
        '
        'capcidadPersonasTextbox
        '
        Me.capcidadPersonasTextbox.Location = New System.Drawing.Point(306, 336)
        Me.capcidadPersonasTextbox.Name = "capcidadPersonasTextbox"
        Me.capcidadPersonasTextbox.Size = New System.Drawing.Size(221, 27)
        Me.capcidadPersonasTextbox.TabIndex = 17
        '
        'seccionesDataGridView
        '
        Me.seccionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.seccionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SeccionColumn, Me.PrecioColumn, Me.CapacidadColumn})
        Me.seccionesDataGridView.Location = New System.Drawing.Point(551, 108)
        Me.seccionesDataGridView.Name = "seccionesDataGridView"
        Me.seccionesDataGridView.RowHeadersWidth = 51
        Me.seccionesDataGridView.RowTemplate.Height = 29
        Me.seccionesDataGridView.Size = New System.Drawing.Size(435, 255)
        Me.seccionesDataGridView.TabIndex = 18
        '
        'SeccionColumn
        '
        Me.SeccionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SeccionColumn.HeaderText = "Seccion"
        Me.SeccionColumn.MinimumWidth = 6
        Me.SeccionColumn.Name = "SeccionColumn"
        Me.SeccionColumn.ReadOnly = True
        '
        'PrecioColumn
        '
        Me.PrecioColumn.HeaderText = "Precio"
        Me.PrecioColumn.MinimumWidth = 6
        Me.PrecioColumn.Name = "PrecioColumn"
        Me.PrecioColumn.ReadOnly = True
        Me.PrecioColumn.Width = 125
        '
        'CapacidadColumn
        '
        Me.CapacidadColumn.HeaderText = "Capacidad"
        Me.CapacidadColumn.MinimumWidth = 6
        Me.CapacidadColumn.Name = "CapacidadColumn"
        Me.CapacidadColumn.ReadOnly = True
        Me.CapacidadColumn.Width = 125
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(656, 369)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(94, 29)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(771, 369)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(94, 29)
        Me.btnEliminar.TabIndex = 20
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'RegistroEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 491)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.seccionesDataGridView)
        Me.Controls.Add(Me.capcidadPersonasTextbox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.horaFinTimePicker)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.horaInicioTimePicker)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.fechaFinDateTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.fechaInicioDateTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.descripcionEventoTextbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nombreEventoTextbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistroEventos"
        Me.Text = "RegistroEventos"
        CType(Me.seccionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents nombreEventoTextbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents descripcionEventoTextbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents fechaInicioDateTime As DateTimePicker
    Friend WithEvents fechaFinDateTime As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents horaInicioTimePicker As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents horaFinTimePicker As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents capcidadPersonasTextbox As TextBox
    Friend WithEvents seccionesDataGridView As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents SeccionColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioColumn As DataGridViewTextBoxColumn
    Friend WithEvents CapacidadColumn As DataGridViewTextBoxColumn
End Class
