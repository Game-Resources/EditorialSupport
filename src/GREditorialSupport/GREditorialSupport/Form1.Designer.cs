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
            editingMethodomboBox = new ComboBox();
            editFlowLayoutPanel = new FlowLayoutPanel();
            mainEditCheckBox = new CheckBox();
            contentEditCheckBox = new CheckBox();
            postEditCheckBox = new CheckBox();
            startButton = new Button();
            mainPanel.SuspendLayout();
            editFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(editingMethodomboBox);
            mainPanel.Controls.Add(editFlowLayoutPanel);
            mainPanel.Controls.Add(startButton);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.FlowDirection = FlowDirection.TopDown;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(332, 200);
            mainPanel.TabIndex = 0;
            // 
            // editingMethodomboBox
            // 
            editingMethodomboBox.FormattingEnabled = true;
            editingMethodomboBox.Items.AddRange(new object[] { "GitHubDevWebEditor", "VisualStudioCode", "VisualStudioCodeInsiders" });
            editingMethodomboBox.Location = new Point(3, 3);
            editingMethodomboBox.Name = "editingMethodomboBox";
            editingMethodomboBox.Size = new Size(240, 33);
            editingMethodomboBox.TabIndex = 0;
            editingMethodomboBox.Text = "GitHubDevWebEditor";
            // 
            // editFlowLayoutPanel
            // 
            editFlowLayoutPanel.Controls.Add(mainEditCheckBox);
            editFlowLayoutPanel.Controls.Add(contentEditCheckBox);
            editFlowLayoutPanel.Controls.Add(postEditCheckBox);
            editFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            editFlowLayoutPanel.Location = new Point(3, 42);
            editFlowLayoutPanel.Name = "editFlowLayoutPanel";
            editFlowLayoutPanel.Size = new Size(286, 106);
            editFlowLayoutPanel.TabIndex = 0;
            // 
            // mainEditCheckBox
            // 
            mainEditCheckBox.AutoSize = true;
            mainEditCheckBox.Location = new Point(3, 3);
            mainEditCheckBox.Name = "mainEditCheckBox";
            mainEditCheckBox.Size = new Size(77, 29);
            mainEditCheckBox.TabIndex = 3;
            mainEditCheckBox.Text = "Main";
            mainEditCheckBox.UseVisualStyleBackColor = true;
            // 
            // contentEditCheckBox
            // 
            contentEditCheckBox.AutoSize = true;
            contentEditCheckBox.Location = new Point(3, 38);
            contentEditCheckBox.Name = "contentEditCheckBox";
            contentEditCheckBox.Size = new Size(101, 29);
            contentEditCheckBox.TabIndex = 0;
            contentEditCheckBox.Text = "Content";
            contentEditCheckBox.UseVisualStyleBackColor = true;
            // 
            // postEditCheckBox
            // 
            postEditCheckBox.AutoSize = true;
            postEditCheckBox.Location = new Point(3, 73);
            postEditCheckBox.Name = "postEditCheckBox";
            postEditCheckBox.Size = new Size(73, 29);
            postEditCheckBox.TabIndex = 1;
            postEditCheckBox.Text = "Post";
            postEditCheckBox.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            startButton.Location = new Point(3, 154);
            startButton.Name = "startButton";
            startButton.Size = new Size(112, 34);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 200);
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
        private CheckBox contentEditCheckBox;
        private Button startButton;
        private CheckBox mainEditCheckBox;
        private CheckBox postEditCheckBox;
        private TabControl optionTabControl;
        private TabPage editTabPage;
        private FlowLayoutPanel editFlowLayoutPanel;
        private TabPage editingMethodTabPage;
        private FlowLayoutPanel tabEditingMethodFlowLayoutPanel;
        private ComboBox editingMethodomboBox;
    }
}