using BusinessLayeres;
using System; // مكتبة الأساسيات.
using System.Collections.Generic; // مكتبة القوائم.
using System.ComponentModel; // مكتبة خصائص الكومبوننت.
using System.Data; // مكتبة للتعامل مع الجداول والداتا.
using System.Data.Common; // مكتبة للتعامل مع قواعد البيانات بشكل عام.
using System.Drawing; // مكتبة الرسوميات (ألوان/صور).
using System.Linq; // مكتبة LINQ.
using System.Text; // مكتبة النصوص.
using System.Threading.Tasks; // مكتبة العمليات غير المتزامنة.
using System.Windows.Forms; // مكتبة تصميم الواجهات Windows Forms.

namespace ETEZAN2024.Presenters
{
    public class clsPersonPresenters
    {
        private clsPersons _Person;
        DataTable data;
        public clsPersonPresenters()
        {
            _Person = new clsPersons();
        }

        public DataView LoadPersonsPaged(int lastPersonID, int rowsNumber, string direction)
        {
            // جلب الأشخاص الذين لديهم PersonID أكبر من آخر شخص تم عرضه
            DataTable data = _Person.GetPersonsPaged(lastPersonID, rowsNumber,  direction);

            if (data == null || data.Rows.Count == 0)
                return null; // لا توجد بيانات

            return new DataView(data);
        }

    }
}