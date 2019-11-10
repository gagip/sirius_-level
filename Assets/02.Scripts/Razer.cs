using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Razer : MonoBehaviour
{
    public GameObject parentObject;
    public float speed = 20f;
    public bool clockWise = true;
    // Update is called once per frame
    void Update()
    {
        int clockWiseInt = clockWise ? -1 : 1;
        transform.RotateAround(parentObject.transform.position, new Vector3(0,0,1 * clockWiseInt), speed * Time.deltaTime);
    }
}
