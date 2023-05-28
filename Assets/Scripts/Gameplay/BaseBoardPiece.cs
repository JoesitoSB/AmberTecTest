using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseBoardPiece : MonoBehaviour
{
    protected Vector2 id = Vector2.zero;
    [SerializeField] private SpriteRenderer spriteRenderer;

    public Vector2 GetSize()
    {
        return spriteRenderer.bounds.size;
    }

    public void Init(Vector2 id)
    {
        this.id = id;
        //PutInPlace(pos.x, pos.y);
    }

    /*private void PutInPlace(float xPos, float yPos)
    {
        transform.SetLocalPositionAndRotation(new Vector3(xPos, yPos, 0), Quaternion.Euler(0, 0, 0));
    }*/
}
