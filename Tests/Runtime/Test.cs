using UnityEngine;

namespace UtilityAI.Tests
{
    /*
    * �򵥲���
    * AI�����ƣ�������װ��������
    * ����ֵ�ϵ�ʱ�������ƣ�����ʱ��������Կ����򿪻𣬷�����װ
    * AI��0�����뵯ҩ��ʼ��ÿ�붼�Զ���ʧ����
    */
    public class Test : MonoBehaviour
    {
        public AIGraph AI;
        private float time;
        private float timer;
        private TestContext testContext = new TestContext();

        public float health;
        public float maxHealth = 100f;
        public int ammo;
        public int maxAmmo = 40;

        private float lastHurt = 1f;

        void Start()
        {
            time = AI.Decider.UpdateInterval;
            timer = time;
        }


        void Update()
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                IAIContext context = GetAIContext();
                IAction action = AI.Decider.Decision(context);
                if (action != null)
                {
                    action.Execute(context);
                }
                timer = time;
            }
            UpdateState();
        }

        void UpdateState()
        {
            lastHurt -= Time.deltaTime;
            if (lastHurt <= 0)
            {
                Hurt();
                lastHurt = 1f;
            }
        }

        public void Cure()
        {
            health += 10f;
            Debug.Log(string.Format("{0}ִ��������+{1}", gameObject.name, Time.time));
        }

        public void Fill()
        {
            ammo = maxAmmo;
            Debug.Log(string.Format("{0}ִ����װ��+{1}", gameObject.name, Time.time));
        }

        public void OpenFire()
        {
            ammo -= 5;
            Debug.Log(string.Format("{0}ִ���˿���+{1}", gameObject.name, Time.time));
        }

        public void Hurt()
        {
            health -= 2f;
        }

        public IAIContext GetAIContext()
        {
            testContext.healthPre = health / maxHealth;
            testContext.ammoPre = ammo / (float)maxAmmo;
            testContext.test = this;
            return testContext;
        }
    }

    public class TestContext : IAIContext
    {
        public float healthPre;
        public float ammoPre;
        public Test test;
    }
}

