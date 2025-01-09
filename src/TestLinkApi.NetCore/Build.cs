namespace TestLinkApi {
    /// <summary>
    ///  Build information returned by Testlink
    /// </summary>
    public class Build {
        /// <summary>
        ///  true if the build is active
        /// </summary>
        public bool active { get; set; }

        /// <summary>
        ///  build ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        ///  true if the build is currently open
        /// </summary>
        public bool is_open { get; set; }

        /// <summary>
        ///  build name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///  any build notes
        /// </summary>
        public string notes { get; set; }

        /// <summary>
        ///  the test plan the build is associated with
        /// </summary>
        public int testplan_id { get; set; }
    }
}