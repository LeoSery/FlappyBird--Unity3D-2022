using UnityEngine;

public class Spawn : MonoBehaviour
{
    [Header("Managers :")]
    public GameManager GameManager;

    [Header("Prefabs :")]
    public GameObject prefab;

    [Header("Parameters :")]
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(SpawnPipe), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(SpawnPipe));
    }

    private void SpawnPipe()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
        pipes.transform.position = new Vector3(pipes.transform.position.x, pipes.transform.position.y, 1f);
    }
}
