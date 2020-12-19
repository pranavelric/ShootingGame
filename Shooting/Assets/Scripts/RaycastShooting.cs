using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShooting : MonoBehaviour
{
    public Transform par;
    public int theDamage = 100;
    private Vector3 lineTransform;
    private Vector3 startTransform;
    // Start is called before the first frame update
    void Start()
    {
        lineTransform = transform.position;
        startTransform = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(new Vector3((float)(Screen.width * 0.5), (float)(Screen.height * 0.5), 0));

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, hit, 100))
            {
                object particleClone = Instantiate(par, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(particleClone.gameObject, 2);
                hit.transform.SendMessage("ApplyDamage", theDamage, SendMessageOptions.DontRequireReceiver);
                lineTransform = hit.point;
            }
        }
    }
}



