using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectStage : MonoBehaviour
{
    public List<bool> Stage = new List<bool>();//�ǂ̃X�e�[�W��I�񂾂��𔻒肷�郊�X�g
    private int NumberOfStages;//�X�e�[�W�̐�

    private void Start()
    {
        NumberOfStages = 1;//�X�e�[�W����1
        for(int Lp = 0; Lp < NumberOfStages; Lp++)//�X�e�[�W�̐������J��Ԃ�
        {
            Stage[Lp] = false;//�X�e�[�W�̑I���̏�����
        }
    }
    public void ToStage1()//01�{�^���������ꂽ���̊֐�
    {
        Stage[0] = true;//�X�e�[�W�P�������ꂽ����
    }
}
