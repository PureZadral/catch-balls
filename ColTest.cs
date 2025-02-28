using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColTest : MonoBehaviour
{
    Rigidbody rb;
    public static int count = 0;
    public static int fall = 0;
    public GameObject win;
    public GameObject lose;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision coll){
        if(coll.gameObject.tag == "Goodcube"){
            rb.AddForce(-20f,0,0);
        }
        if(coll.gameObject.tag == "plate"){
            Destroy(gameObject);
            fall = fall + 1;
        }
        if(fall == 6){
            lose.SetActive(true);
        }
    }
    void OnMouseDown(){
        Destroy(gameObject);
        count = count + 1;
        if(count == 6){
            win.SetActive(true);
        }
    }

}