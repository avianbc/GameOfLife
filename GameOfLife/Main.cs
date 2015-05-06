using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Main : Form
    {
        public byte[,] cells;
        public int rows, cols, generation;
        public Random rand = new Random();
        public Rectangle canvas;
        public Point topLeft;
        public enum FileType
        {
            Unknown,
            RLE,
            CELLS,
            LIF
        }

        private byte RandByte()
        {
            return rand.Next() % 2 == 0 ? (byte)1 : (byte)0;
        }

        public Main()
        {
            InitializeComponent();
            topLeft = new Point(0, menu.Height + toolStrip.Height);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int width = int.Parse(inputWidth.Text);
                int height = int.Parse(inputHeight.Text);
                Init(width, height);
            }
            catch (FormatException)
            {
                Init(30, 30);
            }
        }

        private void Init(int numCols, int numRows, byte defaultValue = 0)
        {
            generation = 0;
            cols = numCols;
            rows = numRows;
            cells = new byte[cols,rows];

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    //cells[x, y] = RandByte();
                    cells[x, y] = defaultValue;
                }
            }
            canvas = new Rectangle(0, topLeft.Y, (Properties.Resources.black.Width - 1) * cols + 1, (Properties.Resources.black.Height - 1) * rows + 1);
            Invalidate();
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            using (var white = new Bitmap(Properties.Resources.white))
            using (var black = new Bitmap(Properties.Resources.black))
            {
                for (int y = 0; y < rows; y++)
                {
                    for (int x = 0; x < cols; x++)
                    {
                        e.Graphics.DrawImage(cells[x, y] != 0 ? black : white, x * (white.Width-1), y * (white.Width-1) + topLeft.Y);
                    }
                }
            }
            statusLabel.Text = "Generation: " + generation;
        }

        private void ParseFile(FileType typeOfFile, string fileNameAndPath, int padding)
        {
            if(!File.Exists(fileNameAndPath))
                throw new FileNotFoundException();

            if(padding < 0)
                padding = 0;

            using (StreamReader fs = new StreamReader(fileNameAndPath))
            {
                switch (typeOfFile)
                {
                    // Parse RLE Run Length Encoded File Format
                    case FileType.RLE: // www.conwaylife.com/wiki/RLE
                        int xsize = 0, ysize = 0;
                        while (xsize == 0 || ysize == 0)
                        {
                            string contents = fs.ReadLine();
                            if (contents == null)
                                throw new InvalidDataException();

                            if (contents.Contains("#"))
                                continue;

                            string[] values = contents.Split(',');
                            foreach (string s in values)
                            {
                                string[] t = s.Replace(" ", String.Empty).Split('=');

                                if (t[0] == "x")
                                    xsize = int.Parse(t[1]) + padding*2;

                                if (t[0] == "y")
                                    ysize = int.Parse(t[1]) + padding*2;
                            }
                        }

                        Init(xsize, ysize);

                        string[] eachLine = fs.ReadToEnd().ToLower().Split('$');
                        int rowNo = padding;
                        foreach(string encodedLine in eachLine)
                        {
                            string decodedLine = Decode(encodedLine).Replace("\r","").Replace("\n","");
                            int colNo = padding;
                            foreach (char c in decodedLine)
                            {
                                if(c == 'o')
                                    cells[colNo, rowNo] = 1;

                                colNo++;
                            }
                            rowNo++;
                        }
                        Invalidate();
                        break;

                    // parse plaintext / *.cells file format
                    case FileType.CELLS: // www.conwaylife.com/wiki/Plaintext

                        string currentLine;
                        int maxLength=0;
                        List<string> fileContainer = new List<string>();

                        while ((currentLine = fs.ReadLine()) != null)
                        {
                            if (currentLine.Contains("!"))
                                continue;

                            if (currentLine.Length > maxLength)
                                maxLength = currentLine.Length;

                            fileContainer.Add(currentLine);
                        }

                        Init(maxLength+padding*2, fileContainer.Capacity+padding*2);

                        int rowNum = 0;
                        foreach(string line in fileContainer)
                        {
                            int colNum = 0;
                            foreach(char c in line)
                            {
                                if(c == '.')
                                    cells[colNum + padding, rowNum + padding] = 0;
                                else
                                    cells[colNum + padding, rowNum + padding] = 1;

                                colNum++;
                            }
                            rowNum++;
                        }
                        break;

                    // parse *.lif 1.05 and 1.06 file format
                    case FileType.LIF: // www.conwaylife.com/wiki/Life_1.05 and www.conwaylife.com/wiki/Life_1.06

                        break;
                }
            }
        }

        public static string Decode(string toDecode)
        {
            string coefficient = String.Empty;
            StringBuilder sb = new StringBuilder();

            foreach (char current in toDecode)
            {
                if (char.IsDigit(current))
                    coefficient += current;
                else
                {
                    if (coefficient == String.Empty)
                        sb.Append(current);
                    else
                    {
                        int count = int.Parse(coefficient);
                        coefficient = String.Empty;

                        for (int j = 0; j < count; j++)
                            sb.Append(current);
                    }
                }
            }
            return sb.ToString();
        }

        public static string Encode(string toEncode)
        {
            StringBuilder sb = new StringBuilder(); 
            int count = 1; 
            char current = toEncode[0]; 
            for (int i = 1; i < toEncode.Length; i++)
            {
                if (current == toEncode[i])
                {
                    count++;
                } else
                {
                    sb.AppendFormat("{0}{1}", count, current);
                    count = 1;
                    current = toEncode[i];
                }
            }
            sb.AppendFormat("{0}{1}", count, current);
            return sb.ToString();
        }

        private void FileLoadMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (Path.GetExtension(openFileDialog.FileName))
                {
                    case ".rle":
                        ParseFile(FileType.RLE, openFileDialog.FileName, 5);
                        break;

                    case ".lif":
                    case ".life":
                        ParseFile(FileType.LIF, openFileDialog.FileName, 5);
                        break;

                    case ".cells":
                        ParseFile(FileType.CELLS, openFileDialog.FileName, 5);
                        break;

                    default:
                        ParseFile(FileType.Unknown, openFileDialog.FileName, 5);
                        break;
                }

                Invalidate(canvas);
            }
        }

        private void NextGeneration()
        {
            byte[,] cellTemp = new byte[cols,rows];
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    cellTemp[x, y] = Lives(x, y) ? (byte)1 : (byte)0;
                }
            }
            generation++;
            cells = cellTemp;
            Invalidate(canvas);
        }

        private bool Lives(int x, int y)
        {
            int neighbors = NeighborCount(x, y);

            if (cells[x, y] != 0 && (neighbors == 2 || neighbors == 3))
                return true;

            if (cells[x, y] == 0 && neighbors == 3)
                return true;

            return false;
        }

        private int NeighborCount(int x, int y)
        {
            int count = 0;
            
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int xval = j + x;
                    int yval = i + y;

                    if (x == xval && y == yval)
                        continue;

                    if (xval < 0)
                        xval = cols - 1;
                    else if (xval > cols - 1)
                        xval = 0;

                    if (yval < 0)
                        yval = rows - 1;
                    else if (yval > rows - 1)
                        yval = 0;

                    if (cells[xval, yval] != 0)
                        count++;
                }
            }

            return count;
        }

        private void stepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private Point GetCellCoords(int mouseX, int mouseY)
        {
            int cellSize = Properties.Resources.white.Width - 1;
            return new Point(mouseX / cellSize, (mouseY - topLeft.Y) / cellSize);
        }

        private void ToggleMenuChecked(object sender, EventArgs e)
        {
            ToolStripMenuItem s = sender as ToolStripMenuItem;
            if (s == null) { return; }

            var parent = (ToolStripMenuItem)s.OwnerItem;
            foreach (ToolStripMenuItem item in parent.DropDownItems)
            {
                if (item == sender)
                    item.Checked = true;

                if (item != null && item != sender)
                    item.Checked = false;
            }

            switch (s.Text)
            {
                case "Fastest":
                    timer.Interval = 25;
                    break;

                case "Fast":
                    timer.Interval = 150;
                    break;

                case "Normal":
                    timer.Interval = 500;
                    break;

                case "Slow":
                    timer.Interval = 1000;
                    break;

                case "Slowest":
                    timer.Interval = 2000;
                    break;
            }
        }

        private void ToggleAnimationToolStripButton_Click(object sender, EventArgs e)
        {
            ToggleAnimationToolStripButton.Image = timer.Enabled ? Properties.Resources.play : Properties.Resources.pause;
            timer.Enabled = !timer.Enabled;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && canvas.Contains(e.X, e.Y))
            {
                Point cellLocation = GetCellCoords(e.X, e.Y);
                cells[cellLocation.X, cellLocation.Y] = 1;
                Invalidate(canvas);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Init(30, 30);
        }

        private void FileExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
