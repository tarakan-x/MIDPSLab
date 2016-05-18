//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop
#include <math.h>

#include "Unit2.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "CSPIN"
#pragma resource "*.dfm"
TForm2 *Form2;
          double TotalTime=0;
int nr = 0;
        char s[10];

void iValoare(){
        itoa(nr,s,10);
        Form2->Edit1->Text=s;
        }
//---------------------------------------------------------------------------
__fastcall TForm2::TForm2(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm2::Button1Click(TObject *Sender)
{
        ++nr;
        iValoare();
}
//---------------------------------------------------------------------------
void __fastcall TForm2::Button2Click(TObject *Sender)
{
   --nr;
   iValoare();
}
//---------------------------------------------------------------------------
void __fastcall TForm2::Button3Click(TObject *Sender)
{
       Close();        
}
//---------------------------------------------------------------------------
void __fastcall TForm2::Button4Click(TObject *Sender)
{
Label1->Visible=true;
}
//---------------------------------------------------------------------------
void __fastcall TForm2::Button5Click(TObject *Sender)
{
Label1->Visible=false;
}
 //---------------------------------------------------------------------------
void __fastcall TForm2::RadioButton1Click(TObject *Sender)
{
Label1->Font->Name="Arial";
}
//---------------------------------------------------------------------------

void __fastcall TForm2::RadioButton2Click(TObject *Sender)
{
     Label1->Font->Name="Calibri";
}
//---------------------------------------------------------------------------

void __fastcall TForm2::RadioButton3Click(TObject *Sender)
{
Label1->Font->Name="Cambria";
}
//---------------------------------------------------------------------------

void __fastcall TForm2::RadioButton4Click(TObject *Sender)
{
Label1->Font->Name="@Dotum";
}
//---------------------------------------------------------------------------

void __fastcall TForm2::CheckBox1Click(TObject *Sender)
{
if((Label1->Font->Style == Label1->Font->Style<<fsBold)==true)
   {
   Label1->Font->Style = Label1->Font->Style.Clear();
   }
   else
   {
     Label1->Font->Style = Label1->Font->Style<<fsBold;
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm2::CheckBox2Click(TObject *Sender)
{
if((Label1->Font->Style == Label1->Font->Style<<fsItalic)==true)
   {
   Label1->Font->Style = Label1->Font->Style.Clear();
   }
   else
   {
     Label1->Font->Style = Label1->Font->Style<<fsItalic;
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm2::RadioButton5Click(TObject *Sender)
{

Label1->Font->Size = 20;
}
//---------------------------------------------------------------------------

void __fastcall TForm2::RadioButton6Click(TObject *Sender)
{
Label1->Font->Size = 25;
}
//---------------------------------------------------------------------------

void __fastcall TForm2::RadioButton7Click(TObject *Sender)
{
Label1->Font->Size = 14;
}
//---------------------------------------------------------------------------


void __fastcall TForm2::Button6Click(TObject *Sender)
{
int Time=0;
if(Timer1->Enabled==true)
{Timer1->Enabled=false;}
else
{Timer1->Enabled=true;}        
}
//---------------------------------------------------------------------------


void __fastcall TForm2::Button7Click(TObject *Sender)
{
   Timer1->Enabled=false;
   Label2->Caption="Timer";
   TotalTime=0;
}
//---------------------------------------------------------------------------

void __fastcall TForm2::Timer1Timer(TObject *Sender)
{
       TotalTime +=0.001*Timer1->Interval;
       Label2->Caption=TotalTime;
}
//---------------------------------------------------------------------------





void __fastcall TForm2::Button8Click(TObject *Sender)
{
         PaintBox1->Canvas->MoveTo(15,35);
PaintBox1->Canvas->LineTo(15,60);
PaintBox1->Canvas->LineTo(60,60);
PaintBox1->Canvas->LineTo(60,40);
PaintBox1->Canvas->MoveTo(60,60);
PaintBox1->Canvas->LineTo(60,80);
PaintBox1->Canvas->LineTo(85,80);
PaintBox1->Canvas->LineTo(85,70);
PaintBox1->Canvas->LineTo(100,70);
PaintBox1->Canvas->LineTo(100,90);
PaintBox1->Canvas->LineTo(85,90);
PaintBox1->Canvas->LineTo(85,70);
PaintBox1->Canvas->MoveTo(100,80);
PaintBox1->Canvas->LineTo(130,80);
PaintBox1->Canvas->MoveTo(60,40);
PaintBox1->Canvas->LineTo(85,40);
PaintBox1->Canvas->LineTo(85,30);
PaintBox1->Canvas->LineTo(100,30);
PaintBox1->Canvas->LineTo(100,50);
PaintBox1->Canvas->LineTo(85,50);
PaintBox1->Canvas->LineTo(85,30);
PaintBox1->Canvas->MoveTo(100,40);
PaintBox1->Canvas->LineTo(130,40);
PaintBox1->Canvas->LineTo(130,60);
PaintBox1->Canvas->MoveTo(130,80);
PaintBox1->Canvas->LineTo(130,60);
PaintBox1->Canvas->LineTo(150,60);
PaintBox1->Canvas->LineTo(150,50);
PaintBox1->Canvas->LineTo(170,50);
PaintBox1->Canvas->LineTo(170,70);
PaintBox1->Canvas->LineTo(150,70);
PaintBox1->Canvas->LineTo(150,60);
PaintBox1->Canvas->MoveTo(170,60);
PaintBox1->Canvas->LineTo(200,60);
}
//---------------------------------------------------------------------------

void __fastcall TForm2::Button9Click(TObject *Sender)
{
 PaintBox2->Canvas->MoveTo(10,50);
PaintBox2->Canvas->LineTo(10,40);
PaintBox2->Canvas->LineTo(50,40);
PaintBox2->Canvas->LineTo(50,50);
PaintBox2->Canvas->MoveTo(50,40);
PaintBox2->Canvas->LineTo(50,30);
PaintBox2->Canvas->LineTo(90,30);
PaintBox2->Canvas->LineTo(90,50);
PaintBox2->Canvas->MoveTo(90,30);
PaintBox2->Canvas->LineTo(90,20);
PaintBox2->Canvas->LineTo(130,20);
PaintBox2->Canvas->LineTo(130,50);
PaintBox2->Canvas->MoveTo(130,20);
PaintBox2->Canvas->LineTo(130,10);
PaintBox2->Canvas->LineTo(170,10);
PaintBox2->Canvas->LineTo(170,50);
PaintBox2->Canvas->MoveTo(170,10);
PaintBox2->Canvas->LineTo(170,0);
PaintBox2->Canvas->LineTo(220,0);
PaintBox2->Canvas->LineTo(220,50);
}
//---------------------------------------------------------------------------

void __fastcall TForm2::Button10Click(TObject *Sender)
{
PaintBox1->Repaint();
PaintBox2->Repaint();
}
//---------------------------------------------------------------------------


void __fastcall TForm2::Timer2Timer(TObject *Sender)
{
     Panel2->Caption=Time();
}
//---------------------------------------------------------------------------


