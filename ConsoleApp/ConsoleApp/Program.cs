string target = Console.ReadLine().Trim();
int cnt = int.Parse(Console.ReadLine().Trim());
string[] words = null;
bool targetFound = false;
for (int i = 0; i < cnt; i++)
{
    targetFound = false;
    words = Console.ReadLine().Trim().Split();
    foreach (string ward in words)
    {
        if (ward.Contains(target)) targetFound = true; 
    }
    Console.WriteLine(targetFound ? "Yes" : "No");
}