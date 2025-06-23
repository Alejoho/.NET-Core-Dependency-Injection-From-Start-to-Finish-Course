namespace WinForms
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
            showLabelContent = new Button();
            helloLabel = new Label();
            goodByeLabel = new Label();
            SuspendLayout();
            // 
            // showLabelContent
            // 
            showLabelContent.Location = new Point(57, 141);
            showLabelContent.Name = "showLabelContent";
            showLabelContent.Size = new Size(84, 34);
            showLabelContent.TabIndex = 0;
            showLabelContent.Text = "Show";
            showLabelContent.UseVisualStyleBackColor = true;
            showLabelContent.Click += showLabelContent_Click;
            // 
            // helloLabel
            // 
            helloLabel.AutoSize = true;
            helloLabel.Location = new Point(57, 53);
            helloLabel.Name = "helloLabel";
            helloLabel.Size = new Size(44, 15);
            helloLabel.TabIndex = 1;
            helloLabel.Text = "label1: ";
            // 
            // goodByeLabel
            // 
            goodByeLabel.AutoSize = true;
            goodByeLabel.Location = new Point(57, 92);
            goodByeLabel.Name = "goodByeLabel";
            goodByeLabel.Size = new Size(44, 15);
            goodByeLabel.TabIndex = 1;
            goodByeLabel.Text = "label2: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(goodByeLabel);
            Controls.Add(helloLabel);
            Controls.Add(showLabelContent);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button showLabelContent;
        private Label helloLabel;
        private Label goodByeLabel;
    }
}
