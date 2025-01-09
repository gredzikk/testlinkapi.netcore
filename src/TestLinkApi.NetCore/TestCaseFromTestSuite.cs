namespace TestLinkApi {
    /// <summary>
    /// test case as it is retrieved from testsuite
    /// </summary>
    public class TestCaseFromTestSuite {
        public bool active { get; set; }
        public int author_id { get; set; }
        public DateTime creation_ts { get; set; }
        public string details { get; set; }

        /// <summary>
        /// manual or automatic
        /// </summary>
        public int execution_type { get; set; }

        /// <summary>
        /// the id that is displayed on the UI, sans the prefix
        /// </summary>
        public string external_id { get; set; }

        /// <summary>
        /// test case id
        /// </summary>
        public int id { get; set; }

        public int importance { get; set; }

        /// <summary>
        /// unknown purpose
        /// </summary>
        public bool is_open { get; set; }

        /// <summary>
        /// not clear what this represents
        /// </summary>
        public string layout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime modification_ts { get; set; }

        public string name { get; set; }
        public int node_order { get; set; }
        public string node_table { get; set; }
        public int node_type_id { get; set; }

        public int parent_id { get; set; }
        public string preconditions { get; set; }

        /// <summary>
        /// not clear in its meaning
        /// </summary>
        public int status { get; set; }

        public string summary { get; set; }

        /// <summary>
        /// the internal id of this testcase version
        /// </summary>
        public int tcversion_id { get; set; }

        /// <summary>
        /// the id of the owning testsuite
        /// </summary>
        public int testSuite_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int updater_id { get; set; }

        /// <summary>
        /// the version of the test case, starts with 1
        /// </summary>
        public int version { get; set; }
    }
}