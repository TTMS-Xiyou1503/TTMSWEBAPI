using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using TTMSWebAPI.Models;
using TTMSWebAPI.Servers;

namespace TTMSWebAPI.Controllers
{
    /// <summary>
    /// 剧目管理API
    /// </summary>
    [Route("[controller]")]
    [EnableCors("mCors")]
    public class ProgrammeController : Controller
    {
        /// <summary>
        /// 获得所有剧目
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public object Get()
        {
            try
            {
//                var addr = Server.GetUserIp(Request.HttpContext);
//                if (Server.IpHandle(addr) == 0)
//                {
//                    return new[] {"your ip can't using our api , please contact administrator"};
//                }
//
                var account = HttpContext.Session.GetString("user_account");

                if (account == null)
                {
                    return new
                    {
                        result = 401,
                        msg = "not login"
                    };
                }

                var re = ProgrammeServer.GetAllProgramme();

                return re;
            }
            catch (Exception e)
            {
                return new
                {
                    result = e.HResult,
                    msg = e.Message
                };
            }
        }

        /// <summary>
        /// 获得所有剧目(附加图片路径)
        /// </summary>
        /// <returns>所有剧目(附加图片路径)</returns>
        [HttpGet("[action]")]
        public object GetWithImagePath()
        {
            try
            {
//                var addr = Server.GetUserIp(Request.HttpContext);
//                if (Server.IpHandle(addr) == 0)
//                {
//                    return new[] {"your ip can't using our api , please contact administrator"};
//                }
//
                var account = HttpContext.Session.GetString("user_account");

                if (account == null)
                {
                    return new
                    {
                        result = 401,
                        msg = "not login"
                    };
                }

                var re = ProgrammeServer.GetAllProgrammeWithImagePath();

                return re;
            }
            catch (Exception e)
            {
                return new
                {
                    result = e.HResult,
                    msg = e.Message
                };
            }
        }
        
        /// <summary>
        /// 查询具体剧目信息
        /// </summary>
        /// <param name="programmeName">剧目名称</param>
        /// <returns></returns>
        [HttpGet("[action]/{programmeName}")]
        public object QueryProgrammeByName(string programmeName)
        {
            try
            {
//                var addr = Server.GetUserIp(Request.HttpContext);
//                if (Server.IpHandle(addr) == 0)
//                {
//                    return new[] {"your ip can't using our api , please contact administrator"};
//                }
//
                var account = HttpContext.Session.GetString("user_account");

                if (account == null)
                {
                    return new
                    {
                        result = 401,
                        msg = "not login"
                    };
                }

                var re = ProgrammeServer.QueryProgramme(programmeName);

                return re;
            }
            catch (Exception e)
            {
                return new
                {
                    result = e.HResult,
                    msg = e.Message
                };
            }
        }

        /// <summary>
        /// 获得已有剧目标签
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public object GetAllTags()
        {
            try
            {
//                var addr = Server.GetUserIp(Request.HttpContext);
//                if (Server.IpHandle(addr) == 0)
//                {
//                    return new[] {"your ip can't using our api , please contact administrator"};
//                }
//
                var account = HttpContext.Session.GetString("user_account");

                if (account == null)
                {
                    return new
                    {
                        result = 401,
                        msg = "not login"
                    };
                }

                var re = ProgrammeServer.GetAllTags();

                return re;
            }
            catch (Exception e)
            {
                return new
                {
                    result = e.HResult,
                    msg = e.Message
                };
            }
        }

        /// <summary>
        /// 筛选海报
        /// </summary>
        /// <param name="programmeId">剧目ID</param>
        /// <returns></returns>
        [HttpGet("[action]/{programmeId}")]
        public object SelectPlayBill(int programmeId)
        {
            try
            {
//                var addr = Server.GetUserIp(Request.HttpContext);
//                if (Server.IpHandle(addr) == 0)
//                {
//                    return new[] {"your ip can't using our api , please contact administrator"};
//                }
//
                var account = HttpContext.Session.GetString("user_account");

                if (account == null)
                {
                    return new
                    {
                        result = 401,
                        msg = "not login"
                    };
                }

                var re = ProgrammeServer.SelectPlayBill(programmeId);

                return re;
            }
            catch (Exception e)
            {
                return new
                {
                    result = e.HResult,
                    msg = e.Message
                };
            }
        }

        
        
        /// <summary>
        /// 查询具体剧目信息
        /// </summary>
        /// <param name="programmeId">剧目ID</param>
        /// <returns></returns>
        [HttpGet("[action]/{programmeId}")]
        public object QueryProgrammeById(int programmeId)
        {
            try
            {
//                var addr = Server.GetUserIp(Request.HttpContext);
//                if (Server.IpHandle(addr) == 0)
//                {
//                    return new[] {"your ip can't using our api , please contact administrator"};
//                }
//
                var account = HttpContext.Session.GetString("user_account");

                if (account == null)
                {
                    return new
                    {
                        result = 401,
                        msg = "not login"
                    };
                }

                var re = ProgrammeServer.QueryProgramme(programmeId);

                return re;
            }
            catch (Exception e)
            {
                return new
                {
                    result = e.HResult,
                    msg = e.Message
                };
            }
        }
        
        /// <summary>
        /// 更新剧目
        /// </summary>
        /// <param name="env">更新剧目模型</param>
        /// <returns>更新结果</returns>
        [HttpPost("[action]")]
        public object UpdateProgramme([FromServices] IHostingEnvironment env)
        {
            try
            {
//                var addr = Server.GetUserIp(Request.HttpContext);
//                if (Server.IpHandle(addr) == 0)
//                {
//                    return new[] {"your ip can't using our api , please contact administrator"};
//                }
//
                var account = HttpContext.Session.GetString("user_account");

                if (account == null)
                {
                    return new
                    {
                        result = 401,
                        msg = "not login"
                    };
                }

                
                var programmeId = int.Parse(Request.Form.First(c => c.Key == "programmeId").Value);
                var programmeName = Request.Form.First(c => c.Key == "programmeName").Value;
                var duration = int.Parse(Request.Form.First(c => c.Key == "duration").Value);
                var profile = Request.Form.First(c => c.Key == "profile").Value;
                var tags = Request.Form.First(c => c.Key == "tags").Value;
                var fileName = "";
                var files = Request.Form.Files;
                if (files.Count != 0)
                {
                    var file = files[0];
                    fileName = DateTime.Now.Ticks + ContentDispositionHeaderValue
                                       .Parse(file.ContentDisposition)
                                       .FileName
                                       .Trim().Value;
                    //var imagePath = env.WebRootPath + @"./PlayBill/" +  DateTime.Now.Ticks + $@"{fileName}"; // in unix
                    var imagePath = @"C:\\PlayBill\" + $@"{fileName}";
                    using (var fs = System.IO.File.Create(imagePath))
                    {
                        file.CopyTo(fs);
                        fs.Flush();
                    }
                }

                var cm = new UpdateProgrammeModel
                {
                    ProgrammeId = programmeId,
                    ProgrammeName = programmeName,
                    Duration = duration,
                    Profile = profile,
                    Tags = tags
                };   

                var re = ProgrammeServer.UpdateAndPlayBill(cm, fileName);

                return re;
            }
            catch (Exception e)
            {
                return new
                {
                    result = e.HResult,
                    msg = e.Message
                };
            }
        }
        
        /// <summary>
        /// 使用剧目标签筛选剧目
        /// </summary>
        /// <param name="tags">标签</param>
        /// <returns>剧目</returns>
        [HttpGet("[action]/{tags}")]
        public object SelectProgrammeBytags(string tags)
        {
            try
            {
//                var addr = Server.GetUserIp(Request.HttpContext);
//                if (Server.IpHandle(addr) == 0)
//                {
//                    return new[] {"your ip can't using our api , please contact administrator"};
//                }
//
                var account = HttpContext.Session.GetString("user_account");

                if (account == null)
                {
                    return new
                    {
                        result = 401,
                        msg = "not login"
                    };
                }

                var re = ProgrammeServer.SelectProgramme(tags);

                return re;
            }
            catch (Exception e)
            {
                return new
                {
                    result = e.HResult,
                    msg = e.Message
                };
            }
        }

        /// <summary>
        /// 上传海报
        /// </summary>
        /// <param name="env"></param>
        /// <param name="programmeId"></param>
        /// <returns></returns>
        [HttpPost("[action]/{programmeId}")]
        public object UploadPlayBill([FromServices] IHostingEnvironment env, int programmeId)
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = DateTime.Now.Ticks + ContentDispositionHeaderValue
                                   .Parse(file.ContentDisposition)
                                   .FileName
                                   .Trim().Value;
                //var filePath = env.WebRootPath + @"./PlayBill/" +  DateTime.Now.Ticks + $@"{fileName}"; // in unix
                var filePath = @"C:\\PlayBill\" + $@"{fileName}"; // in windows

                using (var fs = System.IO.File.Create(filePath))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }

                var re = ProgrammeServer.UploadPlayBill(programmeId, fileName);

                return re;
            }
            catch (Exception e)
            {
                return new
                {
                    result = e.HResult,
                    msg = e.Message
                };
            }
        }


        /// <summary>
        /// 新建剧目
        /// </summary>
        /// <param name="env">系统</param>
        /// <param name="cm">待新建的剧目</param>
        /// <returns>新建结果</returns>
        [HttpPost("[action]")]
        public object CreateProgramme([FromServices] IHostingEnvironment env, [FromBody] CreateProgrammeModel cm)
        {
            try
            {
//                var addr = Server.GetUserIp(Request.HttpContext);
//                if (Server.IpHandle(addr) == 0)
//                {
//                    return new[] {"your ip can't using our api , please contact administrator"};
//                }
//
                var account = HttpContext.Session.GetString("user_account");

                if (account == null)
                {
                    return new
                    {
                        result = 401,
                        msg = "not login"
                    };
                }

                var re = ProgrammeServer.CreateProgramme(cm);

                return re;
            }
            catch (Exception e)
            {
                return new
                {
                    result = e.HResult,
                    msg = e.Message
                };
            }
        }

        /// <summary>
        /// 新建剧目（同时上传海报）
        /// </summary>
        /// <param name="env">系统</param>
        /// <returns>新建结果</returns>
        [HttpPost("[action]")]
        public object CreateProgrammeAndPlayBill([FromServices] IHostingEnvironment env)
        {
            try
            {
//                var addr = Server.GetUserIp(Request.HttpContext);
//                if (Server.IpHandle(addr) == 0)
//                {
//                    return new[] {"your ip can't using our api , please contact administrator"};
//                }
//
                var account = HttpContext.Session.GetString("user_account");

                if (account == null)
                {
                    return new
                    {
                        result = 401,
                        msg = "not login"
                    };
                }

                var files = Request.Form.Files;
                var programmeName = Request.Form.First(c => c.Key == "programmeName").Value;
                var duration = int.Parse(Request.Form.First(c => c.Key == "duration").Value);
                var profile = Request.Form.First(c => c.Key == "profile").Value;
                var tags = Request.Form.First(c => c.Key == "tags").Value;

                var file = files[0];
                var fileName = DateTime.Now.Ticks + ContentDispositionHeaderValue
                                   .Parse(file.ContentDisposition)
                                   .FileName
                                   .Trim().Value;
                //var imagePath = env.WebRootPath + @"./PlayBill/" +  DateTime.Now.Ticks + $@"{fileName}"; // in unix
                var imagePath = @"C:\\PlayBill\" + $@"{fileName}"; // in windows

                var cm = new CreateProgrammeModel
                {
                    ProgrammeName = programmeName,
                    Duration = duration,
                    Profile = profile,
                    Tags = tags
                };

                using (var fs = System.IO.File.Create(imagePath))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }

                var re = ProgrammeServer.CreateProgrammeAndPlayBill(cm, fileName);

                return re;
            }
            catch (Exception e)
            {
                return new
                {
                    result = e.HResult,
                    msg = e.Message
                };
            }
        }


        /// <summary>
        /// 删除剧目
        /// </summary>
        /// <param name="id">剧目Id</param>
        /// <returns>删除结果</returns>
        [HttpDelete("[action]/{id}")]
        public object DeleteProgramme(int id)
        {
            try
            {
//                var addr = Server.GetUserIp(Request.HttpContext);
//                if (Server.IpHandle(addr) == 0)
//                {
//                    return new[] {"your ip can't using our api , please contact administrator"};
//                }
//
                var account = HttpContext.Session.GetString("user_account");

                if (account == null)
                {
                    return new
                    {
                        result = 401,
                        msg = "not login"
                    };
                }

                var re = ProgrammeServer.DeleteProgramme(id);

                return re;
            }
            catch (Exception e)
            {
                return new
                {
                    result = e.HResult,
                    msg = e.Message
                };
            }
        }
    }
}