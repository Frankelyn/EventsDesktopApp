Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class RegistroEventos

    Private frmSecciones As RegistroSecciones


    Private eventoBLL As New EventoBLL()
    Private seccionBLL As New SeccionBLL()

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim registroSecciones As New RegistroSecciones()

        ' Mostrar el formulario de Secciones como un diálogo
        Dim result As DialogResult = registroSecciones.ShowDialog()

        ' Verificar si se hizo clic en el botón "Guardar" del formulario de Secciones
        If result = DialogResult.OK Then
            ' Agregar una nueva fila al DataGridView con los valores proporcionados
            seccionesDataGridView.Rows.Add(registroSecciones.NombreSeccion, registroSecciones.PrecioAsiento, registroSecciones.CapacidadSeccion)
        End If

    End Sub



    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(nombreEventoTextbox.Text) Then
            MessageBox.Show("El campo Nombre de Evento no puede estar vacío.")
            nombreEventoTextbox.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(descripcionEventoTextbox.Text) Then
            MessageBox.Show("El campo Descripción de Evento no puede estar vacío.")
            descripcionEventoTextbox.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(capcidadPersonasTextbox.Text) OrElse capcidadPersonasTextbox.Text = "0" Then
            MessageBox.Show("El campo Capacidad de Personas debe ser un número entero mayor que cero.")
            capcidadPersonasTextbox.Focus()
            Return False
        End If

        If fechaInicioDateTime.Value > fechaFinDateTime.Value Then
            MessageBox.Show("La Fecha de Inicio no puede ser posterior a la Fecha de Finalización.")
            fechaInicioDateTime.Focus()
            Return False
        End If

        If horaInicioTimePicker.Value > horaFinTimePicker.Value Then
            MessageBox.Show("La Hora de Inicio no puede ser posterior a la Hora de Finalización.")
            horaInicioTimePicker.Focus()
            Return False
        End If

        If seccionesDataGridView.Rows.Count = 1 AndAlso seccionesDataGridView.Rows(0).Cells("SeccionColumn").Value Is Nothing Then
            MessageBox.Show("Debe agregar al menos una sección al evento.")
            Return False
        End If

        Return True
    End Function


    Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Not ValidarCampos() Then
            Return
        End If


        Dim evento As New Evento()

        evento.nombre_evento = nombreEventoTextbox.Text
        evento.descripcion_evento = descripcionEventoTextbox.Text
        evento.fecha_evento = fechaInicioDateTime.Value.Date.ToString("yyyy-MM-dd")
        evento.hora_inicio = horaInicioTimePicker.Value.TimeOfDay.ToString()
        evento.fecha_finalizacion = fechaFinDateTime.Value.Date.ToString("yyyy-MM-dd")
        evento.hora_finalizacion = horaFinTimePicker.Value.TimeOfDay.ToString()
        evento.capacidad_total = CInt(capcidadPersonasTextbox.Text)

        Dim secciones As New List(Of Seccion)()

        For Each row As DataGridViewRow In seccionesDataGridView.Rows
            If Not row.IsNewRow Then
                Dim seccion As New Seccion()

                seccion.nombre_seccion = row.Cells("SeccionColumn").Value.ToString()

                If Not String.IsNullOrEmpty(row.Cells("PrecioColumn").Value?.ToString()) Then
                    seccion.precio_asiento = CDec(row.Cells("PrecioColumn").Value)
                End If

                If Not String.IsNullOrEmpty(row.Cells("CapacidadColumn").Value?.ToString()) Then
                    seccion.capacidad_seccion = CInt(row.Cells("CapacidadColumn").Value)
                End If

                secciones.Add(seccion)
            End If
        Next



        Dim exito As Boolean = Await eventoBLL.GuardarEvento(evento, secciones)

        If exito Then
            MessageBox.Show("Evento guardado correctamente.")
        Else
            MessageBox.Show("No se pudo guardar el evento.")
        End If


        Me.Close()
        frmDashboard.Show()


    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If seccionesDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = seccionesDataGridView.SelectedRows(0)
            seccionesDataGridView.Rows.Remove(selectedRow)
        End If
    End Sub

    Private Sub seccionesDataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles seccionesDataGridView.SelectionChanged
        If seccionesDataGridView.SelectedRows.Count > 0 Then

            btnEliminar.Enabled = True
        Else
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub capcidadPersonasTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles capcidadPersonasTextbox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class