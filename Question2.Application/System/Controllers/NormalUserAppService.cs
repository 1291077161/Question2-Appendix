using emmm.Application.System.Dtos;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StackExchange.Profiling.Internal;
using StackExchange.Redis;

namespace emmm.Application.System.Controllers
{
    [Route("redis/[Controller]")]
    [ApiDescriptionSettings(SplitCamelCase = false)]
    public class NormalUserAppService : IDynamicApiController
    {
        /// <summary>
        /// 获取redis中用户的数量
        /// </summary>
        [HttpPost]
        [QueryParameters]
        public string saveUserInfoInRedis([FromBody] EmailUserInRedis emailUserInRedis)
        {
            //RedisHelper redisHelper = new RedisHelper("localhost:6379,defaultDatabase=8,password=123456");

            //与redis建立连接
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379," +
                "defaultDatabase=8,password=123456");
            var db = redis.GetDatabase();
            //if (emailUserInRedis != null)
            //{
            //    这里假设数据模型类名为JsonData，它包含email，Id，User，Token，Time和Error五个字段
            //    string email = emailUserInRedis.email;
            //    int id = emailUserInRedis.Id;
            //    string user = emailUserInRedis.User;
            //    string token = emailUserInRedis.Token;
            //    string time = emailUserInRedis.Time;
            //    string status = emailUserInRedis.status;
            //}

            // if (string.IsNullOrEmpty(emailUserInRedis.email))
            // {
            //     return "email is null";
            // }
            // if (emailUserInRedis.id.GetType() == typeof(bool))
            // {
            //     Convert.ToString(emailUserInRedis.id);
            // }

            if (string.IsNullOrEmpty(emailUserInRedis.email))
            {
                return "email is null";
            }
            else if (emailUserInRedis.email != null && emailUserInRedis != null)
            {
                db.StringSet("email:" + emailUserInRedis.email, emailUserInRedis.ToJson(), expiry: TimeSpan.FromSeconds(60));
            }

            return new EmailUserInRedis().error = "邮箱存入Redis成功";
        }
    }
}