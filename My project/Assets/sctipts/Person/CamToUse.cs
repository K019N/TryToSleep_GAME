using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamToUse : MonoBehaviour
{
    private Transform _transform;
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _transform.Rotate(0, 0.3f, 0);
    }
}
