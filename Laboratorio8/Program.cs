using System;
using System.Collections.Generic;
using AbstractFactory.BasesDeDatosConexion;
using AbstractFactory.Fabrica;
using Laboratorio8._2_MetodoFabricacion;
using Laboratorio8._3_Constructor;
using Laboratorio8._4_Prototipo;
using Laboratorio8._5_InstanciaUnica;
using Laboratorio8._6_Adaptador;
using Laboratorio8._7_Compuesto;
using Laboratorio8._8_Puente;
using Laboratorio8._9_Contenedor;
using Laboratorio8._10_Proximidad;
using Laboratorio8._11_CadenaResponsabilidad;
using Laboratorio8._12_Comando;
using Laboratorio8._13_EscuchaEventos;
using Laboratorio8._14_Interprete;
using Laboratorio8._15_Iterador;
using Laboratorio8._16_Mediador;
using Laboratorio8Ulloa.Elements;
using Laboratorio8Ulloa.ObjectStructure;
using Laboratorio8Ulloa.Visitors;

namespace Laboratorio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //FabricaAbstracta();

            //2
            //Fabricacion();

            //3
            //Constructor();

            //4
            //Prototipo();

            //5
            //InstanciaUnica();

            //6
            //Adaptador();

            //7
            //Compuesto1();
            //Compuesto2();

            //8
            //Puente();
           
            //9
            //Contenedor();

            //10
            //Proximidad();

            //11
            //CadenaResponsabilidad1();
            //CadenaResponsabilidad2();

            //12
            //Comando();

            //13
            //EscuchaEventos();

            //14
            //Interprete();

            //15
            //Iterador();

            //16
            //Mediador();

            //17
            //Visitante();
        }

        //Uso del patrón
        public static void FabricaAbstracta()
        {
            ConexionFabrica fabrica;
            Conexion conexionBD;
            Console.WriteLine("Por favor ingrese la Base de Datos");
            String opcionBD = Console.ReadLine();
            fabrica = new ConexionFabrica();
            conexionBD = fabrica.creaConexion(opcionBD);
            Console.WriteLine("Conectado a la base: " + conexionBD.descripcion());
            Console.Read();
        }

        //Uso del patrón
        public static void MetodoFabricacion()
        {
            FabricaTarjetas fabrica = null; // Se crea una fábrica nula
            Console.Write("Introduzca el tipo de tarjeta a consultar: ");
            string txt = Console.ReadLine();

            switch (txt.ToLower()) //Dependiendo de lo que elija el usuario, ese será el tipo de fábrica
            {
                //Escenario dependiendo del tipo de tarjeta
                case "bronce":
                    fabrica = new FabricaTarjetasBronce(50000, 0);
                    break;
                case "plata":
                    fabrica = new FabricaTarjetasPlata(100000, 500);
                    break;
                case "oro":
                    fabrica = new FabricaTarjetasOro(500000, 1000);
                    break;
                default:
                    break;
            }
            //Aquí es donde realmente se ve el patrón. El objeto de retorno es una tarjeta de crédito, sin importar el tipo, el programa por medio de la fábrica devuelve unicamente una tarjeta.
            TarjetaCredito tarjetaredito = fabrica.ObtenerTarjetaCredito();
            Console.WriteLine("\nLos detalles de esta tarjeta son : \n");
            Console.WriteLine("Tipo de Tarjeta: {0}\nLimite de Credito: {1}\nCargo Anual: {2}",
                tarjetaredito.TypoTarjeta, tarjetaredito.LimiteCredito, tarjetaredito.CargoAnual);
            Console.ReadKey();
        }

        public static void Fabricacion()
        {
            IDevice device = DeviceFactory.CreateDevice(Device.AM);
            device.TurnOn();
            Console.WriteLine(device.Measure());
            Console.WriteLine(device.Measure());
            Console.WriteLine(device.Measure());
            Console.WriteLine(device.Measure());
            Console.WriteLine(device.Measure());
            device.TurnOff();
            Console.WriteLine();

            device = DeviceFactory.CreateDevice(Device.VOLT);
            device.TurnOn();
            Console.WriteLine(device.Measure());
            Console.WriteLine(device.Measure());
            Console.WriteLine(device.Measure());
            Console.WriteLine(device.Measure());
            Console.WriteLine(device.Measure());
            device.TurnOff();
            Console.WriteLine();

            device = DeviceFactory.CreateDevice(Device.OHM);
            device.TurnOn();
            Console.WriteLine(device.Measure());
            Console.WriteLine(device.Measure());
            Console.WriteLine(device.Measure());
            Console.WriteLine(device.Measure());
            Console.WriteLine(device.Measure());
            device.TurnOff();
            Console.WriteLine();

            Console.ReadLine();
        }
        //Uso del patrón
        public static void Constructor()
        {
            var computadorA = new ComputerCreator(new Computer1Builder());

            computadorA.GetComputer();

            computadorA.CreateComputer();

            var computadoraB = new ComputerCreator(new Computer2Builder());

            computadoraB.CreateComputer();

            computadoraB.GetComputer();

            Console.ReadKey();
        }

        //Uso del patrón
        public static void Prototipo()
        {
            Animales objAnimal = new Animales() { Nombre = "Perro", Patas = 4 };
            Animales objAnimalClonado = objAnimal;
            //al momento de modificar un atributo del segundo objeto practicamente
            //estamos modificando al primer objeto
            objAnimalClonado.Patas = 5;


            Console.WriteLine(objAnimal.Patas);
            Console.WriteLine(objAnimalClonado.Patas);
            //Entonces la cantidad de patas del primer objeto es 5 en vez de 4
            Console.ReadLine();
            //Lo que pasó fue que se asignó la posoción en memoria que traía ese objeto, al final
            //los 2 objetos son iguales

            ////FORMA CORRECTA
            //Animales objAnimal = new Animales() { Nombre = "Perro", Patas = 4 };
            ////Solo hay que llamar el método Clone e identificarlo como la misma clase que estámos usando 
            //Animales objAnimalClonado = objAnimal.Clone() as Animales;
            //objAnimalClonado.Patas = 5;
            //Console.WriteLine(objAnimal.Patas);
            //Console.WriteLine(objAnimalClonado.Patas);
            //Console.ReadLine();

        }

        //Uso del patrón
        public static void InstanciaUnica()
        {
            //es mutuable fuera de la clase
            Console.WriteLine(Singleton.Instance.message);
            Singleton.Instance.message = "Hello B";
            Console.WriteLine(Singleton.Instance.message);
            Console.ReadLine();
        }

        //Uso del patrón
        public static void Adaptador()
        {
            USRobot robotGringo = new USRobot();
            CoolCorpRobot robotEspañol = new CoolCorpRobot();

            Console.WriteLine("A continuacion se presentarán los datos de ambos robots para comparar");
            Console.WriteLine("");
            Console.WriteLine("La velocidad del robot gringo es de: " + robotGringo.CurrentSpeedInmilesPerHour + "Mph");
            Console.WriteLine("");
            Console.WriteLine("La nueva interfaz *adapter* creada convierte los valores del robot gringo a kph, por ende, ");
            Console.WriteLine("La velocidad del robot español es de: " + robotEspañol.CurrentSpeedInKilometersPerHour + "Kph");

            float pies = 12;
            Console.WriteLine("");
            Console.WriteLine("El salto del robot gringo se muestra en pies");
            robotGringo.Jump(pies);
            Console.WriteLine("El salto del robot gringo se muestra en metros");
            robotEspañol.Jump(pies);

            Console.WriteLine("Lo que este patron permite es no tener que cambiar siempre los atributos del robot cada vez que este se va a implementar... sino que mas bien, se crea una unica interfaz que se adapte a la clase requerida y nos permita utilizarlo sin la necesidad de estarlo instanciando y alterando siempre que se ocupe.");

            Console.ReadLine();
        }

        //Uso del patrón
        public static void Compuesto1()
        {
            var troncoArbol = new Rama("Tronco");

            var ramaPrincipal = new Rama("Rama principal");
            ramaPrincipal.Brotar(new Hoja("Hoja1"));

            var ramaSecundaria = new Rama("Rama secundaria");
            ramaSecundaria.Brotar(new Hoja("Hoja1"));
            ramaSecundaria.Brotar(new Hoja("Hoja2"));

            var ramaConMuchasHojas = new Rama("Rama con muchas hojas");
            ramaConMuchasHojas.Brotar(new Hoja("Hoja1"));
            ramaConMuchasHojas.Brotar(new Hoja("Hoja2"));
            ramaConMuchasHojas.Brotar(new Hoja("Hoja3"));

            troncoArbol.Brotar(ramaPrincipal);
            troncoArbol.Brotar(ramaSecundaria);
            troncoArbol.Brotar(ramaConMuchasHojas);

            troncoArbol.Pintar(1);
            Console.ReadLine();
        }

        //Ejemplo 2 del patrón
        public static void Compuesto2()
        {
            Leaf ingrediente1 = new Leaf("Harina", 700, 300, "gramos");
            Leaf ingrediente2 = new Leaf("Levadura", 400, 5, "gramos");
            Leaf ingrediente3 = new Leaf("Salsa Tomate", 1100, 200, "gramos");
            Leaf ingrediente4 = new Leaf("Mozarella", 1600, 100, "gramos");
            Leaf ingrediente5 = new Leaf("Jamón", 1500, 100, "gramos");

            Composite pizzaJamon = new Composite("Pizza de Jamón");
            pizzaJamon.Add(ingrediente1);
            pizzaJamon.Add(ingrediente2);
            pizzaJamon.Add(ingrediente3);
            pizzaJamon.Add(ingrediente4);
            pizzaJamon.Add(ingrediente5);
            Console.WriteLine("Costo Total de Pizza de Jamón: " + pizzaJamon.costoTotal);

            Composite pizzaJamonHongos = new Composite("Pizza de Jamón y Hongos");
            Leaf ingrediente6 = new Leaf("Hongos", 700, 1, "1 lata");
            pizzaJamonHongos.Add(ingrediente6); //Ingrediente agregado
            pizzaJamonHongos.Add(pizzaJamon); //Pizza de Jamón y Hongos junto con la pizza de jamón que se hizo anteriormente
            Console.WriteLine("Costo Total de Pizza de Jamón y Hongos incluidos: " + pizzaJamonHongos.costoTotal);

            Console.ReadLine();
        }

        //Uso del patrón
        public static void Puente()
        {
            // Create RefinedAbstraction

            Customers customers = new Customers("Chicago");

            // Set ConcreteImplementor

            customers.Data = new CustomersData();

            // Exercise the bridge

            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Fabricio Morera");

            customers.ShowAll();

            // Wait for user

            Console.ReadKey();
        }

        //Uso del patrón
        public static void Contenedor()
        {
            //Facade o contenedor
            FachadaImpresora fachada1 = new FachadaImpresora("Texto");
            Console.WriteLine(fachada1.Imprimir());

            FachadaImpresora fachada2 = new FachadaImpresora("Texto para imprimir");
            Console.WriteLine(fachada2.Imprimir());


            //Sin programacion Facade
            Impresora robles1 = new Impresora();
            robles1.SetHoja("A4");
            robles1.SetColor(true);
            robles1.SetTipoDocumento("PDF");
            Console.WriteLine(robles1.Imprimir());

            Console.ReadLine();
        }

        //Uso del patrón
        public static void Proximidad()
        {
            Image image = new ProxyImage("test_10mb.jpg");
            //image will be loaded from disk 
            image.Display();
            Console.WriteLine("");
            //image will not be loaded from disk
            image.Display();
            Console.Read();
        }

        //Uso del patrón
        public static void CadenaResponsabilidad1()
        {
            //Código recopilado de: https://www.dofactory.com/net/chain-of-responsibility-design-pattern
            Approver Director = new Director();
            Approver Vicepresidente = new VicePresident();
            Approver Presidente = new President();

            Director.SetSuccessor(Vicepresidente);
            Vicepresidente.SetSuccessor(Presidente);

            // Generate and process purchase requests

            Purchase p = new Purchase(2034, 1000, "1 000 Cajas de Birras");
            Director.ProcessRequest(p);

            p = new Purchase(2035, 20000, "20 000 Cajas de Birras");
            Director.ProcessRequest(p);

            p = new Purchase(2035, 32500, "32 500 Cajas de Birras");
            Director.ProcessRequest(p);

            p = new Purchase(2036, 120100, "120 100 Cajas de Birras");
            Director.ProcessRequest(p);

            // Wait for user

            Console.ReadKey();
        }

        public static void CadenaResponsabilidad2()
        {
            Banco banco = new Banco();
            banco.SolicitudPrestamo(30000); //se envia la petición al manejador con el monto del prestamo como parametro
            banco.SolicitudPrestamo(100000);
            banco.SolicitudPrestamo(500);
            Console.ReadLine();
        }

        //Uso del patrón
        public static void Comando()
        {
            Console.WriteLine("Patron de diseno Comando");
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Hola clase!!!"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Mande la tarea a Blackboard", "Guarde las notas de la profe"));
            invoker.DoSomethingImportant();
            Console.ReadLine();
        }

        //Uso del patrón
        public static void EscuchaEventos()
        {
            // Create price watch for Carrots and attach restaurants that buy carrots from suppliers.
            Carrots carrots = new Carrots(0.82);
            carrots.Attach(new Restaurant("Mackay's", 0.77));
            carrots.Attach(new Restaurant("Johnny's Sports Bar", 0.74));
            carrots.Attach(new Restaurant("Salad Kingdom", 0.75));

            // Fluctuating carrot prices will notify subscribing restaurants.
            carrots.PricePerPound = 0.79;
            carrots.PricePerPound = 0.76;
            carrots.PricePerPound = 0.74;
            carrots.PricePerPound = 0.81;

            Console.ReadLine();
        }

        //Uso del patrón
        public static void Interprete()
        {
            //El patrón de intérprete es un patrón de comportamiento.
            //Define una manera de controlar la comunicación entre clases. 
            //El patrón de intérprete se utiliza para definir la gramática de las instrucciones que forman parte de un lenguaje o notación

            //Un ejemplo del uso del patrón es utilizando la notación polaca simplificada.
            //Esta notación define un operador matemático seguido de dos valores, por ejemplo "+ 5 6". 
            //En este caso, el símbolo + indica que se deben sumar los dos valores siguientes, dando 11

            Parser parser = new Parser();

            string[] commands = new string[]
            {
            "+ 5 6",
            "- 6 5",
            "+ - 4 5 6",
            "+ 4 - 5 6",
            "+ - + - - 2 3 4 + - -5 6 + -7 8 9 10"
            };

            foreach (string command in commands)
            {
                ExpressionBase expression = parser.Parse(command);
                Console.WriteLine("{0} = {1}", expression, expression.Evaluate());

            }
            Console.ReadLine();
        }

        //Uso del patrón
        public static void Iterador()
        {
            IEnumerable<string> elements = new Lista().GetList();

            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

            Iterador iterador = new Iterador();
            Console.WriteLine(iterador.Inicio(elements));
            Console.ReadLine();

            Console.WriteLine(iterador.Ultimo(elements));
            Console.ReadLine();

            Console.WriteLine(iterador.Posicion(elements, 2));
            Console.ReadLine();
        }

       public static void Mediador()
        {
            // Create chatroom
            Chatroom chatroom = new Chatroom();

            // Create participants and register them
            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");
            //Participant Esmeralda = new NonBeatle("Esmeralda");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);
            //chatroom.Register(Esmeralda);


            // Chatting participants
            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");
            //Esmeralda.Send("Yoko", "Hola");
            // Wait for user
            Console.ReadKey();
        }

        //Uso del patrón
        public static void Visitante()
        {
            ProductList products = new ProductList();

            products.Attach(new Milk());
            products.Attach(new Bread());

            IVisitor iva = new IVA();
            IVisitor discount = new Discount();

            products.Accept(discount);
            products.Accept(iva);

            products.Excecute(_products => {
                foreach (var product in _products)
                    Console.WriteLine(string.Format("The price of the {0} is {1}.", product.GetType().Name, product.Price));
            });

            Console.Read();
        }
    }
}
