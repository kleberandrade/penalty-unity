using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Rigidbody m_Bullet;
    public float m_Force;
    public Transform m_Point;
    public float m_CooldownTime = 1.0f;

    private float m_NextShootTime;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= m_NextShootTime)
        {
            var body = Instantiate<Rigidbody>(m_Bullet, m_Point.position, m_Point.rotation);
            body.AddForce(m_Point.forward * m_Force, ForceMode.Impulse);
            m_NextShootTime = Time.time + m_CooldownTime;
        }
    }
}
