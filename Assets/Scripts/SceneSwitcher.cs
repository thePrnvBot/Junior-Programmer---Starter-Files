using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public Scene nextScene;

	public void ChangeScene(string nextScene)
	{
		SceneManager.LoadScene(nextScene);
	}

	public void Exit()
	{
		Application.Quit();
	}
}
