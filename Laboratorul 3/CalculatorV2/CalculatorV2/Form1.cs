﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace CalculatorV2
{
     public partial class Form1 : Form
     {

          Double resultVal = 0;
          String opPerformed = "";
          bool isopPerformed = false;
          bool s = true;


          public Form1()
          {
               InitializeComponent();
               Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
          }


          private void button1_Click(object sender, EventArgs e)
          {
               if ((textBox1_Result.Text == "0") || (isopPerformed))
                   textBox1_Result.Clear();

               isopPerformed = false;
               Button button = (Button)sender;
               if (button.Text == ".")
               {
                    if (!textBox1_Result.Text.Contains("."))
                         textBox1_Result.Text = textBox1_Result.Text + button.Text;
               }
               else
                    textBox1_Result.Text = textBox1_Result.Text + button.Text;

          }

          private void func_Click(object sender, EventArgs e)
          {
               Button button = (Button)sender;
               if (resultVal != 0)
               {
                    if (button.Text == "Sqrt")
                         textBox1_Result.Text = Math.Sqrt(Double.Parse(textBox1_Result.Text)).ToString();
                    if (button.Text == "Log")
                         textBox1_Result.Text = Math.Log(Double.Parse(textBox1_Result.Text)).ToString();
                    if (button.Text == "^2")
                         textBox1_Result.Text = Math.Pow(Double.Parse(textBox1_Result.Text), 2).ToString();




                    equal.PerformClick();
                    opPerformed = button.Text;
                   // lbCurentOp.Text = resultVal + " " + opPerformed;
                    isopPerformed = true;
               }
               else if (button.Text == "Sqrt")
               {
                    textBox1_Result.Text = Math.Sqrt(Double.Parse(textBox1_Result.Text)).ToString();
                    resultVal = Math.Sqrt(Double.Parse(textBox1_Result.Text));
               }
               else if (button.Text == "Log")
               {
                    textBox1_Result.Text = Math.Log(Double.Parse(textBox1_Result.Text)).ToString();
                    resultVal = Math.Log(Double.Parse(textBox1_Result.Text));
               }
               else if (button.Text == "^2")
               {
                    textBox1_Result.Text = Math.Pow(Double.Parse(textBox1_Result.Text), 2).ToString();
                    resultVal = Math.Pow(Double.Parse(textBox1_Result.Text), 2);
               }
               else
               {
                    opPerformed = button.Text;
                    resultVal = Double.Parse(textBox1_Result.Text);
                    opPerformed = button.Text;
                   //lbCurentOp.Text = resultVal + " " + opPerformed;
                    isopPerformed = true;

               }
              //lbCurentOp.Focus();
          }

          private void deletCar_Click(object sender, EventArgs e)
          {
               int length = textBox1_Result.Text.Length - 1;
               string text = textBox1_Result.Text;
               textBox1_Result.Clear();
               for (int i = 0; i < length; i++)
               {
                    textBox1_Result.Text = textBox1_Result.Text + text[i];
               }
          }

          private void clear_Click(object sender, EventArgs e)
          {
               textBox1_Result.Text = "0";
               resultVal = 0;
          }

        
          private void button10_Click(object sender, EventArgs e)
          {
              if (s == true)
            {
                textBox1_Result.Text = "-" + textBox1_Result.Text;
                s = false;
            }
            else
            {
                textBox1_Result.Text = textBox1_Result.Text.Replace("-", "");
                s = true;
            }
          }

          private void equal_Click(object sender, EventArgs e)
          {
               switch (opPerformed)
               {


                    case "+":
                         textBox1_Result.Text = (resultVal + Double.Parse(textBox1_Result.Text)).ToString();
                         break;
                    case "-":
                         textBox1_Result.Text = (resultVal - Double.Parse(textBox1_Result.Text)).ToString();
                         break;
                    case "*":
                         textBox1_Result.Text = (resultVal * Double.Parse(textBox1_Result.Text)).ToString();
                         break;
                    case "/":
                         textBox1_Result.Text = (resultVal / Double.Parse(textBox1_Result.Text)).ToString();
                         break;
                    default:
                         break;
               }

               resultVal = Double.Parse(textBox1_Result.Text);
               //lbCurentOp.Text = "";
          }

       

          private void operator_Click(object sender, EventArgs e)
          {
               Button button = (Button)sender;
               opPerformed = button.Text;
               resultVal = Double.Parse(textBox1_Result.Text);
               isopPerformed = true;
          }

          private void zecimal_Click(object sender, EventArgs e)
          {
               Button button = (Button)sender;
               if (button.Text == ".")
               {
                    if (!textBox1_Result.Text.Contains("."))
                         textBox1_Result.Text = textBox1_Result.Text + button.Text;
               }
               else
                    textBox1_Result.Text = textBox1_Result.Text + button.Text;
          }

          private void Form1_KeyPress(object sender, KeyPressEventArgs e)
          {
               /*switch (e.KeyChar)
               {
                    case "0":
                         zero.PerformClick();
                         break;
                    case "1":
                         one.PerformClick();
                         break;
                    case "2":
                         two.PerformClick();
                         break;
                    case "3":
                         three.PerformClick();
                         break;
                    case "4":
                         four.PerformClick();
                         break;
                    case "5":
                         five.PerformClick();
                         break;
                    case "6":
                         six.PerformClick();
                         break;
                    case "7":
                         seven.PerformClick();
                         break;
                    case "8":
                         eight.PerformClick();
                         break;
                    case "9":
                         nine.PerformClick();
                         break;
                    case "+":
                         add.PerformClick();
                         break;
                    case "-":
                         sub.PerformClick();
                         break;
                    case "*":
                         mul.PerformClick();
                         break;
                    case "/":
                         div.PerformClick();
                         break;
                    case "=":
                         equal.PerformClick();
                         break;
                    default:
                         break;
               }*/
          }
     }
}