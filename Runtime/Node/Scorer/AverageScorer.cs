using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UtilityAI
{
    [CreateNodeMenu("Utility AI/�Ʒ���/ƽ���Ʒ���")]
    [NodeTitle("ƽ���Ʒ���")]
    public class AverageScorer : ScorerNode
    {
        public override float Scorer(IAIContext context)
        {
            float score = 0;
            int num = 0;
            var evaluators = GetAllOnPort<EvaluatorNode>(nameof(evaluator));
            foreach (var evaluator in evaluators)
            {
                Step(evaluator,
                (EvaluatorSingleNode single) =>
                {
                    score += single.Evaluate(context);
                    num++;
                });
            }
            return score / num;
        }
    }
}