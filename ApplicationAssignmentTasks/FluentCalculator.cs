namespace ApplicationAssignmentTasks
{
    public class FluentCalculator
    {
        // Perhaps I do not understand the approach of separation to Values and Operations,
        // but creating a class for each doesn't seem necessary for me.
        // Also I am quite concerned about using properies instead of methods and lowerCamelCase
        #region Operations
        private char? currentOperation = '+';
        private FluentCalculator AddOperation(char input)
        {
            if (currentOperation.HasValue)
                throw new InvalidOperationException("Operation is already assigned");

            currentOperation = input;
            return this;
        }

        public FluentCalculator plus => AddOperation('+');
        public FluentCalculator minus => AddOperation('-');
        public FluentCalculator times => AddOperation('*');
        public FluentCalculator dividedBy => AddOperation('/');
        #endregion

        #region Values
        private int total = 0;

        private FluentCalculator CalculateTotal(int input)
        {
            if (!currentOperation.HasValue)
                throw new InvalidOperationException("Operator is not chosen");

            total = currentOperation.Value switch
            {
                '+' => total + input,
                '-' => total - input,
                '*' => total * input,
                '/' => total / input,
                _ => throw new ArgumentException(nameof(currentOperation))
            };
            currentOperation = null;
            return this;
        }

        public FluentCalculator zero => CalculateTotal(0);
        public FluentCalculator one => CalculateTotal(1);
        public FluentCalculator two => CalculateTotal(2);
        public FluentCalculator three => CalculateTotal(3);
        public FluentCalculator four => CalculateTotal(4);
        public FluentCalculator five => CalculateTotal(5);
        public FluentCalculator six => CalculateTotal(6);
        public FluentCalculator seven => CalculateTotal(7);
        public FluentCalculator eight => CalculateTotal(8);
        public FluentCalculator nine => CalculateTotal(9);
        #endregion

        public static implicit operator int (FluentCalculator calc) => calc.total;
    }
}
