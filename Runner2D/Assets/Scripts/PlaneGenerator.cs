using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneGenerator : MonoBehaviour
{
    [SerializeField] PlaneProperities plane;
    PlaneProperities lastPlane;
    public int planeNumber;

    // Start is called before the first frame update
    void Start()
    {
        lastPlane = FindObjectOfType<PlaneProperities>();
    }

    // Update is called once per frame
    void Update()
    {
        if(planeNumber<3)
        {
            lastPlane = Instantiate(plane, new Vector3(lastPlane.outOfBound,lastPlane.transform.position.y,0)
                                    , Quaternion.identity);
            planeNumber++;
        }
    }



}
