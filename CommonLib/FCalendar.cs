using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Fadong.CommonLib {
    [Serializable]
    public class FCalendar : BObj {
        public FCalendar(string name, List<DateTime> holidays) {
            if (holidays == null || holidays.Count < 1) {
                throw new Exception("Holiday가 1개 이상이어야 합니다.");
            }
            DateTime fday = holidays.Min();
            DateTime lday = holidays.Max();
            FCalendarInit(name, fday, lday, holidays, default_nonbizday);
        }

        public FCalendar(string name, DateTime fday, DateTime lday, List<DateTime> holidays) {
            if (holidays == null || holidays.Count < 1) {
                throw new Exception("Holidays가 1개 이상이어야 합니다.");
            }
            FCalendarInit(name, fday, lday, holidays, default_nonbizday);
        }

        public FCalendar(string name, DateTime fday, DateTime lday, List<DateTime> holidays, List<DayOfWeek> nonbizday) {
            if (holidays == null || holidays.Count < 1) {
                throw new Exception("Holidays가 1개 이상이어야 합니다.");
            }
            FCalendarInit(name, fday, lday, holidays, nonbizday);
        }

        private void FCalendarInit(string name, DateTime fday, DateTime lday, List<DateTime> holidays, List<DayOfWeek> nbizday) {
            this.Name = name;
            this.FirstDay = fday;
            this.LastDay = lday;
            this.NonBizDay = nbizday;
            if (holidays.Count > 0) {
                this._holidays = holidays.OrderBy(k => k).ToList();
            }
        }

        public bool IsBizDay(DateTime dt) {
            bool rst = false;
            if (!_holidays.Contains(dt) && !NonBizDay.Contains(dt.DayOfWeek)) {
                rst = true;
            }
            return rst;
        }

        public DateTime BizDayOffset(int offset, FEnum BUSINESSDAY_CONVENTION) {

            return DateTime.Now;
        }

        

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime FirstDay { get; set; }
        public DateTime LastDay { get; set; }
        public List<DayOfWeek> NonBizDay { get; set; }

        public List<DateTime> Holidays {
            get { return this._holidays; }
        }

        List<DateTime> _holidays = new List<DateTime>();
        List<DayOfWeek> default_nonbizday = new List<DayOfWeek>() { DayOfWeek.Saturday, DayOfWeek.Sunday };
    }
}
