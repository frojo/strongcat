using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strongcat : MonoBehaviour
{
    public float moveSpeed = 0;

    SpriteRenderer sprite;
    Animator anim;
    public BoxCollider2D punchbox;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        punchbox.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {


        if (anim.GetCurrentAnimatorStateInfo(0).IsName("punch"))
        {
            punchbox.gameObject.SetActive(true);
            return;
        } else {
            if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.L))
            {
 
                anim.SetTrigger("punch");
                punchbox.gameObject.SetActive(true);
                return;

            } else
            {
                punchbox.gameObject.SetActive(false);
                Movement();
            }  
        }

    }

    void Movement()
    {
        bool moving = false;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * Time.deltaTime * moveSpeed;
            moving = true;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Time.deltaTime * moveSpeed;
            moving = true;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * moveSpeed;
            Vector3 scale = transform.localScale;
            scale.x = -1;
            transform.localScale = scale;

            moving = true;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * moveSpeed;

            Vector3 scale = transform.localScale;
            scale.x = 1;
            transform.localScale = scale;
            moving = true;
        }
        anim.SetBool("moving", moving);


    }

    public void getHit()
    {
        Debug.Log(gameObject.name + " got hit!");
    }
}
