using System;
using System.Collections.Generic;

namespace spammaster
{

    [Serializable]
    public class Kontaktai
    {
        public String id { get; set; }
        public String first_name { get; set; }
        public String last_name { get; set; }
        public String email { get; set; }

        public override string ToString()
        {
            return first_name + " " + last_name + " (" + email + ")";
        }
    }

    [Serializable]
    public class RecipientsList
    {
        public List<Kontaktai> recipients { get; set; }
    }
}
