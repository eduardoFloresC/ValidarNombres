using System;

namespace ValidarNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //Lineas para ingresar el texto de prueba y probar la función.
            string nombre = Console.ReadLine();
            Console.WriteLine(ValidName(nombre));
            */
        }

        public static bool ValidName(string nombre)//Funcion que valida el nombre
        {
            bool respuesta = false;
            string[] subs = nombre.Split(' ');
            int size_variable = subs.Length;
            if (size_variable>1 && size_variable<4)//si tiene entre 2 y 3 palabras, condición principal
            {
                respuesta = cumpleMayusculas(subs);
                if (respuesta)
                {
                    switch (size_variable)
                    {
                        case 2://si son 2 palabras
                            if (subs[0].Length < 3)//si la primera palabra es de longitud 2
                            {
                                //evalúo la primera palabra
                                if (!terminaEnPunto(subs[0]) || subs[0].Length==1)//Si no es inicial seguida de punto
                                {
                                    respuesta = false;
                                }
                                else
                                {
                                    if (subs[1].Length<2)
                                    {
                                        respuesta = false;
                                    }
                                    else
                                    {
                                        if (!terminaEnPunto(subs[1]))
                                        {
                                            respuesta = true;
                                        }
                                        else
                                        {
                                            respuesta = false;
                                        }
                                    }
                                    
                                }
                            }
                            else
                            {
                                if (terminaEnPunto(subs[0]) || terminaEnPunto(subs[1])) //si es una palabra y termina en punto
                                {
                                    respuesta = false;
                                }
                                else
                                {
                                    if (subs[1].Length<3)
                                    {
                                        respuesta = false;
                                    }
                                    else
                                    {
                                        respuesta = true;
                                    }                                    
                                }
                            }
                            break;
                        case 3://si son 3 palabras
                            if (subs[0].Length < 3)//si la primera palabra es de longitud 2
                            {
                                //evalúo la primera palabra
                                if (terminaEnPunto(subs[0]) && subs[0].Length == 2)//Si  es inicial seguida de punto
                                {
                                    if (terminaEnPunto(subs[1]) && subs[1].Length == 2)//si la 2da palabra es inicial seguida de punto
                                    {
                                        if (subs[2].Length < 2)
                                        {
                                            respuesta = false;
                                        }
                                        else
                                        {
                                            if (!terminaEnPunto(subs[2]))
                                            {
                                                respuesta = true;
                                            }
                                            else
                                            {
                                                respuesta = false;
                                            }
                                        }
                                    }
                                    else {
                                        respuesta = false;
                                    }
                                }
                                else
                                {
                                    if (subs[0].Length < 2)
                                    {
                                        respuesta = false;
                                    }
                                    else
                                    {
                                        if (terminaEnPunto(subs[0]))//si la primera termina en punto
                                        {
                                            respuesta = false;
                                        }
                                        else
                                        {
                                            if (!terminaEnPunto(subs[1]))
                                            {
                                                respuesta = true;
                                            }
                                            else
                                            {
                                                respuesta = false;
                                            }
                                        }
                                        
                                    }

                                }
                            }
                            else
                            {
                                if (terminaEnPunto(subs[0]))//si la primera palabra termina en "."
                                {
                                    respuesta = false;
                                }
                                else
                                {
                                    if (subs[1].Length == 2 && terminaEnPunto(subs[1]))
                                    //si es una palabra y termina en punto
                                    {
                                        if (subs[2].Length < 2)
                                        {
                                            respuesta = false;
                                        }
                                        else
                                        {
                                            if (!terminaEnPunto(subs[2]))
                                            {
                                                respuesta = true;
                                            }
                                            else
                                            {
                                                respuesta = false;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (subs[1].Length < 2 || terminaEnPunto(subs[1])   )
                                        {
                                            respuesta = false;
                                        }
                                        else
                                        {
                                            respuesta = true;
                                        }
                                    }
                                }
                                
                            }
                            break;
                    }
                }
                else
                {
                    return false;
                }
            }
            else {
                return false;
            }
            return respuesta;
            

            static bool cumpleMayusculas(string[] nombre)//funcion que me devuelve true si cumple la condicion de que todas las palabras empiezan con mayuscula
            {
                bool condicion = true;
                foreach (string palabra in nombre)
                {
                    if (Char.IsUpper(palabra[0])&& condicion)
                    {
                        condicion = true;
                    }
                    else
                    {
                        condicion = false;
                    }
                }
                return condicion;
            }

            static bool terminaEnPunto(string palabra)
            {
                bool termina = false;
                if (palabra.Substring(palabra.Length - 1) == ".")
                {
                    termina = true;
                }
                return termina;
            }
        }// Fin de la Función que valida el nombre
    }
}
