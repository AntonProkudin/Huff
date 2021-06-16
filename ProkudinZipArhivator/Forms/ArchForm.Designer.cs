
namespace ProkudinZipArhivator
{
    partial class ArchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Put1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Put2 = new System.Windows.Forms.TextBox();
            this.buuton = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите Архив";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(272, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "🔍";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Search1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Put1
            // 
            this.Put1.Location = new System.Drawing.Point(15, 28);
            this.Put1.Name = "Put1";
            this.Put1.Size = new System.Drawing.Size(251, 20);
            this.Put1.TabIndex = 0;
            this.Put1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Put1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите еденичный файл для архивации";
            // 
            // Put2
            // 
            this.Put2.Location = new System.Drawing.Point(15, 70);
            this.Put2.Name = "Put2";
            this.Put2.Size = new System.Drawing.Size(251, 20);
            this.Put2.TabIndex = 4;
            this.Put2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Put2_KeyPress);
            // 
            // buuton
            // 
            this.buuton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buuton.Location = new System.Drawing.Point(272, 69);
            this.buuton.Name = "buuton";
            this.buuton.Size = new System.Drawing.Size(25, 21);
            this.buuton.TabIndex = 5;
            this.buuton.Text = "🔍";
            this.buuton.UseVisualStyleBackColor = false;
            this.buuton.Click += new System.EventHandler(this.Search2);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(16, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(282, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Добавить в архив";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Add);
            // 
            // ArchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(309, 150);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buuton);
            this.Controls.Add(this.Put2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Put1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ArchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox Put1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Put2;
        private System.Windows.Forms.Button buuton;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button3;
    }
}