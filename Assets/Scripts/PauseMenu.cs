using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //public PlayerInput playerInput;
    public InputActionReference togglePauseAction;
    [SerializeField] private GameObject pauseCanvas;
    [SerializeField] private bool isPaused;
    void Awake()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        // if (isPaused && pauseCanvas != null)
        // {
        //     Cursor.lockState = CursorLockMode.None;
        //     Cursor.visible = true;
        // }
        // else
        // {
        //     Cursor.lockState = CursorLockMode.Locked;
        //     Cursor.visible = false;
        // }
    }

    public void Resume()
    {
        // playerInput.actions.Disable();
        // playerInput.SwitchCurrentActionMap("Player");
        pauseCanvas.SetActive(false);
        AudioListener.pause = false;
        Time.timeScale = 1;
        isPaused = false;
    }

    void Pause()
    {
        //playerInput.actions.Enable();
        // playerInput.SwitchCurrentActionMap("UI");
        pauseCanvas.SetActive(true);
        AudioListener.pause = true;
        Time.timeScale = 0;
        isPaused = true;
    }

    // void TogglePause(InputAction.CallbackContext context)
    // {
    //     isPaused = !isPaused;
    //     pauseCanvas.SetActive(isPaused);
    //     Time.timeScale = isPaused ? 0f : 1f;
    // }
    //
    // private void OnEnable()
    // {
    //     togglePauseAction.action.performed += TogglePause;
    // }
    //
    // private void OnDisable()
    // {
    //     togglePauseAction.action.performed -= TogglePause;
    // }

    // void ActivateMenu()
    // {
    //     Time.timeScale = 0;
    //     AudioListener.pause = true;
    //     pauseCanvas.SetActive(true);
    // }
    //
    // public void DeactivateMenu()
    // {
    //     Time.timeScale = 1;
    //     AudioListener.pause = false;
    //     pauseCanvas.SetActive(false);
    //     isPaused = false;
    // }

    public void MainMenu()
    {
        Debug.Log("Main Menu");
        Resume();
        SceneManager.LoadScene("MainMenuScene");
    }
    
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
