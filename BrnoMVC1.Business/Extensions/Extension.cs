using BrnoMVC1.Business.ActionResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BrnoMVC1.Business.Extensions
{
    public static class Extension
    {
        public static XMLActionResult Xml(this Controller controller, object obj)
        {
            return new XMLActionResult(obj);
        }
    }
}
