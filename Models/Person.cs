using System.Runtime.Serialization;

namespace UserProfileApp.Models
{
    [DataContract]
    public class Person
    {
        [DataMember] 
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Group { get; set; }

        [DataMember]
        public string Info { get; set; }

        [DataMember]
        public List<string> Hobby { get; set; }

        [IgnoreDataMember]
        private byte[] img;

        public byte[] Img
        {
            get { return img; }
            set { img = value; }
        }
    }
}
