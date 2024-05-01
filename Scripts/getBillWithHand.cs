using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getBillWithHand : MonoBehaviour
{
    //public GameObject bringTheBillTimelineActive;

    private Collider takeTheBillCollider;

    //public GameObject leftHandPosition;

    //public GameObject rightHandPosition;

    // Start is called before the first frame update

    
    void Start()
    {
        //Fetch the GameObject's Collider (make sure they have a Collider component)
        takeTheBillCollider = GetComponent<Collider>();
        //Here the GameObject's Collider is not a trigger
        takeTheBillCollider.isTrigger = false;
        //Output whether the Collider is a trigger type Collider or not
        Debug.Log("Trigger On : " + takeTheBillCollider.isTrigger);
    }

    private void OnTriggerEnter(Collider other) =>
            //if (other.gameObject.tag == "Hand")
            //{
            Debug.Log("Triggered");//}

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(takeTheBillCollider.isTrigger);
    }
}
