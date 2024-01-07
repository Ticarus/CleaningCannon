using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Score")]
    [SerializeField] int scoreValue;

    [Header("Sprites")]
    [SerializeField] Sprite dirtySprite;
    [SerializeField] Sprite cleanSprite;

    SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = FindObjectOfType<SpriteRenderer>();
    }

    public void SetSprite(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
    }

    public Sprite GetCleanSprite()
    {
        return cleanSprite;
    }

    public int GetScoreValue()
    {
        return scoreValue;
    }
}
