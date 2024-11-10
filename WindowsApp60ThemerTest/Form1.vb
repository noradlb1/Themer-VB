Imports System
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Private Const WM_NCHITTEST As Integer = &H84
    Private Const HT_CAPTION As Integer = &H2

    Private _themer As UnifiedThemer

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        ' Initialize themer
        _themer = New UnifiedThemer(Me.Handle)
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m) ' moveable window in borderless form
        If m.Msg = WM_NCHITTEST Then
            m.Result = CType(HT_CAPTION, IntPtr)
        End If
    End Sub

    Private Sub guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged
        If Guna2ToggleSwitch1.Checked Then
            Guna2ControlBox1.Visible = False
            Guna2ControlBox2.Visible = False
            Guna2Panel1.Visible = False
        Else
            Guna2ControlBox1.Visible = True
            Guna2ControlBox2.Visible = True
            Guna2Panel1.Visible = True
        End If
    End Sub

#Region "Events"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        _themer.Apply(UnifiedThemer.Themes.Acrylic)
        lbl.Text = "Acrylic"
    End Sub

    Private Sub guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        _themer.Apply(UnifiedThemer.Themes.AeroGlass)
        lbl.Text = "Glass"
    End Sub

    Private Sub guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        _themer.Apply(UnifiedThemer.Themes.Transparent)
        lbl.Text = "Transparent"
    End Sub

    Private Sub guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        _themer.Apply(UnifiedThemer.Themes.None)
        lbl.Text = "Disabled"
    End Sub

    Private Sub lbl_SizeChanged(sender As Object, e As EventArgs) Handles lbl.SizeChanged
        lbl.Left = (Guna2Panel1.ClientSize.Width - lbl.Size.Width) / 2
    End Sub

#End Region

End Class
