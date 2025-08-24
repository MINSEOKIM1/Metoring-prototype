using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Monster : MonoBehaviour
{
    public float maxHP = 100;
    private float currentHP;
    public Image HPImage;
    void Start()
    {
        currentHP = maxHP;

        if (HPImage != null)
            HPImage.fillAmount = 1f; // 시작시 풀 체력
    }

    public void Damaged(int power)
    {
        currentHP -= power;
        currentHP = Mathf.Clamp(currentHP, 0, maxHP);

        // 체력바 UI 갱신
        if (HPImage != null)
            HPImage.fillAmount = currentHP / maxHP;

        Debug.Log(currentHP);

        if (currentHP <= 0)
        {
            DieMonster();
        }

    }
    void DieMonster()
    {
        GameObject.Find("GameManager").GetComponent<Request>().nextButton();

        Debug.Log($"{gameObject.name} 사망!");
        Invoke("Destroy(gameObject)",1f);

    }

}
