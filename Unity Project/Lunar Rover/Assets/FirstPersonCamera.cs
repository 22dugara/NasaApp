using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{	public Transform car;
public Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	camera.position = new Vector3((car.position.x + 5f), (car.position.y + 12f), (car.position.z - 2));
    	camera.localEulerAngles = new Vector3(car.eulerAngles.x,car.eulerAngles.y,car.eulerAngles.z);
        
    }
}
