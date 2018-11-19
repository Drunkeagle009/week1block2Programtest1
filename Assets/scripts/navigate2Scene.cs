using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navigate2Scene : MonoBehaviour {
    // making a place to put scene
    [SerializeField]

    string SceneToLoad;
	
    // the proces of loading the scene you inserted in the serializefield
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
