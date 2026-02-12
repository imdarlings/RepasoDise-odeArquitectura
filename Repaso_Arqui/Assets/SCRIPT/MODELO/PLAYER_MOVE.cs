using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField]
    private PlayerControles playerController;
    [SerializeField]
    private Rigidbody rb;

    public bool isMove;

    float velocidad = 5;

    void Update()
    {
        Movimiento();
    }

    private void Movimiento()
    {
        if (isMove)
        {
            rb.linearVelocity = playerController.DirectionJugador() * velocidad;
        }
    }
}