using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelManager : MonoBehaviour
{
   public static LevelManager instance;

   public Transform respawnPoint;
   public GameObject playerPrefab;
   public PlayerInput playerInput;
   [SerializeField] private GameObject cardHolder;
   [SerializeField] private bool pauseGame;
   [SerializeField] private GameObject pauseCanvas;
   public static bool gameIsPaused = false;
   public bool pauseKeyPressed;

   private void Awake()
   {
      instance = this; // make global instance
      
   }

   public void Respawn()
   {
      // Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
   }

   private void Update()
   {
      // PauseGame();
   }

   // void PauseGame()
   // {
   //    if (Input.GetKeyDown(KeyCode.Escape))
   //    {
   //       if (gameIsPaused)
   //       {
   //          Resume();
   //       }
   //       else
   //       {
   //          Pause();
   //       }
   //    }
   // }

   public void Pause()
   {
      playerInput.actions.Disable();
      pauseCanvas.SetActive(true);
      Time.timeScale = 0f;
      AudioListener.pause = true;
      gameIsPaused = true;
   }

   public void Resume()
   {
      playerInput.actions.Enable();
      pauseCanvas.SetActive(false);
      Time.timeScale = 1f;
      AudioListener.pause = false;
      gameIsPaused = false;
   }
}
