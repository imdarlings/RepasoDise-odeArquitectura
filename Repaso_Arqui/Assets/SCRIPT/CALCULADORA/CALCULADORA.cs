using Unity.VisualScripting;
using UnityEngine;

public class CALCULADORA : MonoBehaviour
{
    // Definición de las clases faltantes
    public class Suma
    {
        public float Calcular(float a, float b) => a + b;
    }

    public class Resta
    {
        public float Calcular(float a, float b) => a - b;
    }

    public class Multiplicacion
    {
        public float Calcular(float a, float b) => a * b;
    }

    public class Division
    {
        public float Calcular(float a, float b) => a / b;
    }

    public class Calculadora
    {
        private     Suma suma = new Suma();
        private Resta resta = new Resta();
        private Multiplicacion multiplicacion = new Multiplicacion();
        private Division division = new Division();

        public float Sumar(float a, float b)
        {
            return suma.Calcular(a, b);
        }

        public float Restar(float a, float b)
        {
            return resta.Calcular(a, b);
        }

        public float Multiplicar(float a, float b)
        {
            return multiplicacion.Calcular(a, b);
        }

        public float Dividir(float a, float b)
        {
            return division.Calcular(a, b);
        }
    }
}
