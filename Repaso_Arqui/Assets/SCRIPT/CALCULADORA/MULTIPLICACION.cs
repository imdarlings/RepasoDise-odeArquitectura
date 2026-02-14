using UnityEngine;

public class MULTIPLICACION : MonoBehaviour
{
    public class Multiplicacion : IOperacion
    {
        public float Calcular(float a, float b)
        {
            return a * b;
        }
    }
}
