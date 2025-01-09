namespace TestLinkApi {
    /// <summary>
    /// this is returned as a response to an attachment request
    /// </summary>
    public class AttachmentRequestResponse {
        /// <summary>
        /// description 
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// filename 
        /// </summary>
        public string file_name { get; set; }

        /// <summary>
        /// mime type
        /// </summary>
        public string file_type { get; set; }

        /// <summary>
        /// the foreign key
        /// </summary>
        public int foreignKeyId { get; set; }

        /// <summary>
        /// the name of the table containing hte event this is attached to (an execution for instance)
        /// </summary>
        public string linkedTableName { get; set; }

        /// <summary>
        /// size in bytes
        /// </summary>
        public int size { get; set; }

        /// <summary>
        /// title of the attachment
        /// </summary>
        public string title { get; set; }
    }
}