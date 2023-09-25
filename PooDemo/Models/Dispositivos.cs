namespace PooDemo.Models
{
    internal abstract class Dispositivos
    {
        public abstract string Nombre {get; set;}
        public abstract string TomarFotos();

        public virtual string TomarSelfies()
        {
            return $"{Nombre} toma selfies muy padres";
        } 
    }
}