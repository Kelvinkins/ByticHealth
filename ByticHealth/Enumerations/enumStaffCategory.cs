using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByticHealth.Enumerations
{
    enum enumStaffCategory
    {
        NA = 0,
        Doctor = 1,
        Nurse=2,
        Pharmacy=3,
        Reception=4,
        Laboratory=5,
        Admission=6
    }

    enum enumMaritalStatus
    {
        NA = 0,
        Single = 1,
        Married=2,
        Divorced=3,
        Widowed=4
    }
    enum enumSex
    {
        NA=0,
        Male=1,
        Female=2,
        Unknown=3
    }
    enum enumPatientType
    {
        NA = 0,
        InPatient = 1,
        OutPatient2
    }

    enum enumRelationType
    {
        NA = 0,
        Mother = 1,
        Father=2,
        Child=3,
        Uncle=4,
        Aunty=5,
        Niece=6,
        Nephew=7,
        Brother=8,
        Sister=9,
        Hosband=10,
        Wife=11,
        Boyfriend=12,
        Girlfriend=13,
        Employer=14,
        Employee=15,
        Athoney=16,
        Other=17
    }
}
