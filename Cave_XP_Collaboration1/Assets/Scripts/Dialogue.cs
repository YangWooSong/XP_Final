using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    List<string> Scene1clue = new List<string>() { "도움 될만한 내용은 없네…", "큰 의미 없는 그림인 거 같아", "쿠션? 이런 거 볼 시간이 없어", "아무리 봐도 평범한 장난감이네" };
    List<string> Scene1_2clue = new List<string>() { "love me… 일단 기억해 두자.", "장난감을 단서로 쓸 수는 없어", "러그에 피가 잔뜩 묻어있어.. A의 피인가..?", " 그림을 그리고 있었나? 하지만 중요하지 않아.", "괴물을 그린 그림인가..? 하지만 찢어져서 보이지 않아.", "손톱자국이 있어. 괴물의 짓인가?", " 날 사랑해줘. 삐뚤빼뚤한 글씨가 가득하다.. 벽의 낙서와 같은 뜻이야. (확인 필요!)" };
    List<string> Scene2clue = new List<string>() { " 잠겨있다, 풀어볼 수 있을 것 같아", "제어 장치야, 내가 할 수 있는 건 없어", "흔히 볼 수 있는 의자. 특별한 건 보이지 않아", "괴물의 자료인가? 이 방의 괴물 자료는 아닌거 같은데…", "연구 보고서의 일부분 같은데..", "지금 필요한 건 없어", "도움 될만한 건 없어 보여" };
    List<string> Scene3clue = new List<string>() { "필요 없는 자료인 거 같네", "보고서 작성용 종이인가?", "연구용품이야… 건드릴필요는 없을 것 같아" };
    List<string> mainClue = new List<string>() { "내 사원증이 여기 있었네, 이걸로 문을 열 수 있을 거야", "이건 내 발자국? 내 발자국이 왜 여기있지.. 이건 나에게 불리한 단서야 없애야 해!", "윽 팔이.. 지퍼 모양으로 잘려있어. 손바닥에 이 하트 문양은 뭐지?", "이건 무슨 발자국이지? 곰.. 아니 둥근 게 꼭 인형 같아.", "이게 있으면 내 지문이 묻은 단서들을 닦을 수 있겠어. 그렇지 않으면 범인으로 몰릴지도 몰라.", "윽 피가 잔뜩 묻었네. 흉기인가 챙겨 가봐야겠어. 엇 맨손으로 잡으면 내 지문이 묻을 텐데!" };
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
