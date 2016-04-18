
Partial Class controles_Ahorros_WbUCtasAhorro
    Inherits ucWBase

#Region "Privadas"
    Private vDetalle As New DataSet
    Private codigoJs As String = ""
    Private ds As New DataSet
    Private eahomlib As New cAhomlib
    Private cClsAho As New cAhomcta
    Private ds_find As New DataSet
    Private array_d As New ArrayList
    Private cClsfir As New cAhomfir
    Private clsppal As New class1
#End Region

#Region "Metodos"

    Public Sub Cargar_Datos()

        Dim ListaItem As New ListItem

        ListaItem.Value = "00"
        ListaItem.Text = "Selecccione una Opción"


        If Me.CbxParentesco1.Items.Count > 1 Then
            Me.CbxParentesco1.Items.Clear()
        End If

        'Agrega el Primer Registro
        'Me.CbxParentesco1.Items.Add(ListaItem)

        Me.CbxParentesco1.Recuperar()

        If Me.CbxTipAho1.Items.Count > 1 Then
            Me.CbxTipAho1.Items.Clear()
        End If

        'Agrega el Primer Registro
        'Me.CbxTipAho1.Items.Add(ListaItem)

        Me.CbxTipAho1.Recuperar()

        If Me.CbxLinAhoProd1.Items.Count > 1 Then
            Me.CbxLinAhoProd1.Items.Clear()
        End If

        'Agrega el Primer Registro
        'Me.CbxLinAhoProd1.Items.Add(ListaItem)

        Me.CbxLinAhoProd1.Recuperar(Me.CbxTipAho1.SelectedValue.Trim)


        Limpieza()
        Limpia_Item()
        Session.Add("Bandera", "1")
        ViewState.Add("Dataset", vDetalle)

        ViewState.Add("Dataset", ds_find)

        Me.Txtdfeccnt.Text = Session("GDFECSIS")

        Me.cbxTipBusq.SelectedValue = "01"

    End Sub


    Private Sub Buscar_Asociado()
        Dim lntipo As Integer = Nothing
        Dim occlass_cli As New cClimide



        If Me.TxtcEvalua.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        If Me.cbxTipBusq.SelectedValue.Trim = "00" Then
            codigoJs = "<script language='javascript'>alert('Seleccione una Opcion de Busqueda, " & _
                                 "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Seleccione una Opcion de Busqueda, " & _
            '                     "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If



        Select Case cbxTipBusq.SelectedValue.Trim

            Case Is = "01"   'Nombre del Socio
                lntipo = 1

            Case Is = "02"   'Número de DUI
                lntipo = 2

            Case Is = "03"   'Número de Socio
                lntipo = 3

        End Select


        ds_find = occlass_cli.Extraer_Datos_Socio(lntipo, Me.TxtcEvalua.Text.Trim)


        If ds_find.Tables(0).Rows.Count = 0 Then
            codigoJs = "<script language='javascript'>alert('No existen Datos, " & _
                                 "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('No existen Datos, " & _
            '              "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If



        Me.Gridfind.DataSource = ds_find.Tables(0)
        Me.Gridfind.DataBind()
        
        'Cargar_Datos()
        ViewState("Dataset") = ds_find

    End Sub

    Public Sub Carga_Boton_Nuevo()
        Limpieza()
        Limpia_Item()
        ' Me.TxtcCodcrt.Text = "99999999"
        Me.Habilita(True)
        Me.Habilita_Item(True)
        Me.btnnew.Enabled = False
        Me.btnsave.Enabled = True
        Me.btncancel.Enabled = True

        vDetalle = cClsfir.CargaFirmas_()
        ViewState("Dataset") = vDetalle
    End Sub


    Private Sub Limpieza()
        Me.TxtcCodaho.Text = ""
        Me.Txtdfeccnt.Text = Session("GDFECSIS")
        Me.Txtnlibreta.Text = "0"
        Me.Txtctitular.Text = ""
        Me.TxtcNombres.Text = ""
        Me.TxtcApellidos.Text = ""
    End Sub

    Private Sub Limpia_Item()
        Me.Txtnlinea.Text = "0"
        Me.TxtcNomben.Text = ""
        Me.TxtnPorcen.Text = "0.0"
        Me.TxtcDirBen.Text = ""
        Me.CbxParentesco1.SelectedValue = "00"
        Me.Txtdnacimi.Text = Session("GDFECSIS")
    End Sub

    Private Sub Limpia_Item1()
        Me.Txtnlinea0.Text = "0"
        Me.TxtcNomFir.Text = ""
        Me.Txtdnacimi0.Text = Session("GDFECSIS")
        Me.TxtcnudociFir.Text = ""
    End Sub

    Private Sub Habilita(ByVal llbandera As Boolean)
        Me.CbxTipAho1.Enabled = llbandera
        Me.CbxLinAhoProd1.Enabled = llbandera
    End Sub

    Private Sub Habilita_Item(ByVal llbandera As Boolean)
        Me.TxtcNomben.Enabled = llbandera
        Me.TxtnPorcen.Enabled = llbandera
        Me.TxtcDirBen.Enabled = llbandera
        Me.btnproc.Enabled = llbandera
        Me.CbxParentesco1.Enabled = llbandera
        Me.GridBen.Enabled = llbandera
        Me.Txtdnacimi.Enabled = llbandera
    End Sub

    Private Sub Habilita_Item1(ByVal llbandera As Boolean)
        Me.TxtcNomFir.Enabled = llbandera
        Me.Txtdnacimi0.Enabled = llbandera
        Me.TxtcnudociFir.Enabled = llbandera
        Me.btnproc0.Enabled = llbandera
        Me.GridFirm.Enabled = llbandera
    End Sub

    Private Sub Inserta_Detalle_Beneficiarios()

        Dim dr As DataRow
        Dim i As Integer

        vDetalle = ViewState("Dataset")

        i = vDetalle.Tables("Beneficiarios").Rows.Count

        i += 1
        dr = vDetalle.Tables("Beneficiarios").NewRow

        dr("IdCuenta") = i
        dr("cNomBen") = Me.TxtcNomben.Text.Trim.ToUpper
        dr("dnacimi") = Date.Parse(Me.Txtdnacimi.Text)
        dr("cParent") = Me.CbxParentesco1.SelectedValue.Trim
        dr("cDirecc") = Me.TxtcDirBen.Text.Trim
        dr("nPorcen") = Double.Parse(Me.TxtnPorcen.Text)


        vDetalle.Tables("Beneficiarios").Rows.Add(dr)
        Me.GridBen.DataSource = vDetalle.Tables("Beneficiarios")
        Me.GridBen.DataBind()

    End Sub



    Public Sub Limpia_Pagina()
        Limpieza()
        Limpia_Item()
        Limpia_Item1()

        vDetalle = ViewState("Dataset")

        'Limpiando el Grid
        If Me.GridBen.Rows.Count > 0 Then
            If vDetalle.Tables.Count > 0 Then
                vDetalle.Tables("Beneficiarios").Rows.Clear()
                Me.GridBen.DataSource = vDetalle.Tables("Beneficiarios")
                Me.GridBen.DataBind()
            End If
        End If

        'Limpiando el Grid
        If Me.GridFirm.Rows.Count > 0 Then
            If vDetalle.Tables.Count > 0 Then
                vDetalle.Tables("Firmas").Rows.Clear()
                Me.GridFirm.DataSource = vDetalle.Tables("Firmas")
                Me.GridFirm.DataBind()
            End If
        End If

        Habilita(False)
        Habilita_Item(False)
        Habilita_Item1(False)
        Me.btnEdit.Enabled = False
        Me.btnnew.Enabled = True
        Me.btnsave.Enabled = False
        Me.btncancel.Enabled = False



        'Busqueda de Partidas
        'Me.Txtdfecini.Text = Session("GDFECSIS")
        'Me.Txtdfecfin.Text = Date.Parse(Me.Txtdfecini.Text).AddMonths(1)
        'Me.TxtnValor.Text = "0.0"
        Me.TxtcEvalua.Text = ""
        Me.cbxTipBusq.SelectedValue = "01"

        ds_find = ViewState("Dataset")

        'Limpiando el Grid
        If Me.Gridfind.Rows.Count > 0 Then
            If ds_find.Tables.Count > 0 Then
                ds_find.Tables(0).Rows.Clear()
                Me.Gridfind.DataSource = ds_find.Tables(0)
                Me.Gridfind.DataBind()
            End If
        End If

        'Me.TxtnValor.Visible = False
        Me.TxtcEvalua.Visible = True
        'Me.Txtdfecini.Enabled = False
        'Me.Txtdfecfin.Enabled = False
        'Me.TxtnValor.Enabled = False
        Me.TxtcEvalua.Enabled = True

    End Sub



    Private Sub Imprimir(ByVal ds_Print As DataSet, ByVal mi_rptEmp As Object, _
                         ByVal origen As String, ByVal Destino As String, _
                         ByVal pdnacimi As Date, ByVal pcsexo As String, _
                         ByVal pcdui As String, ByVal pcteldom As String, _
                         ByVal pcprofesion As String, ByVal pccivil As String, _
                         ByVal pcdirdom As String, ByVal pcNomcli As String)


        Dim parameters(25, 1) As String


        'Armando Matriz de variables
        parameters(0, 0) = ("gcNominst")
        parameters(0, 1) = ("COPADEO DE R.L")

        parameters(1, 0) = ("pcorigen")
        parameters(1, 1) = (origen)

        parameters(2, 0) = ("pcdestino")
        parameters(2, 1) = (Destino)

        parameters(3, 0) = ("id1")
        parameters(3, 1) = ("")

        parameters(4, 0) = ("id2")
        parameters(4, 1) = ("")

        parameters(5, 0) = ("id3")
        parameters(5, 1) = ("X")

        parameters(6, 0) = ("id4")
        parameters(6, 1) = ("")

        parameters(7, 0) = ("id5")
        parameters(7, 1) = ("")

        parameters(8, 0) = ("id6")
        parameters(8, 1) = ("")

        parameters(9, 0) = ("id7")
        parameters(9, 1) = ("")

        parameters(10, 0) = ("nmonto1")
        parameters(10, 1) = ("0")

        parameters(11, 0) = ("nmonto2")
        parameters(11, 1) = ("0")

        parameters(12, 0) = ("nmonto3")
        parameters(12, 1) = (ViewState("pnMonCert"))

        parameters(13, 0) = ("nmonto4")
        parameters(13, 1) = ("0")

        parameters(14, 0) = ("nmonto5")
        parameters(14, 1) = ("0")

        parameters(15, 0) = ("nmonto6")
        parameters(15, 1) = (ViewState("pnMonCert"))

        parameters(16, 0) = ("nmonto7")
        parameters(16, 1) = ("0")

        parameters(17, 0) = ("pccodcli")
        parameters(17, 1) = (ViewState("pcCodcli"))

        parameters(18, 0) = ("pcnomcli")
        parameters(18, 1) = (pcNomcli)

        parameters(19, 0) = ("pdnacimi")
        parameters(19, 1) = (pdnacimi)

        parameters(20, 0) = ("pcsexo")
        parameters(20, 1) = (pcsexo)

        parameters(21, 0) = ("pcdui")
        parameters(21, 1) = (pcdui)

        parameters(22, 0) = ("pcteldom")
        parameters(22, 1) = (pcteldom)

        parameters(23, 0) = ("pcprofesion")
        parameters(23, 1) = (pcprofesion)

        parameters(24, 0) = ("pccivil")
        parameters(24, 1) = (pccivil)

        parameters(25, 0) = ("pcdirdom")
        parameters(25, 1) = (pcdirdom)


        Me.GenerarReporte_New(ds_Print, Server.MapPath("reportes"), mi_rptEmp, "PDF", parameters)


    End Sub


    Private Sub Inserta_Detalle_Firmas()

        Dim dr As DataRow
        Dim i As Integer

        vDetalle = ViewState("Dataset")

        i = vDetalle.Tables("Firmas").Rows.Count

        i += 1
        dr = vDetalle.Tables("Firmas").NewRow

        dr("IdCuenta") = i
        dr("cNomFir") = Me.TxtcNomFir.Text.Trim.ToUpper
        dr("dnacimi") = Date.Parse(Me.Txtdnacimi0.Text)
        dr("cnudoci") = Me.TxtcnudociFir.Text.Trim


        vDetalle.Tables("Firmas").Rows.Add(dr)
        Me.GridFirm.DataSource = vDetalle.Tables("Firmas")
        Me.GridFirm.DataBind()
    End Sub


#End Region



    Protected Sub ibt_Click(ByVal sender As Object, ByVal e As ImageClickEventArgs)
        Dim pIdcuenta As String = (CType(sender, ImageButton)).CommandArgument
        Dim vdetalle As New DataSet
        Dim i As Integer = 1

        vdetalle = ViewState("Dataset")

        'Obtener un array de filas cuyo id sea el recuperado. Teóricamente solo debe eliminar uno
        Dim filas As DataRow() = vdetalle.Tables("Beneficiarios").Select("idcuenta = " + pIdcuenta, String.Empty)

        'Buscando Items
        For Each item As DataRow In filas
            vdetalle.Tables("Beneficiarios").Rows.Remove(item)
        Next

        'Asigna nuevamente numero de Linea
        For Each fila As DataRow In vdetalle.Tables("Beneficiarios").Rows
            fila("idcuenta") = i
            i += 1
        Next


        Me.GridBen.DataSource = vdetalle.Tables("Beneficiarios")
        Me.GridBen.DataBind()

        ViewState("Dataset") = vdetalle

    End Sub

    Protected Sub ibt0_Click(ByVal sender As Object, ByVal e As ImageClickEventArgs)
        Dim pIdcuenta As String = (CType(sender, ImageButton)).CommandArgument
        Dim vdetalle As New DataSet
        Dim i As Integer = 1

        vdetalle = ViewState("Dataset")

        'Obtener un array de filas cuyo id sea el recuperado. Teóricamente solo debe eliminar uno
        Dim filas As DataRow() = vdetalle.Tables("Firmas").Select("idcuenta = " + pIdcuenta, String.Empty)

        'Buscando Items
        For Each item As DataRow In filas
            vdetalle.Tables("Firmas").Rows.Remove(item)
        Next

        'Asigna nuevamente numero de Linea
        For Each fila As DataRow In vdetalle.Tables("Firmas").Rows
            fila("idcuenta") = i
            i += 1
        Next


        Me.GridFirm.DataSource = vdetalle.Tables("Firmas")
        Me.GridFirm.DataBind()

        ViewState("Dataset") = vdetalle

    End Sub

    Protected Sub btnproc_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnproc.Click
        Dim pnTotpor As Double = 0

        'Valida que existe una cuenta contable
        If Me.TxtcNomben.Text.Trim.Length = 0 Then
            codigoJs = "<script language='javascript'>alert('La Cuenta Contable esta Vacia, " & _
                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Nombre del Beneficiario esta vacia, " & _
            '                "Advertencia SIM.NET ')</script>")
            Exit Sub

        End If


        If Me.CbxParentesco1.SelectedValue.Trim = "00" Then
            codigoJs = "<script language='javascript'>alert('Debe Elegir un Parentesco, " & _
                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Debe Elegir un Parentesco, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        'Valida Detalle de la Linea 
        If Me.TxtcDirBen.Text.Trim.Length = 0 Then
            codigoJs = "<script language='javascript'>alert('El Detalle de Movimiento por Linea esta Vacio, " & _
                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('La dirección del Beneficiario esta vacia, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub

        End If


        ''Valida que debe y haber no sean cero
        'If Double.Parse(Me.TxtnDebe.Text) = 0 And Double.Parse(Me.TxtnHaber.Text) = 0 Then
        '    'codigoJs = "<script language='javascript'>alert('Cargo y Abono es igual a Cero, " & _
        '    '        "Advertencia SIM.NET ')</script>"
        '    'ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        '    Response.Write("<script language='javascript'>alert('Cargo y Abono es igual a Cero, " & _
        '                   "Advertencia SIM.NET ')</script>")
        '    Exit Sub
        'End If

        'valida que no valla vacia la cuenta
        If Me.TxtcNomben.Text.Trim.Length = 0 Or Me.TxtcNomben.Text.Trim = Nothing Then

            codigoJs = "<script language='javascript'>alert('Imposible procesar, No hay cuenta, " & _
                  "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            '  Response.Write("<script language='javascript'>alert('Imposible procesar, No hay cuenta, Advertencia SIM.NET')</script>")
            Exit Sub
        End If

        vDetalle = ViewState("Dataset")

        ''Valida si porcentaje supera el 100%
        'If Not IsDBNull(vDetalle.Tables(0).Compute("sum(nPorcen)", "")) Then
        '    pnTotpor = vDetalle.Tables(0).Compute("sum(nPorcen)", "")
        'End If


        'If (pnTotpor + Double.Parse(Me.TxtnPorcen.Text)) > 100 Then
        '    'codigoJs = "<script language='javascript'>alert('El porcentaje no puede exceder el 100%, " & _
        '    '      "Advertencia SIM.NET ')</script>"
        '    'ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        '    Response.Write("<script language='javascript'>alert('El porcentaje no puede exceder el 100%, Advertencia SIM.NET')</script>")
        '    Exit Sub
        'End If

        '----------------------------------------------------------    
        'Valida si es modificacion o Nueva Linea
        '----------------------------------------------------------
        If Me.Txtnlinea.Text.Trim = "0" Then
            Inserta_Detalle_Beneficiarios()
        Else

            'Actualizando valores en el Dataset
            For Each fila In vDetalle.Tables("Beneficiarios").Rows
                If Me.Txtnlinea.Text.Trim = fila("IdCuenta").ToString.Trim Then
                    fila("cNomBen") = Me.TxtcNomben.Text.Trim.ToUpper
                    fila("dnacimi") = Date.Parse(Me.Txtdnacimi.Text)
                    fila("cParent") = Me.CbxParentesco1.SelectedValue.Trim
                    fila("cDirecc") = Me.TxtcDirBen.Text.Trim
                    fila("nPorcen") = Double.Parse(Me.TxtnPorcen.Text)
                End If
            Next


            Me.GridBen.DataSource = vDetalle.Tables("Beneficiarios")
            Me.GridBen.DataBind()

        End If

        Limpia_Item()
    End Sub

    Protected Sub GridBen_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GridBen.SelectedIndexChanged
        'Me.TxtcDescriCta.Text = ""
        '        Busca_Item(Me.GridBen.SelectedRow.Cells(1).Text)

        Me.Txtnlinea.Text = Me.GridBen.SelectedRow.Cells(1).Text
        Me.TxtcNomben.Text = Me.GridBen.SelectedRow.Cells(2).Text
        Me.Txtdnacimi.Text = Me.GridBen.SelectedRow.Cells(3).Text
        Me.CbxParentesco1.SelectedValue = Me.GridBen.SelectedRow.Cells(4).Text
        Me.TxtcDirBen.Text = Me.GridBen.SelectedRow.Cells(5).Text
        Me.TxtnPorcen.Text = Me.GridBen.SelectedRow.Cells(6).Text
        Me.TxtnPorcen.Text = Format(Math.Round(Double.Parse(Me.TxtnPorcen.Text), 2), "#########.00")

    End Sub

    Protected Sub btnnew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnnew.Click

        If Me.TxtcCodcli.Text.Trim.Length = 0 Then
            codigoJs = "<script language='javascript'>alert('El Codigo de Socio no puede estar Vacio, " & _
                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

            'Response.Write("<script language='javascript'>alert('El Codigo de Socio no puede estar Vacio, " & _
            '                    "Advertencia SIM.NET ')</script>")

            Exit Sub
        End If

        'Limpieza()
        Limpia_Item()
        Limpia_Item1()
        Me.Habilita(True)
        Me.Habilita_Item(True)
        Habilita_Item1(True)
        Me.btnnew.Enabled = False
        Me.btnsave.Enabled = True
        Me.btncancel.Enabled = True
        '  Me.btnprint.Enabled = False

        vDetalle = cClsfir.CargaFirmas_()
        ViewState("Dataset") = vDetalle
    End Sub

    Protected Sub btnsave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsave.Click
        Dim vDetalle As New DataSet
        Dim lcNumcom As String = ""
        Dim pnTotpor As Double = 0
        Dim array_d As New ArrayList
        Dim pnTotint As Double = 0
        Dim dt_ben As New DataTable
        Dim dt_firm As New DataTable
        Dim lnRetorno As Integer = 0

        vDetalle = ViewState("Dataset")

        dt_ben = vDetalle.Tables("Beneficiarios")  'Beneficiarios
        dt_firm = vDetalle.Tables("Firmas")        'Firmas Autorizadas


        'Valida si porcentaje supera el 100%
        'If Not IsDBNull(vDetalle.Tables(0).Compute("sum(nPorcen)", "")) Then
        '    pnTotpor = vDetalle.Tables(0).Compute("sum(nPorcen)", "")
        'End If

        'If pnTotpor <> 100 Then
        '    codigoJs = "<script language='javascript'>alert('Los Beneficiarios no suman el 100%, " & _
        '                        "Advertencia SIM.NET ')</script>"
        '    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

        '    'Response.Write("<script language='javascript'>alert('Los Beneficiarios no suman el 100%, " & _
        '    '                    "Advertencia SIM.NET ')</script>")
        '    Exit Sub
        'End If


        'If dt_firm.Rows.Count = 0 Then
        '    codigoJs = "<script language='javascript'>alert('No Existen firmas Autorizadas, " & _
        '                        "Advertencia SIM.NET ')</script>"
        '    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

        '    'Response.Write("<script language='javascript'>alert('No Existen Firmas Autorizadas, " & _
        '    '                    "Advertencia SIM.NET ')</script>")
        '    Exit Sub
        'End If

        If Me.CbxLinAhoProd1.Items.Count = 0 Then
            codigoJs = "<script language='javascript'>alert('Seleccione un Producto Correcto, " & _
                                 "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('No existen Lineas Creadas, " & _
            '                     "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If


        If Me.CbxLinAhoProd1.SelectedValue.Trim = "00" Then
            codigoJs = "<script language='javascript'>alert('Seleccione un Producto Correcto, " & _
                                 "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Seleccione un Producto Correcto, " & _
            '                     "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        If Me.CbxTipAho1.SelectedValue.Trim = "00" Then
            codigoJs = "<script language='javascript'>alert('Seleccione una Frecuencia Correcta, " & _
                                 "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Seleccione un tipo de Ahorro Correcto, " & _
            '                     "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If


        If Not IsNumeric(Me.Txtnlibreta.Text) Then
            codigoJs = "<script language='javascript'>alert('Monto de Certificado Incorrecto, " & _
                                 "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Numero de Libreta Incorrecto, " & _
            '                     "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If



        array_d.Add(Me.Txtctitular.Text.Trim)              'Nombre del Titular
        array_d.Add(Me.TxtcCodcli.Text.Trim)               'Codigo del Titular
        array_d.Add(Me.TxtcCodaho.Text.Trim)               'No Cta de Ahorro
        array_d.Add(Date.Parse(Me.Txtdfeccnt.Text))        'Fecha
        array_d.Add(Integer.Parse(Me.Txtnlibreta.Text))    'No de Libreta
        array_d.Add(Me.CbxTipAho1.SelectedValue.Trim)      'Tipo de Ahorro
        array_d.Add(Me.CbxLinAhoProd1.SelectedValue.Trim)  'Linea de Ahorro
        array_d.Add(Session("GCCODOFI"))                   'Oficina
        array_d.Add(Session("GDFECSIS"))                   'Fecha de Modificación
        array_d.Add(Session("GCCODUSU"))                   'Usuario
        array_d.Add(Me.TxtcNombres.Text.Trim)              'Nombres
        array_d.Add(Me.TxtcApellidos.Text.Trim)            'Apellidos


        lnRetorno = cClsAho.Mantenimiento_Cta_Ahorro(array_d, dt_ben, dt_firm)

        If lnRetorno = 0 Then
            codigoJs = "<script language='javascript'>alert('Ocurrido un Error, " & _
                                 "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Ocurrido un Error, " & _
            '                     "Advertencia SIM.NET ')</script>")
            Exit Sub
        ElseIf lnRetorno = 2 Then
            codigoJs = "<script language='javascript'>alert('Correlativo de Libreta finalizado o Inactivo, " & _
                                 "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Correlativo de Libreta finalizado o Inactivo, " & _
            '                     "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If


        Limpia_Pagina()
        Me.CbxTipTran.SelectedValue = "00"
        'Me.btnprint.Enabled = False
        Me.btnsave.Enabled = False
        Me.btnnew.Enabled = True
        Me.btncancel.Enabled = False
        Me.TxtcCodcli.Text = ""
        Me.Txtctitular.Text = ""
    End Sub


    Protected Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        Me.Habilita(True)
        Me.Habilita_Item(True)
        Me.btnEdit.Enabled = False
        Me.btncancel.Enabled = True
        Me.btnsave.Enabled = True
    End Sub

    Protected Sub btncancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncancel.Click
        Me.btnsave.Enabled = False
        Me.btncancel.Enabled = False
        Me.btnnew.Enabled = True
        Me.Limpieza()
        Me.Limpia_Item()
        Me.Habilita(False)
        Me.Habilita_Item(False)
        'Me.btnprint.Enabled = False
    End Sub


    Protected Sub CbxTipTran_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxTipTran.SelectedIndexChanged
        Limpia_Pagina()    'Inicializa Ajuste Bancos

        Select Case CbxTipTran.SelectedValue.Trim
            Case "01"
                Me.MtvPrinci.SetActiveView(ViewFind)
            Case "02"
                'Me.Carga_Boton_Nuevo()
                Me.MtvPrinci.SetActiveView(ViewCtaAho)
        End Select
    End Sub

    Protected Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Buscar_Asociado()
        'Me.TxtcEvalua.Text = ""
        'Me.cbxTipBusq.SelectedValue = "00"
    End Sub

    Protected Sub Gridfind_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Gridfind.SelectedIndexChanged
        'Cheque_Seleccionado(Me.Gridfind.SelectedRow.Cells(1).Text)
        Me.TxtcCodcli.Text = Me.Gridfind.SelectedRow.Cells(1).Text
        Me.TxtcNombres.Text = Me.Gridfind.SelectedRow.Cells(2).Text
        Me.TxtcApellidos.Text = Me.Gridfind.SelectedRow.Cells(3).Text
        Me.TxtcApellidos.Text = Me.TxtcApellidos.Text.Replace("&#209;", "Ñ")

        'For Each li As ListItem In llBandera_Socio.Items
        '    If li.Selected = True Then
        '        Select Case li.Value
        '            Case Is = "01"
        '                Me.Txtctitular.Text = Me.Txtctitular.Text.Trim & " Y " & Me.Gridfind.SelectedRow.Cells(2).Text
        '            Case Is = "02"
        '                Me.Txtctitular.Text = Me.Txtctitular.Text.Trim & " O " & Me.Gridfind.SelectedRow.Cells(2).Text
        '            Case Else
        Me.Txtctitular.Text = Me.TxtcNombres.Text.Trim + " " + Me.TxtcApellidos.Text.Trim
        '        End Select
        '    End If
        'Next

        'Obtiene el numero sugerido de libreta
        Dim lnlibreta As Integer
        lnlibreta = eahomlib.ObtenerCorrelativoSugerido()

        Me.Txtnlibreta.Text = lnlibreta

        CbxTipTran.SelectedValue = "02"
        llBandera_Socio.SelectedValue = "03"
        Me.MtvPrinci.SetActiveView(ViewCtaAho)
    End Sub


    Protected Sub Grid_Lineas_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Gridfind.PageIndexChanging
        Gridfind.PageIndex = e.NewPageIndex
        Call Buscar_Asociado()
    End Sub

    Protected Sub Grid_Lineas_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Gridfind.RowDataBound
        If e.Row.RowType = DataControlRowType.Pager AndAlso Not Gridfind.DataSource Is Nothing Then
            'TRAE EL TOTAL DE PAGINAS
            Dim _TotalPags As Label = e.Row.FindControl("lblTotalNumberOfPages")
            _TotalPags.Text = Gridfind.PageCount.ToString

            'LLENA LA LISTA CON EL NUMERO DE PAGINAS
            Dim list As DropDownList = e.Row.FindControl("paginasDropDownList")
            For i As Integer = 1 To CInt(Gridfind.PageCount)
                list.Items.Add(i.ToString)
            Next
            list.SelectedValue = Gridfind.PageIndex + 1
        End If
    End Sub

    Protected Sub paginasDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim oIraPag As DropDownList = DirectCast(sender, DropDownList)
        Dim iNumPag As Integer = 0
        If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= Gridfind.PageCount Then
            If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= Gridfind.PageCount Then
                Gridfind.PageIndex = iNumPag - 1
            Else
                Gridfind.PageIndex = 0
            End If
        End If
        Call Buscar_Asociado()
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub




    Protected Sub GridBen_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridBen.RowDataBound
        Dim datt As New DataSet
        Dim nTotalPorcen As Double

        datt = ViewState("Dataset")

        nTotalPorcen = Nothing

        If e.Row.RowType = DataControlRowType.Footer Then
            For Each Fila As DataRow In datt.Tables("Beneficiarios").Rows
                nTotalPorcen = Double.Parse(IIf(nTotalPorcen = Nothing, 0, nTotalPorcen)) + _
                            Double.Parse(IIf(Fila.Item("nPorcen") = Nothing, 0, Fila.Item("nPorcen")))
            Next

            e.Row.Cells(4).Text = "TOTALES"
            e.Row.Cells(4).Font.Bold = True
            e.Row.Cells(6).Text = nTotalPorcen
            e.Row.Cells(6).Text = Format(Math.Round(Double.Parse(e.Row.Cells(6).Text), 2), "#########.00")
            e.Row.Cells(6).HorizontalAlign = HorizontalAlign.Left
            e.Row.Cells(6).Font.Bold = True

        End If
    End Sub


    Protected Sub btnproc0_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnproc0.Click
        'Valida No DUI 

        'Valida nombre de la firma
        If Me.TxtcNomFir.Text.Trim.Length = 0 Then
            codigoJs = "<script language='javascript'>alert('La Cuenta Contable esta Vacia, " & _
                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Nombre de la Firma vacia, " & _
            '                "Advertencia SIM.NET ')</script>")
            Exit Sub

        End If

        'Valida fecha de nacimiento
        If Me.Txtdnacimi0.Text.Trim.Length = 0 Then
            codigoJs = "<script language='javascript'>alert('La Cuenta Contable esta Vacia, " & _
                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('La fecha de nacimiento esta vacia, " & _
            '                "Advertencia SIM.NET ')</script>")
            Exit Sub

        End If

        'Valida No Documento
        If Me.TxtcnudociFir.Text.Trim.Length = 0 Then
            codigoJs = "<script language='javascript'>alert('La Cuenta Contable esta Vacia, " & _
                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Numero de DUI vacio, " & _
            '                "Advertencia SIM.NET ')</script>")
            Exit Sub

        End If


        If Not IsDate(Me.Txtdnacimi0.Text) Then
            codigoJs = "<script language='javascript'>alert('La Cuenta Contable esta Vacia, " & _
                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('La fecha no es valida, " & _
            '                "Advertencia SIM.NET ')</script>")
            Exit Sub

        End If

        Dim lcdui As String

        lcdui = Left(TxtcnudociFir.Text.Trim, 8) + "-" + Right(TxtcnudociFir.Text.Trim, 1)

        Dim lverifica As Boolean
        lverifica = clsppal.ValidaDUI(lcdui)
        If lverifica = False Then
            'Response.Write("<script language='javascript'>alert('Formato DUI Invalido, Advertencia SIM.NET')</script>")
            codigoJs = "<script language='javascript'>alert('Formato DUI Invalido, " & _
                  "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If


        vDetalle = ViewState("Dataset")

        '----------------------------------------------------------    
        'Valida si es modificacion o Nueva Linea
        '----------------------------------------------------------
        If Me.Txtnlinea0.Text.Trim = "0" Then
            Inserta_Detalle_Firmas()
        Else

            'Actualizando valores en el Dataset
            For Each fila In vDetalle.Tables("Firmas").Rows
                If Me.Txtnlinea0.Text.Trim = fila("IdCuenta").ToString.Trim Then
                    fila("cNomFir") = Me.TxtcNomFir.Text.Trim.ToUpper
                    fila("dnacimi") = Date.Parse(Me.Txtdnacimi0.Text)
                    fila("cnudoci") = Me.TxtcnudociFir.Text.Trim
                End If
            Next


            Me.GridFirm.DataSource = vDetalle.Tables("Firmas")
            Me.GridFirm.DataBind()

        End If

        Limpia_Item1()
    End Sub

    Protected Sub GridFirm_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridFirm.SelectedIndexChanged
        Me.Txtnlinea0.Text = Me.GridFirm.SelectedRow.Cells(1).Text
        Me.TxtcNomFir.Text = Me.GridFirm.SelectedRow.Cells(2).Text
        Me.Txtdnacimi0.Text = Me.GridFirm.SelectedRow.Cells(3).Text
        Me.TxtcnudociFir.Text = Me.GridFirm.SelectedRow.Cells(4).Text
    End Sub

   
    Protected Sub CbxTipAho1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxTipAho1.SelectedIndexChanged
        Me.CbxLinAhoProd1.Recuperar(Me.CbxTipAho1.SelectedValue.Trim)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class

