using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GPS : MonoBehaviour
{
    public Vector2 initCoords = new Vector2(59.4050f, 17.9520f);
    private void Start()
    {
        GPSEncoder.SetLocalOrigin(initCoords); //new Vector2(59.4050f, 17.9520f)); //new Vector2(59.908110f, 17.739856f));


        Debug.Log("A:" + GPSEncoder.GPSToUCS(59.4050f, 17.9520f));
        Debug.Log("B:" + GPSEncoder.GPSToUCS(59.4039f, 17.9488f));
        Debug.Log("C:" + GPSEncoder.GPSToUCS(59.4030f, 17.9546f));

    }

    private void Update()
    {
       // Debug.Log(GPSEncoder.USCToGPS(transform.position).ToString("F6"));
    }
}
