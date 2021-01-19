using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftWareProjectManage.Entity
{
    public class SoftwareProject
    {
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ProjectName { get; set; }
        public ProgrammeLanguage Language { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastSaveTime { get; set; }
        

        public SoftwareProject()
        {

        }

        public SoftwareProject(string _projectName, ProgrammeLanguage _language)
        {
            ProjectName = _projectName;
            CreateTime = DateTime.Now;
            Language = _language;
        }

        public DateTime Save()
        {
            DateTime dateTime = DateTime.Now;

            return dateTime;
        }
    }
}
