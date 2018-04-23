Imports Microsoft.VisualBasic
Imports System.Windows

Namespace OddEvenRows

	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Public Class SimpleData
		Private privateColumn1 As String
		Public Property Column1() As String
			Get
				Return privateColumn1
			End Get
			Set(ByVal value As String)
				privateColumn1 = value
			End Set
		End Property
		Private privateColumn2 As Integer
		Public Property Column2() As Integer
			Get
				Return privateColumn2
			End Get
			Set(ByVal value As Integer)
				privateColumn2 = value
			End Set
		End Property

		Public Sub New()
		End Sub

		Public Sub New(ByVal str1 As String, ByVal int2 As Integer)
			Column1 = str1
			Column2 = int2
		End Sub
	End Class
End Namespace
