using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
public class CameraControls : MonoBehaviour
{
    public InputAction cameraControls;
    float moveDirection;
    [SerializeField] float moveSpeed = 5f;

    void OnEnable()
    {
        cameraControls.Enable();
    }
    void OnDisable()
    {
        cameraControls.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = cameraControls.ReadValue<float>();
        transform.Rotate(0, moveDirection * moveSpeed * Time.deltaTime, 0);
    }
}
