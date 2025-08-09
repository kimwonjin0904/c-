using System;
using static System.Console;

public class 다차원배열
{
    public static void Main()
    {
        //데이터형식[,] 배열이름; //2차  
        //데이터형식[,,] 배열이름; //3차

        int[] oneArray;
        int[,] twoArray;
        int[,,] threeArray;

        oneArray = new int[] { 1, 2 };
        twoArray = new int[,] { { 1, 2 }, { 3, 4 } };
        threeArray = new int[,,] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
    }
}