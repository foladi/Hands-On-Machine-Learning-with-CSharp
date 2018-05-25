﻿// Accord Math Library
// The Accord.NET Framework
// http://accord-framework.net
//
// Copyright © César Souza, 2009-2017
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

// ======================================================================
// This code has been generated by a tool; do not edit manually. Instead,
// edit the T4 template Matrix.Elementwise2.tt so this file can be regenerated. 
// ======================================================================

namespace Accord.Math
{
    using System;
    using Accord.Math;
    using System.Runtime.CompilerServices;

    public static partial class Elementwise
    {
#pragma warning disable 1591



        #region Matrix matrix

        /// <summary>
        ///   Multiplies a matrix <c>A</c> with a scalar <c>b</c> and accumulates with <c>c</c>.
        /// </summary>
        /// 
        /// <param name="a">The matrix <c>A</c>.</param>
        /// <param name="b">The scalar <c>b</c>.</param>
        /// <param name="c">The matrix <c>c</c>.</param>
        /// <param name="result">The matrix where the result should be stored. Pass the same
        ///   matrix as one of the arguments to perform the operation in place.</param>
        /// 
#if NET45 || NET46 || NET462 || NETSTANDARD2_0
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static int[][] MultiplyAndAdd(this int[][] a, int b, int[][] c, int[][] result)
        {
            check<int, int, int, int>(a: a, b: b, c: c, result: result);
            for (int i = 0; i < result.Length; i++)
                for (int j = 0; j < result[i].Length; j++)
                    result[i][j] = (int)((int)(a[i][j]) * b + (int)(c[i][j]));

            return result;
        }

        /// <summary>
        ///   Multiplies a matrix <c>A</c> with a scalar <c>b</c> and accumulates with <c>c</c>.
        /// </summary>
        /// 
        /// <param name="a">The matrix <c>A</c>.</param>
        /// <param name="b">The scalar <c>b</c>.</param>
        /// <param name="c">The matrix <c>c</c>.</param>
        /// <param name="result">The matrix where the result should be stored. Pass the same
        ///   matrix as one of the arguments to perform the operation in place.</param>
        /// 
#if NET45 || NET46 || NET462 || NETSTANDARD2_0
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static int[,] MultiplyAndAdd(this int[,] a, int b, int[,] c, int[,] result)
        {
            check<int, int, int, int>(a: a, b: b, c: c, result: result);
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                    result[i, j] = (int)((int)(a[i, j]) * b + (int)(c[i, j]));

            return result;
        }

        #endregion



        #region Matrix matrix

        /// <summary>
        ///   Multiplies a matrix <c>A</c> with a scalar <c>b</c> and accumulates with <c>c</c>.
        /// </summary>
        /// 
        /// <param name="a">The matrix <c>A</c>.</param>
        /// <param name="b">The scalar <c>b</c>.</param>
        /// <param name="c">The matrix <c>c</c>.</param>
        /// <param name="result">The matrix where the result should be stored. Pass the same
        ///   matrix as one of the arguments to perform the operation in place.</param>
        /// 
#if NET45 || NET46 || NET462 || NETSTANDARD2_0
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static float[][] MultiplyAndAdd(this float[][] a, float b, float[][] c, float[][] result)
        {
            check<float, float, float, float>(a: a, b: b, c: c, result: result);
            for (int i = 0; i < result.Length; i++)
                for (int j = 0; j < result[i].Length; j++)
                    result[i][j] = (float)((float)(a[i][j]) * b + (float)(c[i][j]));

            return result;
        }

        /// <summary>
        ///   Multiplies a matrix <c>A</c> with a scalar <c>b</c> and accumulates with <c>c</c>.
        /// </summary>
        /// 
        /// <param name="a">The matrix <c>A</c>.</param>
        /// <param name="b">The scalar <c>b</c>.</param>
        /// <param name="c">The matrix <c>c</c>.</param>
        /// <param name="result">The matrix where the result should be stored. Pass the same
        ///   matrix as one of the arguments to perform the operation in place.</param>
        /// 
#if NET45 || NET46 || NET462 || NETSTANDARD2_0
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static float[,] MultiplyAndAdd(this float[,] a, float b, float[,] c, float[,] result)
        {
            check<float, float, float, float>(a: a, b: b, c: c, result: result);
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                    result[i, j] = (float)((float)(a[i, j]) * b + (float)(c[i, j]));

            return result;
        }

        #endregion



        #region Matrix matrix

        /// <summary>
        ///   Multiplies a matrix <c>A</c> with a scalar <c>b</c> and accumulates with <c>c</c>.
        /// </summary>
        /// 
        /// <param name="a">The matrix <c>A</c>.</param>
        /// <param name="b">The scalar <c>b</c>.</param>
        /// <param name="c">The matrix <c>c</c>.</param>
        /// <param name="result">The matrix where the result should be stored. Pass the same
        ///   matrix as one of the arguments to perform the operation in place.</param>
        /// 
#if NET45 || NET46 || NET462 || NETSTANDARD2_0
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double[][] MultiplyAndAdd(this double[][] a, double b, double[][] c, double[][] result)
        {
            check<double, double, double, double>(a: a, b: b, c: c, result: result);
            for (int i = 0; i < result.Length; i++)
                for (int j = 0; j < result[i].Length; j++)
                    result[i][j] = (double)((double)(a[i][j]) * b + (double)(c[i][j]));

            return result;
        }

        /// <summary>
        ///   Multiplies a matrix <c>A</c> with a scalar <c>b</c> and accumulates with <c>c</c>.
        /// </summary>
        /// 
        /// <param name="a">The matrix <c>A</c>.</param>
        /// <param name="b">The scalar <c>b</c>.</param>
        /// <param name="c">The matrix <c>c</c>.</param>
        /// <param name="result">The matrix where the result should be stored. Pass the same
        ///   matrix as one of the arguments to perform the operation in place.</param>
        /// 
#if NET45 || NET46 || NET462 || NETSTANDARD2_0
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double[,] MultiplyAndAdd(this double[,] a, double b, double[,] c, double[,] result)
        {
            check<double, double, double, double>(a: a, b: b, c: c, result: result);
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                    result[i, j] = (double)((double)(a[i, j]) * b + (double)(c[i, j]));

            return result;
        }

        #endregion



        #region Matrix matrix

        /// <summary>
        ///   Multiplies a matrix <c>A</c> with a scalar <c>b</c> and accumulates with <c>c</c>.
        /// </summary>
        /// 
        /// <param name="a">The matrix <c>A</c>.</param>
        /// <param name="b">The scalar <c>b</c>.</param>
        /// <param name="c">The matrix <c>c</c>.</param>
        /// <param name="result">The matrix where the result should be stored. Pass the same
        ///   matrix as one of the arguments to perform the operation in place.</param>
        /// 
#if NET45 || NET46 || NET462 || NETSTANDARD2_0
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static byte[][] MultiplyAndAdd(this byte[][] a, byte b, byte[][] c, byte[][] result)
        {
            check<byte, byte, byte, byte>(a: a, b: b, c: c, result: result);
            for (int i = 0; i < result.Length; i++)
                for (int j = 0; j < result[i].Length; j++)
                    result[i][j] = (byte)((byte)(a[i][j]) * b + (byte)(c[i][j]));

            return result;
        }

        /// <summary>
        ///   Multiplies a matrix <c>A</c> with a scalar <c>b</c> and accumulates with <c>c</c>.
        /// </summary>
        /// 
        /// <param name="a">The matrix <c>A</c>.</param>
        /// <param name="b">The scalar <c>b</c>.</param>
        /// <param name="c">The matrix <c>c</c>.</param>
        /// <param name="result">The matrix where the result should be stored. Pass the same
        ///   matrix as one of the arguments to perform the operation in place.</param>
        /// 
#if NET45 || NET46 || NET462 || NETSTANDARD2_0
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static byte[,] MultiplyAndAdd(this byte[,] a, byte b, byte[,] c, byte[,] result)
        {
            check<byte, byte, byte, byte>(a: a, b: b, c: c, result: result);
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                    result[i, j] = (byte)((byte)(a[i, j]) * b + (byte)(c[i, j]));

            return result;
        }

        #endregion



        #region Matrix matrix

        /// <summary>
        ///   Multiplies a matrix <c>A</c> with a scalar <c>b</c> and accumulates with <c>c</c>.
        /// </summary>
        /// 
        /// <param name="a">The matrix <c>A</c>.</param>
        /// <param name="b">The scalar <c>b</c>.</param>
        /// <param name="c">The matrix <c>c</c>.</param>
        /// <param name="result">The matrix where the result should be stored. Pass the same
        ///   matrix as one of the arguments to perform the operation in place.</param>
        /// 
#if NET45 || NET46 || NET462 || NETSTANDARD2_0
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static decimal[][] MultiplyAndAdd(this decimal[][] a, decimal b, decimal[][] c, decimal[][] result)
        {
            check<decimal, decimal, decimal, decimal>(a: a, b: b, c: c, result: result);
            for (int i = 0; i < result.Length; i++)
                for (int j = 0; j < result[i].Length; j++)
                    result[i][j] = (decimal)((decimal)(a[i][j]) * b + (decimal)(c[i][j]));

            return result;
        }

        /// <summary>
        ///   Multiplies a matrix <c>A</c> with a scalar <c>b</c> and accumulates with <c>c</c>.
        /// </summary>
        /// 
        /// <param name="a">The matrix <c>A</c>.</param>
        /// <param name="b">The scalar <c>b</c>.</param>
        /// <param name="c">The matrix <c>c</c>.</param>
        /// <param name="result">The matrix where the result should be stored. Pass the same
        ///   matrix as one of the arguments to perform the operation in place.</param>
        /// 
#if NET45 || NET46 || NET462 || NETSTANDARD2_0
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static decimal[,] MultiplyAndAdd(this decimal[,] a, decimal b, decimal[,] c, decimal[,] result)
        {
            check<decimal, decimal, decimal, decimal>(a: a, b: b, c: c, result: result);
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                    result[i, j] = (decimal)((decimal)(a[i, j]) * b + (decimal)(c[i, j]));

            return result;
        }

        #endregion


#pragma warning restore 1591
    }
}
