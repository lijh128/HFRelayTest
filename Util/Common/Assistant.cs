﻿using System;

namespace RelayTest.Util.Common
{
    /// <summary>
    /// Assistant ��ժҪ˵����
    /// </summary>
    public sealed class Assistant
    {        
            
        #region

        /// <summary>
        /// ���ַ���������õ����涨�������ַ���.
        /// </summary>
        /// <param name="allChar"></param>
        /// <param name="CodeCount"></param>
        /// <returns></returns>
        private string GetRandomCode(string allChar,int CodeCount) 
        { 
            //string allChar = "1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,i,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z"; 
            string[] allCharArray = allChar.Split(','); 
            string RandomCode = ""; 
            int temp = -1; 
            Random rand = new Random(); 
            for (int i=0;i<CodeCount;i++) 
            { 
                if (temp != -1) 
                { 
                    rand = new Random(temp*i*((int) DateTime.Now.Ticks)); 
                } 

                int t = rand.Next(allCharArray.Length-1); 

                while (temp == t) 
                { 
                    t = rand.Next(allCharArray.Length-1); 
                } 
        
                temp = t; 
                RandomCode += allCharArray[t]; 
            } 
            return RandomCode; 
        }

        #endregion
        

    }
}
