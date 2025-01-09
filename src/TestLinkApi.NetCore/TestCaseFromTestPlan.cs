namespace TestLinkApi {
    /// <summary>
    /// test cases as they are returned from the getTestCase API call
    /// </summary>
    /// <remarks>This is different from other calls that return TestCases </remarks>
    public class TestCaseFromTestPlan {
        public string name { get; set; }
        public int tc_id { get; set; }
        public int tcversion_id { get; set; }
        public int version { get; set; }
        public string external_id { get; set; }
        public int execution_type { get; set; }
        public int status { get; set; }
        public int feature_id { get; set; }
        public int platform_id { get; set; }
        public string platform_name { get; set; }
        public int execution_order { get; set; }
        public string exec_status { get; set; }
        public int exec_id { get; set; }
        public int tcversion_number { get; set; }
        public int exec_on_build { get; set; }
        public int exec_on_tplan { get; set; }
        public string exec_comment { get; set; }
    }
}