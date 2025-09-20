
using System.Collections.Generic;

namespace GarajeMVC.Models
{
    public class Garage
    {
        public int NumeroGaraje { get; set; }
        public string Descripcion { get; set; }
        public int CapacidadEspacios { get; set; }
        public int EspaciosOcupados { get; set; }
        public List<Auto> Autos { get; set; }

        public Garage(int numeroGaraje, string descripcion, int capacidad, int espaciosOcupados)
        {
            this.NumeroGaraje = numeroGaraje;
            this.Descripcion = descripcion;
            this.CapacidadEspacios = capacidad;
            this.EspaciosOcupados = espaciosOcupados;
            this.Autos = new List<Auto>();
        }

        public void IngresarAuto(Auto auto)
        {
            this.Autos.Add(auto);
        }

        public List<Auto> GetAutos()
        {
            return this.Autos;
        }
    }
}