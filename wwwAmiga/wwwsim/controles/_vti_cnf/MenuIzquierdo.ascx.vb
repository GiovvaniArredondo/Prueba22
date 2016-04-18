Public Class MenuIzquierdo
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DIV1 As System.Web.UI.HtmlControls.HtmlGenericControl

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            If Request.IsAuthenticated Then GenerarMenu()
        End If
    End Sub

    Private Sub GenerarMenu()
        Dim mControl As New cLogin
        Dim mListaOpciones As New listaopciones
        Dim mEntidad As New opciones
        mListaOpciones = mControl.ObtenerListaOpciones(configuracion.idUsuario)

        Dim i As Integer
        i = -1
        Dim strLinea As New System.Text.StringBuilder
        strLinea.Append("<div id='masterdiv'>")
        For Each mEntidad In mListaOpciones
            If mEntidad.idOpcionPadre = 0 Then
                i += 1
                If i > 0 Then strLinea.Append("</span>")
                strLinea.Append("<div class='menutitle' onclick=""SwitchMenu('sub" + i.ToString() + "')"">")
                strLinea.Append("<FONT size=""1"">" + mEntidad.opcion + "</FONT></div>")

                strLinea.Append("<span class=""submenu"" id=""sub" + i.ToString() + """>")
            Else
                strLinea.Append("<FONT size='1'>- </FONT><A href='" + _
                                mEntidad.url + "'><FONT size='1'>" + _
                                mEntidad.opcion + "</FONT></A><br>")
            End If
        Next
        strLinea.Append("</span></div>")
        Me.DIV1.InnerHtml = strLinea.ToString()
    End Sub
End Class
