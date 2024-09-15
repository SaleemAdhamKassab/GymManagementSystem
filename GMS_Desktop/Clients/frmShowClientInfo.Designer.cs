namespace GMS_Desktop
{
    partial class frmShowClientInfo
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
            label1 = new Label();
            btnClose = new Button();
            ctrlPersonCard1 = new Coaches.ctrlPersonCard();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(758, 42);
            label1.TabIndex = 0;
            label1.Text = "Client Info";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(614, 419);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 40);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(13, 74);
            ctrlPersonCard1.Margin = new Padding(4);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(748, 328);
            ctrlPersonCard1.TabIndex = 15;
            // 
            // frmShowClientInfo
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(773, 470);
            Controls.Add(ctrlPersonCard1);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmShowClientInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client Info";
            Load += frmShowClientInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnClose;
        private Coaches.ctrlPersonCard ctrlPersonCard1;
    }
}