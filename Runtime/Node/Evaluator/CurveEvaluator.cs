using Sirenix.OdinInspector;
using UnityEngine;

namespace UtilityAI
{
    [CreateNodeMenu("Utility AI/������/����������")]
    [NodeTitle("����������")]
    public class CurveEvaluator : EvaluatorSingleNode
    {
        [LabelText("����")]
        [SerializeField]
        private AnimationCurve curve;



        public override float Evaluate(IAIContext context)
        {
            return curve.Evaluate(scene.Evaluate(context));
        }
    }
}