using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


         public int r1, r2, r3, r4, r5, r6, r7, r8, r9 ;
        public int i=1,ver1=0,ver2=0,ver3=0,ver4=0;
        public int contador = 0, contador1 = 0, contador2 = 0;



        public void limpar()
        {
            bt_1.Visible = true;
            bt_2.Visible = true;
            bt_3.Visible = true;
            bt_4.Visible = true;
            bt_5.Visible = true;
            bt_6.Visible = true;
            bt_7.Visible = true;
            bt_8.Visible = true;
            bt_9.Visible = true;
            r1 = 0;
            r2 = 0;
            r3 = 0;
            r4 = 0;
            r5 = 0;
            r6 = 0;
            r7 = 0;
            r8 = 0;
            r9 = 0;

        }

           public void fechar()
        {
            i = 1;
        }
        public void pontuacao()
        {
            contador = contador + 1;
            label6.Text =Convert.ToString(contador);
        }
        public void pontuacao1()
        {
            contador1 = contador1 + 1;
            label7.Text = Convert.ToString(contador1);
        }
        public void velha()
        {
            contador2 = contador2 + 1;
            label8.Text = Convert.ToString(contador2);

        }

         public void labe()
        {
            label2.Visible = true;
            label1.Visible = false;
        }
        public void labe1()
        {
            label2.Visible = false;
            label1.Visible = true;
        }
        public void labecorrecao()
        {
            label1.Visible = true;
            label2.Visible = false;
        }


        public void i1botao1()
        {
                 bt_5.Visible = false;
                 r5 = 15;
                 pb_5.Image = Properties.Resources.o;
                 i = i + 1;
                 labe1();
                 verificar();
         }

        public void i1botao2()
    {
                 bt_5.Visible = false;
                 r5 = 15;
                 pb_5.Image = Properties.Resources.o;
                 i = i + 1;
                 labe1();
                 verificar();

    }

        public void i1botao3()
        {
            bt_5.Visible = false;
            r5 = 15;
            pb_5.Image = Properties.Resources.o;
            i = i + 1;
            labe1();
            verificar();

        }

        public void i1botao4()
        {
            bt_5.Visible = false;
            r5 = 15;
            pb_5.Image = Properties.Resources.o;
            i = i + 1;
            labe1();
            verificar();

        }
        public void i1botao5()
        {
            bt_3.Visible = false;
            r3 = 13;
            pb_3.Image = Properties.Resources.o;
            i = i + 1;
            labe1();
            verificar();
        }
        public void i1botao6()
        {
            bt_5.Visible = false;
            r5 = 15;
            pb_5.Image = Properties.Resources.o;
            i = i + 1;
            labe1();
            verificar();
        }
        public void i1botao7()
        {
            bt_5.Visible = false;
            r5 = 15;
            pb_5.Image = Properties.Resources.o;
            i = i + 1;
            labe1();
            verificar();
        }

        public void i1botao8()
        {
            bt_5.Visible = false;
            r5 = 15;
            pb_5.Image = Properties.Resources.o;
            i = i + 1;
            labe1();
            verificar();

        }

        public void i1botao9()
        {
            bt_5.Visible = false;
            r5 = 15;
            pb_5.Image = Properties.Resources.o;
            i = i + 1;
            labe1();
            verificar();
        }

        public void i3botao1() 
        {
            if (ver1==2) {
            bt_3.Visible = false;
            r3 = 13;
            pb_3.Image = Properties.Resources.o;
            i = i + 1;
            labe1();
            verificar();

            }

            if (ver1 == 3)
            {
                bt_2.Visible = false;
                r2 = 12;
                pb_2.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();


            }

            if (ver1 == 4)
            {
                bt_7.Visible = false;
                r7 = 17;
                pb_7.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();

            }

            if (ver1 == 5)
            {
                bt_9.Visible = false;
                r9 = 19;
                pb_9.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();


            }

            if (ver1 == 6)
            {
                bt_3.Visible = false;
                r3 = 13;
                pb_3.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();
            }


            if (ver1 == 7)
            {
                bt_4.Visible = false;
                r4 = 14;
                pb_4.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();
            }

            if (ver1 == 8)
            {
                bt_7.Visible = false;
                r7 = 17;
                pb_7.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();
            }

            if (ver1 == 9)
            {
                bt_6.Visible = false;
                r6 = 16;
                pb_6.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();
            }



        }

        public void i3botao2() 
        {

            if (ver1 == 1)
            {
                bt_3.Visible = false;
                r3 = 13;
                pb_3.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();

            }

            if (ver1 == 3)
            {
                bt_1.Visible = false;
                r1 = 11;
                pb_1.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();


            }


            if (ver1 == 4)
            {
                bt_1.Visible = false;
                r1 = 11;
                pb_1.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();


            }

            if (ver1 == 5)
            {
                bt_8.Visible = false;
                r8 = 18;
                pb_8.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();


            }

            if (ver1 == 6)
            {
                bt_3.Visible = false;
                r3 = 13;
                pb_3.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();
            }


            if (ver1 == 7)
            {
                bt_4.Visible = false;
                r4 = 14;
                pb_4.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();
            }

            if (ver1 == 8)
            {
                bt_1.Visible = false;
                r1 = 11;
                pb_1.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();
            }

            if (ver1 == 9)
            {
                bt_3.Visible = false;
                r3 = 13;
                pb_3.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();
            }
            
        }

      public void  i3botao3(){

          if (ver1 == 1)
          {
              bt_2.Visible = false;
              r2 = 12;
              pb_2.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 2)
          {
              bt_1.Visible = false;
              r1 = 11;
              pb_1.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();


          }

        

          if (ver1 == 4)
          {
              bt_1.Visible = false;
              r1 = 11;
              pb_1.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 6)
          {
              bt_9.Visible = false;
              r9 = 19;
              pb_9.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 7)
          {
              bt_6.Visible = false;
              r6 = 16;
              pb_6.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 8)
          {
              bt_6.Visible = false;
              r6 = 16;
              pb_6.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 9)
          {
              bt_6.Visible = false;
              r6 = 16;
              pb_6.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }
            


      }

      public void   i3botao4(){

          if (ver1 == 1)
          {
              bt_7.Visible = false;
              r7 = 17;
              pb_7.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 2)
          {
              bt_1.Visible = false;
              r1 = 11;
              pb_1.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();


          }



          if (ver1 == 3)
          {
              bt_1.Visible = false;
              r1 = 11;
              pb_1.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 5)
          {
              bt_6.Visible = false;
              r6 = 16;
              pb_6.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 6)
          {
              bt_2.Visible = false;
              r2 = 12;
              pb_2.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 7)
          {
              bt_1.Visible = false;
              r1 = 11;
              pb_1.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 8)
          {
              bt_7.Visible = false;
              r7 = 17;
              pb_7.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 9)
          {
              bt_7.Visible = false;
              r7 = 17;
              pb_7.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }
            

      
      
      }

      public void   i3botao5(){
      
      }

      public void   i3botao6()
      
      {

          
      

          if (ver1 == 1)
          {
              bt_3.Visible = false;
              r3 = 13;
              pb_3.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 2)
          {
              bt_3.Visible = false;
              r3 = 13;
              pb_3.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();


          }



          if (ver1 == 3)
          {
              bt_9.Visible = false;
              r9 = 19;
              pb_9.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 4)
          {
              bt_3.Visible = false;
              r3 = 13;
              pb_3.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 5)
          {
              bt_4.Visible = false;
              r4 = 14;
              pb_4.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }


          if (ver1 == 7)
          {
              bt_9.Visible = false;
              r9 = 19;
              pb_9.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 8)
          {
              bt_9.Visible = false;
              r9 = 19;
              pb_9.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 9)
          {
              bt_3.Visible = false;
              r3 = 13;
              pb_3.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }
            
      
      
      }

      public void   i3botao7()
      
      {


          if (ver1 == 1)
          {
              bt_4.Visible = false;
              r4 = 14;
              pb_4.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 2)
          {
              bt_1.Visible = false;
              r1 = 11;
              pb_1.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();


          }



          if (ver1 == 3)
          {
              bt_4.Visible = false;
              r4 = 14;
              pb_4.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 4)
          {
              bt_1.Visible = false;
              r1 = 11;
              pb_1.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 5)
          {
              bt_9.Visible = false;
              r9 = 19;
              pb_9.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }


          if (ver1 == 6)
          {
              bt_9.Visible = false;
              r9 = 19;
              pb_9.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 8)
          {
              bt_9.Visible = false;
              r9 = 19;
              pb_9.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 9)
          {
              bt_8.Visible = false;
              r8 = 18;
              pb_8.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }
      
      
      }

      public void   i3botao8()
      
      {


          if (ver1 == 1)
          {
              bt_7.Visible = false;
              r7 = 17;
              pb_7.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 2)
          {
              bt_4.Visible = false;
              r4 = 14;
              pb_4.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();


          }



          if (ver1 == 3)
          {
              bt_9.Visible = false;
              r9 = 19;
              pb_9.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 4)
          {
              bt_7.Visible = false;
              r7 = 17;
              pb_7.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 5)
          {
              bt_2.Visible = false;
              r2 = 12;
              pb_2.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }


          if (ver1 == 6)
          {
              bt_9.Visible = false;
              r9 = 19;
              pb_9.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 7)
          {
              bt_9.Visible = false;
              r9 = 19;
              pb_9.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 9)
          {
              bt_7.Visible = false;
              r7 = 17;
              pb_7.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }
      }

      public void i3botao9() 
      
      {


          if (ver1 == 1)
          {
              bt_6.Visible = false;
              r6 = 16;
              pb_6.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 2)
          {
              bt_3.Visible = false;
              r3 = 13;
              pb_3.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();


          }



          if (ver1 == 3)
          {
              bt_6.Visible = false;
              r6 = 16;
              pb_6.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 4)
          {
              bt_3.Visible = false;
              r3 = 13;
              pb_3.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 5)
          {
              bt_1.Visible = false;
              r1 = 11;
              pb_1.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 6)
          {
              bt_3.Visible = false;
              r3 = 13;
              pb_3.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 7)
          {
              bt_8.Visible = false;
              r8 = 18;
              pb_8.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

          if (ver1 == 8)
          {
              bt_7.Visible = false;
              r7 = 17;
              pb_7.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();
          }

         
      
      }


      public void i5botao1() 
      
      {

          if (ver1 == 2 && ver2 == 6)
          {
              bt_7.Visible = false;
              r7 = 17;
              pb_7.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 2 && ver2 == 8)
          {
              bt_6.Visible = false;
              r6 = 16;
              pb_6.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          

          if (ver1 == 2 && ver2 == 9)
          {
              bt_7.Visible = false;
              r7 = 17;
              pb_7.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }



          if (ver1 == 3 && ver2 == 6)
          {
              bt_2.Visible = false;
              r2 = 12;
              pb_2.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 3 && ver2 == 7)
          {
              bt_6.Visible = false;
              r6 = 16;
              pb_6.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }



          if (ver1 == 3 && ver2 == 8)
          {
              bt_2.Visible = false;
              r2 = 12;
              pb_2.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }


          if (ver1 == 3 && ver2 == 9)
          {
              bt_4.Visible = false;
              r4 = 14;
              pb_4.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 4 && ver2 == 6)
          {
              bt_7.Visible = false;
              r7 = 17;
              pb_7.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 4 && ver2 == 8)
          {
              bt_3.Visible = false;
              r3 = 13;
              pb_3.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 4 && ver2 == 9)
          {
              bt_7.Visible = false;
              r7 = 17;
              pb_7.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 5 && ver2 == 2)
          {
              bt_9.Visible = false;
              r9 = 19;
              pb_9.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 5 && ver2 == 4)
          {
              bt_9.Visible = false;
              r9 = 19;
              pb_9.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 5 && ver2 == 6)
          {
              bt_9.Visible = false;
              r9 = 19;
              pb_9.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 5 && ver2 == 7)
          {
              bt_6.Visible = false;
              r6 = 16;
              pb_6.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 5 && ver2 == 8)
          {
              bt_9.Visible = false;
              r9 = 19;
              pb_9.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 6 && ver2 == 2)
          {
              bt_7.Visible = false;
              r7 = 17;
              pb_7.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 6 && ver2 == 3)
          {
              bt_2.Visible = false;
              r2 = 12;
              pb_2.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 6 && ver2 == 4)
          {
              bt_8.Visible = false;
              r8 = 18;
              pb_8.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 6 && ver2 == 7)
          {
              bt_4.Visible = false;
              r4 = 14;
              pb_4.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 6 && ver2 == 8)
          {
              bt_7.Visible = false;
              r7 = 17;
              pb_7.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 6 && ver2 == 9)
          {
              bt_7.Visible = false;
              r7 = 17;
              pb_7.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }


          if (ver1 == 7 && ver2 == 2)
          {
              bt_6.Visible = false;
              r6 = 16;
              pb_6.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 7 && ver2 == 3)
          {
              bt_4.Visible = false;
              r4 = 14;
              pb_4.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 7 && ver2 == 6)
          {
              bt_4.Visible = false;
              r4 = 14;
              pb_4.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }


          if (ver1 == 7 && ver2 == 8)
          {
              bt_4.Visible = false;
              r4 = 14;
              pb_4.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 7 && ver2 == 9)
          {
              bt_2.Visible = false;
              r2 = 12;
              pb_2.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }


          if (ver1 == 8 && ver2 == 3)
          {
              bt_4.Visible = false;
              r4 = 14;
              pb_4.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }


          if (ver1 == 8 && ver2 == 4)
          {
              bt_3.Visible = false;
              r3 = 13;
              pb_3.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }


          if (ver1 == 8 && ver2 == 6)
          {
              bt_7.Visible = false;
              r7 = 17;
              pb_7.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }


          if (ver1 == 8 && ver2 == 3)
          {
              bt_4.Visible = false;
              r4 = 14;
              pb_4.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }


          if (ver1 == 8 && ver2 == 7)
          {
              bt_4.Visible = false;
              r4 = 14;
              pb_4.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }


          if (ver1 == 8 && ver2 == 9)
          {
              bt_3.Visible = false;
              r3 = 13;
              pb_3.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }




          if (ver1 == 9 && ver2 == 2)
          {
              bt_7.Visible = false;
              r7 = 17;
              pb_7.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }

          if (ver1 == 9 && ver2 == 3)
          {
              bt_4.Visible = false;
              r4 = 14;
              pb_4.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();

          }


          if (ver1 == 9 && ver2 == 4)
          {
              bt_3.Visible = false;
              r3 = 13;
              pb_3.Image = Properties.Resources.o;
              i = i + 1;
              labe1();
              verificar();


          }













      }



         public void verificar()
        {
            if (r1 == 1 && r2 == 2 && r3 == 3)
            {
                MessageBox.Show("Jogador Um é o vencedor");
                pontuacao();
                limpar();
                labecorrecao();
                fechar();
                
               
            }
            if (r4 == 4 && r5 == 5 && r6 == 6)
            {
                MessageBox.Show("Jogador Um é o vencedor");
                pontuacao();
                limpar();
                labecorrecao();
                fechar();

            }
            if (r7 == 7 && r8 == 8 && r9 == 9)
            {
                MessageBox.Show("Jogador Um é o vencedor");
                pontuacao();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r1 == 1 && r4 == 4 && r7 == 7)
            {
                MessageBox.Show("Jogador Um é o vencedor");
                pontuacao();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r2 == 2 && r5 == 5 && r8 == 8)
            {
                MessageBox.Show("Jogador Um é o vencedor");
                pontuacao();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r3 == 3 && r6 == 6 && r9 == 9)
            {
                MessageBox.Show("Jogador Um é o vencedor");
                pontuacao();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r1 == 1 && r5 == 5 && r9 == 9)
            {
                MessageBox.Show("Jogador Um é o vencedor");
                pontuacao();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r3 == 3 && r5 == 5 && r7 == 7)
            {
                MessageBox.Show("Jogador Um é o vencedor");
                pontuacao();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r1 == 11 && r2 == 12 && r3 == 13)
            {
                MessageBox.Show("Jogador Dois é o vencedor");
                pontuacao1();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r4 == 14 && r5 == 15 && r6 == 16)
            {
                MessageBox.Show("Jogador Dois é o vencedor");
                pontuacao1();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r7 == 17 && r8 == 18 && r9 == 19)
            {
                MessageBox.Show("Jogador Dois é o vencedor");
                pontuacao1();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r1 == 11 && r4 == 14 && r7 == 17)
            {
                MessageBox.Show("Jogador Dois é o vencedor");
                pontuacao1();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r2 == 12 && r5 == 15 && r8 == 18)
            {
                MessageBox.Show("Jogador Dois é o vencedor");
                pontuacao1();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r3 == 13 && r6 == 16 && r9 == 19)
            {
                MessageBox.Show("Jogador Dois é o vencedor");
                pontuacao1();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r1 == 11 && r5 == 15 && r9 == 19)
            {
                MessageBox.Show("Jogador Dois é o vencedor");
                pontuacao1();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r3 == 13 && r5 == 15 && r7 == 17)
            {
                MessageBox.Show("Jogador Dois é o vencedor");
                pontuacao1();
                limpar();
                labecorrecao();
                fechar();
            }
            if (i == 10)
            {
                MessageBox.Show("Deu velha");
                velha();
                limpar();
                labecorrecao();
                fechar();
            }
         }



         private void bt_1_Click(object sender, EventArgs e)
         {
             bt_1.Visible = false;

             if (i == 1)
                 ver1 = 1;
             if (i == 3)
                 ver2 = 1;
             if (i == 5)
                 ver3 = 1;
             if (i == 7)
                 ver3 = 1;

             if (i % 2 == 1)
             {   
                 r1 = 1;
                 pb_1.Image = Properties.Resources.x__1_;
                 
                 label2.Visible = true;
                 label1.Visible = false;
                 verificar();


                 if (i == 1)
                     i1botao1();

                 if (i == 3)
                     i3botao1();

                 if (i == 5)
                     i5botao1();





            
                   

                    
                 
                 i = i + 1;
                        
             }
          
         }

         private void bt_2_Click(object sender, EventArgs e)
         {

             if (i == 1)
                 ver1 = 2;
             if (i == 3)
                 ver2 = 2;
             if (i == 5)
                 ver3 = 2;
             if (i == 7)
                 ver4 = 2;


                 bt_2.Visible = false;
            
                 
                 r2 = 2;
                 pb_2.Image = Properties.Resources.x__1_;

                 labe();
                 verificar();

                 if (i == 1)
                     i1botao2();

                 if (i == 3)
                     i3botao2();


                 i = i + 1;
             
         }

         private void bt_3_Click(object sender, EventArgs e)
         {

             if (i == 1)
                 ver1 = 3;
             if (i == 3)
                 ver2 = 3;
             if (i == 5)
                 ver3 = 3;
             if (i == 7)
                 ver4 = 3;

                bt_3.Visible = false;
            
                 
                 r3 = 3;
                 pb_3.Image = Properties.Resources.x__1_;

                 labe();
                 verificar();

                 if (i==1)
                     i1botao3();

                 if (i==3)
                     i3botao3();
                
                     


                 
                 i = i + 1;
             }
         

         private void bt_4_Click(object sender, EventArgs e)
         {

             if (i == 1)
                 ver1 = 4;
             if (i == 3)
                 ver2 = 4;
             if (i == 5)
                 ver3 = 4;
             if (i == 7)
                 ver3 = 4;

             bt_4.Visible = false;
             
                 
                 r4 = 4;
                 pb_4.Image = Properties.Resources.x__1_;
                 
                 labe();
                 verificar();


                 if (i == 1)
                     i1botao4();

                 if (i == 3)
                     i3botao4();
                 i = i + 1;
            
             
         }

         private void bt_5_Click(object sender, EventArgs e)
         {
             if (i == 1)
                 ver1 = 5;
             if (i == 3)
                 ver2 = 5;
             if (i == 5)
                 ver3 = 5;
             if (i == 7)
                 ver3 = 5;

             bt_5.Visible = false;
             

             
                 
                 r5 = 5;
                 pb_5.Image = Properties.Resources.x__1_;
                 
                 labe();
                 verificar();


                 if (i == 1)
                     i1botao5();

                 if (i == 3)
                     i3botao5();

                 i = i + 1;
             
         }

         private void bt_6_Click(object sender, EventArgs e)
         {
              if (i == 1)
                 ver1 = 6;
             if (i == 3)
                 ver2 = 6;
             if (i == 5)
                 ver3 = 6;
             if (i == 7)
                 ver3 = 6;

             bt_6.Visible = false;
             

                
                 r6 = 6;
                 pb_6.Image = Properties.Resources.x__1_;
                 
                 labe();
                 verificar();

                 if (i == 1)
                     i1botao6();

                 if (i == 3)
                     i3botao6();

                 i = i + 1;
             
             
         }

         private void bt_7_Click(object sender, EventArgs e)
         {

              if (i == 1)
                 ver1 = 7;
             if (i == 3)
                 ver2 = 7;
             if (i == 5)
                 ver3 = 7;
             if (i == 7)
                 ver3 = 7;

             bt_7.Visible = false;
           

                 
                 r7 = 7;
                 pb_7.Image = Properties.Resources.x__1_;
                 
                 labe();
                 verificar();

                 if (i == 1)
                     i1botao7();

                 if (i == 3)
                     i3botao7();

                 i = i + 1;
             
         }

         private void bt_8_Click(object sender, EventArgs e)
         {

              if (i == 1)
                 ver1 = 8;
             if (i == 3)
                 ver2 = 8;
             if (i == 5)
                 ver3 = 8;
             if (i == 7)
                 ver3 = 8;

             bt_8.Visible = false;
         
                
                 r8 = 8;
                 pb_8.Image = Properties.Resources.x__1_;
                 
                 labe();
                 verificar();

                 if (i == 1)
                     i1botao8();

                 if (i == 3)
                     i3botao8();

                 i = i + 1;
             
         }

         private void bt_9_Click(object sender, EventArgs e)
         {

              if (i == 1)
                 ver1 = 9;
             if (i == 3)
                 ver2 = 9;
             if (i == 5)
                 ver3 = 9;
             if (i == 7)
                 ver3 = 9;

             bt_9.Visible = false;
            
                
                 r9 = 9;
                 pb_9.Image = Properties.Resources.x__1_;
                 
                 labe();
                 verificar();


                 if (i == 1)
                     i1botao9();

                 if (i == 3)
                     i3botao9();

                 i = i + 1;
             
         }

         private void button1_Click(object sender, EventArgs e)
         {
             this.Close();
         }

       
    }
}
