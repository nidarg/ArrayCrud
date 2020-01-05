namespace ArrayCRUD
{
    public class SortedIntArray : IntArray
    {
        public SortedIntArray() : base()
        {
        }

        public override int this[int index]
        {
            get => base[index];
            set
                {
                if (!VerifyIfSortedAtSetElement(index, value))
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
            if (!VerifyIfSortedAtInsertElement(index, element))
            {
                return;
            }

            base.Insert(index, element);
        }

        private bool VerifyIfSortedAtSetElement(int index, int element)
        {
            if ((index == 0 && element <= base[index + 1]) || (index == Count && element >= base[index - 1]))
            {
                return true;
            }

            if (element >= base[index - 1] && element <= base[index + 1])
            {
                return true;
            }

            return false;
        }

        private bool VerifyIfSortedAtInsertElement(int index, int element)
        {
            if ((index == 0 && element <= base[index + 1]) || (index == Count && element >= base[index - 1]))
            {
                return true;
            }

            if (element >= base[index - 1] && element <= base[index])
            {
                return true;
            }

            return false;
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
