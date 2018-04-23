Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication5
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.calcEditDescendant1 = New WindowsFormsApplication5.CalcEditDescendant()
			CType(Me.calcEditDescendant1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' calcEditDescendant1
			' 
			Me.calcEditDescendant1.Location = New System.Drawing.Point(116, 81)
			Me.calcEditDescendant1.Name = "calcEditDescendant1"
			Me.calcEditDescendant1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.calcEditDescendant1.Size = New System.Drawing.Size(217, 22)
			Me.calcEditDescendant1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(480, 383)
			Me.Controls.Add(Me.calcEditDescendant1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.calcEditDescendant1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private calcEditDescendant1 As CalcEditDescendant

	End Class
End Namespace

