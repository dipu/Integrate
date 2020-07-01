using Allors;

namespace Iseries
{
    public partial class Library
    {
        public static Library Create(AllorsSession session, string name)
        {
            var lib = session.Create<Library>();
            lib.Name = name;
            return lib;
        }

        public Program Find(AllorsSession session, string programname)
        {
            AllorsExtent<Program> programs = this.Programs;
            programs.Filter.AddEquals(AllorsDomains.IseriesDomain.ProgramName.Role, programname);
            return programs.First;
        }
    }
}
