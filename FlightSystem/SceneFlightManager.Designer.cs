namespace FlightSystem
{
    partial class SceneFlightManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SceneFlightManager));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFlightHome = new System.Windows.Forms.ToolStripButton();
            this.SceneFlightManage = new System.Windows.Forms.ToolStripButton();
            this.SceneCustomerManager = new System.Windows.Forms.ToolStripButton();
            this.SceneBookingManager = new System.Windows.Forms.ToolStripButton();
            this.tabFLightManager = new System.Windows.Forms.TabControl();
            this.tabFlightAdd = new System.Windows.Forms.TabPage();
            this.txtMaxSeat = new System.Windows.Forms.TextBox();
            this.lblMaxSeat = new System.Windows.Forms.Label();
            this.btnFlightCancelAdd = new System.Windows.Forms.Button();
            this.btnFlightAdd = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtFlightNo = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblFlightNo = new System.Windows.Forms.Label();
            this.tabFlightDelete = new System.Windows.Forms.TabPage();
            this.rtxtFilghtDelete = new System.Windows.Forms.RichTextBox();
            this.btnFlightCancelDelete = new System.Windows.Forms.Button();
            this.btnFlightDelete = new System.Windows.Forms.Button();
            this.txtFlightDelete = new System.Windows.Forms.TextBox();
            this.lblFlightDelete = new System.Windows.Forms.Label();
            this.tabFlightView = new System.Windows.Forms.TabPage();
            this.rtxtFlightView = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.tabFLightManager.SuspendLayout();
            this.tabFlightAdd.SuspendLayout();
            this.tabFlightDelete.SuspendLayout();
            this.tabFlightView.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFlightHome,
            this.SceneFlightManage,
            this.SceneCustomerManager,
            this.SceneBookingManager});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFlightHome
            // 
            this.btnFlightHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFlightHome.ForeColor = System.Drawing.Color.White;
            this.btnFlightHome.Image = ((System.Drawing.Image)(resources.GetObject("btnFlightHome.Image")));
            this.btnFlightHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFlightHome.Name = "btnFlightHome";
            this.btnFlightHome.Size = new System.Drawing.Size(23, 22);
            this.btnFlightHome.Text = "toolStripButton1";
            this.btnFlightHome.Click += new System.EventHandler(this.btnFlightHome_Click);
            // 
            // SceneFlightManage
            // 
            this.SceneFlightManage.BackColor = System.Drawing.Color.Coral;
            this.SceneFlightManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SceneFlightManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SceneFlightManage.ForeColor = System.Drawing.Color.White;
            this.SceneFlightManage.Image = ((System.Drawing.Image)(resources.GetObject("SceneFlightManage.Image")));
            this.SceneFlightManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SceneFlightManage.Name = "SceneFlightManage";
            this.SceneFlightManage.Size = new System.Drawing.Size(91, 22);
            this.SceneFlightManage.Text = "Flight Manager";
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
            // SceneBookingManager
            // 
            this.SceneBookingManager.BackColor = System.Drawing.Color.Coral;
            this.SceneBookingManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SceneBookingManager.ForeColor = System.Drawing.Color.White;
            this.SceneBookingManager.Image = ((System.Drawing.Image)(resources.GetObject("SceneBookingManager.Image")));
            this.SceneBookingManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SceneBookingManager.Name = "SceneBookingManager";
            this.SceneBookingManager.Size = new System.Drawing.Size(105, 22);
            this.SceneBookingManager.Text = "Booking Manager";
            this.SceneBookingManager.Click += new System.EventHandler(this.SceneBookingManager_Click);
            // 
            // tabFLightManager
            // 
            this.tabFLightManager.Controls.Add(this.tabFlightAdd);
            this.tabFLightManager.Controls.Add(this.tabFlightDelete);
            this.tabFLightManager.Controls.Add(this.tabFlightView);
            this.tabFLightManager.Location = new System.Drawing.Point(0, 28);
            this.tabFLightManager.Name = "tabFLightManager";
            this.tabFLightManager.SelectedIndex = 0;
            this.tabFLightManager.Size = new System.Drawing.Size(800, 421);
            this.tabFLightManager.TabIndex = 6;
            // 
            // tabFlightAdd
            // 
            this.tabFlightAdd.Controls.Add(this.txtMaxSeat);
            this.tabFlightAdd.Controls.Add(this.lblMaxSeat);
            this.tabFlightAdd.Controls.Add(this.btnFlightCancelAdd);
            this.tabFlightAdd.Controls.Add(this.btnFlightAdd);
            this.tabFlightAdd.Controls.Add(this.txtDestination);
            this.tabFlightAdd.Controls.Add(this.txtOrigin);
            this.tabFlightAdd.Controls.Add(this.txtFlightNo);
            this.tabFlightAdd.Controls.Add(this.lblDestination);
            this.tabFlightAdd.Controls.Add(this.lblOrigin);
            this.tabFlightAdd.Controls.Add(this.lblFlightNo);
            this.tabFlightAdd.ForeColor = System.Drawing.Color.Coral;
            this.tabFlightAdd.Location = new System.Drawing.Point(4, 22);
            this.tabFlightAdd.Name = "tabFlightAdd";
            this.tabFlightAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabFlightAdd.Size = new System.Drawing.Size(792, 395);
            this.tabFlightAdd.TabIndex = 0;
            this.tabFlightAdd.Text = "Add Flight";
            this.tabFlightAdd.UseVisualStyleBackColor = true;
            // 
            // txtMaxSeat
            // 
            this.txtMaxSeat.Location = new System.Drawing.Point(142, 192);
            this.txtMaxSeat.Name = "txtMaxSeat";
            this.txtMaxSeat.Size = new System.Drawing.Size(246, 20);
            this.txtMaxSeat.TabIndex = 11;
            // 
            // lblMaxSeat
            // 
            this.lblMaxSeat.AutoSize = true;
            this.lblMaxSeat.Location = new System.Drawing.Point(30, 192);
            this.lblMaxSeat.Name = "lblMaxSeat";
            this.lblMaxSeat.Size = new System.Drawing.Size(57, 13);
            this.lblMaxSeat.TabIndex = 10;
            this.lblMaxSeat.Text = "Max Seats";
            // 
            // btnFlightCancelAdd
            // 
            this.btnFlightCancelAdd.Location = new System.Drawing.Point(313, 253);
            this.btnFlightCancelAdd.Name = "btnFlightCancelAdd";
            this.btnFlightCancelAdd.Size = new System.Drawing.Size(75, 23);
            this.btnFlightCancelAdd.TabIndex = 9;
            this.btnFlightCancelAdd.Text = "Cancel";
            this.btnFlightCancelAdd.UseVisualStyleBackColor = true;
            this.btnFlightCancelAdd.Click += new System.EventHandler(this.btnFlightCancelAdd_Click);
            // 
            // btnFlightAdd
            // 
            this.btnFlightAdd.Location = new System.Drawing.Point(142, 254);
            this.btnFlightAdd.Name = "btnFlightAdd";
            this.btnFlightAdd.Size = new System.Drawing.Size(75, 23);
            this.btnFlightAdd.TabIndex = 8;
            this.btnFlightAdd.Text = "Add";
            this.btnFlightAdd.UseVisualStyleBackColor = true;
            this.btnFlightAdd.Click += new System.EventHandler(this.btnFlightAdd_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(142, 136);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(246, 20);
            this.txtDestination.TabIndex = 6;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(142, 94);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(246, 20);
            this.txtOrigin.TabIndex = 5;
            // 
            // txtFlightNo
            // 
            this.txtFlightNo.Location = new System.Drawing.Point(142, 51);
            this.txtFlightNo.Name = "txtFlightNo";
            this.txtFlightNo.Size = new System.Drawing.Size(246, 20);
            this.txtFlightNo.TabIndex = 4;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(27, 144);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(60, 13);
            this.lblDestination.TabIndex = 2;
            this.lblDestination.Text = "Destination";
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(27, 101);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(34, 13);
            this.lblOrigin.TabIndex = 1;
            this.lblOrigin.Text = "Origin";
            // 
            // lblFlightNo
            // 
            this.lblFlightNo.AutoSize = true;
            this.lblFlightNo.Location = new System.Drawing.Point(27, 58);
            this.lblFlightNo.Name = "lblFlightNo";
            this.lblFlightNo.Size = new System.Drawing.Size(72, 13);
            this.lblFlightNo.TabIndex = 0;
            this.lblFlightNo.Text = "Flight Number";
            // 
            // tabFlightDelete
            // 
            this.tabFlightDelete.Controls.Add(this.rtxtFilghtDelete);
            this.tabFlightDelete.Controls.Add(this.btnFlightCancelDelete);
            this.tabFlightDelete.Controls.Add(this.btnFlightDelete);
            this.tabFlightDelete.Controls.Add(this.txtFlightDelete);
            this.tabFlightDelete.Controls.Add(this.lblFlightDelete);
            this.tabFlightDelete.ForeColor = System.Drawing.Color.Coral;
            this.tabFlightDelete.Location = new System.Drawing.Point(4, 22);
            this.tabFlightDelete.Name = "tabFlightDelete";
            this.tabFlightDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabFlightDelete.Size = new System.Drawing.Size(792, 395);
            this.tabFlightDelete.TabIndex = 1;
            this.tabFlightDelete.Text = "Delete FLight";
            this.tabFlightDelete.UseVisualStyleBackColor = true;
            // 
            // rtxtFilghtDelete
            // 
            this.rtxtFilghtDelete.Location = new System.Drawing.Point(8, 16);
            this.rtxtFilghtDelete.Name = "rtxtFilghtDelete";
            this.rtxtFilghtDelete.Size = new System.Drawing.Size(772, 240);
            this.rtxtFilghtDelete.TabIndex = 4;
            this.rtxtFilghtDelete.Text = "";
            // 
            // btnFlightCancelDelete
            // 
            this.btnFlightCancelDelete.Location = new System.Drawing.Point(309, 335);
            this.btnFlightCancelDelete.Name = "btnFlightCancelDelete";
            this.btnFlightCancelDelete.Size = new System.Drawing.Size(75, 23);
            this.btnFlightCancelDelete.TabIndex = 3;
            this.btnFlightCancelDelete.Text = "Cancel";
            this.btnFlightCancelDelete.UseVisualStyleBackColor = true;
            this.btnFlightCancelDelete.Click += new System.EventHandler(this.btnFlightCancelDelete_Click);
            // 
            // btnFlightDelete
            // 
            this.btnFlightDelete.Location = new System.Drawing.Point(144, 335);
            this.btnFlightDelete.Name = "btnFlightDelete";
            this.btnFlightDelete.Size = new System.Drawing.Size(75, 23);
            this.btnFlightDelete.TabIndex = 2;
            this.btnFlightDelete.Text = "Delete";
            this.btnFlightDelete.UseVisualStyleBackColor = true;
            this.btnFlightDelete.Click += new System.EventHandler(this.btnFlightDelete_Click);
            // 
            // txtFlightDelete
            // 
            this.txtFlightDelete.Location = new System.Drawing.Point(144, 274);
            this.txtFlightDelete.Name = "txtFlightDelete";
            this.txtFlightDelete.Size = new System.Drawing.Size(240, 20);
            this.txtFlightDelete.TabIndex = 1;
            // 
            // lblFlightDelete
            // 
            this.lblFlightDelete.AutoSize = true;
            this.lblFlightDelete.ForeColor = System.Drawing.Color.Coral;
            this.lblFlightDelete.Location = new System.Drawing.Point(23, 281);
            this.lblFlightDelete.Name = "lblFlightDelete";
            this.lblFlightDelete.Size = new System.Drawing.Size(72, 13);
            this.lblFlightDelete.TabIndex = 0;
            this.lblFlightDelete.Text = "Flight Number";
            // 
            // tabFlightView
            // 
            this.tabFlightView.Controls.Add(this.rtxtFlightView);
            this.tabFlightView.Location = new System.Drawing.Point(4, 22);
            this.tabFlightView.Name = "tabFlightView";
            this.tabFlightView.Padding = new System.Windows.Forms.Padding(3);
            this.tabFlightView.Size = new System.Drawing.Size(792, 395);
            this.tabFlightView.TabIndex = 2;
            this.tabFlightView.Text = "View Flight";
            this.tabFlightView.UseVisualStyleBackColor = true;
            // 
            // rtxtFlightView
            // 
            this.rtxtFlightView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtFlightView.Location = new System.Drawing.Point(3, 3);
            this.rtxtFlightView.Name = "rtxtFlightView";
            this.rtxtFlightView.Size = new System.Drawing.Size(786, 389);
            this.rtxtFlightView.TabIndex = 0;
            this.rtxtFlightView.Text = "";
            // 
            // SceneFlightManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabFLightManager);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SceneFlightManager";
            this.Text = "FlightManagerScene";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabFLightManager.ResumeLayout(false);
            this.tabFlightAdd.ResumeLayout(false);
            this.tabFlightAdd.PerformLayout();
            this.tabFlightDelete.ResumeLayout(false);
            this.tabFlightDelete.PerformLayout();
            this.tabFlightView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SceneFlightManage;
        private System.Windows.Forms.ToolStripButton SceneCustomerManager;
        private System.Windows.Forms.ToolStripButton SceneBookingManager;
        private System.Windows.Forms.TabControl tabFLightManager;
        private System.Windows.Forms.TabPage tabFlightAdd;
        private System.Windows.Forms.Button btnFlightCancelAdd;
        private System.Windows.Forms.Button btnFlightAdd;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtFlightNo;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label lblFlightNo;
        private System.Windows.Forms.TabPage tabFlightDelete;
        private System.Windows.Forms.Button btnFlightCancelDelete;
        private System.Windows.Forms.Button btnFlightDelete;
        private System.Windows.Forms.TextBox txtFlightDelete;
        private System.Windows.Forms.Label lblFlightDelete;
        private System.Windows.Forms.TabPage tabFlightView;
        private System.Windows.Forms.RichTextBox rtxtFlightView;
        private System.Windows.Forms.TextBox txtMaxSeat;
        private System.Windows.Forms.Label lblMaxSeat;
        private System.Windows.Forms.ToolStripButton btnFlightHome;
        private System.Windows.Forms.RichTextBox rtxtFilghtDelete;
    }
}