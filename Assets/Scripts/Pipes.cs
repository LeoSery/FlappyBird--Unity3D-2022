using UnityEngine;

public class Pipes : MonoBehaviour
{
    [Header("Scripts :")]
    public GameManager GameManager;
    
    [Header("Parameters :")]
    public float speed = 5f;

    private float leftEdge;

    private void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < leftEdge)
            Destroy(gameObject);
    }   
}
