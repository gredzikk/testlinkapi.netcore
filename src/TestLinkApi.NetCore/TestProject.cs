namespace TestLinkApi {
    /// <summary>
    /// represent a test project object in testlink
    /// </summary>
    public class TestProject {
        /// <summary>
        /// 
        /// </summary>
        public bool active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string color { get; set; }

        /// <summary>
        /// internal id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// project name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// notes
        /// </summary>
        public string notes { get; set; }

        /// <summary>
        /// true if automation is enabled
        /// </summary>
        public bool option_automation { get; set; }

        /// <summary>
        /// true of inventory is enabled
        /// </summary>
        public bool option_inventory { get; set; }

        /// <summary>
        /// true if priority feature is enabled
        /// </summary>
        public bool option_priority { get; set; }

        /// <summary>
        /// true of requirements feature is enabled
        /// </summary>
        public bool option_reqs { get; set; }

        /// <summary>
        /// string prefix for test cases
        /// </summary>
        public string prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int tc_counter { get; set; }


        public List<TestSuite> TestSuites { get; set; } = new List<TestSuite>();
    }
}