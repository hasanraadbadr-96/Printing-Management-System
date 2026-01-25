using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;        // هنا نستخدم مكتبة خاصة بالأصوات
using System.Windows.Forms; // حتى نكدر نعرض رسالة خطأ إذا يصير شي
using NAudio.Wave; // هذا نخليه حتى نكدر نستعمل مكتبة تشغيل الصوت

namespace ETEZAN2024.forms_And_Contrls.GlobalClasses
{
    public static class clsAlertSoundPlayer
    {
        // نخزن بيه تشغيل الصوت حتى نكدر نوقفه بعدين إذا نريد
        private static WaveOutEvent output;

        // نخزن بيه ملف الصوت حتى نكدر نقراه
        private static AudioFileReader audio;

        public static void PlayMp3(string soundPath)
        {
            try
            {
                // اذا اكو صوت جان مشتغل قبل، نوقفه — حتى ما يتداخل الصوتين
                output?.Stop();

                // هنا نكول للبرنامج: هذا ملف الصوت اللي نريد نقراه
                audio = new AudioFileReader(soundPath);

                // هذا المسؤول عن تشغيل الصوت فعلياً
                output = new WaveOutEvent();

                // نخلي جهاز التشغيل يتعرف على ملف الصوت
                output.Init(audio);

                // هسه نشغل الصوت
                output.Play();
            }
            catch (Exception ex)
            {
                // اذا صار خطأ مثل مسار غلط — نعرض رسالة للمستخدم
                MessageBox.Show(
                    "ما قدر يشغل الصوت — يمكن المسار غلط او الملف ممسوح\n\n" + ex.Message,
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // دالة توقف الصوت
        public static void Stop()
        {
            try
            {
                // اذا اكو صوت جان مشتغل
                if (output != null)
                {
                    output.Stop();  // نوقف التشغيل
                    output.Dispose(); // ننظف الجهاز
                    output = null;   // نفرغ المتغير
                }

                if (audio != null)
                {
                    audio.Dispose(); // ننظف الملف
                    audio = null;   // نفرغ المتغير
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "ما قدر يوقف الصوت\n\n" + ex.Message,
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
