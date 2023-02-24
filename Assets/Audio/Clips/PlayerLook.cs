using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
#region Exposed

    #endregion

    #region Unity Lifecycle
    void Start()
    {
        
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        mouseX = _mouseSensitivity.x * Time.deltaTime;
        
        
        float mouseY = Input.GetAxis("Mouse Y");
        mouseY = _mouseSensitivity.y * Time.deltaTime;

        gamePadX = _padSensitivity.x * Time.deltaTime;

        gamePadY = _padSensitivity.y * Time.deltaTime;

        _horizontal += mouseX + gamePadX;

        _vertical += mouseY + gamePadY;


        _vertical = Mathf.Clamp(_vertical, _mouseYLimit.x, _mouseYLimit.y);
        //ici on fait la rotation du joueur
        //on uilise les angles en degrés, (ou angles d'Euler), mais il faut se souvenir qu'Unity utilise en coulisse des Quaternions

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, _horizontal, transform.eulerAngles.z);

        //Au tour de la caméra
        _cameraTransform.eulerAngles = new Vector3(_vertical, _cameraTransform.eulerAngles.y, _cameraTransform.eulerAngles.z);
    }

    void Awake ()
    {

        Cursor.lockState = CursorLockMode.Locked;

    }
    #endregion

    #region Methods

    #endregion

    #region Private & Protected

    Vector3 _mouseSensitivity;

    Vector3 _padSensitivity;

    Vector3 _mouseYLimit;

    float _horizontal;

    float _vertical;

    float  gamePadX;

    float  gamePadY;

    private object _cameraTransform;



    #endregion
}
