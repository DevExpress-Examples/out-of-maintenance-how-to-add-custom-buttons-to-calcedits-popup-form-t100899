Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication5
	Partial Public Class UserControl1
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			SubscribeAllTheButtonsToOneButtonClickEvent()

		End Sub

		Private Sub SubscribeAllTheButtonsToOneButtonClickEvent()
			For Each control As Control In layoutControl1.Controls
				If TypeOf control Is SimpleButton Then
					Dim button As SimpleButton = TryCast(control, SimpleButton)
					AddHandler button.Click, AddressOf button_Click
				End If
			Next control
		End Sub

		Private Sub button_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim button As SimpleButton = TryCast(sender, SimpleButton)
			MessageBox.Show(button.Text & " button was clicked")
		End Sub
	End Class
End Namespace
