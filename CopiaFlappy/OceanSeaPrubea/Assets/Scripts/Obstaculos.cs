using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public float speed = 5f;
    void Start()
    {
        Invoke("Destroy", 6f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.down * speed * Time.deltaTime;
    }

    private void Destory()
    {
        Destroy(gameObject); 
    }
}
