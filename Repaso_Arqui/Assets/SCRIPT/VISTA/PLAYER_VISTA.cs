using UnityEngine;

public class PLAYER_VISTA : MonoBehaviour
{
    public bool isMove;

    [Header("Materiales")]
    [SerializeField] private Renderer render;
    [SerializeField] private Material material1;
    [SerializeField] private Material material2;

    [Header("clases")]
    [SerializeField] private PLAYER_CONTROLADOR controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        render = GetComponent<Renderer>();
        controller = GetComponent<PlayerController>();


    }


    // Update is called once per frame
    void Update()
    {
        CambiarColor();
        Debug.Log(controller.DirectionJugador().magnitude);
    }

    public void CambiarColor()
    {
        if (controller.DirectionJugador().magnitude > 0)
        {
            render.material.color = Color.red;
        }
        else
        {
            render.material.color = Color.yellow;
        }

    }
}