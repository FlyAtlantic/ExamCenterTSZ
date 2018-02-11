namespace ExamCenterTSZ.UI.DashboardComponents
{
    partial class ButtonTyperating
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonTyperating));
            this.btnTyperating = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // btnTyperating
            // 
            this.btnTyperating.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnTyperating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnTyperating.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTyperating.BorderRadius = 0;
            this.btnTyperating.ButtonText = "bunifuFlatButton1";
            this.btnTyperating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTyperating.DisabledColor = System.Drawing.Color.Gray;
            this.btnTyperating.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTyperating.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTyperating.Iconimage")));
            this.btnTyperating.Iconimage_right = null;
            this.btnTyperating.Iconimage_right_Selected = null;
            this.btnTyperating.Iconimage_Selected = null;
            this.btnTyperating.IconMarginLeft = 0;
            this.btnTyperating.IconMarginRight = 0;
            this.btnTyperating.IconRightVisible = true;
            this.btnTyperating.IconRightZoom = 0D;
            this.btnTyperating.IconVisible = true;
            this.btnTyperating.IconZoom = 90D;
            this.btnTyperating.IsTab = false;
            this.btnTyperating.Location = new System.Drawing.Point(0, 0);
            this.btnTyperating.Name = "btnTyperating";
            this.btnTyperating.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnTyperating.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnTyperating.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTyperating.selected = false;
            this.btnTyperating.Size = new System.Drawing.Size(173, 48);
            this.btnTyperating.TabIndex = 1;
            this.btnTyperating.Text = "bunifuFlatButton1";
            this.btnTyperating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTyperating.Textcolor = System.Drawing.Color.White;
            this.btnTyperating.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTyperating.Click += new System.EventHandler(this.btnTyperating_Click);
            // 
            // ButtonTyperating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTyperating);
            this.Name = "ButtonTyperating";
            this.Size = new System.Drawing.Size(173, 48);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnTyperating;
    }
}
