using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleMan_After
{
    public class 중개자
    {
        public 고객 고객 { get; set; }
        public string Get마지막()
        {
            return 고객.Get주소().Get지역().Get마지막();
        }
    }
    public class 장사
    {
        public 중개자 중개자 { get; set; }
        public string getWhatever()
        {
            return 중개자.Get마지막();
        }
    }
    public class 고객
    {
        public 주소 주소 { get; set; }
        public 주소 Get주소()
        {
            return 주소;
        }
    }
    public class 주소
    {
        public 지역 지역 { get; set; }
        public 지역 Get지역()
        {
            return 지역;
        }
    }
    public class 지역
    {
        public string Get마지막()
        {
            return "충무로";
        }
    }
}
