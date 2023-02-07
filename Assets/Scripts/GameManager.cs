using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 敵関係のゲームオブジェクトをアタッチする配列
    public GameObject[] Enemys;
    // プレイヤー関係のゲームオブジェクトをアタッチする配列
    public GameObject[] Players;

    GameObject target;

    /// <summary>
    /// Player側の攻撃を行う際に呼び出すメソッド
    /// </summary>
    public void PlayerAttack()
    {
        target = Enemys[Random.Range(0, Enemys.Length)];
        target.GetComponent<IDamagable>()
            .AddDamage();
    }

    /// <summary>
    /// Enemy側の攻撃を行う際に呼び出すメソッド
    /// </summary>
    public void EnemyAttack()
    {
        target = Players[Random.Range(0, Enemys.Length)];
        target.GetComponent<IDamagable>()
            .AddDamage();
    }

    /// <summary>
    /// プレイヤーを回復させる際に呼び出すメソッド
    /// </summary>
    public void PlayerHeal()
    {
        for (int i = 0; i < Players.Length; i++)
        {
            target = Players[i];
            target.GetComponent<IHealable>().AddHp(10);
        }
    }
}
