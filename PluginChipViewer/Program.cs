using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PluginChipViewer.APP_CODE;

namespace PluginChipViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            ChipArray chipArray = new ChipArray();

            Console.WriteLine("\nEnter the type of chips you want to view: ");
            Console.Write("1. System Chips \n2. Attack Chips\n");
            
            
            string choice = Console.ReadLine();
            bool result = int.TryParse(choice, out int userChoice);
            if (result)
            {
                switch (userChoice)
                {
                    case 1:
                        List<string> systemChips = CreateList("SystemChips.txt");
                        chipArray.Chips = ChipArray.SystemData(systemChips);
                        ChipArray.DisplayChips(chipArray.Chips);
                        currentChipsDisplay(chipArray);                        
                        break;
                    case 2:
                        break;
                    default:
                        break;

                }
            }
            else
            {
                Console.WriteLine("Sorry that is not in correct format.");
                Console.ReadLine();
            }
            Console.WriteLine("Thank You for using!:  ");
            Console.ReadLine();
        }

        protected static void currentChipsDisplay(ChipArray chipArray)
        {
            bool moreChip = true;
            do
            {
                Console.WriteLine("Which chip do you want to view:  \n>>>");
                int chipChoice = int.Parse(Console.ReadLine());
                ChipArray.ChipInfo(chipArray.Chips, chipChoice);

                Console.WriteLine("\n want to Choose another chip? Y/N: ");
                string userChoice = Console.ReadLine();

                if (userChoice.ToUpper() == "Y")
                {
                    ChipArray.DisplayChips(chipArray.Chips);
                    moreChip = true;
                }
                else
                {
                    moreChip = false;
                }
            } while (moreChip);
        }

        protected static List<string> CreateList(string fileToOpen)
        {
            List<string> ChipsList = null;

            var path = "C:\\data\\" + fileToOpen;
            try
            {
                string text = System.IO.File.ReadAllText(path);
                string[] values = text.Split(',');
                ChipsList = new List<string>(values);
                ChipsList.RemoveRange(0, 5);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
            }
            return ChipsList;
        }
    }
}

