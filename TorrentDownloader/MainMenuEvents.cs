using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using DatabaseAccess;

namespace TorrentDownloader
{
    public partial class MainMenu
    {
        void episodesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2 | e.RowIndex < 0)
            {
                return;
            }

            int rowIndex = e.RowIndex;
            Episode episode = (Episode)episodesGrid.Rows[rowIndex].Tag;
            if (episode.Downloaded == true)
            {
                return;
            }
            string clientPath = @"C:\Program Files (x86)\Deluge\deluge.exe";
            string torrentUrl = episode.torrentFileHD;
            System.Diagnostics.Process.Start(clientPath, torrentUrl);
            td.markEpisodesDownloaded(new List<Episode>(){episode});
            updateEpisodesList(episode.Show);
        }

        private void addShowButton_Click(object sender, EventArgs e)
        {
            string showName = Interaction.InputBox("Enter the show to add", "New show");
            if (string.IsNullOrEmpty(showName) == false)
            {
                td.addShow(showName);
            }
            refreshShowsList();
        }

        private void removeShowButton_Click(object sender, EventArgs e)
        {
            if (showsListBox.SelectedItems.Count != 1)
            {
                return;
            }

            Show show = (Show)showsListBox.SelectedItem;
            if (DialogResult.Yes == MessageBox.Show("Are you sure you wish to delete " + show + "?", ":o", MessageBoxButtons.YesNo))
            {
                td.removeShow(show);
                refreshShowsList();
            }
        }

        private void showsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showsListBox.SelectedItems.Count != 1)
            {
                showInfoBox.Text = "";
                return;
            }

            Show show = (Show)showsListBox.SelectedItem;
            updateShowInfo(show);
            updateEpisodesList(show);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void mainMenu_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
            }
        }

        private void mainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void markDownloadedButton_Click(object sender, EventArgs e)
        {
            if (episodesGrid.SelectedRows.Count == 0)
            {
                return;
            }
            List<Episode> eps = new List<Episode>();
            foreach (DataGridViewRow row in episodesGrid.SelectedRows)
            {
                eps.Add((Episode) row.Tag);
                td.markEpisodesDownloaded(eps);
            }
            updateEpisodesList(eps[0].Show);
        }

        private void terminateMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void markUndownloadedButton_Click(object sender, EventArgs e)
        {
            if (episodesGrid.SelectedRows.Count == 0)
            {
                return;
            }
            List<Episode> eps = new List<Episode>();
            foreach (DataGridViewRow row in episodesGrid.SelectedRows)
            {
                eps.Add((Episode)row.Tag);
                td.markEpisodesUndownloaded(eps);
            }
            updateEpisodesList(eps[0].Show);
        }
    }
}
