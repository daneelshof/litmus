using System.Collections.Generic;
using Ardalis.GuardClauses;
using Litmus.SharedKernel;

namespace Litmus.Core.TestSuiteAggregate
{
    public class TestSection : BaseEntity
    {
        public string Name { get; private set; }

        private List<TestCase> _cases = new List<TestCase>();
        public IEnumerable<TestCase> Cases => _cases.AsReadOnly();

        public TestSection(string name)
        {
            Name = Guard.Against.NullOrEmpty(name, nameof(name));
        }

        public void UpdateName(string name)
        {
            Name = Guard.Against.NullOrEmpty(name, nameof(name));
        }
    }
}