using UnityEngine;

public class AgentView : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private AgentModel _agentModel;

    private bool isMoving = false;
    private bool isRunning = false;

    [SerializeField] private float runThreshold = 0.8f;

    void Update()
    {
        float magnitude = _agentModel.MagnitudMovimiento;

        // CORRER
        if (magnitude > runThreshold)
        {
            if (!isRunning)
            {
                _animator.SetTrigger("Correr");
                isRunning = true;
                isMoving = true;
            }
        }
        // CAMINAR
        else if (magnitude > 0)
        {
            if (!isMoving || isRunning)
            {
                _animator.SetTrigger("Caminar");
                isMoving = true;
                isRunning = false;
            }
        }
        // QUIETO
        else
        {
            if (isMoving)
            {
                _animator.SetTrigger("Parar");
                isMoving = false;
                isRunning = false;
            }
        }
    }

    // VIDA
    public void PlayHeal()
    {
        _animator.SetTrigger("Vida");
    }

    // DAÑO
    public void PlayDamage()
    {
        _animator.SetTrigger("Daño");
    }
}