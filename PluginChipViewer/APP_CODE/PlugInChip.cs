using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginChipViewer.APP_CODE
{
    public class PlugInChip
    {

        private int id;
        private string name;
        private int cost;
        private string rank;
        private string effect;
        private string obtain;

        public PlugInChip(int Id, string Name, string Rank, int Cost, string Effect, string Obtain)
        {
            this.id = Id;
            this.name = Name;
            this.rank = Rank;
            this.cost = Cost;
            this.effect = Effect;
            this.obtain = Obtain;
        }

        public int ID { get { return id; } }

        public string Name { get { return name; } }

        public string Rank { get { return rank; } }

        public int Cost { get { return cost; } }

        public string Effect { get { return effect; } }

        public string Obtain { get { return obtain; } }

    }
}
