using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabShooting : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody bullet;
    public float speed = 20f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            object clone = Instantiate(bullet, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3(0, 0, speed));
            Destroy(clone.gameObject, 3);
        }

    }
}
