using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UtilityAI
{
    [DisallowMultipleNodes]
    [NodeTint("#641E16")]
    [CreateNodeMenu("Utility AI/��ͼ���/��������")]
    [NodeTitle("��������")]
    public class EvaluatorSetNode : AIBaseNode
    {
        [Input(ShowBackingValue.Never, ConnectionType.Override, TypeConstraint.Strict)]
        public EvaluatorNode evaluator;

        public IEnumerable<EvaluatorNode> Evaluators => GetAllOnPort<EvaluatorNode>(nameof(evaluator));
    }
}