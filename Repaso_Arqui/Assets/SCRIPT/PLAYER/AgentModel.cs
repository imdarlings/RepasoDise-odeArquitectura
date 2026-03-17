using Unity.VisualScripting;
using UnityEngine;

public class AgentModel : MonoBehaviour
{
    [SerializeField] private AgentController _agentControlle;
    [SerializeField] private float _velocidad = 20f;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private AgentView _agentView;
    [SerializeField] float veloMax = 10;
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
       
        float veloNormalizada = Mathf.Clamp01(_rb.linearVelocity.magnitude / veloMax
            If(_rb.linearVelocity.magnitude >= 0.01)
            {
            veloNormalizada = 0.01f;
            _agentView.animator.SetFloat
            }

    }

}
