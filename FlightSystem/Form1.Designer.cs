namespace FlightSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SceneFlightManager = new System.Windows.Forms.ToolStripButton();
            this.SceneCustomerManager = new System.Windows.Forms.ToolStripButton();
            this.SceneBookingManager = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lblHome = new System.Windows.Forms.Label();
            this.picHome2 = new System.Windows.Forms.PictureBox();
            this.picHome1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.SceneFlightManager,
            this.SceneCustomerManager,
            this.SceneBookingManager});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.ForeColor = System.Drawing.Color.Coral;
            this.lblHome.Location = new System.Drawing.Point(24, 58);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(153, 13);
            this.lblHome.TabIndex = 2;
            this.lblHome.Text = "Welcome to ABC Flight System";
            // 
            // picHome2
            // 
            this.picHome2.Image = ((System.Drawing.Image)(resources.GetObject("picHome2.Image")));
            this.picHome2.Location = new System.Drawing.Point(183, 42);
            this.picHome2.Name = "picHome2";
            this.picHome2.Size = new System.Drawing.Size(78, 47);
            this.picHome2.TabIndex = 3;
            this.picHome2.TabStop = false;
            // 
            // picHome1
            // 
            this.picHome1.Image = ((System.Drawing.Image)(resources.GetObject("picHome1.Image")));
            this.picHome1.Location = new System.Drawing.Point(177, 153);
            this.picHome1.Name = "picHome1";
            this.picHome1.Size = new System.Drawing.Size(599, 274);
            this.picHome1.TabIndex = 4;
            this.picHome1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picHome1);
            this.Controls.Add(this.picHome2);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Home";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SceneFlightManager;
        private System.Windows.Forms.ToolStripButton SceneCustomerManager;
        private System.Windows.Forms.ToolStripButton SceneBookingManager;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.PictureBox picHome2;
        private System.Windows.Forms.PictureBox picHome1;
    }
}

