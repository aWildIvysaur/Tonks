using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FaceMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get a ray from the camera through the mouse
        var pos = Mouse.current.position;
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(pos.x.ReadValue(), pos.y.ReadValue(), 0));
        RaycastHit info;
        Physics.Raycast(ray, out info, 15);
        Vector3 point = info.point;
        point.y = 0.5f;
        transform.LookAt(point);


        Debug.DrawRay(ray.origin, ray.direction*15);
    }
}
