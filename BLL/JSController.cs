﻿using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosApp.BLL
{
    public static class JSController
    {
        public async static Task<bool> ConfirmDelete(this IJSRuntime js, string titulo, string Mensaje, string tipo)
        {
            return await js.InvokeAsync<bool>("ConfirmationPrumpt", titulo, Mensaje, tipo);
        }

        public async static Task<bool> Confirmar(this IJSRuntime js, string posicion, string icono, string titulo, string texto, bool confbtn, int timer)
        {
            return await js.InvokeAsync<bool>("SavePrumpt", posicion, icono, titulo, texto, confbtn, timer);
        }

        public static ValueTask<object> SaveAs(this IJSRuntime js, string filename, byte[] data)
       => js.InvokeAsync<object>(
           "saveAsFile",
           filename,
           Convert.ToBase64String(data));
    }
}
