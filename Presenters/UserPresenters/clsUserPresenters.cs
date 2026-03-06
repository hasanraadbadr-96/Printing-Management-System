using BusinessLayeres; // الطبقة اللي بيها كلاس clsUsers
using EtezanPrinting_Shared.UsersDTO;
using System;
using System.Collections.Generic;

namespace ETEZAN2024.Presenters.UserPresenters
{
    public class clsUserPresenters
    {
        // 1. تعريف كائن من طبقة المستخدمين (المسؤول عن جلب البيانات)
        private readonly clsUsers _Users = new clsUsers();

        // 2. دالة جلب المستخدمين بنظام الصفحات (نفس طريقة البيرسون)
        public List<UsersDTO> LoadUsersList()
        {
            // نكول للداتابيز: "جيب لي الـ 10 مستخدمين اللي ورا هذا الرقم"
            List<UsersDTO> usersList = _Users.GetAllUsersList();

            // إذا السجل خلص وماكو بيانات، نرجع null
            if (usersList == null || usersList.Count == 0)
                return null;

            return usersList;
        }
    }
}