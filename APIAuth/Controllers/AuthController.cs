using Microsoft.AspNetCore.Mvc;

namespace APIAuth.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        [Route("/login")]
        public dynamic login([FromBody] LoginForm data)
        {
            string username = data.username;
            string password = data.password;

            if(username != "mauri")
            {
                return new { error = true, message = "Auth error, username not exists" };
            }else
            {
                if (password == "mauriTest")
                {
                    return new Session
                    {
                        id = Guid.NewGuid().ToString("N"),
                        sessionStartTime = DateTime.Now.ToString("dd-mm-yy HH:mm:ss"),
                        sessionLifeTime = 60
                    };
                }else
                {
                    return new { error = true, message = "Auth error, password error" };
                }
            }
        }


        //[HttpPost]
        //[Route("/guardar")]
        //public dynamic guardarCliente()
        //{

        //}
    }
}
