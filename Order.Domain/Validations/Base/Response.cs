using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Validations.Base
{
    public class Response
    {
        public Response()
        {
            Report = new List<Report>();
        }

        public Response(List<Report> reports)
        {
            Report = reports;
        }

        public Response(Report report) :this(new List<Report>() { report})
        {

        }

        public List<Report> Report { get; }
    }

    public class Response<T> : Response
    {
        public Response()
        {
        }

        public Response(T data, List<Report> reports = null) : base()
        {
            Data = data;
        }

        public T Data { get; set; }
    }

}
