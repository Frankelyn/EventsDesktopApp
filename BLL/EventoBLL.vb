Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class EventoBLL
    Private apiClient As New ApiClient()

    Public Async Function GuardarEvento(evento As Evento, secciones As List(Of Seccion)) As Task(Of Boolean)
        Try
            Dim jsonEvento As String = JsonConvert.SerializeObject(evento)
            Dim jsonObject As JObject = JObject.Parse(jsonEvento)
            jsonObject("fecha_evento") = evento.fecha_evento
            jsonObject("fecha_finalizacion") = evento.fecha_finalizacion


            Dim jsonFinal As String = jsonObject.ToString()


            Dim responseEvento As HttpResponseMessage = Await apiClient.PostAsync("eventos/", evento)

            If responseEvento.IsSuccessStatusCode Then

                MessageBox.Show("Evento enviado correctamente.")

                Dim eventoCreado As Evento = JsonConvert.DeserializeObject(Of Evento)(Await responseEvento.Content.ReadAsStringAsync())
                Dim idEventoCreado As Integer = eventoCreado.id_evento

                For Each seccion As Seccion In secciones

                    seccion.id_evento = idEventoCreado


                    Dim jsonSeccion As String = JsonConvert.SerializeObject(seccion)


                    Dim responseSeccion As HttpResponseMessage = Await apiClient.PostAsync("secciones/", seccion)

                    If Not responseSeccion.IsSuccessStatusCode Then

                        Dim contenidoRespuesta As String = Await responseSeccion.Content.ReadAsStringAsync()
                        MessageBox.Show("Error al enviar la sección. Detalles del error: " & vbCrLf & contenidoRespuesta)
                        Return False
                    End If
                Next

                MessageBox.Show("Secciones enviadas correctamente.")
                Return True
            Else

                Dim contenidoRespuesta As String = Await responseEvento.Content.ReadAsStringAsync()
                MessageBox.Show("Error al enviar el evento. Detalles del error: " & vbCrLf & contenidoRespuesta)
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function






    Public Async Function ObtenerEventos() As Task(Of List(Of Evento))
        Try
            Dim response As HttpResponseMessage = Await apiClient.GetAsync("eventos/")

            If response.IsSuccessStatusCode Then
                Dim eventosJson As String = Await response.Content.ReadAsStringAsync()
                Dim eventos As List(Of Evento) = JsonConvert.DeserializeObject(Of List(Of Evento))(eventosJson)
                Return eventos
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al obtener los eventos: " & ex.Message)
            Return Nothing
        End Try
    End Function


End Class
