using Dormitory.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory.Class
{
    public class NewStart
    {
        static public void BaseCreation()
        {
            AppData.modelBD = new ModelBD();

            #region TUsers

            AppData.modelBD.TUsers.Add(new TUsers
            {
                Admin = false,
                Name = "user",
                Password = "user"
            });

            AppData.modelBD.TUsers.Add(new TUsers
            {
                Admin = true,
                Name = "admin",
                Password = "admin"
            });

            #endregion

            #region TStudents

            AppData.modelBD.TStudents.Add(new TStudents
            {
                FCs = "Лазарев Феликс",
                Men = true,
                NumberPhone = "68(194)840-68-56",
                NumberViolations = 0
            });

            AppData.modelBD.TStudents.Add(new TStudents
            {
                FCs = "Авдеев Ермолай Демьянович",
                Men = true,
                NumberPhone = "16(6003)420-35-04",
                NumberViolations = 0
            });

            AppData.modelBD.TStudents.Add(new TStudents
            {
                FCs = "Дьячков Гаянэ Иванович",
                Men = true,
                NumberPhone = "7(783)326-38-59",
                NumberViolations = 2
            });

            AppData.modelBD.TStudents.Add(new TStudents
            {
                FCs = "Павлов Модест Донатович",
                Men = true,
                NumberPhone = "11(97)918-43-98",
                NumberViolations = 1
            });

            AppData.modelBD.TStudents.Add(new TStudents
            {
                FCs = "Белова Нева Эдуардовна",
                Men = false,
                NumberPhone = "020(6759)815-20-11",
                NumberViolations = 0
            });

            AppData.modelBD.TStudents.Add(new TStudents
            {
                FCs = "Красильникова Юланта Вадимовна",
                Men = false,
                NumberPhone = "22(1991)864-84-38",
                NumberViolations = 1
            });

            #endregion

            #region TParents

            AppData.modelBD.TParents.Add(new TParents
            {
                FCs = "Рябова Августина",
                NumberPhone = "974(2667)112-05-88",
            });

            AppData.modelBD.TParents.Add(new TParents
            {
                FCs = "Горбачёва Эльвира",
                NumberPhone = "737(74)221-55-72",
            });

            AppData.modelBD.TParents.Add(new TParents
            {
                FCs = "Симонова Эжени",
                NumberPhone = "47(63)370-50-10",
            });

            AppData.modelBD.TParents.Add(new TParents
            {
                FCs = "Носова Земфира Рудольфовна",
                NumberPhone = "976(481)131-39-70",
            });

            AppData.modelBD.TParents.Add(new TParents
            {
                FCs = "Костина Ника Альбертовна",
                NumberPhone = "1(940)330-49-05",
            });

            AppData.modelBD.TParents.Add(new TParents
            {
                FCs = "Колесникова Гелана Аристарховна",
                NumberPhone = "956(904)964-09-38",
            });

            AppData.modelBD.TParents.Add(new TParents
            {
                FCs = "Новиков Осип Аристархович",
                NumberPhone = "609(5361)834-71-82",
            });

            AppData.modelBD.TParents.Add(new TParents
            {
                FCs = "Ефремов Алексей Филиппович",
                NumberPhone = "5(697)437-43-89",
            });

            AppData.modelBD.TParents.Add(new TParents
            {
                FCs = "Трофимов Донат Семенович",
                NumberPhone = "4(9153)666-00-42",
            });

            AppData.modelBD.TParents.Add(new TParents
            {
                FCs = "Жуков Натан Максимович",
                NumberPhone = "744(140)932-47-03",
            });

            AppData.modelBD.TParents.Add(new TParents
            {
                FCs = "Котов Овидий Антонович",
                NumberPhone = "537(803)605-74-76",
            });

            AppData.modelBD.TParents.Add(new TParents
            {
                FCs = "Моисеев Мечислав Тарасович",
                NumberPhone = "2(54)595-91-96",
            });

            #endregion

            AppData.modelBD.SaveChanges();

            #region TParentsStudents

            AppData.modelBD.TParentsStudents.Add(new TParentsStudents
            {
                IdParents = 1,
                IdStudents = 1,
            });

            AppData.modelBD.TParentsStudents.Add(new TParentsStudents
            {
                IdParents = 2,
                IdStudents = 2,
            });

            AppData.modelBD.TParentsStudents.Add(new TParentsStudents
            {
                IdParents = 3,
                IdStudents = 3,
            });

            AppData.modelBD.TParentsStudents.Add(new TParentsStudents
            {
                IdParents = 4,
                IdStudents = 4,
            });

            AppData.modelBD.TParentsStudents.Add(new TParentsStudents
            {
                IdParents = 5,
                IdStudents = 5,
            });

            AppData.modelBD.TParentsStudents.Add(new TParentsStudents
            {
                IdParents = 6,
                IdStudents = 6,
            });

            AppData.modelBD.TParentsStudents.Add(new TParentsStudents
            {
                IdParents = 7,
                IdStudents = 1,
            });

            AppData.modelBD.TParentsStudents.Add(new TParentsStudents
            {
                IdParents = 8,
                IdStudents = 2,
            });

            AppData.modelBD.TParentsStudents.Add(new TParentsStudents
            {
                IdParents = 9,
                IdStudents = 3,
            });

            AppData.modelBD.TParentsStudents.Add(new TParentsStudents
            {
                IdParents = 10,
                IdStudents = 4,
            });

            AppData.modelBD.TParentsStudents.Add(new TParentsStudents
            {
                IdParents = 11,
                IdStudents = 5,
            });

            AppData.modelBD.TParentsStudents.Add(new TParentsStudents
            {
                IdParents = 12,
                IdStudents = 6,
            });

            #endregion

            AppData.modelBD.SaveChanges();
        }
    }
}
