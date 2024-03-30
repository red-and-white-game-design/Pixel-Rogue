using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {
    void Update() {
        //���Ȼ�ȡ����ǰ�������Ļ����
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        //��������Ļ�����Z����ڵ�ǰ�������Ļ�����Z�ᣬҲ��������ľ���
        Vector3 m_MousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, pos.z);
        //����ȷ�������Ļ���껻���������꽻������
        transform.position = Camera.main.ScreenToWorldPoint(m_MousePos);
    }
}

