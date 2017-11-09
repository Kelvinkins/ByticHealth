using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByticHealth.Enumerations
{
    enum AptStatus
    {
        Select = 0,
        Open = 1,
        Closed=2,
        Cancelled=3,
        Absent=4
    }



    enum WardType
    {
        Select=0,
        Ward = 1,
        Room=2
   
    }

    enum BedStatus
    {
        Select = 0,
        Available = 1,
       Unavailable=2
    }


    enum PatientType
    {
        Select = 0,
        IPD = 1,
        OPD = 2
    }

    enum DischargeMethod
    {
        Select = 0,
        CD = 1,
        SD = 2
    }

    enum AdmissionMethod
    {
        Select=0,
        Elective=1,
        Emmergency=2,
        Transfer=3,
        NA=4
    }
}
