using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Cola
{
    public class Cola
    {
        Nodo inicio;
        Nodo fin;

        public Cola() 
        {
            inicio = null;
            fin = null;
        }

        public void insertar(int orden)
        { 
            Nodo nodo = new Nodo(orden);
            if (inicio == null)
            { 
                inicio = nodo;
                fin = nodo;
            }
            else 
            { 
                fin.siguiente = nodo;
                fin = nodo;
            
            }
        }
        public void listar(ListBox listaCola)
        {
            listaCola.Items.Clear();
            if (inicio == null) listaCola.Items.Add("Lista Vacia");
            else
            {
                Nodo actual = inicio;
                while (actual != null)
                {
                    listaCola.Items.Add(actual.orden);
                    actual = actual.siguiente;
                }
            }
        }

        public string eliminar()
        {
            if (inicio == null) return "La lista esta vacia";
            else
            {
                Nodo aux = inicio;
                inicio = aux.siguiente;
                aux = null;
                if (inicio == null) fin = null;
                return "Elemento eliminado";
            }
        }

        public string buscarPosicion(int orden)
        {
            string Mensaje = "";
            
            if (inicio == null) Mensaje = "Lista Vacia";
            else
            {
                Nodo actual = inicio;
                int posicion = 1;
                while (actual != null)
                {
                    if (actual.orden == orden)
                    {
                        Mensaje = "Encontrado en posicion " + posicion;
                        break;
                    }
                    posicion++;
                    actual = actual.siguiente;
                }
            }
            if (Mensaje == "") Mensaje = "El elemento no existe en la cola";
            return Mensaje;
        }
    }
}
