using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject player;
    private SpriteRenderer spriteRenderer;
    public bool isOnMainMenu = false;
    public Sprite[] spriteArr;
    private int spriteIndex;

    void Awake()
    {
        spriteRenderer = player.GetComponent<SpriteRenderer>();
        isOnMainMenu = true;
        Time.timeScale = 1f;
    }

    public void Start()
    {
        InvokeRepeating(nameof(FlappingWingsBird), 0.15f, 0.15f);
    }

   void FlappingWingsBird()
   {
        if (isOnMainMenu)
        {
            spriteIndex++;
            if (spriteIndex >= spriteArr.Length)
                spriteIndex = 0;
            if (spriteIndex <= spriteArr.Length)
                spriteRenderer.sprite = spriteArr[spriteIndex];
            else
                spriteRenderer.sprite = spriteArr[0];
        }
   }

   public void PlayGame()
   {
        SceneManager.LoadScene("Game");
   }

   public void QuitGame()
   {
        Debug.LogWarning("Closing the game... (not visible in the editor)");
        Application.Quit();
   }
}
