using System;
namespace PremierApp.Pages
{
	public class ResultsViewModel
	{
		public List<MatchModel> Matches { get; init; }

		public ResultsViewModel()
		{
			Matches = GetMatches();
		}

		private List<MatchModel> GetMatches()
		{
			List<MatchModel> matches = new();
            matches.Add(new("TOT", "CHE", 2, 2));
            matches.Add(new("MCN", "LIV", 2, 1));
            matches.Add(new("MCI", "NWC", 3, 3));
            matches.Add(new("ARS", "LEI", 4, 2));
            matches.Add(new("NWC", "NFO", 4, 2));
            return matches;
		}
	}
}

