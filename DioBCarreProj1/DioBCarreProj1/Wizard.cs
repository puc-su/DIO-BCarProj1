using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DioBCarreProj1;

namespace DioBCarreProj1
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string TypeHeroe, int MP, int HP) 
        {
            this.Name = Name;
            this.Level = Level;
            this.TypeHeroe = TypeHeroe;
            this.MP = MP;
            this.HP = HP;
        }

        public override string Attack()
        {
            return this.Name + " Lançou magia ";
        }
        public string Attack(string Mago)
        {
            if (Mago == "W")
            {
                return this.Name + " Lançou magia de Luz Branca ";
            }
            else 
            {
                return this.Name + " Lançou magia de Luz Negra ";

            }

        }
    }
}
