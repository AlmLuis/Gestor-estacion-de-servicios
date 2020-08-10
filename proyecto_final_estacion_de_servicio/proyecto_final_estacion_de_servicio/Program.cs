/*
 * Created by SharpDevelop.
 * User: luis
 * Date: 13/6/2019
 * Time: 12:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyecto_final_estacion_de_servicio
{		
	class Program
	{
		public static void Main(string[] args)
		{
			int constante=0;	
			playero p= new playero();
			promocion prom= new promocion();
			surtidor surt= new surtidor();			
			do{			
				Console.WriteLine("			****************************************************************");
				Console.WriteLine("			****************************************************************");
				Console.WriteLine("			*	    ___    ___    ______      ________                 *");
				Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
				Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
				Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
				Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
				Console.WriteLine("			*	       |  |      |  |        |  |                      *");
				Console.WriteLine("			*	       |__|      |__|        |__|                      *");
				Console.WriteLine("			*                                                              *");
				Console.WriteLine("			****************************************************************");
				Console.WriteLine("			****************************************************************");
				Console.WriteLine("");
				Console.WriteLine("	*************************************************************************************************");
				Console.WriteLine("	*****   				ESTACION DE SERVICIO	 				*****");
				Console.WriteLine("	*************************************************************************************************");
				Console.WriteLine("");
				Console.WriteLine("Seleccione una opcion: ");
				Console.WriteLine("");
				Console.WriteLine("1- Surtidores;");
				Console.WriteLine("2- Playeros;");
				Console.WriteLine("3- Promociones;");
				Console.WriteLine("4- Administracion;");
				Console.WriteLine("5- Salir.");
				Console.WriteLine();
				Console.Write("_ ");
				int opcionElegida= 0;				
				try{
					opcionElegida= int.Parse(Console.ReadLine());
				}				
				catch(FormatException){
					Console.WriteLine("No ha ingresado un caracter numerico. . . ");
				}							
				switch(opcionElegida){						
					case 1:
						int c1=0;						
						do{							
							Console.Clear();							
							Console.WriteLine("			****************************************************************");
							Console.WriteLine("			****************************************************************");
							Console.WriteLine("			*	    ___    ___    ______      ________                 *");
							Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
							Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
							Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
							Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
							Console.WriteLine("			*	       |  |      |  |        |  |                      *");
							Console.WriteLine("			*	       |__|      |__|        |__|                      *");
							Console.WriteLine("			*                                                              *");
							Console.WriteLine("			****************************************************************");
							Console.WriteLine("			****************************************************************");
							Console.WriteLine("");									
							Console.WriteLine("	*************************************************************************************************");
							Console.WriteLine("	*****   				MODULO SURTIDORES	 	 			*****");
							Console.WriteLine("	*************************************************************************************************");
							Console.WriteLine("");							
							Console.WriteLine("Seleccione una opcion: ");
							Console.WriteLine("");
							Console.WriteLine("1- Agregar surtidor;");
							Console.WriteLine("2- Habilitar un surtidor;");
							Console.WriteLine("3- Deshabilitar un surtidor;");
							Console.WriteLine("4- Ver la cantidad de litros vendidos;");
							Console.WriteLine("5- Cargar combustible;");
							Console.WriteLine("6- Listar todos los surtidores;");
							Console.WriteLine("7- Volver.");
							Console.WriteLine();
							Console.Write("_ ");										
							int opcionSurtidor= -1;							
							try{
								opcionSurtidor= int.Parse(Console.ReadLine());
							}				
							catch(FormatException){
								Console.WriteLine("No ha ingresado un caracter numerico. . . ");
							}							
							switch(opcionSurtidor){									
								case 1:
									Console.Clear();							
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO SURTIDORES	  				*****");
									Console.WriteLine("	*****   				Agregar Surtidor  					*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");                                    
                                    surt.agregarSurtidor();									
									Console.WriteLine("Presione una tecla para continuar. . . ");
									Console.ReadKey(true);									
									break;									
								case 2:
									Console.Clear();							
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO SURTIDORES	  				*****");
									Console.WriteLine("	*****   				Habilitar Surtidor  					*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");										
									surt.habilitarSurtidor();
                                    Console.WriteLine();
									Console.WriteLine("Presione una tecla para continuar. . . ");
									Console.ReadKey(true);									
									break;									
								case 3:
									Console.Clear();							
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO SURTIDORES	  				*****");
									Console.WriteLine("	*****   				Deshabilitar Surtidor  					*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");                                                                     
                                    surt.deshabilitarSurtidor();
                                    Console.WriteLine();
                                    Console.WriteLine("Presione una tecla para continuar. . . ");
                                    Console.ReadKey(true);									
									break;									
								case 4:
									Console.Clear();							
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO SURTIDORES	  				*****");
									Console.WriteLine("	*****   				Consultar Surtidor  					*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");                                    
                                    Console.WriteLine();                                    
                                    int conta = 0;
                                    foreach (surtidor s in surt.surtidores)
                                    {
                                        if (s.estado==true) {
                                            conta++;
                                        }
                                    }
                                    if (conta != 0)
                                    {
                                        surt.listaSurtidoresHabilitados();
                                        Console.WriteLine();
                                        Console.WriteLine("Ingrese el nro de surtidor a consultar: ");
                                        int surtElegido = -1;
                                        try
                                        {
                                            surtElegido = int.Parse(Console.ReadLine());
                                            int Opcion = 0;
                                            foreach (surtidor s in surt.surtidores)
                                            {
                                                if (s.numero == surtElegido)
                                                {
                                                    Opcion++;
                                                }
                                            }
                                            if (Opcion == 0)
                                            {
                                                throw new CampoVacioException();
                                            }
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Ha ingresado un caracter invalido. . . ");
                                        }
                                        catch (ArgumentOutOfRangeException)
                                        {
                                            Console.WriteLine("Ha ingresado una opcion incorrecta. . . ");
                                        }
                                        catch (CampoVacioException)
                                        {
                                            Console.WriteLine("El surtidor seleccionado no esta disponible. . . ");
                                        }
                                        foreach (surtidor s in surt.surtidores)
                                        {
                                            if (s.numero == surtElegido)
                                            {
                                                Console.WriteLine("La cantidad de litros vendidos es de: " + s.litrosVendidosPorDia + " litros.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("No hay surtidores habilitados para consultar. . . ");
                                    }                                                           
                                    Console.WriteLine();
                                    Console.WriteLine("Presione una tecla para continuar. . . ");
									Console.ReadKey(true);									
									break;								
								case 5:
									Console.Clear();							
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO SURTIDORES	  				*****");
									Console.WriteLine("	*****   				Cargar Combustible  					*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");
                                    surt.cargaCombustible(prom,surt);
                                    Console.WriteLine();
                                    Console.WriteLine("presione una tecla para continuar. . . ");
									Console.ReadKey(true);									
									break;								
								case 6:
									Console.Clear();							
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO SURTIDORES	  				*****");
									Console.WriteLine("	*****   				Listado de Surtidores  					*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");
                                    int cSurt = 0;
                                    foreach (surtidor s in surt.surtidores)
                                    {
                                        cSurt++;
                                    }
                                    if (cSurt != 0) {
                                        surt.listaSurtidoresHabilitados();
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se encuentran surtidores cargados para listar. . . ");
                                    }
                                    Console.WriteLine();
									Console.WriteLine("Presione una tecla para continuar. . . ");
									Console.ReadKey(true);									
									break;									
								case 7:
									Console.Clear();									
									c1=4;
									break;									
								default:
									c1++;
									Console.WriteLine("Por favor ingrese una opcion valida. . . ");
									int	intentosRestantes= 4- c1;
									Console.WriteLine("Le restan "+intentosRestantes+" intentos.");
									Console.WriteLine("Presione una tecla para continuar. . . ");
									Console.ReadKey(true);
									Console.Clear();																		
									break;									
							}
						}						
						while(c1<=3);
						break;						
					case 2:
						int c2=0;
						do{								
							Console.Clear();							
							Console.WriteLine("			****************************************************************");
							Console.WriteLine("			****************************************************************");
							Console.WriteLine("			*	    ___    ___    ______      ________                 *");
							Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
							Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
							Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
							Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
							Console.WriteLine("			*	       |  |      |  |        |  |                      *");
							Console.WriteLine("			*	       |__|      |__|        |__|                      *");
							Console.WriteLine("			*                                                              *");
							Console.WriteLine("			****************************************************************");
							Console.WriteLine("			****************************************************************");
							Console.WriteLine("");							
							Console.WriteLine("	*************************************************************************************************");
							Console.WriteLine("	*****   				MODULO PLAYEROS	 	 				*****");
							Console.WriteLine("	*************************************************************************************************");
							Console.WriteLine("");							
							Console.WriteLine("Seleccione una opcion: ");
							Console.WriteLine("");
							Console.WriteLine("1- Dar de alta un playero;");
							Console.WriteLine("2- Dar de baja un playero;");
							Console.WriteLine("3- Asignar playero a un surtidor;");
							Console.WriteLine("4- Listar todos los playeros;");
							Console.WriteLine("5- Volver.");
							Console.WriteLine();
							Console.Write("_ ");							
							int opcionPlayero= -1;							
							try{
								opcionPlayero= int.Parse(Console.ReadLine());
							}				
							catch(FormatException){
								Console.WriteLine("No ha ingresado un caracter numerico. . . ");
							}							
							switch(opcionPlayero){									
									case 1:
									Console.Clear();							
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO PLAYEROS	 	 				*****");
									Console.WriteLine("	*****   				Alta de Playero  					*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");
                                    p.altaPlayero();
									Console.WriteLine();
									Console.Write("Presione una tecla para continuar. . . ");
									Console.ReadKey(true);									
									break;									
								case 2:
									Console.Clear();						
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO PLAYEROS	 	 				*****");
									Console.WriteLine("	*****   				Baja de Playero  					*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");                            
                                    Console.WriteLine();
                                    int contPlay = 0;
                                    foreach (playero pl in p.playeros) {
                                        contPlay++;
                                    }
                                    if (contPlay != 0)
                                    {
                                        Console.WriteLine("Listado de playeros: ");
                                        p.listaPlayeros();
                                        p.bajaPlayero();
                                        Console.WriteLine();
                                        Console.WriteLine("Listado de playeros actualizado: ");
                                        p.listaPlayeros();
                                    }
                                    else
                                    {
                                        Console.WriteLine("No hay playeros cargados en sistema. . . ");
                                    }									
									Console.WriteLine();
									Console.Write("Presione una tecla para continuar. . . ");
									Console.ReadKey(true);										
									break;									
								case 3:
									Console.Clear();							
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO PLAYEROS	 	 				*****");
									Console.WriteLine("	*****   				Asignar Playero  					*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");                                    
                                    Console.WriteLine();
                                    int contObj = 0;
                                    foreach (playero play in p.playeros)
                                    {
                                        contObj++;
                                    }
                                    if (contObj != 0)
                                    {
                                        Console.WriteLine("Listado de playeros: ");
                                        p.listaPlayeros();
                                        Console.WriteLine();
                                        Console.WriteLine("Ingrese el nro de playero: ");
                                        Console.Write("- ");
                                        int nroPlayero = -1;
                                        try
                                        {
                                            nroPlayero = int.Parse(Console.ReadLine());
                                            int cInterno = 0;
                                            foreach (playero pl in p.playeros)
                                            {
                                                if (nroPlayero == p.playeros.Count)
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
                                            Console.WriteLine("Ha ingresado un caracter invalido. . . ");
                                            Console.WriteLine("Presione una tecla para continuar. . . ");
                                            Console.ReadKey(true);
                                            break;
                                        }
                                        catch (ArgumentOutOfRangeException)
                                        {
                                            Console.WriteLine("Ha ingresado una opcion incorrecta. . . ");
                                            Console.WriteLine("Presione una tecla para continuar. . . ");
                                            Console.ReadKey(true);
                                            break;
                                        }
                                        catch (OpcionIncorrectaException)
                                        {
                                            Console.WriteLine("Ha ingresado un numero de playero inexistente. . . ");
                                            Console.WriteLine("Presione una tecla para continuar. . . ");
                                            Console.ReadKey(true);
                                            break;
                                        }
                                        playero pla = new playero();
                                        int cont = 0;
                                        foreach (playero pl in p.playeros)
                                        {
                                            cont += 1;
                                            if (cont == nroPlayero)
                                            {
                                                pla = pl;
                                            }
                                        }
                                        surt.asignarPlayero(pla);
                                    }
                                    if (contObj == 0)
                                    {
                                        Console.WriteLine("No hay playeros cargados para asignar. . . ");
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Presione una tecla para continuar. . . ");
									Console.ReadKey(true);									
									break;									
								case 4:
									Console.Clear();							
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO PLAYEROS	 	 				*****");
									Console.WriteLine("	*****   				Listado de Playeros  					*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");
                                    Console.WriteLine();
                                    int contP = 0;
                                    foreach (playero pl in p.playeros)
                                    {
                                        contP++;
                                    }
                                    if (contP == 0)
                                    {
                                        Console.WriteLine("No existen playeros cargados para listar. . . ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Listado de playeros: ");
                                        p.listaPlayeros();
                                    }									
									Console.WriteLine();
									Console.WriteLine("Presione una tecla para continuar. . . ");
									Console.ReadKey(true);									
									break;									
								case 5:
									Console.Clear();									
									c2=4;
									break;									
								default:
									c2++;
									Console.WriteLine("Por favor ingrese una opcion valida. . . ");
									int	intentosRestantes= 4- c2;
									Console.WriteLine("Le restan "+intentosRestantes+" intentos.");
									Console.WriteLine("Presione una tecla para continuar. . . ");
									Console.ReadKey(true);
									Console.Clear();																		
									break;									
							}
						}						
						while(c2<=3);
						break;						
					case 3:
						int c3=0;
						do{
							
							Console.Clear();							
							Console.WriteLine("			****************************************************************");
							Console.WriteLine("			****************************************************************");
							Console.WriteLine("			*	    ___    ___    ______      ________                 *");
							Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
							Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
							Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
							Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
							Console.WriteLine("			*	       |  |      |  |        |  |                      *");
							Console.WriteLine("			*	       |__|      |__|        |__|                      *");
							Console.WriteLine("			*                                                              *");
							Console.WriteLine("			****************************************************************");
							Console.WriteLine("			****************************************************************");
							Console.WriteLine("");							
							Console.WriteLine("	*************************************************************************************************");
							Console.WriteLine("	*****   				MODULO PROMOCIONES	 	 			*****");
							Console.WriteLine("	*************************************************************************************************");
							Console.WriteLine("");							
							Console.WriteLine("Seleccione una opcion: ");
							Console.WriteLine("");
							Console.WriteLine("1- Dar de alta una promocion;");
							Console.WriteLine("2- Dar de baja una promocion;");
							Console.WriteLine("3- Listar todas las promociones;");
							Console.WriteLine("4- Volver;");
							Console.WriteLine();
							Console.Write("_ ");							
							int opcionPromocion= -1;							
							try{
								opcionPromocion= int.Parse(Console.ReadLine());
							}				
							catch(FormatException){
								Console.WriteLine("No ha ingresado un caracter numerico. . . ");
							}							
							switch(opcionPromocion){									
									case 1:
									Console.Clear();							
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO PROMOCIONES	  				*****");
									Console.WriteLine("	*****   				Alta de Promocion  					*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");										
									prom.altaPromocion();									
									Console.WriteLine("Presione una tecla para continuar. . .");
									Console.ReadKey(true);									
									break;									
								case 2:
									Console.Clear();							
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO PROMOCIONES	  				*****");
									Console.WriteLine("	*****   				Baja de Promocion  					*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");
                                    Console.WriteLine();
                                    int contProm = 0;
                                    foreach (promocion pr in prom.promociones)
                                    {
                                        contProm++;
                                    }
                                    if (contProm != 0)
                                    {
                                        Console.WriteLine("Listado de promociones vigentes: ");
                                        prom.listaPromociones();
                                        prom.bajaPromocion();
                                        Console.WriteLine("Listado de promociones modificado: ");
                                        prom.listaPromociones();
                                    }
                                    else
                                    {
                                        Console.WriteLine("No existen promociones vigentes. . . ");
                                    }
                                    Console.WriteLine();
									Console.WriteLine("Presione una tecla para continuar. . .");
									Console.ReadKey(true);									
									break;									
								case 3:
									Console.Clear();							
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO PROMOCIONES	  				*****");
									Console.WriteLine("	*****   				Listado de Promociones  				*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");
                                    Console.WriteLine();
                                    int cProm = 0;
                                    foreach (promocion pr in prom.promociones)
                                    {
                                        cProm++;
                                    }
                                    if (cProm != 0 ) {
                                        Console.WriteLine("Listado de promociones vigentes: ");
                                        prom.listaPromociones();
                                    }
                                    else
                                    {
                                        Console.WriteLine("No existen promociones vigentes para listar. . . ");
                                    }
                                    Console.WriteLine();
									Console.WriteLine("Presione una tecla para continuar. . .");
									Console.ReadKey(true);									
									break;									
								case 4:
									Console.Clear();									
									c3=4;
									break;									
								default:
									c3++;
									Console.WriteLine("Por favor ingrese una opcion valida. . . ");
									int	intentosRestantes= 4- c3;
									Console.WriteLine("Le restan "+intentosRestantes+" intentos.");
									Console.WriteLine("Presione una tecla para continuar. . . ");
									Console.ReadKey(true);
									Console.Clear();																		
									break;									
							}							
						}						
						while(c3<=3);
						break;						
					case 4:
						int c4=0;						
						do{							
							Console.Clear();							
							Console.WriteLine("			****************************************************************");
							Console.WriteLine("			****************************************************************");
							Console.WriteLine("			*	    ___    ___    ______      ________                 *");
							Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
							Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
							Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
							Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
							Console.WriteLine("			*	       |  |      |  |        |  |                      *");
							Console.WriteLine("			*	       |__|      |__|        |__|                      *");
							Console.WriteLine("			*                                                              *");
							Console.WriteLine("			****************************************************************");
							Console.WriteLine("			****************************************************************");
							Console.WriteLine("");							
							Console.WriteLine("	*************************************************************************************************");
							Console.WriteLine("	*****   				MODULO ADMINISTRACION	 	 			*****");
							Console.WriteLine("	*************************************************************************************************");
							Console.WriteLine("");							
							Console.WriteLine("Seleccione una opcion: ");
							Console.WriteLine("");
							Console.WriteLine("1- Recaudacion final de la Estacion;");
							Console.WriteLine("2- Recaudacion de surtidores;");
							Console.WriteLine("3- Recaudacion de playeros;");
							Console.WriteLine("4- Monto total descontado correspondiente a ventas con promociones;");
							Console.WriteLine("5- Volver;");
							Console.WriteLine();
							Console.Write("_ ");							
							int opcionAdministracion= 0;							
							try{
								opcionAdministracion= int.Parse(Console.ReadLine());
							}				
							catch(FormatException){
								Console.WriteLine("No ha ingresado un caracter numerico. . . ");
							}							
							switch(opcionAdministracion){									
									case 1:
									Console.Clear();							
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO ADMINISTRACION	  				*****");
									Console.WriteLine("	*****   				Recaudacion de final  					*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");
                                    Console.WriteLine();
                                    double recFinal = 0;
                                    double descFinal = 0;
                                    foreach (surtidor s in surt.surtidores)
                                    {
                                        recFinal += s.venta;
                                        descFinal += s.descuentosAplicados;
                                    }
                                    double total = recFinal - descFinal;
                                    Console.WriteLine("Recaudacion final de la estacion de servicio: $"+total);
                                    Console.WriteLine();
                                    Console.WriteLine("Presione una tecla para continuar. . . ");
									Console.ReadKey(true);									
									break;									
								case 2:
									Console.Clear();							
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO ADMINISTRACION	  				*****");
									Console.WriteLine("	*****   				Recaudacion de Surtidores  				*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");
                                    Console.WriteLine();
                                    int Csurt = 0;
                                    foreach (surtidor s in surt.surtidores) {
                                        Csurt++;
                                    }
                                    if (Csurt != 0)
                                    {
                                        Console.WriteLine("Listado de surtidores habilitados: ");
                                        Console.WriteLine();
                                        int cont = 0;
                                        foreach (surtidor s in surt.surtidores)
                                        {
                                            if (s.estado == true)
                                            {
                                                Console.WriteLine("Surtidor=" + s.numero + " - Tipo Comb: " + s.tipoCombustible + " - Recaudacion: $" + s.venta + ".");
                                                cont++;
                                            }
                                        }
                                        if (cont == 0)
                                        {
                                            Console.WriteLine("Ningun surtidor se encuentra habilitado.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("No existen surtidores cargados para consultar. . . ");
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Presione una tecla para continuar. . . ");
									Console.ReadKey(true);									
									break;									
								case 3:
									Console.Clear();							
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO ADMINISTRACION	  				*****");
									Console.WriteLine("	*****   				Recaudacion de Playeros  				*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");
                                    Console.WriteLine();
                                    int Cpla = 0;
                                    foreach (playero pl in p.playeros)
                                    {
                                        Cpla++;
                                    }
                                    if (Cpla != 0)
                                    {
                                        Console.WriteLine("Listado de playeros: ");
                                        Console.WriteLine();
                                        int con = 0;
                                        foreach (playero pl in p.playeros)
                                        {
                                            Console.WriteLine("*" + pl.nombre_apellido + " - Recaudacion: $" + pl.montoTotalVendidoPorDia + ".");
                                            con++;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("No existen playeros registrados.");
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Presione una tecla para continuar. . . ");
									Console.ReadKey(true);									
									break;									
								case 4:
									Console.Clear();							
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			*	    ___    ___    ______      ________                 *");
									Console.WriteLine("			*	    \\  \\  /  /   |      \\    |        |                *");
									Console.WriteLine("			*	     \\  \\/  /    |   |\\  \\   |   _____|                *");
									Console.WriteLine("			*	      \\    /     |   |/  /   |  |__                    *");
									Console.WriteLine("			*	       |  |      |   ___/    |   __|                   *");
									Console.WriteLine("			*	       |  |      |  |        |  |                      *");
									Console.WriteLine("			*	       |__|      |__|        |__|                      *");
									Console.WriteLine("			*                                                              *");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("			****************************************************************");
									Console.WriteLine("");									
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("	*****   				MODULO ADMINISTRACION	  				*****");
									Console.WriteLine("	*****   				Monto por Descuentos  					*****");
									Console.WriteLine("	*************************************************************************************************");
									Console.WriteLine("");
                                    Console.WriteLine();
                                    double descRealizados = 0;
                                    foreach (surtidor s in surt.surtidores)
                                    {
                                        descRealizados += s.descuentosAplicados;
                                    }
                                    Console.WriteLine("Monto total por descuentos en ventas con promociones: $"+descRealizados+".");
                                    Console.WriteLine();
                                    Console.WriteLine("Presione una tecla para continuar. . . ");
									Console.ReadKey(true);									
									break;																	
								case 5:
									Console.Clear();
									c4=4;
									break;									
								default:
									c4++;
									Console.WriteLine("Por favor ingrese una opcion valida. . . ");
									int	intentosRestantes= 4- c4;
									Console.WriteLine("Le restan "+intentosRestantes+" intentos.");
									Console.WriteLine("Presione una tecla para continuar. . . ");
									Console.ReadKey(true);
									Console.Clear();																		
									break;
							}
						}						
						while(c4<=3);						
						break;						
					case 5:
						Environment.Exit(1);
						break;						
					default:
						constante++;
						Console.WriteLine("Por favor ingrese una opcion valida. . . ");
						int intentosRestantesMenuPrincip=0;
						if (constante>0){
							intentosRestantesMenuPrincip= 3- constante;
                        }
						Console.WriteLine("Intentos restantes: "+intentosRestantesMenuPrincip);
						Console.WriteLine("Presione una tecla para continuar. . . ");
						Console.ReadKey(true);
						Console.Clear();
						break;
				}
			}
			while(constante<=2);			
			Console.WriteLine("Programa finalizado. . . ");
            Console.WriteLine();
			Console.Write("Presione una tecla para continuar. . . ");
			Console.ReadKey(true);
		}
	}
}