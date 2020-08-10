using System;
using System.Collections;

namespace proyecto_final_estacion_de_servicio
{
    //************************************ EXCEPCIONES *******************************************
    class CampoVacioException : Exception { }
    class TipoDeDatoException : Exception { }
    class FueraDeRangoException : Exception { }
    class OpcionIncorrectaException : Exception { }
    //*********************************** CLASE PLAYERO ******************************************
    public class playero
    {
        public int idPlayero;
        public string nombre_apellido;
        string horarioLaboral;
        string dni;
        public double montoTotalVendidoPorDia;
        public ArrayList playeros = new ArrayList();
        public void altaPlayero()
        {
            string letras = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,ñ,o,p,q,r,s,t,u,v,w,x,y,z,A,B,C,D,E,F,G,H,I,J,K,L,M,N,Ñ,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            string[] abecedario = letras.Split(new char[] { ',' });
            string numeros = "0,1,2,3,4,5,6,7,8,9";
            string[] partes = numeros.Split(new char[] { ',' });
            Console.WriteLine("Ingrese nombre y apellido: ");
            Console.Write("- ");
            nombre_apellido = "";
            try
            {
                nombre_apellido = Console.ReadLine();
                foreach (string parte in partes)
                {
                    if (nombre_apellido.Contains(parte))
                    {
                        throw new TipoDeDatoException();
                    }
                }
                if (nombre_apellido == "")
                {
                    throw new CampoVacioException();
                }
            }
            catch (CampoVacioException)
            {
                Console.WriteLine("Ingrese los datos solicitados. . . ");
                return;
            }
            catch (TipoDeDatoException)
            {
                Console.WriteLine("No ingreso un nombre valido. . . ");
                return;
            }
            Console.WriteLine("Ingrese DNI: ");
            Console.Write("- ");
            dni = "";
            try
            {
                dni = Console.ReadLine();
                foreach (string letra in abecedario)
                {
                    if (dni.Contains(letra))
                    {
                        throw new TipoDeDatoException();
                    }
                }
                if (dni == "")
                {
                    throw new CampoVacioException();
                }
            }
            catch (CampoVacioException)
            {
                Console.WriteLine("Ingrese los datos solicitados. . . ");
                return;
            }
            catch (TipoDeDatoException)
            {
                Console.WriteLine("No ingreso un DNI valido. . . ");
                return;
            }
            Console.WriteLine("Ingrese horario de trabajo: ");
            Console.Write("- ");
            horarioLaboral = "";
            try
            {
                horarioLaboral = Console.ReadLine();
                if (horarioLaboral == "")
                {
                    throw new CampoVacioException();
                }
            }
            catch (CampoVacioException)
            {
                Console.WriteLine("Ingrese los datos solicitados. . . ");
                return;
            }
            montoTotalVendidoPorDia = 0;
            playero p = new playero();
            int coincidencia = 0;
            foreach (playero py in playeros)
            {
                if (py.dni == dni)
                {
                    coincidencia++;
                }
            }
            if (coincidencia == 0 && playeros != null)
            {
                p.idPlayero = playeros.Count + 1;
                p.nombre_apellido = nombre_apellido;
                p.dni = dni;
                p.horarioLaboral = horarioLaboral;
                p.montoTotalVendidoPorDia = montoTotalVendidoPorDia;
                playeros.Add(p);
                Console.WriteLine("El playero ha sido agregado con exito. . . ");
            }
            else
            {
                Console.WriteLine("Ya existe un playero con ese DNI. . . ");
            }
        }
        public void bajaPlayero()
        {
            Console.WriteLine("Ingrese el numero de playero a dar de baja: ");
            Console.Write("- ");
            int elementoBorrar = 0;
            try
            {
                elementoBorrar = int.Parse(Console.ReadLine());
                elementoBorrar -= 1;
                playeros.RemoveAt(elementoBorrar);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ha ingresado una opcion no valida. . . ");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ha ingresado un caracter no valido. . . ");
                return;
            }
        }
        public void listaPlayeros()
        {
            int posicion = 1;
            foreach (playero p in playeros)
            {
                Console.WriteLine(posicion + "- " + p.nombre_apellido + ".");
                posicion++;
            }
        }
    }
    //********************************** CLASE PROMOCION *****************************************
    public class promocion
    {
        string tarjetaAplica;
        public string tipo;
        public int puntos;
        public double porcentaje;
        public ArrayList promociones = new ArrayList();
        public void altaPromocion()
        {
            string numeros = "0,1,2,3,4,5,6,7,8,9";
            string[] partes = numeros.Split(new char[] { ',' });
            promocion p = new promocion();
            Console.WriteLine("Ingrese tipo de promocion <1- puntos; o 2- descuento>: ");
            Console.Write("- ");
            int opcion = 0;
            try
            {
                opcion = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ha ingresado un caracter no valido. . . ");
                Console.WriteLine();
                return;
            }
            Console.WriteLine();
            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Ingrese una opcion valida. . . ");
                    Console.WriteLine();
                    break;
                case 1:
                    tipo = "puntos";
                    Console.WriteLine("Ingrese la cantidad de puntos a sumar por litro: ");
                    Console.Write("- ");
                    try
                    {
                        puntos = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ha ingresado un caracter no valido. . . ");
                        return;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Ingrese nombre de la tarjeta de puntos: ");
                    Console.Write("- ");
                    try
                    {
                        tarjetaAplica = Console.ReadLine();
                        if (tarjetaAplica == "")
                        {
                            throw new CampoVacioException();
                        }
                    }
                    catch (CampoVacioException)
                    {
                        Console.WriteLine("Ingrese los datos solicitados. . . ");
                        return;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ha ingresado un caracter no valido. . . ");
                        return;
                    }
                    Console.WriteLine();
                    p.tipo = tipo;
                    p.puntos = puntos;
                    p.tarjetaAplica = tarjetaAplica;
                    promociones.Add(p);
                    break;
                case 2:
                    tipo = "descuento";
                    Console.WriteLine("Ingrese porcentaje de descuento aplicado sobre la operacion: ");
                    Console.Write("- ");
                    try
                    {
                        porcentaje = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ha ingresado un caracter no valido. . . ");
                        return;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Ingrese la tarjeta sobre la cual se efectua el descuento: ");
                    Console.Write("- ");
                    try
                    {
                        tarjetaAplica = Console.ReadLine();
                        foreach (string parte in partes)
                        {
                            if (tarjetaAplica.Contains(parte))
                            {
                                throw new TipoDeDatoException();
                            }
                        }
                        if (tarjetaAplica == "")
                        {
                            throw new CampoVacioException();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ha ingresado un caracter no valido. . . ");
                        return;
                    }
                    catch (CampoVacioException)
                    {
                        Console.WriteLine("Ingrese los datos solicitados. . . ");
                        return;
                    }
                    catch (TipoDeDatoException)
                    {
                        Console.WriteLine("No ingreso un nombre de tarjeta valido. . . ");
                        return;
                    }
                    p.tipo = tipo;
                    p.porcentaje = porcentaje;
                    p.tarjetaAplica = tarjetaAplica;
                    promociones.Add(p);
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion valida. . .");
                    Console.WriteLine();
                    break;
            }
        }
        public void bajaPromocion()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese el numero de la promocion a dar de baja: ");
            Console.Write("- ");
            int elementoBorrar = 0;
            try
            {
                elementoBorrar = int.Parse(Console.ReadLine());
                elementoBorrar -= 1;
                promociones.RemoveAt(elementoBorrar);
                Console.WriteLine();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ha ingresado una opcion no valida. . . ");
                Console.WriteLine();
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ha ingresado un caracter no valido. . . ");
                Console.WriteLine();
                return;
            }
        }
        public void listaPromociones()
        {
            int posicion = 1;
            foreach (promocion pr in promociones)
            {
                if (pr.tipo == "puntos")
                {
                    Console.WriteLine(posicion + "- Suma " + pr.puntos + " puntos por cada litro cargado con " + pr.tarjetaAplica + ".");
                    posicion++;
                }
                if (pr.tipo == "descuento")
                {
                    Console.WriteLine(posicion + "- " + pr.porcentaje + "% de descuento con Tarjeta " + pr.tarjetaAplica + ".");
                    posicion++;
                }
            }
        }
    }
    //********************************** CLASE SURTIDOR ******************************************
    public class surtidor
    {
        public int numero;
        public double valorLitro, stockRemanente, litrosVendidosPorDia;
        public string tipoCombustible;
        public bool estado;
        public double venta, descuentosAplicados;
        public playero playeroAsignado;
        public ArrayList surtidores = new ArrayList();
        public void habilitarSurtidor()
        {
            int cont = 0;
            Console.WriteLine("Listado de surtidores deshabilitados: ");
            Console.WriteLine();
            foreach (surtidor s in surtidores)
            {
                if (s.estado == false)
                {
                    Console.WriteLine("Surtidor=" + s.numero + " - Tipo Comb:" + s.tipoCombustible + ".");
                    cont++;
                }
            }
            if (cont != 0)
            {
                Console.WriteLine();
                Console.Write("Ingrese el numero de surtidor que desea habilitar: ");
                int habilitar = 0;
                try
                {
                    habilitar = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ha ingresado un caracter no valido. . . ");
                    Console.WriteLine();
                    return;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Ha ingresado una opcion no valida. . . ");
                    Console.WriteLine();
                    return;
                }
                int habilito = 0;
                foreach (surtidor su in surtidores)
                {
                    if (habilitar == su.numero && su.estado == false)
                    {
                        habilito++;
                        su.estado = true;
                        Console.WriteLine("El surtidor nro " + su.numero + " ha sido habilitado.");
                        Console.WriteLine();
                        Console.WriteLine("(Para asignarle un playero desplacese al menu 'Playeros')");
                        return;
                    }
                }
                if (habilito == 0)
                {
                    Console.WriteLine("No ha ingresado un surtidor de la lista. . . ");
                }
            }
            if (cont == 0)
            {
                Console.WriteLine("No se encuentra ningun surtidor deshabilitado.");
            }
        }
        public void deshabilitarSurtidor()
        {
            int cont = 0;
            Console.WriteLine("Listado de surtidores habilitados: ");
            Console.WriteLine();
            foreach (surtidor s in surtidores)
            {
                if (s.estado == true)
                {
                    Console.WriteLine("Surtidor=" + s.numero + " - Tipo Comb:" + s.tipoCombustible + ".");
                    cont++;
                }
            }
            if (cont != 0)
            {
                Console.WriteLine();
                Console.Write("Ingrese el numero de surtidor que desea deshabilitar: ");
                int deshabilitar = 0;
                try
                {
                    deshabilitar = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ha ingresado un caracter no valido. . . ");
                    Console.WriteLine();
                    return;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Ha ingresado una opcion no valida. . . ");
                    Console.WriteLine();
                    return;
                }
                int deshabilito = 0;
                foreach (surtidor su in surtidores)
                {
                    if (deshabilitar == su.numero && su.estado == true)
                    {
                        deshabilito++;
                        su.estado = false;
                        su.playeroAsignado = null;
                        Console.WriteLine("El surtidor nro " + su.numero + " ha sido deshabilitado.");
                        return;
                    }
                }
                if (deshabilito == 0)
                {
                    Console.WriteLine("No ha ingresado un surtidor de la lista. . . ");
                }
            }
            if (cont == 0)
            {
                Console.WriteLine("No se encuentra ningun surtidor habilitado.");
            }
        }
        public void agregarSurtidor()
        {
            string numeros = "0,1,2,3,4,5,6,7,8,9";
            string[] partes = numeros.Split(new char[] { ',' });
            Console.WriteLine("Ingrese numero de surtidor: <1-6>");
            Console.Write("- ");
            numero = 0;
            try
            {
                numero = int.Parse(Console.ReadLine());
                if (surtidores.Count > 5)
                {
                    throw new FueraDeRangoException();
                }
                if (numero > 6 || numero < 1)
                {
                    throw new OpcionIncorrectaException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ha ingresado un caracter no valido. . . ");
                Console.WriteLine();
                return;
            }
            catch (FueraDeRangoException)
            {
                Console.WriteLine("Ha superado la cantidad maxima de surtidores a dar de alta. . . ");
                return;
            }
            catch (OpcionIncorrectaException)
            {
                Console.WriteLine("Ingrese un numero de surtidor en el rango establecido. . . ");
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Ingrese tipo de combustible: ");
            Console.Write("- ");
            tipoCombustible = "";
            try
            {
                tipoCombustible = Console.ReadLine();
                foreach (string parte in partes)
                {
                    if (tipoCombustible.Contains(parte))
                    {
                        throw new TipoDeDatoException();
                    }
                    if (tipoCombustible == "")
                    {
                        throw new CampoVacioException();
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ha ingresado un caracter invalido. . . ");
                return;
            }
            catch (TipoDeDatoException)
            {
                Console.WriteLine("No ingreso un tipo de combustible valido. . . ");
                return;
            }
            catch (CampoVacioException)
            {
                Console.WriteLine("Ingrese los datos solicitados. . . ");
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Ingrese la cantidad de combustible remanente: ");
            Console.Write("- ");
            stockRemanente = 0;
            try
            {
                stockRemanente = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ha ingresado un caracter no valido. . . ");
                Console.WriteLine();
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Ingrese precio por litro: ");
            Console.Write("- $");
            valorLitro = 0;
            try
            {
                valorLitro = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ha ingresado un caracter no valido. . . ");
                Console.WriteLine();
                return;
            }
            Console.WriteLine();
            estado = false;
            playeroAsignado = null;
            litrosVendidosPorDia = 0;
            venta = 0;
            descuentosAplicados = 0;
            surtidor s = new surtidor();
            int coincidencia = 0;
            foreach (surtidor su in surtidores)
            {
                if (su.numero == numero)
                {
                    coincidencia++;
                }
            }
            if (coincidencia == 0 && surtidores != null)
            {
                s.numero = numero;
                s.stockRemanente = stockRemanente;
                s.litrosVendidosPorDia = litrosVendidosPorDia;
                s.valorLitro = valorLitro;
                s.estado = estado;
                s.tipoCombustible = tipoCombustible;
                s.playeroAsignado = playeroAsignado;
                s.venta = venta;
                s.descuentosAplicados = descuentosAplicados;
                surtidores.Add(s);
            }
            else
            {
                Console.WriteLine("Ya existe un surtidor con ese nro. . . ");
            }
        }
        public void listaSurtidoresHabilitados()
        {
            Console.WriteLine("Listado de surtidores habilitados: ");
            Console.WriteLine();
            int cont = 0;
            foreach (surtidor s in surtidores)
            {
                if (s.estado == true)
                {
                    Console.WriteLine("Surtidor=" + s.numero + " - Tipo Comb:" + s.tipoCombustible + ".");
                    cont++;
                }
            }
            if (cont == 0)
            {
                Console.WriteLine("Ningun surtidor se encuentra habilitado.");
            }
        }
        public void asignarPlayero(playero pla)
        {
            Console.WriteLine("Ingrese el numero del surtidor a asignarle <1-6>: ");
            Console.Write("- ");
            int nroSurtidor = 0;
            try
            {
                nroSurtidor = int.Parse(Console.ReadLine());
                int cInterno = 0;
                foreach (surtidor s in surtidores)
                {
                    if (nroSurtidor == surtidores.Count)
                    {
                        cInterno++;
                    }
                }
                if (cInterno == 0)
                {
                    throw new OpcionIncorrectaException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ha ingresado un caracter no valido. . . ");
                return;
            }
            catch (OpcionIncorrectaException)
            {
                Console.WriteLine("Ha ingresado un numero de surtidor inexistente. . . ");
                return;
            }
            Console.WriteLine();
            if (nroSurtidor <= 6 && nroSurtidor > 0)
            {
                int Cont = 0;
                foreach (surtidor s in surtidores)
                {
                    if (s.numero == nroSurtidor && s.estado==true)
                    {
                        Cont++;
                        s.playeroAsignado = pla;
                        Console.WriteLine("El playero " + s.playeroAsignado.nombre_apellido + " ha sido asignado al surtidor nro " + s.numero + ".");
                    }
                }
                if (Cont == 0)
                {
                    Console.WriteLine("El surtidor seleccionado no se encuentra habilitado. . . ");
                }
            }
            else
            {
                Console.WriteLine("Ha ingresado un numero de surtidor inexistente. . . ");
            }
        }
        public void cargaCombustible(promocion promo, surtidor sur)
        {
            int contS = 0;
            foreach (surtidor s in sur.surtidores)
            {
                if (s.estado == true)
                {
                    contS++;
                }
            }
            if (contS != 0)
            {
                Console.WriteLine("Ingrese el surtidor a ocupar: ");
                Console.Write("- ");
                int surtSel = -1;
                try
                {
                    surtSel = int.Parse(Console.ReadLine());
                    int Sel = 0;
                    foreach (surtidor s in sur.surtidores)
                    {
                        if (s.estado == true && s.numero==surtSel && s.playeroAsignado != null)
                        {
                            Sel++;
                        }
                    }
                    if (Sel == 0)
                    {
                        throw new CampoVacioException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ha ingresado un caracter invalido. . . ");
                    return;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Ha ingresado una opcion incorrecta. . . ");
                    return;
                }
                catch (CampoVacioException)
                {
                    Console.WriteLine("No ha seleccionado un sutidor habilitado para la carga. . . ");
                    Console.WriteLine("Verifique que el surtidor seleccionado se encuentre habilitado");
                    Console.WriteLine("y tenga asignado un playero. . . ");
                    return;
                }
                Console.WriteLine();
                Console.WriteLine("Ingrese la cantidad de litros cargados: ");
                Console.Write("- ");
                int litrosVend = -1;
                try
                {
                    litrosVend = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ha ingresado un caracter invalido. . . ");
                    return;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Ha ingresado una opcion incorrecta. . . ");
                    return;
                }
                Console.WriteLine("Paga con alguna promocion? s/n");
                Console.Write("- ");
                string pagaOpcion = "";
                try
                {
                    pagaOpcion = Console.ReadLine();
                    if (pagaOpcion != "s" && pagaOpcion != "n")
                    {
                        throw new OpcionIncorrectaException();
                    }
                    if (pagaOpcion == "")
                    {
                        throw new CampoVacioException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ha ingresado un caracter no valido. . . ");
                    return;
                }
                catch (OpcionIncorrectaException)
                {
                    Console.WriteLine("Ingrese una opcion valida. . . ");
                    return;
                }
                catch (CampoVacioException)
                {
                    Console.WriteLine("Ingrese los datos solicitados. . . ");
                    return;
                }
                double venta = 0;
                double puntos = 0;
                double valorDescuentosAplicados = 0;
                switch (pagaOpcion)
                {
                    case "s":
                        Console.WriteLine();      
                        if (promo.promociones.Count>0)
                        {
                            Console.WriteLine("Listado de promociones vigentes: ");
                            promo.listaPromociones();
                            Console.WriteLine();
                            Console.WriteLine("Ingrese el numero de promocion a utilizar: ");
                            Console.Write("- ");
                            int numProm = -1;
                            try
                            {
                                numProm = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Ha ingresado un caracter invalido. . . ");
                                return;
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("Ha ingresado una opcion incorrecta. . . ");
                                return;
                            }
                            Console.WriteLine();
                            promocion pr = new promocion();
                            for (int i = 1; i <= promo.promociones.Count; i++)
                            {
                                int cont = 0;
                                if (i == numProm)
                                {
                                    foreach (promocion prom in promo.promociones)
                                    {
                                        cont += 1;
                                        if (cont == numProm)
                                        {
                                            pr = prom;
                                            string tipoProm = pr.tipo;
                                            if (tipoProm == "puntos")
                                            {
                                                int puntosAplica = pr.puntos;
                                                puntos = litrosVend * puntosAplica;
                                                foreach (surtidor s in sur.surtidores)
                                                {
                                                    if (s.numero == surtSel)
                                                    {
                                                        if (litrosVend<=s.stockRemanente) {
                                                        venta = litrosVend * s.valorLitro;
                                                        s.litrosVendidosPorDia += litrosVend;
                                                        s.stockRemanente -= litrosVend;
                                                        s.venta += venta;
                                                        s.playeroAsignado.montoTotalVendidoPorDia += venta;
                                                        Console.WriteLine("El monto total de la venta es de: $" + venta + ".");
                                                        Console.WriteLine("La venta ha sumado la cantidad de : " + puntos + ".");
                                                        Console.WriteLine();
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("La cantidad de litros ha vender supera el stock remanente del surtidor seleccionado. . . ");
                                                            return;
                                                        }
                                                    }
                                                }
                                            }
                                            if (tipoProm == "descuento")
                                            {
                                                double porcDesc = pr.porcentaje;
                                                foreach (surtidor s in sur.surtidores)
                                                {
                                                    if (s.numero == surtSel)
                                                    {
                                                        if (litrosVend <= s.stockRemanente)
                                                        {
                                                            venta = litrosVend * s.valorLitro;
                                                            valorDescuentosAplicados = venta * porcDesc / 100;
                                                            double ventaConDescuento = venta - valorDescuentosAplicados;
                                                            s.litrosVendidosPorDia += litrosVend;
                                                            s.stockRemanente -= litrosVend;
                                                            s.venta += venta;
                                                            s.descuentosAplicados += valorDescuentosAplicados;
                                                            s.playeroAsignado.montoTotalVendidoPorDia += venta;
                                                            Console.WriteLine("El monto total de la venta con descuento es de: $" + ventaConDescuento + ".");
                                                            Console.WriteLine();
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("La cantidad de litros ha vender supera el stock remanente del surtidor seleccionado. . . ");
                                                            return;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No existen promociones cargadas en sistema. . . ");
                            return;
                        }
                        break;
                    case "n":
                        foreach (surtidor s in sur.surtidores)
                        {
                            if (s.numero == surtSel)
                            {
                                if (litrosVend <= s.stockRemanente)
                                {
                                    venta = litrosVend * s.valorLitro;
                                    s.litrosVendidosPorDia += litrosVend;
                                    s.stockRemanente -= litrosVend;
                                    s.venta += venta;
                                    s.playeroAsignado.montoTotalVendidoPorDia += venta;
                                    Console.WriteLine("El monto total de la venta es de: $" + venta + ".");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("La cantidad de litros ha vender supera el stock remanente del surtidor seleccionado. . . ");
                                    return;
                                }
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("No ingreso una opcion valida. . . ");
                        break;
                }
            }
            else
            {
                Console.WriteLine("No hay surtidores habilitados para realizar la carga de combustible. . . ");
            }
        }
    }
}
		
