#Region ""

Imports System
Imports System.Diagnostics
Imports System.Windows.Forms

#End Region

Namespace Themer.Sample
    Public Partial Class Showcase
        Inherits Form
        Private Const WM_NCHITTEST As Integer = &H84
        Private Const HT_CAPTION As Integer = &H2

        Private _themer As ThemerApplier

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            ' Initialize themer
            _themer = New ThemerApplier(Handle)
        End Sub
        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub WndProc(ByRef m As Message)
            MyBase.WndProc(m) ' moveable window in borderless form
            If m.Msg = WM_NCHITTEST Then m.Result = CType(HT_CAPTION, IntPtr)
        End Sub

        Private Sub guna2ToggleSwitch1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If guna2ToggleSwitch1.Checked Then
                ' toggle free mode
                guna2ControlBox1.Visible = False
                guna2ControlBox2.Visible = False
                guna2Panel1.Visible = False
            Else
                guna2ControlBox1.Visible = True
                guna2ControlBox2.Visible = True
                guna2Panel1.Visible = True
            End If
        End Sub

#Region "Events"

        Private Sub Showcase_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub guna2Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            _themer.Apply(Themes.Acrylic)
            lbl.Text = "Acrylic"
        End Sub

        Private Sub guna2Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            _themer.Apply(Themes.AeroGlass)
            lbl.Text = "Glass"
        End Sub

        Private Sub guna2Button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            _themer.Apply(Themes.Transparent)
            lbl.Text = "Transparent"
        End Sub

        Private Sub guna2Button4_Click(ByVal sender As Object, ByVal e As EventArgs)
            _themer.Apply(Themes.None)
            lbl.Text = "Disabled"
        End Sub

        Private Sub lblSizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            lbl.Left = (guna2Panel1.ClientSize.Width - lbl.Size.Width) / 2
        End Sub

        Private Sub guna2Button5_Click(ByVal sender As Object, ByVal e As EventArgs)
            MessageBox.Show("Themer is made to show you rare WinForm effecs made with DWM API. Explore different effects for your WinForm. You can use it by downloading the framework in my github.", "Themer", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub guna2Button6_Click(ByVal sender As Object, ByVal e As EventArgs)
            Process.Start("explorer.exe", "https://github.com/arshx86")
        End Sub
#End Region
    End Class
End Namespace
