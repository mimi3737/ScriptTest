using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53; //魔法攻撃


    // MAGIC関数
    public void MAGICK()
    {
        if(mp >=5)
        {
            //mpが5以上の場合
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りのMPは" + mp);
            

        }
        else
        {
            //mpが足りない場合
            
            Debug.Log("MPが足りないため、魔法が使えない。" );

        }
    }


}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        
       
        // 10回処理を繰り返す
        for (int i = 0; i <= 10; i++)
        {
            // MAGIC用の関数を呼び出す
            lastboss.MAGICK();
     
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
