Imports Microsoft.VisualBasic
Imports System.Data.Common
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections

Public Class lineas_ahorro
    Inherits ucWBase


#Region "Privadas"
    Private occlass As New cAhotlin
    Private codigoJs As String
#End Region


#Region "Metodos"

    Public Sub Cargar_Inicial()
        Dim ListaItem As New ListItem

        'ListaItem.Value = "00"
        'ListaItem.Text = "Selecccione una Opcion"

        'Agrega el Primer Registro

        'If Me.CbxCapitaliza1.Items.Count > 1 Then
        '    Me.CbxCapitaliza1.Items.Clear()
        'End If

        ' Me.CbxCapitaliza1.Items.Add(ListaItem)

        '        Me.CbxCapitaliza1.Recuperar()


        If Me.CbxInst1.Items.Count > 1 Then
            Me.CbxInst1.Items.Clear()
        End If

        'Me.CbxInst1.Items.Add(ListaItem)

        Me.CbxInst1.Recuperar()

        If Me.CbxMoneda1.Items.Count > 1 Then
            Me.CbxMoneda1.Items.Clear()
        End If

        'Me.CbxMoneda1.Items.Add(ListaItem)

        Me.CbxMoneda1.Recuperar()

        If Me.CbxTipAho1.Items.Count > 1 Then
            Me.CbxTipAho1.Items.Clear()
        End If

        'Me.CbxTipAho1.Items.Add(ListaItem)

        Me.CbxTipAho1.Recuperar()

        'If Me.CbxSectorAho1.Items.Count() > 1 Then
        '    Me.CbxSectorAho1.Items.Clear()
        'End If

        'Me.CbxSectorAho1.Items.Add(ListaItem)

        '       Me.CbxSectorAho1.Recuperar()

        Limpieza()

    End Sub


    Private Sub Genera_Codigo_Linea()
        Dim pccodlin As String = Me.CbxMoneda1.SelectedValue.Trim & "." & _
                                Me.CbxCapitaliza1.SelectedValue.Trim & "." & _
                                Me.CbxTipAho1.SelectedValue.Trim & "." & _
                                "01" & "." & _
                                Me.CbxSectorAho1.SelectedValue.Trim

        Me.TxtcCodlin.Text = pccodlin

    End Sub

#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
    End Sub

   
    Public Sub CargarPorlinea(ByVal cnrolin As String)
        Dim eahotlin As New ahotlin
        Dim mahotlin As New cAhotlin

        eahotlin.cnrolin = cnrolin
        mahotlin.ObtenerAhotlin(eahotlin)


        Me.Txtcnrolin.Text = cnrolin                                                    'No de Linea   
        'Me.inferior_TextBox.Text = eahotlin.nliminf  'Presupuesto Inferior
        'Me.superior_TextBox.Text = eahotlin.nlimsup  'Presupuesto Superior
        Me.CbxInst1.SelectedValue = "001"
        Me.CbxMoneda1.SelectedValue = Left(eahotlin.ccodlin, 1)
        Me.CbxCapitaliza1.SelectedValue = eahotlin.ccodlin.Substring(1, 2)
        Me.CbxTipAho1.SelectedValue = eahotlin.ccodlin.Substring(3, 2)
        Me.CbxSectorAho1.SelectedValue = eahotlin.ccodlin.Substring(7, 2)

        Genera_Codigo_Linea()

        If eahotlin.lactiva = True Then
            Me.cmbEstado.SelectedValue = "1"
        Else
            Me.cmbEstado.SelectedValue = "2"
        End If

        Me.txtntasamax.Text = eahotlin.ntasmax
        Me.txtntasamin.Text = eahotlin.ntasmin
        Me.txtnmonmin.Text = eahotlin.nliminf
        Me.txtnmonmax.Text = eahotlin.nlimsup
        Me.txtnplazomin.Text = eahotlin.nplainf
        Me.txtnplazomax.Text = eahotlin.nplasup
        Me.txtcDesprod.Text = eahotlin.cdeslin.Trim
        Me.txtntasa.text = eahotlin.ntasint

        'Habilita(True)
        Me.btnEdit.Enabled = True
        'Me.btnnew.Enabled = True
    End Sub


    Private Sub Habilita(ByVal Bandera As Boolean)
        Me.CbxCapitaliza1.Enabled = Bandera
        Me.CbxInst1.Enabled = Bandera
        Me.CbxMoneda1.Enabled = Bandera
        Me.CbxTipAho1.Enabled = Bandera
        Me.cmbEstado.Enabled = Bandera
        Me.CbxSectorAho1.Enabled = Bandera
        Me.txtntasamax.Enabled = Bandera
        Me.txtntasamin.Enabled = Bandera
        Me.txtnmonmin.Enabled = Bandera
        Me.txtntasa.Enabled = Bandera
        Me.txtnmonmax.Enabled = Bandera
        Me.txtnplazomax.Enabled = Bandera
        Me.txtnplazomin.Enabled = Bandera
        Me.txtcDesprod.Enabled = Bandera
    End Sub


    Private Sub Limpieza()
        Me.CbxCapitaliza1.SelectedValue = "00"
        Me.CbxInst1.SelectedValue = "00"
        Me.CbxMoneda1.SelectedValue = "00"
        Me.CbxTipAho1.SelectedValue = "00"
        Me.CbxSectorAho1.SelectedValue = "00"
        Me.cmbEstado.SelectedValue = "00"
        Me.txtntasamax.Text = "0.0"
        Me.txtntasamin.Text = "0.0"
        Me.txtnmonmin.Text = "0.0"
        Me.txtnmonmax.Text = "0.0"
        Me.txtntasa.Text = "0.0"
        Me.txtnplazomax.Text = "0"
        Me.txtnplazomin.Text = "0"
        Me.txtcDesprod.Text = ""
        Me.TxtcCodlin.Text = ""
        Me.TxtFecVig.Text = Session("GDFECSIS")
        Me.Txtcnrolin.Text = ""
    End Sub

   
   

    Protected Sub btnnew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Habilita(True)
        btnnew.Enabled = False
        Btnsave.Enabled = True
    End Sub

    Protected Sub Btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnsave.Click

        Dim pccodlin As String = Me.CbxMoneda1.SelectedValue.Trim & _
                                Me.CbxCapitaliza1.SelectedValue.Trim & _
                                Me.CbxTipAho1.SelectedValue.Trim & _
                                Me.CbxInst1.SelectedValue.Trim & _
                                Me.CbxSectorAho1.SelectedValue.Trim



        Dim array_d As New ArrayList
        Dim lnRetorno As Integer = 0


        If Me.CbxMoneda1.SelectedValue.Trim = "00" Then
            codigoJs = "<script language='javascript'>alert('Debe seleccionar una opción valida, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Debe seleccionar una opción valida, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If


        If Me.CbxCapitaliza1.SelectedValue.Trim = "00" Then
            codigoJs = "<script language='javascript'>alert('Debe seleccionar una opción valida, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Debe seleccionar una opción valida, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If


        If Me.CbxTipAho1.SelectedValue.Trim = "00" Then
            codigoJs = "<script language='javascript'>alert('Debe seleccionar una opción valida, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            
            Exit Sub
        End If


        If Me.CbxTipAho1.SelectedValue.Trim <> "07" And Double.Parse(Me.txtntasa.Text) = 0 Then
            codigoJs = "<script language='javascript'>alert('Debe seleccionar una opción valida, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Tasa no puede ser cero, " & _
            '               "Advertencia SIM.NET ')</script>")
        End If

        If Me.CbxSectorAho1.SelectedValue.Trim = "00" Then
            codigoJs = "<script language='javascript'>alert('Debe seleccionar una opción valida, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Debe seleccionar una opción valida, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        If Me.CbxInst1.SelectedValue.Trim = "00" Then
            codigoJs = "<script language='javascript'>alert('Debe seleccionar una opción valida, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Debe seleccionar una opción valida, " & _
            '             "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        If Me.cmbEstado.SelectedValue.Trim = "00" Then
            codigoJs = "<script language='javascript'>alert('Debe seleccionar una opción valida, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Debe seleccionar una opción valida, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If


        If Me.txtcDesprod.Text.Trim.Length = 0 Then
            codigoJs = "<script language='javascript'>alert('Descripción de Linea Vacia, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Descripción de Linea Vacia, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        If Not IsNumeric(Me.txtntasamin.Text) Then
            codigoJs = "<script language='javascript'>alert('Digite un número correcto, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Digite un número correcto, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub

        End If

        If Not IsNumeric(Me.txtntasamax.Text) Then
            codigoJs = "<script language='javascript'>alert('Digite un número correcto, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Digite un número correcto, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        If Not IsNumeric(Me.txtnmonmin.Text) Then
            codigoJs = "<script language='javascript'>alert('Digite un número correcto, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Digite un número correcto, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        If Not IsNumeric(Me.txtnmonmax.Text) Then
            codigoJs = "<script language='javascript'>alert('Digite un número correcto, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Digite un número correcto, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        If Not IsNumeric(Me.txtnplazomin.Text) Then
            codigoJs = "<script language='javascript'>alert('Digite un número correcto, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Digite un número correcto, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        'If Not IsNumeric(Me.txtnplazomax.Text) Then
        '    'codigoJs = "<script language='javascript'>alert('Digite un número correcto, " & _
        '    '           "Advertencia SIM.NET ')</script>"
        '    'ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
        '    Response.Write("<script language='javascript'>alert('Digite un número correcto, " & _
        '                   "Advertencia SIM.NET ')</script>")
        '    Exit Sub
        'End If


        'Valida Rango de Plazos
        'If Integer.Parse(Me.txtnplazomin.Text) > Integer.Parse(Me.txtnplazomax.Text) Then
        '    'codigoJs = "<script language='javascript'>alert('Plazo Incorrecto " & _
        '    '           "Advertencia SIM.NET ')</script>"
        '    'ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
        '    Response.Write("<script language='javascript'>alert('Plazo Incorrecto, " & _
        '                   "Advertencia SIM.NET ')</script>")
        '    Exit Sub
        'End If


        'Valida Rangos de Montos
        If Double.Parse(Me.txtnmonmin.Text) > Double.Parse(Me.txtnmonmax.Text) Then
            codigoJs = "<script language='javascript'>alert('Incosistencias en Montos " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Incosistencias en Montos, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        'Valida Rango de Tasas
        If Double.Parse(Me.txtntasamin.Text) > Double.Parse(Me.txtntasamax.Text) Then
            codigoJs = "<script language='javascript'>alert('Tasa Incorrecta " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Tasa Incorrecta, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If


        'Valida Plazos cero
        If Integer.Parse(Me.txtnplazomin.Text) = 0 And Integer.Parse(Me.txtnplazomax.Text) = 0 And CbxTipAho1.SelectedValue.Trim = "07" Then
            codigoJs = "<script language='javascript'>alert('Plazo cero, no se puede continuar,  " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Plazo cero, no se puede continuar, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        'Valida Rangos de Montos cero
        If Double.Parse(Me.txtnmonmin.Text) = 0 And Double.Parse(Me.txtnmonmax.Text) = 0 Then
            codigoJs = "<script language='javascript'>alert('Rango de Monto en cero, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('IRango de Monto en cero, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        ''Valida Rango de Tasas cero
        'If Double.Parse(Me.txtntasamin.Text) = 0 And Double.Parse(Me.txtntasamax.Text) = 0 Then
        '    'codigoJs = "<script language='javascript'>alert('Tasa cero, no se puede continuar " & _
        '    '           "Advertencia SIM.NET ')</script>"
        '    'ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
        '    Response.Write("<script language='javascript'>alert('Tasa cero, no se puede continuar, " & _
        '                   "Advertencia SIM.NET ')</script>")
        '    Exit Sub
        'End If


        'Valida Rango de Tasas cero
        If Double.Parse(Me.txtntasamin.Text) = 0 Then
            codigoJs = "<script language='javascript'>alert('Tasa cero, no se puede continuar " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Tasa cero, no se puede continuar, " & _
            '               "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If


        Me.TxtcCodlin.Text = Me.TxtcCodlin.Text.Trim.Replace(".", "")

        array_d.Add(Me.Txtcnrolin.Text.Trim)            ' No Linea
        array_d.Add(Me.TxtcCodlin.Text.Trim)            ' Codigo de Linea
        array_d.Add(Date.Parse(Me.TxtFecVig.Text))      ' Fecha de Linea
        array_d.Add(Double.Parse(Me.txtntasamin.Text))  ' Tasa Minima
        array_d.Add(Double.Parse(Me.txtntasamax.Text))  ' Tasa Maxima
        array_d.Add(Double.Parse(Me.txtnmonmin.Text))   ' Monto Minimo
        array_d.Add(Double.Parse(Me.txtnmonmax.Text))   ' Monto Maximo
        array_d.Add(Double.Parse(Me.txtnplazomin.Text)) ' Plazo Minimo
        array_d.Add(Double.Parse(Me.txtnplazomin.Text)) ' Plazo Máximo  'Modificado
        'array_d.Add(Double.Parse(Me.txtnplazomax.Text)) ' Plazo Maximo
        array_d.Add(Me.cmbEstado.SelectedValue.Trim)    ' Estado de Linea
        array_d.Add(Me.txtcDesprod.Text.Trim)           ' Descripción de Linea
        array_d.Add(Session("GDFECSIS"))                ' Fecha de Modificación
        array_d.Add(Session("GCCODUSU"))                ' Usuario
        array_d.Add(Double.Parse(Me.txtntasa.text))     ' Tasa fija para ahorro no a plazo


        lnRetorno = occlass.Mantenimiento_Lineas(array_d)

        If lnRetorno = 0 Then
            codigoJs = "<script language='javascript'>alert('Ocurrio un Error, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            

            Exit Sub
        ElseIf lnRetorno = 2 Then
            codigoJs = "<script language='javascript'>alert('Ya existe una linea con los parametros digitados, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Advertencia", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('Ya existe una linea con los parametros digitados, " & _
            '               "Advertencia SIM.NET ')</script>")

            Exit Sub

        End If



        Habilita(False)
        Limpieza()
        btnnew.Enabled = True
        Btnsave.Enabled = False
    End Sub

    Protected Sub cmbEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectedIndexChanged
        Dim tam As Integer = CbxTipAho1.SelectedItem.Text.ToString.Trim.Length
        Me.txtcDesprod.Text = "AHORRO " & CbxTipAho1.SelectedItem.Text.Trim.Substring(9, tam - 9) & _
                                                  " Tasa Minima " & txtntasamin.Text.ToString.Trim & "%" & ", Tasa Maxima " & _
                                                  txtntasamax.Text.ToString.Trim & "%, Plazo Minimo " & Me.txtnplazomin.Text.Trim & " Días " & _
                                                  " Plazo Máximo " & Me.txtnplazomax.Text.Trim & " Días "
    End Sub

    Protected Sub CbxMoneda1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxMoneda1.SelectedIndexChanged
        Genera_Codigo_Linea()
    End Sub

    Protected Sub CbxCapitaliza1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxCapitaliza1.SelectedIndexChanged
        Genera_Codigo_Linea()
    End Sub

    Protected Sub CbxTipAho1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxTipAho1.SelectedIndexChanged
        Genera_Codigo_Linea()
        If Me.CbxTipAho1.Selectedvalue.trim = "07" Then
            Me.txtntasa.enabled = False
        Else
            Me.txtntasa.enabled = True
        End If
    End Sub

    Protected Sub CbxSectorAho1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxSectorAho1.SelectedIndexChanged
        Genera_Codigo_Linea()
    End Sub

    Protected Sub CbxInst1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxInst1.SelectedIndexChanged
        Genera_Codigo_Linea()
    End Sub


    Protected Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Habilita(True)
        Me.btnEdit.Enabled = False
        Me.btnnew.Enabled = False
        Me.Btnsave.Enabled = True
    End Sub
End Class
