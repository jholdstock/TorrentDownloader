using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseAccess;
using DTTServiceAccess;
using System.Data.Objects;
using System.Windows.Forms;

namespace TorrentDownloader
{
    public class TorrentData
    {
        private DTTServiceClient client;
        private TorrentDownloaderEntities dal;

        public TorrentData()
        {
            client = new DTTServiceClient();
            makeNewDal();
        }

        public List<Show> getShows()
        {
            return dal.Shows.ToList();
        }

        public void markEpisodesDownloaded(List<Episode> episodes)
        {
            foreach (Episode e in episodes)
            {
                e.Downloaded = true;
            }
            saveChanges();
        }

        public void markEpisodesUndownloaded(List<Episode> episodes)
        {
            foreach (Episode e in episodes)
            {
                e.Downloaded = false;
            }
            saveChanges();
        }

        private void makeNewDal()
        {
            dal = new TorrentDownloaderEntities();
        }

        public ObjectSet<Episode> getShowEpisodes(Show show)
        {
            return dal.Episodes;
        }
        
        public List<Episode> getLatestEpisodes()
        {
            List<Episode> newEpisodes = new List<Episode>();
            foreach (Show show in dal.Shows)
            {
                Episode latestEpisode = client.EpisodeGetLatest(show.name);
                bool alreadyGot = false;
                foreach (Episode e in show.Episodes)
                {
                    if (e.num == latestEpisode.num)
                        alreadyGot = true;
                }
                if (!alreadyGot)
                {
                    latestEpisode.Show = show;
                    newEpisodes.Add(latestEpisode);
                }
            }
            foreach (Episode ep in newEpisodes)
            {
                dal.AddToEpisodes(ep);
            }
            saveChanges();

            return newEpisodes;
        }

        private List<Episode> downloadAllEpisodesOfShow(Show show)
        {
            int totalPages;
            int totalEpisodes;
            List<Episode> eps = client.ShowGetEpisodesFirstPage(show.name, out totalPages, out totalEpisodes);
            
            for (int i = 1; i < totalPages; i++)
            {
                eps.AddRange(client.ShowGetEpisodesExtraPage(show.name, i));
            }

            return eps;
        }

        public void addShow(string showName)
        {
            showName = showName.Replace(' ', '-');
            
            Show show = client.ShowGetInfo(showName);
            if (show.name == null)
            {
                MessageBox.Show("Could not find a show with that name", ":(", MessageBoxButtons.OK);
                return;
            }

            foreach(Show s in dal.Shows)
            {
                if (s.name == show.name)
                {
                    MessageBox.Show("This show is already in the list", ":(", MessageBoxButtons.OK);
                    return;
                }
            }

            List<Episode> eps = downloadAllEpisodesOfShow(show);

            if (eps.Count() == 0)
            {
                MessageBox.Show("No episodes for this show");
                return;
            }

            dal.AddToShows(show);

            foreach (Episode e in eps)
            {
                e.Show = show;
                dal.AddToEpisodes(e);
            }

            saveChanges();
        }

        public void removeShow(Show show)
        {
            dal.DeleteObject(show);
            saveChanges();
        }

        private void saveChanges()
        {
            dal.SaveChanges();
            makeNewDal();
        }
    }
}
