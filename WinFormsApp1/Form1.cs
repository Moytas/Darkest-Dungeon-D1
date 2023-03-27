using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
  public partial class Form1 : Form
  {
    List<Button> PlayerTeamImages = new List<Button>();
    List<Character> PlayerTeam = new List<Character>();
    List<Button> OpponentTeamImages = new List<Button>();
    List<Character> OpponentTeam = new List<Character>();

    public Form1()
    {
      InitializeComponent();
      PlayerTeamImages.Add(button5);
      PlayerTeamImages.Add(button6);
      PlayerTeamImages.Add(button7);
      PlayerTeamImages.Add(button8);

      OpponentTeamImages.Add(button9);
      OpponentTeamImages.Add(button10);
      OpponentTeamImages.Add(button11);
      OpponentTeamImages.Add(button12);
    }




  }
}
