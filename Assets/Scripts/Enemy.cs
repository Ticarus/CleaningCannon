using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int scoreValue;
    [SerializeField] SpriteRenderer sprite;
    [SerializeField] SpriteRenderer dirtySprite;
    [SerializeField] SpriteRenderer cleanSprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Gate" && this.sprite == cleanSprite)
        {

        }
    }
}
