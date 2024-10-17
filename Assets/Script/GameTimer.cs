using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    //�J�E���g�_�E��
    public float countdown = 60.0f;

    //���Ԃ�\������Text�^�̕ϐ�
    public TextMeshProUGUI timeText;

    public bool isPaused = true;

    // Update is called once per frame
    void Update()
    {
        //���Ԃ�\������
        timeText.text = countdown.ToString("f2");
        if(isPaused)
        {
            return;
        }
        //���Ԃ��J�E���g�_�E������
        countdown -= Time.deltaTime;


        //countdown��0�ȉ��ɂȂ����Ƃ�
        if (countdown <= 0)
        {
            SceneManager.LoadScene("Result");
        }
    }

    public void StartTimer()
    {
        isPaused = false;
    }
    public void PausedTimer()
    {
        isPaused = true;
    }
}
