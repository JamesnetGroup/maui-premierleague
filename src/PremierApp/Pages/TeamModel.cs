using System;
namespace PremierApp.Pages
{
	public class TeamModel
    {
        public string Emblem { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Points { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Lose { get; set; }

        public TeamModel(string code)
        {
            Emblem = $"{code.ToLower()}.png";
            Code = code;
        }

        public TeamModel(string code, int win, int draw, int lose, string name, string city)
		{
            Emblem = $"{code}.png";
            Code = code;
            Name = name;
            City = city;
            Points = (win * 3) + draw;
            Win = win;
            Draw = draw;
            Lose = lose;
		}
	}
}

