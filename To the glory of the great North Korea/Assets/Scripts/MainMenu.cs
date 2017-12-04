﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public SceneFade sceneFade;

	public string levelToLoad = "Main";

	public void StartGame()
	{
		sceneFade.FadeTo(levelToLoad);
	}

	public void Options()
	{

	}

	public void Quit()
	{
		Application.Quit();
	}
}