using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartManager : MonoBehaviour
{
    public FloorMaker FloorMaker;
    // Update is called once per frame
    void Update()
    {
        
		if(Input.GetKeyDown(KeyCode.R)){
      FloorMaker.myCounter = 0;
      FloorMaker.floorlist.Clear();
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
    }
}
