using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public float turnSpeed = 50f;
    
    
    void Update ()
    {
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }

}
