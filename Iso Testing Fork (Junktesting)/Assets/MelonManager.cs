using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonManager : MonoBehaviour
{
    public static float enBulletMoveFactor = 1;

    public IEnumerator Melon()
    {
        Weapon.melonSwitch = false;
        EnemyAI.enMoveSpeed = EnemyAI.enMoveSpeed / 2;
        enBullet.enbulletSpeed = enBullet.enbulletSpeed / (enBulletMoveFactor * 2);
        En2Bullet.enbulletSpeed = En2Bullet.enbulletSpeed / (enBulletMoveFactor * 2);
        En3Bullet.enbulletSpeed = En3Bullet.enbulletSpeed / (enBulletMoveFactor * 2);
        MelonController.MelonOn = false;
        yield return new WaitForSeconds(10);
        EnemyAI.enMoveSpeed = EnemyAI.enMoveSpeed = EnemyAI.enMoveSpeed * 2;
        enBullet.enbulletSpeed = enBullet.enbulletSpeed * (enBulletMoveFactor * 2);
        En2Bullet.enbulletSpeed = En2Bullet.enbulletSpeed * (enBulletMoveFactor * 2);
        En3Bullet.enbulletSpeed = En3Bullet.enbulletSpeed * (enBulletMoveFactor * 2);
        
    }

    

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if(Weapon.melonSwitch == true)
        {
            StartCoroutine(Melon());
        }
    }
}
