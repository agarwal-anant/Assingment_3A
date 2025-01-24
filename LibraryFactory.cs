using LMS.Models;

namespace LMS.Models
{
    public static class LibraryFactory
    {
        public static Library CreateLibrary()
        {
            return new Library();
        }
    }
}