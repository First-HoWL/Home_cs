using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Game
{
    enum team
    {
        white,
        black
    }
    abstract class Chessman
    {
        protected int x, y;
        protected team team;

        team Team { get { return team; } }

        public int[][] whereCanMove()
        {
            int[][] a = new int[64][];
            int b = 0;
            for (int i = 0; i < 64; ++i)
                a[i] = new int[2];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (this.isCanMove(i, j))
                    {
                        a[b][0] = i;
                        a[b][1] = j;
                        b++;
                    }
                }
            }
            int[][] c = new int[b][];
            for (int i = 0; i < b; ++i)
                c[i] = new int[2];
            for (int i = 0; i < b; i++)
            {
                c[i][0] = a[i][0];
                c[i][1] = a[i][1];
            }
            return c;
        }

        

        public abstract bool isCanMove(int y, int x);


    }
    class Pawn : Chessman
    {

        public override bool isCanMove(int y, int x)
        {
            if (this.x == x)
                if (this.y == y - 1 || this.y == y - 2) return true;

            return false;
        }
        public Pawn(int x, int y, team team)
        {
            this.x = x;
            this.y = y;
            this.team = team;
        }
    }

    class Turris : Chessman
    {

        public override bool isCanMove(int y, int x)
        {
            if (y == this.y || x == this.x) return true;
            else
                return false;
        }
        public Turris(int x, int y, team team)
        {
            this.x = x;
            this.y = y;
            this.team = team;
        }
    }

    class Horse : Chessman
    {
        public override bool isCanMove(int y, int x)
        {
            if (this.y + 2 == y && this.x + 1 == x) return true;
            else if (this.y + 2 == y && this.x - 1 == x) return true;
            else if (this.y - 2 == y && this.x + 1 == x) return true;
            else if (this.y - 2 == y && this.x - 1 == x) return true;
            else if (this.y + 1 == y && this.x - 2 == x) return true;
            else if (this.y + 1 == y && this.x + 2 == x) return true;
            else if (this.y - 1 == y && this.x - 2 == x) return true;
            else if (this.y - 1 == y && this.x + 2 == x) return true;
            else
                return false;
        }
        public Horse(int x, int y, team team)
        {
            this.x = x;
            this.y = y;
            this.team = team;
        }
    }

    class Elephant : Chessman
    {
        public override bool isCanMove(int y, int x)
        {
            if (x + y == this.x + this.y)
                return true;

            if (x - y == this.x - this.y)
                return true;


            return false;
        }
        public Elephant(int x, int y, team team)
        {
            this.x = x;
            this.y = y;
            this.team = team;
        }
    }

    class Ferzin : Chessman
    {
        public override bool isCanMove(int y, int x)
        {

            if (this.x == x + 1 || this.x == x - 1 || this.x == x)
                if (this.y == y + 1 || this.y == y - 1 || this.y == y)
                    return true;
            if (y == this.y || x == this.x) return true;

            if (x + y == this.x + this.y)
                return true;

            if (x - y == this.x - this.y)
                return true;


            return false;
        }
        public Ferzin(int x, int y, team team)
        {
            this.x = x;
            this.y = y;
            this.team = team;
        }
    }

    class King : Chessman
    {
        public override bool isCanMove(int y, int x)
        {

            if (this.x == x + 1 || this.x == x - 1 || this.x == x)
                if (this.y == y + 1 || this.y == y - 1 || this.y == y)
                    return true;

            return false;
        }
        public King(int x, int y, team team)
        {
            this.x = x;
            this.y = y;
            this.team = team;
        }
    }


}
