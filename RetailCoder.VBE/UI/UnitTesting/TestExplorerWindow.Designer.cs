using System.ComponentModel;
using System.Windows.Forms;

namespace Rubberduck.UI.UnitTesting
{
    partial class TestExplorerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestExplorerWindow));
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
         this.testProgressBar = new System.Windows.Forms.ToolStripProgressBar();
         this.TotalElapsedMilisecondsLabel = new System.Windows.Forms.ToolStripLabel();
         this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
         this.passedTestsLabel = new System.Windows.Forms.ToolStripLabel();
         this.failedTestsLabel = new System.Windows.Forms.ToolStripLabel();
         this.inconclusiveTestsLabel = new System.Windows.Forms.ToolStripLabel();
         this.panel1 = new System.Windows.Forms.Panel();
         this.testOutputGridView = new System.Windows.Forms.DataGridView();
         this.refreshTestsButton = new System.Windows.Forms.ToolStripButton();
         this.runButton = new System.Windows.Forms.ToolStripSplitButton();
         this.runAllTestsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.runSelectedTestMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
         this.runNotRunTestsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.runFailedTestsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.runPassedTestsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
         this.runLastRunMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.runSelectedButton = new System.Windows.Forms.ToolStripButton();
         this.addButton = new System.Windows.Forms.ToolStripDropDownButton();
         this.addTestModuleButton = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.addTestMethodButton = new System.Windows.Forms.ToolStripMenuItem();
         this.addExpectedErrorTestMethodButton = new System.Windows.Forms.ToolStripMenuItem();
         this.gotoSelectionButton = new System.Windows.Forms.ToolStripButton();
         this.toolStrip1.SuspendLayout();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.testOutputGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // toolStrip1
         // 
         this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshTestsButton,
            this.toolStripSeparator1,
            this.runButton,
            this.runSelectedButton,
            this.addButton,
            this.gotoSelectionButton,
            this.toolStripSeparator5,
            this.testProgressBar,
            this.TotalElapsedMilisecondsLabel,
            this.toolStripSeparator6,
            this.passedTestsLabel,
            this.failedTestsLabel,
            this.inconclusiveTestsLabel});
         this.toolStrip1.Location = new System.Drawing.Point(0, 0);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(670, 27);
         this.toolStrip1.TabIndex = 1;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
         // 
         // toolStripSeparator5
         // 
         this.toolStripSeparator5.Name = "toolStripSeparator5";
         this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
         // 
         // testProgressBar
         // 
         this.testProgressBar.ForeColor = System.Drawing.Color.LimeGreen;
         this.testProgressBar.Name = "testProgressBar";
         this.testProgressBar.Size = new System.Drawing.Size(100, 24);
         this.testProgressBar.Step = 1;
         // 
         // TotalElapsedMilisecondsLabel
         // 
         this.TotalElapsedMilisecondsLabel.Name = "TotalElapsedMilisecondsLabel";
         this.TotalElapsedMilisecondsLabel.Size = new System.Drawing.Size(32, 24);
         this.TotalElapsedMilisecondsLabel.Text = "0 ms";
         // 
         // toolStripSeparator6
         // 
         this.toolStripSeparator6.Name = "toolStripSeparator6";
         this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
         // 
         // passedTestsLabel
         // 
         this.passedTestsLabel.Name = "passedTestsLabel";
         this.passedTestsLabel.Size = new System.Drawing.Size(52, 24);
         this.passedTestsLabel.Text = "0 Passed";
         // 
         // failedTestsLabel
         // 
         this.failedTestsLabel.Name = "failedTestsLabel";
         this.failedTestsLabel.Size = new System.Drawing.Size(47, 24);
         this.failedTestsLabel.Text = "0 Failed";
         // 
         // inconclusiveTestsLabel
         // 
         this.inconclusiveTestsLabel.Name = "inconclusiveTestsLabel";
         this.inconclusiveTestsLabel.Size = new System.Drawing.Size(82, 24);
         this.inconclusiveTestsLabel.Text = "0 Inconclusive";
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.testOutputGridView);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Location = new System.Drawing.Point(0, 27);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(670, 173);
         this.panel1.TabIndex = 2;
         // 
         // testOutputGridView
         // 
         this.testOutputGridView.AllowUserToAddRows = false;
         this.testOutputGridView.AllowUserToDeleteRows = false;
         this.testOutputGridView.AllowUserToOrderColumns = true;
         this.testOutputGridView.AllowUserToResizeRows = false;
         dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
         dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         this.testOutputGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
         this.testOutputGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
         this.testOutputGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.testOutputGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.testOutputGridView.DefaultCellStyle = dataGridViewCellStyle4;
         this.testOutputGridView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.testOutputGridView.Location = new System.Drawing.Point(0, 0);
         this.testOutputGridView.Name = "testOutputGridView";
         this.testOutputGridView.ReadOnly = true;
         this.testOutputGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.testOutputGridView.Size = new System.Drawing.Size(670, 173);
         this.testOutputGridView.TabIndex = 1;
         this.testOutputGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCellDoubleClicked);
         this.testOutputGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ColumnHeaderMouseClicked);
         // 
         // refreshTestsButton
         // 
         this.refreshTestsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.refreshTestsButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshTestsButton.Image")));
         this.refreshTestsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.refreshTestsButton.Name = "refreshTestsButton";
         this.refreshTestsButton.Size = new System.Drawing.Size(24, 24);
         this.refreshTestsButton.ToolTipText = "Refresh";
         this.refreshTestsButton.Click += new System.EventHandler(this.RefreshTestsButtonClick);
         // 
         // runButton
         // 
         this.runButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runAllTestsMenuItem,
            this.runSelectedTestMenuItem,
            this.toolStripSeparator3,
            this.runNotRunTestsMenuItem,
            this.runFailedTestsMenuItem,
            this.runPassedTestsMenuItem,
            this.toolStripSeparator4,
            this.runLastRunMenuItem});
         this.runButton.Image = global::Rubberduck.Properties.Resources.control_000_small;
         this.runButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.runButton.Name = "runButton";
         this.runButton.Size = new System.Drawing.Size(64, 24);
         this.runButton.Text = "&Run";
         // 
         // runAllTestsMenuItem
         // 
         this.runAllTestsMenuItem.Image = global::Rubberduck.Properties.Resources.flask_arrow;
         this.runAllTestsMenuItem.ImageTransparentColor = System.Drawing.Color.White;
         this.runAllTestsMenuItem.Name = "runAllTestsMenuItem";
         this.runAllTestsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
         this.runAllTestsMenuItem.Size = new System.Drawing.Size(234, 26);
         this.runAllTestsMenuItem.Text = "&All Tests";
         // 
         // runSelectedTestMenuItem
         // 
         this.runSelectedTestMenuItem.Enabled = false;
         this.runSelectedTestMenuItem.Name = "runSelectedTestMenuItem";
         this.runSelectedTestMenuItem.Size = new System.Drawing.Size(234, 26);
         this.runSelectedTestMenuItem.Text = "&Selected Tests";
         this.runSelectedTestMenuItem.Visible = false;
         // 
         // toolStripSeparator3
         // 
         this.toolStripSeparator3.Name = "toolStripSeparator3";
         this.toolStripSeparator3.Size = new System.Drawing.Size(231, 6);
         // 
         // runNotRunTestsMenuItem
         // 
         this.runNotRunTestsMenuItem.Image = global::Rubberduck.Properties.Resources.question_white;
         this.runNotRunTestsMenuItem.Name = "runNotRunTestsMenuItem";
         this.runNotRunTestsMenuItem.Size = new System.Drawing.Size(234, 26);
         this.runNotRunTestsMenuItem.Text = "&Not Run Tests";
         // 
         // runFailedTestsMenuItem
         // 
         this.runFailedTestsMenuItem.Enabled = false;
         this.runFailedTestsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("runFailedTestsMenuItem.Image")));
         this.runFailedTestsMenuItem.Name = "runFailedTestsMenuItem";
         this.runFailedTestsMenuItem.Size = new System.Drawing.Size(234, 26);
         this.runFailedTestsMenuItem.Text = "&Failed Tests";
         // 
         // runPassedTestsMenuItem
         // 
         this.runPassedTestsMenuItem.Enabled = false;
         this.runPassedTestsMenuItem.Image = global::Rubberduck.Properties.Resources.tick_circle;
         this.runPassedTestsMenuItem.Name = "runPassedTestsMenuItem";
         this.runPassedTestsMenuItem.Size = new System.Drawing.Size(234, 26);
         this.runPassedTestsMenuItem.Text = "&Passed Tests";
         // 
         // toolStripSeparator4
         // 
         this.toolStripSeparator4.Name = "toolStripSeparator4";
         this.toolStripSeparator4.Size = new System.Drawing.Size(231, 6);
         // 
         // runLastRunMenuItem
         // 
         this.runLastRunMenuItem.Enabled = false;
         this.runLastRunMenuItem.Name = "runLastRunMenuItem";
         this.runLastRunMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
         this.runLastRunMenuItem.Size = new System.Drawing.Size(234, 26);
         this.runLastRunMenuItem.Text = "Repeat &Last Run";
         // 
         // runSelectedButton
         // 
         this.runSelectedButton.Image = global::Rubberduck.Properties.Resources.list_arrow_green1;
         this.runSelectedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.runSelectedButton.Name = "runSelectedButton";
         this.runSelectedButton.Size = new System.Drawing.Size(99, 24);
         this.runSelectedButton.Text = "Run Selected";
         // 
         // addButton
         // 
         this.addButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTestModuleButton,
            this.toolStripSeparator2,
            this.addTestMethodButton,
            this.addExpectedErrorTestMethodButton});
         this.addButton.Image = global::Rubberduck.Properties.Resources.flask_plus;
         this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.addButton.Name = "addButton";
         this.addButton.Size = new System.Drawing.Size(62, 24);
         this.addButton.Text = "&Add";
         // 
         // addTestModuleButton
         // 
         this.addTestModuleButton.Image = global::Rubberduck.Properties.Resources.flask_empty;
         this.addTestModuleButton.Name = "addTestModuleButton";
         this.addTestModuleButton.Size = new System.Drawing.Size(226, 22);
         this.addTestModuleButton.Text = "Test &Module";
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(223, 6);
         // 
         // addTestMethodButton
         // 
         this.addTestMethodButton.Image = global::Rubberduck.Properties.Resources.flask;
         this.addTestMethodButton.ImageTransparentColor = System.Drawing.Color.Fuchsia;
         this.addTestMethodButton.Name = "addTestMethodButton";
         this.addTestMethodButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
         this.addTestMethodButton.Size = new System.Drawing.Size(226, 22);
         this.addTestMethodButton.Text = "&Test Method";
         // 
         // addExpectedErrorTestMethodButton
         // 
         this.addExpectedErrorTestMethodButton.Image = global::Rubberduck.Properties.Resources.flask_exclamation;
         this.addExpectedErrorTestMethodButton.Name = "addExpectedErrorTestMethodButton";
         this.addExpectedErrorTestMethodButton.Size = new System.Drawing.Size(226, 22);
         this.addExpectedErrorTestMethodButton.Text = "Test Method (Expected &Error)";
         // 
         // gotoSelectionButton
         // 
         this.gotoSelectionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.gotoSelectionButton.Image = global::Rubberduck.Properties.Resources.arrow;
         this.gotoSelectionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.gotoSelectionButton.Name = "gotoSelectionButton";
         this.gotoSelectionButton.Size = new System.Drawing.Size(24, 24);
         this.gotoSelectionButton.ToolTipText = "Navigate to selected";
         // 
         // TestExplorerWindow
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.toolStrip1);
         this.MinimumSize = new System.Drawing.Size(600, 200);
         this.Name = "TestExplorerWindow";
         this.Size = new System.Drawing.Size(670, 200);
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.panel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.testOutputGridView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton refreshTestsButton;
        private Panel panel1;
        private DataGridView testOutputGridView;
        private ToolStripSplitButton runButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem runSelectedTestMenuItem;
        private ToolStripMenuItem runAllTestsMenuItem;
        private ToolStripMenuItem runFailedTestsMenuItem;
        private ToolStripMenuItem runNotRunTestsMenuItem;
        private ToolStripMenuItem runPassedTestsMenuItem;
        private ToolStripMenuItem runLastRunMenuItem;
        private ToolStripDropDownButton addButton;
        private ToolStripMenuItem addTestModuleButton;
        private ToolStripMenuItem addTestMethodButton;
        private ToolStripMenuItem addExpectedErrorTestMethodButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton gotoSelectionButton;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripProgressBar testProgressBar;
        private ToolStripLabel passedTestsLabel;
        private ToolStripLabel failedTestsLabel;
        private ToolStripLabel inconclusiveTestsLabel;
        private ToolStripLabel TotalElapsedMilisecondsLabel;
        private ToolStripSeparator toolStripSeparator6;
      private ToolStripButton runSelectedButton;
   }
}