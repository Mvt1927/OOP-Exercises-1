namespace Exercise_3
{
    /// <summary>
    /// This is class Song
    /// </summary>
    class Song{
        private string typeList="";//field typeList
        private string name="";//field name
        private string time="";//field time

        /// <summary>
        /// Property for TypeList
        /// </summary>
        public string TypeList{
            get{return typeList;}
            set{typeList=value;}
        }

        /// <summary>
        /// Property for Name
        /// </summary>
        public string Name{
            get{return name;}
            set{name=value;}
        }

        /// <summary>
        /// Property for Time
        /// </summary>
        public string Time{
            get{return time;}
            set{time=value;}
        }
        
        /// <summary>
        /// Default constuctor
        /// </summary>
        public Song(){
            this.typeList="";
            this.name="";
            this.time="";
        }

        /// <summary>
        /// Constructor with 3 argument
        /// </summary>
        /// <param name="typeList"></param>
        /// <param name="name"></param>
        /// <param name="time"></param>
        public Song(string typeList, string name, string time){
            this.typeList=typeList;
            this.name=name;
            this.time=time;
        }
    }
}