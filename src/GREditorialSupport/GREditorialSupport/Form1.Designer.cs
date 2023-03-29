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
            editingMethodomboBox = new ComboBox();
            mainEditCheckBox = new CheckBox();
            contentEditCheckBox = new CheckBox();
            postEditCheckBox = new CheckBox();
            startButton = new Button();
            mainTtableLayoutPanel = new TableLayoutPanel();
            editTableLayoutPanel = new TableLayoutPanel();
            calendarEditCheckBox = new CheckBox();
            mainTtableLayoutPanel.SuspendLayout();
            editTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // editingMethodomboBox
            // 
            editingMethodomboBox.FormattingEnabled = true;
            editingMethodomboBox.Items.AddRange(new object[] { "GitHubDevウェブエディター", "VisualStudioCode", "VisualStudioCodeInsiders" });
            editingMethodomboBox.Location = new Point(3, 3);
            editingMethodomboBox.Name = "editingMethodomboBox";
            editingMethodomboBox.Size = new Size(240, 33);
            editingMethodomboBox.TabIndex = 0;
            editingMethodomboBox.Text = "GitHubDevウェブエディター";
            // 
            // mainEditCheckBox
            // 
            mainEditCheckBox.AutoSize = true;
            mainEditCheckBox.Location = new Point(3, 3);
            mainEditCheckBox.Name = "mainEditCheckBox";
            mainEditCheckBox.Size = new Size(77, 29);
            mainEditCheckBox.TabIndex = 3;
            mainEditCheckBox.Text = "メイン";
            mainEditCheckBox.UseVisualStyleBackColor = true;
            // 
            // contentEditCheckBox
            // 
            contentEditCheckBox.AutoSize = true;
            contentEditCheckBox.Location = new Point(3, 38);
            contentEditCheckBox.Name = "contentEditCheckBox";
            contentEditCheckBox.Size = new Size(104, 29);
            contentEditCheckBox.TabIndex = 0;
            contentEditCheckBox.Text = "コンテンツ";
            contentEditCheckBox.UseVisualStyleBackColor = true;
            // 
            // postEditCheckBox
            // 
            postEditCheckBox.AutoSize = true;
            postEditCheckBox.Location = new Point(3, 108);
            postEditCheckBox.Name = "postEditCheckBox";
            postEditCheckBox.Size = new Size(74, 29);
            postEditCheckBox.TabIndex = 1;
            postEditCheckBox.Text = "投稿";
            postEditCheckBox.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            startButton.Location = new Point(3, 188);
            startButton.Name = "startButton";
            startButton.Size = new Size(112, 34);
            startButton.TabIndex = 1;
            startButton.Text = "開始";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // mainTtableLayoutPanel
            // 
            mainTtableLayoutPanel.ColumnCount = 1;
            mainTtableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTtableLayoutPanel.Controls.Add(startButton, 0, 2);
            mainTtableLayoutPanel.Controls.Add(editingMethodomboBox, 0, 0);
            mainTtableLayoutPanel.Controls.Add(editTableLayoutPanel, 0, 1);
            mainTtableLayoutPanel.Dock = DockStyle.Fill;
            mainTtableLayoutPanel.Location = new Point(0, 0);
            mainTtableLayoutPanel.Name = "mainTtableLayoutPanel";
            mainTtableLayoutPanel.RowCount = 3;
            mainTtableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTtableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTtableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTtableLayoutPanel.Size = new Size(273, 236);
            mainTtableLayoutPanel.TabIndex = 1;
            // 
            // editTableLayoutPanel
            // 
            editTableLayoutPanel.AutoSize = true;
            editTableLayoutPanel.ColumnCount = 1;
            editTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            editTableLayoutPanel.Controls.Add(postEditCheckBox, 0, 3);
            editTableLayoutPanel.Controls.Add(contentEditCheckBox, 0, 1);
            editTableLayoutPanel.Controls.Add(mainEditCheckBox, 0, 0);
            editTableLayoutPanel.Controls.Add(calendarEditCheckBox, 0, 2);
            editTableLayoutPanel.Location = new Point(3, 42);
            editTableLayoutPanel.Name = "editTableLayoutPanel";
            editTableLayoutPanel.RowCount = 4;
            editTableLayoutPanel.RowStyles.Add(new RowStyle());
            editTableLayoutPanel.RowStyles.Add(new RowStyle());
            editTableLayoutPanel.RowStyles.Add(new RowStyle());
            editTableLayoutPanel.RowStyles.Add(new RowStyle());
            editTableLayoutPanel.Size = new Size(110, 140);
            editTableLayoutPanel.TabIndex = 2;
            // 
            // calendarEditCheckBox
            // 
            calendarEditCheckBox.AutoSize = true;
            calendarEditCheckBox.Location = new Point(3, 73);
            calendarEditCheckBox.Name = "calendarEditCheckBox";
            calendarEditCheckBox.Size = new Size(103, 29);
            calendarEditCheckBox.TabIndex = 4;
            calendarEditCheckBox.Text = "カレンダー";
            calendarEditCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 236);
            Controls.Add(mainTtableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "GR編集サポート";
            mainTtableLayoutPanel.ResumeLayout(false);
            mainTtableLayoutPanel.PerformLayout();
            editTableLayoutPanel.ResumeLayout(false);
            editTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox contentEditCheckBox;
        private Button startButton;
        private CheckBox mainEditCheckBox;
        private CheckBox postEditCheckBox;
        private TabControl optionTabControl;
        private TabPage editTabPage;
        private TabPage editingMethodTabPage;
        private FlowLayoutPanel tabEditingMethodFlowLayoutPanel;
        private ComboBox editingMethodomboBox;
        private TableLayoutPanel mainTtableLayoutPanel;
        private TableLayoutPanel editTableLayoutPanel;
        private CheckBox calendarEditCheckBox;
    }
}