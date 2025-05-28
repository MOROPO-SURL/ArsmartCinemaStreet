namespace MOROPO.CPCC.CinemaStreet.Arsmart.Providers
{
    public sealed class DataModelProvider
    {
        public static Models.Data.TargetInfoDataModel[] TargetInfos
        {
            get
            {
                if (targetInfos == null) Initialize();

                return targetInfos;
            }
        }

        private static Models.Data.TargetInfoDataModel[] targetInfos;

        private static void Initialize()
        {
            targetInfos = new Models.Data.TargetInfoDataModel[]
            {
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "Los Carteles Cubanos del Cine",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.proy-1-1.jpg"),
                    PosterWidth = 1000,
                    PosterHeight = 752,
                    Summary = string.Format("Un largo camino tuvo que transitar la colección de carteles del cine cubano (1960-1980) para formar parte del Programa Memoria del Mundo de la Unesco. El 12 de julio de 2017 la Comisión Cubana de la Unesco los inscribió en el Registro Nacional. En octubre del 2017, en Curazao, se hizo la certificación en el Registro de América Latina y el Caribe. En 2018 fueron reconocidos además como Patrimonio Cultural de la nación cubana.{0}{0}Finalmente, el 18 de mayo de este año 2023 se dio a conocer en el Consejo Ejecutivo de la Unesco que los carteles cinematográficos cubanos habían sido inscriptos en el Programa Memoria del Mundo de esa organización. Así lo confirmó la señora Anne Lemaistre, directora de la Oficina Regional de Cultura para América Latina y el Caribe.", System.Environment.NewLine)
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "La Calle de los Cines",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.proy-2-1.jpg"),
                    PosterWidth = 1000,
                    PosterHeight = 667,
                    Summary = string.Format("El Paseo Temático del Cine surgió en vísperas de los festejos por el 500 Aniversario de la Fundación de la Villa de Santa María del Puerto del Príncipe a raíz de una investigación realizada por la Oficina del Historiador de la Ciudad.{0}{0}En esta primera etapa fueron convocados los especialistas Armando Pérez Padrón y Juan Antonio García Borrero, con el fin de proponer el diseño de nombres para las instituciones y unidades, así como las ambientaciones del Paseo Temático, recayendo en el primero el crédito de tales acciones. Lógicamente, esa idea inicial fue enriqueciéndose y sufriendo abundantes cambios en la misma medida en que se adelantaba en la construcción, como fue la decisión de construir El Callejón de los Milagros cuando ya habían transcurrido varios meses de los movimientos de tierra.{0}{0}Hoy el Paseo Temático La Calle de los Cines es un espacio único dentro del país, que cuenta con una infraestructura asociada a las tecnologías digitales que la convierte en un área de vanguardia en el renglón de la gestión cultural.", System.Environment.NewLine)
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "Noticiero Latinoamericano ICAIC",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-3.jpg"),
                    PosterWidth = 183,
                    PosterHeight = 275,
                    Summary = string.Format("El Noticiero ICAIC Latinoamericano surge en 1960 y se diferencia de todos los realizados con anterioridad porque reseña la información visual bajo nuevos preceptos y sin incluir anuncios comerciales. Su frecuencia es semanal y de aproximadamente diez minutos de duración, aunque en determinadas ocasiones puede llegar a tener una duración de veinte minutos.{0}{0}Fundado por Alfredo Guevara y Santiago Álvarez, que es su director general y principal realizador desde sus inicios hasta su cierre, junto con los camarógrafos Arturo Agramonte, Dervis Pastor Espinosa y el narrador Julio Batista. Durante sus treinta años de existencia, este noticiero constituye, sin duda, una escuela en la que muchos jóvenes directores tienen sus primeras experiencias para después pasar a filmar documentales y largometrajes de ficción como son Manuel Pérez, Miguel Torres, Pastor Vega, Rolando Díaz, Daniel Díaz Torres, Fernando Pérez y Francisco Puñal Suárez, entre otros. También los editores Norma Torrado, Julia Yip y Jorge Abello; los técnicos de sonido Daniel Diez, Marcos Madrigal y los camarógrafos Iván Nápoles, Raúl Pérez Ureta y Luis Costales tienen una labor relevante en los años de este noticiero.{0}{0}El noticiero ofrece información nacional e internacional en los ámbitos artístico, cultural, deportivo, histórico y económico y tiene un incuestionable atractivo para los espectadores que se ven en las pantallas como partícipes activos de los cambios revolucionarios. Independientemente de que las noticias reseñadas ya son difundidas por otros medios como la radio, la prensa y la televisión, en el noticiero la información cobra otra dimensión por el valor de la imagen, la utilización de la música y porque el mismo aporta un carácter valorativo más trascendente. Utiliza los más diversos e ingeniosos recursos para comunicar un mensaje: caricaturas, dibujos animados, gráfica, trucaje, foto animación y el color en sus ediciones especiales. Utiliza siempre la fotografía en blanco y negro.", System.Environment.NewLine)
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "Clandestinos",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-4.jpg"),
                    PosterWidth = 580,
                    PosterHeight = 870,
                    Genre = "Ficción",
                    Country = "Cuba",
                    Year = 1987,
                    Duration = 103.00D,
                    Direction = "Fernando Pérez Valdés",
                    Screenplay = "Jesús Díaz",
                    Production = "Santiago Llapur Milián",
                    Photography = "Adriano Moreno Rodríguez",
                    Edition = "Jorge Abello Heras",
                    Music = "Edesio Alejandro",
                    Audio = "Ricardo Istueta",
                    ArtManager = null,
                    Cast = "Luis Alberto García (hijo), Isabel Santos Téllez, Susana Pérez, René Losada, Amado del Pino, Miguel Gutiérrez, Miguel Navarro, Francisco Fonseca, Rolando Tarajano, Oscar Álvarez",
                    Summary = "Un joven, preso por sus actividades políticas durante la tiranía de Fulgencio Batista, recibe la visita de una muchacha desconocida, de quien desconfía. Ya en libertad, se reencuentran. Un amor surge entre ellos, paralelo a la lucha armada que condicionará sus vidas.",
                    Awards = string.Format("1987. Premios de Ópera Prima, otorgados por la AHS y por El Caimán Barbudo, Premio Rubén Martínez Villena, de la UJC y el Ministerio de Cultura, Premio El Mégano de la Federación Nacional de Cine Clubes, Premio Coral a la mejor actuación femenina a Isabel Santos, Festival Internacional del Nuevo Cine Latinoamericano, Cuba.{0}{0}1988. Premios Caracol de dirección, edición, banda sonora, de actuación a Isabel Santos y Luis Alberto García (hijo), Premio de ECITV-FAR, Premio de la FMC, Mención de actuación a Rolando Tarajano, Susana Pérez y Amado del Pino, otorgados por la Asociación de Artes Escénicas, Festival Nacional UNEAC de Cine, Radio y Televisión, Cuba / Premio Ópera Prima, Festival Internacional de Cine de Tashkent, URSS / Premios India Catalina de Oro a la mejor película, mejor dirección (exaequo) y mejor actuación masculina a Luis Alberto García (hijo), Festival Internacional de Cine de Cartagena, Colombia / Premio al mejor guion, Festival de Cine de San Juan, Puerto Rico.{0}{0}1991. Premio Inti, Festival de Cine de Perú.{0}{0}2008. Ocupa el lugar número 15 en la encuesta «Lo mejor de la producción del ICAIC (1959-2008), convocada por la Asociación Cubana de la Prensa Cinematográfica.", System.Environment.NewLine)
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "SOY CUBA",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-5.jpg"),
                    PosterWidth = 300,
                    PosterHeight = 456,
                    Genre = "Ficción",
                    Country = "Cuba, URSS",
                    Year = 1964,
                    Duration = 141.00D,
                    Direction = "Mijail Kalatozov",
                    Screenplay = "Evgueni Evtushenko, Enrique Pineda Barnet",
                    Production = "Miguel Mendoza, Simón Mariajin",
                    Photography = "Serguei Urusevsky",
                    Edition = "Lidia Turina",
                    Music = "Carlos Fariñas",
                    Audio = "Vladimir Sharum",
                    ArtManager = null,
                    Cast = "Luz María Collazo, Jean Bouise, Sergio Corrieri, José Gallardo, Raúl García Aparicio,Salvador Wood",
                    Summary = "Cuatro episodios que muestran diferentes aspectos de la vida en Cuba antes del triunfo revolucionario: una joven mestiza se prostituye; un campesino se inmola junto a sus cosechas; un grupo de estudiantes, en los días posteriores al desembarco del Granma, propone un atentado al jefe de la policía; un campesino de la Sierra Maestra, acosado por el ejército de la tiranía, decide incorporarse a la lucha armada.",
                    Awards = "1964. Prix Excellent, Congreso de la Unión Internacional de Técnicos Cinematográficos, Milán, Italia."
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "BESOS ROBADOS",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-6.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "Now!",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-7.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                    Genre = "Documental",
                    Country = "Cuba",
                    Year = 2000,
                    Duration = 45.00D,
                    Edition = "Norma Torrado, Idalberto Gálvez",
                    Summary = "Novedoso montaje de noticieros y fotos sobre la lucha de los negros norteamericanos contra la discriminación racial."
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "PON TU PENSAMIENTO EN MI",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-8.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "LA ULTIMA CENA",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-9.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "CINE MOVIL ICAIC",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-10.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "EL CHICUELO",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-11.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "EL CIUDADANO",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-12.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "HARAKIRI",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-13.jpg"),
                    PosterWidth = 939,
                    PosterHeight = 1332
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "Vampiros en La Habana",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-14.jpg"),
                    PosterWidth = 517,
                    PosterHeight = 720,
                    Genre = "Animación",
                    Country = "Cuba",
                    Year = 1987,
                    Duration = 103.00D,
                    Direction = "Juan Padrón",
                    Screenplay = null,
                    Production = null,
                    Photography = "Adalberto Hernández, Julio Simoneau Martínez",
                    Edition = "Rosa María Carreras Testa",
                    Music = "Rembert Egües",
                    Audio = "Ricardo Istueta",
                    ArtManager = "Juan Padrón",
                    Cast = "Manuel Marín, Margarita Agüero, Irela Bravo, Carlos González, Mirella Guillot, Carmen Solar, Juan Padrón",
                    Summary = "Unos vampiros de la mafia internacional intentan robar una fórmula mágica trasladada a La Habana por su inventor, la cual les permitirá vivir a la luz del día. Un animado al estilo del cine negro.",
                    Awards = null
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "LA MUERTE DE UN BUROCRATA",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-15.jpg"),
                    PosterWidth = 513,
                    PosterHeight = 768,
                    Genre = "Ficción",
                    Country = "Cuba",
                    Year = 1966,
                    Duration = 85.00D,
                    Direction = "Tomás Gutiérrez Alea",
                    Screenplay = "Alfredo del Cueto, Tomás Gutiérrez Alea, Ramón F Suárez",
                    Production = "Margarita Alexandre",
                    Photography = "Ramón F Suárez",
                    Edition = "Mario González",
                    Music = "Leo Brouwer Mezquida",
                    Audio = "Eugenio Vesa, Adalberto Jiménez, Carlos Fernández Fernández, Ricardo Istueta",
                    Cast = "Salvador Wood, Manuel Estanillo, Silvia Planas, Gaspar de Santelices, Pedro Pablo Astorga, Carlos Gargallo, Alicia Bustamante",
                    Summary = "Un obrero muere en un accidente de trabajo y es enterrado con su carné laboral, imprescindible para que la viuda pueda recibir una pensión. Para recuperarlo la familia se ve precisada a realizar una exhumación clandestina. Los impedimentos de la burocracia imposibilitan que se vuelva a enterrar el cadáver. Lo absurdo de la situación conduce a la violencia.",
                    Awards = string.Format("1966. Seleccionado como el mejor largometraje cubano exhibido en el año, Selección Anual de la Crítica, Cuba / Premio Especial del Jurado, Festival Internacional de Cine de Karlovy Vary, Checoslovaquia.{0}{0}1979. Seleccionado por los mejores créditos del año 1978, Círculo Dominicano de Críticos de Cine.{0}{0}1989. Figura en el segundo puesto en la selección de lo mejor del cine cubano, según encuesta de la revista Cine Cubano.{0}{0}2008. Ocupa el sexto lugar en la encuesta «Lo mejor de la producción del ICAIC (1959-2008), convocada por la Asociación Cubana de la Prensa Cinematográfica.", System.Environment.NewLine)
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "LOS DIOSES ROTOS",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-16.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                    Genre = "Ficción",
                    Country = "Cuba",
                    Year = 2008,
                    Duration = 96.00D,
                    Direction = "Ernesto Daranas Serrano",
                    Screenplay = "Ernesto Daranas Serrano",
                    Production = "Camilo Vives, Isabel Prendes",
                    Photography = "Rigoberto Senarega Madruga",
                    Edition = "Pedro Suárez",
                    Music = "Edesio Alejandro",
                    Audio = "Raúl Amargó (Nikita)",
                    ArtManager = "Erick Grass Marrero",
                    Cast = "Silvia Águila Pérez, Carlos Ever Fonseca, Héctor Noas, Annia Bú Maure, Isabel Santos Téllez, Eman Xor Oña",
                    Summary = "Una profesora universitaria que investiga sobre el famoso proxeneta cubano Alberto Yarini y Ponce de León, asesinado a inicios del siglo XX, está interesada en demostrar la vigencia del legendario personaje. Para lograrlo, se adentra en una de las zonas más complejas de la realidad habanera de hoy.",
                    Awards = string.Format("2007. Premio a la mejor maqueta de largometraje (ex-aequo), Festival Internacional de Cine Pobre Humberto Solás, Gibara, Cuba.{0}{0}2008. Premio del público, Premio de la Asociación Cubana de la Prensa Cinematográfica, Festival Internacional del Nuevo Cine Latinoamericano, Cuba / Seleccionada por la ACPC entre las diez mejores películas exhibidas en el año, Cuba / Premio Adolfo Llauradó de actuación femenina a Annia Bú, AHS, Cuba.{0}{0}2009. Premio Caricato al mejor actor a Héctor Noas, Sección de Artes Escénicas, Festival Nacional UNEAC de Cine, Radio y Televisión, Cuba / Premio a la mejor dirección de Arte, Premio de mejor música, 17 Providence Latin American Film Festival, Estados Unidos / Mención Especial del Jurado de la Prensa Extranjera, Gran Premio Especial del Público al Largometraje, Festival Internacional de Cine Pobre Humberto Solás, Gibara, Cuba.", System.Environment.NewLine)
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "RETRATO DE TERESA",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-17.jpg"),
                    PosterWidth = 260,
                    PosterHeight = 402,
                    Genre = "Ficción",
                    Country = "Cuba",
                    Year = 1979,
                    Duration = 103.00D,
                    Direction = "Pastor Vega Torres",
                    Screenplay = "Ambrosio Fornet, Pastor Vega Torres",
                    Production = "Evelio Delgado Suárez",
                    Photography = "Livio Delgado Camacho",
                    Edition = "Mirita Lores",
                    Music = "Carlos Fariñas",
                    Audio = "Germinal Hernández Veitía",
                    Cast = "Daisy Granados, Adolfo Llauradó, Alina Sánchez, Raúl Pomares, Eloísa Álvarez Guedes, Alejandro Lugo, Idalia Anreus, Miguel Benavides, Mario Limonta, Samuel Claxton, Elsa Gay, Norma Martínez, Isaura Mendoza, Germán Pinelli, Asenneh Rodríguez, Parmenia Silva",
                    Summary = "Una trabajadora de la textilera, delegada sindical, deviene promotora cultural. Su esposo machista opina que esas tareas le restan tiempo a las ocupaciones hogareñas y la acusa de negligente, pero ella reacciona en defensa de su emancipación.",
                    Awards = string.Format("1979. Seleccionado entre los filmes más significativos del año, Selección Anual de la Crítica, Cuba / Premios Caracol de largometraje, producción, mejor actuación femenina en cine a Daisy Granados, Concurso de la Sección de Cine, Radio y Televisión de la UNEAC, Cuba / Premio a la mejor actuación femenina (ex-aequo) a Daisy Granados y Premio del Comité de Mujeres Soviéticas, Festival Internacional de Cine de Moscú, URSS / Mención Especial del Jurado, Festival Internacional de Cine de Santarem, Portugal / Mención Especial del Jurado a Daisy Granados por su actuación, Festival de Cine Iberoamericano de Huelva, España / Segundo Premio, otorgado por el público, Semana Internacional de Cine de Autor,  Benalmádena, España.{0}{0}1980. Premios India Catalina de Oro a la mejor película, mejor actriz a Daisy Granados, Festival Internacional de Cine de Cartagena, Colombia / Premio a la mejor actuación femenina, otorgado por el público a Daisy Granados, Festival del Joven Cine, Hyeres, Francia / Filme notable del año, Festival Internacional de Cine de Londres, Inglaterra.{0}{0}2008. Ocupa el octavo lugar en la encuesta «Lo mejor de la producción del ICAIC (1959-2008), convocada por la Asociación Cubana de la Prensa Cinematográfica.", System.Environment.NewLine)
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "EL PIDIO VALDES",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-18.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "LUCIA",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-19.jpg"),
                    PosterWidth = 580,
                    PosterHeight = 831,
                    Genre = "Ficción",
                    Country = "Cuba",
                    Year = 1968,
                    Duration = 160.00D,
                    Direction = "Humberto Solás Borrego",
                    Screenplay = "Humberto Solás Borrego, Julio García Espinosa, Nelson Rodríguez",
                    Photography = "Jorge Herrera",
                    Edition = "Nelson Rodríguez",
                    Music = "Leo Brouwer Mezquida, Joseíto Fernández",
                    Audio = "Eugenio Vesa, Ricardo Istueta, Carlos Fernández",
                    Cast = "Raquel Revuelta, Eslinda Núñez, Adela Legrá, Eduardo Moure, Silvia Planas, Ramón Brito, Flora Lauten, Rogelio Blaín, María Elena Molinet, Adolfo Llauradó, Teté Vergara, Aramís Delgado, Flavio Calderín",
                    Summary = "Una mujer de mediana edad, perteneciente la aristocracia criolla, es seducida por un agente español, lo que permite que el ejército colonial descubra un campamento insurrecto. II: Una joven de la pequeña burguesía se enamora de un luchador contra la tiranía de Machado y abandona su familia para compartir sus ideales. III: Una joven campesina afronta los celos y los prejuicios machistas de su esposo.",
                    Awards = string.Format("1968. Seleccionado entre los diez mejores filmes estrenados en el año, Selección Anual de la Crítica, Cuba.{0}{0}1969. Primer Premio Medalla de Oro y Premio de la FIPRESCI, Festival Internacional de Cine de Moscú, URSS / Mención de Honor, Festival de Barcelona, España / Copa (ex-aequo) del Comité Central de Sangkum, Festival Internacional de Cine de Phnom Penh, Cambodia.{0}{0}1970. Seleccionada entre las veinte mejores películas del año, Festival Internacional de Cine de Tokío, Japón / Primer Premio Carabela, Semana Internacional de Cine de Valladolid, España / Primer Premio Globo de Oro, Festival de Cine de la Cineteca Italiana, Milán / Diploma de Honor, Biennale 1970, Viena, Austria.{0}{0}1971. Primer Premio Caracola, Semana Cultural «Alcances», Festival de Cine de Cádiz, España / Premio anual de la crítica al mejor filme, Círculo de Críticos de Arte, Santiago de Chile.{0}{0}1977. Cuarto lugar en la selección los mejores filmes del tercer mundo correspondientes al período 1968-1978 por la revista TakeOne, Canadá.{0}{0}1979. Seleccionado como la mejor fotografía en blanco y negro del año 1978, Círculo Dominicano de Críticos de Cine.{0}{0}1981. Seleccionada entre las diez mejores películas del Cine Iberoamericano, según una encuesta entre los críticos de América, España y Portugal, Festival de Cine Iberoamericano de Huelva, España.{0}{0}1989. Comparte con Memorias del subdesarrollo el primer lugar en la selección de lo mejor del cine cubano, según encuesta de la revista Cine Cubano.{0}{0}1996. Tercer lugar (ex-aequo) en la encuesta de la Asociación Cubana de la Prensa Cinematográfica para escoger las mejores películas latinoamericanas de todos los tiempos.{0}{0}2008. Ocupa el segundo lugar en la encuesta «Lo mejor de la producción del ICAIC (1959-2008), convocada por la Asociación Cubana de la Prensa Cinematográfica.", System.Environment.NewLine)
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "FRESA Y CHOCOLATE",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-20.jpg"),
                    PosterWidth = 919,
                    PosterHeight = 1366,
                    Genre = "Ficción",
                    Country = "Cuba",
                    Year = 1993,
                    Duration = 110.00D,
                    Direction = "Tomás Gutiérrez Alea, Juan Carlos Tabío",
                    Screenplay = "Senel Paz",
                    Production = "Miguel Mendoza",
                    Photography = "Mario García Joya",
                    Edition = "Miriam Talavera Fernández, Osvaldo Donatién",
                    Music = "José María Vitier García-Marruz",
                    Audio = "Germinal Hernández Veitía",
                    ArtManager = "Fernando Pérez O’Reilly",
                    Cast = "Jorge Perugorría, Vladimir Cruz, Mirtha Ibarra, Francisco Gattorno, Joel Angelino, Marilyn Solaya",
                    Summary = "Un homosexual culto y marginado, que ama a su país y sus tradiciones, conoce a un joven estudiante universitario con inquietudes literarias, pero militante de la Juventud Comunista. Entre los dos se establece una relación amistosa que derrumba incomprensiones, prejuicios e intolerancias.",
                    Awards = string.Format("1992. Premio Coral al guion inédito «Enemigo rumor», Festival Internacional del Nuevo Cine Latinoamericano, Cuba.{0}{0}1993. Premio Nacional de la Crítica, Asociación Cubana de la Prensa Cinematográfica, Cuba / Premio Especial Oso de Plata, Mención Especial del Jurado Ecuménico (INTERFILAS y OCIC), Segundo Premio de la popularidad de los lectores del Berliner Morgenpost, Festival Internacional de Cine de Berlín, Alemania / Primer Premio Coral, Premios Coral a mejor dirección, mejor actor a Jorge Perugorría y mejor actriz secundaria a Mirtha Ibarra / Premios de FIPRESCI, OCIC, UCCA y El Caimán Barbudo / Mención de Radio Habana Cuba / Premio de la popularidad, el jurado de la FIPRESCI reconoce a Tomás Gutiérrez Alea y Juan Carlos Tabío por su ilustre carrera dando lúcida perspectiva sobre la realidad cubana, Festival Internacional del Nuevo Cine Latinoamericano, Cuba.{0}{0}1994. Seleccionado entre los filmes más significativos del año, Asociación Cubana de la Prensa Cinematográfica / Premio Mariposa / Premios de actuación a Jorge Perrugorría, Vladimir Cruz, Mirtha Ibarra otorgados por la Sección de Artes Escénicas, Premios Caracol al mejor filme y guion, Festival Nacional UNEAC de Cine, Radio y Televisión, Cuba / Premios Kikito al mejor filme, mejor actuación masculina a Perugorría y Vladimir Cruz (ex-aequo), mejor actriz secundaria a Mirtha Ibarra, Festival de Cine de Gramado, Brasil / Premio del público, Premio de la crítica, Festival Internacional de Cine Latinoamericano de Paso Norte, Ciudad Juárez, México. / Premios Panambi a mejor película latinoamericana, guion, trabajo actoral a Jorge Perrugorría y Vladimir Cruz (exaequo) y banda sonora latinoamericana, Voto del público a la mejor película, Festival Internacional de Cine de Asunción, Paraguay / Premio Ondas entregado por Televisión Española, Madrid / Premio a la mejor película exhibida en Brasil, encuesta del periódico O´Globo, Brasil.{0}{0}1995. Premio Goya a la mejor película extranjera de habla hispana, otorgado por la Academia de Artes y Ciencias Cinematográficas de España / Nominada al Premio Oscar a la mejor película extranjera por la Academia de Artes y Ciencias Cinematográficas de Hollywood / Premios a mejor película, mejor dirección, mejor actuación protagónica a Jorge Perugorría, mejor actuación secundaria a Vladimir Cruz, otorgados por la Asociación de Críticos Cinematográficos de Los Ángeles, California, Estados Unidos.{0}{0}2001. Primer lugar en la producción fílmica cubana de la década del 90.{0}{0}2008. Ocupa el tercer lugar en la encuesta «Lo mejor de la producción del ICAIC (1959-2008), convocada por la Asociación Cubana de la Prensa Cinematográfica.", System.Environment.NewLine)
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "Por primera vez",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-21.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "José Martí, el ojo del canario",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-22.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                    Genre = "Ficción",
                    Country = "Cuba",
                    Year = 2010,
                    Duration = 120.00D,
                    Direction = "Fernando Pérez Valdés",
                    Screenplay = "Fernando Pérez Valdés",
                    Production = "Rafael Rey Rodríguez, Miguel Morales",
                    Photography = "Raúl Pérez Ureta",
                    Edition = "Julia Yip Nodarse",
                    Music = "Edesio Alejandro",
                    Audio = "Raúl Amargó (Nikita), Edesio Alejandro, Fernando Pérez Valdés",
                    ArtManager = "Erick Grass Marrero",
                    Cast = "Damián A Rodríguez, Daniel Romero Pildaín, Rolando Brito Rodríguez, Broselianda Hernández, Manuel Porto Sánchez, Julio César Ramírez",
                    Summary = "Recrea pasajes de la vida de José Martí entre los 9 y los 17 años, período en que conoció de cerca a su patria y aprendió a amarla, entenderla y luchar por ella.",
                    Awards = string.Format("2010. Colón de Plata a la mejor dirección y mejor fotografía, Festival de Cine Iberoamericano de Huelva, España / Segundo Premio del Público, Festival de Cine de Lima, Perú / Premio a la mejor dirección a Fernando Pérez, mejor dirección de arte / Premio SIGNIS de la Asociación Católica del Cine y el Audiovisual / Premio Roque Dalton concedido por la Emisora Radio Habana Cuba / Premio El Mégano de la Federación Nacional de Cine Clubes / Galardón de UNICEF / Premio Caminos del Centro Martin Luther King / Premio UNEAC / Premio Vigía / Premio de la Asociación Cubana de la Prensa Cinematográfica / Premio al mejor cartel, Festival Internacional del Nuevo Cine Latinoamericano, Cuba.{0}{0}2011. Premio Ariel a la mejor película iberoamericana (ex-aequo), Academia Mexicana de Artes y Ciencias cinematográficas / Premio de dirección, de dirección de arte, de fotografía en la categoría de ficción, Concurso Caracol UNEAC, Cuba / Premio Mariposa.", System.Environment.NewLine)
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "NUESTROS AÑOS FELICES",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-23.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                }
            };
        }
    }
}
