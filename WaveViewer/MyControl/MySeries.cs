using System.Collections.Generic;

namespace WaveViewer.MyControl
{
    public class MySeries
    {
        public int begin, end;
        public float[] data;
        public int peek = -1;
        public void FindPeek()
        {
            List<point> peeks = new List<point>();
            for(int i = 1; i < data.Length - 1; i++)
            {
                if (data[i] > data[i - 1] && data[i] > data[i + 1])
                    peeks.Add(new point(i, data[i]));
            }
            point max=new point();
            foreach (var peek in peeks)
            {
                if (peek.value > max.value)
                    max = peek;
            }
            this.peek = max.index;
        }
        private struct point {
            public int index;
            public float value;
            public point(int i, float v)
            {
                this.index = i;
                this.value = v;
            }
        }
    }
}
