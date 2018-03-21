using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BrnoMVC1.Business.ActionResults

{

    public class XMLActionResult : ActionResult
    {
        public object obj { get; set; }

        public XMLActionResult(object obj)
        {
           
            this.obj = obj;
           
        }

        public override void ExecuteResult(ControllerContext context)
        {
            context.HttpContext.Response.Clear();
            var xmlS = new System.Xml.Serialization.XmlSerializer(this.obj.GetType());
            context.HttpContext.Response.ContentType = "text/xml";
            xmlS.Serialize(context.HttpContext.Response.Output, this.obj);
        }
    }
}
