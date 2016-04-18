<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Imgen_Ticket_Cl.aspx.vb" Inherits="Imgen_Ticket_Cl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Comprobante(Ticket Garantia)</title>
  <style type="text/css">
  .image_
  {
  	border: 5px solid #ddd;
    padding: 5px; /*Inner border size*/
    background-color:Gray ;
   
    -moz-box-sizing: border-box;
     box-sizing: border-box;
     
     transition: 1.5s ease;
 		-moz-transition: 1.5s ease; /* Firefox */
 		-webkit-transition: 1.5s ease; /* Chrome - Safari */
 		-o-transition: 1.5s ease; /* Opera */
    
  	
  	}
  	
  	.image_:hover{
		transform : scale(2);
		-moz-transform : scale(2); /* Firefox */
		-webkit-transform : scale(2); /* Chrome - Safari */
		-o-transform : scale(2); /* Opera */
		-ms-transform : scale(2); /* IE9 */
	}
  
  
  </style>
</head>
<body bgColor="White">
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Click aqui para imprimir comprobante"></asp:Label>
    <br />
   <input type="button" name="imprimir" value="Imprimir" onclick="window.print();">
    <center>
    <div>
    <asp:Image ID="Image1" runat="server" CssClass= image_  Height="693px" Width="382px" 
            GenerateEmptyAlternateText="True" />
    </div>
    </center>
    
    
    </form>
        
</body>
</html>
