Public Class frmDashboard

    Private eventoBLL As New EventoBLL()
    Private Async Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Obtener los eventos
        Dim eventos As List(Of Evento) = Await eventoBLL.ObtenerEventos()

        ' Verificar si se obtuvieron eventos
        If eventos IsNot Nothing Then
            ' Enlazar los eventos al DataGridView
            eventosDatagridView.AutoGenerateColumns = True
            eventosDatagridView.DataSource = eventos
        Else
            MessageBox.Show("Error al obtener los eventos.")
        End If
    End Sub

    Private Sub btnREventos_Click(sender As Object, e As EventArgs) Handles btnREventos.Click
        RegistroEventos.Show()

    End Sub
End Class
