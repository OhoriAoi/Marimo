using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectStage : MonoBehaviour
{
    public List<bool> Stage = new List<bool>();//どのステージを選んだかを判定するリスト
    private int NumberOfStages;//ステージの数

    private void Start()
    {
        NumberOfStages = 1;//ステージ数は1
        for(int Lp = 0; Lp < NumberOfStages; Lp++)//ステージの数だけ繰り返す
        {
            Stage[Lp] = false;//ステージの選択の初期化
        }
    }
    public void ToStage1()//01ボタンを押された時の関数
    {
        Stage[0] = true;//ステージ１を押された判定
    }
}
