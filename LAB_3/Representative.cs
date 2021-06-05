namespace LAB_3
{
    class Representative
    {
        Race[] data;
        public Representative()
        {
            data = new Race[10];
        }
        public Race this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
}