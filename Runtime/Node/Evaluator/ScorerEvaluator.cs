using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UtilityAI
{
    /// <summary>
    /// �������������һ���Ʒ����ڵ�����
    /// ����������һ��������ʹ�ö���Ʒ�������
    /// </summary>
    [CreateNodeMenu("Utility AI/������/�Ʒ���������")]
    [NodeTitle("�Ʒ���������")]
    public class ScorerEvaluator : EvaluatorNode
    {
        [Input(ShowBackingValue.Never, ConnectionType.Override, TypeConstraint.Strict)]
        [LabelText("In")]
        public ScorerNode scorer;

        public override float Evaluate(IAIContext context)
        {
            return scorer.Scorer(context);
        }
    }
}