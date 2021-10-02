using Microsoft.AspNetCore.Mvc.Filters;
using FarmatodoWeb.Models;
using Microsoft.AspNetCore.Http;
using FarmatodoWeb.Controllers;
using System;

namespace FarmatodoWeb.Filters
{
    public class VerificarSesionCliente: ActionFilterAttribute{
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var Logueado=/*(Persona)*/AppHttpContext.Current.Session.GetString("Logueado");
            if(Logueado==null){
                if(context.Controller is ClienteController==false){
                    //Cuando regresa a una página de filtro y no está logueado
                    //context.HttpContext.Response.Redirect("/Acceso/Index");
                    Console.WriteLine("Permiso: Denegado | Logueado: No | Controlador Cliente: false | Rol Actual: "+PersonaBase.Rol);
                    context.HttpContext.Response.Redirect("/Home/IndexM");
                }else{
                    Console.WriteLine("Permiso: Denegado | Logueado: No | Controlador Cliente: true | Rol Actual: "+PersonaBase.Rol);
                    context.HttpContext.Response.Redirect("/Producto/List");
                }
            }else{
                //Cuando eres cliente se te activa el ClienteController
                if(context.Controller is ClienteController==true){
                    if(PersonaBase.Rol!="Cliente" && PersonaBase.Rol!="Administrador"){
                        //Cuando regresa a una página de filtro y está logueado
                        //context.HttpContext.Response.Redirect("/Home/Asd");
                        Console.WriteLine("Permiso: Denegado | Vista para: Cliente, Administrador | Rol Actual: "+PersonaBase.Rol);
                        context.HttpContext.Response.Redirect("/Producto/List");
                    }else{
                        //Console.WriteLine("no es cliente, ni tampoco administrador: ");
                        Console.WriteLine("Permiso: Accedido | Vista para: Cliente, Administrador | Rol Actual: "+PersonaBase.Rol);
                    }
                }
            }
            base.OnActionExecuting(context);
        }
    }
}