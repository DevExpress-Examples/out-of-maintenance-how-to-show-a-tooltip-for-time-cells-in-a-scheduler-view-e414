Imports Microsoft.VisualBasic
Imports System
Namespace SchedulerViewCellToolTip
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
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.OptionsView.ToolTipVisibility = DevExpress.XtraScheduler.ToolTipVisibility.Always
			Me.schedulerControl1.Size = New System.Drawing.Size(679, 439)
			Me.schedulerControl1.Start = New System.DateTime(2008, 8, 22, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 0
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.ToolTipController = Me.toolTipController1
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
'			Me.schedulerControl1.SelectionChanged += New System.EventHandler(Me.OnSchedulerControlLayoutChanged);
'			Me.schedulerControl1.VisibleIntervalChanged += New System.EventHandler(Me.OnSchedulerControlLayoutChanged);
'			Me.schedulerControl1.SizeChanged += New System.EventHandler(Me.OnSchedulerControlLayoutChanged);
			' 
			' toolTipController1
			' 
'			Me.toolTipController1.BeforeShow += New DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(Me.toolTipController1_BeforeShow);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(679, 439)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Name = "Form1"
			Me.toolTipController1.SetSuperTip(Me, Nothing)
			Me.Text = "SchedulerViewCellTooltip"
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private WithEvents toolTipController1 As DevExpress.Utils.ToolTipController
	End Class
End Namespace

