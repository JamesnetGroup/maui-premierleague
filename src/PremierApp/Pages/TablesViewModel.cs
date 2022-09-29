using System;
namespace PremierApp.Pages
{
	public class TablesViewModel
	{
		public List<TeamModel> Teams { get; init; }

		public TablesViewModel()
		{
			Teams = GetTeams();
		}

		private List<TeamModel> GetTeams()
		{
			List<TeamModel> teams = new();
			teams.Add(new("ars", 5, 0, 1, "Arsnal", "London"));
			teams.Add(new("mci", 4, 2, 0, "Man City", "Manchester"));
            teams.Add(new("tot", 4, 2, 0, "Tottenham", "London"));
            teams.Add(new("bri", 4, 1, 1, "Brighton", "East Sussex"));
            teams.Add(new("mcn", 4, 0, 2, "Man United", "Manchester"));
            teams.Add(new("che", 3, 1, 2, "Chelsea", "London"));
            teams.Add(new("liv", 2, 3, 1, "Liverpool", "Liverpool"));
            teams.Add(new("bre", 2, 3, 1, "BrentFord", "London"));
            teams.Add(new("lee", 2, 3, 1, "Leeds United", "West Yorkshire"));
            teams.Add(new("ful", 2, 2, 2, "Fullham", "London"));
            teams.Add(new("nwc", 1, 4, 1, "NewCastle United", "Tyne and Wear"));
            teams.Add(new("sou", 2, 1, 3, "Southampton", "Hampshire"));
            teams.Add(new("bou", 2, 1, 3, "Bournemouth", "Dorset"));
            teams.Add(new("wol", 1, 3, 2, "Wolves", "Dorset"));
            teams.Add(new("cry", 1, 3, 2, "Crystal Palace", "Dorset"));
            teams.Add(new("eve", 0, 4, 2, "Everton", "Dorset"));
            teams.Add(new("avl", 1, 1, 4, "Aston Villa", "Dorset"));
            teams.Add(new("whu", 1, 1, 4, "West Ham", "Dorset"));
            teams.Add(new("nfo", 1, 1, 4, "Nott'm Forest", "Dorset"));
            teams.Add(new("lei", 0, 1, 5, "Leicester", "Dorset"));
            return teams;
		}
	}
}

