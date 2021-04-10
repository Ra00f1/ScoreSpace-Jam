using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReloadSc : MonoBehaviour
{
    public WeaponSlecetSc WeaponSlecetSc;

    public TextMeshProUGUI BulletCountText;

    public int PistolBC;
    public int UziBC;
    public int ShotgunBC;

    public int CurrentBulletC;
    public int CurrentMaxBulletC;

    public bool ReloadReady;
    public bool ClipEmpty;

    void Start()
    {
        WeaponSlecetSc = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<WeaponSlecetSc>();
    }

    void Update()
    {
        CheckWeapon();
        Reload();
        SetText();
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

    private void Reload()
    {
        if (ReloadReady == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                CurrentBulletC = CurrentMaxBulletC;
            }
        }
    }
}
