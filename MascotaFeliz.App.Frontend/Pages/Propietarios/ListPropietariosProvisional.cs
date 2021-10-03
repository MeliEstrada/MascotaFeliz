using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia.AppMemoriaTemporal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class ListPropietariosProvisionalModel : PageModel
    {
        private readonly IMemoriaPropietario memoriaPropietario;
        public IEnumerable<Propietario> Propietarios {get;set;}

        public ListPropietariosProvisionalModel(IMemoriaPropietario memoriaPropietario)
        {
            this.memoriaPropietario = memoriaPropietario;
        }
       
        public void OnGet()
        {
            Propietarios = memoriaPropietario.GetAll();
        }
    }
}
