' Developer Express Code Central Example:
' How to set different styles for even and odd rows in the DXGrid
' 
' The following example demonstrates how to mark odd and even rows in a grid with
' different background colors.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E981
Imports System.Windows

Namespace OddEvenRows

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class SimpleData

        Public Property Column1 As String

        Public Property Column2 As Integer

        Public Sub New()
        End Sub

        Public Sub New(ByVal str1 As String, ByVal int2 As Integer)
            Column1 = str1
            Column2 = int2
        End Sub
    End Class
End Namespace
