/* 
Данныйм методом я воспользовался с http://habrahabr.ru/post/83303/
т.к. это быстрей работает чем рекурсия
*/

namespace EighthTask
{
    class EighthTaskProg
    {
        private static readonly mtx2x2 fibMtx = new mtx2x2
        {
            _11 = 1,
            _12 = 1,
            _21 = 1
        };

        private static readonly mtx2x2 identity = new mtx2x2
        {
            _11 = 1,
            _22 = 1
        };

        public struct mtx2x2
        {
            public ulong _11, _12, _21, _22;
            public static mtx2x2 operator *(mtx2x2 lhs, mtx2x2 rhs)
            {
                return new mtx2x2
                {
                    _11 = lhs._11 * rhs._11 + lhs._12 * rhs._21,
                    _12 = lhs._11 * rhs._12 + lhs._12 * rhs._22,
                    _21 = lhs._21 * rhs._11 + lhs._22 * rhs._21,
                    _22 = lhs._21 * rhs._12 + lhs._22 * rhs._22
                };
            }
        }

        public static mtx2x2 IntPower(mtx2x2 x, short power)
        {
            if (power == 0)
                return identity;

            if (power == 1)
                return x;

            int n = 15;
            while ((power <<= 1) >= 0) n--;

            mtx2x2 tmp = x;
            while (--n > 0)
                tmp = (tmp * tmp) * (((power <<= 1) < 0) ? x : identity);

            return tmp;
        }

        public static ulong fibm(short n)
        {
            return IntPower(fibMtx, (short)(n - 1))._11;
        }

    }
}
