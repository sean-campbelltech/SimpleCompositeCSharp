namespace SimpleCompositeCSharp
{
    // Composite
    public class PullRequest : GitComponent
    {
        private readonly string _fromBranch;
        private readonly string _intoBranch;

        public PullRequest(string fromBranch, string intoBranch)
        {
            _fromBranch = fromBranch;
            _intoBranch = intoBranch;
        }

        public override void ShowDetail()
        {
            Console.WriteLine($"Pull Request: [{_fromBranch} -> {_intoBranch}] with commits:");
            foreach (GitComponent component in _components)
            {
                component.ShowDetail();
            }
        }
    }
}