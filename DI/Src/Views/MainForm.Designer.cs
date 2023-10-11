namespace DI.Src.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.driveListControl = new DI.Src.Controls.DriveList.DriveListControl();
            this.tlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // tlPanel
            // 
            resources.ApplyResources(this.tlPanel, "tlPanel");
            this.tlPanel.Controls.Add(this.driveListControl, 1, 0);
            this.tlPanel.Name = "tlPanel";
            // 
            // driveListControl
            // 
            resources.ApplyResources(this.driveListControl, "driveListControl");
            this.driveListControl.Name = "driveListControl";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlPanel);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.tlPanel.ResumeLayout(false);
            this.tlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private Controls.DriveList.DriveListControl driveListControl;
    }
}

