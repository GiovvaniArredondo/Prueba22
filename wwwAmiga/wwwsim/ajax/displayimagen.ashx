<%@ WebHandler Language="VB" Class="displayimagen" %>

Imports System
Imports System.Web
Imports System.Data.SqlClient

Public Class displayimagen : Implements IHttpHandler
    
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "image/gif"
        Dim Cadena As String
        Dim sqlComando As New SqlCommand
        Dim UserID As String
        
        Dim binario As Byte
        Try

        
            UserID = context.Request.Form("UserId")
            
            Cadena = " SELECT foto FROM Climide WHERE ccodcli=@UserID "

            Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("FondesolConnectionString2").ConnectionString)
                cnConexion.Open()
                sqlComando.CommandText = Cadena
                sqlComando.Parameters.AddWithValue("@UserID", Trim(UserID))
                binario = DirectCast(sqlComando.ExecuteScalar(), Byte)
                context.Response.Write(binario)
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