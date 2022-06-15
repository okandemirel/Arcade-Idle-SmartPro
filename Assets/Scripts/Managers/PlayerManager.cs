using Controllers;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    #region Self Variables

    #region Public Variables
    #endregion

    #region Serialized Variables
    [SerializeField] private PlayerMovementController movementController;
    [SerializeField] private PlayerAnimationController animationController;
    [SerializeField] private PlayerPhysicsController physicsController;

    #endregion

    #region Private Variables
    #endregion

    #endregion


    public void OnPlayerCollidedWithCollectable()
    {
        animationController.PlayAttackAnimation();

    }

}
