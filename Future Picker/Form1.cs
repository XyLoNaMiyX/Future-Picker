using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Imaging;

namespace Future_Picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables

        public class Question {
            public string Quest { get; set; }
            public int Score { get; set; }

            public Question(string question, int score) {
                Quest = question;
                Score = score;
            }
        }

        string[] questionsStrings = new string[] {
            "Examinar, analizar y estudiar el funcionamiento de máquinas nuevas e inventos tecnológicos.",
            "Reparar equipos de sonido, ordenadores, televisores, frigoríficos, aire acondicionado, etc.",
            "Intervenir en la elaboración de contratos, escrituras y testamentos.",
            "Diagnosticar y administrar tratamientos médicos, para curar o prevenir las enfermedades de los seres humanos.",
            "Traducir e interpretar textos escritos en otro idioma.",
            "Relizar funciones de protección, seguridad y vigilancia",
            "Desarrollar y realizar un guión cinematográfico.",
            "Realizar estudios en el área de las matemáticas y la estadística.",
            "Componer, dirigir o interpretar obras musicales.",
            "Estudiar la evolución de las razas humanas, su organización política, social, econónmica y cultural (estilos artísticos, etc.).",
            "Realizar estudios e investigaciones sobre diferentes rocas.",
            "Manejar máquinas de oficina (ordenador, calculadoras, etc.) y comunicaciones telefónicas.",
            "Planificar, organizar, dirigir y controlar las actividades de una empresa.",
            "Trabajar e interesar,e por las explotaciones ganaderas y resolver sus problemas.",
            "Clasificiar documentos, cartas, sellos, diapositivas u otros objetos por temas.",
            "Entrenar o preparar a deportistas para mejorar su rendimiento.",
            "Informar de los acontecimientos de la actualidad.",
            "Indagar y descubrir por qué de las teorías científicas.",
            "Diseñar muebles, cerámica, complementos, prendas de vestir, joyas, etc.",
            "Participar en la política regional o nacional.",
            "Diseñar, proyectar y elaborar los planos de un edificio en la ciudad.",
            "Construir o reparar muebles u objetos de madera.",
            "Dirigir o participar en las actividades de un banco.",
            "Diagnosticar, prevenir y tratar las enfermedades y/o lesiones de los animales.",
            "Estudiar el origen y evolución de las lenguas.",
            "Perseguir, detener y poner a disposición judicial a aquellos que cometen delitos.",
            "Crear o diseñar anuncios publiciatrios.",
            "Realizar experimentos para analizar y estudiar los fenómenos químicos y bioquímicos.",
            "Dar ercitales de canto y música.",
            "Dar clases en un colegio.",
            "Dirigir la instalación de sistemas de alarmas.",
            "Realizar actividades donde se requiera habilidad manual y práctoca.",
            "Intervenir ante los tribunales de justicia en nombre de la ley, representando a un cliente.",
            "Organizar una finca supervisando el cuidado de los animales.",
            "Ordenar, clasificar y archivar documentos e informes.",
            "Dirigir las competiciones deportivas y aplicar las reglas establecidas.",
            "Componer, dirigir o interpretar una representación teatral, televisiva o cinematográfica.",
            "Hacer descubrimientos científicos.",
            "Restaurar obras de arte, tomando decisiones propias sobre la forma, modo y técnica a aplicar.",
            "Investigar los problemas psicológicos de las personas.",
            "Estudiar, proyectar y construir instalaciones eléctricas, puentes, túneles, etc.",
            "Ajustar maquinaria e instalar equipos eléctricos en fábricas o edificios.",
            "Asesorar sobre problemas contables, financieros y/o económicos.",
            "Investigar en un laboratorio el origen de las enfermedades.",
            "Organizar y clasificar libros y documentos en una biblioteca.",
            "Prestar servicios en organismos y establecimientos militares.",
            "Presentar las noticias en los informativos de tv.",
            "Organizar la repoblación del monte seleccionando las plantas más adecuadas.",
            "Crear y ejecutar pasos de danza.",
            "Estudiar teorías relativas al compotramiento del ser humano.",
            "Elaborar y diseñar programas informáticos.",
            "Reparar las averías de los vehículos.",
            "Aplicar los principios de la teoría económica para solcuionar problemas financieros en empresas.",
            "Prescribir medicamentos para la curación de enfermedades.",
            "Traducir textos de diferentes idiomas.",
            "Organizar y planificar competiciones deportivas.",
            "Redactar noticias, comentar informaciones y coordinar la redacción de una publicación.",
            "Investigar en un laboratorio para la creación de nuevos materiales.",
            "Fotografiar, esculpir o pintar creaciones artísticas.",
            "Orientar profesional y/o académicamente a las personas."
        };

        string[] fields = new string[10] {
            "Científico técnico",
            "Técnico aplicado",
            "Jurídico Administrativo",
            "Bio-sanitario",
            "Lingüistico literario",
            "Físico deportivo",
            "Publicidad y medios de comunicación",
            "Científico experimental",
            "Artístico musical",
            "Ciencias sociales"
        };

        Point p0 = new Point(9, 9);

        List<Question> questions = new List<Question>();

        #endregion


        //Max 6 pts.
        //Campo 1: 1-11-21-31-41-51
        //Campo 2: 2-12-22-32-42-52
        
        //Campos 1                      2                   3                           4               5                        6                   7                                      8                           9                       10
        //Campos Científico-técnico     Técnico-aplicado    Jurídico-administrativo     Bio-sanitario    Lingüistico y literario  Físico-deportivo    Publicidad y medios de comunicación    Científico-experimental     Artístico y musical     Ciencias sociales

        //-6 _ -3   = Baja
        //-2 _ 2    = Media
        // 3 _ 6    = Alta

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Location = p0;
            this.Size = this.MinimumSize;
        }

        private void startB_Click(object sender, EventArgs e)
        {
            Start();
        }

        #region Quiz manager

        int q = 0;

        private void Start() {
            startB.Enabled = false;
            startB.Text = "El test ha comenzado";
            this.Text = "Elige tu futuro";

            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Location = p0;

            Ease();
        }

        private void DoneStart()
        {
            this.Size = panel2.Size;
            questionL.Text = questionsStrings[q];
            questionL.MaximumSize = new Size(this.Size.Width - 40, 40);
            panel2.Enabled = true;

            tp.Interval = 2;
            tp.Enabled = true;
            tp.Tick += tp_Tick;
        }

        int sen = 0;

        Timer tf = new Timer();

        private void Ease() {
            tf.Interval = 5;
            tf.Enabled = true;
            tf.Tick += t_Tick;
        }

        void t_Tick(object sender, EventArgs e)
        {
            double s = Math.Sin(Math.PI * sen / 180);

            if (sen < 90)
                sen++;
            else
            {
                DoneStart();
                tf.Dispose();
            }

            double width = s * panel2.Size.Width;
            double height = s * panel2.Size.Height;
            this.Size = new Size((int)width, (int)height);
        }

        private void NextQuestion(int score) {
            questions.Add(new Question(questionsStrings[q], score));
            q++;

            if (q < questionsStrings.Length)
            {
                questionL.Text = questionsStrings[q];
                currentQuestionL.Text = "Pregunta " + (q + 1) + "/60";
            }
            else
                FinishQuiz();
        }

        private void FinishQuiz() {
            panel2.Visible = false;
            panel3.Location = p0;
            panel3.Visible = true;
            this.Size = panel3.Size;

            GetScore();
        }

        #endregion

        #region Like buttons and effects

        Timer tp = new Timer();
        Image currentImg = Properties.Resources.Neutral;
        float fade = 0;

        private void dislikeB_Click(object sender, EventArgs e)
        {
            NextQuestion(-1);
            tp.Enabled = true;
            fade = 100f;
            SetImg(Properties.Resources.Dislike);
        }

        private void neutralB_Click(object sender, EventArgs e)
        {
            NextQuestion(0);
            tp.Enabled = true;
            fade = 100f;
            SetImg(Properties.Resources.Neutral);
        }

        private void likeB_Click(object sender, EventArgs e)
        {
            NextQuestion(+1);
            SetImg(Properties.Resources.Like);
        }

        private void SetImg(Image img)
        {
            tp.Enabled = true;
            fade = 100f;
            currentImg = img;
        }

        void tp_Tick(object sender, EventArgs e)
        {
            if (fade > 0)
                fade--;
            else
                tp.Enabled = false;

            scorePB.Image = ImageTransparency.ChangeOpacity(currentImg, fade / 100);
        }

        #endregion

        #region Score

        private void GetScore() {
            int[] scores = new int[10];

            for (int i = 0; i < questions.Count; i++)
            {
                Question q = questions[i];
                string index = i.ToString();
                string lstChar = index[index.Length - 1].ToString();
                int ind = Int32.Parse(lstChar);
                scores[ind] += q.Score;
            }

            string bf = "...nada! ¡Quédate con tus padres salao";
            int bi = 0;

            for (int i = 0; i < 10; i++)
            {
                if (scores[i] > bi)
                {
                    bi = scores[i];
                    bf = fields[i];
                }

                var item = new ListViewItem(new[] { fields[i], scores[i].ToString() });
                scoresLV.Items.Add(item);
            }

            becomeL.Text = "¡Deberías hacerte " + bf.ToLower() + "!";
        }

        #endregion

        private void acceptB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkUpdatesB_Click(object sender, EventArgs e)
        {
            new UpdateChecker.UpdateChecker(System.Reflection.Assembly.GetExecutingAssembly().Location, "fup").Show();
        }

    }
    class ImageTransparency
    {
        public static Bitmap ChangeOpacity(Image img, float opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height); // Determining Width and Height of Source Image
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityvalue;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();   // Releasing all resource used by graphics 
            return bmp;
        }
    }
}