using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialLoginMaratona.Model
{
    public class User
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }
    }
}
