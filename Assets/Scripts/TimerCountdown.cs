using AV.Inspector.Runtime;
using UnityEngine;

public class TimerCountdown : MonoBehaviour
{
    [SerializeField] float m_countDownSeconds;
    [SerializeField] FloatEvent m_onCountDown;
    [SerializeField] GameEvent m_onCountDownFinished;
    [SerializeField] bool m_clampFloat;
    [Space]
    [SerializeField, ReadOnly] bool m_isCountingDown = false;
    float m_remainingTime;

    public void StartCountdown()
    {
        m_isCountingDown = true;
        m_remainingTime = m_countDownSeconds;
    }
    public void StopCountdown()
    {
        m_isCountingDown = false;
    }

    private void Update()
    {
        if (!m_isCountingDown) return;
        m_remainingTime -= Time.deltaTime;
        if (m_remainingTime <= 0)
        {
            m_remainingTime = 0;
            m_isCountingDown = false;
        }
        m_onCountDown.Raise(m_clampFloat ? ((float)((int)m_remainingTime)) : m_remainingTime);


        if (m_remainingTime == 0)
        {
            m_onCountDownFinished.Raise();
        }

    }
}
