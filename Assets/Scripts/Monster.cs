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
            HPImage.fillAmount = 1f; // ���۽� Ǯ ü��
    }

    public void Damaged(int power)
    {
        currentHP -= power;
        currentHP = Mathf.Clamp(currentHP, 0, maxHP);

        // ü�¹� UI ����
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

        Debug.Log($"{gameObject.name} ���!");
        Invoke("Destroy(gameObject)",1f);

    }

}
