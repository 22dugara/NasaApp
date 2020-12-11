using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapscript : MonoBehaviour
{
	public Transform car;
public Transform camera;
private string mode = "Slopes";
public GameObject colorKey;
public GameObject blackKey;
public GameObject ElevationKey;
public GameObject ActualElevationKey;
public GameObject AzimuthKey;
    // Start is called before the first frame update
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
             camera.position = new Vector3(car.position.x -59237f, 39f, car.position.z);
             blackKey.SetActive(true);
             colorKey.SetActive(false);
            AzimuthKey.SetActive(false);
             ElevationKey.SetActive(false);
        }
        if(mode == "Height"){
            camera.position = new Vector3(car.position.x -121997f, 39f, car.position.z);
             blackKey.SetActive(false);
             colorKey.SetActive(true);
             ElevationKey.SetActive(false);
        }
        if(mode == "ElevationAngle"){
             camera.position = new Vector3(car.position.x -182550f, 39f, car.position.z);
             blackKey.SetActive(false);
             colorKey.SetActive(false);
             ElevationKey.SetActive(true);
        }
                if(mode == "ActualElevationKey"){
             camera.position = new Vector3(car.position.x -242263f, 39f, car.position.z);
             blackKey.SetActive(false);
             colorKey.SetActive(false);
             ElevationKey.SetActive(false);
             ActualElevationKey.SetActive(true);
        }
                if(mode == "AzimuthKey"){
             camera.position = new Vector3(car.position.x -304224f, 39f, car.position.z);
             blackKey.SetActive(false);
             colorKey.SetActive(false);
             ElevationKey.SetActive(false);
             ActualElevationKey.SetActive(false);
             AzimuthKey.SetActive(true);
        }

    }
}

