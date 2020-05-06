using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace CoreService.Models.AWS_Cognito_System
{
    public class CognitoLogin
    {
        [StringLength(50)]
        [JsonProperty("userName")]
        public string UserName { get; set; }

        [StringLength(50)]
        [JsonProperty("password")]
        public String Password { get; set; }

        [StringLength(50)]
        [JsonProperty("newPassword")]
        public String NewPassword { get; set; }

        [JsonProperty("exceededAttempts")]
        public bool ExceededAttempts { get; set; }

    }
}
