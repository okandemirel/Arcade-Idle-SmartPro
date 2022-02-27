using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysicsController : MonoBehaviour
{

    #region Self Variables

    #region Public Variables

    #endregion
    #region Serialized Variables


    [SerializeField] private PlayerManager manager;
    [SerializeField] private Collider collider;
    [SerializeField] private Rigidbody rigidbody;


    #endregion
    #region Private Variables

    #endregion
    #endregion

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            manager.OnPlayerCollidedWithCollectable();

        }
    }
}
