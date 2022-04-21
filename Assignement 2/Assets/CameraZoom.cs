using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    int zoom = 60; 
    int normal = 60; 
    float smooth = 5;

    private bool isZoomed = false;

    void Update()
    {
        if(Input.GetMouseButtonDown(1) && zoom > 15)
        {   
            isZoomed = true;
            zoom -= 15;
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);

        }
        if(Input.GetMouseButtonDown(0) && zoom !=60){
            isZoomed = true;
            zoom += 15;
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);
        }
        if(Input.GetMouseButtonDown(2)){
            isZoomed = false;
        }


        if(isZoomed)
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);
        }

        if(!isZoomed)
        {
             GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth);
            zoom = 60;

        }
    }





}
