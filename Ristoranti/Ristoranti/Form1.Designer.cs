﻿namespace Ristoranti
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFatturato = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.txtTavoloAgg = new System.Windows.Forms.TextBox();
            this.btnEliminOrdin = new System.Windows.Forms.Button();
            this.btnAggiorna = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCercaAgg = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbQI = new System.Windows.Forms.TextBox();
            this.tbTI = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPaga = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnScontrino = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.btnFatturato);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(792, 425);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Fatturato";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(396, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "-----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "PREZZO";
            // 
            // btnFatturato
            // 
            this.btnFatturato.Location = new System.Drawing.Point(333, 141);
            this.btnFatturato.Name = "btnFatturato";
            this.btnFatturato.Size = new System.Drawing.Size(97, 41);
            this.btnFatturato.TabIndex = 0;
            this.btnFatturato.Text = "FATTURATO";
            this.btnFatturato.UseVisualStyleBackColor = true;
            this.btnFatturato.Click += new System.EventHandler(this.btnFatturato_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox3);
            this.tabPage3.Controls.Add(this.domainUpDown1);
            this.tabPage3.Controls.Add(this.txtTavoloAgg);
            this.tabPage3.Controls.Add(this.btnEliminOrdin);
            this.tabPage3.Controls.Add(this.btnAggiorna);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.listBox2);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btnCercaAgg);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Aggiorna";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(686, 15);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(70, 329);
            this.listBox3.TabIndex = 11;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged_1);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("7");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("9");
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Items.Add("11");
            this.domainUpDown1.Items.Add("12");
            this.domainUpDown1.Items.Add("13");
            this.domainUpDown1.Items.Add("14");
            this.domainUpDown1.Items.Add("15");
            this.domainUpDown1.Items.Add("16");
            this.domainUpDown1.Items.Add("17");
            this.domainUpDown1.Items.Add("18");
            this.domainUpDown1.Items.Add("19");
            this.domainUpDown1.Items.Add("20");
            this.domainUpDown1.Location = new System.Drawing.Point(273, 102);
            this.domainUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(34, 20);
            this.domainUpDown1.TabIndex = 10;
            this.domainUpDown1.Text = "1";
            // 
            // txtTavoloAgg
            // 
            this.txtTavoloAgg.Location = new System.Drawing.Point(40, 102);
            this.txtTavoloAgg.Margin = new System.Windows.Forms.Padding(2);
            this.txtTavoloAgg.Name = "txtTavoloAgg";
            this.txtTavoloAgg.Size = new System.Drawing.Size(76, 20);
            this.txtTavoloAgg.TabIndex = 9;
            // 
            // btnEliminOrdin
            // 
            this.btnEliminOrdin.Location = new System.Drawing.Point(233, 191);
            this.btnEliminOrdin.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminOrdin.Name = "btnEliminOrdin";
            this.btnEliminOrdin.Size = new System.Drawing.Size(74, 36);
            this.btnEliminOrdin.TabIndex = 6;
            this.btnEliminOrdin.Text = "Elimina ordine";
            this.btnEliminOrdin.UseVisualStyleBackColor = true;
            this.btnEliminOrdin.Click += new System.EventHandler(this.btnEliminOrdin_Click);
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.Location = new System.Drawing.Point(233, 124);
            this.btnAggiorna.Margin = new System.Windows.Forms.Padding(2);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new System.Drawing.Size(74, 23);
            this.btnAggiorna.TabIndex = 5;
            this.btnAggiorna.Text = "Aggiorna";
            this.btnAggiorna.UseVisualStyleBackColor = true;
            this.btnAggiorna.Click += new System.EventHandler(this.btnAggiorna_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quantità:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(566, 15);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(114, 329);
            this.listBox2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "n* tavolo";
            // 
            // btnCercaAgg
            // 
            this.btnCercaAgg.Location = new System.Drawing.Point(40, 144);
            this.btnCercaAgg.Margin = new System.Windows.Forms.Padding(2);
            this.btnCercaAgg.Name = "btnCercaAgg";
            this.btnCercaAgg.Size = new System.Drawing.Size(75, 41);
            this.btnCercaAgg.TabIndex = 0;
            this.btnCercaAgg.Text = "Cerca";
            this.btnCercaAgg.UseVisualStyleBackColor = true;
            this.btnCercaAgg.Click += new System.EventHandler(this.btnCercaAgg_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbNome);
            this.tabPage1.Controls.Add(this.tbQI);
            this.tabPage1.Controls.Add(this.tbTI);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnOrdina);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuovo tavolo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Location = new System.Drawing.Point(310, 197);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(85, 20);
            this.tbNome.TabIndex = 9;
            // 
            // tbQI
            // 
            this.tbQI.Location = new System.Drawing.Point(45, 337);
            this.tbQI.Margin = new System.Windows.Forms.Padding(2);
            this.tbQI.Name = "tbQI";
            this.tbQI.Size = new System.Drawing.Size(76, 20);
            this.tbQI.TabIndex = 5;
            this.tbQI.Text = "1";
            // 
            // tbTI
            // 
            this.tbTI.Location = new System.Drawing.Point(45, 66);
            this.tbTI.Margin = new System.Windows.Forms.Padding(2);
            this.tbTI.Name = "tbTI";
            this.tbTI.Size = new System.Drawing.Size(76, 20);
            this.tbTI.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Penne al sugo",
            "Vino",
            "Pizza",
            "Cotoletta",
            "Patatine",
            "Acqua",
            "Coca-Cola",
            "Gelato",
            "Bistecca",
            "Tagliata",
            "Risotto",
            "Grigliata",
            "Fritto misto",
            "Branzino",
            "Cheesecake"});
            this.listBox1.Location = new System.Drawing.Point(45, 128);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 160);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 112);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Nome del piatto";
            // 
            // btnOrdina
            // 
            this.btnOrdina.Location = new System.Drawing.Point(554, 178);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(102, 37);
            this.btnOrdina.TabIndex = 3;
            this.btnOrdina.Text = "Ordina";
            this.btnOrdina.UseVisualStyleBackColor = true;
            this.btnOrdina.Click += new System.EventHandler(this.btnOrdina_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantità";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci il numero del tavolo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.listView2);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.btnVisualizza);
            this.tabPage4.Controls.Add(this.radioButton3);
            this.tabPage4.Controls.Add(this.radioButton4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 425);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "Visualizza ordini";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 128);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 20);
            this.textBox2.TabIndex = 5;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(460, 44);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(229, 336);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prezzo";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tavolo";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "no tavolo";
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(134, 267);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(109, 37);
            this.btnVisualizza.TabIndex = 2;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(34, 90);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(99, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "ordini del tavolo";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(34, 67);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(75, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.Text = "ordini totali";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Controls.Add(this.btnPaga);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.btnScontrino);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(792, 425);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Scontrino-Salva";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "------";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnPaga
            // 
            this.btnPaga.Location = new System.Drawing.Point(469, 129);
            this.btnPaga.Name = "btnPaga";
            this.btnPaga.Size = new System.Drawing.Size(75, 23);
            this.btnPaga.TabIndex = 3;
            this.btnPaga.Text = "PAGA";
            this.btnPaga.UseVisualStyleBackColor = true;
            this.btnPaga.Click += new System.EventHandler(this.btnPaga_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(466, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "PREZZO";
            // 
            // btnScontrino
            // 
            this.btnScontrino.Location = new System.Drawing.Point(117, 129);
            this.btnScontrino.Name = "btnScontrino";
            this.btnScontrino.Size = new System.Drawing.Size(75, 23);
            this.btnScontrino.TabIndex = 1;
            this.btnScontrino.Text = "Scontrino";
            this.btnScontrino.UseVisualStyleBackColor = true;
            this.btnScontrino.Click += new System.EventHandler(this.btnScontrino_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "no tavolo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFatturato;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.TextBox txtTavoloAgg;
        private System.Windows.Forms.Button btnEliminOrdin;
        private System.Windows.Forms.Button btnAggiorna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCercaAgg;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbQI;
        private System.Windows.Forms.TextBox tbTI;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOrdina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPaga;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnScontrino;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

