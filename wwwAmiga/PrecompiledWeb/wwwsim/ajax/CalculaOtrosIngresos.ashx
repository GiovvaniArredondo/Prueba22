<%@ WebHandler Language="VB" Class="CalculaOtrosIngresos" %>

Imports System
Imports System.Web
Imports System.Data.SqlClient


Public Class CalculaOtrosIngresos : Implements IHttpHandler
    
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "text/plain"
        Dim fieldTipoIngreso As String = ""
        Dim fieldNumeroClientes As String = ""
        Dim fieldCodigoCliente As String = ""
        Dim fieldProducto As String = ""
        Dim Salida As String = ""
        
        fieldTipoIngreso = Trim(context.Request.Form("TipoIngreso"))        
        fieldNumeroClientes = Trim(context.Request.Form("NumeroClientes"))
        fieldCodigoCliente = Trim(context.Request.Form("CodigoCliente"))
        fieldProducto = Trim(context.Request.Form("Producto"))
        
       
        
        
        Select Case fieldTipoIngreso
            Case "RF"
                Salida = OtrosIngresosPorReferencia(fieldNumeroClientes).ToString
            Case "LG"
                Salida = OtrosIngresosPorLegalizacion(fieldCodigoCliente, fieldProducto)
            Case "CO"
                Salida = OtrosIngresosPorComision(fieldCodigoCliente, fieldProducto)
        End Select
            
        context.Response.Write(Salida)
 
    End Sub
 
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property
    
    Public Function OtrosIngresosPorReferencia(ByVal NumeroClientes As String) As Decimal
        
        Dim Cadena As String = ""
        Dim sqlComando As New SqlCommand
        Dim drResultado As SqlDataReader
        Dim Total As New Decimal
      

        
        Cadena = "  " & _
        " select (monto*@Clientes) as total" & _
        " from detalletipoIngreso " & _
        " where tipoingreso='RF'" & _
        " and producto='01'"


        Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("FondesolConnectionString2").ConnectionString)
            cnConexion.Open()
            sqlComando.CommandText = Cadena
            sqlComando.Parameters.AddWithValue("@Clientes", NumeroClientes)
            sqlComando.Connection = cnConexion
            drResultado = sqlComando.ExecuteReader
            
            If drResultado.Read() Then
                Total = Decimal.ToDouble(drResultado.Item("total"))                
            Else
                Total = 0
            End If
            
        End Using
                        
        Return Total
        
    End Function
    
    
    Public Function OtrosIngresosPorComision(ByVal CodigoCliente As String, ByVal Producto As String) As Decimal
        
        Dim Cadena As String = ""
        Dim sqlComando As New SqlCommand
        Dim drResultado As SqlDataReader
        Dim Total As New Decimal
      
        Select Case Producto
            Case "01"
                
                Cadena = "" & _
                " select ( " & _
                " Select ncapdes " & _
                " from cremcre  " & _
                " where ccodcli=@CodigoCliente " & _
                " and substring(ccodcta,7,2)='01' " & _
                " and cestado='F')* " & _
                " (select porcentaje/100 " & _
                " from detalletipoIngreso " & _
                " where tipoingreso='CO' " & _
                " and producto='01') as total  "
                
            Case "02", "03"
                
                Cadena = "" & _
                " select (ISNULL((select sum(ncapdes) " & _
                " from cremcre " & _
                " where ccodsol in " & _
                " ( " & _
                 " select ccodsol " & _
                 " from cremcre " & _
                 " where ccodcli=@CodigoCliente " & _
                 " and cestado='F' " & _
                " ) " & _
                " and substring(ccodcta,7,2) in ('02','03') " & _
                " and cestado='F'),0)*(select porcentaje/100 " & _
                 " from detalletipoIngreso " & _
                 " where tipoingreso='CO' " & _
                 " and producto='01')) as total "
                
        End Select
            
        

        Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("FondesolConnectionString2").ConnectionString)
            cnConexion.Open()
            sqlComando.CommandText = Cadena
            sqlComando.Parameters.AddWithValue("@CodigoCliente", CodigoCliente)
            sqlComando.Connection = cnConexion
            drResultado = sqlComando.ExecuteReader
            
            If drResultado.Read() Then
                Total = Decimal.ToDouble(drResultado.Item("total"))
            Else
                Total = 0
            End If
            
        End Using
                        
        Return Total
        
    End Function

    Public Function OtrosIngresosPorLegalizacion(ByVal CodigoCliente As String, ByVal Producto As String) As Decimal
        
        Dim Cadena As String = ""
        Dim sqlComando As New SqlCommand
        Dim drResultado As SqlDataReader
        Dim Total As New Decimal
      
        Select Case Producto
            
            Case "01"
                
                Cadena = "" & _
                " select monto as total " & _
                " from detalletipoIngreso " & _
                " where tipoingreso='LG' " & _
                " and producto='01' " & _
                " and rangomax>=(select ncapdes " & _
                " from cremcre " & _
                " where ccodcli=@CodigoCliente " & _
                " and cestado='F' " & _
                " and substring(ccodcta,7,2)='01' " & _
                " ) and rangomin<=(select ncapdes " & _
                " from cremcre " & _
                " where ccodcli=@CodigoCliente " & _
                " and cestado='F' " & _
                " and substring(ccodcta,7,2)='01' " & _
                " ) "
                
            Case "02"
                
                Cadena = "" & _
                " select (ISNULL((select count(ccodcta) " & _
                " from cremcre " & _
                " where ccodsol in " & _
                " ( " & _
                 " select ccodsol " & _
                 " from cremcre " & _
                 " where ccodcli=@CodigoCliente " & _
                 " and cestado='F' " & _
                " ) " & _
                " and substring(ccodcta,7,2)='02' " & _
                " and cestado='F'),0)*(select monto " & _
                 " from detalletipoIngreso " & _
                 " where tipoingreso='LG' " & _
                 " and producto='02')) as total "
                
            Case "03"
                
                Cadena = "" & _
                " select monto as total " & _
                " from detalletipoIngreso " & _
                " where tipoingreso='LG' " & _
                " and producto='03' "
                
        End Select
            
        

        Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("FondesolConnectionString2").ConnectionString)
            cnConexion.Open()
            sqlComando.CommandText = Cadena
            sqlComando.Parameters.AddWithValue("@CodigoCliente", CodigoCliente)
            sqlComando.Connection = cnConexion
            drResultado = sqlComando.ExecuteReader
            
            If drResultado.Read() Then
                Total = Decimal.ToDouble(drResultado.Item("total"))
            Else
                Total = 0
            End If
            
        End Using
                        
        Return Total
        
    End Function
End Class