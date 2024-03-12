using UnityEngine;

public class BeerToUse : MonoBehaviour
{
    private Transform _transform;
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    void Update()
    {
        _transform.Rotate(0f, 0f, 0.3f);
    }
}
