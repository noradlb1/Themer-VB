Imports System
Imports System.Runtime.InteropServices
Imports Themer.Models



''' <summary>
'''     A class to set DWM effects to current window.
''' </summary>
Namespace Themer
    Public Class ThemerApplier

        Private ReadOnly _handle As IntPtr

        ''' <summary> Adjustment level of the effect. The larger the number, the more effective of the style. </summary>
        Private Const adjustmentLevel As UInteger = 20

        ''' <summary> Color of the effect brush. </summary>
        Private Const backgroundColor As UInteger = &H990000 ' Default: Dark

        ''' <summary>
        '''     Initializes <b>Themer</b> to current form.
        ''' </summary>
        ''' <paramname="handle">  Handle of the form to be brushed. </param>
        Public Sub New(ByVal handle As IntPtr)
            _handle = handle
        End Sub

#Region "Apply"

        ''' <summary>
        '''     Apply a <b>style</b> to window.
        ''' </summary>
        ''' <paramname="theme">Style to be applied.</param>
        Public Sub Apply(ByVal theme As Themes)
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

        ''' <summary>
        '''     Acrylic is a translucent texture, like a blur but vision is low.
        ''' </summary>
        Private Sub Acrylic()
            Dim accent = New AccentPolicy With {
        .AccentState = AccentState.ACCENT_ENABLE_ACRYLICBLURBEHIND,
        .GradientColor = adjustmentLevel << &H18 Or backgroundColor And &HFFFFFF
    }
            Dim accentStructSize = Marshal.SizeOf(accent)
            Dim accentPtr = Marshal.AllocHGlobal(accentStructSize)
            Marshal.StructureToPtr(accent, accentPtr, False)
            Dim data = New WindowCompositionAttributeData With {
        .Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY,
        .SizeOfData = accentStructSize,
        .Data = accentPtr
    }
            SetWindowCompositionAttribute(_handle, data)
            Marshal.FreeHGlobal(accentPtr)
        End Sub


        ''' <summary>
        '''     Applies a glass effect, background is blurred.
        ''' </summary>
        Private Sub AeroGlass()
            Dim accentPolicy As AccentPolicy = New AccentPolicy With {
        .AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND,
        .AccentFlags = 0,
        .GradientColor = 0,
        .AnimationId = 0
    }
            Dim data As WindowCompositionAttributeData = New WindowCompositionAttributeData With {
        .Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY
    }
            Dim accentSize = Marshal.SizeOf(accentPolicy)
            Dim accentPtr = Marshal.AllocHGlobal(accentSize)
            Marshal.StructureToPtr(accentPolicy, accentPtr, False)
            data.Data = accentPtr
            data.SizeOfData = accentSize
            Dim result = SetWindowCompositionAttribute(_handle, data)
            Marshal.FreeHGlobal(accentPtr)
        End Sub

        ''' <summary>
        '''     Applies a full transparent theme.
        ''' </summary>
        Private Sub Transparent()
            Dim accent = New AccentPolicy With {
        .AccentState = AccentState.ACCENT_ENABLE_TRANSPARENTGRADIENT,
        .GradientColor = adjustmentLevel << &H18 Or backgroundColor And &HFFFFFF
    }
            Dim accentStructSize = Marshal.SizeOf(accent)
            Dim accentPtr = Marshal.AllocHGlobal(accentStructSize)
            Marshal.StructureToPtr(accent, accentPtr, False)
            Dim data = New WindowCompositionAttributeData With {
        .Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY,
        .SizeOfData = accentStructSize,
        .Data = accentPtr
    }
            SetWindowCompositionAttribute(_handle, data)
            Marshal.FreeHGlobal(accentPtr)
        End Sub

        ''' <summary>
        '''     Clears all underlayed styles.
        ''' </summary>
        Private Sub Clear()
            Dim accent = New AccentPolicy With {
        .AccentState = AccentState.ACCENT_DISABLED
    }
            Dim accentStructSize = Marshal.SizeOf(accent)
            Dim accentPtr = Marshal.AllocHGlobal(accentStructSize)
            Marshal.StructureToPtr(accent, accentPtr, False)
            Dim data = New WindowCompositionAttributeData With {
        .Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY,
        .SizeOfData = accentStructSize,
        .Data = accentPtr
    }
            SetWindowCompositionAttribute(_handle, data)
            Marshal.FreeHGlobal(accentPtr)
        End Sub

#Region "Helpers"

        Private Sub ResetDWM()
            Dim mrg As MARGINS = New MARGINS With {
        .Bottom = 0,
        .Left = 0,
        .Right = 0,
        .Top = 0
    }
            DwmExtendFrameIntoClientArea(_handle, mrg)
        End Sub

#End Region

#End Region

#Region "Imports"

        <DllImport("user32.dll")>
        Friend Shared Function SetWindowCompositionAttribute(ByVal hwnd As IntPtr, ByRef data As WindowCompositionAttributeData) As Integer
        End Function

        <DllImport("DwmApi.dll")>
        Friend Shared Function DwmExtendFrameIntoClientArea(ByVal hwnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
        End Function

#End Region
    End Class
End Namespace
