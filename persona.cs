using System;

namespace IMC;

public class Persona
{
    public string nombre { get; set; }
    public int edad { get; set; }
    public float peso { get; set; }
    public float altura { get; set; }
    public string sexo { get; set; }
    public string correo { get; set; }
    public string direccion { get; set; }
    public int telefono { get; set; }

    public Persona()
    {
        this.nombre = "";
        this.edad = 0;
        this.peso = 0;
        this.altura = 0;
        this.sexo = "";
        this.correo = "";
        this.direccion = "";
        this.telefono = 0;
    }

    

}
