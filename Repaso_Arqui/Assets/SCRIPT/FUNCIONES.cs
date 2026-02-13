using UnityEngine;

public class FUNCIONES : MonoBehaviour
{
    private int _numeroEntero = 2;

    public FUNCIONES(int numeroEntero)
    {
        _numeroEntero = numeroEntero;
    }

    public CLASE listadeestudiantes = new CLASE();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MiFuncion();
    }

    // Update is called once per frame
    void Update()
    {
        //no saturar0
        MiFuncion();
    }

    public void MiFuncion()
    {
        Debug.Log(listadeestudiantes.estudiantes[2]);
    }
}
