namespace aplisantewelcome
{
    partial class FORMULAIRE_SERVICE_RENSEIGNEMENT
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numserv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nomma = new System.Windows.Forms.TextBox();
            this.dp1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.heur = new System.Windows.Forms.TextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.NumeroServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomMal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeureRens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom malade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date renseignement";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(268, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Supprimer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numserv
            // 
            this.numserv.Location = new System.Drawing.Point(192, 32);
            this.numserv.Margin = new System.Windows.Forms.Padding(4);
            this.numserv.Name = "numserv";
            this.numserv.Size = new System.Drawing.Size(169, 22);
            this.numserv.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Heure rens";
            // 
            // nomma
            // 
            this.nomma.Location = new System.Drawing.Point(192, 103);
            this.nomma.Margin = new System.Windows.Forms.Padding(4);
            this.nomma.Name = "nomma";
            this.nomma.Size = new System.Drawing.Size(169, 22);
            this.nomma.TabIndex = 6;
            // 
            // dp1
            // 
            this.dp1.Location = new System.Drawing.Point(188, 167);
            this.dp1.Margin = new System.Windows.Forms.Padding(4);
            this.dp1.Name = "dp1";
            this.dp1.Size = new System.Drawing.Size(173, 22);
            this.dp1.TabIndex = 7;
            // 
            // heur
            // 
            this.heur.Location = new System.Drawing.Point(188, 224);
            this.heur.Margin = new System.Windows.Forms.Padding(4);
            this.heur.Name = "heur";
            this.heur.Size = new System.Drawing.Size(173, 22);
            this.heur.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(130, 290);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "&Enregistrer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(395, 290);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "&Quitter";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroServ,
            this.NomMal,
            this.DateRens,
            this.HeureRens});
            this.table.Location = new System.Drawing.Point(381, 32);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(406, 217);
            this.table.TabIndex = 11;
            // 
            // NumeroServ
            // 
            this.NumeroServ.HeaderText = "NumeroServ";
            this.NumeroServ.Name = "NumeroServ";
            // 
            // NomMal
            // 
            this.NomMal.HeaderText = "NomMal";
            this.NomMal.Name = "NomMal";
            // 
            // DateRens
            // 
            this.DateRens.HeaderText = "DateRens";
            this.DateRens.Name = "DateRens";
            // 
            // HeureRens
            // 
            this.HeureRens.HeaderText = "HeureRens";
            this.HeureRens.Name = "HeureRens";
            // 
            // FORMULAIRE_SERVICE_RENSEIGNEMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 346);
            this.Controls.Add(this.table);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.heur);
            this.Controls.Add(this.dp1);
            this.Controls.Add(this.nomma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numserv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FORMULAIRE_SERVICE_RENSEIGNEMENT";
            this.Text = "FORMULAIRE_SERVICE_RENSEIGNEMENT";
            this.Load += new System.EventHandler(this.FORMULAIRE_SERVICE_RENSEIGNEMENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numserv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomma;
        private System.Windows.Forms.DateTimePicker dp1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox heur;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomMal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRens;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeureRens;
    }
}