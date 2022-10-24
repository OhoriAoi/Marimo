using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManagement : MonoBehaviour
{
    private SelectStage selectStage;//�X�e�[�W��I�ԃX�N���v�g

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); //���[�h������̃I�u�W�F�N�g�������Ȃ�
    }

    private enum TransitionMode
    {
        TitleMode,      //�^�C�g�����
        SelectStageMode,   //�X�e�[�W�I�����  
        Stage1Mode,//�X�e�[�W1���
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
        if (selectStage.Stage[0])//�X�e�[�W1���I�����ꂽ�ꍇ
        {
            ToStage1();//�X�e�[�W1��ʂֈړ�����֐�
        }
    }

    private void ToSelectStage()//�X�e�[�W�I����ʂֈړ�����֐�
    {
        SceneManager.LoadScene("SelectStage");//�X�e�[�W�I����ʂֈړ�
        transitionMode = TransitionMode.SelectStageMode;//�X�e�[�W�I����� //�X�e�[�W1��ʂֈړ�����֐�
        selectStage = GameObject.FindGameObjectWithTag("SelectStageControl").GetComponent<SelectStage>();
    }

    private void ToStage1()//�X�e�[�W1��ʂֈړ�����֐�
    {
        SceneManager.LoadScene("Stage1");//�X�e�[�W1��ʂֈړ�
        transitionMode = TransitionMode.Stage1Mode;//�X�e�[�W�I����� 
    }
}
