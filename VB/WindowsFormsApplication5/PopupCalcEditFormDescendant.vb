Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors
Imports System.Drawing

Namespace WindowsFormsApplication5
	Public Class PopupCalcEditFormDescendant
		Inherits PopupCalcEditForm
		Private userControl As UserControl1
		Public Sub New(ByVal ownerEdit As PopupBaseEdit)
			MyBase.New(ownerEdit)
			userControl = New UserControl1()

		End Sub
		Public Overrides Sub ShowPopupForm()

			Me.Height += userControl.Height
			userControl.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.Controls.Add(userControl)
			MyBase.ShowPopupForm()
		End Sub
	End Class
End Namespace
