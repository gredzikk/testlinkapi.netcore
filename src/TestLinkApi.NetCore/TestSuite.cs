namespace TestLinkApi {
    /// <summary>
    ///  represent a folder in the test specification tree
    /// </summary>
    public class TestSuite {
        /// <summary>
        ///  internal primary key
        /// </summary>
        public int id { get; set; }

        /// <summary>
        ///  name of test suite
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///  sequence id for ordering folders in tree
        /// </summary>
        public int nodeOrder { get; set; }

        /// <summary>
        ///  internal value
        /// </summary>
        public int nodeTypeId { get; set; }

        /// <summary>
        ///  foreign key to parent
        /// </summary>
        public int parentId { get; set; }
    }
}