using UnityEngine;

public class Parallax : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public float scrollSpeed;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0f);
    }
}
