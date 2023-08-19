using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class frmCardGame : Form
    {
        string exe_path; 
        string pic_path;
        string pic_fname_dealer1;
        string pic_fname_dealer2;
        string pic_fname_dealer3;
        string pic_fname_user1;
        string pic_fname_user2;
        string pic_fname_user3;

        public frmCardGame()
        {
            InitializeComponent();
        }

        private void frmCardGame_Load(object sender, EventArgs e)
        {
            exe_path = Environment.CurrentDirectory;
            pic_path = exe_path + @"\pic\";
            pic_fname_dealer1 = pic_path + "back.jpg";
            picDealer1.Image = Image.FromFile(pic_fname_dealer1);
            picDealer2.Image = Image.FromFile(pic_fname_dealer1);
            picDealer3.Image = Image.FromFile(pic_fname_dealer1);
            picUser1.Image = Image.FromFile(pic_fname_dealer1);
            picUser2.Image = Image.FromFile(pic_fname_dealer1);
            picUser3.Image = Image.FromFile(pic_fname_dealer1);


            picDealer1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnShowCard_Click(object sender, EventArgs e)
        {
            string card_number_dealer1_str = "";
            string card_suit_dealer1_str = "";
            string card_number_dealer2_str = "";
            string card_suit_dealer2_str = "";
            string card_number_dealer3_str = "";
            string card_suit_dealer3_str = "";
            string card_number_user1_str = "";
            string card_suit_user1_str = "";
            string card_number_user2_str = "";
            string card_suit_user2_str = "";
            string card_number_user3_str = "";
            string card_suit_user3_str = "";
            Random random = new Random();
            int card_number_dealer1 = random.Next(1, 13);
            int card_suit_dealer1 = random.Next(1, 4);
            int card_number_dealer2 = random.Next(1, 13);
            int card_suit_dealer2 = random.Next(1, 4);
            int card_number_dealer3 = random.Next(1, 13);
            int card_suit_dealer3 = random.Next(1, 4);
            int card_number_user1 = random.Next(1, 13);
            int card_suit_user1 = random.Next(1, 4);
            int card_number_user2 = random.Next(1, 13);
            int card_suit_user2 = random.Next(1, 4);
            int card_number_user3 = random.Next(1, 13);
            int card_suit_user3 = random.Next(1, 4);

            card_number_dealer1_str = cardNo2Str(card_number_dealer1);
            card_suit_dealer1_str = cardSuit2Str(card_suit_dealer1);
            card_number_dealer2_str = cardNo2Str(card_number_dealer2);
            card_suit_dealer2_str = cardSuit2Str(card_suit_dealer2);
            card_number_dealer3_str = cardNo2Str(card_number_dealer3);
            card_suit_dealer3_str = cardSuit2Str(card_suit_dealer3);
            card_number_user1_str = cardNo2Str(card_number_user1);
            card_suit_user1_str = cardSuit2Str(card_suit_user1);
            card_number_user2_str = cardNo2Str(card_number_user2);
            card_suit_user2_str = cardSuit2Str(card_suit_user2);
            card_number_user3_str = cardNo2Str(card_number_user3);
            card_suit_user3_str = cardSuit2Str(card_suit_user3);

            string new_card_fname_dealer1 = card_number_dealer1_str + card_suit_dealer1_str;
            string new_card_fname_dealer2 = card_number_dealer2_str + card_suit_dealer2_str;
            string new_card_fname_dealer3 = card_number_dealer3_str + card_suit_dealer3_str;
            string new_card_fname_user1 = card_number_user1_str + card_suit_user1_str;
            string new_card_fname_user2 = card_number_user2_str + card_suit_user2_str;
            string new_card_fname_user3 = card_number_user3_str + card_suit_user3_str;
            pic_fname_dealer1 = pic_path + new_card_fname_dealer1;
            pic_fname_dealer2 = pic_path + new_card_fname_dealer2;
            pic_fname_dealer3= pic_path + new_card_fname_dealer3;
            pic_fname_user1 = pic_path + new_card_fname_user1;
            pic_fname_user2 = pic_path + new_card_fname_user2;
            pic_fname_user3 = pic_path + new_card_fname_user3;
            picDealer1 .Image = Image.FromFile(pic_fname_dealer1);
            picDealer2.Image = Image.FromFile(pic_fname_dealer2);
            picDealer3.Image = Image.FromFile(pic_fname_dealer3);
            picUser1.Image = Image.FromFile(pic_fname_user1);
            picUser2.Image = Image.FromFile(pic_fname_user2);
            picUser3.Image = Image.FromFile(pic_fname_user3);

            int totalDealer = 0;
            int totalUser = 0;
            if (card_number_dealer1>=10)
            {
                card_number_dealer1 = 10;
            }
            else if(card_number_dealer2>=10)
            {
                card_number_dealer2 = 10;
            }
            else if (card_number_dealer3 >= 10)
            {
                card_number_dealer3 = 10;
            }
            else if (card_number_user1 >= 10)
            {
                card_number_user1 = 10;
            }
            else if (card_number_user2 >= 10)
            {
                card_number_user2= 10;
            }
            else if (card_number_user3 >= 10)
            {
                card_number_user3 = 10;
            }

            totalDealer=card_number_dealer1+card_number_dealer2+ card_number_dealer3;
            totalUser=card_number_user1 + card_number_user2+card_number_user3;

            totalDealer = totalDealer % 10;
            totalUser = totalUser % 10;

            lblDealerMarks.Text = totalDealer.ToString();
            lblUserMarks.Text = totalUser.ToString();

            if(totalDealer>totalUser)
            {
                lblResult.Text = "Dealer!";
            }
            else if (totalDealer < totalUser)
            {
                lblResult.Text = "User!";
            }
            else
            {
                lblResult.Text = "Draw!";
            }

        }

        string cardNo2Str(int card_number)
        {
            string card_number_str = "";
            switch (card_number)
            {
                case 1: card_number_str = "ace"; break;
                case 11: card_number_str = "jack"; break;
                case 12: card_number_str = "queen"; break;
                case 13: card_number_str = "king"; break;
                default: card_number_str = card_number.ToString(); break;
            }
            return card_number_str;
        }
        string cardSuit2Str(int card_suit)
        {
            string card_suit_str = "";
            switch (card_suit)
            {
                case 1: card_suit_str = "_of_hearts.png"; break;
                case 2: card_suit_str = "_of_diamonds.png"; break;
                case 3: card_suit_str = "_of_spades.png"; break;
                case 4: card_suit_str = "_of_clubs.png"; break;
            }
            return card_suit_str;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
