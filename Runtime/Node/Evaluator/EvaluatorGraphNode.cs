using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UtilityAI
{
    [CreateNodeMenu("Utility AI/������/��������")]
    [NodeTitle("��������")]
    public class EvaluatorGraphNode : EvaluatorNode
    {
        [LabelText("��ͼ")]
        [ShowInInspector]
        [Required]
        private EvaluatorGraph evaluatorGraph;

        public IEnumerable<EvaluatorNode> Evaluators => evaluatorGraph.Evaluators;

        public override float Evaluate(IAIContext context)
        {
            return 0f;
        }
    }
}