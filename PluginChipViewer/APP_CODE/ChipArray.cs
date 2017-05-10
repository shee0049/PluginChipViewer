using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginChipViewer.APP_CODE
{
    class ChipArray
    {
        private static PlugInChip[] chips = new PlugInChip[13];

        public PlugInChip[] Chips { get; set; }


        public ChipArray()
        {
        }

 
        public static void DisplayChips(PlugInChip[] chipArray)
        {
            for (int i = 0; i < chipArray.Length; i++)
            {
                Console.Out.WriteLine("{0} {1}", i, chipArray[i].Name);
            }
        }

        public static PlugInChip[] SystemData(List<string> list)
        {
            int index = 0;

            for (int i = 0; i < list.Count; i += 5)
            {
                PlugInChip chip = new PlugInChip(index, list[i].TrimStart('\r', '\n'), list[i + 1], int.Parse(list[i + 2]), list[i + 3], list[i + 4]);
                chips[index] = chip;
                index++;
            }
            return chips;
        }

        public static void ChipInfo(PlugInChip[] chipArray, int chipChoice)
        {
            bool isFound = false;
            for (int i = 0; !isFound; i++)
            {
                if (i == chipArray[chipChoice].ID)
                {
                    Console.Write("Chip Name: {0}\nChip Cost: {1}\nChip Rank: {2}\nChip Effect: {3}\nChip Obtain: {4}\n",
                        chipArray[i].Name, chipArray[i].Cost, chipArray[i].Rank, chipArray[i].Effect, chipArray[i].Obtain);
                    isFound = true;
                }
                else
                {
                    isFound = false;
                }
            }
        }
    }
}
