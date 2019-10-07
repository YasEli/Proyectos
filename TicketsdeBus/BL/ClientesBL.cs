using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsdeBus.Modelos;

namespace TicketsdeBus.BL
{
    public class ClientesBL
    {
        public BindingList<Cliente> ListadeClientes { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new BindingList<Cliente>();
            CargarDatos();        
        }
        private void CargarDatos()
        {
            
            var cliente1 = new Cliente(1, "Ana", "Ordoñez", "98678656");
            var cliente2 = new Cliente(2, "Sara", "Guifarro", "96374859");
            var cliente3 = new Cliente(3, "Greysi", "Toro", "94567634");
            var cliente4 = new Cliente(4, "Edith", "Lopez", "92345676");
            var cliente5 = new Cliente(5, "Alejandro", "Melgar", "92345676");
            var cliente6 = new Cliente(6, "Jorge", "Mejia", "92345676");
            var cliente7 = new Cliente(7, "Manuel", "Lara", "92345676");

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
            ListadeClientes.Add(cliente4);
            ListadeClientes.Add(cliente5);
            ListadeClientes.Add(cliente6);
            ListadeClientes.Add(cliente7);

        }
    }
}
