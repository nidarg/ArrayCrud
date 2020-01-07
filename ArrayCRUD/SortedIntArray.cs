namespace ArrayCRUD
{
    public class SortedIntArray : IntArray
    {
        const bool InsertVerify = true;
        const bool SetVerify = true;

        public SortedIntArray() : base()
        {
        }

        public override int this[int index]
        {
            get => base[index];
            set
            {
                if (!VerifyIfSorted(index, value) || VerifyIfSorted(index, value) != SetVerify)
                {
                    return;
                }

                base[index] = value;
            }
        }

        public bool VerifyIfSortedAtAdd(int element)
        {
            return element >= base[Count - 1];
        }

        public override void Add(int element)
        {
            base.Insert(FindRightPosition(element), element);
        }

        public override void Insert(int index, int element)
        {
            if (!VerifyIfSorted(index, element) || VerifyIfSorted(index, element) != InsertVerify)
            {
                return;
            }

            base.Insert(index, element);
        }

        private bool VerifyIfSorted(int index, int element)
        {
            if ((index == 0 && element <= base[index + 1]) || (index == Count && element >= base[index - 1]))
            {
                return true;
            }
            else if (element >= base[index - 1] && element <= base[index])
            {
                return InsertVerify;
            }
            else if (element >= base[index - 1] && element > base[index] && element <= base[index + 1])
            {
                return SetVerify;
            }
            else
            {
                return false;
            }
        }

        private int FindRightPosition(int element)
        {
            if (Count == 0)
            {
                return Count;
            }

            for (int i = 0; i < Count; i++)
            {
                if (element <= base[i])
                {
                    return i;
                }
            }

            return Count;
        }
    }
}
