using System.Security.Cryptography;
using System.Text;

var IPHONE14 = new Celular();
var VIVOV25 = new Celular();


var vivoV25 = new Caracteristicas();
vivoV25.Pa = Pantalla.Pantalla6inch;
vivoV25.P = Procesador.MediaTek;
vivoV25.Al = Almacenamiento.Almacenamiento256Gb;
vivoV25.R = RAM.RAM8Gb;
vivoV25.CamaraFrontal = true;
vivoV25.N = CamarasTraseras.NumeroDeCamaras3;
vivoV25.S = Software.Andorid;

var iphone14 = new Caracteristicas();
iphone14.Pa = Pantalla.Pantalla6inch;
iphone14.P = Procesador.Apple;
iphone14.Al = Almacenamiento.Almacenamiento128Gb;
iphone14.R = RAM.RAM6Gb;
iphone14.CamaraFrontal = true;
iphone14.N = CamarasTraseras.NumeroDeCamaras2;
iphone14.S = Software.IOS;


VIVOV25.Id|= 1;
VIVOV25.Nombre = "Vivo 25e";
VIVOV25.Color = "Gris";
VIVOV25.Dimensiones = "162.51 x 75.81 x 7.80 mm -- 186 gramos";
VIVOV25.NoDeBotones = 3;
VIVOV25.CarCamaraF = "32 megapixeles f/2.0";
VIVOV25.CarCamaraT = "64 megapixeles f/1.79 principal con estabilización óptica (OIS), 2 megapixeles f/2.4 macro, 2 megapixeles f/2.4 para profundidad";
VIVOV25.Bateria = "4,600 mAh con carga rápida de 66W";
VIVOV25.Otros = "Sensor de huellas en pantalla, 4G LTE, Wi-Fi 2.4/5 GHz, Bluetooth 5.2, Audífonos incluidos en la caja";
VIVOV25.LogoMarca = false;

IPHONE14.Id = 2;
IPHONE14.Nombre = "Iphone 14";
IPHONE14.Color = "Dorado";
IPHONE14.Dimensiones = "146.7mm x 71 x 5mm x 7,6mm -- 173g";
IPHONE14.NoDeBotones = 4;
IPHONE14.CarCamaraF = "12MP, f/1,9, TOF 3D, slow-motion, AF";
IPHONE14.CarCamaraT = "Principal: 12MP, f/1.6, OIS, QuadLED flash, Secundaria gran angular: 12MP, f/2.4, Vídeo: 4K Dolby Vision, 1080p/240fps, HDR, modo cinemático";
IPHONE14.Bateria ="Carga rápida 18W e inalámbrica MagSafe 15W, Conexión Lightning";
IPHONE14.Otros = "WiFi 6, 5G, BT 5.2, NFC, GPS, dualSIM, eSIM, altavoces estéreo Dolby Atmos, reconocimiento facial, resistencia al agua IP68";
IPHONE14.LogoMarca = true;


List<Caracteristicas> IphoneCar = new List<Caracteristicas>();
IphoneCar.Add(iphone14);
IPHONE14.caracteristicas = IphoneCar;
string resultCaracteristicas = IPHONE14.VerCaracteristicas();
Console.WriteLine(resultCaracteristicas);

List<Caracteristicas> VivoCar = new List<Caracteristicas>();
VivoCar.Add(vivoV25);
VIVOV25.caracteristicas = VivoCar;
string resultCaracteristicas1 = VIVOV25.VerCaracteristicas();
Console.WriteLine(resultCaracteristicas1);



class Celular 
{
    public int Id;
    public string Nombre;
    public string Color;
    public string Dimensiones;
    public int NoDeBotones;
    public string CarCamaraF;
    public string CarCamaraT;
    public string Bateria;
    public bool LogoMarca;
    public string Otros;
    public List<Caracteristicas> caracteristicas;

    public Celular()
    {
        Id = 1;
        caracteristicas = new List<Caracteristicas>();
        LogoMarca = false;
    }

    public String VerCaracteristicas()
    {
        StringBuilder sb =  new StringBuilder();
        foreach (var item in caracteristicas)
        {
            sb.AppendLine($"{Nombre} Tiene las siguientes caracteristicas: {item.Pa}, {item.P}, {item.Al}, {item.R}, {item.CamaraFrontal}, {item.N}, {item.S} ");
        }
        return sb.ToString();
    }
}

class Caracteristicas 
{
    public Pantalla Pa;
    public Procesador P;
    public Almacenamiento Al;
    public RAM R;
    public bool CamaraFrontal;
    public CamarasTraseras N;
    public Software S;

    public Caracteristicas() 
    {
        Pa = Pantalla.Pantalla5inch;
        P = Procesador.Qualcomm;
        Al = Almacenamiento.Almacenamiento64Gb;
        R = RAM.RAM4Gb;
        CamaraFrontal = true;
        N = CamarasTraseras.NumeroDeCamaras1;
        S = Software.Andorid;
    }
}

enum Pantalla 
{
    Pantalla5inch,
    Pantalla6inch,
    Pantalla7inch
}

enum Procesador
{
    Qualcomm,
    Adreno,
    Apple,
    Exynos,
    MediaTek,
    Tensor
}

enum RAM
{
    RAM4Gb,
    RAM6Gb,
    RAM8Gb,
    RAM12Gb,
    RAM18Gb
}

enum Almacenamiento
{
    Almacenamiento64Gb, 
    Almacenamiento128Gb, 
    Almacenamiento256Gb,
    Almacenamiento512Gb, 
    Almacenamiento1T
}

enum CamarasTraseras
{
    NumeroDeCamaras1,
    NumeroDeCamaras2,
    NumeroDeCamaras3,
    NumeroDeCamaras4
}

enum Software
{
    Andorid,
    IOS
}
