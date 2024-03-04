namespace Proba2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            futtat_button = new Button();
            egyik_label = new Label();
            masik_label = new Label();
            egyik_textbox = new TextBox();
            masik_textbox = new TextBox();
            SuspendLayout();
            // 
            // futtat_button
            // 
            futtat_button.Location = new Point(335, 275);
            futtat_button.Name = "futtat_button";
            futtat_button.Size = new Size(150, 46);
            futtat_button.TabIndex = 0;
            futtat_button.Text = "Add össze!";
            futtat_button.UseVisualStyleBackColor = true;
            futtat_button.Click += futtat_button_Click;
            // 
            // egyik_label
            // 
            egyik_label.AutoSize = true;
            egyik_label.Location = new Point(218, 98);
            egyik_label.Name = "egyik_label";
            egyik_label.Size = new Size(136, 32);
            egyik_label.TabIndex = 1;
            egyik_label.Text = "Egyik szám:";
            // 
            // masik_label
            // 
            masik_label.AutoSize = true;
            masik_label.Location = new Point(502, 98);
            masik_label.Name = "masik_label";
            masik_label.Size = new Size(142, 32);
            masik_label.TabIndex = 2;
            masik_label.Text = "Másik szám:";
            // 
            // egyik_textbox
            // 
            egyik_textbox.Location = new Point(188, 133);
            egyik_textbox.Name = "egyik_textbox";
            egyik_textbox.Size = new Size(200, 39);
            egyik_textbox.TabIndex = 3;
            // 
            // masik_textbox
            // 
            masik_textbox.Location = new Point(478, 133);
            masik_textbox.Name = "masik_textbox";
            masik_textbox.Size = new Size(200, 39);
            masik_textbox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(masik_textbox);
            Controls.Add(egyik_textbox);
            Controls.Add(masik_label);
            Controls.Add(egyik_label);
            Controls.Add(futtat_button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button futtat_button;
        private Label egyik_label;
        private Label masik_label;
        private TextBox egyik_textbox;
        private TextBox masik_textbox;
    }
}
