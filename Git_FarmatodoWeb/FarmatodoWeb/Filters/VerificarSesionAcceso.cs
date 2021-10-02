using Microsoft.AspNetCore.Mvc.Filters;
using FarmatodoWeb.Models;
using Microsoft.AspNetCore.Http;
using FarmatodoWeb.Controllers;

namespace FarmatodoWeb.Filters
{
    public class VerificarSesionAcceso: ActionFilterAttribute{
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var Logueado=/*(Persona)*/AppHttpContext.Current.Session.GetString("Logueado");
            if(Logueado==null){
                if(context.Controller is AccesoController==true){
                    //context.HttpContext.Response.Redirect("/Home/Index");
                }
            }else{
                if(context.Controller is AccesoController==true){
                    context.HttpContext.Response.Redirect("/Home/Index");
                }
            }
            base.OnActionExecuting(context);
        }
    }
}