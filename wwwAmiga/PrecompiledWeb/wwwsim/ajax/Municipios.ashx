<%@ WebHandler Language="VB" Class="Municipios" %>

Imports System
Imports System.Web
Imports System.Data.SqlClient
Public Class Municipios : Implements IHttpHandler
    
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "text/plain"
        Dim Cadena As String
        Dim sqlComando As New SqlCommand
        Dim fieldDepto As String
        Dim drMunicipios As SqlDataReader
        Dim Salida As String

        Try

        

            fieldDepto = context.Request.Form("Departamento")

            Cadena = " select ccodzon,cdeszon " & _
            " from tabtzon " & _
            " where ctipzon = 2 " & _
            " and substring(ccodzon,1,2)=@depto order by cdeszon"

            Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("FondesolConnectionString2").ConnectionString)
                cnConexion.Open()
                sqlComando.CommandText = Cadena
                sqlComando.Parameters.AddWithValue("@depto", Trim(fieldDepto))
                sqlComando.Connection = cnConexion
                drMunicipios = sqlComando.ExecuteReader
                Salida = ""
                'Salida += "<option value='0'>Seleccionar municipio</option>"
                While drMunicipios.Read()
                    Salida += "<option value='" + drMunicipios.Item("ccodzon").ToString + "'>" + drMunicipios.Item("cdeszon").ToString + "</option>"
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