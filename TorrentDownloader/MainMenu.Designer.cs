namespace TorrentDownloader
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addShowButton = new System.Windows.Forms.Button();
            this.removeShowButton = new System.Windows.Forms.Button();
            this.showsListBox = new System.Windows.Forms.ListBox();
            this.showInfoBox = new System.Windows.Forms.TextBox();
            this.episodesGrid = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Download = new System.Windows.Forms.DataGridViewButtonColumn();
            this.showsLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenu = new System.Windows.Forms.ContextMenu();
            this.terminateMenuItem = new System.Windows.Forms.MenuItem();
            this.episodesLabel = new System.Windows.Forms.Label();
            this.markDownloadedButton = new System.Windows.Forms.Button();
            this.markUndownloadedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.episodesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addShowButton
            // 
            this.addShowButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addShowButton.Location = new System.Drawing.Point(102, 12);
            this.addShowButton.Name = "addShowButton";
            this.addShowButton.Size = new System.Drawing.Size(27, 27);
            this.addShowButton.TabIndex = 1;
            this.addShowButton.Text = "+";
            this.addShowButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addShowButton.UseVisualStyleBackColor = true;
            this.addShowButton.Click += new System.EventHandler(this.addShowButton_Click);
            // 
            // removeShowButton
            // 
            this.removeShowButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeShowButton.Location = new System.Drawing.Point(143, 12);
            this.removeShowButton.Name = "removeShowButton";
            this.removeShowButton.Size = new System.Drawing.Size(27, 27);
            this.removeShowButton.TabIndex = 2;
            this.removeShowButton.Text = "-";
            this.removeShowButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeShowButton.UseVisualStyleBackColor = true;
            this.removeShowButton.Click += new System.EventHandler(this.removeShowButton_Click);
            // 
            // showsListBox
            // 
            this.showsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showsListBox.FormattingEnabled = true;
            this.showsListBox.ItemHeight = 15;
            this.showsListBox.Location = new System.Drawing.Point(12, 48);
            this.showsListBox.Name = "showsListBox";
            this.showsListBox.Size = new System.Drawing.Size(158, 94);
            this.showsListBox.Sorted = true;
            this.showsListBox.TabIndex = 3;
            this.showsListBox.SelectedIndexChanged += new System.EventHandler(this.showsListBox_SelectedIndexChanged);
            // 
            // showInfoBox
            // 
            this.showInfoBox.BackColor = System.Drawing.SystemColors.Control;
            this.showInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInfoBox.Location = new System.Drawing.Point(188, 17);
            this.showInfoBox.Multiline = true;
            this.showInfoBox.Name = "showInfoBox";
            this.showInfoBox.Size = new System.Drawing.Size(388, 125);
            this.showInfoBox.TabIndex = 4;
            this.showInfoBox.Text = "Show: \r\n\r\nGenre:\r\n\r\nEpisodes:\r\n\r\nLink:";
            // 
            // episodesGrid
            // 
            this.episodesGrid.AllowUserToAddRows = false;
            this.episodesGrid.AllowUserToDeleteRows = false;
            this.episodesGrid.AllowUserToResizeRows = false;
            this.episodesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.episodesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.episodesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Title,
            this.Download});
            this.episodesGrid.Location = new System.Drawing.Point(12, 196);
            this.episodesGrid.Name = "episodesGrid";
            this.episodesGrid.ReadOnly = true;
            this.episodesGrid.RowHeadersVisible = false;
            this.episodesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.episodesGrid.Size = new System.Drawing.Size(564, 232);
            this.episodesGrid.TabIndex = 5;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Download
            // 
            this.Download.HeaderText = "Download";
            this.Download.Name = "Download";
            this.Download.ReadOnly = true;
            // 
            // showsLabel
            // 
            this.showsLabel.AutoSize = true;
            this.showsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showsLabel.Location = new System.Drawing.Point(21, 16);
            this.showsLabel.Name = "showsLabel";
            this.showsLabel.Size = new System.Drawing.Size(62, 20);
            this.showsLabel.TabIndex = 6;
            this.showsLabel.Text = "Shows";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "TorrentDownloader";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.terminateMenuItem});
            // 
            // terminateMenuItem
            // 
            this.terminateMenuItem.Index = 0;
            this.terminateMenuItem.Text = "Terminate  :(";
            this.terminateMenuItem.Click += new System.EventHandler(this.terminateMenuItem_Click);
            // 
            // episodesLabel
            // 
            this.episodesLabel.AutoSize = true;
            this.episodesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodesLabel.Location = new System.Drawing.Point(21, 162);
            this.episodesLabel.Name = "episodesLabel";
            this.episodesLabel.Size = new System.Drawing.Size(83, 20);
            this.episodesLabel.TabIndex = 7;
            this.episodesLabel.Text = "Episodes";
            // 
            // markDownloadedButton
            // 
            this.markDownloadedButton.Location = new System.Drawing.Point(124, 159);
            this.markDownloadedButton.Name = "markDownloadedButton";
            this.markDownloadedButton.Size = new System.Drawing.Size(119, 27);
            this.markDownloadedButton.TabIndex = 8;
            this.markDownloadedButton.Text = "Mark as downloaded";
            this.markDownloadedButton.UseVisualStyleBackColor = true;
            this.markDownloadedButton.Click += new System.EventHandler(this.markDownloadedButton_Click);
            // 
            // markUndownloadedButton
            // 
            this.markUndownloadedButton.Location = new System.Drawing.Point(261, 159);
            this.markUndownloadedButton.Name = "markUndownloadedButton";
            this.markUndownloadedButton.Size = new System.Drawing.Size(142, 27);
            this.markUndownloadedButton.TabIndex = 9;
            this.markUndownloadedButton.Text = "Mark as not downloaded";
            this.markUndownloadedButton.UseVisualStyleBackColor = true;
            this.markUndownloadedButton.Click += new System.EventHandler(this.markUndownloadedButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 440);
            this.Controls.Add(this.markUndownloadedButton);
            this.Controls.Add(this.markDownloadedButton);
            this.Controls.Add(this.episodesLabel);
            this.Controls.Add(this.showsLabel);
            this.Controls.Add(this.episodesGrid);
            this.Controls.Add(this.showInfoBox);
            this.Controls.Add(this.showsListBox);
            this.Controls.Add(this.removeShowButton);
            this.Controls.Add(this.addShowButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Torrent Downloader - Jamie Holdstock";
            ((System.ComponentModel.ISupportInitialize)(this.episodesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addShowButton;
        private System.Windows.Forms.Button removeShowButton;
        private System.Windows.Forms.ListBox showsListBox;
        private System.Windows.Forms.TextBox showInfoBox;
        private System.Windows.Forms.DataGridView episodesGrid;
        private System.Windows.Forms.Label showsLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenu notifyIconMenu;
        private System.Windows.Forms.MenuItem terminateMenuItem;
        private System.Windows.Forms.Label episodesLabel;
        private System.Windows.Forms.Button markDownloadedButton;
        private System.Windows.Forms.Button markUndownloadedButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewButtonColumn Download;
    }
}

