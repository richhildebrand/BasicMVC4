using System.Runtime.Serialization;

namespace BasicMVC4.LanguageServices
{
    [DataContract]
    public class EditorError
    {
        [DataMember]
        public DocumentLineSpan Location { get; set; }
        
        [DataMember]
        public string Message { get; set; }
    }
}