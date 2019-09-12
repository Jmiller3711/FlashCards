namespace FlashCardsWinForms
{
    partial class FlashCardForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(913, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "No Deck Loaded";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(38, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(425, 257);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(472, 124);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(425, 257);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 71);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deckToolStripMenuItem,
            this.cardActionsToolStripMenuItem,
            this.navigationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(946, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deckToolStripMenuItem
            // 
            this.deckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDeckToolStripMenuItem,
            this.newDeckToolStripMenuItem,
            this.deleteDeckToolStripMenuItem});
            this.deckToolStripMenuItem.Name = "deckToolStripMenuItem";
            this.deckToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.deckToolStripMenuItem.Text = "Deck";
            // 
            // loadDeckToolStripMenuItem
            // 
            this.loadDeckToolStripMenuItem.Name = "loadDeckToolStripMenuItem";
            this.loadDeckToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadDeckToolStripMenuItem.Text = "Load Deck";
            this.loadDeckToolStripMenuItem.Click += new System.EventHandler(this.loadDeckToolStripMenuItem_Click);
            // 
            // newDeckToolStripMenuItem
            // 
            this.newDeckToolStripMenuItem.Name = "newDeckToolStripMenuItem";
            this.newDeckToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newDeckToolStripMenuItem.Text = "New Deck";
            this.newDeckToolStripMenuItem.Click += new System.EventHandler(this.newDeckToolStripMenuItem_Click);
            // 
            // deleteDeckToolStripMenuItem
            // 
            this.deleteDeckToolStripMenuItem.Name = "deleteDeckToolStripMenuItem";
            this.deleteDeckToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deleteDeckToolStripMenuItem.Text = "Delete Deck";
            this.deleteDeckToolStripMenuItem.Click += new System.EventHandler(this.deleteDeckToolStripMenuItem_Click);
            // 
            // cardActionsToolStripMenuItem
            // 
            this.cardActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCardToolStripMenuItem,
            this.editCardToolStripMenuItem,
            this.deleteCardToolStripMenuItem});
            this.cardActionsToolStripMenuItem.Name = "cardActionsToolStripMenuItem";
            this.cardActionsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.cardActionsToolStripMenuItem.Text = "Card";
            // 
            // addCardToolStripMenuItem
            // 
            this.addCardToolStripMenuItem.Name = "addCardToolStripMenuItem";
            this.addCardToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.addCardToolStripMenuItem.Text = "Add Card(s)";
            this.addCardToolStripMenuItem.Click += new System.EventHandler(this.addCardToolStripMenuItem_Click);
            // 
            // editCardToolStripMenuItem
            // 
            this.editCardToolStripMenuItem.Name = "editCardToolStripMenuItem";
            this.editCardToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.editCardToolStripMenuItem.Text = "Edit Card";
            this.editCardToolStripMenuItem.Click += new System.EventHandler(this.editCardToolStripMenuItem_Click);
            // 
            // deleteCardToolStripMenuItem
            // 
            this.deleteCardToolStripMenuItem.Name = "deleteCardToolStripMenuItem";
            this.deleteCardToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.deleteCardToolStripMenuItem.Text = "Delete Card";
            this.deleteCardToolStripMenuItem.Click += new System.EventHandler(this.deleteCardToolStripMenuItem_Click);
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextToolStripMenuItem1,
            this.showToolStripMenuItem1,
            this.backToolStripMenuItem1});
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.navigationToolStripMenuItem.Text = "Navigation";
            // 
            // nextToolStripMenuItem1
            // 
            this.nextToolStripMenuItem1.Name = "nextToolStripMenuItem1";
            this.nextToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.nextToolStripMenuItem1.Text = "Next (Right Arrow Key)";
            this.nextToolStripMenuItem1.Click += new System.EventHandler(this.nextToolStripMenuItem1_Click);
            // 
            // showToolStripMenuItem1
            // 
            this.showToolStripMenuItem1.Name = "showToolStripMenuItem1";
            this.showToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.showToolStripMenuItem1.Text = "Show (Down Arrow Key)";
            this.showToolStripMenuItem1.Click += new System.EventHandler(this.showToolStripMenuItem1_Click);
            // 
            // backToolStripMenuItem1
            // 
            this.backToolStripMenuItem1.Name = "backToolStripMenuItem1";
            this.backToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.backToolStripMenuItem1.Text = "Back (Left Arrow Key)";
            this.backToolStripMenuItem1.Click += new System.EventHandler(this.backToolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "QUESTION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(656, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "ANSWER";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(903, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 257);
            this.button1.TabIndex = 11;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 257);
            this.button2.TabIndex = 12;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(916, 32);
            this.button3.TabIndex = 13;
            this.button3.Text = "SHOW ANSWER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(472, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 264);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // FlashCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 429);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(954, 468);
            this.MinimumSize = new System.Drawing.Size(954, 468);
            this.Name = "FlashCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Cards";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlashCardForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCardToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

