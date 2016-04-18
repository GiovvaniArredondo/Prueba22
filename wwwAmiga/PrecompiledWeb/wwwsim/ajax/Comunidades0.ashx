<%@ WebHandler Language="VB" Class="Comunidades0" %>

Imports System
Imports System.Web
Imports System.Data.SqlClient
Public Class Comunidades0 : Implements IHttpHandler
    
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "text/plain"
        Dim Cadena As String
        Dim sqlComando As New SqlCommand
        Dim fieldDepto As String
        Dim drComunidades As SqlDataReader
        Dim Salida As String
        Dim fieldMuni As String

        Try

        
            fieldDepto = context.Request.Form("Municipio0")
            fieldDepto = Trim(fieldDepto)
            fieldMuni = fieldDepto.Substring(2, 2)
            fieldDepto = fieldDepto.Substring(0, 2)

            Cadena = " select ccodzon,cdeszon " & _
            " from tabtzon " & _
            " where ctipzon = 3 " & _
            " and substring(ccodzon,1,2)=@depto" & _
            " and substring(ccodzon,3,2)=@muni order by cdeszon "

            Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("FondesolConnectionString2").ConnectionString)
                cnConexion.Open()
                sqlComando.CommandText = Cadena
                sqlComando.Parameters.AddWithValue("@depto", Trim(fieldDepto))
                sqlComando.Parameters.AddWithValue("@muni", Trim(fieldMuni))
                sqlComando.Connection = cnConexion
                drComunidades = sqlComando.ExecuteReader
                Salida = ""
                'Salida += "<option value='0'>Seleccionar comunidad</option>"
                While drComunidades.Read()
                    Salida += "<option value='" + drComunidades.Item("ccodzon").ToString + "'>" + drComunidades.Item("cdeszon").ToString + "</option>"
                End While

                context.Response.Write(Salida)
            End Using
        Catch ex As Exception

        End Try

    End Sub
 
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property


End Class