using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManagement : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); //���[�h������̃I�u�W�F�N�g�������Ȃ�
    }

    private enum TransitionMode
    {
        TitleMode,      //�^�C�g�����
        SelectStageMode,   //�X�e�[�W�I�����  
        Stage1Mode,//�X�e�[�W1���
        Stage2Mode,//�X�e�[�W2���
        Stage3Mode,//�X�e�[�W3���
        Stage4Mode,//�X�e�[�W4���
    }

    TransitionMode transitionMode;//��ʃ��[�h�̕ϐ�

    // Start is called before the first frame update
    void Start()
    {
        transitionMode = TransitionMode.TitleMode;//�^�C�g�����
    }

    // Update is called once per frame
    void Update()
    {
        if (transitionMode == TransitionMode.TitleMode)//�^�C�g����ʂ̏ꍇ
        {
            if (Input.GetKeyDown(KeyCode.Return))//�G���^�[�������ꂽ�ꍇ
            {
                ToSelectStage();//�X�e�[�W�I����ʂֈړ�����֐�
            }
        }
    }

    private void ToSelectStage()//�X�e�[�W�I����ʂֈړ�����֐�
    {
        SceneManager.LoadScene("SelectStage");//�X�e�[�W�I����ʂֈړ�
        transitionMode = TransitionMode.SelectStageMode;//�X�e�[�W�I����� 
    }

    public void ToStage1()//�X�e�[�W1��ʂֈړ�����֐�
    {
        SceneManager.LoadScene("Stage1");//�X�e�[�W1��ʂֈړ�
        transitionMode = TransitionMode.Stage1Mode;//�X�e�[�W�I����� 
    }
    public void ToStage2()//�X�e�[�W2��ʂֈړ�����֐�
    {
        SceneManager.LoadScene("Stage2");//�X�e�[�W2��ʂֈړ�
        transitionMode = TransitionMode.Stage2Mode;//�X�e�[�W�I����� 
    }
    public void ToStage3()//�X�e�[�W3��ʂֈړ�����֐�
    {
        SceneManager.LoadScene("Stage3");//�X�e�[�W3��ʂֈړ�
        transitionMode = TransitionMode.Stage3Mode;//�X�e�[�W�I����� 
    }
    public void ToStage4()//�X�e�[�W4��ʂֈړ�����֐�
    {
        SceneManager.LoadScene("Stage4");//�X�e�[�W4��ʂֈړ�
        transitionMode = TransitionMode.Stage4Mode;//�X�e�[�W�I����� 
    }
}
