using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float x = 0f;
    public float y = 0f;
    public float z = 0f;
    private void Update()
    {
        transform.Rotate(x, y, z);
    }
}
