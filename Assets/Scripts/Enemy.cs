using System.Collections;
using UnityEngine;

public class Enemy : Token
{

    //アニメーション用のスプライト
    public Sprite spr0;

    public Sprite spr1;

    int tAnim = 0;

    void FixedUpdate()
    {
        tAnim++;
        if (tAnim % 32 < 16)
        {
            SetSprite(spr0);
        }
        else
        {
            SetSprite(spr1);
        }
    }

}
