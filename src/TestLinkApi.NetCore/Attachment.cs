namespace TestLinkApi {
    /// <summary>
    /// The object returned from Testlinkt when requesting an attachment
    /// </summary>
    public class Attachment {
        public byte[] content { get; set; }
        public DateTime date_added { get; set; }
        public string file_type { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string title { get; set; }
    }
}