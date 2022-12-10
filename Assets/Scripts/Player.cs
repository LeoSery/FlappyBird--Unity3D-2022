using UnityEngine;

public class Player : MonoBehaviour
{
    public MainMenu mainMenu;

    private Vector3 direction;
    public float gravity = -9.8f;
    public int strength = 5;

    private SpriteRenderer spriteRenderer;
    public Sprite[] spriteArr;
    private int spriteIndex;

    public void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            direction = Vector3.up * strength;
        }
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }

    public void Start()
    {
        InvokeRepeating(nameof(changeRenderSprite), 0.15f, 0.15f);
    }

    public void changeRenderSprite()
    {
        spriteIndex++;

        if (spriteIndex >= spriteArr.Length)
        {
            spriteIndex = 0;
        }
        if (direction.y > 0)
        {
            spriteRenderer.sprite = spriteArr[spriteIndex];
        }
        else
        {
            spriteRenderer.sprite = spriteArr[0];
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Pipe" || other.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().GameOver();
            Debug.Log("Call GameOver();");
        }
        else if (other.gameObject.tag == "ScoreZone")
        {
            FindObjectOfType<GameManager>().IncreaseScore();
            Debug.Log("Call IncreaseScore();");
        }
    }
}
