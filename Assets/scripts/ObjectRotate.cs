using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        transform.Rotate(0, 0, speed);
    }
}
