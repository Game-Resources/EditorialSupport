namespace GREditorialSupport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainPanel = new FlowLayoutPanel();
            editFlowLayoutPanel = new FlowLayoutPanel();
            contentEditCheckBox = new CheckBox();
            startButton = new Button();
            postEditCheckBox = new CheckBox();
            editLabel = new Label();
            mainEditCheckBox = new CheckBox();
            mainPanel.SuspendLayout();
            editFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(editFlowLayoutPanel);
            mainPanel.Controls.Add(startButton);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.FlowDirection = FlowDirection.TopDown;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 450);
            mainPanel.TabIndex = 0;
            // 
            // editFlowLayoutPanel
            // 
            editFlowLayoutPanel.Controls.Add(editLabel);
            editFlowLayoutPanel.Controls.Add(mainEditCheckBox);
            editFlowLayoutPanel.Controls.Add(contentEditCheckBox);
            editFlowLayoutPanel.Controls.Add(postEditCheckBox);
            editFlowLayoutPanel.Dock = DockStyle.Fill;
            editFlowLayoutPanel.Location = new Point(3, 3);
            editFlowLayoutPanel.Name = "editFlowLayoutPanel";
            editFlowLayoutPanel.Size = new Size(112, 150);
            editFlowLayoutPanel.TabIndex = 2;
            // 
            // contentEditCheckBox
            // 
            contentEditCheckBox.AutoSize = true;
            contentEditCheckBox.Location = new Point(3, 63);
            contentEditCheckBox.Name = "contentEditCheckBox";
            contentEditCheckBox.Size = new Size(101, 29);
            contentEditCheckBox.TabIndex = 0;
            contentEditCheckBox.Text = "Content";
            contentEditCheckBox.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            startButton.Location = new Point(3, 159);
            startButton.Name = "startButton";
            startButton.Size = new Size(112, 34);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            // 
            // postEditCheckBox
            // 
            postEditCheckBox.AutoSize = true;
            postEditCheckBox.Location = new Point(3, 98);
            postEditCheckBox.Name = "postEditCheckBox";
            postEditCheckBox.Size = new Size(73, 29);
            postEditCheckBox.TabIndex = 1;
            postEditCheckBox.Text = "Post";
            postEditCheckBox.UseVisualStyleBackColor = true;
            // 
            // editLabel
            // 
            editLabel.AutoSize = true;
            editLabel.Location = new Point(3, 0);
            editLabel.Name = "editLabel";
            editLabel.Size = new Size(42, 25);
            editLabel.TabIndex = 2;
            editLabel.Text = "Edit";
            // 
            // mainEditCheckBox
            // 
            mainEditCheckBox.AutoSize = true;
            mainEditCheckBox.Location = new Point(3, 28);
            mainEditCheckBox.Name = "mainEditCheckBox";
            mainEditCheckBox.Size = new Size(77, 29);
            mainEditCheckBox.TabIndex = 3;
            mainEditCheckBox.Text = "Main";
            mainEditCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "GREditorialSupport";
            mainPanel.ResumeLayout(false);
            editFlowLayoutPanel.ResumeLayout(false);
            editFlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel mainPanel;
        private FlowLayoutPanel editFlowLayoutPanel;
        private CheckBox contentEditCheckBox;
        private Button startButton;
        private Label editLabel;
        private CheckBox mainEditCheckBox;
        private CheckBox postEditCheckBox;
    }
}