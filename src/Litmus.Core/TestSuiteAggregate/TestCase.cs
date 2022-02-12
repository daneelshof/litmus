using System.Collections.Generic;
using Ardalis.GuardClauses;
using Litmus.SharedKernel;

namespace Litmus.Core.TestSuiteAggregate
{
    public class TestCase : BaseEntity
    {
        public string Name { get; private set; }
        public string Instructions { get; private set; }

        private List<TestStep> _steps = new List<TestStep>();
        public IEnumerable<TestStep> Steps => _steps.AsReadOnly();

        public TestCase(string name)
        {
            Name = Guard.Against.NullOrEmpty(name, nameof(name));
        }

        public void AddOrUpdateInstructions(string instructions)
        {
            Instructions = Guard.Against.NullOrEmpty(instructions, nameof(instructions));
        }

        public void UpdateName(string name)
        {
            Name = Guard.Against.NullOrEmpty(name, nameof(name));
        }

        public void AddStep(TestStep step)
        {
            Guard.Against.Null(step, nameof(step));
            _steps.Add(step);
            
            // TODO: add NewStepAddedEvent
        }
    }
}