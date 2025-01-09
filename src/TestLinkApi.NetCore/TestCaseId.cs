namespace TestLinkApi {
    /// <summary>
    /// view of test case identifiers returned by the api call GetTestCaseIdByName
    /// </summary>
    public class TestCaseId {
        /// <summary>
        /// test case internal id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// that would be the id of the owning item in the nodes hierarchy table (i.e. the folder id)
        /// </summary>
        public int parent_id { get; set; }

        /// <summary>
        /// the externally visible id without the prefix
        /// </summary>
        public int tc_external_id { get; set; }

        /// <summary>
        /// name of the test suite that contains the test case
        /// </summary>
        public string tsuite_name { get; set; }
    }
}