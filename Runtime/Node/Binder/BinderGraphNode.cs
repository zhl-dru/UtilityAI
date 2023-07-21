using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UtilityAI
{
    [CreateNodeMenu("Utility AI/����/����������")]
    [NodeTitle("����������")]
    public class BinderGraphNode : BinderNode
    {
        [LabelText("��ͼ")]
        [ShowInInspector]
        [PropertyOrder(100)]
        [Required]
        private BinderGraph binderGraph;

        public IEnumerable<BinderNode> Binders => binderGraph.Binders;

        public override ScorerNode Scorers => null;
    }
}