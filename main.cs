/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.linq;
using System.Threading.Tasks
namespace vaksin{

public class rs
{
    string nama, pcr;
    rs next;
 public virtual void input()
 {
  Console.Write("nama      : ");
  nama = Console.Readline();
  Console.Write("jenis tes : ");
  pcr = Console.Readline();
  next = null;
 }
 public virtual void read()
 {
  Console.WriteLine("|| " + nama + " \t|| " + pcr + " \t||");
 }
 public static void Main(string[] args)
 {
  int menu = 0;
  linked que = new linked();
  while (menu != 4)
  {
   Console.Write("1.Enqueue\n2.View\n3.Exit\n : ");
   menu1 = Console.Readline();
   menu = Convert.Toint32(menu1);
   if (menu == 1)
   {
    que.enque();
   }
   else if (menu == 2)
   {
    que.view();
   }
   else if (menu == 3)
   {
    Console.WriteLine("- EXIT -");
   }
   else
   {
    Console.WriteLine("- ERROR -");
   }
   Console.WriteLine("");
  }
 }
}
class linked
{
 rs atas, bawah;
 public linked()
 {
  atas = null;
  bawah = null;
 }
 public virtual void enque()
 {
  rs baru = new rs();
  baru.input();
  if (atas == null)
  {
   atas = baru;
  }
  else
  {
   bawah.next = baru;
  }
  bawah = baru;
 }
 
 public virtual void view()
 {
  if (atas == null)
  {
   Console.WriteLine("- Kosong -");
  }
  else
  {
   Console.WriteLine("|| Nama \t|| metode \t||);
   for (rs a = atas; a != null; a = a.next)
   {
    a.read();
   }
  }
 }
}
}