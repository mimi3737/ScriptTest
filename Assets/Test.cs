using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53; //���@�U��


    // MAGIC�֐�
    public void MAGICK()
    {
        if(mp >=5)
        {
            //mp��5�ȏ�̏ꍇ
            this.mp -= 5;
            Debug.Log("���@�U���������B�c���MP��" + mp);
            

        }
        else
        {
            //mp������Ȃ��ꍇ
            
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B" );

        }
    }


}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        
       
        // 10�񏈗����J��Ԃ�
        for (int i = 0; i <= 10; i++)
        {
            // MAGIC�p�̊֐����Ăяo��
            lastboss.MAGICK();
     
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
