namespace QLW
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnW1 = new System.Windows.Forms.Button();
            this.cmW1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editPageW1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editImageW1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newImageW1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetImageW1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameW1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnW2 = new System.Windows.Forms.Button();
            this.cmW2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editPageW2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editImageW2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newImageW2 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetImageW2 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameW2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnW3 = new System.Windows.Forms.Button();
            this.cmW3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editPageW3 = new System.Windows.Forms.ToolStripMenuItem();
            this.editImageW3 = new System.Windows.Forms.ToolStripMenuItem();
            this.newImageW3 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetImageW3 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameW3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnW4 = new System.Windows.Forms.Button();
            this.cmW4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editPageW4 = new System.Windows.Forms.ToolStripMenuItem();
            this.editImageW4 = new System.Windows.Forms.ToolStripMenuItem();
            this.newImageW4 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetImageW4 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameW4 = new System.Windows.Forms.ToolStripMenuItem();
            this.name_W1 = new System.Windows.Forms.Label();
            this.name_W2 = new System.Windows.Forms.Label();
            this.name_W3 = new System.Windows.Forms.Label();
            this.name_W4 = new System.Windows.Forms.Label();
            this.cmW1.SuspendLayout();
            this.cmW2.SuspendLayout();
            this.cmW3.SuspendLayout();
            this.cmW4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnW1
            // 
            this.btnW1.ContextMenuStrip = this.cmW1;
            this.btnW1.FlatAppearance.BorderSize = 0;
            this.btnW1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnW1.Image = global::QLW.Properties.Resources.widget1;
            this.btnW1.Location = new System.Drawing.Point(16, 10);
            this.btnW1.Name = "btnW1";
            this.btnW1.Size = new System.Drawing.Size(50, 50);
            this.btnW1.TabIndex = 0;
            this.btnW1.Tag = "1";
            this.btnW1.UseVisualStyleBackColor = true;
            this.btnW1.Click += new System.EventHandler(this.OnClickWidget);
            // 
            // cmW1
            // 
            this.cmW1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPageW1,
            this.editImageW1,
            this.renameW1});
            this.cmW1.Name = "cmW1";
            this.cmW1.Size = new System.Drawing.Size(131, 70);
            // 
            // editPageW1
            // 
            this.editPageW1.Name = "editPageW1";
            this.editPageW1.Size = new System.Drawing.Size(130, 22);
            this.editPageW1.Text = "Edit Page";
            this.editPageW1.Click += new System.EventHandler(this.editPage_W1);
            // 
            // editImageW1
            // 
            this.editImageW1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newImageW1,
            this.resetImageW1});
            this.editImageW1.Name = "editImageW1";
            this.editImageW1.Size = new System.Drawing.Size(130, 22);
            this.editImageW1.Text = "Edit Image";
            // 
            // newImageW1
            // 
            this.newImageW1.Name = "newImageW1";
            this.newImageW1.Size = new System.Drawing.Size(138, 22);
            this.newImageW1.Text = "New Image";
            this.newImageW1.Click += new System.EventHandler(this.newImage_W1);
            // 
            // resetImageW1
            // 
            this.resetImageW1.Name = "resetImageW1";
            this.resetImageW1.Size = new System.Drawing.Size(138, 22);
            this.resetImageW1.Text = "Reset Image";
            this.resetImageW1.Click += new System.EventHandler(this.resetImage_W1);
            // 
            // renameW1
            // 
            this.renameW1.Name = "renameW1";
            this.renameW1.Size = new System.Drawing.Size(130, 22);
            this.renameW1.Text = "Rename";
            this.renameW1.Click += new System.EventHandler(this.rename_W1);
            // 
            // btnW2
            // 
            this.btnW2.ContextMenuStrip = this.cmW2;
            this.btnW2.FlatAppearance.BorderSize = 0;
            this.btnW2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnW2.Image = global::QLW.Properties.Resources.widget2;
            this.btnW2.Location = new System.Drawing.Point(77, 16);
            this.btnW2.Name = "btnW2";
            this.btnW2.Size = new System.Drawing.Size(50, 50);
            this.btnW2.TabIndex = 1;
            this.btnW2.Tag = "2";
            this.btnW2.UseVisualStyleBackColor = true;
            this.btnW2.Click += new System.EventHandler(this.OnClickWidget);
            // 
            // cmW2
            // 
            this.cmW2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPageW2,
            this.editImageW2,
            this.renameW2});
            this.cmW2.Name = "cmW2";
            this.cmW2.Size = new System.Drawing.Size(131, 70);
            // 
            // editPageW2
            // 
            this.editPageW2.Name = "editPageW2";
            this.editPageW2.Size = new System.Drawing.Size(130, 22);
            this.editPageW2.Text = "Edit Page";
            this.editPageW2.Click += new System.EventHandler(this.editPage_W2);
            // 
            // editImageW2
            // 
            this.editImageW2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newImageW2,
            this.resetImageW2});
            this.editImageW2.Name = "editImageW2";
            this.editImageW2.Size = new System.Drawing.Size(130, 22);
            this.editImageW2.Text = "Edit Image";
            // 
            // newImageW2
            // 
            this.newImageW2.Name = "newImageW2";
            this.newImageW2.Size = new System.Drawing.Size(138, 22);
            this.newImageW2.Text = "New Image";
            this.newImageW2.Click += new System.EventHandler(this.newImage_W2);
            // 
            // resetImageW2
            // 
            this.resetImageW2.Name = "resetImageW2";
            this.resetImageW2.Size = new System.Drawing.Size(138, 22);
            this.resetImageW2.Text = "Reset Image";
            this.resetImageW2.Click += new System.EventHandler(this.resetImage_W2);
            // 
            // renameW2
            // 
            this.renameW2.Name = "renameW2";
            this.renameW2.Size = new System.Drawing.Size(130, 22);
            this.renameW2.Text = "Rename";
            this.renameW2.Click += new System.EventHandler(this.rename_W2);
            // 
            // btnW3
            // 
            this.btnW3.ContextMenuStrip = this.cmW3;
            this.btnW3.FlatAppearance.BorderSize = 0;
            this.btnW3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnW3.Image = global::QLW.Properties.Resources.widget3;
            this.btnW3.Location = new System.Drawing.Point(166, 16);
            this.btnW3.Name = "btnW3";
            this.btnW3.Size = new System.Drawing.Size(50, 50);
            this.btnW3.TabIndex = 2;
            this.btnW3.Tag = "3";
            this.btnW3.UseVisualStyleBackColor = true;
            this.btnW3.Click += new System.EventHandler(this.OnClickWidget);
            // 
            // cmW3
            // 
            this.cmW3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPageW3,
            this.editImageW3,
            this.renameW3});
            this.cmW3.Name = "cmW3";
            this.cmW3.Size = new System.Drawing.Size(131, 70);
            // 
            // editPageW3
            // 
            this.editPageW3.Name = "editPageW3";
            this.editPageW3.Size = new System.Drawing.Size(130, 22);
            this.editPageW3.Text = "Edit Page";
            this.editPageW3.Click += new System.EventHandler(this.editPage_W3);
            // 
            // editImageW3
            // 
            this.editImageW3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newImageW3,
            this.resetImageW3});
            this.editImageW3.Name = "editImageW3";
            this.editImageW3.Size = new System.Drawing.Size(130, 22);
            this.editImageW3.Text = "Edit Image";
            // 
            // newImageW3
            // 
            this.newImageW3.Name = "newImageW3";
            this.newImageW3.Size = new System.Drawing.Size(138, 22);
            this.newImageW3.Text = "New Image";
            this.newImageW3.Click += new System.EventHandler(this.newImage_W3);
            // 
            // resetImageW3
            // 
            this.resetImageW3.Name = "resetImageW3";
            this.resetImageW3.Size = new System.Drawing.Size(138, 22);
            this.resetImageW3.Text = "Reset Image";
            this.resetImageW3.Click += new System.EventHandler(this.resetImage_W3);
            // 
            // renameW3
            // 
            this.renameW3.Name = "renameW3";
            this.renameW3.Size = new System.Drawing.Size(130, 22);
            this.renameW3.Text = "Rename";
            this.renameW3.Click += new System.EventHandler(this.rename_W3);
            // 
            // btnW4
            // 
            this.btnW4.ContextMenuStrip = this.cmW4;
            this.btnW4.FlatAppearance.BorderSize = 0;
            this.btnW4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnW4.Image = global::QLW.Properties.Resources.widget4;
            this.btnW4.Location = new System.Drawing.Point(225, 10);
            this.btnW4.Name = "btnW4";
            this.btnW4.Size = new System.Drawing.Size(50, 50);
            this.btnW4.TabIndex = 3;
            this.btnW4.Tag = "4";
            this.btnW4.UseVisualStyleBackColor = true;
            this.btnW4.Click += new System.EventHandler(this.OnClickWidget);
            // 
            // cmW4
            // 
            this.cmW4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPageW4,
            this.editImageW4,
            this.renameW4});
            this.cmW4.Name = "cmW4";
            this.cmW4.Size = new System.Drawing.Size(131, 70);
            // 
            // editPageW4
            // 
            this.editPageW4.Name = "editPageW4";
            this.editPageW4.Size = new System.Drawing.Size(130, 22);
            this.editPageW4.Text = "Edit Page";
            this.editPageW4.Click += new System.EventHandler(this.editPage_W4);
            // 
            // editImageW4
            // 
            this.editImageW4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newImageW4,
            this.resetImageW4});
            this.editImageW4.Name = "editImageW4";
            this.editImageW4.Size = new System.Drawing.Size(130, 22);
            this.editImageW4.Text = "Edit Image";
            // 
            // newImageW4
            // 
            this.newImageW4.Name = "newImageW4";
            this.newImageW4.Size = new System.Drawing.Size(138, 22);
            this.newImageW4.Text = "New Image";
            this.newImageW4.Click += new System.EventHandler(this.newImage_W4);
            // 
            // resetImageW4
            // 
            this.resetImageW4.Name = "resetImageW4";
            this.resetImageW4.Size = new System.Drawing.Size(138, 22);
            this.resetImageW4.Text = "Reset Image";
            this.resetImageW4.Click += new System.EventHandler(this.resetImage_W4);
            // 
            // renameW4
            // 
            this.renameW4.Name = "renameW4";
            this.renameW4.Size = new System.Drawing.Size(130, 22);
            this.renameW4.Text = "Rename";
            this.renameW4.Click += new System.EventHandler(this.rename_W4);
            // 
            // name_W1
            // 
            this.name_W1.BackColor = System.Drawing.Color.Transparent;
            this.name_W1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_W1.ForeColor = System.Drawing.SystemColors.Control;
            this.name_W1.Location = new System.Drawing.Point(16, 63);
            this.name_W1.Name = "name_W1";
            this.name_W1.Size = new System.Drawing.Size(50, 43);
            this.name_W1.TabIndex = 4;
            this.name_W1.Text = "Widget 1";
            this.name_W1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_W2
            // 
            this.name_W2.BackColor = System.Drawing.Color.Transparent;
            this.name_W2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_W2.ForeColor = System.Drawing.SystemColors.Control;
            this.name_W2.Location = new System.Drawing.Point(77, 65);
            this.name_W2.Name = "name_W2";
            this.name_W2.Size = new System.Drawing.Size(50, 41);
            this.name_W2.TabIndex = 5;
            this.name_W2.Text = "Widget 2";
            this.name_W2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_W3
            // 
            this.name_W3.BackColor = System.Drawing.Color.Transparent;
            this.name_W3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_W3.ForeColor = System.Drawing.SystemColors.Control;
            this.name_W3.Location = new System.Drawing.Point(166, 65);
            this.name_W3.Name = "name_W3";
            this.name_W3.Size = new System.Drawing.Size(50, 41);
            this.name_W3.TabIndex = 6;
            this.name_W3.Text = "Widget 3";
            this.name_W3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_W4
            // 
            this.name_W4.BackColor = System.Drawing.Color.Transparent;
            this.name_W4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_W4.ForeColor = System.Drawing.SystemColors.Control;
            this.name_W4.Location = new System.Drawing.Point(225, 63);
            this.name_W4.Name = "name_W4";
            this.name_W4.Size = new System.Drawing.Size(50, 43);
            this.name_W4.TabIndex = 7;
            this.name_W4.Text = "Widget 4";
            this.name_W4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLW.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(292, 106);
            this.Controls.Add(this.name_W4);
            this.Controls.Add(this.name_W3);
            this.Controls.Add(this.name_W2);
            this.Controls.Add(this.name_W1);
            this.Controls.Add(this.btnW4);
            this.Controls.Add(this.btnW3);
            this.Controls.Add(this.btnW2);
            this.Controls.Add(this.btnW1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "QWL";
            this.Load += new System.EventHandler(this.LoadFrame);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.cmW1.ResumeLayout(false);
            this.cmW2.ResumeLayout(false);
            this.cmW3.ResumeLayout(false);
            this.cmW4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnW1;
        private System.Windows.Forms.Button btnW2;
        private System.Windows.Forms.Button btnW3;
        private System.Windows.Forms.Button btnW4;
        private System.Windows.Forms.ContextMenuStrip cmW1;
        private System.Windows.Forms.ToolStripMenuItem editPageW1;
        private System.Windows.Forms.ToolStripMenuItem editImageW1;
        private System.Windows.Forms.ToolStripMenuItem newImageW1;
        private System.Windows.Forms.ToolStripMenuItem resetImageW1;
        private System.Windows.Forms.ToolStripMenuItem renameW1;
        private System.Windows.Forms.Label name_W1;
        private System.Windows.Forms.Label name_W2;
        private System.Windows.Forms.Label name_W3;
        private System.Windows.Forms.Label name_W4;
        private System.Windows.Forms.ContextMenuStrip cmW2;
        private System.Windows.Forms.ToolStripMenuItem editPageW2;
        private System.Windows.Forms.ToolStripMenuItem editImageW2;
        private System.Windows.Forms.ToolStripMenuItem newImageW2;
        private System.Windows.Forms.ToolStripMenuItem resetImageW2;
        private System.Windows.Forms.ToolStripMenuItem renameW2;
        private System.Windows.Forms.ContextMenuStrip cmW3;
        private System.Windows.Forms.ToolStripMenuItem editPageW3;
        private System.Windows.Forms.ToolStripMenuItem editImageW3;
        private System.Windows.Forms.ToolStripMenuItem newImageW3;
        private System.Windows.Forms.ToolStripMenuItem resetImageW3;
        private System.Windows.Forms.ToolStripMenuItem renameW3;
        private System.Windows.Forms.ContextMenuStrip cmW4;
        private System.Windows.Forms.ToolStripMenuItem editPageW4;
        private System.Windows.Forms.ToolStripMenuItem editImageW4;
        private System.Windows.Forms.ToolStripMenuItem newImageW4;
        private System.Windows.Forms.ToolStripMenuItem resetImageW4;
        private System.Windows.Forms.ToolStripMenuItem renameW4;
    }
}

