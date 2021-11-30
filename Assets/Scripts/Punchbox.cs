using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punchbox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("trigger!");
        if (col.tag == "strongcat")
        {
            col.GetComponent<Strongcat>().getHit();
        } else if (col.tag == "enemycat")
        {
            col.GetComponent<Enemycat>().getHit();
        }
    }
}
