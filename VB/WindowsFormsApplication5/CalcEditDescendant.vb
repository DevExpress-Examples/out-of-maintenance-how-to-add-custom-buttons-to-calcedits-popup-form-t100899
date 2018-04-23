Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup
Imports System.ComponentModel

Namespace WindowsFormsApplication5
	<ToolboxItem(True)> _
	Public Class CalcEditDescendant
		Inherits CalcEdit
		Public Sub New()

		End Sub
		Protected Overrides Function CreatePopupForm() As DevExpress.XtraEditors.Popup.PopupBaseForm
			Return New PopupCalcEditFormDescendant(Me) 'base.CreatePopupForm();
		End Function
	End Class
End Namespace
