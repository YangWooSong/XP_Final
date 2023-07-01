using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    List<string> Scene1clue = new List<string>() { "���� �ɸ��� ������ ���ס�", "ū �ǹ� ���� �׸��� �� ����", "���? �̷� �� �� �ð��� ����", "�ƹ��� ���� ����� �峭���̳�" };
    List<string> Scene1_2clue = new List<string>() { "love me�� �ϴ� ����� ����.", "�峭���� �ܼ��� �� ���� ����", "���׿� �ǰ� �ܶ� �����־�.. A�� ���ΰ�..?", " �׸��� �׸��� �־���? ������ �߿����� �ʾ�.", "������ �׸� �׸��ΰ�..? ������ �������� ������ �ʾ�.", "�����ڱ��� �־�. ������ ���ΰ�?", " �� �������. �߶Ի����� �۾��� �����ϴ�.. ���� ������ ���� ���̾�. (Ȯ�� �ʿ�!)" };
    List<string> Scene2clue = new List<string>() { " ����ִ�, Ǯ� �� ���� �� ����", "���� ��ġ��, ���� �� �� �ִ� �� ����", "���� �� �� �ִ� ����. Ư���� �� ������ �ʾ�", "������ �ڷ��ΰ�? �� ���� ���� �ڷ�� �ƴѰ� ��������", "���� ������ �Ϻκ� ������..", "���� �ʿ��� �� ����", "���� �ɸ��� �� ���� ����" };
    List<string> Scene3clue = new List<string>() { "�ʿ� ���� �ڷ��� �� ����", "���� �ۼ��� �����ΰ�?", "������ǰ�̾ߡ� �ǵ帱�ʿ�� ���� �� ����" };
    List<string> mainClue = new List<string>() { "�� ������� ���� �־���, �̰ɷ� ���� �� �� ���� �ž�", "�̰� �� ���ڱ�? �� ���ڱ��� �� ��������.. �̰� ������ �Ҹ��� �ܼ��� ���־� ��!", "�� ����.. ���� ������� �߷��־�. �չٴڿ� �� ��Ʈ ������ ����?", "�̰� ���� ���ڱ�����? ��.. �ƴ� �ձ� �� �� ���� ����.", "�̰� ������ �� ������ ���� �ܼ����� ���� �� �ְھ�. �׷��� ������ �������� �������� ����.", "�� �ǰ� �ܶ� ������. ����ΰ� ì�� �����߰ھ�. �� �Ǽ����� ������ �� ������ ���� �ٵ�!" };
    public int d_num;
    public int sceneNum;

    public GameObject dialoguePanel;
    public TextMeshProUGUI text;
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        dialoguePanel = GameObject.Find("Dialogue");
        dialoguePanel.SetActive(false);
        btn = dialoguePanel.GetComponent<Transform>().GetChild(1).GetComponent<Button>();
        btn.onClick.AddListener(D_close);
        text = dialoguePanel.GetComponent<Transform>().GetChild(0).GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(sceneNum != 0)
        {
            dialoguePanel.SetActive(true);
            if (sceneNum == 1)
            {
                text.text = Scene1clue[d_num];
            }
            else if (sceneNum == 2)
            {
                text.text = Scene1_2clue[d_num];
            }
            else if (sceneNum == 3)
            {
                text.text = Scene2clue[d_num];
            }
            else if (sceneNum == 4)
            {
                text.text = Scene3clue[d_num];
            }
            else
            {
                text.text = mainClue[d_num];
            }
        }
        else dialoguePanel.SetActive(false);
    }

    public void D_close()
    {
        sceneNum = 0;
    }
}
