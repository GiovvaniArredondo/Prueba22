<%@ Control Language="VB" AutoEventWireup="false" CodeFile="SubirArchivo.ascx.vb" Inherits="controles_SubirArchivo" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<script type="text/javascript">
        function uploadError(sender, args) {
            var divmsg = $get("<%= msgClientSide.ClientID %>");
            divmsg.className = "error";
            divmsg.style.display = 'block';
            divmsg.innerHTML = 'File: ' + args.get_fileName() +
            '<br/>' + 'Error: '
            + args.get_errorMessage();

        }
        function uploadComplete(sender, args) {
            var divmsg = $get("<%= msgClientSide.ClientID %>");
            divmsg.className = "success";
            divmsg.style.display = 'block';
            divmsg.innerHTML = 'File: ' + args.get_fileName() + '<br/>'
             + 'Length: ' + args.get_length() + 'bytes';
        }
        
    </script>

<form id="form1" runat="server">
   <asp:ScriptManager ID="sm" runat="server" />
   <h1>
       Carga de archivo asíncrona</h1>
   <div id="demoTitle">
       Demostración Control "AsyncFileUpload"
   </div>
   <div id="uploadArea">
       <div id="Throbber" runat="server" 
           style="display: none;">
           <img align="middle" alt="" src="indicator.gif" />
       </div>
       
       
   </div>
   <br />
   <br />
   <div>
       <strong>Ultimo evento del lado del servidor:</strong></div>
   <div id="msgServerSide" runat="server">
   </div>
   <br />
   <br />
   <div>
       <strong>Eventos del lado del cliente:</strong></div>
   <div id="msgClientSide" runat="server" style="display: none">
   </div>
   </form>