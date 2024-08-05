
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Chuong5
{
    internal class Program
    {
        public static Item[] itemList = new Item[100];
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            //b1
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine($"nhap thong tin san pham {i+1}");
            //    itemList[i] = new Item();
            //    itemList[i].input();
            //}

            //Console.WriteLine("Danh sach san pham");
            //double total = 0;
            //for (int i = 0; i < 2; i++)
            //{
            //    itemList[i].output();
            //    total += (itemList[i].Price * itemList[i].Quantity);
            //}
            //Console.WriteLine($"Tong gia tri: {total}");


            //c2 dung List

            //List<Item> items = new List<Item>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Nhập thông tin sản phẩm {i + 1}:");
            //    Item item = new Item();
            //    Console.Write("Mã số: ");
            //    item.Id = Console.ReadLine();
            //    Console.Write("Tên hàng: ");
            //    item.Name = Console.ReadLine();
            //    Console.Write("Giá: ");
            //    item.Price = double.Parse(Console.ReadLine());
            //    Console.Write("Số lượng: ");
            //    item.Quantity = int.Parse(Console.ReadLine());
            //    items.Add(item);
            //}

            //double totalValue = 0;
            //Console.WriteLine("\nDanh sách sản phẩm:");
            //foreach (Item item in items)
            //{
            //    Console.WriteLine($"{item.Name}: {item.Quantity} x {item.Price} = {item.TotalValue()} VND");
            //    totalValue += item.TotalValue();
            //}

            //Console.WriteLine($"\nTổng giá trị của kho hàng: {totalValue} VND");


            //b2

            //double[] scores = new double[5];
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"Nhập điểm của sinh viên thứ {i + 1}: ");
            //    scores[i] = double.Parse(Console.ReadLine());
            //}
            //double temp;
            //for (int i = 0; i < scores.Length-1; i++)
            //{
            //    for (int j = i+1; j < scores.Length; j++)
            //    {
            //        if (scores[i] < scores[j])
            //        {
            //            temp = scores[i];
            //            scores[i] = scores[j];
            //            scores[j] = temp;

            //        }

            //    }

            //}

            //c2
            //Array.Sort(scores);
            //Array.Reverse(scores);

            //Console.WriteLine("\nDanh sách điểm từ cao xuống thấp:");
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"Sinh viên {i + 1}: {scores[i]} điểm");
            //}


            //b3


            //List<CD> cds = new List<CD>();
            //int choice;
            //do
            //{
            //    Console.WriteLine("\nMenu");
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine("1. Add CD");
            //    Console.WriteLine("2. Search CD");
            //    Console.WriteLine("3. Display catalog");
            //    Console.WriteLine("4. Exit");
            //    Console.Write("Your choice: ");
            //    choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            if (cds.Count >= 1000)
            //            {
            //                Console.WriteLine("Không thể thêm đĩa CD mới vì đã đạt đến giới hạn.");
            //            }
            //            else
            //            {
            //                CD cd = new CD();
            //                Console.Write("CD Name: ");
            //                cd.CDName = Console.ReadLine();
            //                Console.Write("CD Type: ");
            //                cd.CDType = Console.ReadLine();
            //                Console.Write("CD Price: ");
            //                cd.CDPrice = double.Parse(Console.ReadLine());
            //                cds.Add(cd);
            //            }
            //            break;
            //        case 2:
            //            Console.Write("Nhập tên CD cần tìm: ");
            //            string searchName = Console.ReadLine();
            //            CD foundCD = cds.Find(cd => cd.CDName.Equals(searchName, StringComparison.OrdinalIgnoreCase));
            //            if (foundCD != null)
            //            {
            //                Console.WriteLine($" {foundCD.CDName}, Type: {foundCD.CDType}, Price: {foundCD.CDPrice} VND");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Không tìm thấy CD.");
            //            }
            //            break;
            //        case 3:
            //            Console.WriteLine("\nCatalog CD hiện có:");
            //            Console.WriteLine("CD No. \tCD Name \tCD Type \tCD Price");
            //            for (int i = 0; i < cds.Count; i++)
            //            {
            //                Console.WriteLine($"{i + 1} \t{cds[i].CDName} \t{cds[i].CDType} \t{cds[i].CDPrice} VND");
            //            }
            //            break;
            //        case 4:
            //            return;
            //        default:
            //            Console.WriteLine("Lựa chọn không hợp lệ.");
            //            break;
            //    }
            //} while (true);


            //c2
            CD[] cdList = new CD[1000];
            int choice;
            int cdCount = 0;
            do
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1. Add CD");
                Console.WriteLine("2. Search CD");
                Console.WriteLine("3. Display catalog");
                Console.WriteLine("4. Exit");
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        // add CD
                        Console.WriteLine("moi ban nhap so dia cd can them");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            cdList[i] = new CD();
                            Console.WriteLine("moi ban nhap cd name");
                            cdList[i].CDName = Console.ReadLine();
                            Console.WriteLine("moi ban nhap cd type");
                            cdList[i].CDType = Console.ReadLine();
                            Console.WriteLine("moi ban nhap cd price");
                            cdList[i].CDPrice = double.Parse(Console.ReadLine());
                            cdCount++;
                        }

                        break;
                    case 2:

                        Console.Write("Nhập tên CD cần tìm: ");
                        string searchName = Console.ReadLine();
                        for (int i = 0; i < cdCount; i++)
                        {
                            bool found = cdList[i].CDName.Equals(searchName);
                            if (found)
                            {
                                Console.WriteLine($"CD name: {cdList[i].CDName}\t cdType: {cdList[i].CDType}\t cdPrice: {cdList[i].CDPrice} " );
                            }
                            else
                            {
                                Console.WriteLine("khong tim thay");
                            }
                        }
                        break;
                     
                    case 3:
                        // hien thi cd
                        Console.WriteLine("Danh sach CD hien co");
                        Console.WriteLine("CD No. \t CD Name \tCD Type \tCD Price");
                        for (int i = 0; i < cdCount; i++)
                        {
                            Console.WriteLine($" {i + 1} \t {cdList[i].CDName} \t {cdList[i].CDType} \t {cdList[i].CDPrice}");
                        }
                        break;
                    case 4:
                        return;

                    default:
                        Console.WriteLine("moi ban nhap lai");
                        break;
                }

            } while (true);

        }
    }
}
