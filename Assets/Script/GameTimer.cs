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

    // Update is called once per frame
    void Update()
    {
        //���Ԃ��J�E���g�_�E������
        countdown -= Time.deltaTime;

        //���Ԃ�\������
        timeText.text = countdown.ToString("f1");

        //countdown��0�ȉ��ɂȂ����Ƃ�
        if (countdown <= 0)
        {
            SceneManager.LoadScene("Result");
        }
    }
}
