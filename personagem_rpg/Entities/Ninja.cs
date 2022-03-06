namespace personagem_rpg.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

         public Ninja(){
        }

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public override string Attack()
        {
            return this.Name + " se escondeu nas sombras!";
        }
    }
}