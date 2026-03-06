
using BusinessLayeres;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using EtezanPrinting_Shared.Depts;
using System;

namespace EtezanPrinting.Test.TestClass
    {
        [TestClass]
        public sealed class DebtsTests
        {
            // 1. اختبار جلب كل الديون
            [TestMethod]
            public void GetAllDebtsList_WhenCalled_ShouldReturnMoreThanZero()
            {
                // Arrange: نحضر الغراض - نسوي نسخة من كلاس البزنس
                clsDebts debtService = new clsDebts();

                // Act: نشغل الماكنة - نستدعي دالة جلب كل القائمة
                var result = debtService.GetAllDebtsList();

                // Assert: نشيك النتيجة - نتأكد القائمة مو فارغة وبيهة بيانات حقيقية
                Assert.IsNotNull(result, "فشل: القائمة رجعت Null، اكو خلل بالربط!");
                Assert.IsTrue(result.Count > 0, "فشل: القائمة فارغة، الداتابيز مابيها ديون حالياً!");
            }

            // 2. اختبار البحث عن دين موجود فعلياً
            [TestMethod]
            public void Find_WhenDebtExists_ShouldReturnDebtDetails()
            {
                // Arrange: نحدد ID موجود عندك بالجدول (مثلاً 59)
                int existingId = 59;

                // Act: نستدعي دالة Find الاستاتك مباشرة باسم الكلاس (طريقة المحترفين)
                var result = clsDebts.Find(existingId);

                // Assert: نتأكد إن البيانات رجعت كاملة ومو Null
                Assert.IsNotNull(result, $"فشل: السجل رقم {existingId} موجود بالداتابيز بس الكود مالقاه!");
                Assert.AreEqual(existingId, result.DebtID, "فشل: الـ ID اللي رجع مو نفسه اللي بحثنا عنه!");
            }

            // 3. اختبار البحث عن دين "ما موجود" (حتى نضمن السيستم ما ينهار)
            [TestMethod]
            public void Find_WhenDebtDoesNotExist_ShouldReturnNull()
            {
                // Arrange: نختار رقم خيالي مستحيل يكون موجود
                int nonExistingId = 999999;

                // Act: نبحث عنه بالداتابيز
                var result = clsDebts.Find(nonExistingId);

                // Assert: لازم يرجع Null حتى نكدر نعالج الموضوع بـ MessageBox بالديسكتوب
                Assert.IsNull(result, "فشل: المفروض يرجع Null لسجل ما موجود، بس الكود رجع كائن!");
            }


        [TestMethod]
        public void AddNewDebt_WhenDataIsValid_ShouldReturnNewGeneratedID()
        {
            // 1. Arrange
            clsDebts newDebt = new clsDebts();
            newDebt.debtor_name = "حسن رعد";
            newDebt.debt_amount = 50000;
            newDebt.phone_number = "07700000000";
            newDebt.address = "البصرة - حي الحسين";
            newDebt.debt_date = DateTime.Now;

            // إهنا ركز وياي: لازم هاي الأرقام موجودة فعلياً بجداولك
            newDebt.users_id = 29;     // آيدي الموظف (حسن)
            newDebt.persons_id = 77;   // آيدي الشخص من جدول الأشخاص
            newDebt.orders_id = 352;  // آيدي الطلبية اللي عليها الدين

            newDebt.isActive = true;

            // 2. Act
            bool result = newDebt.Save();

            // 3. Assert
            Assert.IsTrue(result, "فشل: العملية ما تمت، شيك الـ Foreign Keys بالداتابيز!");
            Assert.AreNotEqual(-1, newDebt.DebtID, "فشل: السجل انحفظ بس ما استلمنا ID جديد!");
        }

        // اختبار الإضافة ببيانات ناقصة (حتى نشوف القوة مالت الكود)
        [TestMethod]
        public void AddNewDebt_WhenRequiredDataIsMissing_ShouldReturnNegativeOne()
        {
            // 1. Arrange: نسوي سجل "أعرج" بدون اسم (إذا كان الاسم مطلوب بالداتابيز)
            clsDebts badDebt = new clsDebts();
            badDebt.debtor_name = null; // نخليه نل حتى يضرب بالـ Procedure

            // 2. Act: نحاول نحفظ
            bool result = badDebt.Save();

            // 3. Assert: المفروض يفشل ويرجع false
            Assert.IsFalse(result, "فشل: الكود سمح بإضافة سجل بدون اسم! (لازم الـ Procedure يمنع هذا الشي)");
            Assert.AreEqual(-1, badDebt.DebtID, "فشل: السجل أخذ ID وهو أصلاً لازم يفشل!");
        }
        // 5. اختبار التحقق من وجود دين (isExist)
        [TestMethod]
            public void IsExist_WhenDebtExists_ShouldReturnTrue()
            {
                // Arrange: نختار ID نكون متأكدين منه
                int testId = 59;
                clsDebts debtService = new clsDebts();

                // Act: نشيك الوجود
                bool exists = debtService.isExist(testId);

                // Assert: لازم يرجع True
                Assert.IsTrue(exists, $"فشل: السجل {testId} موجود بس دالة isExist تكول ماكو!");
            }
        }
    }




