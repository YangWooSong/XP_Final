using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MiniGameTimer : MonoBehaviour
{
    //시간 15초 임의 설정
    public static float timeDuration=20f;         //최대 시간
    private float timer;

    [SerializeField]
    private TextMeshProUGUI firstMinute;
    [SerializeField]
    private TextMeshProUGUI secondMinute;
    [SerializeField]
    private TextMeshProUGUI seperator;
    [SerializeField]
    private TextMeshProUGUI firstSecond;
    [SerializeField]
    private TextMeshProUGUI secondSecond;
    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        timeDuration -= Time.deltaTime;
        //Debug.Log(MemorytimeDuration);
        if (timer > 11f)
        {
            timer -= Time.deltaTime;
            UpdateTimerDisplay(timer);
        }
        //10초부터 빨간색으로 변환
        else if (timer >= 0f)
        {
            ColorChange();
            timer -= Time.deltaTime;
            UpdateTimerDisplay(timer);
        }
        //타이머가 음수일 경우 방지
        if (timer < 0f)
        {
            timer = 0;
            UpdateTimerDisplay(timer);
        }
    }
    private void ResetTimer()
    {
        timer = timeDuration;
    }
    private void ColorChange()
    {
        firstMinute.color = Color.red;
        secondMinute.color = Color.red;
        seperator.color = Color.red;
        firstSecond.color = Color.red;
        secondSecond.color = Color.red;
    }
    private void UpdateTimerDisplay(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        string currentTime = string.Format("{00:00}{1:00}", minutes, seconds);
        firstMinute.text = currentTime[0].ToString();
        secondMinute.text = currentTime[1].ToString();
        firstSecond.text = currentTime[2].ToString();
        secondSecond.text = currentTime[3].ToString();
    }
}
