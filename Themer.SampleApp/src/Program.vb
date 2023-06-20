#Region ""

Imports System
Imports System.Windows.Forms

#End Region

Namespace Themer.Sample
    Friend Module Program
        <STAThread>
        Private Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Showcase())
        End Sub
    End Module
End Namespace
