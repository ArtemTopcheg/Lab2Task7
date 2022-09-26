//Task7
int k = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[k];
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < nums.Length; i++)
{
    Console.Write(nums[i]+" ");
}
Console.WriteLine('\n' + "Новый массив");
int temp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] < nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
for (int i = 0; i < nums.Length; i++)
{
    Console.Write(nums[i]+" ");
}