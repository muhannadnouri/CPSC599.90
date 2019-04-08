using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DistanceTracker : MonoBehaviour
{
    Animator anim;

    TrackableBehaviour myTrackableBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 delta = Camera.main.transform.position - myTrackableBehaviour.transform.position;
        float distance = delta.magnitude;

        if (distance > 0)
        {
            anim.SetTrigger("Resting");
            anim.SetTrigger("IsClose");
        } else if (distance > 5)
        {
            anim.ResetTrigger("Resting");
        }
        */
    }
}
