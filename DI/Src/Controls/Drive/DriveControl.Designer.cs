namespace DI.Src.Controls.Drive
{
    partial class DriveControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriveControl));
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.drivePanel = new System.Windows.Forms.TableLayoutPanel();
            this.driveTypePicture = new System.Windows.Forms.PictureBox();
            this.lblDriveName = new System.Windows.Forms.Label();
            this.sizePanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblAvaliableText = new System.Windows.Forms.Label();
            this.lblAvaliableValue = new System.Windows.Forms.Label();
            this.lblFreeText = new System.Windows.Forms.Label();
            this.lblFreeValue = new System.Windows.Forms.Label();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.sizeBar = new System.Windows.Forms.ProgressBar();
            this.directoryPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblLabelText = new System.Windows.Forms.Label();
            this.lblLabelValue = new System.Windows.Forms.Label();
            this.lblDirectoryText = new System.Windows.Forms.Label();
            this.lblDirectoryValue = new System.Windows.Forms.Label();
            this.lblFormatText = new System.Windows.Forms.Label();
            this.lblFormatValue = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.drivePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driveTypePicture)).BeginInit();
            this.sizePanel.SuspendLayout();
            this.directoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Controls.Add(this.drivePanel, 0, 0);
            this.mainPanel.Controls.Add(this.sizePanel, 1, 0);
            this.mainPanel.Controls.Add(this.directoryPanel, 2, 0);
            this.mainPanel.Name = "mainPanel";
            // 
            // drivePanel
            // 
            resources.ApplyResources(this.drivePanel, "drivePanel");
            this.drivePanel.Controls.Add(this.driveTypePicture, 0, 0);
            this.drivePanel.Controls.Add(this.lblDriveName, 0, 1);
            this.drivePanel.Name = "drivePanel";
            // 
            // driveTypePicture
            // 
            resources.ApplyResources(this.driveTypePicture, "driveTypePicture");
            this.driveTypePicture.Name = "driveTypePicture";
            this.driveTypePicture.TabStop = false;
            this.driveTypePicture.Click += new System.EventHandler(this.DriveTypePicture_Click);
            // 
            // lblDriveName
            // 
            resources.ApplyResources(this.lblDriveName, "lblDriveName");
            this.lblDriveName.Name = "lblDriveName";
            // 
            // sizePanel
            // 
            resources.ApplyResources(this.sizePanel, "sizePanel");
            this.sizePanel.Controls.Add(this.lblAvaliableText, 0, 0);
            this.sizePanel.Controls.Add(this.lblAvaliableValue, 1, 0);
            this.sizePanel.Controls.Add(this.lblFreeText, 0, 1);
            this.sizePanel.Controls.Add(this.lblFreeValue, 1, 1);
            this.sizePanel.Controls.Add(this.lblTotalText, 0, 2);
            this.sizePanel.Controls.Add(this.lblTotalValue, 1, 2);
            this.sizePanel.Controls.Add(this.sizeBar, 0, 3);
            this.sizePanel.Name = "sizePanel";
            // 
            // lblAvaliableText
            // 
            resources.ApplyResources(this.lblAvaliableText, "lblAvaliableText");
            this.lblAvaliableText.Name = "lblAvaliableText";
            // 
            // lblAvaliableValue
            // 
            resources.ApplyResources(this.lblAvaliableValue, "lblAvaliableValue");
            this.lblAvaliableValue.Name = "lblAvaliableValue";
            // 
            // lblFreeText
            // 
            resources.ApplyResources(this.lblFreeText, "lblFreeText");
            this.lblFreeText.Name = "lblFreeText";
            // 
            // lblFreeValue
            // 
            resources.ApplyResources(this.lblFreeValue, "lblFreeValue");
            this.lblFreeValue.Name = "lblFreeValue";
            // 
            // lblTotalText
            // 
            resources.ApplyResources(this.lblTotalText, "lblTotalText");
            this.lblTotalText.Name = "lblTotalText";
            // 
            // lblTotalValue
            // 
            resources.ApplyResources(this.lblTotalValue, "lblTotalValue");
            this.lblTotalValue.Name = "lblTotalValue";
            // 
            // sizeBar
            // 
            resources.ApplyResources(this.sizeBar, "sizeBar");
            this.sizePanel.SetColumnSpan(this.sizeBar, 2);
            this.sizeBar.MarqueeAnimationSpeed = 200;
            this.sizeBar.Name = "sizeBar";
            // 
            // directoryPanel
            // 
            resources.ApplyResources(this.directoryPanel, "directoryPanel");
            this.directoryPanel.Controls.Add(this.lblLabelText, 0, 0);
            this.directoryPanel.Controls.Add(this.lblLabelValue, 1, 0);
            this.directoryPanel.Controls.Add(this.lblDirectoryText, 0, 1);
            this.directoryPanel.Controls.Add(this.lblDirectoryValue, 1, 1);
            this.directoryPanel.Controls.Add(this.lblFormatText, 0, 2);
            this.directoryPanel.Controls.Add(this.lblFormatValue, 1, 2);
            this.directoryPanel.Name = "directoryPanel";
            // 
            // lblLabelText
            // 
            resources.ApplyResources(this.lblLabelText, "lblLabelText");
            this.lblLabelText.Name = "lblLabelText";
            // 
            // lblLabelValue
            // 
            resources.ApplyResources(this.lblLabelValue, "lblLabelValue");
            this.lblLabelValue.Name = "lblLabelValue";
            // 
            // lblDirectoryText
            // 
            resources.ApplyResources(this.lblDirectoryText, "lblDirectoryText");
            this.lblDirectoryText.Name = "lblDirectoryText";
            // 
            // lblDirectoryValue
            // 
            resources.ApplyResources(this.lblDirectoryValue, "lblDirectoryValue");
            this.lblDirectoryValue.Name = "lblDirectoryValue";
            // 
            // lblFormatText
            // 
            resources.ApplyResources(this.lblFormatText, "lblFormatText");
            this.lblFormatText.Name = "lblFormatText";
            // 
            // lblFormatValue
            // 
            resources.ApplyResources(this.lblFormatValue, "lblFormatValue");
            this.lblFormatValue.Name = "lblFormatValue";
            // 
            // DriveControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.mainPanel);
            this.Name = "DriveControl";
            this.mainPanel.ResumeLayout(false);
            this.drivePanel.ResumeLayout(false);
            this.drivePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driveTypePicture)).EndInit();
            this.sizePanel.ResumeLayout(false);
            this.sizePanel.PerformLayout();
            this.directoryPanel.ResumeLayout(false);
            this.directoryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.TableLayoutPanel drivePanel;
        private System.Windows.Forms.PictureBox driveTypePicture;
        private System.Windows.Forms.Label lblDriveName;
        private System.Windows.Forms.TableLayoutPanel sizePanel;
        private System.Windows.Forms.Label lblAvaliableText;
        private System.Windows.Forms.Label lblAvaliableValue;
        private System.Windows.Forms.Label lblFreeText;
        private System.Windows.Forms.Label lblFreeValue;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.TableLayoutPanel directoryPanel;
        private System.Windows.Forms.Label lblLabelText;
        private System.Windows.Forms.Label lblLabelValue;
        private System.Windows.Forms.Label lblDirectoryText;
        private System.Windows.Forms.Label lblDirectoryValue;
        private System.Windows.Forms.Label lblFormatText;
        private System.Windows.Forms.Label lblFormatValue;
        private System.Windows.Forms.ProgressBar sizeBar;
    }
}
