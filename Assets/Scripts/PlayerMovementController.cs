using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovementController : MonoBehaviour
{
    [SerializeField]
    private float maxRotateSpeed = 6.0f;
    [SerializeField]
    private float maxMoveSpeed = 10f;

    public GameObject gameOverScreen;

    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        //transform.Rotate(0,  Input.GetAxis("Mouse X") * maxRotateSpeed, 0);
        transform.Rotate(0, Input.GetAxis("Mouse X") * maxRotateSpeed, 0);
        characterController?.Move(Vector3.ClampMagnitude(
            new Vector3(
                Input.GetAxis("Horizontal") * maxMoveSpeed * Time.deltaTime,
                0,
                Input.GetAxis("Vertical") * maxMoveSpeed * Time.deltaTime), maxMoveSpeed)
        );
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
