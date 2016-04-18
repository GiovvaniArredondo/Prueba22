<%@ Control Language="vb" AutoEventWireup="false" Inherits="wucGeoReferencia" CodeFile="wucGeoReferencia.ascx.vb" %>
 <style type="text/css">
     .style1
     {
         width: 67%;
         height: 60px;
     }
     .style2
     {
         width: 428px;
     }
     .style4
     {
         width: 67%;
         height: 30px;
     }
     .ToUpper
    {
    text-transform: uppercase;
    }
 </style>
 <div>
     <table cellpadding="0" cellspacing="0" class="style1">
         <tr>
             <td>
                 <table cellpadding="0" cellspacing="0" class="style1">
                     <tr>
                         <td class="style2">

        <h2>&nbsp;<asp:Label ID="Label10" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="16pt" Text="Geolocalización" Width="124px" 
                                                onkeypress="return SoloLetras(event)" 
                ForeColor="#16387C"></asp:Label>
                             </h2>
                         </td>
                         <td>
                             &nbsp;</td>
                     </tr>
                     <tr>
                         <td class="style2">
                             <asp:TextBox ID="Txtczona" runat="server" Height="25px" Width="412px" 
                                 BorderColor="#16387C" BorderWidth="1px" CssClass="ToUpper"></asp:TextBox>
                         </td>
                         <td>
                             <asp:Button ID="BtnIr" runat="server" Height="30px" Text="Ir ......" 
                                 Width="120px" Font-Names="Gill Sans MT" Font-Size="11pt" />
                             <asp:Button ID="Btnout" runat="server" Font-Names="Gill Sans MT" 
                                 Font-Size="11pt" Height="30px" Text="Retornar" Width="120px" 
                     style="text-align: center" />
                         </td>
                     </tr>
                 </table>
             </td>
         </tr>
         <tr>
             <td style="text-align: left">
                 <table cellpadding="0" cellspacing="0" class="style4">
                     <tr>
                         <td style="text-align: center">
                                            <asp:Label ID="Label9" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="12pt" Text="Latitud:" Width="124px" 
                                                onkeypress="return SoloLetras(event)" 
                                 ForeColor="#16387C"></asp:Label>
                                        </td>
                         <td>
                             <asp:TextBox ID="TxtLat" runat="server" BorderColor="#16387C" BorderWidth="1px" 
                                 Enabled="False" Width="120px" Height="21px"></asp:TextBox>
                         </td>
                         <td>
                                            <asp:Label ID="Label11" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="12pt" Text="Longitud:" Width="124px" 
                                                onkeypress="return SoloLetras(event)" 
                                 ForeColor="#16387C"></asp:Label>
                         </td>
                         <td>
                             <asp:TextBox ID="TxtLng" runat="server" BorderColor="#16387C" BorderWidth="1px" 
                                 Enabled="False" Height="21px" Width="120px"></asp:TextBox>
                         </td>
                     </tr>
                     </table>
             </td>
         </tr>
         <tr>
             <td>
    <artem:GoogleMap ID="GoogleMap1" runat="server" Width="800px" Height="600px">        
    </artem:GoogleMap>
             </td>
         </tr>
     </table>
    </div>
