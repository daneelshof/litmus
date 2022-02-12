using Ardalis.GuardClauses;
using System.Collections.Generic;
using Litmus.SharedKernel;
using Litmus.SharedKernel.Interfaces;

namespace Litmus.Core.TestSuiteAggregate
{
    public class TestSuite : BaseEntity, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        private List<TestSection> _sections = new List<TestSection>();
        public IEnumerable<TestSection> Sections => _sections.AsReadOnly();

        public TestSuite(string name)
        {
            Name = Guard.Against.NullOrEmpty(name, nameof(name));
        }

        public void AddOrUpdateDescription(string description)
        {
            Description = Guard.Against.NullOrEmpty(description, nameof(description));
        }

        public void UpdateName(string name)
        {
            Name = Guard.Against.NullOrEmpty(name, nameof(name));
        }

        public void AddSection(TestSection section)
        {
            Guard.Against.Null(section, nameof(section));
            _sections.Add(section);
            
            // TODO: add NewSectionAddedEvent
        }
    }
}