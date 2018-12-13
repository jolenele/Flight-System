namespace FlightSystem
{
    partial class SceneBookingManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SceneBookingManager));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBookingHome = new System.Windows.Forms.ToolStripButton();
            this.SceneFlightManager = new System.Windows.Forms.ToolStripButton();
            this.SceneCustomerManager = new System.Windows.Forms.ToolStripButton();
            this.SceneBookManager = new System.Windows.Forms.ToolStripButton();
            this.tabBookView = new System.Windows.Forms.TabPage();
            this.rtxtBookView = new System.Windows.Forms.RichTextBox();
            this.tabBookAdd = new System.Windows.Forms.TabPage();
            this.vScrollBarFlight = new System.Windows.Forms.VScrollBar();
            this.vScrollBarCustomer = new System.Windows.Forms.VScrollBar();
            this.rtxtFlightView = new System.Windows.Forms.RichTextBox();
            this.rtxtCustView = new System.Windows.Forms.RichTextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtFlightNo = new System.Windows.Forms.TextBox();
            this.txtCustNo = new System.Windows.Forms.TextBox();
            this.btnBookCancelAdd = new System.Windows.Forms.Button();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFlightNo = new System.Windows.Forms.Label();
            this.lblCustNo = new System.Windows.Forms.Label();
            this.tabBookManage = new System.Windows.Forms.TabControl();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.tabBookView.SuspendLayout();
            this.tabBookAdd.SuspendLayout();
            this.tabBookManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBookingHome,
            this.SceneFlightManager,
            this.SceneCustomerManager,
            this.SceneBookManager});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBookingHome
            // 
            this.btnBookingHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBookingHome.Image = ((System.Drawing.Image)(resources.GetObject("btnBookingHome.Image")));
            this.btnBookingHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBookingHome.Name = "btnBookingHome";
            this.btnBookingHome.Size = new System.Drawing.Size(23, 22);
            this.btnBookingHome.Text = "toolStripButton1";
            this.btnBookingHome.Click += new System.EventHandler(this.btnBookingHome_Click);
            // 
            // SceneFlightManager
            // 
            this.SceneFlightManager.BackColor = System.Drawing.Color.Coral;
            this.SceneFlightManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SceneFlightManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SceneFlightManager.ForeColor = System.Drawing.Color.White;
            this.SceneFlightManager.Image = ((System.Drawing.Image)(resources.GetObject("SceneFlightManager.Image")));
            this.SceneFlightManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SceneFlightManager.Name = "SceneFlightManager";
            this.SceneFlightManager.Size = new System.Drawing.Size(91, 22);
            this.SceneFlightManager.Text = "Flight Manager";
            this.SceneFlightManager.Click += new System.EventHandler(this.SceneFlightManager_Click);
            // 
            // SceneCustomerManager
            // 
            this.SceneCustomerManager.BackColor = System.Drawing.Color.White;
            this.SceneCustomerManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SceneCustomerManager.ForeColor = System.Drawing.Color.Coral;
            this.SceneCustomerManager.Image = ((System.Drawing.Image)(resources.GetObject("SceneCustomerManager.Image")));
            this.SceneCustomerManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SceneCustomerManager.Name = "SceneCustomerManager";
            this.SceneCustomerManager.Size = new System.Drawing.Size(113, 22);
            this.SceneCustomerManager.Text = "Customer Manager";
            this.SceneCustomerManager.Click += new System.EventHandler(this.SceneCustomerManager_Click);
            // 
            // SceneBookManager
            // 
            this.SceneBookManager.BackColor = System.Drawing.Color.Coral;
            this.SceneBookManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SceneBookManager.ForeColor = System.Drawing.Color.White;
            this.SceneBookManager.Image = ((System.Drawing.Image)(resources.GetObject("SceneBookManager.Image")));
            this.SceneBookManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SceneBookManager.Name = "SceneBookManager";
            this.SceneBookManager.Size = new System.Drawing.Size(105, 22);
            this.SceneBookManager.Text = "Booking Manager";
            // 
            // tabBookView
            // 
            this.tabBookView.Controls.Add(this.rtxtBookView);
            this.tabBookView.Location = new System.Drawing.Point(4, 22);
            this.tabBookView.Name = "tabBookView";
            this.tabBookView.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookView.Size = new System.Drawing.Size(792, 395);
            this.tabBookView.TabIndex = 2;
            this.tabBookView.Text = "View Booking";
            this.tabBookView.UseVisualStyleBackColor = true;
            // 
            // rtxtBookView
            // 
            this.rtxtBookView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtBookView.Location = new System.Drawing.Point(3, 3);
            this.rtxtBookView.Name = "rtxtBookView";
            this.rtxtBookView.Size = new System.Drawing.Size(786, 389);
            this.rtxtBookView.TabIndex = 0;
            this.rtxtBookView.Text = "";
            // 
            // tabBookAdd
            // 
            this.tabBookAdd.Controls.Add(this.btnRefresh);
            this.tabBookAdd.Controls.Add(this.vScrollBarFlight);
            this.tabBookAdd.Controls.Add(this.vScrollBarCustomer);
            this.tabBookAdd.Controls.Add(this.rtxtFlightView);
            this.tabBookAdd.Controls.Add(this.rtxtCustView);
            this.tabBookAdd.Controls.Add(this.txtDate);
            this.tabBookAdd.Controls.Add(this.txtFlightNo);
            this.tabBookAdd.Controls.Add(this.txtCustNo);
            this.tabBookAdd.Controls.Add(this.btnBookCancelAdd);
            this.tabBookAdd.Controls.Add(this.btnBookAdd);
            this.tabBookAdd.Controls.Add(this.lblDate);
            this.tabBookAdd.Controls.Add(this.lblFlightNo);
            this.tabBookAdd.Controls.Add(this.lblCustNo);
            this.tabBookAdd.ForeColor = System.Drawing.Color.Coral;
            this.tabBookAdd.Location = new System.Drawing.Point(4, 22);
            this.tabBookAdd.Name = "tabBookAdd";
            this.tabBookAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookAdd.Size = new System.Drawing.Size(792, 395);
            this.tabBookAdd.TabIndex = 0;
            this.tabBookAdd.Text = "Add Booking";
            this.tabBookAdd.UseVisualStyleBackColor = true;
            // 
            // vScrollBarFlight
            // 
            this.vScrollBarFlight.Location = new System.Drawing.Point(757, 17);
            this.vScrollBarFlight.Name = "vScrollBarFlight";
            this.vScrollBarFlight.Size = new System.Drawing.Size(20, 196);
            this.vScrollBarFlight.TabIndex = 13;
            // 
            // vScrollBarCustomer
            // 
            this.vScrollBarCustomer.Location = new System.Drawing.Point(366, 20);
            this.vScrollBarCustomer.Name = "vScrollBarCustomer";
            this.vScrollBarCustomer.Size = new System.Drawing.Size(21, 194);
            this.vScrollBarCustomer.TabIndex = 12;
            // 
            // rtxtFlightView
            // 
            this.rtxtFlightView.Location = new System.Drawing.Point(399, 19);
            this.rtxtFlightView.Name = "rtxtFlightView";
            this.rtxtFlightView.Size = new System.Drawing.Size(378, 194);
            this.rtxtFlightView.TabIndex = 11;
            this.rtxtFlightView.Text = "";
            // 
            // rtxtCustView
            // 
            this.rtxtCustView.Location = new System.Drawing.Point(20, 17);
            this.rtxtCustView.Name = "rtxtCustView";
            this.rtxtCustView.Size = new System.Drawing.Size(367, 197);
            this.rtxtCustView.TabIndex = 10;
            this.rtxtCustView.Text = "";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(142, 319);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(246, 20);
            this.txtDate.TabIndex = 7;
            // 
            // txtFlightNo
            // 
            this.txtFlightNo.Location = new System.Drawing.Point(142, 279);
            this.txtFlightNo.Name = "txtFlightNo";
            this.txtFlightNo.Size = new System.Drawing.Size(246, 20);
            this.txtFlightNo.TabIndex = 6;
            // 
            // txtCustNo
            // 
            this.txtCustNo.Location = new System.Drawing.Point(142, 237);
            this.txtCustNo.Name = "txtCustNo";
            this.txtCustNo.Size = new System.Drawing.Size(246, 20);
            this.txtCustNo.TabIndex = 5;
            // 
            // btnBookCancelAdd
            // 
            this.btnBookCancelAdd.Location = new System.Drawing.Point(313, 362);
            this.btnBookCancelAdd.Name = "btnBookCancelAdd";
            this.btnBookCancelAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBookCancelAdd.TabIndex = 9;
            this.btnBookCancelAdd.Text = "Cancel";
            this.btnBookCancelAdd.UseVisualStyleBackColor = true;
            this.btnBookCancelAdd.Click += new System.EventHandler(this.btnBookCancelAdd_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(142, 362);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBookAdd.TabIndex = 8;
            this.btnBookAdd.Text = "Add";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(30, 327);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // lblFlightNo
            // 
            this.lblFlightNo.AutoSize = true;
            this.lblFlightNo.Location = new System.Drawing.Point(27, 287);
            this.lblFlightNo.Name = "lblFlightNo";
            this.lblFlightNo.Size = new System.Drawing.Size(46, 13);
            this.lblFlightNo.TabIndex = 2;
            this.lblFlightNo.Text = "Flight ID";
            // 
            // lblCustNo
            // 
            this.lblCustNo.AutoSize = true;
            this.lblCustNo.Location = new System.Drawing.Point(27, 244);
            this.lblCustNo.Name = "lblCustNo";
            this.lblCustNo.Size = new System.Drawing.Size(65, 13);
            this.lblCustNo.TabIndex = 1;
            this.lblCustNo.Text = "Customer ID";
            // 
            // tabBookManage
            // 
            this.tabBookManage.Controls.Add(this.tabBookAdd);
            this.tabBookManage.Controls.Add(this.tabBookView);
            this.tabBookManage.Location = new System.Drawing.Point(-2, 29);
            this.tabBookManage.Name = "tabBookManage";
            this.tabBookManage.SelectedIndex = 0;
            this.tabBookManage.Size = new System.Drawing.Size(800, 421);
            this.tabBookManage.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(17, 362);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // SceneBookingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabBookManage);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SceneBookingManager";
            this.Text = "SceneBookingManager";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabBookView.ResumeLayout(false);
            this.tabBookAdd.ResumeLayout(false);
            this.tabBookAdd.PerformLayout();
            this.tabBookManage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SceneFlightManager;
        private System.Windows.Forms.ToolStripButton SceneCustomerManager;
        private System.Windows.Forms.ToolStripButton SceneBookManager;
        private System.Windows.Forms.TabPage tabBookView;
        private System.Windows.Forms.RichTextBox rtxtBookView;
        private System.Windows.Forms.TabPage tabBookAdd;
        private System.Windows.Forms.VScrollBar vScrollBarFlight;
        private System.Windows.Forms.VScrollBar vScrollBarCustomer;
        private System.Windows.Forms.RichTextBox rtxtFlightView;
        private System.Windows.Forms.RichTextBox rtxtCustView;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtFlightNo;
        private System.Windows.Forms.TextBox txtCustNo;
        private System.Windows.Forms.Button btnBookCancelAdd;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblFlightNo;
        private System.Windows.Forms.Label lblCustNo;
        private System.Windows.Forms.TabControl tabBookManage;
        private System.Windows.Forms.ToolStripButton btnBookingHome;
        private System.Windows.Forms.Button btnRefresh;
    }
}