Imports System
Imports System.Runtime.InteropServices

Namespace Themer.Models

    <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
    <StructLayout(LayoutKind.Sequential)>
    Friend Structure AccentPolicy
        Public AccentState As AccentState
        Public AccentFlags As Integer
        Public GradientColor As UInteger
        Public AnimationId As Integer
    End Structure
End Namespace
