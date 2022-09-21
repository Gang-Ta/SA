using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAssaultRifle : MonoBehaviour
{
    [Header("Audio Clips")]
    [SerializeField]
    private AudioClip audioClipTakeOutWeapon;       //������������   
    private AudioSource audioSource;                    //���� ��� ������Ʈ

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnEnable()
    {
        PlaySound(audioClipTakeOutWeapon);      //������������
    }
    private void PlaySound(AudioClip clip)
    {
        audioSource.Stop();             //����������λ�������
        audioSource.clip = clip;        //���ο� ���� Ŭ�����α�ü
        audioSource.Play();                //���� ���
    }
}
