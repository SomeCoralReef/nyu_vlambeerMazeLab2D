using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class click : MonoBehaviour
{
    public FloorMaker FloorMaker;
    public void ClickTest(){
     FloorMaker.myCounter = 0;
      FloorMaker.floorlist.Clear();
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
}

