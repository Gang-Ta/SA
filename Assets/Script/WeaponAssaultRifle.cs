using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAssaultRifle : MonoBehaviour
{
    [Header("Audio Clips")]
    [SerializeField]
    private AudioClip audioClipTakeOutWeapon;       //무기장착사운드   
    private AudioSource audioSource;                    //사운드 재생 컴포넌트

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnEnable()
    {
        PlaySound(audioClipTakeOutWeapon);      //무기장착사운드
    }
    private void PlaySound(AudioClip clip)
    {
        audioSource.Stop();             //기존재생중인사운드정지
        audioSource.clip = clip;        //새로운 사운드 클립으로교체
        audioSource.Play();                //사운드 재생
    }
}
