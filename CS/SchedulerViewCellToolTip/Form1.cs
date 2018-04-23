using System;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.Utils;
using DevExpress.XtraScheduler.Drawing;

namespace SchedulerViewCellToolTip {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();

			PrepareToolTipCells();
		}
		private void toolTipController1_BeforeShow(object sender, ToolTipControllerShowEventArgs e) {
			ToolTipController controller = sender as ToolTipController;
			SchedulerViewCellBase cell = controller.ActiveObject as SchedulerViewCellBase;
			if (cell != null) 
				e.ToolTip = cell.Interval.ToString();
		}
		private void OnSchedulerControlLayoutChanged(object sender, EventArgs e) {
			PrepareToolTipCells();
		}
		private void PrepareToolTipCells() {
			SchedulerViewCellContainerCollection containers = GetCellContainers(schedulerControl1.ActiveView);
			for (int i = 0; i < containers.Count; i++) {
				SchedulerViewCellBaseCollection cells = containers[i].Cells;
				for (int n = 0; n < cells.Count; n++) {
					cells[n].ShouldShowToolTip = true;
					cells[n].ToolTipText = "Text value shouldn't be empty";
				}
			}
		}
		protected SchedulerViewCellContainerCollection GetCellContainers(SchedulerViewBase view) {
			DayView dayView = view as DayView;
			if (dayView != null)
				return dayView.ViewInfo.Columns;

			WeekView weekView = view as WeekView;
			if (weekView != null)
				return weekView.ViewInfo.Weeks;

			TimelineView timeLineView = view as TimelineView;
			return timeLineView.ViewInfo.Timelines;
		}

	}
}