using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private GameObject finishLineUI;
    [SerializeField] private GameObject backgroundUI;
    private PlayerInputActions playerInputActions;
    public bool reachedFinish = false;

    public FinishLine(PlayerInputActions playerInputActions)
    {
        this.playerInputActions = playerInputActions;
    }

    private IEnumerator DelayedCommand(float delay, System.Action action)
    {
        yield return new WaitForSeconds(delay);
        action.Invoke();
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        float delayInSeconds = 2.0f;
        if (collision.CompareTag("Player"))
        {
            // if (Input.GetKeyDown(KeyCode.P))
            // {
            //     SceneManager.LoadScene("MainMenuScene");    
            // }
            finishLineUI.SetActive(true);
            backgroundUI.SetActive(true);
            AudioListener.pause = true;
            // Time.timeScale = 0;
            reachedFinish = true;
            
            // wait seconds then go to the next scene
            StartCoroutine(DelayedCommand(delayInSeconds, () =>
            {
                AudioListener.pause = false;
                if ((SceneManager.GetActiveScene().buildIndex + 1) < SceneManager.sceneCountInBuildSettings)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
                else
                {
                    SceneManager.LoadScene("MainMenuScene");
                }
                // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }));

            // Time.timeScale = 0;
            // switch to UI input map
            // if (Input.GetKeyDown(KeyCode.Keypad9))
            // {
            //     SceneManager.LoadScene(0);
            // }
        }

            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    void OnEnd(InputAction.CallbackContext context)
    {
        // check if player is pressing the enter button and if so load the next scene
        if (context.performed)
        {
            SceneManager.LoadScene("MainMenuScene");
        }
    }
}
