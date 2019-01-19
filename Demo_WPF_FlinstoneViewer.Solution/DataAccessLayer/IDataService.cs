using Demo_WPF_FlintstoneViewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_WPF_FlintstoneViewer.DataAccessLayer
{
    public interface IDataService
    {
        List<Character> ReadAll();
        void WriteAll(List<Character> characters);
    }
}
