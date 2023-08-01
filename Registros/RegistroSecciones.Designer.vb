<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroSecciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nombreSeccionTextbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.capacidadSeccionTextbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.precioAsientoTextbox = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de Secciones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        '
        'nombreSeccionTextbox
        '
        Me.nombreSeccionTextbox.Location = New System.Drawing.Point(31, 134)
        Me.nombreSeccionTextbox.Name = "nombreSeccionTextbox"
        Me.nombreSeccionTextbox.Size = New System.Drawing.Size(364, 27)
        Me.nombreSeccionTextbox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Capacidad de personas"
        '
        'capacidadSeccionTextbox
        '
        Me.capacidadSeccionTextbox.Location = New System.Drawing.Point(34, 204)
        Me.capacidadSeccionTextbox.Name = "capacidadSeccionTextbox"
        Me.capacidadSeccionTextbox.Size = New System.Drawing.Size(361, 27)
        Me.capacidadSeccionTextbox.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Precio del Asiento"
        '
        'precioAsientoTextbox
        '
        Me.precioAsientoTextbox.Location = New System.Drawing.Point(31, 271)
        Me.precioAsientoTextbox.Name = "precioAsientoTextbox"
        Me.precioAsientoTextbox.Size = New System.Drawing.Size(364, 27)
        Me.precioAsientoTextbox.TabIndex = 8
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(162, 318)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(94, 29)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'RegistroSecciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 367)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.precioAsientoTextbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.capacidadSeccionTextbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nombreSeccionTextbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistroSecciones"
        Me.Text = "RegistroSecciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nombreSeccionTextbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents capacidadSeccionTextbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents precioAsientoTextbox As TextBox
    Friend WithEvents btnGuardar As Button
End Class
