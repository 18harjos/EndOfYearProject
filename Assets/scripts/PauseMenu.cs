 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
	public static bool GameIsPaused = false;
	public AudioMixer audioMixer;
	public PlayerMovement stopMouse;
	public bulletScript stopShooting;

	public GameObject pauseMenuUI;

	
	public void Start() //Getting the scripts that control the moust and ability to shoot
	{
		stopMouse = FindObjectOfType<PlayerMovement>();
		stopShooting = FindObjectOfType<bulletScript>();
	}

	public void SetVolume(float volume){ //setting the volume of the game
		audioMixer.SetFloat("volume", volume);
	} 

	
	void Update() { //checking wether or not the escape key has been pressed
		if (Input.GetKeyDown(KeyCode.Escape)){
			if (GameIsPaused){
				Resume();
			} else {
				Pause();
			}
		}
	}

	public void Resume() { //restarting time and allowing for movement and shooting
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
		Cursor.lockState = CursorLockMode.Locked;

		stopMouse.sensitivity = 50f;
		stopShooting.canShoot = true;
	}

	void Pause() { //stopping time and preventing movement and shooting
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;

		stopMouse.sensitivity = 0f;
		stopShooting.canShoot = false;
	}

	public void LoadMenu() { //Loading the menu if the menu button is pressed
		SceneManager.LoadScene("Menu");
		Time.timeScale = 1f;
	}

	
}
