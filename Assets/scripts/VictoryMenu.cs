using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class VictoryMenu : MonoBehaviour
{
    public GameObject victoryMenuUI;
    public TextMeshProUGUI time;

    public PlayerMovement stopMouse;
    public bulletScript stopShooting;
    public TimeController displayTime;
    // Start is called before the first frame update
    void Start() //Gathering scripts so we can control them later on
    {
        stopMouse = FindObjectOfType<PlayerMovement>();
        stopShooting = FindObjectOfType<bulletScript>();
        displayTime = FindObjectOfType<TimeController>();
    }

   

    public void victory() //Stopping time and ability too shoot and taking the time and displaying it
    {
        Time.timeScale = 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        victoryMenuUI.SetActive(true);

        stopMouse.sensitivity = 0f;
        stopShooting.canShoot = false;

        time.SetText(displayTime.timeCounter.text);
    }

    public void restartGame() //Restarting the level from the start and restarting time
    {

        // Cursor.lockState = CursorLockMode.Locked;
        print(Time.timeScale);
        Time.timeScale = 1f;
        print(Time.timeScale);
        print("GameResethjgjg");
        victoryMenuUI.SetActive(false);
        //stopMouse.sensitivity = 50f;
        stopShooting.canShoot = true;
        SceneManager.LoadScene("Level-1");
        
    }
}
