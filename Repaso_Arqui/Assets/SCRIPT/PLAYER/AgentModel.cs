using UnityEngine;

public class AgentModel : MonoBehaviour
{
    [SerializeField] private AgentController _agentControlle;
    [SerializeField] private float _velocidad = 20f;
    [SerializeField] private Rigidbody _rb;

    public bool IsMoving=>
        _agentControlle.moveValue !=
        Vector2.zero;

    public float MagnitudMovimiento=>
        _agentControlle.moveValue.magnitude;

    public void Movimiento()
    {
        _rb.linearVelocity = new Vector3(
            _agentControlle.moveValue.x * _velocidad,
            _rb.linearVelocity.y,
            _agentControlle.moveValue.y * _velocidad);
    }

    void Update()
    {
        Movimiento();
    }

}
