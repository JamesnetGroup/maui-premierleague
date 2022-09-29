using System;
namespace PremierApp.Pages
{
	public class MatchModel
	{
		public TeamModel Home { get; set; }
        public TeamModel Away { get; set; }
		public int HomeScore { get; set; }
        public int AwayScore { get; set; }

        public MatchModel(string home, string away, int homeScore, int awayScore)
		{
			Home = new(home);
            Away = new(away);
			HomeScore = homeScore;
            AwayScore = awayScore;
        }
	}
}

