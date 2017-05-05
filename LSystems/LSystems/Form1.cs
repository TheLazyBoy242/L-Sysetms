using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace LSystems
{
    public partial class Form1 : Form
    {
        string posang = "";
        string negang = "";
        int length = 5;
        int depth = 6;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            test_out_lbl.Visible = false;
            this.BackColor = Color.White;
        }

        private void Run_btn_Click(object sender, EventArgs e)
        {
            int pos_angle;
            int neg_angle;
            Random rand = new Random();

            //randomizes the angles for generation if needed
            if (posang != "") { pos_angle = Convert.ToInt16(posang); }
            else { pos_angle = rand.Next(5, 35); }

            if (negang != "") { neg_angle = -Convert.ToInt16(negang); }
            else { neg_angle = -rand.Next(5, 35); }


            string this_line = "";


            // sets up the turtle graphics tool with the right settings
            
            Turtle.PenUp();
            Turtle.PenColor = Color.Brown;
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 3;
            Turtle.MoveTo(-400, -150);
            Turtle.RotateTo(25);
            Turtle.PenUp();


            // initializes and runs the l-system
            system lsys = new system();
            lsys.next_gen(depth,"X");


            for (int i = 0; i < depth; i++) //runs for each generation of the tree. This is not striktly neccissary,
                                            //but is fairly unintensive, and simply coppies over. It can be used to alter the 
                                            //width of the branches at higher levels.
            {
                              
                Stack<int[]> stk = new Stack<int[]>(); //creates the stack for generation at runtime

                this_line = lsys.gen_tree.Pop();//pops the oldest generation from the stack of generationscerated
                                                //by the l-system


                //resets the tuertle at the base of the tree and at the correct angle
                Turtle.PenDown();                
                Turtle.RotateTo(45);
                Turtle.PenUp();
                Turtle.MoveTo(-600, -300);
                Turtle.PenDown();


                //generates the tree based on the characters in the gurrent generation ruleset
                foreach (char c in this_line)
                {
                   //values of the turtle if needed to be pushed to the stack
                    int[] to_place = new int[3];
                    to_place[0] = Convert.ToInt16(Turtle.X);
                    to_place[1] = Convert.ToInt16(Turtle.Y);
                    to_place[2] = Convert.ToInt16(Turtle.Angle);

                    //the rules depending on character
                    if (c == 'F') {
                        Turtle.Forward(length); }

                    if (c== 'X') {//draws leaf nodes
                        Turtle.PenColor = Color.Green;
                        
                        Turtle.Forward(length*2);
                        
                        Turtle.PenColor = Color.Brown;
                    }

                    if (c == '-') {//rotates negatiely
                        Turtle.Rotate(neg_angle); }

                    if (c == '+') {//rotates positively
                        Turtle.Rotate(pos_angle); }

                    if (c == '[')
                    {//pushes to stack
                        stk.Push(to_place);
                    }
                    
                    if (c == ']')
                    {//pops from stack, and updates turtle position
                        Turtle.PenUp();
                        Turtle.MoveTo(stk.Peek()[0], stk.Peek()[1]);
                        Turtle.RotateTo(stk.Pop()[2]);
                        Turtle.PenDown();
                    }
                }

            }

        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = Color.White;
            Turtle.PenSize = 2000;
            Turtle.PenDown();
            Turtle.MoveTo(0, 0);
        }

        private void posang_txtb_TextChanged(object sender, EventArgs e)
        {
            posang = posang_txtb.Text;
        }

        private void negang_txtb_TextChanged(object sender, EventArgs e)
        {
            negang = negang_txtb.Text;
        }

        private void Depth_bar_Scroll(object sender, EventArgs e)
        {
            depth = Depth_bar.Value;
            depth_lbl.Text = "Depth = " + Depth_bar.Value;
        }

        private void Length_txtb_TextChanged(object sender, EventArgs e)
        {
            if (Length_txtb.Text != "")
            {
            length = Convert.ToInt32(Length_txtb.Text);
            }

        }
    }


    class system
    {
        //creates dictionary for rules
        Dictionary<char, string> rules = new Dictionary<char, string>();

        //creates key value pairs on initalization
        public system( )
        {
            rules.Add('F', "FF");
            rules.Add('X', "F-[[X]+X]+F[+FX]-X");
            //rules.Add('X', "F[++F[X]]-F+X");
        }

        public void clear()
        {
            current = "";
        }

        //creates stack of generations
        public Stack<string> gen_tree = new Stack<string>();

        //uses the rules dictionary to proccess the current gerneration and push the nex
        //generation to the stack.
        public string current;
        public void next_gen(int gen, string axiom)
        {
            if (gen != 0)
            { 

                string new_str = "";
                foreach (char c in axiom)
                {
                    //writes with new rule if needed, and copies if not
                    if (rules.ContainsKey(c))
                    {
                        new_str += rules[c];
                    }
                    else
                    {
                        new_str += c;
                    }
                }
                current = new_str;
                gen_tree.Push(current);
                next_gen(gen - 1,current);
            }
        }
    }
}
