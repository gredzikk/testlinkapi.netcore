namespace TestLinkApi {
    /// <summary>
    /// Represents a platform against which a test result can be recorded
    /// </summary>
    public class TestPlatform {
        /// <summary>
        /// primary key
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string notes { get; set; }
    }
}