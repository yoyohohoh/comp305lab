using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{
    public float scrollSpeed = 0.05f;

    private Renderer renderer;
    
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        //alternative way to do this,
        ////but showing lacking effect if initial scroll speed in panel is 1 for example
        InvokeRepeating("MoveBG", 0.01f, scrollSpeed);
    }

    private void MoveBG()
    {
        //alternative way to do this
        renderer.material.mainTextureOffset = new Vector2(renderer.material.mainTextureOffset.x + 0.05f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //work the same as above
        //renderer.material.mainTextureOffset = new Vector2(scrollSpeed * Time.time, 0);
    }
}
