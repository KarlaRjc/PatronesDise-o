namespace Laboratorio8._7_Compuesto
{
    //clase abstracta, Padre
    abstract class Component
    {
        //Métodos Getters and Setters
        public string nombre { get; set; }
        public decimal costo { get; set; }

        public Component(string nombre, decimal costo)
        {
            this.nombre = nombre;
            this.costo = costo;
        }
    }
}
