namespace SchedulerViewCellToolTip {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
			DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
			this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
			this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
			this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
			((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
			this.SuspendLayout();
			// 
			// schedulerControl1
			// 
			this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
			this.schedulerControl1.Name = "schedulerControl1";
			this.schedulerControl1.OptionsView.ToolTipVisibility = DevExpress.XtraScheduler.ToolTipVisibility.Always;
			this.schedulerControl1.Size = new System.Drawing.Size(679, 439);
			this.schedulerControl1.Start = new System.DateTime(2008, 8, 22, 0, 0, 0, 0);
			this.schedulerControl1.Storage = this.schedulerStorage1;
			this.schedulerControl1.TabIndex = 0;
			this.schedulerControl1.Text = "schedulerControl1";
			this.schedulerControl1.ToolTipController = this.toolTipController1;
			this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
			this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
			this.schedulerControl1.SelectionChanged += new System.EventHandler(this.OnSchedulerControlLayoutChanged);
			this.schedulerControl1.VisibleIntervalChanged += new System.EventHandler(this.OnSchedulerControlLayoutChanged);
			this.schedulerControl1.SizeChanged += new System.EventHandler(this.OnSchedulerControlLayoutChanged);
			// 
			// toolTipController1
			// 
			this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.toolTipController1_BeforeShow);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(679, 439);
			this.Controls.Add(this.schedulerControl1);
			this.Name = "Form1";
			this.toolTipController1.SetSuperTip(this, null);
			this.Text = "SchedulerViewCellTooltip";
			((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
		private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
		private DevExpress.Utils.ToolTipController toolTipController1;
	}
}

