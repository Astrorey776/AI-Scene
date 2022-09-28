using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementstatic1 : MonoBehaviour
{
    public GameObject target;

    public float speed = 1f;
    public float turnSpeed = 1f;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Seek
        Vector3 direction = target.transform.position - transform.position;
        direction.y = 0f;
      
        Vector3 movement = direction.normalized * speed;

        float angle = Mathf.Rad2Deg * Mathf.Atan2(movement.x, movement.z);
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.up);

        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * turnSpeed);

        transform.position += movement * Time.deltaTime;
        
    }
}
