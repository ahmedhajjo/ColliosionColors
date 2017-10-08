using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour {
    public Light ll;
    // Use this for initialization
      private void OnCollisionEnter(Collision collision)
      
        

    {
        if (collision.gameObject.tag == "Crack")
        {

            collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        
            }

        if (collision.gameObject.tag == "Platform")
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;


        }
       
            collision.gameObject.GetComponent<MeshRenderer>();
            ll.color = Color.blue;
        
    }


    void Start () {
		
         



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
