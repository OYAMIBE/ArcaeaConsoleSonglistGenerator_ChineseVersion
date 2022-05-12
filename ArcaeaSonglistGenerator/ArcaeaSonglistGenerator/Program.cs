using System;

namespace ArcaeaSonglistGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arcaea songlist 生成器（中文版）");
            Console.WriteLine("歌曲id：");
            string id = Console.ReadLine();
            Console.WriteLine("歌曲标题：");
            string title = Console.ReadLine();
            Console.WriteLine("曲师：");
            string artist = Console.ReadLine();
            Console.WriteLine("显示bpm：");
            string Viewbpm = Console.ReadLine();
            Console.WriteLine("基础bpm：");
            string basebpm = Console.ReadLine();
            Console.WriteLine("所属曲包：");
            string set = Console.ReadLine();
            Console.WriteLine("预览开始时间（ms）：");
            string preview = Console.ReadLine();
            Console.WriteLine("预览结束时间（ms）：");
            string previewend = Console.ReadLine();
            Console.WriteLine("曲目侧（0为光芒侧，1为纷争侧）：");
            string side = Console.ReadLine();
            Console.WriteLine("曲目背景：");
            string bg = Console.ReadLine();
            Console.WriteLine("曲目加入日期（九位时间戳）：");
            string date = Console.ReadLine();
            Console.WriteLine("曲目加入版本：");
            string version = Console.ReadLine();
            Console.WriteLine("画师：");
            string jacketdesigner = Console.ReadLine();
            Console.WriteLine("谱师：");
            string chartdesigner = Console.ReadLine();
            Console.WriteLine("分别输入难度（Ftr，Prs，Pst，Byd）：");
            string ftrdiff = Console.ReadLine();
            string prsdiff = Console.ReadLine();
            string pstdiff = Console.ReadLine();
            string byddiff = Console.ReadLine();
            Console.WriteLine("是否需要书写Beyond难度？\n（Yes/no）");
            string judgment = Console.ReadLine();
            if (judgment == "Yes")
            {
                Console.WriteLine("{");
                Console.WriteLine("  \"id\": " + id);
                Console.WriteLine("  \"title_localized\": {");
                Console.WriteLine("    \"en\": " + title);
                Console.WriteLine("  },");
                Console.WriteLine("  \"artist\": " + artist);
                Console.WriteLine("  \"bpm\": " + Viewbpm);
                Console.WriteLine("  \"bpm_base\": " + basebpm);
                Console.WriteLine("  \"set\": ");
                Console.WriteLine("  \"purchase\": ");
                Console.WriteLine("  \"audioPreview\": " + preview);
                Console.WriteLine("  \"audioPreviewEnd\": " + previewend);
                Console.WriteLine("  \"side\": " + side);
                Console.WriteLine("  \"bg\": " + bg);
                Console.WriteLine("  \"date\": " + date);
                Console.WriteLine("  \"version\": " + version);
                Console.WriteLine("  \"world_unlock\": false");
                Console.WriteLine("  \"remote_dl\": false");
                Console.WriteLine("  \"difficulties\": [");
                Console.WriteLine("    {");
                Console.WriteLine("      \"ratingClass\" : 0");
                Console.WriteLine("      \"chartDesigner\" : "+ chartdesigner);
                Console.WriteLine("      \"jacketDesigner\" : " + jacketdesigner);
                Console.WriteLine("      \"rating\" : " + pstdiff);
                Console.WriteLine("    },");
                Console.WriteLine("    {");
                Console.WriteLine("      \"ratingClass\" : 1");
                Console.WriteLine("      \"chartDesigner\" : " + chartdesigner);
                Console.WriteLine("      \"jacketDesigner\" : " + jacketdesigner);
                Console.WriteLine("      \"rating\" : " + prsdiff);
                Console.WriteLine("    },");
                Console.WriteLine("    {");
                Console.WriteLine("      \"ratingClass\" : 2");
                Console.WriteLine("      \"chartDesigner\" : " + chartdesigner);
                Console.WriteLine("      \"jacketDesigner\" : " + jacketdesigner);
                Console.WriteLine("      \"rating\" : " + ftrdiff);
                Console.WriteLine("    },");
                Console.WriteLine("    {");
                Console.WriteLine("      \"ratingClass\" : 3");
                Console.WriteLine("      \"chartDesigner\" : " + chartdesigner);
                Console.WriteLine("      \"jacketDesigner\" : " + jacketdesigner);
                Console.WriteLine("      \"rating\" : " + byddiff);
                Console.WriteLine("    }");
                Console.WriteLine("  ]");
                Console.WriteLine("}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("{");
                Console.WriteLine("  \"id\": " + id);
                Console.WriteLine("  \"title_localized\": {");
                Console.WriteLine("    \"en\": " + title);
                Console.WriteLine("  },");
                Console.WriteLine("  \"artist\": " + artist);
                Console.WriteLine("  \"bpm\": " + Viewbpm);
                Console.WriteLine("  \"bpm_base\": " + basebpm);
                Console.WriteLine("  \"set\": ");
                Console.WriteLine("  \"purchase\": ");
                Console.WriteLine("  \"audioPreview\": " + preview);
                Console.WriteLine("  \"audioPreviewEnd\": " + previewend);
                Console.WriteLine("  \"side\": " + side);
                Console.WriteLine("  \"bg\": " + bg);
                Console.WriteLine("  \"date\": " + date);
                Console.WriteLine("  \"version\": " + version);
                Console.WriteLine("  \"world_unlock\": false");
                Console.WriteLine("  \"remote_dl\": false");
                Console.WriteLine("  \"difficulties\": [");
                Console.WriteLine("    {");
                Console.WriteLine("      \"ratingClass\" : 0");
                Console.WriteLine("      \"chartDesigner\" : " + chartdesigner);
                Console.WriteLine("      \"jacketDesigner\" : " + jacketdesigner);
                Console.WriteLine("      \"rating\" : " + pstdiff);
                Console.WriteLine("    },");
                Console.WriteLine("    {");
                Console.WriteLine("      \"ratingClass\" : 1");
                Console.WriteLine("      \"chartDesigner\" : " + chartdesigner);
                Console.WriteLine("      \"jacketDesigner\" : " + jacketdesigner);
                Console.WriteLine("      \"rating\" : " + prsdiff);
                Console.WriteLine("    },");
                Console.WriteLine("    {");
                Console.WriteLine("      \"ratingClass\" : 2");
                Console.WriteLine("      \"chartDesigner\" : " + chartdesigner);
                Console.WriteLine("      \"jacketDesigner\" : " + jacketdesigner);
                Console.WriteLine("      \"rating\" : " + ftrdiff);
                Console.WriteLine("    }");
                Console.WriteLine("  ]");
                Console.WriteLine("}");
                Console.ReadKey();
            }
        }
    }
}
