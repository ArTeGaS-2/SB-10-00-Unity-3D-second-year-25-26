using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float speed = 5f;
    private void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
