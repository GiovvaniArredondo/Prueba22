

Partial Class VistaDetalleCremcre
    Inherits ucWBase
 
    Private _ccodcta As String
    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Protected WithEvents dsDatos As System.Data.DataSet
    Private mComponente As New cCremcre
    Private mEntidad As Cremcre
    Public Event ErrorEvent(ByVal errorMessage As String)
 
    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property
 
    Public Property ccodcta() As String
        Get
            Return Me._ccodcta
        End Get
        Set(ByVal Value As String)
            Me._ccodcta = Value
            If Me._ccodcta > 0 Then
                Me.CargarDatos()
            Else
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property
 
    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property
 
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        If Not Me.ViewState("nuevo") Is Nothing Then
            Me._nuevo = Me.ViewState("nuevo")
        End If
 
    End Sub
 
    Private Sub CargarDatos()
        Dim sError As New String("")
        mEntidad = New Cremcre
        mEntidad.ccodcta = ccodcta
 
        If mComponente.ObtenerCremcre(mEntidad) <> 1 Then
            Dim e As EventArgs
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtccodcta.Text = mEntidad.ccodcta
        'Me.ddlcCodofi.SelectedValue = mEntidad.cCodofi
        Me.txtccodprd.Text = mEntidad.ccodprd
        Me.txtcmoneda.Text = mEntidad.cmoneda
        Me.txtcestado.Text = mEntidad.cestado
        Me.txtccodcli.Text = mEntidad.ccodcli
        Me.txtccatego.Text = mEntidad.ccatego
        Me.txtccodfue.Text = mEntidad.ccodfue
        'Me.ddlccodact.SelectedValue = mEntidad.ccodact
        Me.txtctipcre.Text = mEntidad.ctipcre
        Me.txtcdescre.Text = mEntidad.cdescre
        Me.txtctipcuo.Text = mEntidad.ctipcuo
        Me.txtctipper.Text = mEntidad.ctipper
        Me.txtntipperc.Text = mEntidad.ntipperc
        Me.txtcctapre.Text = mEntidad.cctapre
        Me.txtcnorref.Text = mEntidad.cnorref
        Me.txtccodana.Text = mEntidad.ccodana
        Me.txtdfecasi.Text = mEntidad.dfecasi
        Me.txtdfecsol.Text = mEntidad.dfecsol
        Me.txtnmonsol.Text = mEntidad.nmonsol
        Me.txtnmonsug.Text = mEntidad.nmonsug
        Me.txtncuosug.Text = mEntidad.ncuosug
        Me.txtndessug.Text = mEntidad.ndessug
        Me.txtndiasug.Text = mEntidad.ndiasug
        Me.txtndiagra.Text = mEntidad.ndiagra
        Me.txtdfecapr.Text = mEntidad.dfecapr
        Me.txtdfecven.Text = mEntidad.dfecven
        Me.txtnmonapr.Text = mEntidad.nmonapr
        Me.txtnmoncuo.Text = mEntidad.nmoncuo
        Me.txtnintapr.Text = mEntidad.nintapr
        Me.txtncuoapr.Text = mEntidad.ncuoapr
        Me.txtndiaapr.Text = mEntidad.ndiaapr
        Me.txtndesapr.Text = mEntidad.ndesapr
        'Me.ddlcnrolin.SelectedValue = mEntidad.cnrolin
        Me.txtntasint.Text = mEntidad.ntasint
        Me.txtctipcon.Text = mEntidad.ctipcon
        Me.txtccodapo.Text = mEntidad.ccodapo
        Me.txtdfecvig.Text = mEntidad.dfecvig
        Me.txtndeseje.Text = mEntidad.ndeseje
        Me.txtngastos.Text = mEntidad.ngastos
        Me.txtncappag.Text = mEntidad.ncappag
        Me.txtnintpen.Text = mEntidad.nintpen
        Me.txtnintcal.Text = mEntidad.nintcal
        Me.txtnintpag.Text = mEntidad.nintpag
        Me.txtnintmor.Text = mEntidad.nintmor
        Me.txtnmorpag.Text = mEntidad.nmorpag
        Me.txtnpagcta.Text = mEntidad.npagcta
        Me.txtncapdes.Text = mEntidad.ncapdes
        Me.txtncapcal.Text = mEntidad.ncapcal
        Me.txtngaspag.Text = mEntidad.ngaspag
        Me.txtndiaatr.Text = mEntidad.ndiaatr
        Me.txtndiaant.Text = mEntidad.ndiaant
        Me.txtnatracu.Text = mEntidad.natracu
        Me.txtnatrmax.Text = mEntidad.natrmax
        Me.txtccondic.Text = mEntidad.ccondic
        Me.txtdultpag.Text = mEntidad.dultpag
        Me.txtdfecter.Text = mEntidad.dfecter
        Me.txtccodrec.Text = mEntidad.ccodrec
        Me.txtnnota1.Text = mEntidad.nnota1
        Me.txtnnota2.Text = mEntidad.nnota2
        Me.txtcmarjud.Text = mEntidad.cmarjud
        Me.txtntipcam.Text = mEntidad.ntipcam
        Me.cbxlctaret.Checked = mEntidad.lctaret
        Me.txtcclacre.Text = mEntidad.cclacre
        Me.txtccalif.Text = mEntidad.ccalif
        Me.txtnsegvid.Text = mEntidad.nsegvid
        Me.txtcnumexp.Text = mEntidad.cnumexp
        Me.txtccodrub.Text = mEntidad.ccodrub
        Me.txtcregist.Text = mEntidad.cregist
        Me.txtdfecadm.Text = mEntidad.dfecadm
        Me.txtnintadm.Text = mEntidad.nintadm
        Me.txtnmeses.Text = mEntidad.nmeses
        Me.txtcsececo.Text = mEntidad.csececo
        Me.txtnciclo.Text = mEntidad.nciclo
        'Me.ddlccodsol.SelectedValue = mEntidad.ccodsol
        Me.txtnmorak.Text = mEntidad.nmorak
        Me.txtnahoprg.Text = mEntidad.nahoprg
        Me.txtcliquid.Text = mEntidad.cliquid
        Me.txtclineac.Text = mEntidad.clineac
        Me.txtncapoto.Text = mEntidad.ncapoto
        Me.txtccontra.Text = mEntidad.ccontra
        Me.txtdfectra.Text = mEntidad.dfectra
        Me.txtccodusu.Text = mEntidad.ccodusu
        Me.txtdfecmod.Text = mEntidad.dfecmod
        Me.txtcflag.Text = mEntidad.cflag
        Me.txtcflat.Text = mEntidad.cflat
        Me.txtnnumfal.Text = mEntidad.nnumfal
        Me.txtctipgar.Text = mEntidad.ctipgar
    End Sub
 
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        'Me.ddlcCodofi.Enabled = edicion
        Me.txtccodprd.Enabled = edicion
        Me.txtcmoneda.Enabled = edicion
        Me.txtcestado.Enabled = edicion
        Me.txtccodcli.Enabled = edicion
        Me.txtccatego.Enabled = edicion
        Me.txtccodfue.Enabled = edicion
        'Me.ddlccodact.Enabled = edicion
        Me.txtctipcre.Enabled = edicion
        Me.txtcdescre.Enabled = edicion
        Me.txtctipcuo.Enabled = edicion
        Me.txtctipper.Enabled = edicion
        Me.txtntipperc.Enabled = edicion
        Me.txtcctapre.Enabled = edicion
        Me.txtcnorref.Enabled = edicion
        Me.txtccodana.Enabled = edicion
        Me.txtdfecasi.Enabled = edicion
        Me.txtdfecsol.Enabled = edicion
        Me.txtnmonsol.Enabled = edicion
        Me.txtnmonsug.Enabled = edicion
        Me.txtncuosug.Enabled = edicion
        Me.txtndessug.Enabled = edicion
        Me.txtndiasug.Enabled = edicion
        Me.txtndiagra.Enabled = edicion
        Me.txtdfecapr.Enabled = edicion
        Me.txtdfecven.Enabled = edicion
        Me.txtnmonapr.Enabled = edicion
        Me.txtnmoncuo.Enabled = edicion
        Me.txtnintapr.Enabled = edicion
        Me.txtncuoapr.Enabled = edicion
        Me.txtndiaapr.Enabled = edicion
        Me.txtndesapr.Enabled = edicion
        'Me.ddlcnrolin.Enabled = edicion
        Me.txtntasint.Enabled = edicion
        Me.txtctipcon.Enabled = edicion
        Me.txtccodapo.Enabled = edicion
        Me.txtdfecvig.Enabled = edicion
        Me.txtndeseje.Enabled = edicion
        Me.txtngastos.Enabled = edicion
        Me.txtncappag.Enabled = edicion
        Me.txtnintpen.Enabled = edicion
        Me.txtnintcal.Enabled = edicion
        Me.txtnintpag.Enabled = edicion
        Me.txtnintmor.Enabled = edicion
        Me.txtnmorpag.Enabled = edicion
        Me.txtnpagcta.Enabled = edicion
        Me.txtncapdes.Enabled = edicion
        Me.txtncapcal.Enabled = edicion
        Me.txtngaspag.Enabled = edicion
        Me.txtndiaatr.Enabled = edicion
        Me.txtndiaant.Enabled = edicion
        Me.txtnatracu.Enabled = edicion
        Me.txtnatrmax.Enabled = edicion
        Me.txtccondic.Enabled = edicion
        Me.txtdultpag.Enabled = edicion
        Me.txtdfecter.Enabled = edicion
        Me.txtccodrec.Enabled = edicion
        Me.txtnnota1.Enabled = edicion
        Me.txtnnota2.Enabled = edicion
        Me.txtcmarjud.Enabled = edicion
        Me.txtntipcam.Enabled = edicion
        Me.cbxlctaret.Enabled = edicion
        Me.txtcclacre.Enabled = edicion
        Me.txtccalif.Enabled = edicion
        Me.txtnsegvid.Enabled = edicion
        Me.txtcnumexp.Enabled = edicion
        Me.txtccodrub.Enabled = edicion
        Me.txtcregist.Enabled = edicion
        Me.txtdfecadm.Enabled = edicion
        Me.txtnintadm.Enabled = edicion
        Me.txtnmeses.Enabled = edicion
        Me.txtcsececo.Enabled = edicion
        Me.txtnciclo.Enabled = edicion
        'Me.ddlccodsol.Enabled = edicion
        Me.txtnmorak.Enabled = edicion
        Me.txtnahoprg.Enabled = edicion
        Me.txtcliquid.Enabled = edicion
        Me.txtclineac.Enabled = edicion
        Me.txtncapoto.Enabled = edicion
        Me.txtccontra.Enabled = edicion
        Me.txtdfectra.Enabled = edicion
        Me.txtccodusu.Enabled = edicion
        Me.txtdfecmod.Enabled = edicion
        Me.txtcflag.Enabled = edicion
        Me.txtcflat.Enabled = edicion
        Me.txtnnumfal.Enabled = edicion
        Me.txtctipgar.Enabled = edicion
    End Sub
 
    Private Sub Nuevo()
        Me._nuevo = True
        If Me.ViewState("nuevo") Is Nothing Then
            Me.ViewState.Add("nuevo", Me._nuevo)
        Else
            Me.ViewState("nuevo") = Me._nuevo
        End If
    End Sub
 
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New Cremcre
        If Me._nuevo Then
            mEntidad.ccodcta = 0
        Else
            mEntidad.ccodcta = CInt(Me.txtccodcta.Text)
        End If
        'mEntidad.cCodofi = Me.ddlcCodofi.SelectedValue
        mEntidad.ccodprd = Me.txtccodprd.Text
        mEntidad.cmoneda = Me.txtcmoneda.Text
        mEntidad.cestado = Me.txtcestado.Text
        mEntidad.ccodcli = Me.txtccodcli.Text
        mEntidad.ccatego = Me.txtccatego.Text
        mEntidad.ccodfue = Me.txtccodfue.Text
        'mEntidad.ccodact = Me.ddlccodact.SelectedValue
        mEntidad.ctipcre = Me.txtctipcre.Text
        mEntidad.cdescre = Me.txtcdescre.Text
        mEntidad.ctipcuo = Me.txtctipcuo.Text
        mEntidad.ctipper = Me.txtctipper.Text
        mEntidad.ntipperc = Me.txtntipperc.Text
        mEntidad.cctapre = Me.txtcctapre.Text
        mEntidad.cnorref = Me.txtcnorref.Text
        mEntidad.ccodana = Me.txtccodana.Text
        mEntidad.dfecasi = System.DateTime.Parse(Me.txtdfecasi.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.dfecsol = System.DateTime.Parse(Me.txtdfecsol.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.nmonsol = Me.txtnmonsol.Text
        mEntidad.nmonsug = Me.txtnmonsug.Text
        mEntidad.ncuosug = Me.txtncuosug.Text
        mEntidad.ndessug = Me.txtndessug.Text
        mEntidad.ndiasug = Me.txtndiasug.Text
        mEntidad.ndiagra = Me.txtndiagra.Text
        mEntidad.dfecapr = System.DateTime.Parse(Me.txtdfecapr.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.dfecven = System.DateTime.Parse(Me.txtdfecven.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.nmonapr = Me.txtnmonapr.Text
        mEntidad.nmoncuo = Me.txtnmoncuo.Text
        mEntidad.nintapr = Me.txtnintapr.Text
        mEntidad.ncuoapr = Me.txtncuoapr.Text
        mEntidad.ndiaapr = Me.txtndiaapr.Text
        mEntidad.ndesapr = Me.txtndesapr.Text
        'mEntidad.cnrolin = Me.ddlcnrolin.SelectedValue
        mEntidad.ntasint = Me.txtntasint.Text
        mEntidad.ctipcon = Me.txtctipcon.Text
        mEntidad.ccodapo = Me.txtccodapo.Text
        mEntidad.dfecvig = System.DateTime.Parse(Me.txtdfecvig.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.ndeseje = Me.txtndeseje.Text
        mEntidad.ngastos = Me.txtngastos.Text
        mEntidad.ncappag = Me.txtncappag.Text
        mEntidad.nintpen = Me.txtnintpen.Text
        mEntidad.nintcal = Me.txtnintcal.Text
        mEntidad.nintpag = Me.txtnintpag.Text
        mEntidad.nintmor = Me.txtnintmor.Text
        mEntidad.nmorpag = Me.txtnmorpag.Text
        mEntidad.npagcta = Me.txtnpagcta.Text
        mEntidad.ncapdes = Me.txtncapdes.Text
        mEntidad.ncapcal = Me.txtncapcal.Text
        mEntidad.ngaspag = Me.txtngaspag.Text
        mEntidad.ndiaatr = Me.txtndiaatr.Text
        mEntidad.ndiaant = Me.txtndiaant.Text
        mEntidad.natracu = Me.txtnatracu.Text
        mEntidad.natrmax = Me.txtnatrmax.Text
        mEntidad.ccondic = Me.txtccondic.Text
        mEntidad.dultpag = System.DateTime.Parse(Me.txtdultpag.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.dfecter = System.DateTime.Parse(Me.txtdfecter.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.ccodrec = Me.txtccodrec.Text
        mEntidad.nnota1 = Me.txtnnota1.Text
        mEntidad.nnota2 = Me.txtnnota2.Text
        mEntidad.cmarjud = Me.txtcmarjud.Text
        mEntidad.ntipcam = Me.txtntipcam.Text
        mEntidad.lctaret = Me.cbxlctaret.Checked
        mEntidad.cclacre = Me.txtcclacre.Text
        mEntidad.ccalif = Me.txtccalif.Text
        mEntidad.nsegvid = Me.txtnsegvid.Text
        mEntidad.cnumexp = Me.txtcnumexp.Text
        mEntidad.ccodrub = Me.txtccodrub.Text
        mEntidad.cregist = Me.txtcregist.Text
        mEntidad.dfecadm = System.DateTime.Parse(Me.txtdfecadm.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.nintadm = Me.txtnintadm.Text
        mEntidad.nmeses = Me.txtnmeses.Text
        mEntidad.csececo = Me.txtcsececo.Text
        mEntidad.nciclo = Me.txtnciclo.Text
        'mEntidad.ccodsol = Me.ddlccodsol.SelectedValue
        mEntidad.nmorak = Me.txtnmorak.Text
        mEntidad.nahoprg = Me.txtnahoprg.Text
        mEntidad.cliquid = Me.txtcliquid.Text
        mEntidad.clineac = Me.txtclineac.Text
        mEntidad.ncapoto = Me.txtncapoto.Text
        mEntidad.ccontra = Me.txtccontra.Text
        mEntidad.dfectra = System.DateTime.Parse(Me.txtdfectra.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.ccodusu = Me.txtccodusu.Text
        mEntidad.dfecmod = System.DateTime.Parse(Me.txtdfecmod.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.cflag = Me.txtcflag.Text
        mEntidad.cflat = Me.txtcflat.Text
        mEntidad.nnumfal = Me.txtnnumfal.Text
        mEntidad.ctipgar = Me.txtctipgar.Text
 
        If mComponente.ActualizarCremcre(mEntidad) <> 1 Then
            Return "Error al Guardar registro."
        End If
    End Function
End Class


