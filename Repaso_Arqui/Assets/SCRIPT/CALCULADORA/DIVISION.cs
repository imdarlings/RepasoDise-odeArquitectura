using UnityEngine;

public class DIVISION : MonoBehaviour
{
    public float Calcular(float a, float b)
    {
        if (b == 0)
            return 0; 
        
        return a / b;
    }
}
