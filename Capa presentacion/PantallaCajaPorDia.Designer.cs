
namespace Capa_presentacion
{
    partial class PantallaCajaPorDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaCajaPorDia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvCaja = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSaldo = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).BeginInit();
            this.guna2Panel3.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel6, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1488, 124);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Panel6.Controls.Add(this.label1);
            this.guna2Panel6.Controls.Add(this.txtFecha);
            this.guna2Panel6.Location = new System.Drawing.Point(291, 0);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(304, 124);
            this.guna2Panel6.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFecha.BorderRadius = 5;
            this.txtFecha.Checked = true;
            this.txtFecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha.Location = new System.Drawing.Point(10, 62);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.txtFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(221, 36);
            this.txtFecha.TabIndex = 0;
            this.txtFecha.Value = new System.DateTime(2024, 4, 14, 1, 51, 57, 941);
            this.txtFecha.ValueChanged += new System.EventHandler(this.txtFecha_ValueChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(660, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Caja diaria";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvCaja);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 163);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1488, 569);
            this.guna2Panel2.TabIndex = 6;
            // 
            // dgvCaja
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvCaja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvCaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCaja.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaja.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCaja.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvCaja.Location = new System.Drawing.Point(0, 0);
            this.dgvCaja.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCaja.Name = "dgvCaja";
            this.dgvCaja.RowHeadersVisible = false;
            this.dgvCaja.RowTemplate.Height = 30;
            this.dgvCaja.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaja.Size = new System.Drawing.Size(1488, 569);
            this.dgvCaja.TabIndex = 0;
            this.dgvCaja.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgvCaja.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvCaja.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCaja.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCaja.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCaja.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCaja.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCaja.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvCaja.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgvCaja.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCaja.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCaja.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCaja.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCaja.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvCaja.ThemeStyle.ReadOnly = false;
            this.dgvCaja.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvCaja.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvCaja.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCaja.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCaja.ThemeStyle.RowsStyle.Height = 30;
            this.dgvCaja.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvCaja.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Panel3.Controls.Add(this.txtSaldo);
            this.guna2Panel3.Location = new System.Drawing.Point(892, 0);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(304, 124);
            this.guna2Panel3.TabIndex = 2;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSaldo.AutoSize = true;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(0, 57);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(80, 20);
            this.txtSaldo.TabIndex = 1;
            this.txtSaldo.Text = "Saldo: $ ";
            // 
            // PantallaCajaPorDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 732);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaCajaPorDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema recibos - Generar recibo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaCajaPorDia_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtFecha;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCaja;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label txtSaldo;
    }
}