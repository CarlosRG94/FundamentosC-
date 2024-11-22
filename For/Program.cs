// See https://aka.ms/new-console-template for more information
string[] num = new string[9]
{
   "cero","uno","dos","tres","cuatro","cinco","seis","siete","ocho"
};
for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine(num[i]);
}
bool n = true;
for (int a = 0; a < 8 && n; a++)
{
    Console.WriteLine("Entra si es verdad");
}
