using UnityEngine;

public class AgentModel : MonoBehaviour
{
    [SerializeField] private AgentController _agentControlle;
    [SerializeField] private float _velocidad = 20f;
    [SerializeField] private Rigidbody _rb;

    public void Movimiento()
    {
        _rb.linearVelocity = new Vector3(
            _rd.lineal 10, _rb.linearVelocity.y, 0);
    }
  
}
