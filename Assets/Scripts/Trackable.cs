using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Trackable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TrackableBehaviour tb = this.GetComponentInChildren<TrackableBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
