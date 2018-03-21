using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrnoMVC1.Web.HTMLHelpers
{
    public static class HTMLHelperExtension
    {
        public static MvcHtmlString ModalDialog(this HtmlHelper htmlHelper, string header, string body, string close)
        {
            string BsModal = $@"
                <!-- Modal -->
                <div id = ""myModal"" class=""modal fade"" role=""dialog"">
                  <div class=""modal-dialog"">

                    <!-- Modal content-->
                    <div class=""modal-content"">
                      <div class=""modal-header"">
                        <button type = ""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                        <h4 class=""modal-title""> { header} </h4>
                        </div>
                          <div class=""modal-body"">
                            <p> {body} </p>
                          </div>
                          <div class=""modal-footer"">
                            <button type = ""button"" class=""btn btn-default"" data-dismiss=""modal""> { close} </button>
                          </div>
                        </div>

                  </div>
                </div>
            ";


            return MvcHtmlString.Create(BsModal);

        }





    }
}