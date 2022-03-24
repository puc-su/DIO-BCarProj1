using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DioBCarreProj1;

namespace DioBCarreProj1
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string TypeHeroe, int MP, int HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.TypeHeroe = TypeHeroe;
            this.MP = MP;
            this.HP = HP;

        }

    }
}
