using System.Collections;
using UnityEngine;

public class Field : Token
{
    // Start is called before the first frame update
    void Start()
    {
        //マップ読み込み
        TMXLoader tmx = new TMXLoader();
        tmx.Load("Levels/map");

        //経路レイヤーを取得
        Layer2D path = tmx.GetLayer("path");
        //デバッグ出力
        path.Dump();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
