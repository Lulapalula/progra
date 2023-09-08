using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone SamsungS23 = new SmartPhone();

            //Network
            SamsungS23.Technology = "CSM / CDMA /HSPA / EVDO / LTE / 5G";

            //Launch
            SamsungS23.Announced = "2023, February 01";
            SamsungS23.Status = "Available. Released 2023, February 17";

            //Body
            SamsungS23.DimensionAlto = 163.4;
            SamsungS23.DimensionAncho = 78.1;
            SamsungS23.DimensionLargo = 8.9;
            SamsungS23.Weight = 234g;
            SamsungS23.Build = "Glass front (Gorilla Glass Victus 2), glass back (Gorilla Glass Victus 2), aluminum frame";
            SamsungS23.SIM = "Nano-SIM and eSIM or Dual SIM (2 Nano-SIMs and eSIM, dual stand-by) " +
                "IP68 dust/ water resistant(up to 1.5m for 30 min)Armor aluminum frame with tougher drop and " +
                "scratch resistance(advertised) Stylus(Bluetooth integration, accelerometer, gyro)";

            //Display
            SamsungS23.Type = "Dynamic AMOLED 2X, 120Hz, HDR10+, 1200 nits (HBM), 1750 nits (peak)";
            SamsungS23.Size = "6.8 inches, 114.7 cm2 (~89.9% screen-to-body ratio)";
            SamsungS23.ResoAlto = 1440;
            SamsungS23.ResoAncho = 3088;
            SamsungS23.Protection = "Corning Gorilla Glass Victus 2";

            //Platform 
            SamsungS23.OS = "Android 13, One UI 5.1";
            SamsungS23.Chipset = "Qualcomm SM8550-AC Snapdragon 8 Gen 2 (4 nm)";
            SamsungS23.CPU = "Octa-core (1x3.36 GHz Cortex-X3 & 2x2.8 GHz Cortex-A715 & 2x2.8 GHz Cortex-A710 & 3x2.0 GHz Cortex-A510)";
            SamsungS23.GPU = "Adreno 740";

            //Memory
            SamsungS23.CardSlot = false;
            SamsungS23.InternalMemory = 256;
            SamsungS23.InternalRAM = 12;

            //MainCamera
            SamsungS23.Quad = "200 MP, f/1.7, 24mm (wide), 1/1.3, 0.6µm, multi - directional PDAF, Laser AF, OIS " +
                "10 MP, f / 4.9, 230mm(periscope telephoto), 1 / 3.52, 1.12µm, Dual Pixel PDAF, OIS, 10x optical zoom " +
                "10 MP, f / 2.4, 70mm(telephoto), 1 / 3.52, 1.12µm, Dual Pixel PDAF, OIS, 3x optical zoom " +
                "12 MP, f / 2.2, 13mm, 120˚ (ultrawide), 1 / 2.55, 1.4µm, Dual Pixel PDAF, Super Steady video";
            SamsungS23.Features = "LED flash, auto-HDR, panorama";
            SamsungS23.VideoMC = "8K@24/30fps, 4K@30/60fps, 1080p@30/60/240fps, 1080p@960fps, HDR10+, stereo sound rec., gyro-EIS";

            //selfie camera
            SamsungS23.Single = "12 MP, f/2.2, 26mm (wide), Dual Pixel PDAF";
            SamsungS23.Caracteristicas = "Dual video call, Auto-HDR, HDR10+";
            SamsungS23.VideoSC = "4K@30 / 60fps, 1080p@30fps";

            //Sound 
            SamsungS23.LoudSpeaker = "Yes, with stereo speakers";
            SamsungS23.Jack = false;

            //COOMS
            SamsungS23.WLAN = "Wi-Fi 802.11 a/b/g/n/ac/6e, tri-band, Wi-Fi Direct";
            SamsungS23.Bluetooth = 5.3;
            SamsungS23.Positioning = "GPS, GLONASS, BDS, GALILEO";
            SamsungS23.NFC = true;
            SamsungS23.Radio = false;
            SamsungS23.USB = "USB Type-C 3.2, OTG";

            //Features 
            SamsungS23.Sensors = "Fingerprint(under display, ultrasonic), accelerometer, gyro, proximity, compass, barometer " +
                "Samsung DeX, Samsung Wireless DeX(desktop experience support) Bixby natural language commands and dictation " +
                "Samsung Pay(Visa, MasterCard certified) " +
                "Ultra Wideband(UWB) support";

            //Battery
            SamsungS23.Type = "Li-Ion 5000 mAh, non-removable";
            SamsungS23.Charging = "45W wired, PD3.0, 65% in 30 min (advertised) " +
                "15W wireless(Qi/ PMA) " +
                "4.5W reverse wireless";

            //Misc
            SamsungS23.Colors = "Phantom Black, Green, Cream, Lavender, Graphite, Sky Blue, Lime, Red, BMW M Edition";
            SamsungS23.Models = "SM-S918B, SM-S918B/DS, SM-S918U, SM-S918U1, SM-S918W, SM-S918N, SM-S9180, SM-S918E, SM-S918E/DS";
            SamsungS23.SAR = "1.12 W/kg (head)     0.92 W/kg (body";
            SamsungS23.SAREU = "0.96 W/kg (head)     1.40 W/kg (body";
            SamsungS23.Price = "$ 852.00 / € 1,105.00 / £ 879.97 / ₹ 107,970";

            //Tests
            SamsungS23.Performance = "AnTuTu: 1241531 (v9) " +
                "GeekBench: 4927(v5.1) " +
                "GFXBench: 67fps(ES 3.1 onscreen)";
            SamsungS23.Display = "Contrast ratio: Infinite (nominal)";
            SamsungS23.Camera = "Photo / Video";
            SamsungS23.LoudSpeaker = "-25.6 LUFS";
            SamsungS23.BatteryLife = "Endurance rating 126h";


        }
    }
}
