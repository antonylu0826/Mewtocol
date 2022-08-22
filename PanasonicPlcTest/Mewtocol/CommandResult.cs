namespace PanasonicPlcTest.Mewtocol
{
    public struct CommandResult
    {

        /// <summary>
        /// Success state of the message
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// Response text of the message
        /// </summary>
        public string Response { get; set; }
        /// <summary>
        /// Error code of the message
        /// </summary>
        public string Error { get; set; }
        /// <summary>
        /// Error text of the message
        /// </summary>
        public string ErrorDescription { get; set; }

    }
}
