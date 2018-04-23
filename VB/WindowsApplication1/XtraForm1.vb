Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Partial Public Class XtraForm1
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private time As Integer
		Private maxtime As Integer = 30
		Public Sub ShowProgress()
			ShowDialog()
		End Sub

		Private Sub timer1_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles timer1.Elapsed
			linearScaleComponent1.Value = time*10 Mod linearScaleComponent1.MaxValue
			time += 1
			If time > maxtime Then
				timer1.Stop()
				Dispose()
			End If
		End Sub
	End Class
End Namespace