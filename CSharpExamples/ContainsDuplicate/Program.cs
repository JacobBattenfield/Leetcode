using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Program{
    static void Main(){
        Console.WriteLine(string.Join(", ",TwoSum([3,4,5,6],11)));
        Console.WriteLine(string.Join(",",TwoSum([4,5,6],10)));
        Console.WriteLine(string.Join(",",TwoSum([5,5],10)));
        Console.WriteLine(string.Join(",", TwoSum(new int[] { 2, 7, 11, 15, 23, 42, 54, 78, 90, 33, 21, 44, 56, 67, 89, 12, 34, 23, 45, 66, 88, 99, 13, 25, 37, 49, 61, 73, 85, 97, 31, 46, 58, 63, 75, 82, 94, 18, 29, 41, 53, 64, 76, 87, 92, 19, 32, 48, 59, 62, 74, 81, 93, 16, 27, 38, 50, 68, 72, 84, 96, 20, 30, 47, 57, 65, 77, 91, 98, 14, 26, 39, 51, 60, 71, 80, 95, 17, 28, 40, 52, 69, 79, 83, 100, 5, 6, 3, 8, 1 }, 101)));





    }
    static bool ContainsDuplicate(int[] array){
        List<int> SeenNumbers = [];
        for(int i = 0;i<array.Length;i++){
            if(!SeenNumbers.Contains(array[i])){
                SeenNumbers.Add(array[i]);
            }
        }
        if(SeenNumbers.Count==array.Length){
            return false;
        }else{
            return true;
        }
    }
    static bool ValidAnagram(string s, string t){
        char[] Sarr = s.ToCharArray();
        char[] Tarr = t.ToCharArray();
        Array.Sort(Sarr);
        Array.Sort(Tarr);
        Console.WriteLine(Sarr);
        Console.WriteLine(Tarr);
        return Sarr.SequenceEqual(Tarr);
    }
    static int[] TwoSum(int[]nums,int target){
        int[] coords = new int[2];
        HashSet<int> Visited = [];
        for(int i = 0;i<nums.Length;i++){
            int diff = target-nums[i];
            if(Visited.Contains(diff)){
                coords[0] = Array.IndexOf(nums,diff);
                coords[1] = i;
                return coords;
            }
            Visited.Add(nums[i]);
        }
        return [-1,-1];
    }
}