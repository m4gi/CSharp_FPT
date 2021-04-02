
namespace LoginForm
{
    partial class SimpleDrawing
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
            this.components = new System.ComponentModel.Container();
            this.lb_Header = new System.Windows.Forms.Label();
            this.groupBox_Choose = new System.Windows.Forms.GroupBox();
            this.radCircle = new System.Windows.Forms.RadioButton();
            this.radRectangle = new System.Windows.Forms.RadioButton();
            this.privateFontCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combox_Color = new System.Windows.Forms.ComboBox();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.btnDraw = new System.Windows.Forms.Button();
            this.groupBox_Choose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.privateFontCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Header
            // 
            this.lb_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Header.AutoSize = true;
            this.lb_Header.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Header.Location = new System.Drawing.Point(186, 9);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(209, 46);
            this.lb_Header.TabIndex = 0;
            this.lb_Header.Text = "Draw Shape";
            // 
            // groupBox_Choose
            // 
            this.groupBox_Choose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Choose.Controls.Add(this.radCircle);
            this.groupBox_Choose.Controls.Add(this.radRectangle);
            this.groupBox_Choose.Location = new System.Drawing.Point(12, 71);
            this.groupBox_Choose.Name = "groupBox_Choose";
            this.groupBox_Choose.Size = new System.Drawing.Size(202, 102);
            this.groupBox_Choose.TabIndex = 1;
            this.groupBox_Choose.TabStop = false;
            this.groupBox_Choose.Text = "Choose a shape";
            // 
            // radCircle
            // 
            this.radCircle.AutoSize = true;
            this.radCircle.Location = new System.Drawing.Point(142, 43);
            this.radCircle.Name = "radCircle";
            this.radCircle.Size = new System.Drawing.Size(51, 17);
            this.radCircle.TabIndex = 1;
            this.radCircle.Text = "Circle";
            this.radCircle.UseVisualStyleBackColor = true;
            // 
            // radRectangle
            // 
            this.radRectangle.AutoSize = true;
            this.radRectangle.Checked = true;
            this.radRectangle.Location = new System.Drawing.Point(6, 43);
            this.radRectangle.Name = "radRectangle";
            this.radRectangle.Size = new System.Drawing.Size(74, 17);
            this.radRectangle.TabIndex = 0;
            this.radRectangle.TabStop = true;
            this.radRectangle.Text = "Rectangle";
            this.radRectangle.UseVisualStyleBackColor = true;
            // 
            // privateFontCollectionBindingSource
            // 
            this.privateFontCollectionBindingSource.DataSource = typeof(System.Drawing.Text.PrivateFontCollection);
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(System.Drawing.Color);
            // 
            // combox_Color
            // 
            this.combox_Color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combox_Color.FormattingEnabled = true;
            this.combox_Color.Location = new System.Drawing.Point(305, 81);
            this.combox_Color.Name = "combox_Color";
            this.combox_Color.Size = new System.Drawing.Size(121, 21);
            this.combox_Color.TabIndex = 2;
            this.combox_Color.Tag = "";
            // 
            // panelDraw
            // 
            this.panelDraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDraw.Location = new System.Drawing.Point(135, 188);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(250, 250);
            this.panelDraw.TabIndex = 4;
            // 
            // btnDraw
            // 
            this.btnDraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDraw.Location = new System.Drawing.Point(320, 150);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 3;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // SimpleDrawing
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.combox_Color);
            this.Controls.Add(this.groupBox_Choose);
            this.Controls.Add(this.lb_Header);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SimpleDrawing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleDrawing";
            this.Load += new System.EventHandler(this.SimpleDrawing_Load);
            this.groupBox_Choose.ResumeLayout(false);
            this.groupBox_Choose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.privateFontCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.GroupBox groupBox_Choose;
        private System.Windows.Forms.RadioButton radCircle;
        private System.Windows.Forms.RadioButton radRectangle;
        private System.Windows.Forms.BindingSource privateFontCollectionBindingSource;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private System.Windows.Forms.ComboBox combox_Color;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Button btnDraw;
    }
}