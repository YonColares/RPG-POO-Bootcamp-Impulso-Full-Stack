namespace DIO_PROJETO_DOTNET_IMPULSO.crc.Entities
{
    public class Wizard : Hero
    {   
        public Wizard(string Name, int Level, string Herotype){
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;
        }


        public new string Attack(){
            return this.Name + " lançou Magia.";
        }

        public string Attack (int Bonus){

            if (Bonus > 6) {
            return this.Name + "Lançou Magia super efetiva com bonus de ataque de" + Bonus;
            }else{
            return this.Name + "Lançou Magia com força fraca com bonus de" + Bonus;
            }
        }
    }
}