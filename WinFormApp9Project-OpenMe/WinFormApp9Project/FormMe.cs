using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp9Project
{

    public partial class FormMe : Form
    {
        public static string AppPath = Application.StartupPath;


        slideManager manager = new slideManager();
        string displayedText = "";
        string fullText = "";
        int CharIndex = 0;
        public FormMe()
        {
            InitializeComponent();
        }
        void Form1_load(object sender, EventArgs e)
        {
            LoadAllSlides();
            ShowCurrentSlide();
        }
        void LoadAllSlides()
        {
            manager.AddSlide(new slideData
            {
                CharacterName = "boss",
                CharacterImagePath = @"Resources\ابو القعقاع.png",
                BackgroundImagePath = @"Resources\AlSooq.jpg",
                DialogText = "أخيرا وصلتَ الى قرطبة، حللت أهلا ووطئت سهلا، سمعت أنك لا تملك عمل لما لا تعمل في صيدليتي ",
                Type = slideType.Normal,
                developerTalk =  ""
            });
            manager.AddSlide(new slideData
            {
                CharacterName = "boss",
                CharacterImagePath = @"Resources\ابو القعقاع.png",
                BackgroundImagePath = @"Resources\AlSooq.jpg",
                DialogText = " إذهب الى يمين جامع قرطبة الصيدلية هناك، اهل قرطبة أناس طيبون ستجدهم بك مرحبين لكن الأمر لا يخلو من غريبي الأطوار لذلك حاول أن تساير الناس قدر الإمكان.",
                Type = slideType.Normal,
                developerTalk = ""
            });

            manager.AddSlide(new slideData
            {
                CharacterName = "me",
                CharacterImagePath = @"Resources\me.png",
                BackgroundImagePath = @"Resources\pharmacy.png",
                DialogText = "ها نحن ذا...",
                Type = slideType.Normal,
                developerTalk = ""
            });

            manager.AddSlide(new slideData
            {
                CharacterName = "malek",
                CharacterImagePath = @"Resources\malek.png",
                BackgroundImagePath = @"Resources\pharmacy1.png",
                DialogText = "مرحبا يا فتى كيف حالك، يبدو أنك جديد على هذه المنطقة",
                Type = slideType.Normal,
                developerTalk = ""
            });
            manager.AddSlide(new slideData
            {
                CharacterName = "me",
                CharacterImagePath = @"Resources\me.png",
                BackgroundImagePath = @"Resources\pharmacy1.png",
                DialogText = "اهلا وسهلا، نعم قدمت من دمشق ",
                Type = slideType.Normal,
                developerTalk = ""
            });
            manager.AddSlide(new slideData
            {
                CharacterName = "malek",
                CharacterImagePath = @"Resources\malek.png",
                BackgroundImagePath = @"Resources\pharmacy1.png",
                DialogText = "قرطبة ترحب بك، انظر الى هذه الراشيتا ",
                Type = slideType.Normal,
                developerTalk = ""
            });
            manager.AddSlide(new slideData
            {
                CharacterName = "me",
                CharacterImagePath = @"Resources\me.png",
                BackgroundImagePath = @"Resources\pharmacyRash1.png",
                DialogText = "...",
                Type = slideType.Normal,
                developerTalk = "قم بتشغيل الحاسب والبحث عن الأدوية المطلوبة(cetamol)(paracetamol)"
            });

            //_____________________________________________________________
            manager.AddSlide(new slideData
            {
                CharacterName = "me",
                CharacterImagePath = @"Resources\me.png",
                BackgroundImagePath = @"Resources\pharmacy.png",
                DialogText = "7 ",
                Type = slideType.Interactive
            });
            //_____________________________________________________________

            manager.AddSlide(new slideData
            {
                CharacterName = "me",
                CharacterImagePath = @"Resources\me.png",
                BackgroundImagePath = @"Resources\pharmacy1.png",
                DialogText = "حسنا، بالنسبة للدواء الأول هو موجود أما الثاني فلدينا بديل وأما الثالث فهو غير متوفر لدينا، هل تريد البديل؟ ",
                Type = slideType.Normal,
                developerTalk = ""
            });
            manager.AddSlide(new slideData
            {
                CharacterName = "malek",
                CharacterImagePath = @"Resources\malek.png",
                BackgroundImagePath = @"Resources\pharmacy1.png",
                DialogText = "اجل لابأس، أين أجد الدواء الأخير؟ ",
                Type = slideType.Normal,
                developerTalk = ""
            });

            manager.AddSlide(new slideData
            {
                CharacterName = "me",
                CharacterImagePath = @"Resources\me.png",
                BackgroundImagePath = @"Resources\pharmacy1.png",
                DialogText = "عند الخضرجي ",
                Type = slideType.Normal,
                developerTalk = ""
            });

            manager.AddSlide(new slideData
            {
                CharacterName = "malek",
                CharacterImagePath = @"Resources\malek.png",
                BackgroundImagePath = @"Resources\pharmacy1.png",
                DialogText = "حسنا ",
                Type = slideType.Normal,
                developerTalk = ""
            });


            manager.AddSlide(new slideData
            {
                CharacterName = "me",
                CharacterImagePath = @"Resources\me.png",
                BackgroundImagePath = @"Resources\pharmacy1.png",
                DialogText = "ها أنت ذا، مئتان وسبعون ",
                Type = slideType.Normal,
                developerTalk = ""
            });

            //_____________________________________________________________
            manager.AddSlide(new slideData
            {
                CharacterName = "me",
                CharacterImagePath = @"Resources\me.png",
                BackgroundImagePath = @"Resources\pharmacy.png",
                DialogText = "ها أنت ذا، مئتان وسبعون ",
                Type = slideType.BlackScreen
            });
            //_____________________________________________________________

            manager.AddSlide(new slideData
            {
                CharacterName = "old woman",
                CharacterImagePath = @"Resources\oldwoman.png",
                BackgroundImagePath = @"Resources\pharmacy2.png",
                DialogText = "كيف حالك يا بني أريد أوغمنتين ",
                Type = slideType.Normal,
                developerTalk = ""
            });

            //_____________________________________________________________
            manager.AddSlide(new slideData
            {
                CharacterName = "me",
                CharacterImagePath = @"Resources\me.png",
                BackgroundImagePath = @"Resources\pharmacy.png",
                DialogText = "7 ",
                Type = slideType.Interactive,
                developerTalk = ""
            });
            //_____________________________________________________________

            manager.AddSlide(new slideData
            {
                CharacterName = "me",
                CharacterImagePath = @"Resources\me.png",
                BackgroundImagePath = @"Resources\pharmacy2.png",
                DialogText = "لدي بديل له هل تريدين",
                Type = slideType.Normal,
                developerTalk = ""
            });

            manager.AddSlide(new slideData
            {
                CharacterName = "old woman",
                CharacterImagePath = @"Resources\oldwoman.png",
                BackgroundImagePath = @"Resources\pharmacy2.png",
                DialogText = "أبقه عندك... مجموعة لصوص ",
                Type = slideType.Normal,
                developerTalk = ""
            });

            manager.AddSlide(new slideData
            {
                CharacterName = "me",
                CharacterImagePath = @"Resources\me.png",
                BackgroundImagePath = @"Resources\pharmacy2.png",
                DialogText = "{عجوز خرف}",
                Type = slideType.Normal,
                developerTalk = ""
            });

            //__________________________________________________________
            manager.AddSlide(new slideData
            {
                CharacterName = "me",
                CharacterImagePath = @"Resources\me.png",
                BackgroundImagePath = @"Resources\pharmacy2.png",
                DialogText = "",
                Type = slideType.BlackScreen,
                developerTalk = ""
            });
            //___________________________________________________________

            manager.AddSlide(new slideData
            {
                CharacterName = "me",
                CharacterImagePath = @"Resources\me.png",
                BackgroundImagePath = @"Resources\pharmacy3.png",
                DialogText = "...",
                Type = slideType.Normal,
                developerTalk = ""
            });

            manager.AddSlide(new slideData
            {
                CharacterName = "samer",
                CharacterImagePath = @"Resources\samer.png",
                BackgroundImagePath = @"Resources\pharmacy3.png",
                DialogText = "كبف الحال؟ أريد دواء يجعلني أشبه هذا",
                Type = slideType.Normal,
                developerTalk = ""
            });

            manager.AddSlide(new slideData
            {
                CharacterName = "me",
                CharacterImagePath = @"Resources\me.png",
                BackgroundImagePath = @"Resources\sigma.png",
                DialogText = "                             أحا",
                Type = slideType.Normal,
                developerTalk = ""
            });

            manager.AddSlide(new slideData
            {
                CharacterName = "me",
                CharacterImagePath = @"Resources\me.png",
                BackgroundImagePath = @"Resources\pharmacy3.png",
                DialogText = "لا وجود لدواء كهذا، حالتك ميئوس منها يا صديق",
                Type = slideType.Normal,
                developerTalk = ""
            });

            manager.AddSlide(new slideData
            {
                CharacterName = "samer",
                CharacterImagePath = @"Resources\samer.png",
                BackgroundImagePath = @"Resources\pharmacy3.png",
                DialogText = "حقا حسنا",
                Type = slideType.Normal,
                developerTalk = ""
            });

        }

        void ShowCurrentSlide()
        {
            var slide = manager.GetCurrentSlide();
            if (slide.CharacterName == "me")
            {
                picPerson.Location = new Point(20, 645);
                picPerson.Size = new Size(420, 420);
            }
            else
            {
                picPerson.Location = new Point(1540, 720);
                picPerson.Size = new Size(350, 350);
            }
            if (slide.Type == slideType.Normal)
            {
                picPerson.Visible = true;
                pnlDialog.Visible = true;

                picBackground.Image = Image.FromFile(slide.BackgroundImagePath);
                picPerson.Image = Image.FromFile(slide.CharacterImagePath);

                lblName.Text = slide.CharacterName;

                fullText = slide.DialogText;
                displayedText = "";
                CharIndex = 0;
                lblText.Text = "";
                timertext.Start();
                lbldeveloper.Text = slide.developerTalk;
            }
            else if (slide.Type == slideType.Interactive)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
                manager.GoToNext();
                ShowCurrentSlide();
            }
            
                 
        }
            
       
        private void FormMe_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllSlides();
                ShowCurrentSlide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            picPerson.BackColor = Color.Transparent;
            picPerson.Parent = picBackground;
            
            butDisctop.BackColor = Color.Transparent;
            butDisctop.Parent = picBackground;
            butDisctop.FlatStyle = FlatStyle.Flat;
            butDisctop.FlatAppearance.BorderSize = 0;


            lbldeveloper.BackColor = Color.Transparent;
            lbldeveloper.Parent = picBackground;
            lbldeveloper.FlatStyle = FlatStyle.Flat;
        }

        private void pnlDialog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timertext_Tick(object sender, EventArgs e)
        {
            if (CharIndex < fullText.Length)
            {
                displayedText += fullText[CharIndex++];
                lblText.Text = displayedText;
            }
            else
                timertext.Stop();
        }

        private void butnext_Click(object sender, EventArgs e)
        {
            bool hasNext = manager.GoToNext();
            if (hasNext)
                ShowCurrentSlide();
        }

        private void picPerson_Click(object sender, EventArgs e)
        {

        }

        private void butback_Click(object sender, EventArgs e)
        {
            bool hasBack = manager.GoToBack();
            if (hasBack)
                ShowCurrentSlide();
        }

        private void butDisctop_Click(object sender, EventArgs e)
        {
            Disctop dis1 = new Disctop();
            dis1.Show();
        }
    }
}
