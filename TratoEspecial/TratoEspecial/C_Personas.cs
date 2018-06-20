using System;
using System.Collections.Generic;
using System.Text;

namespace TratoEspecial.Personas
{
    class C_Login
    {
        string v_usuario="";
        string v_pass = "";

        public C_Login ()
        {
            this.v_usuario = "";
            this.v_pass = "";
        }
        public C_Login(string _usu, string _pass)
        {
            this.v_usuario =_usu ;
            this.v_pass = _pass;
        }

    }
    class C_Ind_Fisica
    {

        string v_Nombre="";
        //year dayofmonth, month   son int
        string v_Rfc;
        /// <summary>
        /// Fecha de nacimiento, tiene que ser dia mes año
        /// </summary>
        DateTime v_FecNaci;
        /// <summary>
        /// lugar de nacimiento
        /// </summary>
        string v_LugNac;
        string v_Ocup;
        string v_Tel;
        string v_Cel;
        string v_Calle;
        string v_NumExt;
        string v_NumInt;
        string v_Colonia;
        string v_Ciudad;
        string v_municipio;
        string v_Estado;
        string v_Cp;
        string v_Correo;
        const int Id=0;
        public C_Ind_Fisica()
        {
            this.v_Nombre = "";
            this.v_Rfc = "";
            //tiene que ser dia mes año
            this.v_FecNaci = new DateTime(0000, 00, 00);
            this.v_LugNac = "";
            this.v_Ocup = "";
            this.v_Tel = "";
            this.v_Cel = "";
            this.v_Calle = "";
            this.v_NumExt = "";
            this.v_NumInt = "";
            this.v_Colonia = "";
            this.v_Ciudad = "";
            this.v_municipio = "";
            this.v_Estado = "";
            this.v_Cp = "";
            this.v_Correo = "";
        }
        public C_Ind_Fisica(string _nom, string _rfc, DateTime _nac,
           string _lugnac, string _ocu, string _tel, string _cel, string _call,
           string _ext, string _int, string _col, string _ciud,string _muni ,string _est, string _cp, string _corr)
        {
            this.v_Nombre = _nom;
            this.v_Rfc = _rfc;
            //tiene que ser dia mes año
            this.v_FecNaci = _nac;
            this.v_LugNac = _lugnac;
            this.v_Ocup = _ocu;
            this.v_Tel = _tel;
            this.v_Cel = _cel;
            this.v_Calle = _call;
            this.v_NumExt = _ext;
            this.v_NumInt = _int;
            this.v_Colonia = _col;
            this.v_Ciudad = _ciud;
            this.v_municipio = _muni;
            this.v_Estado = _est;
            this.v_Cp = _cp;
            this.v_Correo = _corr;
        }

        public string Fn_GetInfo()
        {
            string _mensaje = v_Nombre + " " + v_Rfc + " " + v_FecNaci.ToString() + "" + v_LugNac + " " + v_Ocup +
                " " + v_Tel + " " + v_Cel + " " + v_Calle + " " + v_NumExt + " " + v_NumInt + " " + v_Colonia + " " +
                v_Ciudad + " " + v_municipio + " " + v_Estado + " " + v_Cp + " " + v_Correo;
            return  _mensaje;
        }
    }

    class C_Fam
    {
        string v_Nombre;
        string v_Parentesco;
        /// <summary>
        /// Fecha de nacimiento, tiene que ser dia mes año
        /// </summary>
        DateTime v_FecNaci;
        string v_Correo;
        string v_Cel;
        const int Id = 2;

        public C_Fam()
        {
            this.v_Nombre = "";
            this.v_Parentesco = "";
            this.v_FecNaci = new DateTime(0000, 00, 00);
            this.v_Correo = "";
            this.v_Cel = "";

        }
        public C_Fam(string _nom, string _paren, DateTime _nac,
           string _cel, string _corr)
        {
            this.v_Nombre = _nom;
            this.v_Parentesco = _paren;
            this.v_FecNaci = _nac;
            this.v_Correo = _corr;
            this.v_Cel = _cel;
        }
        public string Fn_GetInfo()
        {
            return "";
        }


    }

    class C_Ind_Moral
    {
        /// <summary>
        /// nombre oi razon social
        /// </summary>
        string v_Nombre;
        string v_Rfc;
        string v_Calle;
        string v_NumExt;
        string v_NumInt;
        string v_Colonia;
        string v_Ciudad;
        string v_municipio;
        string v_Estado;
        string v_Cp;
        string v_Giro;
        string v_Tel;
        string v_Correo;
        const int Id = 1;


        public C_Ind_Moral()
        {
            this.v_Nombre = "";
            this.v_Rfc = "";
            this.v_Tel = "";
            this.v_Calle = "";
            this.v_NumExt = "";
            this.v_NumInt = "";
            this.v_Colonia = "";
            this.v_Ciudad = "";
            this.v_municipio = "";
            this.v_Estado = "";
            this.v_Cp = "";
            this.v_Giro = "";
            this.v_Correo = "";
        }
        public C_Ind_Moral(string _nom, string _rfc, string _giro, string _tel, string _call,
           string _ext, string _int, string _col, string _ciud, string _muni, string _est, string _cp, string _corr)
        {
            this.v_Nombre = _nom;
            this.v_Rfc = _rfc;
            this.v_Calle = _call;
            this.v_NumExt = _ext;
            this.v_NumInt = _int;
            this.v_Colonia = _col;
            this.v_Ciudad = _ciud;
            this.v_municipio = _muni;
            this.v_Estado = _est;
            this.v_Cp = _cp;
            this.v_Giro = _giro;
            this.v_Tel = _tel;
            this.v_Correo = _corr;
        }

        public string Fn_GetInfo()
        {
            string _mensaje = v_Nombre + " " + v_Rfc + " " + v_Calle + " " + v_NumExt + " " + v_NumInt + "  " +
                v_Colonia + " " + v_Ciudad + " " + v_municipio + " " + v_Estado + " " +
                v_Cp + " " + v_Giro + " " + v_Tel + " " + v_Correo;

            return _mensaje;
        }

    }

    class C_Emp_Empleado
    {
        /// <summary>
        /// nombre de la emopresa
        /// </summary>
        string v_NombreEmp;
        /// <summary>
        /// numero de empleado en la empresa
        /// </summary>
        string v_NumeroEmp;
        /// <summary>
        /// nombre completo del empleado
        /// </summary>
        string v_Nombre;
        /// <summary>
        /// Fecha de nacimiento, tiene que ser dia mes año
        /// </summary>
        DateTime v_FecNaci;
        string v_Correo;
        string v_Cel;
        const int Id = 3;
        public C_Emp_Empleado()
        {
            this.v_NombreEmp = "";
            this.v_NumeroEmp = "";
            this.v_Nombre = "";
            this.v_FecNaci = new DateTime(0000, 00, 00);
            this.v_Cel = "";
            this.v_Correo = "";

        }
        public C_Emp_Empleado(string _nomEmp, string _num, string _nombre, DateTime _nac,
           string _cel, string _corr)
        {

            this.v_NombreEmp = _nomEmp;
            this.v_NumeroEmp = _num;
            this.v_Nombre = _nombre;
            this.v_FecNaci = _nac;
            this.v_Cel = _cel;
            this.v_Correo = _corr;
        }

        public string Fn_GetInfo()
        {
            string _mensaje = v_NombreEmp + " " + v_NumeroEmp + " " + v_Nombre + " " +
                v_FecNaci.ToString() + " " + v_Correo + v_Cel;
            return _mensaje;
        }

    }
}
