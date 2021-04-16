using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReloadSc : MonoBehaviour
{
    public WeaponSlecetSc WeaponSlecetSc;

    public TextMeshProUGUI BulletCountText;
    public Slider Slider;

    public int PistolBC;
    public int UziBC;
    public int ShotgunBC;

    public int LastPistolBC;
    public int LastUziBC;
    public int LastShotgunBC;

    public int CurrentBulletC;
    public int CurrentMaxBulletC;

    public bool ReloadReady;
    public bool ClipEmpty;
    public bool Reloading = false;

    void Start()
    {
        WeaponSlecetSc = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<WeaponSlecetSc>();
    }

    void Update()
    {
        CheckWeapon();
        Reload();
        SetText();
        SetSlider();
        RemainingBullets();
    }

    private void CheckWeapon()
    {
        if (WeaponSlecetSc.CurrentWeapon.name == "Pistol")
        {
            CurrentMaxBulletC = PistolBC;
            if (CurrentBulletC == CurrentMaxBulletC)
            { ReloadReady = false; }
            else
            { ReloadReady = true; }
            if (CurrentBulletC == 0)
            { ClipEmpty = true; }
            else
            { ClipEmpty = false; }
        }
        if (WeaponSlecetSc.CurrentWeapon.name == "Uzi")
        {
            CurrentMaxBulletC = UziBC;
            if (CurrentBulletC == CurrentMaxBulletC)
            { ReloadReady = false; }
            else
            { ReloadReady = true; }
            if (CurrentBulletC == 0)
            { ClipEmpty = true; }
            else
            { ClipEmpty = false; }
        }
        if (WeaponSlecetSc.CurrentWeapon.name == "Shotgun")
        {
            CurrentMaxBulletC = ShotgunBC;
            if (CurrentBulletC == CurrentMaxBulletC)
            { ReloadReady = false; }
            else
            { ReloadReady = true; }
            if (CurrentBulletC == 0)
            { ClipEmpty = true; }
            else
            { ClipEmpty = false; }
        }
    }

    private void SetText()
    {
        BulletCountText.SetText(CurrentBulletC + "/" + CurrentMaxBulletC);
    }

    private void SetSlider()
    {
        if (Reloading == false)
        {
            Slider.maxValue = CurrentMaxBulletC;
            Slider.value = CurrentBulletC;
        }
        if (Reloading == true)
        {
            if (WeaponSlecetSc.ShotgunReload == true)
            {
                InvokeRepeating("ReloadShotgun", 0f, 0.5f);
                Reloading = false;
            }
            if (WeaponSlecetSc.ShotgunReload == false)
            {
                ReloadClip();
                Reloading = false;
            }
        }
    }

    private void Reload()
    {
        if (ReloadReady == true)
        {
            if (Reloading == false)
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    Reloading = true;
                }
            }
        }
    }

    private void ReloadShotgun()
    {
        if (CurrentBulletC < CurrentMaxBulletC)
        {
            CurrentBulletC += 1;
        }
        if (CurrentBulletC == CurrentMaxBulletC)
        {
            CancelInvoke();
        }
    }

    private void ReloadClip()
    {
        CurrentBulletC = CurrentMaxBulletC;
    }

    private void RemainingBullets()
    {
        if (WeaponSlecetSc.CurrentWeapon.name == "Pistol")
        {
            LastPistolBC = CurrentBulletC;
        }
        if (WeaponSlecetSc.CurrentWeapon.name == "Uzi")
        {
            LastUziBC = CurrentBulletC;
        }
        if (WeaponSlecetSc.CurrentWeapon.name == "Shotgun")
        {
            LastShotgunBC = CurrentBulletC;
        }
    }
}
