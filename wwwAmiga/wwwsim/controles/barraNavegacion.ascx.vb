

Partial Class barraNavegacion
    Inherits ucWBase

    Public Event Guardar As EventHandler
    Public Event Agregar As EventHandler
    Public Event Editar As EventHandler
    Public Event Cancelar As EventHandler
    Public Event Eliminar As EventHandler
    Public Event Inicio As EventHandler
    Public Event Anterior As EventHandler
    Public Event Siguiente As EventHandler
    Public Event Fin As EventHandler

    Public Property PermitirAgregar() As Boolean
        Get
            Return Me.ibtnAgregar.Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.ibtnAgregar.Visible = Value
        End Set
    End Property

    Public Property PermitirEditar() As Boolean
        Get
            Return Me.ibtnEditarCancelar.Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.ibtnEditarCancelar.Visible = Value
            If Value Then
                Me.PermitirGuardar = True
            End If
        End Set
    End Property

    Public Property PermitirGuardar() As Boolean
        Get
            Return Me.ibtnGuardar.Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.ibtnGuardar.Visible = Value
        End Set
    End Property

    Public Property Navegacion() As Boolean
        Get
            Return True
        End Get
        Set(ByVal Value As Boolean)
            If Not Value Then
                Me.ibtnInicio.Visible = False
                Me.ibtnAnterior.Visible = False
                Me.ibtnSiguiente.Visible = False
                Me.ibtnFin.Visible = False
                Me.lblDe.Visible = False
                Me.lblRegistroActual.Visible = False
                Me.lblRegistros.Visible = False
                Me.lblTotalRegistros.Visible = False
            Else
                Me.ibtnInicio.Visible = True
                Me.ibtnAnterior.Visible = True
                Me.ibtnSiguiente.Visible = True
                Me.ibtnFin.Visible = True
                Me.lblDe.Visible = True
                Me.lblRegistroActual.Visible = True
                Me.lblRegistros.Visible = True
                Me.lblTotalRegistros.Visible = True
            End If
        End Set
    End Property

    Public Property Indice() As Integer
        Get
            Return CInt(Me.lblRegistroActual.Text)
        End Get
        Set(ByVal Value As Integer)
            Me.lblRegistroActual.Text = CStr(Value)
        End Set
    End Property

    Public Property Total() As Integer
        Get
            Return CInt(Me.lblTotalRegistros.Text)
        End Get
        Set(ByVal Value As Integer)
            Me.lblTotalRegistros.Text = CStr(Value)
            If Value = 0 Then
                Me.Indice = 0
                Me.ibtnEditarCancelar.Enabled = False
                Me.ibtnGuardar.Enabled = False
            End If
            Me.HabilitarNavegacion()
        End Set
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Private Sub ibtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibtnAgregar.Click
        Me.HabilitarEdicion(True)
        RaiseEvent Agregar(sender, e)
    End Sub

    Private Sub ibtnEditarCancelar_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibtnEditarCancelar.Click
        If Me.ibtnEditarCancelar.ImageUrl = "../Imagenes/Editar.gif" Then
            Me.HabilitarEdicion(True)
            RaiseEvent Editar(sender, e)
        Else
            Me.HabilitarEdicion(False)
            Try
                If Not Me.Total > 0 Then
                    Me.ibtnEditarCancelar.Enabled = False
                End If
            Catch ex As Exception
            Finally
                RaiseEvent Cancelar(sender, e)
            End Try
        End If
    End Sub

    Private Sub ibtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibtnGuardar.Click
        RaiseEvent Guardar(sender, e)
    End Sub

    Private Sub HabilitarNavegacion()
        If CInt(Me.lblTotalRegistros.Text) > 1 Then
            If CInt(Me.lblRegistroActual.Text) = 1 Then
                Me.ibtnAnterior.Enabled = False
                Me.ibtnInicio.Enabled = False
                Me.ibtnSiguiente.Enabled = True
                Me.ibtnFin.Enabled = True
            End If
            If CInt(Me.lblRegistroActual.Text) = CInt(Me.lblTotalRegistros.Text) Then
                Me.ibtnAnterior.Enabled = True
                Me.ibtnInicio.Enabled = True
                Me.ibtnSiguiente.Enabled = False
                Me.ibtnFin.Enabled = False
            End If
        Else
            Me.ibtnAnterior.Enabled = False
            Me.ibtnInicio.Enabled = False
            Me.ibtnSiguiente.Enabled = False
            Me.ibtnFin.Enabled = False
        End If
    End Sub

    Public Sub HabilitarEdicion(ByVal edicion As Boolean)
        If edicion Then
            Me.ibtnEditarCancelar.ImageUrl = "../Imagenes/Cancelar.gif"
        Else
            Me.ibtnEditarCancelar.ImageUrl = "../Imagenes/Editar.gif"
        End If
        Me.ibtnEditarCancelar.Enabled = True
        Me.ibtnAgregar.Enabled = Not edicion
        Me.ibtnGuardar.Enabled = edicion
    End Sub

    Private Sub ibtnInicio_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibtnInicio.Click
        Me.Indice = 1
        RaiseEvent Inicio(sender, e)
    End Sub

    Private Sub ibtnAnterior_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibtnAnterior.Click
        Me.Indice -= 1
        RaiseEvent Anterior(sender, e)
    End Sub

    Private Sub ibtnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibtnSiguiente.Click
        If Me.Total > Me.Indice Then
            Me.Indice += 1
            RaiseEvent Siguiente(sender, e)
        End If
    End Sub

    Private Sub ibtnFin_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibtnFin.Click
        Me.Indice = Me.Total
        RaiseEvent Fin(sender, e)
    End Sub

End Class


