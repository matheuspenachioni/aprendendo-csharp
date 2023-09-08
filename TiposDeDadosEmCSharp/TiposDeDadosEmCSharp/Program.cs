
namespace TiposDeDadosEmCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte var1 = 100;
            short var2 = 100;
            int var3 = 100;
            long var4 = 100;
            byte var5 = 100;
            ushort var6 = 100;
            uint var7 = 100;
            ulong var8 = 100;

            float var9 = 100.50f;
            double var10 = 100.50;
            decimal var11 = 100.50m;

            char var12 = 'a';
            string var13 = "abcdef";

            bool var14 = true;

            object var15 = 100.50f;
            object var16 = 100.50m;
            object var17 = "abcdef";
            object var18 = true;

            Console.WriteLine("Teste:\n\n"+ var1 +"\n"+ var9 +"\n"+ var11 +"\n"+ var12 +"\n"+ var13 +"\n"+ var14);

        }
    }
}