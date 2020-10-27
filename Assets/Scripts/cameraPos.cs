using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPos : MonoBehaviour
{
    float xAx, yAx;
    public float zoomSpeed = 0.3f;
    public Camera mainCam;
    public RestartManager RestartManager;

    // Update is called once per frame
    void Update()
    {
        if (FloorMaker.floorlist.Count > 0) {
            xAx = 0; 
            yAx = 0;
            for(int i = 0; i < FloorMaker.floorlist.Count; ++i) {
                xAx += FloorMaker.floorlist[i].position.x;
                yAx += FloorMaker.floorlist[i].position.y;
            }
            xAx = xAx/FloorMaker.floorlist.Count;
            yAx = yAx/FloorMaker.floorlist.Count;

            mainCam.transform.position = new Vector3(xAx, yAx, -5);
            if(mainCam.orthographicSize < 20) {
                mainCam.orthographicSize += zoomSpeed;
            }
        } else {
            Debug.Log("haiz...");
        }
    }
}