using System.Text.RegularExpressions;
using System.Collections.Generic;
using static Exercise_3.Song;

namespace Exercise_3
{
    /// <summary>
    /// This is Main class for Exercise_3
    /// 
    /// </summary>
    class Program{
        static void Main(string[] args){
            
            string dataRegex = "^(.*?)_(.*?)_(?:[0-9]|[1-8][0-9]|9[0-9]):(?:[0-5]?[0-9])$";
            //This is regex for verify data
            
            string? temp = System.Console.ReadLine();
            if (temp == null|| temp =="")
            {
                return;
            }

            int? numSongs = int.Parse(temp);// convert string to int
            
            List<Song> songs = new();//Tạo List song

            for (int i = 0; i < numSongs; i++)//vòng lặp dùng để thêm nhạc
            {
                string? data = Console.ReadLine();
                if (data!= null && Regex.IsMatch(data, dataRegex))//kiểm tra data
                {
                    string[] matchData = data.Split("_");//tách data 

                    string type = matchData[0];
                    string name = matchData[1];
                    string time = matchData[2];  

                    Song song = new(type, name, time);//tạo object song mới 

                    songs.Add(song);// thêm song vào list song

                }else{
                    System.Console.Write("Data input error input again: ");// nếu dữ liệu đầu vào lỗi thì nhập lại
                    i--;//giảm vòng lặp do vòng lặp này bị lỗi 
                }    

            }

            string? typeList = Console.ReadLine();//lấy TypeList cần tìm
            // System.Console.WriteLine("________________________");
            if (typeList == "all")//lấy tất cả nhạc
            {
                foreach (Song song in songs)
                {
                    System.Console.WriteLine(song.Name);
                }
                return;
            } 
            foreach (Song song in songs)// lấy theo typeList
            {
                if (song.TypeList==typeList)
                {
                    System.Console.WriteLine(song.Name);
                }
            }
        }
    }
}