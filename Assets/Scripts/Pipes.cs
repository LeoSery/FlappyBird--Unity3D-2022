using UnityEngine;

public class Pipes : MonoBehaviour
{
    public GameManager GameManager;
    public float speed = 5f;
    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        // if (GameManager.difficultyMultiplier != 0)
        // {
        //     Debug.LogWarning("New pipes speed set !");
        //     speed += GameManager.difficultyMultiplier;
        // }
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }

    // public void SetNewPipeSpeed()
    // {
    //     if (GameManager.difficultyMultiplier != 0)
    //     {
    //         Debug.LogWarning("New pipes speed set !");
    //         speed += GameManager.difficultyMultiplier;
    //     }
    // }     
}
