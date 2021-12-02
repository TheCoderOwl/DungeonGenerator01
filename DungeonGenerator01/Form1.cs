using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DungeonGenerator01
{
    public partial class Form1 : Form
    {
        const int mapSize = 20;
        char[,] map = new char[mapSize, mapSize];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initMap();
        }

        private void MakeBtn_Click(object sender, EventArgs e)
        {
            /*test map update
            Random rnd = new Random();
            for(int i=0;i<20;i++)
            {
                int row = rnd.Next(0, mapSize);
                int col = rnd.Next(0, mapSize);

                map[row, col] = '1';
            }
            displayMap();
            */
            BuildNonOverlappingDungeon2();                       
        }
        void initMap()
        {
            for (int row = 0; row < mapSize; row++)
            {
                for (int col = 0; col < mapSize; col++)
                {
                    map[row, col] = 'B';
                }
            }
            displayMap();
        }

        void displayMap()
        {
            MapTxt.Clear();
            for (int row = 0; row < mapSize; row++)
            {
                for (int col = 0; col < mapSize; col++)
                {
                    MapTxt.AppendText(map[row, col].ToString());
                }
                MapTxt.AppendText("\r\n");
            }
            Refresh();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            initMap();
        }

        void buildOverlappingDungeon()
        {
            Random rnd = new Random();

            int numOfRooms = 30; //get user input
            /*
            for (int i = 0; i < 1; i++)
            {
                int row = rnd.Next(0, mapSize - 1);
                int col = rnd.Next(0, mapSize - 1);
                int ResetCol = col;
                while (row < row + RoomSize - 1 && row < 20)
                {
                    col = ResetCol;
                    row++;
                    while (col < col + RoomSize - 1 && col < 20)
                    {
                        map[row, col] = '1';
                        col++;
                    }
                    
                }*/
            for (int i = 0; i < numOfRooms; i++)
            {
                //starting point for room
                int RoomSize = rnd.Next(3, 6);
                int roomRow = rnd.Next(0, mapSize - RoomSize);
                int roomCol = rnd.Next(0, mapSize - RoomSize);

                for (int row = roomRow; row < roomRow + RoomSize; row++)
                {
                    for (int col = roomCol; col < roomCol + RoomSize; col++)
                    {
                        map[row, col] = 'I';
                    }
                }
            }

            displayMap();


        }
        void BuildNonOverlappingDungeon()
        {
            Random rnd = new Random();

            int numOfRooms = 5;
            int attempts = 0;
            for (int i = 0; i < numOfRooms; i++)
            {
                int RoomSize = rnd.Next(3, 6);
                int roomRow = rnd.Next(0, mapSize - RoomSize);
                int roomCol = rnd.Next(0, mapSize - RoomSize);
                bool ValidRoom = true;

                for (int row = roomRow; row < roomRow + RoomSize; row++)
                {
                    for (int col = roomCol; col < roomCol + RoomSize; col++)
                    {
                        if (map[row, col] == 'I')
                        {
                            ValidRoom = false;

                        }
                    }
                }
                if (ValidRoom == false)
                {
                    i--;
                    attempts++;
                }
                //starting point for room
                if (ValidRoom == true)
                {
                    for (int row = roomRow; row < roomRow + RoomSize; row++)
                    {
                        for (int col = roomCol; col < roomCol + RoomSize; col++)
                        {
                            map[row, col] = 'I';
                            if (row == roomRow || col == roomCol || row == roomRow + RoomSize - 1 || col == roomCol + RoomSize - 1)
                            {
                                map[row, col] = 'W';
                            }
                        }
                    }
                    attempts = 101;


                    //displayMap();
                }


                //displayMap();

            }
            displayMap();
        }
        void BuildNonOverlappingDungeon2()
        {
            int numOfRooms;
            int MaxRoomHeight;
            int MinRoomheight;
            int MaxRoomWidth;
            int MinRoomWidth;

            int attempts = 0;
            bool valid = int.TryParse(NumOfRoomsTxt.Text,out numOfRooms);
            if (valid == false)
            {
                MessageBox.Show("please enter a valid integer for the field 'NumOfRooms'");
            }
            bool valid2 = int.TryParse(MaxRoomHeightTxt.Text, out MaxRoomHeight);
            if (valid2 == false)
            {
                MessageBox.Show("please enter a valid integer for the field 'MaxRoomHeight'");
            }
            bool valid3 = int.TryParse(MinRoomHeightTxt.Text, out MinRoomheight);
            if (valid3 == false)
            {
                MessageBox.Show("please enter a valid integer for the field 'MinRoomHeight'");
            }
            bool valid4 = int.TryParse(MaxRoomWidthTxt.Text, out MaxRoomWidth);
            if (valid4 == false)
            {
                MessageBox.Show("please enter a valid integer for the field 'MaxRoomWidth'");
            }
            bool valid5 = int.TryParse(MinRoomWidthTxt.Text, out MinRoomWidth);
            if (valid5 == false)
            {
                MessageBox.Show("please enter a valid integer for the field 'MinRoomWidth'");
            }

            Random rnd = new Random();

            
            for (int i = 0; i < numOfRooms; i++)
            {
                int RoomHeight = rnd.Next(MinRoomheight, MaxRoomHeight);
                int RoomWidth = rnd.Next(MinRoomWidth, MaxRoomWidth);
                int roomRow = rnd.Next(1, mapSize - RoomWidth - 1);
                int roomCol = rnd.Next(1, mapSize - RoomHeight - 1);
                bool ValidRoom = true;

                for (int row = roomRow; row < roomRow + RoomWidth; row++)
                {
                    for (int col = roomCol; col < roomCol + RoomHeight; col++)
                    {
                        if (map[row, col] == 'I')
                        {
                            ValidRoom = false;

                        }
                    }
                }
                if (ValidRoom == false)
                {
                    i--;
                    attempts++;
                }
                
                //starting point for room
                if (ValidRoom == true)
                {
                    for (int row = roomRow; row < roomRow + RoomWidth; row++)
                    {
                        for (int col = roomCol; col < roomCol + RoomHeight; col++)
                        {
                            map[row, col] = 'I';
                        }
                    }
                          
                }
                

                displayMap();
            }
            
            displayMap();
        }
        void DoWalls()
        {
            for (int row = 1; row < 20 - 1 && row > 0; row++)
            {
                for (int col = 1; col < 20 - 1 && col > 0; col++)
                {
                    if (map[row, col] == 'I')
                    {
                        if (map[row - 1, col] == 'B') { map[row, col] = 'W'; }
                        if (map[row + 1, col] == 'B') { map[row, col] = 'W'; }
                        if (map[row, col - 1] == 'B') { map[row, col] = 'W'; }
                        if (map[row, col + 1] == 'B') { map[row, col] = 'W'; }
                    }

                }
            }
            displayMap();
        }
        
       
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 1);



            SolidBrush BlueBrush = new SolidBrush(Color.Blue);

            SolidBrush BlackBrush = new SolidBrush(Color.Black);

            SolidBrush GreyBrush = new SolidBrush(Color.LightGray);

            SolidBrush reddyBrush = new SolidBrush(Color.SaddleBrown);





            for (int row = 0; row < 20; row++)

            {

                for (int col = 0; col < 20; col++)

                {

                    if (map[row, col] == 'B') { e.Graphics.FillRectangle(GreyBrush, new Rectangle(col * 10, row * 10, 10, 10)); }

                    if (map[row, col] == 'I') { e.Graphics.FillRectangle(BlueBrush, new Rectangle(col * 10, row * 10, 10, 10)); }

                    if (map[row, col] == 'W') { e.Graphics.FillRectangle(BlackBrush, new Rectangle(col * 10, row * 10, 10, 10)); }

                    if (map[row, col] == 'D') { e.Graphics.FillRectangle(reddyBrush, new Rectangle(col * 10, row * 10, 10, 10)); }



                    e.Graphics.DrawRectangle(blackPen, new Rectangle(col * 10, row * 10, 10, 10));

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoWalls();
        }
        void ValidatingInputs()
        {

        }
        void DoDoors()
        {
            for (int row = 1; row < 20 - 1 && row > 0; row++)
            {
                for (int col = 1; col < 20 - 1 && col > 0; col++)
                {
                    if (map[row, col] == 'I')
                    {
                        if (map[row - 2, col] == 'I' && map[row - 1,col] == 'W') { map[row - 1, col] = 'D'; }
                        if (map[row + 2, col] == 'I' && map[row + 1, col] == 'W') { map[row + 1, col] = 'D'; }
                        if (map[row, col - 2] == 'I' && map[row, col - 1] == 'W') { map[row, col - 1] = 'D'; }
                        if (map[row, col + 2] == 'I' && map[row, col + 1] == 'W') { map[row, col + 1] = 'D'; }
                    }

                }
            }
            CheckDoors();
            displayMap();
            
        }
        void CheckDoors()
        {
            for (int row = 1; row < 20 - 1 && row > 0; row++)
            {
                for (int col = 1; col < 20 - 1 && col > 0; col++)
                {
                    if (map[row, col] == 'D')
                    {
                        if (map[row - 1, col] == 'I' && map[row + 1, col] == 'I' && map[row, col - 1] == 'I') { map[row, col] = 'I'; }
                        if (map[row - 1, col] == 'I' && map[row + 1, col] == 'I' && map[row, col + 1] == 'I') { map[row, col] = 'I'; }
                        if (map[row - 1, col] == 'I' && map[row - 1, col] == 'I' && map[row, col - 1] == 'I') { map[row, col] = 'I'; }
                        if (map[row - 1, col] == 'I' && map[row - 1, col] == 'I' && map[row, col + 1] == 'I') { map[row, col] = 'I'; }
                        if (map[row - 1, col] == 'I' && map[row - 1, col] == 'I' && map[row, col - 1] == 'I') { map[row, col] = 'I'; }
                        if (map[row + 1, col] == 'I' && map[row + 1, col] == 'I' && map[row, col + 1] == 'I') { map[row, col] = 'I'; }
                        if (map[row + 1, col] == 'I' && map[row + 1, col] == 'I' && map[row, col - 1] == 'I') { map[row, col] = 'I'; }
                        if (map[row + 1, col] == 'I' && map[row - 1, col] == 'I' && map[row, col + 1] == 'I') { map[row, col] = 'I'; }
                        if (map[row + 1, col] == 'I' && map[row - 1, col] == 'I' && map[row, col - 1] == 'I') { map[row, col] = 'I'; }
                    }

                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DoDoors();
        }
        void CleanUp()
        {
            for (int row = 1; row < 20 - 1 && row > 0; row++)
            {
                for (int col = 1; col < 20 - 1 && col > 0; col++)
                {
                    if (map[row, col] == 'I')
                    {
                        if (map[row - 1, col] == 'B' ) { map[row - 1, col] = 'W'; }
                        if (map[row + 1, col] == 'B' ) { map[row + 1, col] = 'W'; }
                        if (map[row, col - 1] == 'B' ) { map[row, col - 1] = 'W'; }
                        if (map[row, col + 1] == 'B' ) { map[row, col + 1] = 'W'; }
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CleanUp();
            displayMap();
        }
        void SaveToFile()
        {
            StreamWriter Writer = new StreamWriter(@"g:\SavedDungeonData6.txt");
            for (int row = 1; row <= 20 - 1 && row > 0; row++)
            {
                for (int col = 1; col <= 20 - 1 && col > 0; col++)
                {
                    
                    Writer.Write(map[row, col]);
                    if (col == 19)
                    {
                        Writer.WriteLine();
                    }
                    
                }
                //Writer.Write("\r\n");

            }
            Writer.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }
    }
}
