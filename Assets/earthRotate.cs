using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earthRotate : MonoBehaviour
{

    //public float rotationSpeed;
    public GameObject pivotObject;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = new Vector3(0, 80, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(movement * Time.deltaTime);
        transform.RotateAround(pivotObject.transform.position, new Vector3(0, 1, 0), 30 * Time.deltaTime);
    }
}
