using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycat : MonoBehaviour
{

    SpriteRenderer sprite;
    Animator anim;
    BoxCollider2D punchbox;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        
    

    }


    public void getHit()
    {
        Debug.Log(gameObject.name + " got hit!");
    }
}
