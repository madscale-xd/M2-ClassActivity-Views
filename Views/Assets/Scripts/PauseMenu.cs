using UnityEngine;
using UnityEngine.SceneManagement;  // To load the menu scene
using UnityEngine.UI;              // For UI button functionality

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuCanvas;  // Reference to the Pause Menu Canvas (assign in inspector)
    [SerializeField] private Button resumeButton;         // Reference to the Resume Button (assign in inspector)
    [SerializeField] private Button menuButton;           // Reference to the Menu Button (assign in inspector)
    private bool isPaused = false;

    void Start()
    {
        // Initially, set the pause menu canvas to inactive
        pauseMenuCanvas.SetActive(false);

        // Set up button listeners
        resumeButton.onClick.AddListener(ResumeGame);
        menuButton.onClick.AddListener(LoadMenu);
    }

    void Update()
    {

        // Listen for Escape key to toggle pause state
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();  // If paused, resume the game
            }
            else
            {
                PauseGame();   // If not paused, pause the game
            }
        }
    }

    void PauseGame()
    {
        // Activate the pause menu canvas and make it visible
        pauseMenuCanvas.SetActive(true);

        // Pause the game
        Time.timeScale = 0;
        isPaused = true;
    }

    void ResumeGame()
    {
        pauseMenuCanvas.SetActive(false);

        // Resume the game
        Time.timeScale = 1;
        isPaused = false;
    }

    void LoadMenu()
    {
        // Resume the game time before loading the scene
        Time.timeScale = 1;

        // Load the menu scene
        SceneManager.LoadScene("View");  // Replace "MainMenu" with your actual menu scene name
    }
}