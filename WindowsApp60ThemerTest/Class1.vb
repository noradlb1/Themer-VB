Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class UnifiedThemer
    Private ReadOnly _handle As IntPtr

    ' Constants for window messages
    Private Const WM_NCHITTEST As Integer = &H84
    Private Const HT_CAPTION As Integer = &H2

    ' Adjustment level and background color for effects
    Private Const adjustmentLevel As UInteger = 20
    Private Const backgroundColor As UInteger = &H990000 ' Default: Dark

    Public Sub New(handle As IntPtr)
        _handle = handle
    End Sub

    ' Enum for themes
    Public Enum Themes
        Acrylic = 0
        AeroGlass = 1
        Transparent = 2
        None = 3
    End Enum

    ' Enum for AccentState
    Friend Enum AccentState
        ACCENT_DISABLED = 0
        ACCENT_ENABLE_TRANSPARENTGRADIENT = 2
        ACCENT_ENABLE_BLURBEHIND = 3
        ACCENT_ENABLE_ACRYLICBLURBEHIND = 4
    End Enum

    ' Enum for WindowCompositionAttribute
    Public Enum WindowCompositionAttribute
        WCA_ACCENT_POLICY = 19
    End Enum

    ' Structure for WindowCompositionAttributeData
    <StructLayout(LayoutKind.Sequential)>
    Public Structure WindowCompositionAttributeData
        Public Attribute As WindowCompositionAttribute
        Public Data As IntPtr
        Public SizeOfData As Integer
    End Structure

    ' Structure for MARGINS
    <StructLayout(LayoutKind.Sequential)>
    Friend Structure MARGINS
        Public Left As Integer
        Public Right As Integer
        Public Top As Integer
        Public Bottom As Integer
    End Structure

    ' Structure for AccentPolicy
    <StructLayout(LayoutKind.Sequential)>
    Friend Structure AccentPolicy
        Public AccentState As AccentState
        Public AccentFlags As Integer
        Public GradientColor As UInteger
        Public AnimationId As Integer
    End Structure

    ' Method to apply a theme
    Public Sub Apply(theme As Themes)
        ResetDWM()
        Select Case theme
            Case Themes.Acrylic
                Acrylic()
            Case Themes.AeroGlass
                AeroGlass()
            Case Themes.Transparent
                Transparent()
            Case Themes.None
                Clear()
        End Select
    End Sub

    Private Sub Acrylic()
        Dim accent As New AccentPolicy With {
            .AccentState = AccentState.ACCENT_ENABLE_ACRYLICBLURBEHIND,
            .GradientColor = (adjustmentLevel << &H18) Or (backgroundColor And &HFFFFFF)
        }
        ApplyAccentPolicy(accent)
    End Sub

    Private Sub AeroGlass()
        Dim accentPolicy As New AccentPolicy With {
            .AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND,
            .AccentFlags = 0,
            .GradientColor = 0,
            .AnimationId = 0
        }
        ApplyAccentPolicy(accentPolicy)
    End Sub

    Private Sub Transparent()
        Dim accent As New AccentPolicy With {
            .AccentState = AccentState.ACCENT_ENABLE_TRANSPARENTGRADIENT,
            .GradientColor = (adjustmentLevel << &H18) Or (backgroundColor And &HFFFFFF)
        }
        ApplyAccentPolicy(accent)
    End Sub

    Private Sub Clear()
        Dim accent As New AccentPolicy With {
            .AccentState = AccentState.ACCENT_DISABLED
        }
        ApplyAccentPolicy(accent)
    End Sub

    Private Sub ApplyAccentPolicy(accent As AccentPolicy)
        Dim accentStructSize As Integer = Marshal.SizeOf(accent)
        Dim accentPtr As IntPtr = Marshal.AllocHGlobal(accentStructSize)
        Marshal.StructureToPtr(accent, accentPtr, False)
        Dim data As New WindowCompositionAttributeData With {
            .Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY,
            .SizeOfData = accentStructSize,
            .Data = accentPtr
        }
        SetWindowCompositionAttribute(_handle, data)
        Marshal.FreeHGlobal(accentPtr)
    End Sub

    Private Sub ResetDWM()
        Dim mrg As New MARGINS With {
            .Bottom = 0,
            .Left = 0,
            .Right = 0,
            .Top = 0
        }
        DwmExtendFrameIntoClientArea(_handle, mrg)
    End Sub

    <DllImport("user32.dll")>
    Private Shared Function SetWindowCompositionAttribute(hwnd As IntPtr, ByRef data As WindowCompositionAttributeData) As Integer
    End Function

    <DllImport("DwmApi.dll")>
    Private Shared Function DwmExtendFrameIntoClientArea(hwnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
    End Function
End Class
