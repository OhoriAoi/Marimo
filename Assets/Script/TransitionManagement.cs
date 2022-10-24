using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManagement : MonoBehaviour
{
    private SelectStage selectStage;//ステージを選ぶスクリプト

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); //ロード後もこのオブジェクトを消さない
    }

    private enum TransitionMode
    {
        TitleMode,      //タイトル画面
        SelectStageMode,   //ステージ選択画面  
        Stage1Mode,//ステージ1画面
    }

    TransitionMode transitionMode;//画面モードの変数

    // Start is called before the first frame update
    void Start()
    {
        transitionMode = TransitionMode.TitleMode;//タイトル画面
    }

    // Update is called once per frame
    void Update()
    {
        if (transitionMode == TransitionMode.TitleMode)//タイトル画面の場合
        {
            if (Input.GetKeyDown(KeyCode.Return))//エンターが押された場合
            {
                ToSelectStage();//ステージ選択画面へ移動する関数
            }
        }
        if (selectStage.Stage[0])//ステージ1が選択された場合
        {
            ToStage1();//ステージ1画面へ移動する関数
        }
    }

    private void ToSelectStage()//ステージ選択画面へ移動する関数
    {
        SceneManager.LoadScene("SelectStage");//ステージ選択画面へ移動
        transitionMode = TransitionMode.SelectStageMode;//ステージ選択画面 //ステージ1画面へ移動する関数
        selectStage = GameObject.FindGameObjectWithTag("SelectStageControl").GetComponent<SelectStage>();
    }

    private void ToStage1()//ステージ1画面へ移動する関数
    {
        SceneManager.LoadScene("Stage1");//ステージ1画面へ移動
        transitionMode = TransitionMode.Stage1Mode;//ステージ選択画面 
    }
}
