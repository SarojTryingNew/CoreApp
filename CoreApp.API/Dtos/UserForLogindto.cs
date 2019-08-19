using System.ComponentModel.DataAnnotations;

namespace CoreApp.API.Dtos
{
    public class UserForLogindto
    {
        
        public string UserName { get; set; }
       
        public string Password { get; set; }
    }
}