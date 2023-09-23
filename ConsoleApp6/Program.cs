namespace ns
{
    class Tclass
    {
        public static void Main()
        {
            var codec1 = new Mp3();
            var codec2 = new Mp4();
            var codec3 = new Avi();

            var file = new File() { data = new byte[] { }, type = "Mp3" };

            var VPC = new VideoPlayerService();
            VPC.AddCodeс(codec1);
            VPC.AddCodeс(codec2);
            VPC.AddCodeс(codec3);

            VPC.PlayFile(file);

            VPC.RemoveCodec(codec2);
        }
    }

    public interface IVideoCodec
    {

        public string[] availableTypes { get; set; }
        DecodedFile Decode(File f);

        void Play(DecodedFile f);
    }

    public class File
    {
        public string type;

        public byte[] data;
    }

    public class DecodedFile
    {
        public string type;

        public byte[] data;
    }

    public class Mp3 : IVideoCodec
    {
        public string[] availableTypes { get => throw new NotImplementedException(); set => availableTypes = new string[] { "Mp3" }; }

        public DecodedFile Decode(File f)
        {
            throw new NotImplementedException();
        }

        public void Play(DecodedFile f)
        {
            throw new NotImplementedException();
        }
    }

    public class Mp4 : IVideoCodec
    {
        public string[] availableTypes { get => throw new NotImplementedException(); set => availableTypes = new string[] { "Mp4" }; }

        public DecodedFile Decode(File f)
        {
            throw new NotImplementedException();
        }

        public void Play(DecodedFile f)
        {
            throw new NotImplementedException();
        }
    }

    public class Avi : IVideoCodec
    {
        public string[] availableTypes { get => throw new NotImplementedException(); set => availableTypes = new string[] { "Avi" }; }

        public DecodedFile Decode(File f)
        {
            throw new NotImplementedException();
        }

        public void Play(DecodedFile f)
        {
            throw new NotImplementedException();
        }
    }

    public class VideoPlayerService
    {
        List<IVideoCodec> videoCodecs = new List<IVideoCodec>();
        public void AddCodeс(IVideoCodec vc)
        {
            videoCodecs.Add(vc);
        }

        public void RemoveCodec(IVideoCodec vc)
        {
            videoCodecs.Remove(vc);
        }

        public void PlayFile(File file)
        {
            switch (file.type)
            {
                case "Mp3":
                    {
                        var codec = videoCodecs.FirstOrDefault(pr => pr.availableTypes.Contains("Mp3"));
                        if (codec != null)
                        {
                            var decodedFile = codec.Decode(file);
                            if (decodedFile != null)
                            {
                                codec.Play(decodedFile);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No available codec for this file was found");
                        }
                        break;
                    }
                case "Mp4":
                    {
                        var codec = videoCodecs.FirstOrDefault(pr => pr.availableTypes.Contains("Mp4"));
                        if (codec != null)
                        {
                            var decodedFile = codec.Decode(file);
                            if (decodedFile != null)
                            {
                                codec.Play(decodedFile);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No available codec for this file was found");
                        }
                        break;
                    }
                case "Avi":
                    {
                        var codec = videoCodecs.FirstOrDefault(pr => pr.availableTypes.Contains("Avi"));
                        if (codec != null)
                        {
                            var decodedFile = codec.Decode(file);
                            if (decodedFile != null)
                            {
                                codec.Play(decodedFile);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No available codec for this file was found");
                        }
                        break;
                    }
            }
        }
    }
}