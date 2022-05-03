using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    private float posPlusHalfWidlf;
    SpriteRenderer spriteRenderer;
    Vector2 screenSize;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        posPlusHalfWidlf = transform.position.x + 2;
        if (spriteRenderer != null)
            posPlusHalfWidlf += spriteRenderer.bounds.size.x / 2;

        screenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if(Camera.main.transform.position.x - screenSize.x >posPlusHalfWidlf)
        {
            Destroy(gameObject);
        }
    }
}
