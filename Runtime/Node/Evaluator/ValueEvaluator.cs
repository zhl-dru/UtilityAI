using Sirenix.OdinInspector;
using UnityEngine;

namespace UtilityAI
{
    /// <summary>
    /// ָ��һ��ֵ,
    /// ���ڸ�ֵʱ
    /// ���inversion = false
    /// ����1,���򷵻�0
    /// �����෴
    /// </summary>
    [CreateNodeMenu("Utility AI/������/��ֵ������")]
    [NodeTitle("��ֵ������")]
    public class ValueEvaluator : EvaluatorSingleNode
    {
        [LabelText("��ֵ")]
        [SerializeField]
        private float value = 0.5f;
        [LabelText("��ת")]
        [SerializeField]
        private bool inversion = false;

        public override float Evaluate(IAIContext context)
        {
            if (scene.Evaluate(context) > value)
            {
                return (inversion ? 0f : 1f) * weight;
            }
            else
            {
                return (inversion ? 1f : 0f) * weight;
            }
        }
    }
}