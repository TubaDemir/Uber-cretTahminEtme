using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcretTahminEtme
{
    class Program
    {
        public static float fareEstimator(int rtime, int rdist, float costPerMin, float costPerMile)
        {
            return (costPerMin * rtime) + (costPerMile * rdist);

        }
        static void Main(string[] args)
        {
            float[] costPerMinute = { 0.2f, 0.35f, 0.4f, 0.45f };
            float[] costPerMile = { 1.1f, 1.8f, 2.3f, 3.5f };
            float[] tahminiSonuc = new float[4];
            int rideTime, rideDistance;
            float sonuc;
            bool durum = false;
            do
            {
                Console.WriteLine("Yaklaşık seyahat uzaklığını giriniz");
                rideDistance = Convert.ToInt32(Console.ReadLine());
                if (rideDistance >= 5 && rideDistance <= 20)
                {
                    do
                    {
                        Console.WriteLine("Tahmini seyahat süresini giriniz");
                        rideTime = Convert.ToInt32(Console.ReadLine());
                        if (rideTime >= 10 && rideTime <= 50)
                        {
                            for (int i = 0; i < costPerMile.Length; i++)
                            {
                                sonuc = fareEstimator(rideTime,rideDistance, costPerMinute[i],costPerMile[i]);
                                tahminiSonuc[i] = sonuc;
                            }
                            for (int i = 0; i < tahminiSonuc.Length; i++)
                            {
                                Console.Write("{0}  ",tahminiSonuc[i]);
                            }
                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine("Hatalı giriş yaptınız");
                            durum = false;
                            continue;
                        }

                    } while (durum != true);
                   
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız");
                    durum = false;
                    continue;
                }

            } while (durum != true);
        }
    }
}
