namespace personagem_rpg.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Wizard(){
        }

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public string Attack(int Bonus){
            if(Bonus > 6){
                return this.Name + " Lançou Super Magia com bonus de ataque de " + Bonus;
            } else {
                return this.Name + " Lançou Magia Fraca com bonus de ataque de " + Bonus;
            }
        }
    }
}