using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceControl : MonoBehaviour
{

    // public static int distanceCount;
    public GameObject distanceCountDisplay;
    public GameObject playerObj;

    void Update()
    {
        distanceCountDisplay.GetComponent<Text>().text=""+Mathf.RoundToInt(playerObj.transform.position.z)+" m";
    }
}
