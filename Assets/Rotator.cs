using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float speed = 180f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0, speed * Time.deltaTime);
    }
}
