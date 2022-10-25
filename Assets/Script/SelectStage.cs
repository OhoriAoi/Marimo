using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectStage : MonoBehaviour
{
    private TransitionManagement transitionManagement;//��ʑJ�ڂ��Ǘ�����X�N���v�g

    public List<bool> Stage = new List<bool>();//�ǂ̃X�e�[�W��I�񂾂��𔻒肷�郊�X�g
    private int NumberOfStages;//�X�e�[�W�̐�

    private void Start()
    {
        transitionManagement = GameObject.FindGameObjectWithTag("GameControl").GetComponent<TransitionManagement>();//GameConrol�ɓ����Ă����ʑJ�ڂ��Ǘ�����X�N���v�g���Q��

        NumberOfStages = 4;//�X�e�[�W����4

        for (int Lp = 0; Lp < NumberOfStages; Lp++)//�X�e�[�W�̐������J��Ԃ�
        {
            Stage.Add(false);//�X�e�[�W�̑I���̏�����
        }
    }
    public void ToStage1()//01�{�^���������ꂽ���̊֐�
    {
        Stage[0] = true;//�X�e�[�W�P�������ꂽ����
        transitionManagement.ToStage1();//�X�e�[�W1�ֈړ�����֐�
    }
    public void ToStage2()//02�{�^���������ꂽ���̊֐�
    {
        Stage[1] = true;//�X�e�[�W2�������ꂽ����
        transitionManagement.ToStage2();//�X�e�[�W2�ֈړ�����֐�
    }
    public void ToStage3()//03�{�^���������ꂽ���̊֐�
    {
        Stage[2] = true;//�X�e�[�W�P�������ꂽ����
        transitionManagement.ToStage3();//�X�e�[�W3�ֈړ�����֐�
    }
    public void ToStage4()//01�{�^���������ꂽ���̊֐�
    {
        Stage[3] = true;//�X�e�[�W�P�������ꂽ����
        transitionManagement.ToStage4();//�X�e�[�W4�ֈړ�����֐�
    }
}
