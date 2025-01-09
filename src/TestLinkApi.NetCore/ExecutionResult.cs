namespace TestLinkApi {
    /// <summary>
    ///  Represent the recorded outcome of a test case execution.
    /// </summary>
    public class ExecutionResult {
        /// <summary>
        ///  id of the build this was run against
        /// </summary>
        public int build_id { get; set; }

        /// <summary>
        ///  timestamp of execution
        /// </summary>
        public DateTime execution_ts { get; set; }

        /// <summary>
        ///  execution type, 1=manual, 2=automatic
        /// </summary>
        public int execution_type { get; set; }

        /// <summary>
        ///  internal id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        ///  notes provided
        /// </summary>
        public string notes { get; set; }

        /// <summary>
        ///  status, p=pass, f=fail, b=blocked
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///  version id of test case
        /// </summary>
        public int tcversion_id { get; set; }

        /// <summary>
        ///  external version number
        /// </summary>
        public int tcversion_number { get; set; }

        /// <summary>
        ///  id of tester
        /// </summary>
        public int tester_id { get; set; }

        /// <summary>
        ///  id of testplan
        /// </summary>
        public int testplan_id { get; set; }
    }
}