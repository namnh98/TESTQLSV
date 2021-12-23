using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTQLSV
{
    class SINHVIEN
    {
        
        private string _HoTen;
        private string _MSSV;
        private double _DQT;
        private double _DKT;

        public string HoTen
        {
            get
            {
                return _HoTen;
            }
            set
            {
                _HoTen = value;
            }
        }
        public string MSSV
        {
            get
            {
                return _MSSV;
            }
            set
            {
                _MSSV = value;
            }
        }
        public double DQT
        {
            get
            {
                return _DQT;
            }
            set
            {
                _DQT = value;
            }
        }
        public double DKT
        {
            get
            {
                return _DKT;
            }
            set
            {
                _DKT = value;
            }
        }
        public double DTK()
        {
            return _DQT * 0.3 + _DKT * 0.7;
        }

    }
}
