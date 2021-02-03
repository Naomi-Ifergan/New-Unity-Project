using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.collider.gameObject == player)
        {
            Debug.Log("collision dected");
            Vector3 force = new Vector3(0, 10, 0);
            this.GetComponent<Rigidbody>().AddForce
        }
    }
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
