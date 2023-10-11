using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] Text scoatext;
    [SerializeField] float SP =10;
    [SerializeField]bool stopfl = false;
    int sukoa = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoatext.text = sukoa+"";
        if (stopfl == false)
        {
            rb.velocity = transform.forward * SP;
            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log("A");
                rb.velocity = transform.forward * SP + transform.right * -10;
            }
            if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("D");
                rb.velocity = transform.forward * SP + transform.right * 10;
            }

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="gool")
        {
            stopfl = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "coin")
        {
            sukoa++;

            other.gameObject.active=false;
        }
    }

}
