using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonManager : MonoBehaviour
{
    public static float enBulletMoveFactor = 1;
    public AudioSource source;

    public IEnumerator Melon()
    {
        Weapon.melonSwitch = false;
        source.pitch = (source.pitch / 4) * 3;
        EnemyAI.enMoveSpeed = EnemyAI.enMoveSpeed / 2;
        Enemy2AI.enMoveSpeed = Enemy2AI.enMoveSpeed / 2;
        Enemy3AI.enMoveSpeed = Enemy3AI.enMoveSpeed / 2;
        Enemy4AI.enMoveSpeed = Enemy4AI.enMoveSpeed / 2;
        Enemy5AI.enMoveSpeed = Enemy5AI.enMoveSpeed / 2;
        Enemy6AI.enMoveSpeed = Enemy6AI.enMoveSpeed / 2;
        enBullet.enbulletSpeed = enBullet.enbulletSpeed / (enBulletMoveFactor * 2);
        En2Bullet.enbulletSpeed = En2Bullet.enbulletSpeed / (enBulletMoveFactor * 2);
        En3Bullet.enbulletSpeed = En3Bullet.enbulletSpeed / (enBulletMoveFactor * 2);
        MelonController.MelonOn = false;
        yield return new WaitForSeconds(10);
        source.pitch = (source.pitch * 4) / 3;
        EnemyAI.enMoveSpeed = EnemyAI.enMoveSpeed * 2;
        Enemy2AI.enMoveSpeed = Enemy2AI.enMoveSpeed * 2;
        Enemy3AI.enMoveSpeed = Enemy3AI.enMoveSpeed * 2;
        Enemy4AI.enMoveSpeed = Enemy4AI.enMoveSpeed * 2;
        Enemy5AI.enMoveSpeed = Enemy5AI.enMoveSpeed * 2;
        Enemy6AI.enMoveSpeed = Enemy6AI.enMoveSpeed * 2;
        enBullet.enbulletSpeed = enBullet.enbulletSpeed * (enBulletMoveFactor * 2);
        En2Bullet.enbulletSpeed = En2Bullet.enbulletSpeed * (enBulletMoveFactor * 2);
        En3Bullet.enbulletSpeed = En3Bullet.enbulletSpeed * (enBulletMoveFactor * 2);
        
    }

    

    // Start is called before the first frame update
    void Start()
    {
        source.pitch = 1;

        enBulletMoveFactor = 1;
        EnemyAI.enMoveSpeed = .5f;
        Enemy2AI.enMoveSpeed = .5f;
        Enemy3AI.enMoveSpeed = .5f;
        Enemy4AI.enMoveSpeed = .5f;
        Enemy5AI.enMoveSpeed = .5f;
        Enemy6AI.enMoveSpeed = .5f;
        enBullet.enbulletSpeed = 1f;
        En2Bullet.enbulletSpeed = 2.5f;
        En3Bullet.enbulletSpeed = 1.5f;
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
