namespace FlightSystem
{
    partial class SceneCustomerManger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SceneCustomerManger));
            this.tabCustomerManager = new System.Windows.Forms.TabControl();
            this.tabCustomerAdd = new System.Windows.Forms.TabPage();
            this.btnCustCancelAdd = new System.Windows.Forms.Button();
            this.btnCustAdd = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tabCustomerDelete = new System.Windows.Forms.TabPage();
            this.btnCustCancelDelete = new System.Windows.Forms.Button();
            this.btnCustDelete = new System.Windows.Forms.Button();
            this.txtCustDelete = new System.Windows.Forms.TextBox();
            this.lblCustDelete = new System.Windows.Forms.Label();
            this.tabCustomerView = new System.Windows.Forms.TabPage();
            this.rtxtCustomerView = new System.Windows.Forms.RichTextBox();
            this.btnCustomerHome = new System.Windows.Forms.ToolStripButton();
            this.SceneFlightManager = new System.Windows.Forms.ToolStripButton();
            this.SceneCustomerManager = new System.Windows.Forms.ToolStripButton();
            this.SceneBookingManager = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.rtxtCustDelete = new System.Windows.Forms.RichTextBox();
            this.tabCustomerManager.SuspendLayout();
            this.tabCustomerAdd.SuspendLayout();
            this.tabCustomerDelete.SuspendLayout();
            this.tabCustomerView.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCustomerManager
            // 
            this.tabCustomerManager.Controls.Add(this.tabCustomerAdd);
            this.tabCustomerManager.Controls.Add(this.tabCustomerDelete);
            this.tabCustomerManager.Controls.Add(this.tabCustomerView);
            this.tabCustomerManager.Location = new System.Drawing.Point(-1, 29);
            this.tabCustomerManager.Name = "tabCustomerManager";
            this.tabCustomerManager.SelectedIndex = 0;
            this.tabCustomerManager.Size = new System.Drawing.Size(800, 421);
            this.tabCustomerManager.TabIndex = 5;
            // 
            // tabCustomerAdd
            // 
            this.tabCustomerAdd.Controls.Add(this.btnCustCancelAdd);
            this.tabCustomerAdd.Controls.Add(this.btnCustAdd);
            this.tabCustomerAdd.Controls.Add(this.txtPhone);
            this.tabCustomerAdd.Controls.Add(this.txtLastName);
            this.tabCustomerAdd.Controls.Add(this.txtFirstName);
            this.tabCustomerAdd.Controls.Add(this.lblPhone);
            this.tabCustomerAdd.Controls.Add(this.lblLastName);
            this.tabCustomerAdd.Controls.Add(this.lblFirstName);
            this.tabCustomerAdd.ForeColor = System.Drawing.Color.Coral;
            this.tabCustomerAdd.Location = new System.Drawing.Point(4, 22);
            this.tabCustomerAdd.Name = "tabCustomerAdd";
            this.tabCustomerAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerAdd.Size = new System.Drawing.Size(792, 395);
            this.tabCustomerAdd.TabIndex = 0;
            this.tabCustomerAdd.Text = "Add Customer";
            this.tabCustomerAdd.UseVisualStyleBackColor = true;
            // 
            // btnCustCancelAdd
            // 
            this.btnCustCancelAdd.Location = new System.Drawing.Point(313, 253);
            this.btnCustCancelAdd.Name = "btnCustCancelAdd";
            this.btnCustCancelAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCustCancelAdd.TabIndex = 9;
            this.btnCustCancelAdd.Text = "Cancel";
            this.btnCustCancelAdd.UseVisualStyleBackColor = true;
            this.btnCustCancelAdd.Click += new System.EventHandler(this.btnCustCancelAdd_Click);
            // 
            // btnCustAdd
            // 
            this.btnCustAdd.Location = new System.Drawing.Point(142, 254);
            this.btnCustAdd.Name = "btnCustAdd";
            this.btnCustAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCustAdd.TabIndex = 8;
            this.btnCustAdd.Text = "Add";
            this.btnCustAdd.UseVisualStyleBackColor = true;
            this.btnCustAdd.Click += new System.EventHandler(this.btnCustAdd_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(142, 136);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(246, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(142, 94);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(246, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(142, 51);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(246, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(27, 144);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(27, 101);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(27, 58);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // tabCustomerDelete
            // 
            this.tabCustomerDelete.Controls.Add(this.rtxtCustDelete);
            this.tabCustomerDelete.Controls.Add(this.btnCustCancelDelete);
            this.tabCustomerDelete.Controls.Add(this.btnCustDelete);
            this.tabCustomerDelete.Controls.Add(this.txtCustDelete);
            this.tabCustomerDelete.Controls.Add(this.lblCustDelete);
            this.tabCustomerDelete.ForeColor = System.Drawing.Color.Coral;
            this.tabCustomerDelete.Location = new System.Drawing.Point(4, 22);
            this.tabCustomerDelete.Name = "tabCustomerDelete";
            this.tabCustomerDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerDelete.Size = new System.Drawing.Size(792, 395);
            this.tabCustomerDelete.TabIndex = 1;
            this.tabCustomerDelete.Text = "Delete Customer";
            this.tabCustomerDelete.UseVisualStyleBackColor = true;
            // 
            // btnCustCancelDelete
            // 
            this.btnCustCancelDelete.Location = new System.Drawing.Point(333, 349);
            this.btnCustCancelDelete.Name = "btnCustCancelDelete";
            this.btnCustCancelDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCustCancelDelete.TabIndex = 3;
            this.btnCustCancelDelete.Text = "Cancel";
            this.btnCustCancelDelete.UseVisualStyleBackColor = true;
            this.btnCustCancelDelete.Click += new System.EventHandler(this.btnCustCancelDelete_Click);
            // 
            // btnCustDelete
            // 
            this.btnCustDelete.Location = new System.Drawing.Point(168, 349);
            this.btnCustDelete.Name = "btnCustDelete";
            this.btnCustDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCustDelete.TabIndex = 2;
            this.btnCustDelete.Text = "Delete";
            this.btnCustDelete.UseVisualStyleBackColor = true;
            this.btnCustDelete.Click += new System.EventHandler(this.btnCustDelete_Click);
            // 
            // txtCustDelete
            // 
            this.txtCustDelete.Location = new System.Drawing.Point(168, 293);
            this.txtCustDelete.Name = "txtCustDelete";
            this.txtCustDelete.Size = new System.Drawing.Size(240, 20);
            this.txtCustDelete.TabIndex = 1;
            // 
            // lblCustDelete
            // 
            this.lblCustDelete.AutoSize = true;
            this.lblCustDelete.ForeColor = System.Drawing.Color.Coral;
            this.lblCustDelete.Location = new System.Drawing.Point(26, 300);
            this.lblCustDelete.Name = "lblCustDelete";
            this.lblCustDelete.Size = new System.Drawing.Size(91, 13);
            this.lblCustDelete.TabIndex = 0;
            this.lblCustDelete.Text = "Customer Number";
            // 
            // tabCustomerView
            // 
            this.tabCustomerView.Controls.Add(this.rtxtCustomerView);
            this.tabCustomerView.Location = new System.Drawing.Point(4, 22);
            this.tabCustomerView.Name = "tabCustomerView";
            this.tabCustomerView.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerView.Size = new System.Drawing.Size(792, 395);
            this.tabCustomerView.TabIndex = 2;
            this.tabCustomerView.Text = "View Customer";
            this.tabCustomerView.UseVisualStyleBackColor = true;
            // 
            // rtxtCustomerView
            // 
            this.rtxtCustomerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtCustomerView.Location = new System.Drawing.Point(3, 3);
            this.rtxtCustomerView.Name = "rtxtCustomerView";
            this.rtxtCustomerView.Size = new System.Drawing.Size(786, 389);
            this.rtxtCustomerView.TabIndex = 0;
            this.rtxtCustomerView.Text = "";
            // 
            // btnCustomerHome
            // 
            this.btnCustomerHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCustomerHome.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerHome.Image")));
            this.btnCustomerHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomerHome.Name = "btnCustomerHome";
            this.btnCustomerHome.Size = new System.Drawing.Size(23, 22);
            this.btnCustomerHome.Text = "toolStripButton1";
            this.btnCustomerHome.Click += new System.EventHandler(this.btnCustomerHome_Click);
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomerHome,
            this.SceneFlightManager,
            this.SceneCustomerManager,
            this.SceneBookingManager});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // rtxtCustDelete
            // 
            this.rtxtCustDelete.Location = new System.Drawing.Point(11, 11);
            this.rtxtCustDelete.Name = "rtxtCustDelete";
            this.rtxtCustDelete.Size = new System.Drawing.Size(761, 263);
            this.rtxtCustDelete.TabIndex = 4;
            this.rtxtCustDelete.Text = "";
            // 
            // SceneCustomerManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCustomerManager);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SceneCustomerManger";
            this.Text = "CustomerMangerScene";
            this.tabCustomerManager.ResumeLayout(false);
            this.tabCustomerAdd.ResumeLayout(false);
            this.tabCustomerAdd.PerformLayout();
            this.tabCustomerDelete.ResumeLayout(false);
            this.tabCustomerDelete.PerformLayout();
            this.tabCustomerView.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabCustomerManager;
        private System.Windows.Forms.TabPage tabCustomerAdd;
        private System.Windows.Forms.Button btnCustCancelAdd;
        private System.Windows.Forms.Button btnCustAdd;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TabPage tabCustomerDelete;
        private System.Windows.Forms.Button btnCustCancelDelete;
        private System.Windows.Forms.Button btnCustDelete;
        private System.Windows.Forms.TextBox txtCustDelete;
        private System.Windows.Forms.Label lblCustDelete;
        private System.Windows.Forms.TabPage tabCustomerView;
        private System.Windows.Forms.RichTextBox rtxtCustomerView;
        private System.Windows.Forms.ToolStripButton btnCustomerHome;
        private System.Windows.Forms.ToolStripButton SceneFlightManager;
        private System.Windows.Forms.ToolStripButton SceneCustomerManager;
        private System.Windows.Forms.ToolStripButton SceneBookingManager;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox rtxtCustDelete;
    }
}