namespace TestLinkApi {
    /// <summary>
    /// summary results for the execution of a testplan.
    /// 
    /// </summary>
    public class TestPlanTotal {
        /// <summary>
        /// Dictionary with execution totals
        /// </summary>
        public Dictionary<string, int> Details { get; set; } = new Dictionary<string, int>();

        /// <summary>
        /// category value
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// total test cases that are covered in this test plan
        /// </summary>
        public int Total_tc { get; set; }

        /// <summary>
        /// category name
        /// </summary>
        public string Type { get; set; }
    }
}