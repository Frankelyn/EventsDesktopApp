Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Threading.Tasks

Public Class SeccionBLL
    Private apiClient As New ApiClient()
    Private baseUrl As String = "https://api.example.com/" ' Ajusta la URL base de tu API

    Public Async Function ObtenerSeccionesPorEvento(idEvento As Integer) As Task(Of List(Of Seccion))
        Dim url As String = baseUrl & "secciones?id_evento=" & idEvento.ToString()
        Dim response As HttpResponseMessage = Await apiClient.GetAsync(url)

        If response.IsSuccessStatusCode Then
            Dim contenido As String = Await response.Content.ReadAsStringAsync()
            Dim secciones As List(Of Seccion) = JsonConvert.DeserializeObject(Of List(Of Seccion))(contenido)
            Return secciones
        Else
            Return Nothing
        End If
    End Function

    ' Otros métodos CRUD para Seccion
End Class

