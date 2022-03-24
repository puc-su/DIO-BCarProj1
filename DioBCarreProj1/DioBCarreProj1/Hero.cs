using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioBCarreProj1
{
    public abstract class Hero
    {
        public Hero(string Name,int Level, string TypeHeroe, int MP, int HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.TypeHeroe = TypeHeroe;
            this.MP = MP;
            this.HP = HP;

        }
        public Hero()
        {

        }

        public string Name;
        public int Level;
        public string TypeHeroe;
        public int MP;
        public int HP;

        public override string ToString()
        {
            return this.Name + "Nível: " + this.Level + "Categoria: " + this.TypeHeroe + "Força: " + this.MP + "Vidas: " + this.HP;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada ";
        }

        public virtual string Forca(int QtdForca)
        {
            if (QtdForca < 10)
            {
                return this.Name + " intensidade do Ataque Fraco " + QtdForca;
            }
            else
            {
                return this.Name + " intensidade do ataque Forte " + QtdForca;

            }
        }
    }
}
