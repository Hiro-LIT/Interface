using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyGoblin : MonoBehaviour, IDamagable
{
    // キャラクターのHPを代入する変数
    public int hp = 100;
    // 残りHPを表示するテキスト
    [SerializeField] Text hpText;

    /// <summary>
    /// HPの値をHpへ表示するメソッド
    /// </summary>
    void DisplayHpValue()
    {
        hpText.text = "HP: " + hp.ToString();
    }
    public void AddDamage()
    {
        int damage = Random.Range(0, 21);
        hp -= damage;
        DisplayHpValue();
    }
}
