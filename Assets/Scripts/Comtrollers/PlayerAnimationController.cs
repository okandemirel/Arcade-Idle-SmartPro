using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{


    #region Self Variables


    #region Public Variables

    #endregion

    #region Serialized Variables

    [SerializeField] private PlayerManager manager;
    [SerializeField] private Animator animator;

    #endregion

    #region Private Variables

    #endregion


    #endregion


    public void PlayMovementAnimation()
    {
        animator.SetTrigger("Run");
    }

    public void PlayIdleAnimation()
    {
        animator.SetTrigger("Idle");
    }

    public void PlayAttackAnimation()
    {
        animator.SetTrigger("Attack");
    }


}
