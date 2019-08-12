using System;
namespace Module {

    public class FileTimes {
        
        public FileTimes(DateTime ct, DateTime ut, DateTime at) {
            this.CreateTime = ct;
            this.UpdateTime = ut;
            this.AccessTime = at;
        }

        public DateTime CreateTime{ get; set; }
        public DateTime UpdateTime{ get; set; }
        public DateTime AccessTime{ get; set; }

    }
}