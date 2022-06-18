using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour
{

    public float moveState;
    public float speed;
    Vector3 vector;

    // Start is called before the first frame update
    void Start()
    {
        vector = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float z = moveState * Mathf.Sin(Time.time * speed);

        transform.localPosition = vector + new Vector3(0, 0, z);
        
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
