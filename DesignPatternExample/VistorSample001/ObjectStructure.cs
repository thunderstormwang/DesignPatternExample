using System.Collections.Generic;

namespace VistorSample001
{
    public class ObjectStructure
    {
        public List<IElement> Elements { get; set; }

        public ObjectStructure()
        {
            CreateElements();
        }

        private void CreateElements()
        {
            Elements = new List<IElement>();
            for (int i = 0; i < 5; i++)
            {
                Elements.Add(new ElementA() { X = i });
                Elements.Add(new ElementB() { Y = i + 10 });
            }
        }
    }
}