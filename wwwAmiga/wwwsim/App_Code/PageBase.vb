Imports System.Web.UI
Imports System.Resources
Imports System.Threading
Imports System.Globalization




Public Class PageBase
    Public rm As System.Resources.ResourceManager '= New System.Resources.ResourceManager(GetType(Login))
    Sub SetUICulture(ByVal culture As String)
        ' get a reference to the ResourceManager for this form

        ' Cargamos el archivo de resources
            rm = New ResourceManager("wwwSim.Resource", System.Reflection.Assembly.GetExecutingAssembly)
        rm.IgnoreCase = True
        Try
            'set the culture as per the selection and 
            'load the appropriate strings for buttun, label, etc.
            System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(culture)

        Catch

        End Try

    End Sub
End Class


