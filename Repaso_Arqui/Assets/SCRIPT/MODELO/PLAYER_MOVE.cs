using UnityEngine;

public class PLAYER_MOVE : MonoBehaviour
{

    [SerializeField]
    private PlayerController playerController;
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
            rb.linearVelocity = Vector3.forward * playerController.DirectionJugador() * velocidad;
        }
    }
}