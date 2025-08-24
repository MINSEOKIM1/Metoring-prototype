using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Request : MonoBehaviour
{
    bool isstart;

    [SerializeField]
    public GameObject SelectButton;
    public GameObject SelectImage;


    public GameObject SuccessImage;
    public GameObject FailedImage;
    void Start()
    {
        isstart = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            SuccesQuest();
        }
    }

    public void QusetStart()
    {
        if (isstart) return;
        //�̼� �����ϱ�
        //StartCoroutine(ShowAndHide(SelectImage));
        SelectImage.SetActive(true);
       isstart = true;

    }

    public void SuccesQuest()
    {
        Debug.Log("�̼� ����");
        isstart = false;
        StartCoroutine(ShowAndHide(SuccessImage));
        SceneManager.LoadScene(1);

    }

    public void FailedQuest()
    {
        Debug.Log("�̼� ����");
        isstart = false;
        StartCoroutine(ShowAndHide(FailedImage));
        SceneManager.LoadScene(1);

    }

    private IEnumerator ShowAndHide(GameObject obj)
    {
        obj.SetActive(true);
        yield return new WaitForSeconds(1f);
        obj.SetActive(false);
    }
}
