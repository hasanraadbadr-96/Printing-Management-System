using BusinessLayeres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtezanPrinting.Test.TestClass
{
    [TestClass] // أضف هذا السطر هنا
    public class UserTest
    {
        clsUsers User = new clsUsers();
        // 1. اختبار جلب قائمة المستخدمين
        [TestMethod]
        public void GetAllUsers_WhenCalled_ShouldReturnList()
        {

            // Act: نستدعي الدالة مباشرة لأنها Static (شغل محترفين)
            var users = User.GetAllUsersList();

            // Assert: نشيك النتيجة
            Assert.IsNotNull(users, "فشل: القائمة رجعت Null، شيك اتصال الداتابيز!");
            // إذا عندك مستخدمين فعلياً، فعل السطر الجوه
            // Assert.IsTrue(users.Count > 0, "التحذير: القائمة فارغة، ماكو مستخدمين بالجدول.");
        }

        [TestMethod]
        // اسم الدالة يوضح: جاي نفحص البحث بالـ ID، في حال المستخدم موجود، لازم يرجع كائن مو فارغ
        public void FindUserById_WhenUserExists_ShouldReturnValidUsersDTO()
        {
            // Arrange: نجهز رقم مستخدم نعرفه موجود بالداتابيز مالت مطبعة إتقان
            int existingUserId = 29;

            // Act: "هجمة مرتدة" - نستدعي دالة البزنس مباشرة لأنها Static مثل ما كلت (شغل نظيف)
            var userResult = clsUsers.FindUserById(existingUserId);

            // Assert: مرحلة "التأكد"
            // 1. نشيك: هل السلة رجعت مليانة؟ إذا Null يعني اكو مشكلة بالاتصال أو الرقم غلط
            Assert.IsNotNull(userResult, "فشل: المستخدم موجود بالداتابيز بس الدالة رجعت Null!");

            // 2. (إضافة للمحترفين): نشيك هل الـ ID اللي رجع هو نفسه اللي طلبناه؟
            Assert.AreEqual(existingUserId, userResult.UserID, "فشل: الدالة رجعت مستخدم بس مو نفس الـ ID المطلوب!");
        }

        [TestMethod]
        public void AddNewUser_WhenDataIsValid_ShouldReturnValidID()
        {
            // Arrange: نجهز بيانات مستخدم وهمي جديد للفحص
            // ملاحظة: اختار PersonID موجود فعلياً بجدول الأشخاص عندك
            var newUser = new clsUsers();
            newUser.UserName = "TestUser_" + Guid.NewGuid().ToString().Substring(0, 5); // اسم فريد حتى ما يتكرر
            newUser.Password = "Test@123";
            newUser.PersonID = 77; // تأكد إن هذا الآيدي موجود بجدول الأشخاص
            newUser.PermissionID = 1;
            newUser.isActive = true;

            // Act: نحاول نحفظ المستخدم الجديد
            // ملاحظة: دالة الـ Save هي اللي راح تستدعي AddNewUser داخلياً
            bool isSaved = newUser.Save();

            // Assert: مرحلة التحقق من النجاح
            // 1. نتأكد إن عملية الحفظ رجعت true
            Assert.IsTrue(isSaved, "فشل: عملية الحفظ لم تتم بنجاح!");

            // 2. نتأكد إن الداتابيز انطت آيدي جديد مو -1
            Assert.IsTrue(newUser.UserID > 0, $"فشل: تم الحفظ ولكن لم يتم استلام UserID جديد. القيمة الحالية: {newUser.UserID}");

            // لمسة إضافية: اطبع الآيدي بالـ Output مالت التيست حتى تشوفه
            Console.WriteLine($"تمت إضافة المستخدم بنجاح بالمعرف رقم: {newUser.UserID}");
        }

        [TestMethod]

        // اسم الدالة: "تحديث مستخدم_عندما تكون البيانات صحيحة_يجب أن يرجع معرف صالح"
        public void UpdateUser_WhenDataIsValid_ShouldReturnValidID()
        {
            bool isSaved = false;

            // Arrange: مرحلة "التحضير" - نجيب مستخدم موجود أصلاً بالداتابيز مالت مطبعة إتقان
            clsUsers newUser = clsUsers.FindUserById(35);

            if (newUser != null)
            {
                // نغير معلوماته حتى نشوف البرنامج يكدر يحدثها لو لا
                // الـ Guid.NewGuid: هاي حركة ذكية منك حتى تضمن الاسم ما يتكرر وتضرب الداتابيز (Unique Constraint)
                newUser.UserName = "TestUser_" + Guid.NewGuid().ToString().Substring(0, 5);
                newUser.Password = "Test@123";
                newUser.PersonID = 77; // تأكد إن "أبو غيرة" (الرقم 77) موجود بجدول الأشخاص
                newUser.PermissionID = 1;
                newUser.isActive = false;

                // Act: مرحلة "التنفيذ" - نكول له "يا بطل احفظ التغييرات"
                // الـ Save() هنا هي العقل؛ شافت الـ ID موجود (35)، فقررت تسوي Update مو Add
                isSaved = newUser.Save();
            }
            else
            {
                isSaved = false; // إذا أصلاً مالكينا رقم 35، التيست راح يفشل وهذا هو الصحيح
            }

            // Assert: مرحلة "الاستجواب" - نتأكد الشغل صار لو لغوة زايدة
            // 1. "احلف!" - نتأكد إن الـ Save رجعت True يعني الداتابيز وافقت على التعديل
            Assert.IsTrue(isSaved, "فشل: عملية الحفظ لم تتم بنجاح!");

            // 2. "شوف لي الرقم" - نتأكد إن المستخدم بعده عنده ID حقيقي (مو -1 أو صفر)
            Assert.IsTrue(newUser.UserID > 0, $"فشل: تم الحفظ ولكن المعرف ضاع! القيمة: {newUser.UserID}");

            // طبعة أخيرة حتى المبرمج يرتاح قلبه ويشوف النتيجة بالشاشة
            Console.WriteLine($"تمت إضافة أو تحديث المستخدم بنجاح بالمعرف رقم: {newUser.UserID}");
        }



        // اسم الدالة: "تحديث مستخدم_عندما تكون البيانات صحيحة_يجب أن يرجع معرف صالح"
        [TestMethod]

        public void DeleteUser_WhenUserExists_ShouldReturnTrue()
        {
            // Arrange: نحدد ID موجود فعلاً (تأكد من الرقم المكتوب هنا)
            int userIdToDelete = 37;

            // Act: نفذ الحذف
            bool isDeleted = User.DeleteUserById(userIdToDelete);

            // Assert: مرحلة التأكد
            // 1. نتأكد إن الدالة رجعت True (يعني الـ RowCount بالـ SQL جان 1)
            Assert.IsTrue(isDeleted, $"فشل الحذف: المعرف {userIdToDelete} غير موجود أو اكو مشكلة بالـ SQL.");

            // 2. الفحص القاضي: نشيك الوجود (لازم يرجع False)
            // نستخدم Assert.IsFalse لأن دالة isExist ترجع bool مو كائن
            bool existsAfterDelete = User.isExistUser(userIdToDelete);

            Assert.IsFalse(existsAfterDelete, "فشل: الدالة كلت انحذف، بس بعده موجود بالداتابيز!");

            Console.WriteLine($"تم التأكد: المستخدم رقم {userIdToDelete} انمسح نهائياً.");
        }
    }
}
