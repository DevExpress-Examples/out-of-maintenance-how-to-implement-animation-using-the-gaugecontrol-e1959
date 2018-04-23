Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub


		Private lockTimerCounter As Integer
		Private Sub OnTimerTick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer.Tick
			If lockTimerCounter = 0 Then
				lockTimerCounter += 1
				UpdateText()
				lockTimerCounter -= 1
			End If
		End Sub
		Protected Sub Init()
			timer.Stop()
			offsetCounter = -digitalGauge1.DigitCount
			timer.Interval = 500 / (trackBarControl1.Value + 1)
			timer.Start()
		End Sub
		Private offsetCounter As Integer = 0
		Protected Sub UpdateText()
			Dim fullTextToShow As String = textEdit1.Text
			Dim textToShow(digitalGauge1.DigitCount - 1) As Char
			For i As Integer = 0 To digitalGauge1.DigitCount - 1
				If i + offsetCounter >= 0 AndAlso i + offsetCounter < fullTextToShow.Length Then
					textToShow(i) = fullTextToShow.Chars(i + offsetCounter)
				Else
					textToShow(i) = " "c
				End If
			Next i
		   offsetCounter += 1
			If offsetCounter > digitalGauge1.DigitCount + fullTextToShow.Length Then
				offsetCounter = -digitalGauge1.DigitCount
			End If
			digitalGauge1.Text = New String(textToShow)
		End Sub


		Private Sub textEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textEdit1.EditValueChanged
			Init()
		End Sub


		Private Sub trackBarControl1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBarControl1.EditValueChanged
			Init()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			CType(New XtraForm1(), XtraForm1).ShowProgress()
		End Sub

	End Class
End Namespace