namespace DIO_PROJETO_DOTNET_IMPULSO.crc.Entities
{
    public abstract class Hero
    {
         public Hero(){
            
        }

        public Hero(string Name, int Level, string Herotype){
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;
        }

        public string Name = string.Empty;

        public int Level;

        public string Herotype = string.Empty;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.Herotype;
        }
        
        public virtual string Attack(){
            return this.Name + " ";
        }
    }
}