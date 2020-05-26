using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juventus.AcercaDeNosotros
{
    public partial class AcercaNos : Form
    {
        //historia de la organizacion
        private string info = "El Ateneo Juventus es una agrupación juvenil que se constituye el 26 de abril de 1958 en la Parroquia del Sagrado Corazón de los Padres Capuchinos de Córdoba, bajo la inspiración del Padre Carmelo D´Agostino." +
            "\n Este movimiento nace a fin de dar cauce a inquietudes de jóvenes en su necesidad de búsqueda de una mayor formación.Desde sus inicios procuró perfilarse como un nuevo nucleamiento dinámico y vital intentando satisfacer de este modo las expectativas juveniles." +
            "\n En un comienzo nace como Ateneo Deportivo Juventus, siendo una organización para varones.Entre sus actividades se contemplaba el deporte con la formación humana y cristiana.Todas las semanas los jóvenes tenían ocasiones de practicar fútbol, ping-pong, billar y realizándose como complemento charlas formativas.De vez en cuando se realizaban excursiones a las sierras, las que dieron lugar, más adelante  a los primeros Campamentos Formativos.Luego se fue dando más tiempo a la formación, transformándose el deporte en un complemento secundario y la denominación deAteneo Deportivo Juventus cambió por la de Ateneo Juventus." +
            "\n Hacia el año 1965 en el Ateneo se instaura una nueva modalidad y se hace mixto, acorde con el espíritu que traían los nuevos tiempos.De este modo se termina de organizar como un movimiento juvenil cuyos objetivos fueron formar a los jóvenes para la vida, en una realidad contemporánea y realista y preparar a los futuros dirigentes cristianos.";

        public AcercaNos()
        {
            InitializeComponent();
        }

        private void AcercaNos_Load(object sender, EventArgs e)
        {
            txtHistoria.Text = info;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
