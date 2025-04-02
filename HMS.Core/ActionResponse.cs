using HMS.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HMS.Core
{
    public class ActionResponse
    {
        public int StatusCode { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public ResponseType  ResponseType{ get; set; }
    }
public enum ResponseType
{
    Ok =1,
    Warning =2,
    Error =3,
}
    //Burada IBaseDto'dan kalıtım alıyordu GetAll methodları için list dönmek gerekli olduğu için kaldırdım 
    public class ActionResponse<T> : ActionResponse
    {

        public T? Data { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        public T? DataList { get; set; }

        public List<string> Errors { get; set; }


        public static ActionResponse<T> Ok(T data)
        {
            return new ActionResponse<T> { Data = data, StatusCode = HttpStatusCode.OK, IsSuccessful = true};
        }
        public static ActionResponse<List<T>> OkList(List<T> data)
        {
            return new ActionResponse<List<T>> { DataList = data, StatusCode = HttpStatusCode.OK, IsSuccessful = true };
        }

        public static ActionResponse<T> NoContent()
        {
            return new ActionResponse<T> {StatusCode = HttpStatusCode.NoContent, IsSuccessful = true};
        }

        public static ActionResponse<T> BadRequest(List<string> errors)
        {
            return new ActionResponse<T> { Errors = errors,  StatusCode = HttpStatusCode.BadRequest, IsSuccessful = false };
        }
        public static ActionResponse<T> BadRequest(string error)
        {

            return new ActionResponse<T> { Errors = new List<string> { error }, StatusCode = HttpStatusCode.BadRequest, IsSuccessful = false, Message = error };
        }


    }
}
