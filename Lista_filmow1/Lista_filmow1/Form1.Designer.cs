namespace Lista_filmow1
{
    partial class Filmy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tytul = new System.Windows.Forms.Label();
            this.rezyser = new System.Windows.Forms.Label();
            this.premiera = new System.Windows.Forms.Label();
            this.aktor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Dodawanie = new System.Windows.Forms.Button();
            this.Zapisywanie = new System.Windows.Forms.Button();
            this.Zamykanie = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumTytul = new System.Windows.Forms.ColumnHeader();
            this.ColumnReżyser = new System.Windows.Forms.ColumnHeader();
            this.ColumnPremiery = new System.Windows.Forms.ColumnHeader();
            this.ColumnAktor = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Usuń = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.Location = new System.Drawing.Point(108, 36);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(35, 15);
            this.tytul.TabIndex = 0;
            this.tytul.Text = "Tytuł:";
            // 
            // rezyser
            // 
            this.rezyser.AutoSize = true;
            this.rezyser.Location = new System.Drawing.Point(108, 89);
            this.rezyser.Name = "rezyser";
            this.rezyser.Size = new System.Drawing.Size(49, 15);
            this.rezyser.TabIndex = 1;
            this.rezyser.Text = "Reżyser:";
            // 
            // premiera
            // 
            this.premiera.AutoSize = true;
            this.premiera.Location = new System.Drawing.Point(431, 36);
            this.premiera.Name = "premiera";
            this.premiera.Size = new System.Drawing.Size(84, 15);
            this.premiera.TabIndex = 2;
            this.premiera.Text = "Data premiery:";
            // 
            // aktor
            // 
            this.aktor.AutoSize = true;
            this.aktor.Location = new System.Drawing.Point(431, 89);
            this.aktor.Name = "aktor";
            this.aktor.Size = new System.Drawing.Size(100, 15);
            this.aktor.TabIndex = 3;
            this.aktor.Text = "Główny aktor(ka):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(559, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 23);
            this.textBox3.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(559, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 23);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Dodawanie
            // 
            this.Dodawanie.Location = new System.Drawing.Point(630, 135);
            this.Dodawanie.Name = "Dodawanie";
            this.Dodawanie.Size = new System.Drawing.Size(75, 23);
            this.Dodawanie.TabIndex = 11;
            this.Dodawanie.Text = "Dodaj";
            this.Dodawanie.UseVisualStyleBackColor = true;
            this.Dodawanie.Click += new System.EventHandler(this.Dodawanie_Click);
            // 
            // Zapisywanie
            // 
            this.Zapisywanie.Location = new System.Drawing.Point(559, 384);
            this.Zapisywanie.Name = "Zapisywanie";
            this.Zapisywanie.Size = new System.Drawing.Size(75, 23);
            this.Zapisywanie.TabIndex = 12;
            this.Zapisywanie.Text = "Zapisz";
            this.Zapisywanie.UseVisualStyleBackColor = true;
            this.Zapisywanie.Click += new System.EventHandler(this.Zapisywanie_Click);
            // 
            // Zamykanie
            // 
            this.Zamykanie.Location = new System.Drawing.Point(660, 384);
            this.Zamykanie.Name = "Zamykanie";
            this.Zamykanie.Size = new System.Drawing.Size(75, 23);
            this.Zamykanie.TabIndex = 13;
            this.Zamykanie.Text = "Zamknij";
            this.Zamykanie.UseVisualStyleBackColor = true;
            this.Zamykanie.Click += new System.EventHandler(this.Zamykanie_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumTytul,
            this.ColumnReżyser,
            this.ColumnPremiery,
            this.ColumnAktor});
            this.listView1.Location = new System.Drawing.Point(108, 164);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(627, 202);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumTytul
            // 
            this.ColumTytul.Text = "Tytuł";
            this.ColumTytul.Width = 150;
            // 
            // ColumnReżyser
            // 
            this.ColumnReżyser.Text = "Reżyser";
            this.ColumnReżyser.Width = 150;
            // 
            // ColumnPremiery
            // 
            this.ColumnPremiery.Text = "DataPremiery";
            this.ColumnPremiery.Width = 150;
            // 
            // ColumnAktor
            // 
            this.ColumnAktor.Text = "Aktor";
            this.ColumnAktor.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuń});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 26);
            // 
            // Usuń
            // 
            this.Usuń.Name = "Usuń";
            this.Usuń.Size = new System.Drawing.Size(149, 22);
            this.Usuń.Text = "Usuń wybrane";
            this.Usuń.Click += new System.EventHandler(this.Usuń_Click);
            // 
            // Filmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Zamykanie);
            this.Controls.Add(this.Zapisywanie);
            this.Controls.Add(this.Dodawanie);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.aktor);
            this.Controls.Add(this.premiera);
            this.Controls.Add(this.rezyser);
            this.Controls.Add(this.tytul);
            this.Name = "Filmy";
            this.Text = "Lista filmów";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tytul;
        private Label rezyser;
        private Label premiera;
        private Label aktor;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Button Dodawanie;
        private Button Zapisywanie;
        private Button Zamykanie;
        private ListView listView1;
        private ColumnHeader ColumTytul;
        private ColumnHeader ColumnReżyser;
        private ColumnHeader ColumnPremiery;
        private ColumnHeader ColumnAktor;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem Usuń;
    }
}