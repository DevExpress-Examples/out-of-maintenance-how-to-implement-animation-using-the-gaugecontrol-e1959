Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class XtraForm1
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
			Dim scaleIndicatorState161 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState162 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState163 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState164 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState165 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState166 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState167 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState168 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState169 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState170 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState171 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState172 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState173 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState174 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState175 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState176 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState177 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState178 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState179 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Dim scaleIndicatorState180 As New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
			Me.gaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
			Me.linearScaleStateIndicatorComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
			Me.linearScaleStateIndicatorComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleStateIndicatorComponent3 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleStateIndicatorComponent4 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleStateIndicatorComponent5 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleStateIndicatorComponent6 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleStateIndicatorComponent7 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleStateIndicatorComponent8 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleStateIndicatorComponent9 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.linearScaleStateIndicatorComponent10 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent()
			Me.labelComponent1 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
			Me.timer1 = New System.Timers.Timer()
			CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleStateIndicatorComponent10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.labelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gaugeControl2
			' 
			Me.gaugeControl2.AutoLayout = False
			Me.gaugeControl2.BackColor = System.Drawing.Color.Transparent
			Me.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.gaugeControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.linearGauge1})
			Me.gaugeControl2.Location = New System.Drawing.Point(0, 0)
			Me.gaugeControl2.Name = "gaugeControl2"
			Me.gaugeControl2.Size = New System.Drawing.Size(615, 414)
			Me.gaugeControl2.TabIndex = 16
			' 
			' linearGauge1
			' 
			Me.linearGauge1.Bounds = New System.Drawing.Rectangle(5, 2, 604, 406)
			Me.linearGauge1.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent() { Me.linearScaleStateIndicatorComponent1, Me.linearScaleStateIndicatorComponent2, Me.linearScaleStateIndicatorComponent3, Me.linearScaleStateIndicatorComponent4, Me.linearScaleStateIndicatorComponent5, Me.linearScaleStateIndicatorComponent6, Me.linearScaleStateIndicatorComponent7, Me.linearScaleStateIndicatorComponent8, Me.linearScaleStateIndicatorComponent9, Me.linearScaleStateIndicatorComponent10})
			Me.linearGauge1.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() { Me.labelComponent1})
			Me.linearGauge1.Name = "RatingControl2"
			Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() { Me.linearScaleComponent1})
			' 
			' linearScaleStateIndicatorComponent1
			' 
			Me.linearScaleStateIndicatorComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(12.5F, 125F)
			Me.linearScaleStateIndicatorComponent1.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent1.Name = "Indicator0"
			Me.linearScaleStateIndicatorComponent1.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState161.IntervalLength = 100F
			scaleIndicatorState161.Name = "Colored"
			scaleIndicatorState161.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState161.StartValue = 0.01F
			scaleIndicatorState162.IntervalLength = 0F
			scaleIndicatorState162.Name = "Empty"
			scaleIndicatorState162.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent1.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState161, scaleIndicatorState162})
			Me.linearScaleStateIndicatorComponent1.ZOrder = 100
			' 
			' linearScaleComponent1
			' 
			Me.linearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			Me.linearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 225F)
			Me.linearScaleComponent1.MajorTickCount = 2
			Me.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
			Me.linearScaleComponent1.MajorTickmark.ShapeOffset = -20F
			Me.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
			Me.linearScaleComponent1.MajorTickmark.ShowText = False
			Me.linearScaleComponent1.MajorTickmark.ShowTick = False
			Me.linearScaleComponent1.MajorTickmark.TextOffset = -32F
			Me.linearScaleComponent1.MaxValue = 100F
			Me.linearScaleComponent1.MinorTickCount = 0
			Me.linearScaleComponent1.MinorTickmark.ShapeOffset = -14F
			Me.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
			Me.linearScaleComponent1.MinorTickmark.ShowTick = False
			Me.linearScaleComponent1.Name = "scale1"
			Me.linearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 25F)
			' 
			' linearScaleStateIndicatorComponent2
			' 
			Me.linearScaleStateIndicatorComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(22.05F, 95.61F)
			Me.linearScaleStateIndicatorComponent2.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent2.Name = "Indicator1"
			Me.linearScaleStateIndicatorComponent2.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState163.IntervalLength = 90F
			scaleIndicatorState163.Name = "Colored"
			scaleIndicatorState163.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState163.StartValue = 10F
			scaleIndicatorState164.IntervalLength = 10F
			scaleIndicatorState164.Name = "Empty"
			scaleIndicatorState164.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent2.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState163, scaleIndicatorState164})
			Me.linearScaleStateIndicatorComponent2.ZOrder = 99
			' 
			' linearScaleStateIndicatorComponent3
			' 
			Me.linearScaleStateIndicatorComponent3.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(47.05F, 77.45F)
			Me.linearScaleStateIndicatorComponent3.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent3.Name = "Indicator2"
			Me.linearScaleStateIndicatorComponent3.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState165.IntervalLength = 80F
			scaleIndicatorState165.Name = "Colored"
			scaleIndicatorState165.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState165.StartValue = 20F
			scaleIndicatorState166.IntervalLength = 20F
			scaleIndicatorState166.Name = "Empty"
			scaleIndicatorState166.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent3.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState165, scaleIndicatorState166})
			Me.linearScaleStateIndicatorComponent3.ZOrder = 98
			' 
			' linearScaleStateIndicatorComponent4
			' 
			Me.linearScaleStateIndicatorComponent4.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(77.95F, 77.45F)
			Me.linearScaleStateIndicatorComponent4.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent4.Name = "Indicator3"
			Me.linearScaleStateIndicatorComponent4.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState167.IntervalLength = 70F
			scaleIndicatorState167.Name = "Colored"
			scaleIndicatorState167.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState167.StartValue = 30F
			scaleIndicatorState168.IntervalLength = 30F
			scaleIndicatorState168.Name = "Empty"
			scaleIndicatorState168.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent4.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState167, scaleIndicatorState168})
			Me.linearScaleStateIndicatorComponent4.ZOrder = 97
			' 
			' linearScaleStateIndicatorComponent5
			' 
			Me.linearScaleStateIndicatorComponent5.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(102.95F, 95.61F)
			Me.linearScaleStateIndicatorComponent5.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent5.Name = "Indicator4"
			Me.linearScaleStateIndicatorComponent5.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState169.IntervalLength = 60F
			scaleIndicatorState169.Name = "Colored"
			scaleIndicatorState169.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState169.StartValue = 40F
			scaleIndicatorState170.IntervalLength = 40F
			scaleIndicatorState170.Name = "Empty"
			scaleIndicatorState170.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent5.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState169, scaleIndicatorState170})
			Me.linearScaleStateIndicatorComponent5.ZOrder = 96
			' 
			' linearScaleStateIndicatorComponent6
			' 
			Me.linearScaleStateIndicatorComponent6.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(112.5F, 125F)
			Me.linearScaleStateIndicatorComponent6.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent6.Name = "Indicator5"
			Me.linearScaleStateIndicatorComponent6.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState171.IntervalLength = 50F
			scaleIndicatorState171.Name = "Colored"
			scaleIndicatorState171.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState171.StartValue = 50F
			scaleIndicatorState172.IntervalLength = 50F
			scaleIndicatorState172.Name = "Empty"
			scaleIndicatorState172.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent6.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState171, scaleIndicatorState172})
			Me.linearScaleStateIndicatorComponent6.ZOrder = 95
			' 
			' linearScaleStateIndicatorComponent7
			' 
			Me.linearScaleStateIndicatorComponent7.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(102.92F, 154.39F)
			Me.linearScaleStateIndicatorComponent7.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent7.Name = "Indicator6"
			Me.linearScaleStateIndicatorComponent7.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState173.IntervalLength = 40F
			scaleIndicatorState173.Name = "Colored"
			scaleIndicatorState173.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState173.StartValue = 60F
			scaleIndicatorState174.IntervalLength = 60F
			scaleIndicatorState174.Name = "Empty"
			scaleIndicatorState174.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent7.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState173, scaleIndicatorState174})
			Me.linearScaleStateIndicatorComponent7.ZOrder = 94
			' 
			' linearScaleStateIndicatorComponent8
			' 
			Me.linearScaleStateIndicatorComponent8.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(77.95F, 172.55F)
			Me.linearScaleStateIndicatorComponent8.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent8.Name = "Indicator7"
			Me.linearScaleStateIndicatorComponent8.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState175.IntervalLength = 30F
			scaleIndicatorState175.Name = "Colored"
			scaleIndicatorState175.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState175.StartValue = 70F
			scaleIndicatorState176.IntervalLength = 70F
			scaleIndicatorState176.Name = "Empty"
			scaleIndicatorState176.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent8.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState175, scaleIndicatorState176})
			Me.linearScaleStateIndicatorComponent8.ZOrder = 93
			' 
			' linearScaleStateIndicatorComponent9
			' 
			Me.linearScaleStateIndicatorComponent9.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(47.05F, 172.55F)
			Me.linearScaleStateIndicatorComponent9.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent9.Name = "Indicator8"
			Me.linearScaleStateIndicatorComponent9.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState177.IntervalLength = 20F
			scaleIndicatorState177.Name = "Colored"
			scaleIndicatorState177.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState177.StartValue = 80F
			scaleIndicatorState178.IntervalLength = 80F
			scaleIndicatorState178.Name = "Empty"
			scaleIndicatorState178.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent9.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState177, scaleIndicatorState178})
			Me.linearScaleStateIndicatorComponent9.ZOrder = 92
			' 
			' linearScaleStateIndicatorComponent10
			' 
			Me.linearScaleStateIndicatorComponent10.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(22.05F, 154.39F)
			Me.linearScaleStateIndicatorComponent10.IndicatorScale = Me.linearScaleComponent1
			Me.linearScaleStateIndicatorComponent10.Name = "Indicator9"
			Me.linearScaleStateIndicatorComponent10.Size = New System.Drawing.SizeF(28.94356F, 28.94356F)
			scaleIndicatorState179.IntervalLength = 10F
			scaleIndicatorState179.Name = "Colored"
			scaleIndicatorState179.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem9
			scaleIndicatorState179.StartValue = 90F
			scaleIndicatorState180.IntervalLength = 90F
			scaleIndicatorState180.Name = "Empty"
			scaleIndicatorState180.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem5
			Me.linearScaleStateIndicatorComponent10.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { scaleIndicatorState179, scaleIndicatorState180})
			Me.linearScaleStateIndicatorComponent10.ZOrder = 91
			' 
			' labelComponent1
			' 
			Me.labelComponent1.AppearanceText.Font = New System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.labelComponent1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			Me.labelComponent1.Name = "linearGauge1_Label1"
			Me.labelComponent1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(58.2F, 31.1F)
			Me.labelComponent1.Size = New System.Drawing.SizeF(350F, 50F)
			Me.labelComponent1.Text = "LOADING"
			Me.labelComponent1.ZOrder = -1001
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.SynchronizingObject = Me
'			Me.timer1.Elapsed += New System.Timers.ElapsedEventHandler(Me.timer1_Elapsed);
			' 
			' XtraForm1
			' 
			Me.Appearance.BackColor = System.Drawing.Color.White
			Me.Appearance.Options.UseBackColor = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(615, 414)
			Me.Controls.Add(Me.gaugeControl2)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Name = "XtraForm1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "XtraForm1"
			Me.TransparencyKey = System.Drawing.Color.White
			CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleStateIndicatorComponent10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.labelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl
		Private linearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
		Private linearScaleStateIndicatorComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
		Private linearScaleStateIndicatorComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleStateIndicatorComponent3 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleStateIndicatorComponent4 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleStateIndicatorComponent5 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleStateIndicatorComponent6 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleStateIndicatorComponent7 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleStateIndicatorComponent8 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleStateIndicatorComponent9 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private linearScaleStateIndicatorComponent10 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
		Private labelComponent1 As DevExpress.XtraGauges.Win.Base.LabelComponent
		Private WithEvents timer1 As System.Timers.Timer
	End Class
End Namespace