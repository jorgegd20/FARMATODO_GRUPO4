using Microsoft.AspNetCore.Mvc.Filters;
using FarmatodoWeb.Models;
using Microsoft.AspNetCore.Http;
using FarmatodoWeb.Controllers;
using System;

namespace FarmatodoWeb.Filters
{
    public class VerificarSesionAdministrador: ActionFilterAttribute{
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var Logueado=/*(Persona)*/AppHttpContext.Current.Session.GetString("Logueado");
            if(Logueado==null){
                if(context.Controller is AdministradorController==false){
                    //Cuando regresa a una página de filtro y no está logueado
                    //context.HttpContext.Response.Redirect("/Acceso/Index");
                    Console.WriteLine("Permiso: Denegado | Logueado: No | Controlador Administrador: false | Rol Actual: "+PersonaBase.Rol);
                    context.HttpContext.Response.Redirect("/Producto/ListX");
                }else{
                    Console.WriteLine("Permiso: Denegado | Logueado: No | Controlador Administrador: true | Rol Actual: "+PersonaBase.Rol);
                    context.HttpContext.Response.Redirect("/Producto/List");
                }
            }else{
                //Cuando eres admi se te activa el AdministradorController
                if(context.Controller is AdministradorController==true){
                    if(PersonaBase.Rol!="Administrador"){
                        //Cuando regresa a una página de filtro y está logueado
                        //context.HttpContext.Response.Redirect("/Home/Asd");
                        Console.WriteLine("Permiso: Denegado | Vista para: Administrador | Rol Actual: "+PersonaBase.Rol);
                        context.HttpContext.Response.Redirect("/Producto/List");
                    }else{
                        //Console.WriteLine("sí es admi: ");
                        Console.WriteLine("Permiso: Accedido | Vista para: Administrador | Rol Actual: "+PersonaBase.Rol);
                    }
                }else{
                    
                        Console.WriteLine("q es admi: ");
                }
            }
            base.OnActionExecuting(context);
        }
    }
}