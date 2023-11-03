using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit info;
        Physics.Raycast(ray, out info, 15);
        Vector3 point = info.point;
        point.y = 0.5f;
        transform.LookAt(point);


        Debug.DrawRay(ray.origin, ray.direction*15);
        Debug.Log(info.point);
    }
}
