using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class backpress : MonoBehaviour {

    public string MainMenu;

	// Update is called once per frame

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(MainMenu);
        }
	}

}