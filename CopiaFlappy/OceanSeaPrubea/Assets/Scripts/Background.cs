using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private Material myMaterial;
    public float velocity = 0; 

    // Start is called before the first frame update
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        myMaterial.mainTextureOffset = myMaterial.mainTextureOffset + Vector2.up* velocity * Time.deltaTime;
    }
}
