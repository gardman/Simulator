using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCar : MonoBehaviour
{
    public Transform carT;
    private Vector3 offset = new Vector3(0,1,5);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = (carT.transform.position + (carT.forward * -10) + Vector3.up * 3) - this.transform.position;
        this.transform.position += diff * 1.95f * Time.deltaTime;

        this.transform.LookAt(carT, Vector3.up);
    }
}
