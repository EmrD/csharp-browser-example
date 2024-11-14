namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.url_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.geri_button = new System.Windows.Forms.Button();
            this.ileri_button = new System.Windows.Forms.Button();
            this.git_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.Name = "webBrowser1";
            // 
            // url_input
            // 
            resources.ApplyResources(this.url_input, "url_input");
            this.url_input.Name = "url_input";
            this.url_input.TextChanged += new System.EventHandler(this.url_input_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // geri_button
            // 
            resources.ApplyResources(this.geri_button, "geri_button");
            this.geri_button.Name = "geri_button";
            this.geri_button.UseVisualStyleBackColor = true;
            this.geri_button.Click += new System.EventHandler(this.geri_button_Click);
            // 
            // ileri_button
            // 
            resources.ApplyResources(this.ileri_button, "ileri_button");
            this.ileri_button.Name = "ileri_button";
            this.ileri_button.UseVisualStyleBackColor = true;
            this.ileri_button.Click += new System.EventHandler(this.ileri_button_Click);
            // 
            // git_button
            // 
            resources.ApplyResources(this.git_button, "git_button");
            this.git_button.Name = "git_button";
            this.git_button.UseVisualStyleBackColor = true;
            this.git_button.Click += new System.EventHandler(this.git_button_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.git_button);
            this.Controls.Add(this.ileri_button);
            this.Controls.Add(this.geri_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.url_input);
            this.Controls.Add(this.webBrowser1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox url_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button geri_button;
        private System.Windows.Forms.Button ileri_button;
        private System.Windows.Forms.Button git_button;
    }
}

