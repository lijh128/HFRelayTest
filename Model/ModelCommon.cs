using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RelayTest.Model
{
    public class GetLoginfoParams
    {
        private string _userId;
        private string _beginDateTime;
        private string _endDateTime;

        public GetLoginfoParams(string userId,
                                string beginDateTime,
                                string endDateTime)
        {
            _userId = userId;
            _beginDateTime = beginDateTime;
            _endDateTime = endDateTime;
        }

        public string UserId
        {
            get { return _userId; }
        }

        public string BeginDateTime
        {
            get { return _beginDateTime; }
        }

        public string EndDateTime
        {
            get { return _endDateTime; }
        }
    }
}
