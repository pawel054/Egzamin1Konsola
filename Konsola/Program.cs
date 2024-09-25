namespace Konsola
{
    internal class Program
    {
        public static List<AlbumObject> albumData = new List<AlbumObject>();
        static void Main(string[] args)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data.txt");
            LoadDataFromFile(filePath);
            DisplayData(albumData);
        }

        private static void LoadDataFromFile(string filePath)
        {
            List<string> data = new List<string>();
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        data.Add(line);
                    }
                }

                for(int i = 0; i < data.Count; i += 5)
                {
                    AlbumObject album = new AlbumObject
                    {
                        Artist = data[i],
                        Album = data[i + 1],
                        SongsNumber = int.Parse(data[i + 2]),
                        Year = int.Parse(data[i + 3]),
                        DownloadNumber = int.Parse(data[i+4])
                    };

                    albumData.Add(album);
                }
            }
        }

        private static void DisplayData(List<AlbumObject> albumObjects)
        {
            foreach(AlbumObject albumObject in albumObjects)
            {
                Console.WriteLine($"{albumObject.Artist}");
                Console.WriteLine($"{albumObject.Album}");
                Console.WriteLine($"{albumObject.SongsNumber}");
                Console.WriteLine($"{albumObject.Year}");
                Console.WriteLine($"{albumObject.DownloadNumber}\n");
            }
        }
    }
}
