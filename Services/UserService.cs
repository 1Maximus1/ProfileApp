using UserProfileApp.Models;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using Microsoft.AspNetCore.Components.Forms;

namespace UserProfileApp.Services
{
    public class UserService
    {
        public Person getUserDataFromJSON(string name)
        {
            using (FileStream fs = new FileStream($"{name}.json", FileMode.Open))
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Person));
                return (Person)jsonSerializer.ReadObject(fs);
            }
        }

        public byte[] getUserPhoto(string path)
        {
            byte[] imageBytes = File.ReadAllBytes(path);
            return imageBytes;
        }
    }
}
