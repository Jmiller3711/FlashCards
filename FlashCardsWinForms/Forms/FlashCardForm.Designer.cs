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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(37, 95);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(425, 257);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deckToolStripMenuItem,
            this.cardActionsToolStripMenuItem,
            this.navigationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(37, 31);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(946, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(174, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deckToolStripMenuItem
            // 
            this.deckToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.deckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDeckToolStripMenuItem,
            this.newDeckToolStripMenuItem,
            this.deleteDeckToolStripMenuItem});
            this.deckToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deckToolStripMenuItem.Name = "deckToolStripMenuItem";
            this.deckToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.deckToolStripMenuItem.Text = "Deck";
            // 
            // loadDeckToolStripMenuItem
            // 
            this.loadDeckToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.loadDeckToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loadDeckToolStripMenuItem.Name = "loadDeckToolStripMenuItem";
            this.loadDeckToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadDeckToolStripMenuItem.Text = "Load Deck";
            this.loadDeckToolStripMenuItem.Click += new System.EventHandler(this.loadDeckToolStripMenuItem_Click);
            // 
            // newDeckToolStripMenuItem
            // 
            this.newDeckToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.newDeckToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newDeckToolStripMenuItem.Name = "newDeckToolStripMenuItem";
            this.newDeckToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newDeckToolStripMenuItem.Text = "New Deck";
            this.newDeckToolStripMenuItem.Click += new System.EventHandler(this.newDeckToolStripMenuItem_Click);
            // 
            // deleteDeckToolStripMenuItem
            // 
            this.deleteDeckToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.deleteDeckToolStripMenuItem.ForeColor = System.Drawing.Color.White;
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
            this.cardActionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cardActionsToolStripMenuItem.Name = "cardActionsToolStripMenuItem";
            this.cardActionsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.cardActionsToolStripMenuItem.Text = "Card";
            // 
            // addCardToolStripMenuItem
            // 
            this.addCardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.addCardToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addCardToolStripMenuItem.Name = "addCardToolStripMenuItem";
            this.addCardToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.addCardToolStripMenuItem.Text = "Add Card(s)";
            this.addCardToolStripMenuItem.Click += new System.EventHandler(this.addCardToolStripMenuItem_Click);
            // 
            // editCardToolStripMenuItem
            // 
            this.editCardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.editCardToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editCardToolStripMenuItem.Name = "editCardToolStripMenuItem";
            this.editCardToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.editCardToolStripMenuItem.Text = "Edit Card";
            this.editCardToolStripMenuItem.Click += new System.EventHandler(this.editCardToolStripMenuItem_Click);
            // 
            // deleteCardToolStripMenuItem
            // 
            this.deleteCardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.deleteCardToolStripMenuItem.ForeColor = System.Drawing.Color.White;
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
            this.navigationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.navigationToolStripMenuItem.Text = "Navigation";
            // 
            // nextToolStripMenuItem1
            // 
            this.nextToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.nextToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.nextToolStripMenuItem1.Name = "nextToolStripMenuItem1";
            this.nextToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.nextToolStripMenuItem1.Text = "Next (Right Arrow Key)";
            this.nextToolStripMenuItem1.Click += new System.EventHandler(this.nextToolStripMenuItem1_Click);
            // 
            // showToolStripMenuItem1
            // 
            this.showToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.showToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.showToolStripMenuItem1.Name = "showToolStripMenuItem1";
            this.showToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.showToolStripMenuItem1.Text = "Show (Down Arrow Key)";
            this.showToolStripMenuItem1.Click += new System.EventHandler(this.showToolStripMenuItem1_Click);
            // 
            // backToolStripMenuItem1
            // 
            this.backToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.backToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.backToolStripMenuItem1.Name = "backToolStripMenuItem1";
            this.backToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.backToolStripMenuItem1.Text = "Back (Left Arrow Key)";
            this.backToolStripMenuItem1.Click += new System.EventHandler(this.backToolStripMenuItem1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(468, 95);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(425, 257);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(202, 72);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Question";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(895, 205);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(28, 36);
            this.materialRaisedButton1.TabIndex = 16;
            this.materialRaisedButton1.Text = ">";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(7, 205);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(28, 36);
            this.materialRaisedButton2.TabIndex = 17;
            this.materialRaisedButton2.Text = "<";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(405, 358);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(120, 36);
            this.materialRaisedButton3.TabIndex = 18;
            this.materialRaisedButton3.Text = "Show Answer";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(649, 72);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(59, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Answer";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(468, 95);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(425, 257);
            this.materialDivider1.TabIndex = 21;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(742, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Deck: No Deck Loaded";
            // 
            // FlashCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(931, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FlashCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                  Flash Cards";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlashCardForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cardActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDeckToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Label label1;
    }
}

