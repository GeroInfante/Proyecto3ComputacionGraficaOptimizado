using UnityEngine;
using UnityEngine.UI; // Si usas un UI Image

public class GifAnimator : MonoBehaviour
{
    public Texture2D[] frames; // Asigna tus texturas en el Inspector
    public float framesPerSecond = 10.0f;

    private Renderer renderer;
    private Image image; // Si usas un UI Image

    void Start()
    {
        renderer = GetComponent<Renderer>();
        image = GetComponent<Image>();
    }

    void Update()
    {
        int index = (int)(Time.time * framesPerSecond) % frames.Length;
        if (renderer != null)
        {
            renderer.material.mainTexture = frames[index];
        }
        if (image != null)
        {
            image.sprite = Sprite.Create(frames[index], new Rect(0, 0, frames[index].width, frames[index].height), new Vector2(0.5f, 0.5f));
        }
    }
}
