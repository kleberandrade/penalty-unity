using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [Range(-90.0f, 90.0f)]
    public float m_Range;
    public float m_SmoothTime;
    public Vector3 m_Axis;
    private Vector3 m_Origin;

    private void Start()
    {
        m_Origin = transform.eulerAngles;
    }

    private void Update()
    {
        float period = (Time.time * (2.0f * Mathf.PI)) * m_SmoothTime;
        Vector3 rotation = m_Axis * Mathf.Sin(period) * m_Range;
        transform.localEulerAngles = m_Origin + rotation;
    }
}
