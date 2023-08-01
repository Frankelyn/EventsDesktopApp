Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ApiClient
    Private httpClient As New HttpClient()
    Private baseURL As String = "http://localhost:8000/" 'URL de la API'

    Public Async Function PostAsync(Of T)(endpoint As String, data As T) As Task(Of HttpResponseMessage)
        Dim url As String = baseURL & endpoint
        Dim content As New StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")

        Return Await httpClient.PostAsync(url, content)
    End Function

    Public Async Function GetAsync(endpoint As String) As Task(Of HttpResponseMessage)
        Dim url As String = baseURL & endpoint

        Return Await httpClient.GetAsync(url)
    End Function

    Public Async Function PutAsync(Of T)(endpoint As String, data As T) As Task(Of HttpResponseMessage)
        Dim url As String = baseURL & endpoint
        Dim content As New StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")

        Return Await httpClient.PutAsync(url, content)
    End Function

    Public Async Function DeleteAsync(endpoint As String) As Task(Of HttpResponseMessage)
        Dim url As String = baseURL & endpoint

        Return Await httpClient.DeleteAsync(url)
    End Function
End Class
