using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSlecetSc : MonoBehaviour
{
    public ReloadSc reloadSc;

    public Transform WeaponSpwanPoint;

    public GameObject Pistol;
    public GameObject Uzi;
    public GameObject SMG;
    public GameObject LMG;
    public GameObject Shotgun;
    public GameObject AutoShotgun;
    public GameObject SemiAutoShotgun;

    public GameObject CurrentWeapon;

    public bool ShotgunReload;

    void Start()
    {
        reloadSc = gameObject.GetComponent<ReloadSc>();
    }

    void Update()
    {
        CurrentWeapon = GameObject.FindGameObjectWithTag("Weapon");
        //Pistol
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Destroy(CurrentWeapon);
            if (CurrentWeapon == null)
            {
                CurrentWeapon = Instantiate(Pistol, WeaponSpwanPoint.position, Quaternion.identity);
                CurrentWeapon.transform.SetParent(gameObject.transform);
                CurrentWeapon.gameObject.name = "Pistol";
                reloadSc.CurrentBulletC = reloadSc.LastPistolBC;
            }
            else
            {
                CurrentWeapon = Instantiate(Pistol, WeaponSpwanPoint.position, WeaponSpwanPoint.rotation);
                CurrentWeapon.transform.SetParent(gameObject.transform);
                CurrentWeapon.gameObject.name = "Pistol";
                reloadSc.CurrentBulletC = reloadSc.LastPistolBC;
            }
            ShotgunReload = false;
        }
        //Uzi
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Destroy(CurrentWeapon);
            if (CurrentWeapon == null)
            {
                CurrentWeapon = Instantiate(Uzi, WeaponSpwanPoint.position, Quaternion.identity);
                CurrentWeapon.transform.SetParent(gameObject.transform);
                CurrentWeapon.gameObject.name = "Uzi";
                reloadSc.CurrentBulletC = reloadSc.LastUziBC;
            }
            else
            {
                CurrentWeapon = Instantiate(Uzi, WeaponSpwanPoint.position, WeaponSpwanPoint.rotation);
                CurrentWeapon.transform.SetParent(gameObject.transform);
                CurrentWeapon.gameObject.name = "Uzi";
                reloadSc.CurrentBulletC = reloadSc.LastUziBC;
            }

            CurrentWeapon.transform.SetParent(gameObject.transform);

            if (CurrentWeapon != null)
            {
                CurrentWeapon.transform.SetParent(gameObject.transform);
            }
            ShotgunReload = false;
        }
        //Shotgun
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Destroy(CurrentWeapon);
            if (CurrentWeapon == null)
            {
                CurrentWeapon = Instantiate(Shotgun, WeaponSpwanPoint.position, Quaternion.identity);
                CurrentWeapon.transform.SetParent(gameObject.transform);
                CurrentWeapon.gameObject.name = "Shotgun";
                reloadSc.CurrentBulletC = reloadSc.LastShotgunBC;
            }
            else
            {
                CurrentWeapon = Instantiate(Shotgun, WeaponSpwanPoint.position, WeaponSpwanPoint.rotation);
                CurrentWeapon.transform.SetParent(gameObject.transform);
                CurrentWeapon.gameObject.name = "Shotgun";
                reloadSc.CurrentBulletC = reloadSc.LastShotgunBC;
            }
            ShotgunReload = true;
        }
    }
}
