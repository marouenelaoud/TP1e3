namespace tp1__3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_eq1 = new System.Windows.Forms.TextBox();
            this.txt_eq2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_eq1 = new System.Windows.Forms.RadioButton();
            this.rdb_eq2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.list_eq1 = new System.Windows.Forms.ListBox();
            this.list_eq2 = new System.Windows.Forms.ListBox();
            this.res = new System.Windows.Forms.Button();
            this.raz = new System.Windows.Forms.Button();
            this.ajout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "EQUIPE 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "EQUIPE 2";
            // 
            // txt_eq1
            // 
            this.txt_eq1.Location = new System.Drawing.Point(112, 26);
            this.txt_eq1.Name = "txt_eq1";
            this.txt_eq1.Size = new System.Drawing.Size(152, 22);
            this.txt_eq1.TabIndex = 2;
            // 
            // txt_eq2
            // 
            this.txt_eq2.Location = new System.Drawing.Point(112, 74);
            this.txt_eq2.Name = "txt_eq2";
            this.txt_eq2.Size = new System.Drawing.Size(152, 22);
            this.txt_eq2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_eq2);
            this.groupBox1.Controls.Add(this.rdb_eq1);
            this.groupBox1.Location = new System.Drawing.Point(29, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 122);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Points marqué par ";
            // 
            // rdb_eq1
            // 
            this.rdb_eq1.AutoSize = true;
            this.rdb_eq1.Location = new System.Drawing.Point(34, 33);
            this.rdb_eq1.Name = "rdb_eq1";
            this.rdb_eq1.Size = new System.Drawing.Size(81, 20);
            this.rdb_eq1.TabIndex = 0;
            this.rdb_eq1.TabStop = true;
            this.rdb_eq1.Text = "Equipe 1";
            this.rdb_eq1.UseVisualStyleBackColor = true;
            this.rdb_eq1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_eq2
            // 
            this.rdb_eq2.AutoSize = true;
            this.rdb_eq2.Location = new System.Drawing.Point(34, 69);
            this.rdb_eq2.Name = "rdb_eq2";
            this.rdb_eq2.Size = new System.Drawing.Size(81, 20);
            this.rdb_eq2.TabIndex = 1;
            this.rdb_eq2.TabStop = true;
            this.rdb_eq2.Text = "Equipe 2";
            this.rdb_eq2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Transformation",
            "Pénalité",
            "Essai ",
            "Drop"});
            this.comboBox1.Location = new System.Drawing.Point(142, 311);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type d\'opération";
            // 
            // list_eq1
            // 
            this.list_eq1.FormattingEnabled = true;
            this.list_eq1.ItemHeight = 16;
            this.list_eq1.Location = new System.Drawing.Point(415, 61);
            this.list_eq1.Name = "list_eq1";
            this.list_eq1.Size = new System.Drawing.Size(139, 276);
            this.list_eq1.TabIndex = 7;
            // 
            // list_eq2
            // 
            this.list_eq2.FormattingEnabled = true;
            this.list_eq2.ItemHeight = 16;
            this.list_eq2.Location = new System.Drawing.Point(586, 61);
            this.list_eq2.Name = "list_eq2";
            this.list_eq2.Size = new System.Drawing.Size(147, 276);
            this.list_eq2.TabIndex = 8;
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(533, 373);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(75, 42);
            this.res.TabIndex = 9;
            this.res.Text = "Résultat";
            this.res.UseVisualStyleBackColor = true;
            this.res.Click += new System.EventHandler(this.res_Click);
            // 
            // raz
            // 
            this.raz.Location = new System.Drawing.Point(658, 373);
            this.raz.Name = "raz";
            this.raz.Size = new System.Drawing.Size(75, 42);
            this.raz.TabIndex = 10;
            this.raz.Text = "RAZ";
            this.raz.UseVisualStyleBackColor = true;
            this.raz.Click += new System.EventHandler(this.raz_Click);
            // 
            // ajout
            // 
            this.ajout.Location = new System.Drawing.Point(415, 373);
            this.ajout.Name = "ajout";
            this.ajout.Size = new System.Drawing.Size(75, 42);
            this.ajout.TabIndex = 11;
            this.ajout.Text = "Ajouter";
            this.ajout.UseVisualStyleBackColor = true;
            this.ajout.Click += new System.EventHandler(this.ajout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "EQUIPE 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "EQUIPE 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ajout);
            this.Controls.Add(this.raz);
            this.Controls.Add(this.res);
            this.Controls.Add(this.list_eq2);
            this.Controls.Add(this.list_eq1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_eq2);
            this.Controls.Add(this.txt_eq1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_eq1;
        private System.Windows.Forms.TextBox txt_eq2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_eq2;
        private System.Windows.Forms.RadioButton rdb_eq1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list_eq1;
        private System.Windows.Forms.ListBox list_eq2;
        private System.Windows.Forms.Button res;
        private System.Windows.Forms.Button raz;
        private System.Windows.Forms.Button ajout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

