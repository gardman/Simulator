using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPS : MonoBehaviour
{
    private void Start()
    {
        GPSEncoder.SetLocalOrigin(new Vector2(59.908110f, 17.739856f));
    }

    private void Update()
    {
        Debug.Log(GPSEncoder.USCToGPS(transform.position).ToString("F6"));
    }
}
