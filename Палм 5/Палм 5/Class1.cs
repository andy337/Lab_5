using System;

namespace struct_lab_student
{
    struct Student
    {
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public string dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;
        public Student(string lineWithAllData)
        {
            string[] arrwithdata = lineWithAllData.Replace("-","2").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            surName = arrwithdata[0];
            firstName = arrwithdata[1];
            patronymic = arrwithdata[2];
            sex = char.Parse(arrwithdata[3]);
            dateOfBirth = arrwithdata[4];
            mathematicsMark = char.Parse(arrwithdata[5]);
            physicsMark = char.Parse(arrwithdata[6]);
            informaticsMark = char.Parse(arrwithdata[7]);
            scholarship = int.Parse(arrwithdata[8]);
        }
    }
}