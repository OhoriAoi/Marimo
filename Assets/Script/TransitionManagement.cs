using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManagement : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); //ロード後もこのオブジェクトを消さない
    }

    private enum TransitionMode
    {
        TitleMode,      //タイトル画面
        SelectStageMode,   //ステージ選択画面  
        Stage1Mode,//ステージ1画面
        Stage2Mode,//ステージ2画面
        Stage3Mode,//ステージ3画面
        Stage4Mode,//ステージ4画面
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
    }

    private void ToSelectStage()//ステージ選択画面へ移動する関数
    {
        SceneManager.LoadScene("SelectStage");//ステージ選択画面へ移動
        transitionMode = TransitionMode.SelectStageMode;//ステージ選択画面 
    }

    public void ToStage1()//ステージ1画面へ移動する関数
    {
        SceneManager.LoadScene("Stage1");//ステージ1画面へ移動
        transitionMode = TransitionMode.Stage1Mode;//ステージ選択画面 
    }
    public void ToStage2()//ステージ2画面へ移動する関数
    {
        SceneManager.LoadScene("Stage2");//ステージ2画面へ移動
        transitionMode = TransitionMode.Stage2Mode;//ステージ選択画面 
    }
    public void ToStage3()//ステージ3画面へ移動する関数
    {
        SceneManager.LoadScene("Stage3");//ステージ3画面へ移動
        transitionMode = TransitionMode.Stage3Mode;//ステージ選択画面 
    }
    public void ToStage4()//ステージ4画面へ移動する関数
    {
        SceneManager.LoadScene("Stage4");//ステージ4画面へ移動
        transitionMode = TransitionMode.Stage4Mode;//ステージ選択画面 
    }
}
