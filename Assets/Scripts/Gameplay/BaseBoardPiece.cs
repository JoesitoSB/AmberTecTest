using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseBoardPiece : MonoBehaviour
{
    protected Vector2 id = Vector2.zero;
    [SerializeField] private SpriteRenderer spriteRenderer = null;

    public Vector2 GetSize()
    {
        return spriteRenderer.bounds.size;
    }

    public void Init(Vector2 id)
    {
        this.id = id;        
    }
}
