Imports System
Imports System.Runtime.InteropServices

Namespace Themer.Models

    <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
    <StructLayout(LayoutKind.Sequential)>
    Public Structure WindowCompositionAttributeData
        Public Attribute As WindowCompositionAttribute
        Public Data As IntPtr
        Public SizeOfData As Integer
    End Structure
End Namespace
