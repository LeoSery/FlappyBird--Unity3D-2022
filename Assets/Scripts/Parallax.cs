using UnityEngine;

public class Parallax : MonoBehaviour
{
    [Header("Parameters :")]
    public float scrollSpeed;

    [Header("Graphics :")]
    public MeshRenderer meshRenderer;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0f);
    }
}
