using MOROPO.CPCC.CinemaStreet.Arsmart.Models.Data;
using Xamarin.Forms.PlatformConfiguration;

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
            var authorEduardo = new AuthorDataModel 
            { 
                Id = System.Guid.NewGuid(),
                Name = "Eduardo Muñoz Bachs.",
                FeatureImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.Eduardo_Muñoz.jpg"),
                Context = "n. Valencia, España, 12 de abril de 1937, m. Cuba, 22 de julio de 2001.",
                Sumary = "Dibujante, pintor, ilustrador y diseñador gráfico. Su obra comprende ilustraciones para libros y revistas, publicidad, pintura, animación, así como más de 2000 carteles de cinematográficos.",
                About = string.Format("Fue fundador del Departamento de Animación y Carteles del ICAIC, y autor del póster para la película Historias de la Revolución, de Tomás Gutiérrez Alea, primero en la historia de esa institución. Considerado como uno de los artista más importante del cartelismo cubano, en sus obras están presentes la originalidad, voluntad de estilo, simbolismo, imaginación, humor, ironía, cosmopolitismo, plasticidad y policromía. Partiendo de las metáforas sugeridas por sus imágenes, consolidó un estilo que dejó símbolos tan trascendentes como la figura de Charlot.{0}{0}Muchos fueron los reconocimientos que mereció durante su carrera artística, en Cuba obtuvo 21 premios y varios internacionales. Fue miembro de la UNEAC, recibió la Distinción por la Cultura Nacional y las medallas “Raúl Gómez García” y la “Alejo Carpentier”.", System.Environment.NewLine)
            };
            var authorPablo = new AuthorDataModel
            {
                Id = System.Guid.NewGuid(),
                Name = "Pablo René Azcuy Cárdenas.",
                FeatureImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.Pablo_Rene_Azcuy.jpg"), 
                Context = "n. La Habana, Cuba, 28 de abril de 1939; m. Miami, Estados Unidos, 25 de marzo de 2019.",
                Sumary = "Diseñador gráfico. Uno de los grandes maestros del cartelismo cubano, con más de 300 obras creados para el ICAIC.",
                About = string.Format("A los 16 años comenzó sus estudios artísticos en la Academia de Bellas Artes San Alejandro, y con posterioridad en la Escuela Superior de Artes y Oficios hasta 1957. Cursó estudios de psicología los que, según el propio artista, serían fundamentales en la conceptualización que animara su obra.{0}{0}Fundador del ICAIC, realizó carteles de filmes cubanos y extranjeros, además de diseñar vallas, logotipos, créditos de filmes, escenografías, etc. Ganó numerosos reconocimientos, y a partir de 1992 comenzaría a vivir y trabajar en México.", System.Environment.NewLine)
            };
            var authorAlfredo = new AuthorDataModel
            {
                Id = System.Guid.NewGuid(),
                Name = "Alfredo Juan González.",
                FeatureImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.Alfredo_Juan_Gonzalez.jpg"), 
                Context = "n. Guantánamo, 31 de diciembre de 1947, m. La Habana, 27 de diciembre de 2004.",
                Sumary = "Graduado de la Escuela de Artes Plásticas de Santiago de Cuba. Dibujante publicitario, pintor, diseñador gráfico y profesor, se destacó por la realización del cartel que representó el símbolo de la nueva canción cubana: La rosa y la espina.",
                About = string.Format("De 1965 y 1970 participó en la producción gráfica del Instituto Cubano de Arte e Industria Cinematográficos (ICAIC), donde diseño más de 200 carteles para la presentación de estrenos de películas. En sus diseños quedaron expuestos efectos ópticos y cinéticos y la línea del pop, entremezclada con un chispeante simbolismo perspicaz.{0}{0}Director Artístico y fundador de la revista Tricontinental y del Departamento de Publicaciones y Divulgación de la Organización de Solidaridad de los Pueblos de África, Asia y América Latina.{0}{0}Ganador de innumerables premios y reconocimientos, desde 1966, es de los precursores del diseño gráfico para la promoción de eventos culturales, políticos y sociales que se gestó en la época de oro del cartel cubano. Formó parte del colectivo de diseñadores que recibieron, en 1970, el Premio Especial durante el Primer Concurso Internacional de Afiches Cinematográficos del XXI Festival Internacional de Cannes, Francia. El Centro de Diseño de la Universidad de Québec, en Canadá, lo consideró uno de los sietes grandes del diseño del cartel cubano de la Revolución.{0}{0}A finales del siglo XX se destacó por su labor docente en el Instituto Superior de Diseño Industrial (ISDI).\r\n.", System.Environment.NewLine)
            };
            var authorRaulM = new AuthorDataModel
            {
                Id = System.Guid.NewGuid(),
                Name = "Raúl Martínez González.",
                FeatureImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.Raul_Martinez.jpg"),
                Context = "n. Ciego de Ávila, el 1 de noviembre de 1927, m. La Habana el 2 de abril de 1995.",
                Sumary = "Pintor, diseñador y fotógrafo cubano. Uno de los exponentes más importantes del expresionismo abstracto de mediados del siglo XX y paradigma del pop art en Cuba.",
                About = string.Format("Artista multifacético comenzó en 1958 a realizar murales en distintos centros de la capital. A partir de 1960 y hasta el final de su vida diseñó revistas y libros de prestigiosas instituciones culturales, carteles para obras de teatro y de cine, escenografías de piezas teatrales, y experimentó la conjunción de pintura y fotografía en espectáculos de teatro y danza. Asumió la dirección artística del magazín Lunes de Revolución y fue profesor de diseño en la Facultad de Arquitectura de la Universidad de La Habana y en la Escuela Nacional de Arte.{0}{0}Hacia 1970 Martínez conformó el retrato colectivo de la nación mediante el procedimiento de yuxtaponer fotografías -una nueva dimensión del collage-, con fuerte colorido e insertando en las superficies otros símbolos de la cubanidad como flores, frutas y animales del país, y alguna que otra cita postmoderna.{0}{0}Otra de sus importantes obras lo fue 15 repeticiones de Martí (pintura) donde el artista obtiene sugerentes matices en la expresión del rostro de José Martí.{0}{0}Desde 1983 participó en proyectos de inserción del arte en la vida social como Telarte y Arte en la Carretera.\r\nPor su fecunda obra recibió innumerables premios y reconocimientos entre los que destacan la Distinción por la Cultura Nacional, Medalla Alejo Carpentier y el Premio Nacional de Artes Plásticas, este último otorgado por vez primera.{0}{0}En 1994 fue acreedor del título de Doctor Honoris Causa otorgado por el Instituto Superior de Arte.", System.Environment.NewLine)
            };
            var authorRene = new AuthorDataModel
            {
                Id = System.Guid.NewGuid(),
                Name = "René Portocarrero.",
                FeatureImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.Rene_Portocarrero.jpg"), 
                Context = "n. La Habana, 24 de febrero de 1912- m.7 de abril de 1985.",
                Sumary = "Una de las figuras cimeras de las artes plásticas de Cuba. Su universo pictórico comprende la creación de cuadros, ilustración de libros y revistas, diseños gráficos y los murales.",
                About = string.Format("Fue fundador del Departamento de Animación y Carteles del ICAIC, y autor del póster para la película Historias de la Revolución, de Tomás Gutiérrez Alea, primero en la historia de esa institución. Considerado como uno de los artista más importante del cartelismo cubano, en sus obras están presentes la originalidad, voluntad de estilo, simbolismo, imaginación, humor, ironía, cosmopolitismo, plasticidad y policromía. Partiendo de las metáforas sugeridas por sus imágenes, consolidó un estilo que dejó símbolos tan trascendentes como la figura de Charlot.{0}{0}Muchos fueron los reconocimientos que mereció durante su carrera artística, en Cuba obtuvo 21 premios y varios internacionales. Fue miembro de la UNEAC, recibió la Distinción por la Cultura Nacional y las medallas “Raúl Gómez García” y la “Alejo Carpentier”.", System.Environment.NewLine)
            };
            var authorAntonio = new AuthorDataModel
            {
                Id = System.Guid.NewGuid(),
                Name = "Antonio Fernández Reboiro.",
                FeatureImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.Antonio_Fernandez.jpg"), 
                Context = "n. Camagüey, 1935, m. España, 2020.",
                About = "Estudió medicina durante seis años antes de dedicarse a la arquitectura y el diseño en la Universidad de La Habana. Fundó la revista turística Havana Picture Guide, y colaboró en la construcción de las escuelas de arte de La Habana. En 1963, se incorporó al departamento de carteles del ICAIC. Este verdadero laboratorio de experimentación le ofreció durante casi dos décadas un espacio donde dar rienda suelta a su imaginación desbordante influenciada tanto por el Art Nouveau, el Art Decó, el pop art y el arte psicodélico."
            };
            var authorJulio = new AuthorDataModel
            {
                Id = System.Guid.NewGuid(),
                Name = "Julio Eloy Mesa.",
                FeatureImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.Julio_Eloy.jpg"), 
                Context = "n. Placetas, Las Villas, Cuba, 12 de abril de 1943.",
                Sumary = "En 1962 comienza a trabajar en el Instituto Cubano del Arte e Industria Cinematográficos (ICAIC) en el Departamento de Escenografía. En dicha institución realiza más de cien carteles.",
                About = string.Format("En los años cincuenta estudia pintura comercial y arquitectónica en la Academia Garcés de La Habana. Desde 1963 hasta 1966 cursa estudios en la Escuela Nacional de Artes Plásticas San Alejandro. Más tarde se prepara en diseño gráfico en la Escuela de Diseño de La Habana y entre 1975 y 1976 recibe clases de Historia del Arte en la Facultad de Artes y Letras de la Universidad de La Habana. Diseña carteles para las muestras de la Cinemateca de Cuba, y de cine cubano en el extranjero.{0}{0}Entre 1987 y 1992 es director artístico de la revista Cine Cubano. Participa en numerosas exposiciones personales y colectivas y su obra forma parte de las colecciones del ICAIC y del Museo Nacional de Bellas Artes de La Habana. Obtiene varios premios como en el International Film Posters Exhibition, Otawa (1972), Concurso de Carteles de Cine de Moscú (1973) y Concurso Internacional de Afiches de Cine del Festival de Cannes (1976), entre otros.", System.Environment.NewLine)
            };
            var authorServando = new AuthorDataModel
            {
                Id = System.Guid.NewGuid(),
                Name = "Servando Cabrera Moreno.",
                FeatureImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.Servando_Cabrera.jpg"),
                Context = "n. La Habana, 28 de mayo de 1923 – m. La Habana, 30 de septiembre de 1981.",
                Sumary = "Una de las figuras más singulares y destacadas de la plástica cubana.",
                About = string.Format("Graduado en la Escuela de San Alejandro. Desarrolló una obra marcada por etapas figurativas que exaltaron la esencia campesina, la sensualidad y el erotismo, así como el compromiso social, especialmente tras el triunfo de la Revolución Cubana. Produjo series icónicas como “Habaneras” y “Guajiros”, caracterizadas por retratar la cubanía, lo popular y lo humano a través de un estilo lírico y expresivo.{0}{0}Además de su aporte a la pintura y el dibujo, Cabrera Morera incursionó con éxito en la gráfica, siendo parte fundamental del movimiento de carteles cubanos que revolucionó el imaginario visual de la isla. Su trabajo para el ICAIC es parte esencial del patrimonio gráfico nacional y continúa siendo una referencia obligada en la historia del diseño en Cuba.", System.Environment.NewLine)
            };
            var authorRaulV = new AuthorDataModel
            {
                Id = System.Guid.NewGuid(),
                Name = "Raúl Valdés González.",
                FeatureImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.Raul_Valdes.jpg"), 
                Context = "n. La Habana, Cuba, el 4 de marzo de 1980.",
                Sumary = "Conocido por sus amigos y profesionalmente como Raupa.",
                About = string.Format("Es un artista independiente y ha creado imágenes de eventos e instituciones de gran importancia para la cultura cubana . Se especializa en diseño gráfico y motion graphics cinematográfico , producidos mediante la ilustración , la animación y el video.{0}{0}Principales premios: Mejor Director – Mejor Dirección Artística – Mejor Video Musical (El Vuelo del Moscardón), “The Bumble Bee Flight”. Interpretado por Aldo López – Gavilán en el disco “En Vivo”.{0}{0}Mejor diseñador, Premio Caja Alta 2014 (premio otorgado por la Unión de Escritores y Artistas de Cuba).", System.Environment.NewLine)
            };
            var authorGiselle = new AuthorDataModel
            {
                Id = System.Guid.NewGuid(),
                Name = "Giselle Monzón.",
                FeatureImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.Giselle_Monzon.jpg"), 
                Context = "n. Santa Clara, Cuba, 1979.",
                Sumary = "Es una prestigiosa diseñadora gráfica. Graduada en 2002 de Diseño de Comunicación Visual en el Instituto Superior de Diseño de La Habana, Giselle Monzón es uno de los talentos más prolíferos de la creación gráfica cubana contemporánea.",
                About = string.Format("Desde su graduación y hasta el año 2008 trabajó como profesora de la Facultad de Comunicación de la Universidad de la Habana. En paralelo ejerció como profesora adjunta en el Instituto Superior de Diseño (ISDI). Ha impartido varios cursos de diseño gráfico en Cuba y en el exterior.{0}{0}Sus obras, en las que trata principalmente temáticas culturales, han sido expuestas en importantes muestras en países como Suiza, Francia, España, Alemania o Estados Unidos.{0}{0}Ha colaborado con varias instituciones culturales nacionales e internacionales como el Centro de Desarrollo de las Artes Visuales (CDAV), de La Habana, el Centro Cultural Pablo de la Torriente Brau, el Instituto Cubano de la Música, el Consejo Nacional de las Artes Plásticas y muy especialmente con el ICAIC.{0}{0}Giselle Monzón ha participado en un gran número de exposiciones colectivas.", System.Environment.NewLine)
            };
            var authorErnesto = new AuthorDataModel
            {
                Id = System.Guid.NewGuid(),
                Name = "Ernesto Ferrand.",
                FeatureImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.proy-1-1.jpg"), //TODO CAMBIAR IMAGEN
                Context = "n. La Habana, Cuba, 1968.",
                Sumary = "Graduado en diseño gráfico en el Instituto Superior de Diseño Industrial (ISDI) en La Habana. Sus obras han ganado reconocimiento y premios internacionales.",
                About = string.Format("Comenzó sus estudios formales de diseño gráfico en la Escuela Experimental de Dibujo y Grabado de La Habana en 1982, a la temprana edad de 14 años. En 1991, se graduó de la escuela de arte más prominente de Cuba, la Academia de Bellas Artes de San Alejandro, con un título en Grabado, y luego completó una licenciatura de 5 años en diseño gráfico en el Instituto Superior de Diseño Industrial (ISDI) en La Habana.{0}{0}Sus obras han ganado reconocimiento y premios internacionales. Su arte de carteles y trabajo fotográfico se ha exhibido en numerosos espacios colectivos a nivel mundial, incluyendo la 4ª, 5ª y 6ª Bienal Internacional del Cartel celebrada en el Museo Franz Mayer, México DF y la 2ª Exposición Internacional de Carteles 2001 en Ningbo, China, entre otras.", System.Environment.NewLine)
            };
            var authorNiko = new AuthorDataModel
            {
                Id = System.Guid.NewGuid(),
                Name = "Antonio Pérez González.",
                FeatureImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.Antonio_Perez_Niko.jpg"), 
                Context = "n. La Habana, 1941.",
                Sumary = "es reconocido como uno de los más importantes y prolíficos diseñadores de carteles. Diseñador gráfico. Licenciado en Historia del Arte General de la Universidad de la Habana. En el año 1988 llegó a México donde trabaja y reside actualmente.",
                About = string.Format("Comenzó a trabajar en el ICAIC en el año 1968, en el departamento de Publicidad o  affiches. Tiene en su currículum una amplia experiencia docente como profesor de diseño en diferentes instituciones mexicanas y cubanas.{0}{0}Es miembro actual de:{0}{0}-International Council of Graphic Design Association (ICOGRADA) Inglaterra.{0}-Miembro Fundador y Honorario. Asociación de Diseñadores Gráficos “Amarillo”. Centro de Diseño. Xalapa, Veracruz.{0}-Unión de Escritores y Artistas de Cuba (UNEAC).{0}{0}Ha obtenido numerosos premios y reconocimientos, entre ellos:{0}{0}-Distinción “Por la Cultura Nacional”. La Habana, Cuba 1983.{0}-Selección del Cartel “Día de la Tierra”. Colección Permanente del Museo de Arte Moderno, Denver, Colorado, Estados Unidos 1995.{0}-Homenaje a 4 Diseñadores Cubanos. Poesía y Diseño. Instituto Cultural de Aguascalientes y Diseñadores del DF y Aguascalientes. Aguascalientes 2003.{0}-Medalla de Excelencia José Guadalupe Posada. Bienal Internacional de  Carteles México 2006.\r\n.", System.Environment.NewLine)
            };

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
                    Author = authorJulio,
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
                    Author = authorRene,
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
                    Summary = "Esta coproducción cubano-soviética se compone de cuatro episodios que retratan la vida en Cuba antes del triunfo de la Revolución:{0}{0}- Una joven prostituta en La Habana, atrapada entre el turismo y la pobreza.{0}{0}- Un campesino que quema su campo de caña al perderlo ante una compañía extranjera.{0}{0}- Un estudiante revolucionario que enfrenta la represión en la Universidad de La Habana.{0}{0}- Campesinos que apoyan a los guerrilleros en la Sierra Maestra.{0}{0}La película se destaca por su estilo visual lírico y sus tomas de cámara innovadoras, que han influido en cineastas como Scorsese y Coppola. Aunque inicialmente fue ignorada, hoy es considerada una obra maestra del cine político y poético.",
                    Awards = "1964. Prix Excellent, Congreso de la Unión Internacional de Técnicos Cinematográficos, Milán, Italia."
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "BESOS ROBADOS",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-6.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                    Author = authorPablo,
                    Year = 1968,
                    Direction = "François Truffaut",
                    Cast = "Jean-Pierre Léaud (Antoine Doinel), Claude Jade (Christine), Delphine Seyrig (Fabienne Tabard), Michael Lonsdale (Georges Tabard)",
                    Summary = "Esta comedia romántica francesa continúa la saga del personaje Antoine Doinel. Tras ser expulsado del ejército, Antoine busca trabajo y termina como detective privado. Su misión lo lleva a infiltrarse en una zapatería, donde se enamora de la esposa del dueño. Mientras tanto, su relación con Christine, su novia, se tambalea. La película retrata con ligereza y profundidad las emociones juveniles, el amor, la búsqueda de identidad y el desencanto. Es un retrato íntimo de la juventud parisina en tiempos de cambio."
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "Now!",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-7.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                    Author = authorAlfredo,
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
                    Direction = "Arturo Sotto"
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "LA ULTIMA CENA",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-9.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                    Author = authorPablo,
                    Year = 1976,
                    Direction = "Tomás Gutiérrez Alea",
                    Cast = "Nelson Villagra (el conde), Silvano Rey (Sebastián), José Antonio Rodríguez, Luis Alberto García",
                    Summary = "Ambientada en la Cuba colonial del siglo XVIII, esta película narra cómo un conde español decide recrear la Última Cena de Cristo con doce esclavos en Jueves Santo. Su intención es evangelizarlos y demostrar su “bondad cristiana”. Sin embargo, tras la cena, los esclavos son brutalmente reprimidos por rebelarse contra las condiciones de esclavitud. La película es una crítica mordaz a la hipocresía religiosa y al poder colonial, y se convierte en una alegoría sobre la lucha por la libertad y la justicia social."
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "CINE MOVIL ICAIC",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-10.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                    Author = authorEduardo,
                    Year = 1961,
                    Cast = "Proyeccionistas como Alberto Sedeño y Rafael Hernández; comunidades rurales cubanas",
                    Summary = "El Cine móvil fue una iniciativa del Instituto Cubano del Arte e Industria Cinematográficos (ICAIC) para llevar el cine a zonas rurales y apartadas del país. Equipados con camiones adaptados, proyectores de 16 mm y pantallas enrollables, los equipos recorrían escuelas, fábricas y comunidades, alfabetizando visualmente a la población. Este proyecto fue clave en la formación de un público crítico y en la descolonización del gusto cinematográfico."
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "EL CHICUELO",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-11.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                    Author = authorPablo,
                    Year = 1921,
                    Direction = "Charles Chaplin",
                    Cast = "Charles Chaplin, Jackie Coogan, Edna Purviance",
                    Summary = "En esta obra maestra del cine mudo, Chaplin interpreta a un vagabundo que encuentra a un bebé abandonado y decide criarlo como su hijo. Juntos sobreviven en la pobreza con ingenio y ternura. Años después, la madre biológica, ahora una actriz famosa, busca al niño. La película combina comedia y drama para abordar temas como el abandono infantil, la pobreza y el amor incondicional. Fue el primer largometraje de Chaplin y sigue siendo una de sus obras más conmovedoras y universales."
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "EL CIUDADANO KANE",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-12.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                    Year = 1941,
                    Direction = "Orson Welles",
                    Cast = "Orson Welles, Joseph Cotten, Dorothy Comingore, Everett Sloane",
                    Summary = "La película narra la vida de Charles Foster Kane, un magnate de la prensa cuya última palabra antes de morir —“Rosebud”— desencadena una investigación periodística sobre su pasado. A través de flashbacks, se revela su ascenso desde una infancia humilde hasta convertirse en un poderoso empresario, y su posterior caída marcada por la soledad, el fracaso emocional y la pérdida de ideales. La historia explora temas como el poder, la identidad y la fragilidad humana."
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "HARAKIRI",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-13.jpg"),
                    PosterWidth = 939,
                    PosterHeight = 1332,
                    Author = authorAntonio,
                    Year = 1962,
                    Direction = "Masaki Kobayashi",
                    Cast = "Tatsuya Nakadai, Rentarō Mikuni, Shima Iwashita, Akira Ishihama",
                    Summary = "Ambientada en el Japón feudal, la historia sigue a Hanshirō Tsugumo, un rōnin empobrecido que solicita cometer harakiri en la residencia de un clan samurái. Antes de hacerlo, relata la trágica historia de su yerno, quien fue obligado a suicidarse con espadas de bambú. A través de su relato, se revela la hipocresía del código de honor samurái y la crueldad institucional. La película culmina en un acto de venganza y sacrificio que pone en evidencia la falsedad del honor feudal."
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "Vampiros en La Habana",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-14.jpg"),
                    PosterWidth = 517,
                    PosterHeight = 720,
                    Author = authorEduardo,
                    Genre = "Animación",
                    Country = "Cuba",
                    Year = 1985,
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
                    Summary = "Esta película animada mezcla humor, política y vampiros en una sátira ambientada en La Habana de los años 30. El científico vampiro Werner Von Drácula crea el Vampisol, una fórmula que permite a los vampiros resistir la luz solar. Su sobrino Pepito, híbrido humano-vampiro, se convierte en el portador de la fórmula, mientras mafias vampíricas europeas y norteamericanas intentan apoderarse de ella. En paralelo, Pepito participa en la lucha contra el régimen de Gerardo Machado. La historia culmina con la liberación del secreto del Vampisol a todos los vampiros del mundo.",
                    Awards = null
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "LA MUERTE DE UN BUROCRATA",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-15.jpg"),
                    PosterWidth = 513,
                    PosterHeight = 768,
                    Author = authorAlfredo,
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
                    Summary = "Esta comedia satírica narra la absurda odisea de un joven que intenta recuperar el carnet laboral de su tío fallecido, enterrado con él por error. Sin ese documento, la viuda no puede reclamar la pensión. Lo que sigue es una crítica feroz al laberinto burocrático cubano, con escenas surrealistas y referencias al cine clásico (Chaplin, Buñuel, Laurel & Hardy). La película combina humor negro con denuncia social, mostrando cómo el exceso de trámites puede llevar a la desesperación y al absurdo total.",
                    Awards = string.Format("1966. Seleccionado como el mejor largometraje cubano exhibido en el año, Selección Anual de la Crítica, Cuba / Premio Especial del Jurado, Festival Internacional de Cine de Karlovy Vary, Checoslovaquia.{0}{0}1979. Seleccionado por los mejores créditos del año 1978, Círculo Dominicano de Críticos de Cine.{0}{0}1989. Figura en el segundo puesto en la selección de lo mejor del cine cubano, según encuesta de la revista Cine Cubano.{0}{0}2008. Ocupa el sexto lugar en la encuesta «Lo mejor de la producción del ICAIC (1959-2008), convocada por la Asociación Cubana de la Prensa Cinematográfica.", System.Environment.NewLine)
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "LOS DIOSES ROTOS",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-16.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                    Author = authorRaulV,
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
                    Summary = "Laura, profesora universitaria, investiga la figura del proxeneta cubano Alberto Yarini, asesinado en 1910. Su búsqueda la lleva a los márgenes de la sociedad habanera contemporánea, donde se entrecruzan el culto religioso, la prostitución y el poder. Paralelamente, Sandra y Alberto intentan escapar de un entorno marcado por la violencia y la desesperanza. El filme es una reflexión sobre la ética, la memoria y los límites entre lo sagrado y lo profano, con una estética que mezcla drama social y suspenso.",
                    Awards = string.Format("2007. Premio a la mejor maqueta de largometraje (ex-aequo), Festival Internacional de Cine Pobre Humberto Solás, Gibara, Cuba.{0}{0}2008. Premio del público, Premio de la Asociación Cubana de la Prensa Cinematográfica, Festival Internacional del Nuevo Cine Latinoamericano, Cuba / Seleccionada por la ACPC entre las diez mejores películas exhibidas en el año, Cuba / Premio Adolfo Llauradó de actuación femenina a Annia Bú, AHS, Cuba.{0}{0}2009. Premio Caricato al mejor actor a Héctor Noas, Sección de Artes Escénicas, Festival Nacional UNEAC de Cine, Radio y Televisión, Cuba / Premio a la mejor dirección de Arte, Premio de mejor música, 17 Providence Latin American Film Festival, Estados Unidos / Mención Especial del Jurado de la Prensa Extranjera, Gran Premio Especial del Público al Largometraje, Festival Internacional de Cine Pobre Humberto Solás, Gibara, Cuba.", System.Environment.NewLine)
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "RETRATO DE TERESA",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-17.jpg"),
                    PosterWidth = 260,
                    PosterHeight = 402,
                    Author = authorServando,
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
                    Summary = "Teresa, obrera textil y delegada sindical, acepta el cargo de promotora cultural en su fábrica. Su esposo, Ramón, la acusa de descuidar el hogar, lo que desencadena una crisis conyugal. Teresa defiende su derecho a la emancipación plena, enfrentando los prejuicios machistas arraigados en la sociedad cubana. El filme se convirtió en un símbolo del debate sobre el rol de la mujer en la Revolución, con un final abierto que invita a la reflexión sobre el cambio social y personal.",
                    Awards = string.Format("1979. Seleccionado entre los filmes más significativos del año, Selección Anual de la Crítica, Cuba / Premios Caracol de largometraje, producción, mejor actuación femenina en cine a Daisy Granados, Concurso de la Sección de Cine, Radio y Televisión de la UNEAC, Cuba / Premio a la mejor actuación femenina (ex-aequo) a Daisy Granados y Premio del Comité de Mujeres Soviéticas, Festival Internacional de Cine de Moscú, URSS / Mención Especial del Jurado, Festival Internacional de Cine de Santarem, Portugal / Mención Especial del Jurado a Daisy Granados por su actuación, Festival de Cine Iberoamericano de Huelva, España / Segundo Premio, otorgado por el público, Semana Internacional de Cine de Autor,  Benalmádena, España.{0}{0}1980. Premios India Catalina de Oro a la mejor película, mejor actriz a Daisy Granados, Festival Internacional de Cine de Cartagena, Colombia / Premio a la mejor actuación femenina, otorgado por el público a Daisy Granados, Festival del Joven Cine, Hyeres, Francia / Filme notable del año, Festival Internacional de Cine de Londres, Inglaterra.{0}{0}2008. Ocupa el octavo lugar en la encuesta «Lo mejor de la producción del ICAIC (1959-2008), convocada por la Asociación Cubana de la Prensa Cinematográfica.", System.Environment.NewLine)
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "EL PIDIO VALDES",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-18.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                    Direction = "Juan Padrón"
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "LUCIA",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-19.jpg"),
                    PosterWidth = 580,
                    PosterHeight = 831,
                    Author = authorRaulM,
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
                    Summary = "Esta película está estructurada en tres episodios, cada uno protagonizado por una mujer llamada Lucía en diferentes momentos históricos de Cuba:{0}{0}- Lucía I (Raquel Revuelta) vive en 1895, durante la Guerra de Independencia contra España. Se enamora de un oficial español que la traiciona, lo que la lleva a la locura.{0}{0}- Lucía II (Eslinda Núñez) es una joven de clase media que lucha contra la dictadura de Gerardo Machado en los años 30, enfrentando la represión y el desencanto político.{0}{0}- Lucía III (Adela Legrá) es una campesina en los primeros años de la Revolución Cubana, que debe enfrentarse al machismo y a las estructuras patriarcales en su entorno rural.{0}{0}La película es una exploración profunda de la mujer cubana como símbolo de resistencia y transformación social, con una estética poderosa y una narrativa emocionalmente intensa.",
                    Awards = string.Format("1968. Seleccionado entre los diez mejores filmes estrenados en el año, Selección Anual de la Crítica, Cuba.{0}{0}1969. Primer Premio Medalla de Oro y Premio de la FIPRESCI, Festival Internacional de Cine de Moscú, URSS / Mención de Honor, Festival de Barcelona, España / Copa (ex-aequo) del Comité Central de Sangkum, Festival Internacional de Cine de Phnom Penh, Cambodia.{0}{0}1970. Seleccionada entre las veinte mejores películas del año, Festival Internacional de Cine de Tokío, Japón / Primer Premio Carabela, Semana Internacional de Cine de Valladolid, España / Primer Premio Globo de Oro, Festival de Cine de la Cineteca Italiana, Milán / Diploma de Honor, Biennale 1970, Viena, Austria.{0}{0}1971. Primer Premio Caracola, Semana Cultural «Alcances», Festival de Cine de Cádiz, España / Premio anual de la crítica al mejor filme, Círculo de Críticos de Arte, Santiago de Chile.{0}{0}1977. Cuarto lugar en la selección los mejores filmes del tercer mundo correspondientes al período 1968-1978 por la revista TakeOne, Canadá.{0}{0}1979. Seleccionado como la mejor fotografía en blanco y negro del año 1978, Círculo Dominicano de Críticos de Cine.{0}{0}1981. Seleccionada entre las diez mejores películas del Cine Iberoamericano, según una encuesta entre los críticos de América, España y Portugal, Festival de Cine Iberoamericano de Huelva, España.{0}{0}1989. Comparte con Memorias del subdesarrollo el primer lugar en la selección de lo mejor del cine cubano, según encuesta de la revista Cine Cubano.{0}{0}1996. Tercer lugar (ex-aequo) en la encuesta de la Asociación Cubana de la Prensa Cinematográfica para escoger las mejores películas latinoamericanas de todos los tiempos.{0}{0}2008. Ocupa el segundo lugar en la encuesta «Lo mejor de la producción del ICAIC (1959-2008), convocada por la Asociación Cubana de la Prensa Cinematográfica.", System.Environment.NewLine)
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "FRESA Y CHOCOLATE",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-20.jpg"),
                    PosterWidth = 919,
                    PosterHeight = 1366,
                    Author = authorErnesto,
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
                    Summary = "Ambientada en La Habana de los años 70, esta película narra la improbable amistad entre Diego, un artista homosexual, culto y escéptico, y David, un joven comunista lleno de prejuicios. Lo que comienza como un intento de seducción se transforma en una relación profunda que desafía las barreras ideológicas y emocionales impuestas por el sistema. A través de libros prohibidos, conversaciones intensas y vínculos inesperados, ambos personajes descubren nuevas formas de entender la libertad, la tolerancia y el amor. Es considerada una obra clave del cine cubano por su tratamiento pionero de la diversidad sexual y su crítica social sutil pero poderosa.",
                    Awards = string.Format("1992. Premio Coral al guion inédito «Enemigo rumor», Festival Internacional del Nuevo Cine Latinoamericano, Cuba.{0}{0}1993. Premio Nacional de la Crítica, Asociación Cubana de la Prensa Cinematográfica, Cuba / Premio Especial Oso de Plata, Mención Especial del Jurado Ecuménico (INTERFILAS y OCIC), Segundo Premio de la popularidad de los lectores del Berliner Morgenpost, Festival Internacional de Cine de Berlín, Alemania / Primer Premio Coral, Premios Coral a mejor dirección, mejor actor a Jorge Perugorría y mejor actriz secundaria a Mirtha Ibarra / Premios de FIPRESCI, OCIC, UCCA y El Caimán Barbudo / Mención de Radio Habana Cuba / Premio de la popularidad, el jurado de la FIPRESCI reconoce a Tomás Gutiérrez Alea y Juan Carlos Tabío por su ilustre carrera dando lúcida perspectiva sobre la realidad cubana, Festival Internacional del Nuevo Cine Latinoamericano, Cuba.{0}{0}1994. Seleccionado entre los filmes más significativos del año, Asociación Cubana de la Prensa Cinematográfica / Premio Mariposa / Premios de actuación a Jorge Perrugorría, Vladimir Cruz, Mirtha Ibarra otorgados por la Sección de Artes Escénicas, Premios Caracol al mejor filme y guion, Festival Nacional UNEAC de Cine, Radio y Televisión, Cuba / Premios Kikito al mejor filme, mejor actuación masculina a Perugorría y Vladimir Cruz (ex-aequo), mejor actriz secundaria a Mirtha Ibarra, Festival de Cine de Gramado, Brasil / Premio del público, Premio de la crítica, Festival Internacional de Cine Latinoamericano de Paso Norte, Ciudad Juárez, México. / Premios Panambi a mejor película latinoamericana, guion, trabajo actoral a Jorge Perrugorría y Vladimir Cruz (exaequo) y banda sonora latinoamericana, Voto del público a la mejor película, Festival Internacional de Cine de Asunción, Paraguay / Premio Ondas entregado por Televisión Española, Madrid / Premio a la mejor película exhibida en Brasil, encuesta del periódico O´Globo, Brasil.{0}{0}1995. Premio Goya a la mejor película extranjera de habla hispana, otorgado por la Academia de Artes y Ciencias Cinematográficas de España / Nominada al Premio Oscar a la mejor película extranjera por la Academia de Artes y Ciencias Cinematográficas de Hollywood / Premios a mejor película, mejor dirección, mejor actuación protagónica a Jorge Perugorría, mejor actuación secundaria a Vladimir Cruz, otorgados por la Asociación de Críticos Cinematográficos de Los Ángeles, California, Estados Unidos.{0}{0}2001. Primer lugar en la producción fílmica cubana de la década del 90.{0}{0}2008. Ocupa el tercer lugar en la encuesta «Lo mejor de la producción del ICAIC (1959-2008), convocada por la Asociación Cubana de la Prensa Cinematográfica.", System.Environment.NewLine)
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "Por primera vez",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-21.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                    Author = authorEduardo,
                    Year = 1967,
                    Direction = "Octavio Cortázar",
                    Cast = "Campesinos de las montañas orientales de Cuba",
                    Summary = "Este cortometraje documental de 10 minutos muestra la llegada del Cine móvil ICAIC a una remota comunidad rural donde los habitantes ven cine por primera vez. A través de sus reacciones espontáneas y emotivas, el filme captura el impacto cultural y humano de esta experiencia. Es considerado una joya del cine cubano por su sensibilidad y autenticidad, y ganó premios internacionales como la Paloma de Oro en Leipzig."

                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "José Martí, el ojo del canario",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-22.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                    Author = authorGiselle,
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
                    Summary = "Esta película reconstruye la infancia y adolescencia de José Martí, desde los 9 hasta los 17 años, en un viaje íntimo y poético por los momentos que forjaron su conciencia patriótica. Dividida en cuatro partes (“Abejas”, “Arias”, “Cumpleaños” y “Rejas”), muestra su contacto con la injusticia, la naturaleza, el arte y la represión colonial. Más que una biografía, es un “itinerario espiritual” que humaniza al héroe nacional cubano, alejándolo de la estatua marmórea para acercarlo al espectador como un joven sensible, rebelde y profundamente observador.",
                    Awards = string.Format("2010. Colón de Plata a la mejor dirección y mejor fotografía, Festival de Cine Iberoamericano de Huelva, España / Segundo Premio del Público, Festival de Cine de Lima, Perú / Premio a la mejor dirección a Fernando Pérez, mejor dirección de arte / Premio SIGNIS de la Asociación Católica del Cine y el Audiovisual / Premio Roque Dalton concedido por la Emisora Radio Habana Cuba / Premio El Mégano de la Federación Nacional de Cine Clubes / Galardón de UNICEF / Premio Caminos del Centro Martin Luther King / Premio UNEAC / Premio Vigía / Premio de la Asociación Cubana de la Prensa Cinematográfica / Premio al mejor cartel, Festival Internacional del Nuevo Cine Latinoamericano, Cuba.{0}{0}2011. Premio Ariel a la mejor película iberoamericana (ex-aequo), Academia Mexicana de Artes y Ciencias cinematográficas / Premio de dirección, de dirección de arte, de fotografía en la categoría de ficción, Concurso Caracol UNEAC, Cuba / Premio Mariposa.", System.Environment.NewLine)
                },
                new Models.Data.TargetInfoDataModel
                {
                    Id = System.Guid.NewGuid(),
                    Title = "NUESTROS AÑOS FELICES",
                    PosterImage = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.poster-23.jpg"),
                    PosterWidth = 927,
                    PosterHeight = 1366,
                    Author = authorNiko,
                    Year = 1973,
                    Direction = "Sydney Pollack",
                    Cast = "Barbara Streisand, Robert Redford",
                    Summary = "Katie, una mujer idealista y comprometida políticamente, se enamora de Hubbell, un escritor carismático pero conformista. A pesar de sus diferencias ideológicas y de personalidad, inician una relación que atraviesa varias décadas. El amor entre ellos se ve tensionado por el contexto político de EE.UU., especialmente durante la caza de brujas en Hollywood. Aunque se aman profundamente, sus valores los separan. La película es una reflexión sobre el amor, la incompatibilidad y la memoria emocional"
                }
            };
        }
    }
}
