namespace PooDemo.Models
{
    class Car 
{
    public Pantalla Pa;
    public Procesador P;
    public Almacenamiento Al;
    public RAM R;
    public bool CamaraFrontal;
    public CamarasTraseras N;
    public Software S;

    public Car() 
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

}