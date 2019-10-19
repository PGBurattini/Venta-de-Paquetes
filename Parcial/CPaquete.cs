using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    class CPaquete
    {
        //Variables Miembro
        private static float IMPUESTO;
        private int Paquete;
        private string Detalle;
        private float Precio;
        private short Cuotas;
        private float SubPrecio;
        
        //Metodos

        public static void setIMPUESTO(float Imp)
        {
            CPaquete.IMPUESTO = Imp;
        }

        public CPaquete()
        {
            this.Paquete = 0;
            this.Detalle = "Sin Asignar.";
        }

        public CPaquete(int NUM, string DET)
        {

            this.Paquete = NUM;
            this.Detalle = DET;
        }

        public void setPrecio(float monto)
        {
            this.Precio = monto;
        }

        public float getPrecio()
        {
            return this.Precio;
        }

        public float darMontoTotal()
        {
            float SubTotal;
            SubTotal = (CPaquete.IMPUESTO * Precio) / 100;
            SubTotal = SubTotal + Precio;

            return SubTotal;

        }

        public void setCuotas(short CUO)
        { this.Cuotas = CUO;
        }

        public float darMontoTotal(short Cuotas)
        {

            float SubTotal;
            if (Cuotas == 1)

                return this.SubPrecio;
            else
            {
                SubTotal = ((Cuotas * 10) * Precio) / 100;
                return this.SubPrecio += SubTotal;
            }
        }

        public override string ToString()
        {
            string CAD;
            CAD = "Numero de paquete: " + this.Paquete.ToString();
            CAD += " - Detalle: " + this.Detalle;
            CAD += " - Precio: " + this.Precio.ToString();
            CAD += " - Impuesto: " + CPaquete.IMPUESTO.ToString();
            CAD += " - Precio total en  " + this.Cuotas.ToString();
            CAD += " Cuotas: " + (this.darMontoTotal(Cuotas) + this.Precio).ToString() ;
            return CAD;
        }

        private float Costo
        {
            set { this.Precio = value; }
            get { return this.Precio; }
        }

        public bool esMasBaratoQue(CPaquete Nuevo)
        {
            if (this.Precio < Nuevo.Precio)
                return true;
            else
                return false;

        }

    }
}
