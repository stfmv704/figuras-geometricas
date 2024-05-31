﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Circulo : Figura //Esta es una clase hija de figura
    {
        //usamos el constructor de la clase padre
        public Circulo(float radio)
        {   //radio se va a leer de la caja de texto con usando el boton guardar
            Lado1 = radio;
        }
        //vamos a usar los métodos de la clase padre
        //vamos a sobreesribir el comportamiento de estos
        public override float area() //Aquí se calcula el área
        {
            return 3.1416F * Lado1 * Lado1;
            //AGREGAMOS F AL FINAL DE UN NUMERO CUANDO
            //ES UNA CONSTANTE NO DEFINIDA EN UNA VARIABLE
            //PREVIAMENTE, ASI EL PROGRAMA SABE QUE ES UN #
        }

        public override float perimetro() //Aquí se calcula el perímetro
        {
            return 3.1416F * 2 * Lado1;
        }

        public override float volumen() //Aquí se calcula el volumen, al ser una figura de dos dimensiones se hace una exepcion
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}