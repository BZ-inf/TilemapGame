using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
    
{
    public SpriteRenderer branch;
    public Sprite dziuplaOpen;
    public Sprite mySprite;
    private SpriteRenderer Acorn;


    // Start is called before the first frame update
    void Start()
    {
        Acorn = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="Player")
        {
            Acorn.sprite = mySprite;
            branch.sprite = dziuplaOpen;
        }

    }
}
