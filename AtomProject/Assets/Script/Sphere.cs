using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 3f);
        }
    }
}
