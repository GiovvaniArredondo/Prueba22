

Partial Class cuwLoteAna
    Inherits ucWBase
    Private pcCodCta As String
    Private pcCodPre As String

    Dim mTabtZon As New listatabtzon

    Dim clsTabtZon As New SIM.BL.cTabtzon
    Dim clstabttab As New cTabttab

#Region "Variable"
    'Variable de la clase Mantenimiento
    Private cls1 As New SIM.bl.ClsMantenimiento
    Private Transacc As String
    Private ds As New DataSet
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub
    Private Sub CargarDatos()


        '----------------------------
        'Llenando Analistas
        '----------------------------
        lnparametro1_R = "cNomUsu , cCodUsu, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTUSU"
        lnparametro5_R = "S"

        Dim lccodofi As String = Session("gccodofi")
        If lccodofi = "001" Then
            lnparametro6_R = "Where cCatego ='ANA' order by CNOMUSU "
        Else
            lnparametro6_R = "Where cCatego ='ANA' and cCodofi =" & lccodofi.Trim & " order by CNOMUSU "
        End If

        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Me.cmbanaact.DataTextField = "cNomUsu"
        Me.cmbanaact.DataValueField = "cCodUsu"
        Me.cmbanaact.DataSource = ds.Tables("Resultado")
        Me.cmbanaact.DataBind()

        Me.cmbananue.DataTextField = "cNomUsu"
        Me.cmbananue.DataValueField = "cCodUsu"
        Me.cmbananue.DataSource = ds.Tables("Resultado")
        Me.cmbananue.DataBind()

        'Me.cbxanacre.DropDownWidth = 300
        ds.Tables("Resultado").Clear()

        Dim mListaTabttab2 As New listatabttab
        Dim mListaTabttab3 As New listatabttab
        Dim mListaTabttab6 As New listatabttab

        mlistatabttab6 = clstabttab.ObtenerLista("125", "1")

        Me.ddlgarantia.DataTextField = "cdescri"
        Me.ddlgarantia.DataValueField = "ccodigo"
        Me.ddlgarantia.DataSource = mlistatabttab6
        Me.ddlgarantia.DataBind()

        mListaTabttab3 = clstabttab.ObtenerLista("033", "1")
        Me.ddlfondos.DataTextField = "cdescri"
        Me.ddlfondos.DataValueField = "ccodigo"
        Me.ddlfondos.DataSource = mListaTabttab3
        Me.ddlfondos.DataBind()

        mListaTabttab2 = clstabttab.ObtenerLista("034", "1")
        ' cartera
        Me.ddlcartera.DataTextField = "cdescri"
        Me.ddlcartera.DataValueField = "ccodigo"
        Me.ddlcartera.DataSource = mListaTabttab2
        Me.ddlcartera.DataBind()
        CargaLineaAuxiliar()


        'Departamento
        mTabtZon = clsTabtZon.ObtenerLista("1")
        Me.DropDownDeptos.DataTextField = "cDesZon"
        Me.DropDownDeptos.DataValueField = "cCodzon"
        Me.DropDownDeptos.DataSource = mTabtZon
        Me.DropDownDeptos.DataBind()
        'Me.CargaDepartamentos()


      

        ''Municipio
        mTabtZon = clsTabtZon.ObtenerLista("2")
        Me.DropDownMuni.DataTextField = "cDesZon"
        Me.DropDownMuni.DataValueField = "cCodzon"
        Me.DropDownMuni.DataSource = mTabtZon
        Me.DropDownMuni.DataBind()


        ''Canton
        mTabtZon = clsTabtZon.ObtenerLista("3")
        Me.DropDownComu.DataTextField = "cDesZon"
        Me.DropDownComu.DataValueField = "cCodzon"
        Me.DropDownComu.DataSource = mTabtZon
        Me.DropDownComu.DataBind()

        BuscaMunicipios()
        BuscaCantones()

        '---------------------------
        'Tipo
        '---------------------------
        Dim mlistatabttab As New listatabttab

        mListaTabttab = clstabttab.ObtenerLista("122", "1")

        Me.ddltipo.DataTextField = "cdescri"
        Me.ddltipo.DataValueField = "ccodigo"
        Me.ddltipo.DataSource = mListaTabttab
        Me.ddltipo.DataBind()
    End Sub
    Public Sub BuscaMunicipios()

        Me.DropDownMuni.Items.Clear()

        Dim clsTabtZon As New SIM.BL.cTabtzon
        Dim mTabtZon As New listatabtzon

        'Municipio
        mTabtZon = clsTabtZon.ObtenerLista1(Me.DropDownDeptos.SelectedItem.Value.Trim, "2")
        Me.DropDownMuni.DataTextField = "cDesZon"
        Me.DropDownMuni.DataValueField = "cCodzon"
        Me.DropDownMuni.DataSource = mTabtZon
        Me.DropDownMuni.DataBind()


    End Sub
    Public Sub BuscaCantones()

        Me.DropDownComu.Items.Clear()

        Dim clsTabtZon As New SIM.BL.cTabtzon
        Dim mTabtZon As New listatabtzon

        'Municipio
        mTabtZon = clsTabtZon.ObtenerLista1(Me.DropDownMuni.SelectedItem.Value.Trim, "3")
        Me.DropDownComu.DataTextField = "cDesZon"
        Me.DropDownComu.DataValueField = "cCodzon"
        Me.DropDownComu.DataSource = mTabtZon
        Me.DropDownComu.DataBind()

    End Sub
    Private Sub CargaLineaAuxiliar()
        Dim ds As New DataSet
        Dim ecretlin As New cCretlin
        ds = ecretlin.ObtenerProducto(ddlcartera.SelectedValue.Trim, ddlgarantia.selectedvalue.trim)


        Me.ddlprogramas.DataTextField = "cdescri"
        Me.ddlprogramas.DataValueField = "ccodigo"
        Me.ddlprogramas.DataSource = ds.Tables(0)
        Me.ddlprogramas.DataBind()

        If ddlprogramas.Items.Count = 0 Then
            Response.Write("<script language='javascript'>alert('No Existe Producto Definido')</script>")
            Exit Sub
        End If
    End Sub
   

   
    Private Sub Cancela()
    End Sub

 
    Protected Sub DropDownDeptos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownDeptos.SelectedIndexChanged
        BuscaMunicipios()
        BuscaCantones()
    End Sub

    Protected Sub DropDownMuni_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownMuni.SelectedIndexChanged
        BuscaCantones()
    End Sub

    Protected Sub ddlcartera_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlcartera.SelectedIndexChanged
        CargaLineaAuxiliar()
    End Sub

    Protected Sub btntrasladar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btntrasladar.Click
        'Validaciones-----

        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True And CheckBox4.Checked = True And _
           CheckBox5.Checked = True And CheckBox6.Checked = True And CheckBox7.Checked = True And CheckBox8.Checked = True And _
           CheckBox9.Checked = True Then
            Response.Write("<script language='javascript'>alert('Combinación No Aplica')</script>")
            Exit Sub
        End If
        If ddlprogramas.Items.Count = 0 And CheckBox4.Checked = False Then
            Response.Write("<script language='javascript'>alert('Producto No Encontrado')</script>")
            Exit Sub
        End If
        '----->-<Establece parametros de traslado>-<-------
        Dim lccodanaact As String, lcmetodo As String, lcprogra As String, lcproducto As String
        Dim lcfondo As String, lcdepa As String, lcmuni As String, lcaldea As String, lctipo As String
        If CheckBox1.Checked = True Then
            lccodanaact = ""
        Else
            lccodanaact = cmbanaact.SelectedValue.Trim.Trim
        End If
        If CheckBox2.Checked = True Then
            lcmetodo = ""
        Else
            lcmetodo = ddlgarantia.SelectedValue.Trim
        End If
        If CheckBox3.Checked = True Then
            lcprogra = ""
        Else
            lcprogra = ddlcartera.SelectedValue.Trim
        End If
        If CheckBox4.Checked = True Then
            lcproducto = ""
        Else
            lcproducto = ddlprogramas.SelectedValue.Trim
        End If
        If CheckBox5.Checked = True Then
            lcfondo = ""
        Else
            lcfondo = ddlfondos.SelectedValue
        End If
        If CheckBox6.Checked = True Then
            lcdepa = ""
        Else
            lcdepa = DropDownDeptos.SelectedValue.Trim
        End If
        If CheckBox7.Checked = True Then
            lcmuni = ""
        Else
            lcmuni = DropDownMuni.SelectedValue.Trim
        End If
        If CheckBox8.Checked = True Then
            lcaldea = ""
        Else
            lcaldea = DropDownComu.SelectedValue.Trim
        End If
        If CheckBox9.Checked = True Then
            lctipo = ""
        Else
            lctipo = ddltipo.SelectedValue.Trim
        End If

        Dim i As Integer
        Dim ecreditos As New ccreditos
        i = ecreditos.Trasladar_Analista_Lote(lccodanaact, lcmetodo, lcprogra, lcproducto, lcfondo, lcdepa, lcmuni, lcaldea, cmbananue.SelectedValue.Trim, lctipo)

        If i = 1 Then
            Response.Write("<script language='javascript'>alert('Se realizo el Traslado')</script>")

        Else
            Response.Write("<script language='javascript'>alert('Ocurrio un Problema')</script>")
        End If

    End Sub

   
End Class


