using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControles : MonoBehaviour


{

    InputAction moveAction;

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");

    }


    void Update()
    {

        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        Debug.Log("Vector de movimiento" + moveValue);

    }

    public Vector2 DirectionJugador()
    {
        return moveAction.ReadValue<Vector2>();
    }
}
