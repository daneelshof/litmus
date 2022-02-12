using System;
using Ardalis.GuardClauses;
using Litmus.SharedKernel;

namespace Litmus.Core.TestSuiteAggregate
{
    public class TestStep : BaseEntity
    {
        public string Name { get; private set; }
        public string Instructions { get; private set; }
        public UInt16 OrderNumber { get; private set; }

        public TestStep(string name)
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

        public void SetOrderNumber(UInt16 orderNumber)
        {
            Guard.Against.Zero(orderNumber, nameof(orderNumber));
            OrderNumber = orderNumber;
        }
    }
}