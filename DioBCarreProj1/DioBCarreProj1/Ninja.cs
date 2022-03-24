using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioBCarreProj1.DioBCarreProj1
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string TypeHeroe, int MP, int HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.TypeHeroe = TypeHeroe;
            this.MP = MP;
            this.HP = HP;
        }
    }
}
