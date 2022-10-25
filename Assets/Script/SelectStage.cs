using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectStage : MonoBehaviour
{
    private TransitionManagement transitionManagement;//画面遷移を管理するスクリプト

    public List<bool> Stage = new List<bool>();//どのステージを選んだかを判定するリスト
    private int NumberOfStages;//ステージの数

    private void Start()
    {
        transitionManagement = GameObject.FindGameObjectWithTag("GameControl").GetComponent<TransitionManagement>();//GameConrolに入っている画面遷移を管理するスクリプトを参照

        NumberOfStages = 4;//ステージ数は4

        for (int Lp = 0; Lp < NumberOfStages; Lp++)//ステージの数だけ繰り返す
        {
            Stage.Add(false);//ステージの選択の初期化
        }
    }
    public void ToStage1()//01ボタンを押された時の関数
    {
        Stage[0] = true;//ステージ１を押された判定
        transitionManagement.ToStage1();//ステージ1へ移動する関数
    }
    public void ToStage2()//02ボタンを押された時の関数
    {
        Stage[1] = true;//ステージ2を押された判定
        transitionManagement.ToStage2();//ステージ2へ移動する関数
    }
    public void ToStage3()//03ボタンを押された時の関数
    {
        Stage[2] = true;//ステージ１を押された判定
        transitionManagement.ToStage3();//ステージ3へ移動する関数
    }
    public void ToStage4()//01ボタンを押された時の関数
    {
        Stage[3] = true;//ステージ１を押された判定
        transitionManagement.ToStage4();//ステージ4へ移動する関数
    }
}
