using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVideoScript : MonoBehaviour
{

    public Texture2D[] frames;
    public float framesPerSecond = 10.0f;

    private MeshRenderer renderer;

    private void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        float index = Time.time * framesPerSecond;
        index = index % frames.Length;
        renderer.material.mainTexture = frames[(int)index];
    }
}
