Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
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
			If disposing Then
				lockTimerCounter += 1
				If timer IsNot Nothing Then
					timer.Stop()
					timer.Dispose()
					timer = Nothing
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.timer = New System.Windows.Forms.Timer(Me.components)
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
			Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.digitalGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
			Me.digitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.digitalGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.digitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' timer
			' 
'			Me.timer.Tick += New System.EventHandler(Me.OnTimerTick);
			' 
			' textEdit1
			' 
			Me.textEdit1.EditValue = "If you don't know where you are going, any road will take you there. "
			Me.textEdit1.Location = New System.Drawing.Point(62, 202)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(539, 20)
			Me.textEdit1.TabIndex = 11
'			Me.textEdit1.EditValueChanged += New System.EventHandler(Me.textEdit1_EditValueChanged);
			' 
			' trackBarControl1
			' 
			Me.trackBarControl1.EditValue = Nothing
			Me.trackBarControl1.Location = New System.Drawing.Point(62, 152)
			Me.trackBarControl1.MaximumSize = New System.Drawing.Size(0, 35)
			Me.trackBarControl1.MinimumSize = New System.Drawing.Size(0, 35)
			Me.trackBarControl1.Name = "trackBarControl1"
			Me.trackBarControl1.Size = New System.Drawing.Size(542, 35)
			Me.trackBarControl1.TabIndex = 10
'			Me.trackBarControl1.EditValueChanged += New System.EventHandler(Me.trackBarControl1_ValueChanged);
			' 
			' gaugeControl1
			' 
			Me.gaugeControl1.AutoLayout = False
			Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.digitalGauge1})
			Me.gaugeControl1.Location = New System.Drawing.Point(0, 8)
			Me.gaugeControl1.Name = "gaugeControl1"
			Me.gaugeControl1.Size = New System.Drawing.Size(607, 138)
			Me.gaugeControl1.TabIndex = 12
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(14, 152)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(31, 13)
			Me.labelControl1.TabIndex = 13
			Me.labelControl1.Text = "SPEED"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(14, 205)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(22, 13)
			Me.labelControl2.TabIndex = 14
			Me.labelControl2.Text = "Text"
			' 
			' digitalGauge1
			' 
			Me.digitalGauge1.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#34000000")
			Me.digitalGauge1.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			Me.digitalGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() { Me.digitalBackgroundLayerComponent1})
			Me.digitalGauge1.Bounds = New System.Drawing.Rectangle(6, 32, 596, 69)
			Me.digitalGauge1.DigitCount = 18
			Me.digitalGauge1.Name = "digitalGauge1"
			Me.digitalGauge1.Text = "00,000"
			' 
			' digitalBackgroundLayerComponent1
			' 
			Me.digitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(883.3251F, 99.9625F)
			Me.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1"
			Me.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style4
			Me.digitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F)
			Me.digitalBackgroundLayerComponent1.ZOrder = 1000
			' 
			' Form1
			' 
			Me.ClientSize = New System.Drawing.Size(607, 250)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.gaugeControl1)
			Me.Controls.Add(Me.textEdit1)
			Me.Controls.Add(Me.trackBarControl1)
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.digitalGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.digitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents timer As System.Windows.Forms.Timer
		Private WithEvents textEdit1 As DevExpress.XtraEditors.TextEdit
		Private WithEvents trackBarControl1 As DevExpress.XtraEditors.TrackBarControl
		Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private digitalGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
		Private digitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
	End Class
End Namespace

