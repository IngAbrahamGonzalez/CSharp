using System.Text;
using PooDemo.Interfaces;
using PooDemo.Models;

namespace PooDemo.Models
{
        class Cel : Dispositivos , ICelulares
    {
        private string _Nombre;
        public int Id {get; set;}
        public override string Nombre 
        {
            get  
            {
                return _Nombre;
            }
            
            set
            {
                _Nombre = value.Trim();
            }
        }

        public string NombreYColor
        {
            get 
            {
                return $"{Nombre} ({Color})";
            }
        }


        public string Color;
        string ICelulares.NombreYColor { get; set; }

        public string Dimensiones;
        public int NoDeBotones;
        public string CarCamaraF;
        public string CarCamaraT;
        public string Bateria;
        public bool LogoMarca;
        public string Otros;
        public List<Car> caracteristicas;

        public Cel()
        {
            Id = 1;
            caracteristicas = new List<Car>();
            LogoMarca = false;
        }

        public String VerCaracteristicas()
        {
            StringBuilder sb =  new StringBuilder();
            foreach (var item in caracteristicas)
            {
                sb.AppendLine($"{NombreYColor} Tiene las siguientes caracteristicas: {item.Pa}, {item.P}, {item.Al}, {item.R}, {item.CamaraFrontal}, {item.N}, {item.S} ");
            }
            return sb.ToString();
        }

        public override string TomarFotos()
        {
            return $"{Nombre} Tiene una camara perfecta para tomar Fotos";
        }

        public override string TomarSelfies()
        {
            //return base.TomarSelfies();
            return $"{Nombre} Tiene una excelente camara para tomar selfies";
        }
    }

}