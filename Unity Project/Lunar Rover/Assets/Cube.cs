using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform car;
public Transform cube;
public string mode = "Slopes";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            Debug.Log("space is pressed");
            Debug.Log(mode);
                    if(mode == "Slopes"){
             mode = "Height";
        }
                    else if(mode == "Height"){
            mode = "ElevationAngle";
        }
                    else if(mode == "ElevationAngle"){
            mode = "ActualElevationKey";
        }
                    else if(mode == "ActualElevationKey"){
            mode = "AzimuthKey";
        }
                    else if(mode == "AzimuthKey"){
            mode = "Slopes";
        }
        }
    	if(mode == "Slopes"){
			cube.position = new Vector3(car.position.x -59237f, 12.6f, car.position.z);
    	}
    	if(mode == "Height"){
    		cube.position = new Vector3(car.position.x -121997f, 12.6f, car.position.z);
    	}
        if(mode == "ElevationAngle"){
            cube.position = new Vector3(car.position.x -182550f, 12.6f, car.position.z);
        }
                if(mode == "ActualElevationKey"){
            cube.position = new Vector3(car.position.x -242263f, 12.6f, car.position.z);
        }
                if(mode == "AzimuthKey"){
            cube.position = new Vector3(car.position.x -304224f, 12.6f, car.position.z);
        }
       
    }
}
