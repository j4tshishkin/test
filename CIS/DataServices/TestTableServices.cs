using DataAccess;
using DataServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices
{
    public class TestTableServices
    {
        DataBaseModel context = new DataBaseModel();

        public List<TestStructure> GetTestStructure()
        {
            var t = context.TableForTest.ToList();
            List<TestStructure> res = new List<TestStructure>();
            for (int i = 0; i < t.Count ; ++i)
            {
                res.Add(new TestStructure() {FieldOne= t[i].FieldOne, FieldTwo= t[i].FieldTwo });
            }
            return res;
        }
    }
}
