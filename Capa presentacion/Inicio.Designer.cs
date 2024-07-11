
namespace Capa_presentacion
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSalir = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRecibos = new Guna.UI2.WinForms.Guna2Button();
            this.btnLibroDiario = new Guna.UI2.WinForms.Guna2Button();
            this.btnGastos = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Turquoise;
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.btnMinimize);
            this.guna2Panel1.Controls.Add(this.btnMaximize);
            this.guna2Panel1.Controls.Add(this.btnClose);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1488, 39);
            this.guna2Panel1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(9, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 30);
            this.label9.TabIndex = 1000;
            this.label9.Text = "Sistema recibos";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1370, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1406, 6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1442, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1488, 693);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnSalir);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(223, 588);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1041, 105);
            this.guna2Panel2.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BorderRadius = 5;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalir.FillColor = System.Drawing.Color.Firebrick;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(413, 18);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(15);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(221, 76);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "✘ Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.guna2Panel4);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(223, 103);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1041, 485);
            this.guna2Panel3.TabIndex = 2;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.guna2Panel5);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1041, 485);
            this.guna2Panel4.TabIndex = 0;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.btnRecibos);
            this.guna2Panel5.Controls.Add(this.btnLibroDiario);
            this.guna2Panel5.Controls.Add(this.btnGastos);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel5.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(1041, 485);
            this.guna2Panel5.TabIndex = 15;
            // 
            // btnRecibos
            // 
            this.btnRecibos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRecibos.BorderRadius = 5;
            this.btnRecibos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecibos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecibos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRecibos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecibos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRecibos.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnRecibos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnRecibos.ForeColor = System.Drawing.Color.White;
            this.btnRecibos.Location = new System.Drawing.Point(413, 101);
            this.btnRecibos.Margin = new System.Windows.Forms.Padding(15);
            this.btnRecibos.Name = "btnRecibos";
            this.btnRecibos.Size = new System.Drawing.Size(221, 76);
            this.btnRecibos.TabIndex = 11;
            this.btnRecibos.Text = "Recibos";
            this.btnRecibos.Click += new System.EventHandler(this.btnRecibos_Click);
            // 
            // btnLibroDiario
            // 
            this.btnLibroDiario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLibroDiario.BorderRadius = 5;
            this.btnLibroDiario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibroDiario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLibroDiario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLibroDiario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLibroDiario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLibroDiario.FillColor = System.Drawing.Color.MediumVioletRed;
            this.btnLibroDiario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLibroDiario.ForeColor = System.Drawing.Color.White;
            this.btnLibroDiario.Location = new System.Drawing.Point(413, 286);
            this.btnLibroDiario.Name = "btnLibroDiario";
            this.btnLibroDiario.Size = new System.Drawing.Size(221, 76);
            this.btnLibroDiario.TabIndex = 14;
            this.btnLibroDiario.Text = "Caja";
            this.btnLibroDiario.Click += new System.EventHandler(this.btnLibroDiario_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGastos.BorderRadius = 5;
            this.btnGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGastos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGastos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGastos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGastos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGastos.FillColor = System.Drawing.Color.BlueViolet;
            this.btnGastos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnGastos.ForeColor = System.Drawing.Color.White;
            this.btnGastos.Location = new System.Drawing.Point(413, 192);
            this.btnGastos.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(221, 76);
            this.btnGastos.TabIndex = 13;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(652, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bienvenido!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 732);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema recibos - Generar recibo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button btnSalir;
        private Guna.UI2.WinForms.Guna2Button btnRecibos;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnLibroDiario;
        private Guna.UI2.WinForms.Guna2Button btnGastos;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
    }
}