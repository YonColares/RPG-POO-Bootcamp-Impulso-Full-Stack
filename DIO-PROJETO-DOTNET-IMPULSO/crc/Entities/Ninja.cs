namespace DIO_PROJETO_DOTNET_IMPULSO.crc.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string Herotype){
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;
        }

        public new string Attack(){
            return this.Name + " lançou Shurikens.";
        }

        public string Attack (int Bonus){

            if (Bonus > 6) {
            return this.Name + " multiplicou a investida de shurikens com força de " + Bonus;
            }else{
            return this.Name + " errou varias vezes o alvo.";
            }
        }
    }
}