namespace paySupplement_P1_9
{
    public class InvalidSequence : Exception
    {
        /// <summary>
        /// Exception for invalid sequence that outputs an error message.
        /// </summary>
        /// <param name="message">This message describes the error.</param>
        public InvalidSequence(string message) : base(message) { }
    }
}
