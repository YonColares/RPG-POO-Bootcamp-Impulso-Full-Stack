namespace DIO_PROJETO_DOTNET_IMPULSO.crc.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string Herotype){
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;
        }

         public override string Attack(){
            return this.Name + " atacou com a sua espada.";
        }
    }
}