using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Vector3 direction = new Vector3(1, 0, 0);
    private Vector3 angle = new Vector3(1, 1, 1);
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime*speed, Space.World);
        transform.Rotate(angle, Space.World);
    }
}
