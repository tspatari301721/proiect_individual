
namespace Inventariere
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.adaugaConturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareConturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.ts_cb_CatBun = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.ts_cb_cont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ts_tb_NI = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ts_tb_Den = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1115, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(130, 22);
            this.toolStripButton1.Text = "Adauga Inregistrare";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaConturiToolStripMenuItem,
            this.editareConturiToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(95, 22);
            this.toolStripDropDownButton1.Text = "Administreaza";
            // 
            // adaugaConturiToolStripMenuItem
            // 
            this.adaugaConturiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fixeToolStripMenuItem,
            this.materialeToolStripMenuItem});
            this.adaugaConturiToolStripMenuItem.Name = "adaugaConturiToolStripMenuItem";
            this.adaugaConturiToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.adaugaConturiToolStripMenuItem.Text = "Adauga Conturi";
            // 
            // fixeToolStripMenuItem
            // 
            this.fixeToolStripMenuItem.Name = "fixeToolStripMenuItem";
            this.fixeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.fixeToolStripMenuItem.Text = "Fixe";
            // 
            // materialeToolStripMenuItem
            // 
            this.materialeToolStripMenuItem.Name = "materialeToolStripMenuItem";
            this.materialeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.materialeToolStripMenuItem.Text = "Materiale";
            // 
            // editareConturiToolStripMenuItem
            // 
            this.editareConturiToolStripMenuItem.Name = "editareConturiToolStripMenuItem";
            this.editareConturiToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.editareConturiToolStripMenuItem.Text = "Editare Conturi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1115, 522);
            this.dataGridView1.TabIndex = 4;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.ts_cb_CatBun,
            this.toolStripLabel4,
            this.ts_cb_cont,
            this.toolStripLabel1,
            this.ts_tb_NI,
            this.toolStripLabel2,
            this.ts_tb_Den,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1115, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(82, 22);
            this.toolStripLabel3.Text = "Categorie Bun";
            // 
            // ts_cb_CatBun
            // 
            this.ts_cb_CatBun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ts_cb_CatBun.Name = "ts_cb_CatBun";
            this.ts_cb_CatBun.Size = new System.Drawing.Size(121, 25);
            this.ts_cb_CatBun.SelectedIndexChanged += new System.EventHandler(this.cb_CatBun_SelectedIndexChanged);
            this.ts_cb_CatBun.TextChanged += new System.EventHandler(this.ts_tb_NI_TextChanged_1);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(33, 22);
            this.toolStripLabel4.Text = "Cont";
            // 
            // ts_cb_cont
            // 
            this.ts_cb_cont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ts_cb_cont.Name = "ts_cb_cont";
            this.ts_cb_cont.Size = new System.Drawing.Size(121, 25);
            this.ts_cb_cont.TextChanged += new System.EventHandler(this.ts_tb_NI_TextChanged_1);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(116, 22);
            this.toolStripLabel1.Text = "Numarul de inventar";
            // 
            // ts_tb_NI
            // 
            this.ts_tb_NI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ts_tb_NI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ts_tb_NI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ts_tb_NI.Name = "ts_tb_NI";
            this.ts_tb_NI.Size = new System.Drawing.Size(100, 25);
            this.ts_tb_NI.TextChanged += new System.EventHandler(this.ts_tb_NI_TextChanged_1);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "Denumire";
            // 
            // ts_tb_Den
            // 
            this.ts_tb_Den.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ts_tb_Den.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ts_tb_Den.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ts_tb_Den.Name = "ts_tb_Den";
            this.ts_tb_Den.Size = new System.Drawing.Size(100, 25);
            this.ts_tb_Den.TextChanged += new System.EventHandler(this.ts_tb_NI_TextChanged_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(89, 22);
            this.toolStripButton2.Text = "Curata filtre";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 575);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Aplicatie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem adaugaConturiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox ts_cb_CatBun;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox ts_cb_cont;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox ts_tb_NI;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox ts_tb_Den;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem fixeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareConturiToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

