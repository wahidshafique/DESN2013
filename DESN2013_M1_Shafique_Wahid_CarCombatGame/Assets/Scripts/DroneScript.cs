using UnityEngine;
using System.Collections;

public class DroneScript : MonoBehaviour
{
    Vector3 rotationMask = new Vector3(0, 1, 0);
    public float rotationSpeed = 5f;
    public Transform rotateAroundObject;
    //public Transform player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
      //  transform.LookAt(player);
        if (rotateAroundObject)
        {//If true in the inspector orbit <rotateAroundObject>:
            transform.RotateAround(rotateAroundObject.transform.position,
            rotationMask, rotationSpeed * Time.deltaTime);
        }
        else
        {//not set -> rotate around own axis/axes:
            transform.Rotate(new Vector3(
            rotationMask.x * rotationSpeed * Time.deltaTime,
            rotationMask.y * rotationSpeed * Time.deltaTime,
            rotationMask.z * rotationSpeed * Time.deltaTime));
        }
    }
}
 