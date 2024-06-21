namespace Polideportivo_Colón
{
    public class Grupo
    {
        // Atributos
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public int Disciplina { get; set; }
        public int NumeroGrupo { get; set; }
        public double TiempoEspera { get; set; }
        public double TiempoLlegada { get; set; }

        // Constructor
        public Grupo(string nombre, int disciplina, double tiempoLlegada, int numeroGrupo)
        {
            NumeroGrupo = numeroGrupo;
            Nombre = nombre;
            Estado = "Esperando";
            Disciplina = disciplina;
            TiempoEspera = 0;
            TiempoLlegada = tiempoLlegada;
        }
        public double calcularTiempoEspera(double grupo_tiempo){
            if(Estado == "Esperando"){
                TiempoEspera = Math.Round(grupo_tiempo - TiempoLlegada - TiempoEspera, 4);
            } 
            return TiempoEspera;
        }

        

        // Método para obtener la representación en cadena del objeto
        public override string ToString()
        {
            return $"Grupo: {Nombre}, Estado: {Estado}, Disciplina: {Disciplina}, Tiempo de Espera: {TiempoEspera}";
        }
    }
}