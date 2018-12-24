using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {

    public int numberScene;

	public void RestartLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(numberScene);
    }

}
