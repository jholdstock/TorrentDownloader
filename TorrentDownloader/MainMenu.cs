using System;
using System.Linq;
using System.Windows.Forms;
using DatabaseAccess;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;

namespace TorrentDownloader
{
    public partial class MainMenu : Form
    {
        TorrentData td;

        public MainMenu()
        {
            InitializeComponent();
            td = new TorrentData();
            getNewEpisodes();
            refreshShowsList();
            episodesGrid.CellClick += new DataGridViewCellEventHandler(episodesGrid_CellClick);
            this.Resize +=new EventHandler(mainMenu_Resize);
            this.FormClosing +=new FormClosingEventHandler(mainMenu_FormClosing);
            notifyIcon.ContextMenu = notifyIconMenu;
            
        }

        private void getNewEpisodes()
        {
            List<Episode> newEpisodes = td.getLatestEpisodes();

            if (newEpisodes.Count > 0)
            {
                string message = newEpisodes.Count + " shows have new episodes!";
                message += Environment.NewLine + Environment.NewLine;
                foreach (Episode e in newEpisodes)
                {
                    message += e.Show + " - " + e.num + Environment.NewLine;
                }
                MessageBox.Show(message);
            }
        }
  
        private void refreshShowsList()
        {
            showInfoBox.Text = "";
            showsListBox.Items.Clear();
            foreach (Show show in td.getShows())
            {
                showsListBox.Items.Add(show);
            }
        }
 
        private void updateEpisodesList(Show show)
        {
            episodesGrid.Rows.Clear();
            foreach (Episode e in show.Episodes)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(episodesGrid,e.num, e.title);
                if (e.Downloaded == true)
                {
                    DataGridViewTextBoxCell textCell = new DataGridViewTextBoxCell();
                    textCell.Value = "Already downloaded";
                    row.Cells[2] = textCell;
                }
                else
                {
                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)row.Cells[2];
                    buttonCell.Value = "Download";
                }
                row.Tag = e;
                episodesGrid.Rows.Add(row);
            }
            DataGridViewColumn col = episodesGrid.Columns[0];
            episodesGrid.Sort(col, ListSortDirection.Descending);
            col.HeaderCell.SortGlyphDirection = SortOrder.Descending;
        }

        private void updateShowInfo(Show show)
        {
            string labelText = "";
            labelText += "Show: " + show.prettyName;
            labelText += Environment.NewLine + Environment.NewLine;
            labelText += "Genre: " + show.genre;
            labelText += Environment.NewLine + Environment.NewLine;
            labelText += "Episodes: " + show.Episodes.Count();
            labelText += Environment.NewLine + Environment.NewLine;
            labelText += "Link: " + show.link;

            showInfoBox.Text = labelText;
        }
    }
}
