using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() {"God Of War", "Ark: Survival Evolved", "Assasins Creed", "Red Dead Redemption" };
            videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
