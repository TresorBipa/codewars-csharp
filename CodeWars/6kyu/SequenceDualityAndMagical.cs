/*
https://www.codewars.com/kata/6146a6f1b117f50007d44460/csharp

6 kyu
Sequence Duality and "Magical" Extrapolation (Binomial Transform)

The goal of this Kata is to build a very simple, yet surprisingly powerful algorithm to extrapolate sequences of numbers* (* in fact, it would work with literally any "[sequence of] objects that can be added and subtracted"!)

This will be achieved by using a little Mathematical "trick" (Binomial Transform), which will be explained below; and by splitting the problem into 3 (simpler) tasks:

Task1: Build a function delta(), which will take a number sequence (list) as an input and return the differences of its successive terms (see below for further explanation)

Task2: Build a function dual_seq(), which will take a number sequence (list) and return its "Dual" (Binomial Transform; see information below)

Task3: Finally, build a function extra_pol(), which will take a number sequence (list), as well as a positive integer "n" and return the sequence completed by the "n" following terms, according to the "best possible polynomial extrapolation" (don't worry: the code for this part should actually be (much) shorter than this sentence! ;) )

Some Theory:

Differences

Let (x_0, x_1, x_1, ..., x_{n-1}, x_n) be a finite sequence of length n+1, one can compute its successive differences in the following way: (x_0 - x_1, x_1 - x_2, ..., x_{n-1}-x_{n}), which will -obviously- be of length n . (This is what your function delta() will be expected to do!)
Dual Sequence (Binomial Transform)

By iterating the process, one can compute its Binomial Transform, which will be given by: (y_0, y_1, ..., y_n), where:
y0=x0y1=x0−x1y2=(x0−x1)−(x1−x2)=x0−2x1+x2y3=(x0−2x1+x2)−(x1−2x2+x3)=x0−3x1+3x2−x3y4=(x0−3x1+3x2−x3)−(x1−3x2+3x3−x4)=x0−4x1+6x2−4x3+x4etcetc...y_0 = x_0 \\ y_1 = x_0 - x_1 \\ y_2 = (x_0 - x_1) - (x_1 - x_2) = x_0 - 2x_1 + x_2 \\ y_3 = (x_0 - 2x_1 + x_2) - (x_1 - 2x_2 + x_3) = x_0 - 3x_1 + 3x_2 -x_3 \\ y_4 = (x_0 - 3x_1 + 3x_2 -x_3) - (x_1 - 3x_2 + 3x_3 -x_4) \\ \quad = x_0 - 4x_1 + 6x_2 - 4x_3 +x_4 \\ etc \quad etc...y 
0
​
 =x 
0
​
 
y 
1
​
 =x 
0
​
 −x 
1
​
 
y 
2
​
 =(x 
0
​
 −x 
1
​
 )−(x 
1
​
 −x 
2
​
 )=x 
0
​
 −2x 
1
​
 +x 
2
​
 
y 
3
​
 =(x 
0
​
 −2x 
1
​
 +x 
2
​
 )−(x 
1
​
 −2x 
2
​
 +x 
3
​
 )=x 
0
​
 −3x 
1
​
 +3x 
2
​
 −x 
3
​
 
y 
4
​
 =(x 
0
​
 −3x 
1
​
 +3x 
2
​
 −x 
3
​
 )−(x 
1
​
 −3x 
2
​
 +3x 
3
​
 −x 
4
​
 )
=x 
0
​
 −4x 
1
​
 +6x 
2
​
 −4x 
3
​
 +x 
4
​
 
etcetc...
(notice the binomial coefficients)

The Binomial transform possesses several useful properties; including:

linearity : if a pointwise sum were defined on the sequences (NB: you are obviously NOT asked to implement this), we could easily see that dual_seq(A+B) = dual_seq(A)+dual_seq(B)
involution: as the name dual suggests, it is always true that dual_seq(dual_seq(A)) = A (this is not only "elegant" but also very useful!)
finally, it might be useful to notice that this tranform behaves in a particular way on polynomials: indeed, if a sequence (x_n) is obtained from a polynomial p of degree d i.e. such that
∀n,xn=p(n)\forall n, \quad x_n = p(n)∀n,x 
n
​
 =p(n)
then it follows that its Dual (Binomial Transform) will be of the form:
y0,y1,y2,...yd,0,0,0,0,...y_0, y_1, y_2, ... y_d, 0, 0, 0, 0, ...y 
0
​
 ,y 
1
​
 ,y 
2
​
 ,...y 
d
​
 ,0,0,0,0,...
(i.e. only zeros after the term y_d)
Polynomial values

Given a sequence (x_0, x_1, ..., x_d) of d+1 points, there exists a unique polynomial p_d of degree (not higher than) d, which passes successively through those points; i.e. such that
pd(0)=x0,pd(1)=x1,...,pd(d)=xdp_{d}(0) = x_0, \quad p_{d}(1) = x_1, \quad ..., \quad p_{d}(d) = x_dp 
d
​
 (0)=x 
0
​
 ,p 
d
​
 (1)=x 
1
​
 ,...,p 
d
​
 (d)=x 
d
​
 
It is with respect to this polynomial that your function extra_pol is supposed to extrapolate: in other words, it will take:
(x0,x1,...,xd)(x_0, x_1, ..., x_d)(x 
0
​
 ,x 
1
​
 ,...,x 
d
​
 )
as well as a parameter n and return:
(x0,x1,...,xd,pd(d+1),pd(d+2),...,pd(d+n))(x_0, x_1, ..., x_d, p_{d}(d+1), p_{d}(d+2), ..., p_{d}(d+n))(x 
0
​
 ,x 
1
​
 ,...,x 
d
​
 ,p 
d
​
 (d+1),p 
d
​
 (d+2),...,p 
d
​
 (d+n))
(Again, don't worry: the description is quite long but the code should be quite short! ;) )

Some Examples

delta()

Delta(new int[] {17, 12}) // new int[] {5}
Delta(new int[] {1, 4, 9, 16, 25}) // new int[] {-3, -5, -7, -9}
Delta([new int[] {1, -2, 4, -8, 16, -32}) // new int[] {3, -6, 12, -24, 48}
dual_seq()

DualSeq(new int[] {1}) //returns new int[] {1}
DualSeq(new int[] {1,2,3,4,5}) //returns new int[] {1, -1, 0, 0, 0}
DualSeq(new int[] {1, -1, 0, 0, 0}) //returns new int[] {1, 2, 3, 4, 5}
DualSeq(new int[] {2,4,6,8,10}) //returns new int[] {2, -2, 0, 0, 0}
DualSeq(new int[] {1,3,5,7,9}) //returns new int[] {1, -2, 0, 0, 0}
DualSeq(new int[] {1,1,1,1,1}) //returns new int[] {1, 0, 0, 0, 0}
DualSeq(new int[] {1, 0, 0, 0, 0}) //returns new int[] {1, 1, 1, 1, 1}
DualSeq(new int[] {1, 4, 9, 16, 25, 36, 49}) //returns new int[] {1, -3, 2, 0, 0, 0, 0}
DualSeq(new int[] {1, -3, 2, 0, 0, 0, 0}) //return new int[] {1, 4, 9, 16, 25, 36, 49}
DualSeq(new int[] {1, -3, 2}) //returns new int[] {1, 4, 9}
DualSeq(new int[] {8, 27, 64, 125, 216}) //returns new int[] {8, -19, 18, -6, 0}
DualSeq(new int[] {1,2,4,8,16,32,64,128,256}) //returns new int[] {1, -1, 1, -1, 1, -1, 1, -1, 1}
DualSeq(new int[] {1, -1, 1, -1, 1, -1, 1, -1, 1}) //returns new int[] {1, 2, 4, 8, 16, 32, 64, 128, 256}
DualSeq(new int[] {1, 1, 2, 3, 5, 8, 13, 21}) //returns new int[] {1, 0, 1, 1, 2, 3, 5, 8}
DualSeq(new int[] {0, 1, 1, 2, 3, 5, 8, 13, 21}) //returns new int[] {0, -1, -1, -2, -3, -5, -8, -13, -21}
extra_pol()

ExtraPol(new int[] {1},0) //returns new int[] {1}
ExtraPol(new int[] {1},5) //returns new int[] {1, 1, 1, 1, 1, 1}
ExtraPol(new int[] {1,4},5) //returns new int[] {1, 4, 7, 10, 13, 16, 19}
ExtraPol(new int[] {1,4,9},5) //returns new int[] {1, 4, 9, 16, 25, 36, 49, 64}
ExtraPol(new int[] {4,16,36},5) //returns new int[] {4, 16, 36, 64, 100, 144, 196, 256}
ExtraPol(new int[] {216, 125 ,64 ,27},7) //returns new int[] {216, 125, 64, 27, 8, 1, 0, -1, -8, -27, -64}
Note: The number sequences will be given by non-empty* lists; (* but possibly of size 1) ((lists in the case of Python; other languages may use (dynamic) Arrays (JavaScript,Ruby), sequences (Nim), vectors (R) etc, but the context (Description and Solution Setup) should make it clear enough... ))
*/


using System;
using System.Linq;

namespace CodeWars
{
    public static class SequenceDualityAndMagical
    {
        public static int[] Delta(int[] seq)
        {
            return seq[1..].Select((x, i) => seq[i] - x).ToArray();
        }

        public static int[] DualSeq(int[] seq)
        {
            return seq.Length > 1 ? new[] {seq[0]}.Concat(DualSeq(Delta(seq))).ToArray() : seq.ToArray();
        }

        public static int[] ExtraPol(int[] seq, int n)
        {
            return DualSeq(DualSeq(seq).Concat(new int[n]).ToArray());
        }
    }
}