Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler.Drawing

Namespace SchedulerViewCellToolTip
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			PrepareToolTipCells()
		End Sub
		Private Sub toolTipController1_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs) Handles toolTipController1.BeforeShow
			Dim controller As ToolTipController = TryCast(sender, ToolTipController)
			Dim cell As SchedulerViewCellBase = TryCast(controller.ActiveObject, SchedulerViewCellBase)
			If cell IsNot Nothing Then
				e.ToolTip = cell.Interval.ToString()
			End If
		End Sub
		Private Sub OnSchedulerControlLayoutChanged(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerControl1.SelectionChanged, schedulerControl1.VisibleIntervalChanged, schedulerControl1.SizeChanged
			PrepareToolTipCells()
		End Sub
		Private Sub PrepareToolTipCells()
			Dim containers As SchedulerViewCellContainerCollection = GetCellContainers(schedulerControl1.ActiveView)
			For i As Integer = 0 To containers.Count - 1
				Dim cells As SchedulerViewCellBaseCollection = containers(i).Cells
				For n As Integer = 0 To cells.Count - 1
					cells(n).ShouldShowToolTip = True
					cells(n).ToolTipText = "not empty"
				Next n
			Next i
		End Sub
		Protected Function GetCellContainers(ByVal view As SchedulerViewBase) As SchedulerViewCellContainerCollection
			Dim dayView As DayView = TryCast(view, DayView)
			If dayView IsNot Nothing Then
				Return dayView.ViewInfo.Columns
			End If

			Dim weekView As WeekView = TryCast(view, WeekView)
			If weekView IsNot Nothing Then
				Return weekView.ViewInfo.Weeks
			End If

			Dim timeLineView As TimelineView = TryCast(view, TimelineView)
			Return timeLineView.ViewInfo.Timelines
		End Function

	End Class
End Namespace