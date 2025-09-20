namespace GarajeMVC.Models
{
  
    public class Auto
    {
        public int numeroAuto { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }

  
        public Auto(int numero, string marca, string placa)
        {
            this.numeroAuto = numero;
            this.Marca = marca;
            this.Placa = placa;
        }
    }
}