

Partial Class MenuIzquierdo
    Inherits ucWBase

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            If Request.IsAuthenticated Then GenerarMenu()
        End If
    End Sub

    'Private Sub GenerarMenu()
    '    Dim mControl As New cLogin
    '    Dim mListaOpciones As New listaopciones
    '    Dim mEntidad As New opciones
    '    'mListaOpciones = mControl.ObtenerListaOpciones(configuracion.idUsuario)
    '    mListaOpciones = mControl.ObtenerListaOpciones(Session("gnIdusuario"))
    '    Dim i As Integer
    '    i = -1
    '    Dim strLinea As New System.Text.StringBuilder
    '    strLinea.Append("<div id='masterdiv'>")
    '    For Each mEntidad In mListaOpciones
    '        If mEntidad.idOpcionPadre = 0 Then
    '            i += 1
    '            If i > 0 Then strLinea.Append("</span>")
    '            strLinea.Append("<div class='menutitle' onclick=""SwitchMenu('sub" + i.ToString() + "')"">")
    '            strLinea.Append("<FONT color=""FFCC00"" size=""1"">" + mEntidad.opcion + "</FONT></div>")
    '            strLinea.Append("<span class=""submenu"" id=""sub" + i.ToString() + """>")
    '        Else
    '            strLinea.Append("<FONT color=""#003399"" size='1'>- </FONT><A href='" + _
    '                            mEntidad.url + "'><FONT color=""#003399"" size='1'>" + _
    '                            mEntidad.opcion + "</FONT></A><br>")
    '        End If
    '    Next
    '    strLinea.Append("</span></div>")
    '    Me.DIV1.InnerHtml = strLinea.ToString()
    'End Sub


    Private Sub GenerarMenu()
        Dim mControl As New cLogin
        Dim mListaOpciones As New listaopciones
        Dim mEntidad As New opciones
        'mListaOpciones = mControl.ObtenerListaOpciones(configuracion.idUsuario)
        mListaOpciones = mControl.ObtenerListaOpciones(Session("gnIdusuario"))
        Dim i As Integer
        i = 0

        Dim lcdesini As String = ""
        Dim lcdesfin As String = ""
        Dim y As Integer = 0
        For Each mEntidad In mListaOpciones
            If mEntidad.idOpcionPadre = 0 Then
                If y = 0 Then
                    lcdesini = mEntidad.descripcion.Trim
                    y = 1
                Else
                    lcdesfin = mEntidad.descripcion.Trim
                End If

            End If
        Next

        Dim strLinea As New System.Text.StringBuilder

        strLinea.Append("<ul id='css3menu1' class='topmenu'>")
        Dim lcicon As String = ""
        For Each mEntidad In mListaOpciones
            'lcicon = mEntidad.icon.Trim
            If mEntidad.idOpcionPadre = 0 Then
                If i = 1 Then
                    strLinea.Append("</ul>")
                    strLinea.Append("</li>")
                    i = 0
                End If
                If lcdesini.Trim = mEntidad.descripcion.Trim Or lcdesfin.Trim = mEntidad.descripcion.Trim Then
                    If lcdesini.Trim = mEntidad.descripcion.Trim Then
                        strLinea.Append("<li class='topfirst'><a href='#' title=" + mEntidad.opcion + "><span>" + mEntidad.opcion + "</span></a>")
                    End If

                    If lcdesfin.Trim = mEntidad.descripcion.Trim Then
                        strLinea.Append("<li class='subfirst'><a href='#' title=" + mEntidad.opcion + "><span>" + mEntidad.opcion + "</span></a>")
                    End If

                Else
                    strLinea.Append("<li><a href='#' title=" + mEntidad.opcion + "><span>" + mEntidad.opcion + "</span></a>")
                End If


                strLinea.Append("<ul>")

            Else
                strLinea.Append("<li class='subfirst'><a href='" + mEntidad.url + "' title='" + mEntidad.opcion + "' >" + mEntidad.opcion + "</a></li>")
                i = 1
            End If
        Next

        strLinea.Append("<p style='display:none'><a href='http://css3menu.com/'>SIM.net</a></p>")
        Me.DIV1.InnerHtml = strLinea.ToString()

    End Sub
End Class


