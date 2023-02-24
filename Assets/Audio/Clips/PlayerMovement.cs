using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
#region Exposed

    #endregion

    #region Unity Lifecycle
    void Start()
    {
        
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        //Comment transformer les deux float en vecteur de direction ?
        //Pour "Vertical", on sait qu'on veut aller vers l'avat quand on pousse le stick vers le haut

        Vector3 direction = transform.right * horizontalInput + transform.forward * verticalInput;

        Vector3 move = direction * _speed * Time.deltaTime;

        _characterController = GetComponent<CharacterController>();

        _characterController.Move(move);
    }

    #endregion

    #region Methods

    #endregion

    #region Private & Protected

    float _speed;

    float Move;

    private CharacterController _characterController;

    #endregion
}
