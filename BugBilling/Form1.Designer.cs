namespace BugBilling {
    partial class MainUI {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstGamepathlabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ScreenBox = new System.Windows.Forms.CheckBox();
            this.donebox = new System.Windows.Forms.CheckBox();
            this.zipBox = new System.Windows.Forms.CheckBox();
            this.LauncherLogsCheckbox = new System.Windows.Forms.CheckBox();
            this.GameLogCheckbox = new System.Windows.Forms.CheckBox();
            this.gamePathCheckBox = new System.Windows.Forms.CheckBox();
            this.dxdiagchkbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tstGamepathlabel,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 156);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(554, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel1.Text = "Game Path:";
            this.toolStripLabel1.ToolTipText = "Путь к установленной игре";
            // 
            // tstGamepathlabel
            // 
            this.tstGamepathlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tstGamepathlabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tstGamepathlabel.Name = "tstGamepathlabel";
            this.tstGamepathlabel.Size = new System.Drawing.Size(53, 22);
            this.tstGamepathlabel.Text = "Unknown";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.BackgroundImage = global::BugBilling.Properties.Resources._512px_Telegram_logo_svg;
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ScreenBox);
            this.groupBox1.Controls.Add(this.donebox);
            this.groupBox1.Controls.Add(this.zipBox);
            this.groupBox1.Controls.Add(this.LauncherLogsCheckbox);
            this.groupBox1.Controls.Add(this.GameLogCheckbox);
            this.groupBox1.Controls.Add(this.gamePathCheckBox);
            this.groupBox1.Controls.Add(this.dxdiagchkbox);
            this.groupBox1.Location = new System.Drawing.Point(419, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 145);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // ScreenBox
            // 
            this.ScreenBox.AutoSize = true;
            this.ScreenBox.Enabled = false;
            this.ScreenBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScreenBox.Location = new System.Drawing.Point(6, 101);
            this.ScreenBox.Name = "ScreenBox";
            this.ScreenBox.Size = new System.Drawing.Size(62, 17);
            this.ScreenBox.TabIndex = 6;
            this.ScreenBox.Text = "Screens";
            this.ScreenBox.UseVisualStyleBackColor = true;
            this.ScreenBox.Visible = false;
            // 
            // donebox
            // 
            this.donebox.AutoSize = true;
            this.donebox.Enabled = false;
            this.donebox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donebox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.donebox.Location = new System.Drawing.Point(6, 124);
            this.donebox.Name = "donebox";
            this.donebox.Size = new System.Drawing.Size(49, 17);
            this.donebox.TabIndex = 5;
            this.donebox.Text = "Done";
            this.donebox.UseVisualStyleBackColor = true;
            // 
            // zipBox
            // 
            this.zipBox.AutoSize = true;
            this.zipBox.Enabled = false;
            this.zipBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zipBox.Location = new System.Drawing.Point(6, 85);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(79, 17);
            this.zipBox.TabIndex = 4;
            this.zipBox.Text = "ZIP Archive";
            this.zipBox.UseVisualStyleBackColor = true;
            // 
            // LauncherLogsCheckbox
            // 
            this.LauncherLogsCheckbox.AutoSize = true;
            this.LauncherLogsCheckbox.Enabled = false;
            this.LauncherLogsCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LauncherLogsCheckbox.Location = new System.Drawing.Point(6, 69);
            this.LauncherLogsCheckbox.Name = "LauncherLogsCheckbox";
            this.LauncherLogsCheckbox.Size = new System.Drawing.Size(89, 17);
            this.LauncherLogsCheckbox.TabIndex = 3;
            this.LauncherLogsCheckbox.Text = "Launcher Log";
            this.LauncherLogsCheckbox.UseVisualStyleBackColor = true;
            // 
            // GameLogCheckbox
            // 
            this.GameLogCheckbox.AutoSize = true;
            this.GameLogCheckbox.Enabled = false;
            this.GameLogCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameLogCheckbox.Location = new System.Drawing.Point(6, 53);
            this.GameLogCheckbox.Name = "GameLogCheckbox";
            this.GameLogCheckbox.Size = new System.Drawing.Size(72, 17);
            this.GameLogCheckbox.TabIndex = 2;
            this.GameLogCheckbox.Text = "Game Log";
            this.GameLogCheckbox.UseVisualStyleBackColor = true;
            // 
            // gamePathCheckBox
            // 
            this.gamePathCheckBox.AutoSize = true;
            this.gamePathCheckBox.Enabled = false;
            this.gamePathCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamePathCheckBox.Location = new System.Drawing.Point(6, 19);
            this.gamePathCheckBox.Name = "gamePathCheckBox";
            this.gamePathCheckBox.Size = new System.Drawing.Size(76, 17);
            this.gamePathCheckBox.TabIndex = 1;
            this.gamePathCheckBox.Text = "Game Path";
            this.gamePathCheckBox.UseVisualStyleBackColor = true;
            // 
            // dxdiagchkbox
            // 
            this.dxdiagchkbox.AutoSize = true;
            this.dxdiagchkbox.Enabled = false;
            this.dxdiagchkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dxdiagchkbox.Location = new System.Drawing.Point(6, 36);
            this.dxdiagchkbox.Name = "dxdiagchkbox";
            this.dxdiagchkbox.Size = new System.Drawing.Size(64, 17);
            this.dxdiagchkbox.TabIndex = 0;
            this.dxdiagchkbox.Text = "DXDIAG";
            this.dxdiagchkbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Version:";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(48, 134);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(29, 13);
            this.versionLabel.TabIndex = 8;
            this.versionLabel.Text = "NaN";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BugBilling.Properties.Resources.War_Thunder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(554, 181);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 220);
            this.MinimumSize = new System.Drawing.Size(570, 220);
            this.Name = "MainUI";
            this.Text = "War Thunder report tool";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel tstGamepathlabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox dxdiagchkbox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.CheckBox LauncherLogsCheckbox;
        private System.Windows.Forms.CheckBox GameLogCheckbox;
        private System.Windows.Forms.CheckBox gamePathCheckBox;
        private System.Windows.Forms.CheckBox donebox;
        private System.Windows.Forms.CheckBox zipBox;
        private System.Windows.Forms.CheckBox ScreenBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label versionLabel;
    }
}

