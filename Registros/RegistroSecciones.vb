Public Class RegistroSecciones

    Public Property IdSeccion As Integer
    Public Property NombreSeccion As String
    Public Property CapacidadSeccion As Integer
    Public Property PrecioAsiento As Decimal


    Private Function ValidarCamposRegistroSecciones() As Boolean

        If String.IsNullOrWhiteSpace(nombreSeccionTextbox.Text) Then
            MessageBox.Show("Por favor, ingrese el nombre de la sección.")
            nombreSeccionTextbox.Select()
            Return False
        End If

        If String.IsNullOrWhiteSpace(capacidadSeccionTextbox.Text) OrElse capacidadSeccionTextbox.Text = "0" Then
            MessageBox.Show("Por favor, ingrese la capacidad de la sección.")
            capacidadSeccionTextbox.Select()
            Return False
        End If

        If String.IsNullOrWhiteSpace(precioAsientoTextbox.Text) Then
            MessageBox.Show("Por favor, ingrese el precio del asiento.")
            precioAsientoTextbox.Select()
            Return False
        End If


        Return True
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Not ValidarCamposRegistroSecciones() Then
            Return
        End If

        NombreSeccion = nombreSeccionTextbox.Text
        CapacidadSeccion = CInt(capacidadSeccionTextbox.Text)
        PrecioAsiento = CDec(precioAsientoTextbox.Text)

        Me.DialogResult = DialogResult.OK
        Me.Close()





    End Sub

    Private Sub precioAsientoTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles precioAsientoTextbox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True ' Cancelar el evento KeyPress para evitar ingresar el carácter
        End If

        ' Verificar si ya se ingresó un punto decimal y evitar ingresar otro
        If e.KeyChar = "." AndAlso precioAsientoTextbox.Text.Contains(".") Then
            e.Handled = True ' Cancelar el evento KeyPress para evitar ingresar otro punto decimal
        End If
    End Sub

    Private Sub capacidadSeccionTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles capacidadSeccionTextbox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub capacidadSeccionTextbox_TextChanged(sender As Object, e As EventArgs) Handles capacidadSeccionTextbox.TextChanged

    End Sub

    Private Sub precioAsientoTextbox_TextChanged(sender As Object, e As EventArgs) Handles precioAsientoTextbox.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub nombreSeccionTextbox_TextChanged(sender As Object, e As EventArgs) Handles nombreSeccionTextbox.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class