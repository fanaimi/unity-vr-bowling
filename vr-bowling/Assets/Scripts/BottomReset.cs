using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider triggerCollider)
    {
        if (triggerCollider.CompareTag("BowlingBall"))
        {
            // print("yeah");
            ResetBall(triggerCollider.transform);
        }
    }


    private void ResetBall(Transform transform)
    {
        // print("yeah");
        transform.position = new Vector3(-1.15f, 0.8f, -0.02f);
    }
}
