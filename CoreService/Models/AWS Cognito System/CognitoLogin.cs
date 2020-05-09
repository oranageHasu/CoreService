using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [NotMapped]
        public String NewPassword { get; set; }

        [JsonProperty("exceededAttempts")]
        [NotMapped]
        public bool ExceededAttempts { get; set; }

        [StringLength(50)]
        [JsonProperty("jwtToken")]
        [NotMapped]
        public String JwtToken { get; set; }

    }
}
