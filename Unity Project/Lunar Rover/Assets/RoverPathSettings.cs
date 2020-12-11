using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoverPathSettings : MonoBehaviour
{
	public Dropdown maxSlope;
	public Dropdown Prioritization;
	protected static int maxSlopeNumber;
	protected static int prio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	maxSlopeNumber= maxSlope.value;
    	prio = Prioritization.value;
    	Debug.Log(maxSlopeNumber);
    	Debug.Log(prio);
        
    }
}
