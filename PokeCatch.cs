using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf10th
{
    public class PokeCatch
    {
        string name;
        int number;
        int ballType;
        int level;
        bool shinyCharm;

        public static void PokeUT()
        {
            PokeCatch trainer = new PokeCatch("Adir", 143, 3, 45, true);
            Console.WriteLine(trainer);
        }

        public PokeCatch(string name, int number, int ballType, int level, bool shinyCharm)
        {
            this.name = name;
            this.number = number;
            this.ballType = ballType;
            this.level = level;
            this.shinyCharm = shinyCharm;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetNumber(int number)
        {
            if (number >= 1 && number <= 151)
            {
                this.number = number;
            }
        }

        public void SetBallType(int ballType)
        {
            if (ballType >= 1 && ballType <= 4)
            {
                this.ballType = ballType;
            }
        }
        public void SetLevel(int level)
        {
            if (level >= 1 && level <= 100)
            {
                this.level = level;
            }
        }

        public void SetShinyCharm(bool shinyCharm)
        {
            this.shinyCharm = shinyCharm;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetNumber()
        {
            return this.number;
        }

        public int GetBallType()
        {
            return this.ballType;
        }

        public int GetLevel()
        {
            return this.level;
        }

        public bool GetShinyCharm()
        {
            return this.shinyCharm;
        }

        public string PokemonName()
        {
            string pokename = "";
            string[] allNames = {"Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀", "Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew"};
            pokename = allNames[this.number - 1];
            return pokename;
        }

        public double CalculateChance()
        {
            double catchRate = 0;
            int[] allRates = {45, 45, 45, 45, 45, 45, 45, 45, 45, 255, 120, 45, 255, 120, 45, 255, 120, 45, 255, 127, 255, 90, 255, 90, 190, 75, 255, 90, 235, 120, 45, 235, 120, 45, 150, 25, 190, 75, 170, 50, 255, 90, 255, 120, 45, 190, 75, 190, 75, 255, 50, 255, 90, 190, 75, 190, 75, 190, 75, 255, 120, 45, 200, 100, 50, 180, 90, 45, 255, 120, 45, 190, 60, 255, 120, 45, 190, 60, 190, 75, 190, 60, 45, 190, 45, 190, 75, 190, 75, 190, 60, 190, 90, 45, 45, 190, 75, 225, 60, 190, 60, 90, 45, 190, 75, 45, 45, 45, 190, 60, 120, 60, 30, 45, 45, 225, 75, 225, 60, 225, 60, 45, 45, 45, 45, 45, 45, 45, 255, 45, 45, 35, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 25, 3, 3, 3, 45, 45, 45, 3, 45};
            double f = 0;
            double num = 0;
            double chance = 0;
            catchRate = allRates[this.number - 1];
            switch (this.ballType)
            {
                case 1:
                    f = 85;
                    num = 255;
                    break;
                case 2:
                    f = 127.5;
                    num = 200;
                    break;
                case 3:
                    f = 170;
                    num = 150;
                    break;
                case 4:
                    f = 1020;
                    num = 1;
                    break;
            }
            chance = ((catchRate + 1) / (num + 1)) * ((f + 1) / 256);
            if (chance > 1)
            {
                chance = 1;
            }
            return chance;
        }

        public bool CatchOrNoCatch()
        {
            bool conc = false;
            Random rnd = new Random();
            int chance = (int)(this.CalculateChance() * 100000);
            int r = rnd.Next(0, 100001);
            if (r <= chance)
            {
                conc = true;
            }
            else
            {
                conc = false;
            }
            return conc;
        }

        public bool ShinyOrNot()
        {
            Random isShiny = new Random();
            int shChance = 4096;
            int roll;
            if (this.shinyCharm)
            {
                shChance /= 2;
            }
            roll = isShiny.Next(1, shChance + 1);
            return (roll == shChance);
        }

        public override string ToString()
        {
            string finalStr = "";
            string shine = "";
            string[] balls = {"Poke", "Great ", "Ultra ", "Master "};
            string ball = balls[this.ballType - 1];
            string aoan = (this.ballType == 3) ? "an" : "a";
            string pokname = this.PokemonName();
            bool caught = this.CatchOrNoCatch();
            if (this.ShinyOrNot())
            {
                shine = "SHINY ";
            }
            finalStr += $"A wild {shine}{pokname} has appeared! (Lv. {this.level})\n";
            finalStr += $"You threw {aoan} {ball}ball at the wild {pokname}!\n";
            finalStr += "...\n";
            if (caught)
            {
                finalStr += $"Congratulations, {this.name}! You have successfully caught the level {this.level} {shine}{pokname}!!!\n";
            }
            else
            {
                finalStr += $"You have failed to catch the level {this.level} {shine}{pokname}! Better luck next time!";
            }
            return finalStr;
        }
    }
}
