using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Player :")]
    public GameObject Player;

    [Header("Managers / Scripts :")]
    public GameObject SpawnManager;
    public MainMenu MainMenu;

    [Header("Overlay :")]
    private TextMeshProUGUI scoreText;
    public GameObject overlayGameOver;
    public GameObject scoreObject;
    public GameObject playButton;

    [HideInInspector] public Parallax backgroundParallax;
    [HideInInspector] public Parallax groundParallax;
    [HideInInspector] public bool isOnGame = false;
    
    private Pipes[] pipes; 
    private int score;

    void Awake()
    {
        scoreText = scoreObject.GetComponent<TextMeshProUGUI>();
        isOnGame = true;

        if (MainMenu.isOnMainMenu)
        {
            MainMenu.isOnMainMenu = false;
            ReplayGame();
        }

        Application.targetFrameRate = 120;
        Player.SetActive(false);
        ResetScore();
        ReplayGame();
    }

    public void ReplayGame()
    {
        Player.transform.position = new Vector3(0f,0f,1f);
        Time.timeScale = 1f;
        isOnGame = true;

        overlayGameOver.SetActive(false);
        playButton.SetActive(false);
        scoreObject.SetActive(true);
        Player.SetActive(true);
        ResetScore();

        pipes = FindObjectsOfType<Pipes>();
        for (int i=0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void GameOver()
    {
        overlayGameOver.SetActive(true);
        playButton.SetActive(true);
        isOnGame = false;
        WaitingRestart();
    }

    public void WaitingRestart()
    {
        Time.timeScale = 0f;
        isOnGame = false;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
}
