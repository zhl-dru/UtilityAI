namespace UtilityAI
{
    [CreateNodeMenu("Utility AI/�Ʒ���/ȡ�߼Ʒ���")]
    [NodeTitle("ȡ�߼Ʒ���")]
    public class MaxScorer : ScorerNode
    {
        public override float Scorer(IAIContext context)
        {
            float score = float.MinValue;
            var evaluators = GetAllOnPort<EvaluatorNode>(nameof(evaluator));
            foreach (var evaluator in evaluators)
            {
                Step(evaluator,
                    (EvaluatorSingleNode single) =>
                    {
                        float value = single.Evaluate(context);
                        if (score < value) score = value;
                    });
            }
            return score;
        }
    }
}
