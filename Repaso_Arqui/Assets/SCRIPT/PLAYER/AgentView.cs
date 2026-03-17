using UnityEngine;

public class AgentView : MonoBehaviour
{
    public enum Animations
    {
        Caminar,
        Correr,
        Daño,
        Vida,
        Quieto
    }
    public Animator animator;
    Animations animations;

    public void AnimationState()
    {
        switch (animations) 
        {
            case Animations.Vida:
                animator.SetTrigger("Vida");
                break;
            case Animations.Daño:
                animator.SetTrigger("Daño");
                break;
            default:
                break;

        }
    }
   


   
}