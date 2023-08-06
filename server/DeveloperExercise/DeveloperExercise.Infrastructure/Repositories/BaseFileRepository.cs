using DeveloperExercise.Domain.Configurations;
using Microsoft.Extensions.Options;

namespace DeveloperExercise.Infrastructure.Repositories
{
    public class BaseFileRepository
    {
        protected readonly string _filePath;

        public BaseFileRepository(IOptions<FileBasedDatabaseOptions> fileBasedDatabaseOptions)
        {
            _filePath = fileBasedDatabaseOptions.Value.FileLocation;
        }
    }
}
