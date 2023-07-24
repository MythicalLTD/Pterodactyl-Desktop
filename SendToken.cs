using System.Collections.Generic;

namespace PteroController
{
    public class SendToken
    {
        public string Event { get; set; } = "auth";

        public List<string> Args = new List<string>();
    }
}
