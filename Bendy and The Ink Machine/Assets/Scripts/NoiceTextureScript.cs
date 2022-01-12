using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiceTextureScript : MonoBehaviour
{
    public int width = 256;
    public int height =  256;

    public float scale = 20f;
    public float OffsetX = 100f;
    public float OffsetY = 100f;


    private void Update()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = GenerateTexture();
    }

    Texture2D GenerateTexture()
    {
        Texture2D Texture = new Texture2D(width, height);

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Color color = CalculateColor(x, y);
                Texture.SetPixel(x, y, color);
            }
        }

        Texture.Apply();
        return Texture;

        Color CalculateColor(int x, int y)
        {
            float xCoord = (float)x / width * scale + OffsetX;
            float yCoord = (float)y / height * scale + OffsetY;

            float sample = Mathf.PerlinNoise(xCoord, yCoord);
            return new Color(sample, sample, sample);
        }
    }
}
